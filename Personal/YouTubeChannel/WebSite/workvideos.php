<?php
require_once __DIR__ . '/secrets.php';
echo "<html>";

echo "<head>";
echo "<title>Work Videos</title>";
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
echo "<div class=\"playvideotopcontentitem\"><a class=\"hidden\" title=\"My site link URL (do you really want to send users to my site?)\" id=\"playvideomysitelink\"></a></div>";
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
echo "<h2>Rule #34: My coworkers are NOT ALLOWED to watch my videos, but if you accidentally break this rule you are REQUIRED to do so during work hours!<br/>";
echo "Rule #35: NO ONE is allowed to make mash-up jokes with my channel and Microsoft Teams!</h2>";
echo "<button id=\"playall\" onclick=\"playall()\">Play All</button>";
echo "<table>";

echo "<tr><th>Name</th><th>Identifier</th><th>Concepts</th><th>Additional</th><th>Dislikes</th><th>Likes</th></tr>";

$dbconn = connectToDatabase();
$query = 'SELECT v.youtubeid,v.shortname,v.identifier,wv.concepts,dtxt.purpose,dtxt.googledrivefileid txtfileid,dmusx.googledrivefileid musxfileid,ddorico.googledrivefileid doricofileid,v.dislikes,v.likes FROM public.videolist_workvideos wv INNER JOIN public.videos v ON wv.videoid = v.id LEFT JOIN documents dtxt ON v.additionaltextdocumentid = dtxt.id LEFT JOIN documents dmusx ON v.musxdocumentid = dmusx.id LEFT JOIN documents ddorico ON v.doricodocumentid = ddorico.id ORDER BY wv.ord';
$result = pg_query($dbconn,$query);

$allvideoids = null;

while ($row = pg_fetch_assoc($result)) {
 $youtubeid = $row['youtubeid'];
 $txtfileid = $row['txtfileid'];
 $hastxt = !empty($txtfileid);
 $musxfileid = $row['musxfileid'];
 $hasmusx = !empty($musxfileid);
 $doricofileid = $row['doricofileid'];
 $hasdorico = !empty($doricofileid);
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
 echo "<a href=\"javascript:void(0);\" onclick=\"doPlayVideo('";
 echo $row["youtubeid"];
 echo "')\">";
 echo $row["shortname"];
 echo "</a>";
 echo "</td>";
 echo "<td>";
 echo $row["identifier"];
 echo "</td>";
 echo "<td>";
 echo $row["concepts"];
 echo "</td>";
 echo "<td>";
 echo "<a href=\"videotextinfo.php?youtubeid=";
 echo $youtubeid;
 echo "&return=workvideos\">Description</a>";
 if ($hastxt)
 {
  echo "<br/>";
  echo "<a href=\"videotextinfo.php?youtubeid=";
  echo $youtubeid;
  echo "&doctype=gdrtxt&return=workvideos\">";
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
 if ($hasdorico)
 {
  echo "<br/>";
  echo "<a href=\"https://drive.google.com/file/d/";
  echo $doricofileid;
  echo "\">Dorico</a>";
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