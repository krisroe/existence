<?php
require_once __DIR__ . '/secrets.php';
function get_access_token() {
	$accessToken = "";
	$errorMessage = "";
	if (isset($_GET['code']))
	{
        $redirectUri = "{protocol}://{server}/adminredirect.php";
		$data = array(
		'grant_type' => 'authorization_code',
		'code' => $_GET['code'],
		'client_id' => getSecrets()['OAUTH_CLIENT_ID'],
		'client_secret' => getSecrets()['OAUTH_CLIENT_SECRET'],
		'redirect_uri' => $redirectUri
		);
		$options = array(
		'http' => array(
		 'method' => 'POST',
	     'header' => 'Content-type: application/x-www-form-urlencoded',
	     'content' => http_build_query($data)
		 )
		);
		$context = stream_context_create($options);
		$response = file_get_contents("https://www.googleapis.com/oauth2/v4/token", false, $context);
		$json = json_decode($response, true);
		if ($json === null)
		{
			$errorMessage = "Failed to decode access token JSON";
		}
		else
		{
			if (isset($json['access_token']))
			{
				$accessToken = $json['access_token'];
			}
			else	
			{
				$errorMessage = "Access token not found in response.";
			}	
		}
	}
	else
	{
		$errorMessage = "No Access Token Received";
	}
	return [$errorMessage,$accessToken];
}

echo "<html>";

echo "<head>";
echo "<title>Admin Redirect</title>";
echo "<link rel=\"stylesheet\" href=\"";
echo "{stylefilename}";
echo "\">";
echo "<link rel=\"icon\" type=\"image/png\" href=\"destroyallpugz.png\"/>";
echo "</head>";

echo "<body>";
echo "<h4><a href=\"../index.html\">Home</a></h4>";

echo "<h2>";
$result = get_access_token();
if ($result[0] === "")
{
	$access_token = $result[1];

	//get videos to update
	$videos = [];	
	$dbconn = connectToDatabase();
	$query = 'SELECT id,youtubeid,dislikes,likes FROM public.videos';
	$result = pg_query($dbconn,$query);
	while ($row = pg_fetch_assoc($result)) {
		array_push($videos,[$row['id'],$row['youtubeid'],$row['dislikes'],$row['likes']]);
	}
	pg_free_result($result);
	pg_close($dbconn);
	
	$count = 0;
	$gainedlikes = 0;
	$gaineddislikes = 0;
	$lostlikes = 0;
	$lostdislikes = 0;
	$videos_to_update = [];
	foreach ($videos as $v)
	{
		$id = $v[0];
		$youtubeid = $v[1];
		$olddislikes = $v[2];
		if (!isset($olddislikes))
		{
			$olddislikes = 0;
		}
		$oldlikes = $v[3];
		if (!isset($oldlikes))
		{
			$oldlikes = 0;
		}
		$newdislikes = 0;		
		$newlikes = 0;
		$found = false;
		
		$options = array(
		 'http' => array(
		   'header' => "Authorization: Bearer " . $access_token
		  )
		);
		
		$context = stream_context_create($options);
		$response = file_get_contents("https://www.googleapis.com/youtube/v3/videos?part=statistics&id=" . $youtubeid, false, $context);
		
		$json = json_decode($response, true);
		if (!($json === null) && isset($json["items"]))
		{
			$items = $json["items"];
			if (count($items) > 0)
			{
				$item = $items[0];
				if (isset($item["statistics"]))
				{
					$statistics = $item["statistics"];
					if (isset($statistics["dislikeCount"]) && isset($statistics["likeCount"]))
					{
						$newdislikes = intval($statistics["dislikeCount"]);
						$newlikes = intval($statistics["likeCount"]);
						if ($newdislikes > $olddislikes)
						{
							$gaineddislikes = $gaineddislikes + $newdislikes - $olddislikes;
						}
						else if ($newdislikes < $olddislikes)
						{
							$lostdislikes = $lostdislikes + $olddislikes - $newdislikes;
						}
						if ($newlikes > $oldlikes)
						{
							$gainedlikes = $gainedlikes + $newlikes - $oldlikes;
						}
						else
						{
							$lostlikes = $lostlikes + $oldlikes - $newlikes;
						}
						array_push($videos_to_update, [$id, $youtubeid, $newdislikes, $newlikes]);
						$found = true;
					}
				}
			}
		}
		if (!$found)
		{
			echo "Failed to retrieve statistics for " . $youtubeid . "<br/>";			
		}
	}
	if (count($videos_to_update) > 0)
	{
		$dbconn = connectToDatabase();
		foreach ($videos_to_update as $v)
		{
			$query = "UPDATE videos SET dislikes=" . $v[2] . ",likes=" . $v[3] . " WHERE id=" . $v[0];
			$updateresult = pg_query($dbconn,$query);
			if ($updateresult)
			{
				$count++;
			}
			else
			{
				echo "Failed to update statistics for " . $v[1] . "<br/>";
			}
		}
		$query = "INSERT INTO dates (id,videos_last_refreshed) VALUES (1, CURRENT_TIMESTAMP) ON CONFLICT (id) DO UPDATE SET videos_last_refreshed = EXCLUDED.videos_last_refreshed";
		pg_query($dbconn,$query);
		pg_close($dbconn);
	}

	//load publish timestamps for videos that are missing them, up to 50 videos per API call
	$publishedcount = 0;
	$missing = []; //youtube id => database id
	$dbconn = connectToDatabase();
	$query = 'SELECT id,youtubeid FROM public.videos WHERE published_timestamp IS NULL';
	$result = pg_query($dbconn,$query);
	while ($row = pg_fetch_assoc($result)) {
		$missing[$row['youtubeid']] = $row['id'];
	}
	pg_free_result($result);
	foreach (array_chunk(array_keys($missing), 50) as $chunk)
	{
		$options = array(
		 'http' => array(
		   'header' => "Authorization: Bearer " . $access_token
		  )
		);
		$context = stream_context_create($options);
		$response = file_get_contents("https://www.googleapis.com/youtube/v3/videos?part=snippet&maxResults=50&id=" . urlencode(implode(',', $chunk)), false, $context);

		$updated = [];
		$json = json_decode($response, true);
		if (!($json === null) && isset($json["items"]))
		{
			foreach ($json["items"] as $item)
			{
				if (isset($item["id"]) && isset($missing[$item["id"]]) && isset($item["snippet"]["publishedAt"]))
				{
					$updateresult = pg_query_params($dbconn, 'UPDATE videos SET published_timestamp=$1 WHERE id=$2', [$item["snippet"]["publishedAt"], $missing[$item["id"]]]);
					if ($updateresult)
					{
						$publishedcount++;
						$updated[$item["id"]] = true;
					}
				}
			}
		}
		foreach ($chunk as $youtubeid)
		{
			if (!isset($updated[$youtubeid]))
			{
				echo "Failed to retrieve publish timestamp for " . $youtubeid . "<br/>";
			}
		}
	}
	pg_close($dbconn);

	echo $count . " videos updated with likes/dislikes.";
	echo "<br/>";
	echo $publishedcount . " videos updated with publish timestamps.";
	echo "<br/>";
	echo $gaineddislikes . " dislikes gained.";
	echo "<br/>";
	echo $lostdislikes . " dislikes lost.";
	echo "<br/>";
	echo $gainedlikes . " likes gained.";
	echo "<br/>";
	echo $lostlikes . " likes lost.";
}
else
{
	echo $result[0]; //error message
}
echo "</h2>";

echo "</body>";
echo "</html>";
?>