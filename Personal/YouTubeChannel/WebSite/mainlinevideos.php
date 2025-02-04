<?php
echo "<html>";

echo "<head>";
echo "<title>Main Line Videos</title>";
echo "<link rel=\"stylesheet\" href=\"";
echo "{stylefilename}";
echo "\">";
echo "<link rel=\"icon\" type=\"image/png\" href=\"destroyallpugz.png\"/>";
echo "</head>";

echo "<body>";

echo "<div id=\"homecontainer\">";
echo "<p id=\"homelink\"><a href=\"../index.html\">Home</a></p>";
echo "<div id=\"playvideotopcontent\">";
echo "<div class=\"playvideotopcontentitem\"><a class=\"hidden\" id=\"playvideostop\" href=\"javascript:void(0);\" onclick=\"doStopVideo()\">Stop</a></div>";
echo "<div class=\"playvideotopcontentitem\"><p class=\"hidden\" title=\"My site link URL (do you really want to send users to my site?)\" id=\"playvideomysitelink\"></p></div>";
echo "<div class=\"playvideotopcontentitem\"><a class=\"hidden\" title=\"YouTube link URL (do you really want to send users to YouTube?). Go to YouTube to DISLIKE my video!\" id=\"playvideoyoutubelink\"></a></div>";
echo "</div>"; //end playvideotopcontent
echo "</div>"; //end homecontainer

echo <<<EOT
<script>
var videoids = [];
	  
var player;
var currentVideoId = 0;
		
function playall()
{
 videoids = allvideoids;
 doPlayVideoList();			
}

function onYouTubeIframeAPIReady() {
 player = new YT.Player('player', {
  height: '100%',
  width: '100%',
  events: {
   'onStateChange': onPlayerStateChange
  }
 });
}

function onPlayerStateChange(event) {
 if (event.data == YT.PlayerState.ENDED) {
  currentVideoId++;
  if (currentVideoId < videoids.length) {
   setCurrentVideo(videoids[currentVideoId]);
  }
  else {
	returnUIToMainContent();
  }
 }
}

function doStopVideo() {
	player.stopVideo();
	returnUIToMainContent();
}

function returnUIToMainContent()
{
 currentVideoId = 0;
 videoids = [];
 var tableelement = document.getElementById('maininfodiv');
 tableelement.classList.remove('hidden');
 var playvideoelements = ['playvideostop','playvideomysitelink','playvideoyoutubelink'];
 playvideoelements.forEach(function(elementid) {
  var playvideotopcontentelement = document.getElementById(elementid);
  playvideotopcontentelement.classList.add('hidden');
 });
 var playercontainerelement = document.getElementById('playercontainer');
 playercontainerelement.style.display = 'none';
}
		
function doPlayVideo(videoid) {
 videoids = [];
 videoids.push(videoid);
 doPlayVideoList();
}

function doPlayVideoList() {
 var tableelement = document.getElementById('maininfodiv');
 tableelement.classList.add('hidden');
 var playvideoelements = ['playvideostop','playvideomysitelink','playvideoyoutubelink'];
 playvideoelements.forEach(function(elementid) {
   var playvideotopcontentelement = document.getElementById(elementid);
   playvideotopcontentelement.classList.remove('hidden');
 });
 var playercontainerelement = document.getElementById('playercontainer');
 playercontainerelement.style.display = 'block';
 currentVideoId = 0;
 setCurrentVideo(videoids[0]);
 player.playVideo();
}

function setCurrentVideo(videoid)
{
 var linkelement1 = document.getElementById('playvideoyoutubelink');
 linkelement1.textContent = 'https://www.youtube.com/watch?v=' + videoid;
 linkelement1.href = 'https://www.youtube.com/watch?v=' + videoid;
 var linkelement2 = document.getElementById('playvideomysitelink');
 linkelement2.textContent = '{protocol}://{server}/donotclick.php?youtubeid=' + videoid; 
 player.loadVideoById(videoid);
}

</script>
EOT;

echo "<div id=\"playercontainer\">";
echo "<div id=\"player\">";
echo "</div>";
echo "</div>";
echo "<script src=\"https://www.youtube.com/iframe_api\"></script>";
echo "<div id=\"maininfodiv\">";
echo "<button id=\"playall\" onclick=\"playall()\">Play All</button>";
echo "<table>";
echo "<tr><th>Episode</td><th>Short Name</th><th>Owner</th><th>Theme</th><th>Audience</th><th>Major Rulez</th><th>Meme(s)</th><th>Minor Rulez</th><th>Additional</th><th>Dislikes</th><th>Likes</th></tr>";

$dbconn = pg_connect("{pgconnstr}");
$query = 'SELECT v.youtubeid,ml.episode,v.owner,ml.theme,ml.audience,ml.majorrulez,ml.memes,ml.minorrulez,dtxt.purpose,dtxt.googledrivefileid txtfileid,dmusx.googledrivefileid musxfileid,v.dislikes,v.likes,v.shortname FROM public.videolist_mainline ml INNER JOIN public.videos v ON ml.videoid = v.id LEFT JOIN documents dtxt ON v.additionaltextdocumentid = dtxt.id LEFT JOIN documents dmusx ON v.musxdocumentid = dmusx.id ORDER BY ml.ord';
$result = pg_query($dbconn,$query);

$allvideoids = null;

while ($row = pg_fetch_assoc($result)) {
 $txtfileid = $row['txtfileid'];
 $musxfileid = $row['musxfileid'];
 $hastxt = !empty($txtfileid);
 $hasmusx = !empty($musxfileid);
 $youtubeid = $row['youtubeid'];
 if ($allvideoids === null)
 {
	 $allvideoids = "'" . $youtubeid . "'";
 }
 else	 
 {
	 $allvideoids = $allvideoids . ",'" . $youtubeid . "'";
 }
 echo "<tr>";
 echo "<td>";
 echo $row["episode"];
 echo "</td>";
 echo "<td>";
 echo "<a href=\"javascript:void(0);\" onclick=\"doPlayVideo('";
 echo $row["youtubeid"];
 echo "')\">";
 echo $row["shortname"];
 echo "</a>";
 echo "</td>";
 echo "<td>";
 echo $row["owner"];
 echo "</td>";
 echo "<td>";
 echo $row["theme"];
 echo "</td>";
 echo "<td>";
 echo $row["audience"];
 echo "</td>";
 echo "<td>";
 echo $row["majorrulez"];
 echo "</td>";
 echo "<td>";
 echo $row["memes"];
 echo "</td>";
 echo "<td>";
 echo $row["minorrulez"];
 echo "</td>";
 echo "<td>";
 echo "<a href=\"videotextinfo.php?youtubeid=";
 echo $youtubeid;
 echo "&return=mainlinevideos&doctype=viddesc\">Description</a>";
 if ($hastxt)
 {
  echo "<br/>";
  echo "<a href=\"videotextinfo.php?youtubeid=";
  echo $youtubeid;
  echo "&doctype=gdrtxt&return=mainlinevideos\">";
  $purpose = $row['purpose'];
  if ($purpose == 1)
  {
	  echo "Transcript";
  }
  else if ($purpose == 3)
  {
	  echo "Transcript+Commentary";
  }
  echo "</a>";
 }
 if ($hasmusx)
 {
  echo "<br/>";
  echo "<a href=\"https://drive.google.com/file/d/";
  echo $musxfileid;
  echo "\">MUSX</a>";
 }
 echo "</td>";
 echo "<td>";
 echo $row["dislikes"];
 echo "</td>";
 echo "<td>";
 echo $row["likes"];
 echo "</td>";
 echo "</tr>";
}

pg_free_result($result);
pg_close($dbconn);

echo "</table>";
echo "</div>";

echo "<script>";
echo "var allvideoids = [";
echo $allvideoids;
echo "];";
echo "</script>";

echo "</body>";
echo "</html>";
?>