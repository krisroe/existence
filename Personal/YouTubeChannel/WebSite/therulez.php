<?php
echo "<html>";

echo "<head>";
echo "<title>The Rulez</title>";
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
echo "<h3>Official Rulez</h3>";
echo "<table>";
echo "<tr><th>Number</th><th>Rule</th><th>Source</th><th>Actual Rule</th></tr>";

$dbconn = pg_connect("{pgconnstr}");
$query = 'SELECT r.number,r.rule,r.source,r.actualrule,v1.youtubeid v1youtubeid,v1.identifier v1identifier,v2.youtubeid v2youtubeid,v2.identifier v2identifier,r.video1isadditionaltext FROM public.rulez_official r LEFT JOIN videos v1 ON r.videoid1=v1.id LEFT JOIN videos v2 ON r.videoid2=v2.id LEFT JOIN documents d ON v1.additionaltextdocumentid=d.id ORDER BY r.ord';
$result = pg_query($dbconn,$query);

while ($row = pg_fetch_assoc($result)) {
 echo "<tr>";
 echo "<td>";
 echo $row['number'];
 echo "</td>";
 echo "<td>";
 echo $row['rule'];
 echo "</td>";
 echo "<td>";
 if (!empty($row['v1youtubeid']))
 {
  if ($row['video1isadditionaltext'] == 't')
  {
   echo "<a href=\"videotextinfo.php?youtubeid=";
   echo $row['v1youtubeid'];
   echo "&return=therulez&doctype=gdrtxt\">";
   echo $row['v1identifier'];
   echo " Additional</a>";
  }
  else
  {
   echo "<a href=\"javascript:void(0);\" onclick=\"doPlayVideo('";
   echo $row['v1youtubeid'];
   echo "')\">";
   echo $row['v1identifier'];
   echo "</a>";
  }
  if (!empty($row['v2youtubeid']))
  {
   echo "<br/>";
   echo "<a href=\"javascript:void(0);\" onclick=\"doPlayVideo('";
   echo $row['v2youtubeid'];
   echo "')\">";
   echo $row['v2identifier'];
   echo "</a>";
  }
  echo $row['source'];
  echo "</td>";
 }
 echo "</td>";
 echo "<td>";
 echo $row["actualrule"];
 echo "</td>";
 echo "</tr>";
}

pg_free_result($result);
pg_close($dbconn);

echo "</table>";

echo "<h3>Infrequently Asked Questions</h3>";
echo "<ul>";
echo "<li>Do we live in a simulation?";
echo "<ul>";
echo "<li>Yes. But if you don't believe this, I hope that we can agree that living in a simulation is a useful (and possibly important) metaphysical concept.</li>";
echo "</ul>";
echo "</li>";
echo "</ul>";

echo "<h3>Unofficial Rulez</h3>";
echo "<table>";
echo "<tr><th>Rule</th><th>Source</th></tr>";

$dbconn = pg_connect("{pgconnstr}");
$query = 'SELECT r.rule,r.source,v1.youtubeid v1youtubeid,v1.identifier v1identifier,v2.youtubeid v2youtubeid,v2.identifier v2identifier,r.video1isadditionaltext FROM public.rulez_unofficial r LEFT JOIN videos v1 ON r.videoid1=v1.id LEFT JOIN videos v2 ON r.videoid2=v2.id LEFT JOIN documents d ON v1.additionaltextdocumentid=d.id ORDER BY r.ord';
$result = pg_query($dbconn,$query);

while ($row = pg_fetch_assoc($result)) {
 echo "<tr>";
 echo "<td>";
 echo $row['rule'];
 echo "</td>";
 echo "<td>";
 if (!empty($row['v1youtubeid']))
 {
  if ($row['video1isadditionaltext'] == 't')
  {
   echo "<a href=\"videotextinfo.php?youtubeid=";
   echo $row['v1youtubeid'];
   echo "&return=therulez&doctype=gdrtxt\">";
   echo $row['v1identifier'];
   echo " Additional</a>";
  }
  else
  {
   echo "<a href=\"javascript:void(0);\" onclick=\"doPlayVideo('";
   echo $row['v1youtubeid'];
   echo "')\">";
   echo $row['v1identifier'];
   echo "</a>";
  }
  if (!empty($row['v2youtubeid']))
  {
   echo "<br/>";
   echo "<a href=\"javascript:void(0);\" onclick=\"doPlayVideo('";
   echo $row['v2youtubeid'];
   echo "')\">";
   echo $row['v2identifier'];
   echo "</a>";
  }
  echo $row['source'];
  echo "</td>";
 }
 echo "</td>";
 echo "</tr>";
}

pg_free_result($result);
pg_close($dbconn);

echo "</table>";
echo "</div>";

echo "</body>";
echo "</html>";
?>