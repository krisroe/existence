<?php
echo "<html>";

echo "<head>";
echo "<title>Silly Songs</title>";
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
echo "<button id=\"playall\" onclick=\"playall()\">Play All</button>";
echo "<table>";

echo "<tr><th>Number</th><th>Name</th><th>Identifier</th><th>Rulez</th><th>Memes</th><th>Additional</th><th>Dislikes</th><th>Likes</th></tr>";

$dbconn = pg_connect("{pgconnstr}");
$query = 'SELECT v.youtubeid,v.shortname,v.identifier,ss.number,ss.rulez,ss.memes,v.dislikes,v.likes FROM public.videolist_sillysongs ss INNER JOIN public.videos v ON ss.videoid = v.id ORDER BY ss.ord';
$result = pg_query($dbconn,$query);

$allvideoids = null;

while ($row = pg_fetch_assoc($result)) {
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
 echo $row["number"];
 echo "</td>";
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
 echo $row["rulez"];
 echo "</td>";
 echo "<td>";
 echo $row["memes"];
 echo "</td>";
 echo "<td>";
 echo "<a href=\"videotextinfo.php?youtubeid=";
 echo $youtubeid;
 echo "&return=sillysongs\">Description</a>";
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