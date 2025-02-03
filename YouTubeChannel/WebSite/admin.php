<?php
echo "<html>";

echo "<head>";
echo "<title>Admin</title>";
echo "<link rel=\"stylesheet\" href=\"";
echo "{stylefilename}";
echo "\">";
echo "<link rel=\"icon\" type=\"image/png\" href=\"destroyallpugz.png\"/>";
echo "</head>";

echo "<body>";
echo "<h4><a href=\"../index.html\">Home</a></h4>";

$dbconn = pg_connect("{pgconnstr}");
$query = 'SELECT videos_last_refreshed FROM public.dates WHERE id=1';
$result = pg_query($dbconn,$query);

echo "<h4>";
if (pg_num_rows($result) == 0)
{
	echo "Videos never refreshed";
}
else	
{
	$row = pg_fetch_row($result);
	$nowutc = new DateTime('now', new DateTimeZone('UTC'));
	$refreshedutc = new DateTime($row[0]);
	$interval = $refreshedutc->diff($nowutc);
	echo $interval->format('Last refreshed %d days, %h hours, %i minutes, %s seconds ago');
}
pg_free_result($result);
pg_close($dbconn);
echo "</h4>";

echo "<a href=\"https://accounts.google.com/o/oauth2/v2/auth?client_id=";
echo "{oauthclientid}";
echo "&response_type=code&scope=https://www.googleapis.com/auth/youtube&redirect_uri={protocol}://";
echo "{server}/adminredirect.php\"><button>Push Me!</button></a>";

echo "</body>";
echo "</html>";
?>