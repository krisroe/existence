<?php
require_once __DIR__ . '/secrets.php';

//song column HTML for a copyright found: title, author, artist (if any) and personal connection (if any), one per line
function formatSong($row)
{
 $lines = [$row['title'], $row['author']];
 if ($row['artist'] !== null)
 {
  $lines[] = $row['artist'];
 }
 if ($row['personalconnection'] !== null)
 {
  $lines[] = $row['personalconnection'];
 }
 return implode('<br/>', array_map('htmlspecialchars', $lines));
}

//adds a period to the end of a sentence unless it already ends with one (e.g. "Inc.")
function endSentence($s)
{
 return substr($s, -1) === '.' ? $s : $s . '.';
}

//copyright column HTML for a copyright found, e.g.
//"2001-02-03 (Publish) Example Music, Inc. Registered 2001-04-05 (PA0000000001). All rights reserved."
//"1990/1991 Sample Songs Ltd. Published 1990-06-07. Registered 1992-08-09 (PA0000000002). All rights reserved."
//Exactly one thing goes before the holder: the key date (the notice date, else the publication date, else the
//registration date), or the copyright year instead when the key date isn't in that year or the year is a range. The
//registration and the key date, when they aren't the one at the front, go after the holder in date order.
function formatCopyright($row)
{
 $yearstart = $row['copyrightyearstart'];
 $yearend = $row['copyrightyearend'];
 $noticedate = $row['copyrightnoticedate'];
 $publicationdate = $row['publicationdate'];
 //the registration date and number are either both set or both null (songs_chk_registration)
 $registrationdate = $row['copyrightregistrationdate'];
 $registrationnumber = $row['copyrightregistrationnumber'];
 $holder = $row['copyrightholder'];
 $flags = $row['copyrightflags'] === null ? 0 : (int)$row['copyrightflags'];

 //the key date and how it reads at the front and after the holder
 $keydate = null;
 $keyfront = null;
 $keytrailing = null;
 if ($noticedate !== null)
 {
  $keydate = $noticedate;
  $keyfront = $noticedate . ' (Notice)';
  $keytrailing = 'Notice ' . $noticedate . '.';
 }
 else if ($publicationdate !== null)
 {
  $keydate = $publicationdate;
  $keyfront = $publicationdate . ' (Publish)';
  $keytrailing = 'Published ' . $publicationdate . '.';
 }
 else if ($registrationdate !== null)
 {
  $keydate = $registrationdate;
  $keyfront = $registrationdate . ' (Registered ' . $registrationnumber . ')';
 }
 $keyisregistration = $noticedate === null && $publicationdate === null && $registrationdate !== null;

 $showyear = $yearstart !== null && ($keydate === null || $yearend !== null || substr($keydate, 0, 4) !== $yearstart);
 $front = null;
 if ($showyear)
 {
  $front = $yearend === null ? $yearstart : $yearstart . '/' . $yearend;
 }
 else if ($keydate !== null)
 {
  $front = $keyfront;
 }
 $keyatfront = !$showyear && $keydate !== null;

 //dates after the holder, each with its date and text
 $trailing = [];
 if (!$keyatfront && $keydate !== null && !$keyisregistration)
 {
  $trailing[] = ['date' => $keydate, 'text' => $keytrailing];
 }
 if (!($keyatfront && $keyisregistration) && $registrationdate !== null)
 {
  $trailing[] = ['date' => $registrationdate, 'text' => 'Registered ' . $registrationdate . ' (' . $registrationnumber . ').'];
 }
 usort($trailing, function ($a, $b) {
  return strcmp($a['date'], $b['date']);
 });

 $headline = [];
 if ($front !== null)
 {
  $headline[] = $front;
 }
 if ($holder !== null)
 {
  $headline[] = $holder;
 }
 $sentences = [];
 if (count($headline) > 0)
 {
  $sentences[] = endSentence(implode(' ', $headline));
 }
 foreach ($trailing as $entry)
 {
  $sentences[] = $entry['text'];
 }
 if ($flags & 1)
 {
  $sentences[] = 'All rights reserved.';
 }
 if ($flags & 2)
 {
  $sentences[] = "Int'l copyright secured.";
 }
 if ($flags & 4)
 {
  $sentences[] = 'Public domain.';
 }
 return htmlspecialchars(implode(' ', $sentences));
}
echo "<html>";

echo "<head>";
echo "<title>Copyrights</title>";
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
echo "<h3>Copyrights Found</h3>";
echo "<table>";
echo "<tr><th>Episode</th><th>Song</th><th>Copyright</th></tr>";

$dbconn = connectToDatabase();
$query = 'SELECT v1.youtubeid v1youtubeid,v1.identifier v1identifier,v2.youtubeid v2youtubeid,v2.identifier v2identifier,s.title,s.author,s.artist,s.personalconnection,s.copyrightholder,s.copyrightyearstart,s.copyrightyearend,s.copyrightnoticedate,s.publicationdate,s.copyrightregistrationdate,s.copyrightregistrationnumber,s.copyrightflags FROM public.copyrights_found c INNER JOIN songs s ON c.songid=s.id INNER JOIN videos v1 ON c.videoid1=v1.id LEFT JOIN videos v2 ON c.videoid2=v2.id ORDER BY c.ord';
$result = pg_query($dbconn,$query);

while ($row = pg_fetch_assoc($result)) {
 echo "<tr>";
 echo "<td>";
 echo "<a href=\"javascript:void(0);\" onclick=\"doPlayVideo('";
 echo $row["v1youtubeid"];
 echo "')\">";
 echo $row["v1identifier"];
 echo "</a>";
 if (!empty($row['v2youtubeid']))
 {
  echo "<br/>";
  echo "<a href=\"javascript:void(0);\" onclick=\"doPlayVideo('";
  echo $row["v2youtubeid"];
  echo "')\">";
  echo $row["v2identifier"];
  echo "</a>";
 }
 echo "</td>";
 echo "<td>";
 echo formatSong($row);
 echo "</td>";
 echo "<td>";
 echo formatCopyright($row);
 echo "</td>";
 echo "</tr>";
}

pg_free_result($result);

echo "</table>";

echo "<h3>Copyrights Missing</h3>";
echo "<table>";
echo "<tr><th>Episode</th><th>Song</th><th>Copyright</th></tr>";

$query = 'SELECT v1.youtubeid v1youtubeid,v1.identifier v1identifier,v2.youtubeid v2youtubeid,v2.identifier v2identifier,c.song,c.copyright FROM public.copyrights_missing c INNER JOIN videos v1 ON c.videoid1=v1.id LEFT JOIN videos v2 ON c.videoid2=v2.id ORDER BY c.ord';
$result = pg_query($dbconn,$query);

while ($row = pg_fetch_assoc($result)) {
 echo "<tr>";
 echo "<td>";
 echo "<a href=\"javascript:void(0);\" onclick=\"doPlayVideo('";
 echo $row["v1youtubeid"];
 echo "')\">";
 echo $row["v1identifier"];
 echo "</a>";
 if (!empty($row['v2youtubeid']))
 {
  echo "<br/>";
  echo "<a href=\"javascript:void(0);\" onclick=\"doPlayVideo('";
  echo $row["v2youtubeid"];
  echo "')\">";
  echo $row["v2identifier"];
  echo "</a>";
 }
 echo "</td>";
 echo "<td>";
 echo $row["song"];
 echo "</td>";
 echo "<td>";
 echo $row["copyright"];
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