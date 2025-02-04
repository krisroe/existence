<?php
echo "<html>";

echo "<head>";
echo "<title>Unfunny Music Videos</title>";
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
echo "<table>";
echo "<tr><th>Piece</th><th>Author</th><th>Setting</th><th>Additional</th><th>Dislikes</th><th>Likes</th></tr>";

$dbconn = pg_connect("{pgconnstr}");
$query = 'SELECT v.youtubeid,v.isprivate,p.id,p.name,mv.piece,mv.author,mv.setting,v.dislikes,v.likes FROM public.videolist_musicvideos mv INNER JOIN public.performers p ON mv.performerid=p.id INNER JOIN public.videos v ON mv.videoid=v.id ORDER BY p.ord,mv.ord';
$result = pg_query($dbconn,$query);
$performerid = 0;
$nextperformerid = 0;

while ($row = pg_fetch_assoc($result)) {
 $youtubeid = $row['youtubeid'];
 $isprivate = $row['isprivate'];
 $nextperformerid = $row['id'];
 if ($nextperformerid != $performerid)
 {
	echo "<tr>";
	echo "<td colspan=\"5\" class=\"musicvideoperformer\">"; 
	echo $row['name'];
	echo "</td>";
	echo "</tr>";
	$performerid=$nextperformerid;
 }
 echo "<tr>";
 echo "<td>";
 echo "<a href=\"";
 if ($isprivate === "t")
 {
  echo "https://youtube.com/watch?v=";
  echo $youtubeid;
 }
 else
 {
  echo "javascript:void(0);\" onclick=\"doPlayVideo('";
  echo $youtubeid;
  echo "')";
 }
 echo "\">";
 echo $row["piece"];
 if ($isprivate === "t")
 {
  echo " (Private)";
 }
 echo "</a>";
 echo "</td>";
 echo "<td>";
 echo $row["author"];
 echo "</td>";
 echo "<td>";
 echo $row["setting"];
 echo "</td>";
 echo "<td>";
 if ($isprivate === 'f')
 {
  echo "<a href=\"videotextinfo.php?youtubeid=";
  echo $youtubeid;
  echo "&return=musicvideos\">Description</a>";
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
echo "</body>";
echo "</html>";
?>