<?php
require_once __DIR__ . '/secrets.php';
echo "<html>";

echo "<head>";
echo "<title>Documents</title>";
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
echo "<h3>Documents</h3>";
echo "<table>";
echo "<tr><th>Video(s)</th><th>Document</th><th>Supports Playback</th></tr>";

//one row per document and video using it; documents are ordered by their order in the XML file
$dbconn = connectToDatabase();
$query = 'SELECT d.id,d.doctype,d.purpose,d.googledrivefileid,d.supportsplayback,v.youtubeid,v.shortname FROM public.documents d LEFT JOIN public.videos v ON v.additionaltextdocumentid = d.id OR v.musxdocumentid = d.id OR v.doricodocumentid = d.id ORDER BY d.ord,v.id';
$result = pg_query($dbconn,$query);

$documents = [];
while ($row = pg_fetch_assoc($result)) {
 $id = $row['id'];
 if (!isset($documents[$id]))
 {
  $documents[$id] = ['row' => $row, 'videos' => []];
 }
 if ($row['youtubeid'] !== null)
 {
  $documents[$id]['videos'][] = $row;
 }
}

pg_free_result($result);
pg_close($dbconn);

foreach ($documents as $document) {
 $row = $document['row'];
 $doctype = $row['doctype'];
 $isadditionaltext = $doctype == 1;
 $doclabel = "";
 if ($isadditionaltext)
 {
  $purpose = $row['purpose'];
  if ($purpose == 1)
  {
   $doclabel = "Transcript";
  }
  else if ($purpose == 2)
  {
   $doclabel = "Commentary";
  }
  else if ($purpose == 3)
  {
   $doclabel = "Transcript+Commentary";
  }
 }
 else if ($doctype == 2)
 {
  $doclabel = "MUSX";
 }
 else if ($doctype == 3)
 {
  $doclabel = "Dorico";
 }
 echo "<tr>";
 echo "<td>";
 $first = true;
 foreach ($document['videos'] as $video)
 {
  if (!$first)
  {
   echo "<br/>";
  }
  $first = false;
  echo "<a href=\"javascript:void(0);\" onclick=\"doPlayVideo('";
  echo $video["youtubeid"];
  echo "')\">";
  echo $video["shortname"];
  echo "</a>";
 }
 echo "</td>";
 echo "<td>";
 echo "<a href=\"https://drive.google.com/file/d/";
 echo htmlspecialchars($row['googledrivefileid']);
 echo "\">";
 echo $doclabel;
 echo "</a>";
 echo "</td>";
 echo "<td>";
 $supportsplayback = $row['supportsplayback'];
 if ($isadditionaltext)
 {
  echo "N/A";
 }
 else if ($supportsplayback === null)
 {
  echo "?";
 }
 else if ($supportsplayback === 't')
 {
  echo "&#9989; Yes";
 }
 else
 {
  echo "&#10060; No";
 }
 echo "</td>";
 echo "</tr>";
}

echo "</table>";
echo "</div>";

echo "</body>";
echo "</html>";
?>
