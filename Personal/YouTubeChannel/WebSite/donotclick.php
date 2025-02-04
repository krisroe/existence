<?php

function checkForInputErrors($youtubevideoid, $autoplay)
{
 if (empty($youtubevideoid))
 {
  return 'Video ID not specified.';
 }
 else if (!preg_match('/^[a-zA-Z0-9_-]{11}$/', $youtubevideoid))
 {
  return 'Invalid YouTube Video ID: ' . $youtubevideoid;
 }
 if (!empty($autoplay) && $autoplay != "true" && $autoplay != "false")
 {
  return "Invalid autoplay value: " . $autoplay;
 }
 return null;
}

function OutputErrorPage($message)
{
 echo "<html>";
 echo "<head>";
 echo "<title>";
 echo $message;
 echo "</title>";
 echo "<link rel=\"stylesheet\" href=\"";
 echo "{stylefilename}";
 echo "\">";
 echo "<link rel=\"icon\" type=\"image/png\" href=\"destroyallpugz.png\"/>";
 echo "</head>";
 echo "<body>";
 echo "<h2>";
 echo $message;
 echo "</h2>";
 echo "</body>";
 echo "</html>";
}

//prevent browser caching
header("Cache-Control: no-store, no-cache, must-revalidate, max-age=0");
header("Cache-Control: post-check=0, pre-check=0", false);
header("Pragma: no-cache");

if (isset($_GET['youtubeid']))
{
 $youtubevideoid = $_GET['youtubeid'];
}
else
{
 $youtubevideoid = '';
}
if (isset($_GET['autoplay']))
{
 $autoplay = $_GET['autoplay'];
}
else
{
 $autoplay = 'true';
}
if (isset($_GET['land']))
{
 $land = $_GET['land'];
}
else
{
 $land = 'destroyallpugz';
}

if ($land == 'destroyallpugz')
{
 $landurl = "{protocol}://{server}/index.html";
}
else
{
 $dbconn = pg_connect("{pgconnstr}");
 $query = 'SELECT url FROM public.landing_pages WHERE name=$1';
 $result = pg_query_params($dbconn,$query,array($land));
 if ($result)
 {
  $haveland = true;
  $landurl = pg_fetch_result($result, 0, 0);
 }
 else
 {
  $haveland = false;
  OutputErrorPage('Invalid landing page: ' . $land);
 }
 pg_free_result($result);
 pg_close($dbconn);
 if (!$haveland)
 {
  return;
 }
}

$error = checkForInputErrors($youtubevideoid, $autoplay);
if (!empty($error))
{
 OutputErrorPage($error);
 return;
}
if ($autoplay == "false")
{
 $autoplaybool = false;
}
else
{
 $autoplaybool = true;
}

echo "<html>";

echo "<head>";
echo "<title>";
echo "Play ";
echo htmlspecialchars($youtubevideoid, ENT_QUOTES, 'UTF-8');
echo "</title>";
echo "<link rel=\"stylesheet\" href=\"";
echo "{stylefilename}";
echo "\">";
echo "<link rel=\"icon\" type=\"image/png\" href=\"destroyallpugz.png\"/>";
echo "</head>";

echo "<body>";

echo "<div id=\"homecontainer\">";
echo "<p id=\"homelink\"><a href=\"javascript:void(0);\" onclick=\"doStopVideo()\">Home</a></p>";
echo "<div id=\"playvideotopcontent\">";
echo "<div class=\"playvideotopcontentitem\"><p title=\"My site link URL (do you really want to send users to my site?)\">See address bar for URL or </p></div>";
echo "<div class=\"playvideotopcontentitem\"><a title=\"YouTube link URL (do you really want to send users to YouTube?). Go to YouTube to DISLIKE my video!\" id=\"playvideoyoutubelink\"></a></div>";
echo "</div>"; //end playvideotopcontent
echo "</div>"; //end homecontainer
echo "<div><h2 id=\"mutewarning\"";
if (!$autoplaybool)
{
 echo " class=\"hidden\"";
}
echo ">Autoplay means the video starts muted, press the UNMUTE button NOW!</h2></div>";
echo "<div><h2 id=\"startwarning\"";
if ($autoplaybool)
{
 echo " class=\"hidden\"";
}
echo ">You need to click to start the video!</h2></div>";

echo "<script>";
echo "var landURL = '";
echo $landurl;
echo "';";
echo "</script>";

echo "<script>";

echo <<<EOT
function onYouTubeIframeAPIReady() {
 player = new YT.Player('player', {
  height: '100%',
  width: '100%',
  events: {
   'onStateChange': onPlayerStateChange,
   'onReady': onPlayerReady
  }
 });
}

function onPlayerStateChange(event) {
 if (event.data == YT.PlayerState.ENDED)
 {
  window.location.href = landURL;
 }
 else if (event.data == YT.PlayerState.PLAYING)
 {
  document.getElementById('startwarning').classList.add('hidden');
 }
}

function onPlayerReady(event) {
 var youtubevideoidvar = getQueryParam('youtubeid');
 var linkurl = 'https://www.youtube.com/watch?v=' + youtubevideoidvar;
 var linkelement1 = document.getElementById('playvideoyoutubelink');
 linkelement1.textContent = linkurl; //textContent does text encoding, so this is not injection risk
 var hrefurl = '';
 try
 {
	 hrefurl = new URL(linkurl).href;
 }
 catch (e)
 {
	 alert('invalid URL: ' + linkurl);
	 return;
 }
 linkelement1.href = linkurl;
 player.loadVideoById(youtubevideoidvar);
 doStartTheVideo();
}

function doStopVideo() {
 player.stopVideo();
 window.location.href = landURL;
}

function getQueryParam(name) {
 const urlParams = new URLSearchParams(window.location.search);
 return urlParams.get(name);
}

EOT;

echo "function doStartTheVideo() {";
echo "\n";
if ($autoplaybool)
{
 echo "player.mute();";
 echo "\n";
}
echo "player.playVideo();";
echo "\n";
if ($autoplaybool)
{
 echo "setInterval(function()";
 echo "{";
 echo "if (!player.isMuted())";
 echo "{";
 echo "document.getElementById('mutewarning').classList.add('hidden');";
 echo "}";
 echo "}";
 echo ",200)";
}
echo "}"; //end the function

echo "</script>";

echo "<div id=\"playercontainervisible\">";
echo "<div id=\"player\">";
echo "</div>";
echo "</div>";
echo "<script src=\"https://www.youtube.com/iframe_api\"></script>";

echo "</body>";
echo "</html>";
?>