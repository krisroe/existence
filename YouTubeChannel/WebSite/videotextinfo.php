<?php

function checkForInputErrors($youtubevideoid,$return,$doctype)
{
 if (empty($youtubevideoid))
 {
  return 'Video ID not specified.';
 }
 else if (!preg_match('/^[a-zA-Z0-9_-]{11}$/', $youtubevideoid))
 {
  return 'Invalid YouTube Video ID: ' . $youtubevideoid;
 }
 if ($return != '' &&
     $return != 'index' &&
     $return != 'lyricsanalysis' &&
	 $return != 'allvideos' &&
	 $return != 'kidzvideos' &&
	 $return != 'mainlinevideos' &&
	 $return != 'musicvideos' &&
	 $return != 'sillysongs' &&
	 $return != 'unexplainablevideos' &&
	 $return != 'workvideos' &&
	 $return != 'therulez')
 {
  return 'Invalid return: ' . $return;
 }
 if ($doctype != 'viddesc' && $doctype != 'gdrtxt')
 {
  return 'Invalid doc type: ' . $doctype;
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

if (isset($_GET['return']))
{
 $return = $_GET['return'];
}
else
{
 $return = '';
}

if (isset($_GET['doctype']))
{
 $doctype = $_GET['doctype'];
}
else
{
 $doctype = 'viddesc';
}

$error = checkForInputErrors($youtubevideoid,$return,$doctype);
if (!empty($error))
{
 OutputErrorPage($error);
 return;
}

if ($doctype == 'viddesc') //video description
{
 $options = [
  'http' => [
   'method' => 'GET',
   'header' => 'Content-Type: application/json',
  ],
  'ssl' => [
   'verify_peer' => false,
   'verify_peer_name' => false,
  ],
 ];
 $context = stream_context_create($options);
 $response = file_get_contents("https://www.googleapis.com/youtube/v3/videos?part=snippet&id=" . $youtubevideoid . "&key={googlecloudapikey}", false, $context);
 if ($response === false)
 {
  OutputErrorPage("Error fetching video description data!");
  return;
 }
 $data = json_decode($response, true);
 if ($data === null)
 {
  OutputErrorPage("Error processing video description JSON!");
  return;
 }
 if (!isset($data["items"]))
 {
  OutputErrorPage("Error processing video description JSON items!");
  return;
 }
 if (count($data["items"]) != 1)
 {
  OutputErrorPage("Error processing video description JSON items count!");
  return;
 }
 $items = $data["items"];
 if (!isset($items[0]["snippet"]))
 {
  OutputErrorPage("Error processing video description JSON items snippet!");
  return;
 }
 $snippet = $items[0]['snippet'];
 if (!isset($snippet["description"]))
 {
  OutputErrorPage("Error processing video description JSON items snippet description!");
  return;
 }
 $description = nl2br(htmlspecialchars($snippet["description"]));
}
else //video additional text
{
 $dbconn = pg_connect("{pgconnstr}");
 $query = 'SELECT d.googledrivefileid FROM public.videos v INNER JOIN public.documents d ON d.id = v.additionaltextdocumentid WHERE v.youtubeid=$1';
 $result = pg_query_params($dbconn,$query,array($youtubevideoid));
 if ($result)
 {
  $googledrivefileid = pg_fetch_result($result, 0, 0);
  $googledriveurl = 'https://www.googleapis.com/drive/v3/files/' . $googledrivefileid . '?alt=media&key={googlecloudapikey}';
  $description = nl2br(htmlspecialchars(file_get_contents($googledriveurl)));
  if ($description === false)
  {
   OutputErrorPage('Failed to load document from google drive');
   return;
  }
 }
 else
 {
  OutputErrorPage('Failed to load additional text document');
  return;
 }
}

//convert hyperlinks
$positions = array();
$offset = 0;
while (($pos = strpos($description, 'https://', $offset)) !== false) {
    $positions[] = $pos;
    $offset = $pos + 1;
}
$positions = array_reverse($positions);
$last = true;
$originallength = strlen($description);
foreach ($positions as $nextposition)
{
 $endindex = $nextposition + 8; //account for the https:// prefix
 $foundleftparen = false;
 $foundrightparen = false;
 $foundslash = false;
 $encloseinparentheses = $nextposition > 0 && $description[$nextposition - 1] == '(';
 while (true)
 {
  if (!$last || $endindex < $originallength) //matches to the end of the description (only possible for the last link)
  {
   $nextchar = $description[$endindex];
   $done = false;
   if ($nextchar == ')')
   {
    if ($foundleftparen && $foundrightparen)
    {
     $done = true;
    }
    else if ($foundleftparen && !$foundrightparen)
    {
     $foundrightparen = true;
    }
    else
    {
     $done = true;
    }
   }
   else if ($nextchar == '(')
   {
    if ($foundleftparen)
    {
     $done = true;
    }
    else
    {
     $foundleftparen = true;
    }
   }
   else if ($encloseinparentheses)
   {
    //skip, wait for closing parenthesis
   }
   else if ($nextchar == '/')
   {
    $foundslash = true;
   }
   else if ($nextchar == '.')
   {
    if ($foundslash)
	{
     $done = true;
	}
   }
   else if (!ctype_alnum($nextchar) && $nextchar != '_' && $nextchar != '?' && $nextchar != '=' && $nextchar != '-' && $nextchar != '&' && $nextchar != ':' && $nextchar != '#')
   {
    $done = true;
   }
  
   if ($done)
   {
     break;
   }
   else
   {
    $endindex++;
   }
  }
  else //end of the string ends with a link (expected to be the https://destroyallpugz.site link)
  {
	  break;
  }
 }
 
 $linktext = substr($description, $nextposition, $endindex-$nextposition);   
 $newlink = "<a href=\"" . $linktext . "\">" . $linktext . "</a>"; 
 if ($last && ($endindex == $originallength))
 {
  $description = substr($description,0,$nextposition) . $newlink;
 }
 else
 {
  $description = substr_replace($description,$newlink,$nextposition,$endindex-$nextposition);
 }
 $last = false;
}

echo "<html>";

echo "<head>";
echo "<title>";
echo "Description ";
echo htmlspecialchars($youtubevideoid, ENT_QUOTES, 'UTF-8');
echo "</title>";
echo "<link rel=\"stylesheet\" href=\"";
echo "{stylefilename}";
echo "\">";
echo "<link rel=\"icon\" type=\"image/png\" href=\"destroyallpugz.png\"/>";
echo "</head>";

echo "<body>";

if ($return == 'index' || $return == '')
{
 $returnurl = 'index.html';
}
else
{
 $returnurl = $return . '.php';
}

echo "<p id=\"homelink\"><a href=\"index.html\">Home</a>";
if ($return != 'main' && $return != '')
{
 echo " ";
 echo "<a href=\"";
 echo $returnurl;
 echo "\">Back</a>";
}
echo "</p>";

echo "<p>";
echo $description;
echo "</p>";

echo "</body>";

echo "</html>";

?>