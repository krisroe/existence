<?php
echo "<html>";

echo "<head>";
echo "<title>Link Instructions</title>";
echo "<link rel=\"stylesheet\" href=\"";
echo "{stylefilename}";
echo "\">";
echo "<link rel=\"icon\" type=\"image/png\" href=\"destroyallpugz.png\"/>";
echo "</head>";

echo "<body>";

echo "<div id=\"homecontainer\">";
echo "<p id=\"homelink\"><a href=\"../index.html\">Home</a></p>";
echo "</div>"; //end homecontainer

echo "<h2>Rule #15: You are NOT ALLOWED to do ABSOLUTELY ANYTHING with my links</h2>";
echo "<h2>Rule #47: I am NOT ALLOWED to give ANYONE security training</h2>";
echo "<h3>Select a video and additional link information to generate a link:</h3>";

echo <<<EOT
<script>

function changedropdown()
{
 var selectvideo = document.getElementById('selectvideo');	
 var selectautoplay = document.getElementById('selectautoplay');
 var selectland = document.getElementById('selectland');
 var copybutton = document.getElementById('copybutton');
 var newurl;
 if (selectvideo.selectedIndex <= 0)
 {
  newurl = '';
  copybutton.disabled = true;
 }
 else
 {
  newurl = '{protocol}://{server}/donotclick.php?youtubeid=' + selectvideo.value;
  if (selectautoplay.selectedIndex > 0)
  {
   newurl += ("&autoplay=" + selectautoplay.options[selectautoplay.selectedIndex].text);
  }
  if (selectland.selectedIndex > 0)
  {
   newurl += ("&land=" + selectland.options[selectland.selectedIndex].text);
  }
  copybutton.disabled = false;
 }
 var link = document.getElementById('computedurllink');
 link.innerText = newurl;
 link.setAttribute('href', newurl);
}

function handlecopy()
{
 var texttocopy = document.getElementById('computedurllink').innerText;
 if (texttocopy)
 {
  var textarea = document.createElement('textarea');
  textarea.value = texttocopy;
  document.body.appendChild(textarea);
  textarea.select();
  document.execCommand("copy");
  document.body.removeChild(textarea);
  alert("Link copied to clipboard!");
 }
}

</script>
EOT;

echo "<table>";
echo "<tbody>";

echo "<tr>";
echo "<td><p>Video:</p></td>";
echo "<td>";
echo "<select id=\"selectvideo\" class=\"linkinstructionsselect\" onchange=\"changedropdown()\">";
echo "<option selected></option>"; //blank option at the beginning of the list
$dbconn = pg_connect("{pgconnstr}");
$query = 'SELECT youtubeid,shortname,identifier,owner FROM public.videos ORDER BY id';
$result = pg_query($dbconn,$query);
while ($row = pg_fetch_assoc($result))
{
 echo "<option value=\"";
 echo $row['youtubeid'];
 echo "\">";
 echo $row['shortname'];
 echo " ";
 echo $row['identifier'];
 echo " ";
 echo $row['owner'];
 echo "</option>";
}
echo "</select>";
echo "</td>";
echo "</tr>";

echo "<tr>";
echo "<td class=\"linkfirstcolumn\"><p>Autoplay:</p></td>";
echo "<td>";
echo "<select id=\"selectautoplay\" class=\"linkinstructionsselect\" onchange=\"changedropdown()\">";
echo "<option selected></option>";
echo "<option>true</option>";
echo "<option>false</option>";
echo "</select>";
echo "</td>";
echo "</tr>";

echo "<tr>";
echo "<td class=\"linkfirstcolumn\"><p>Land:</p></td>";
echo "<td>";
echo "<select id=\"selectland\" class=\"linkinstructionsselect\" onchange=\"changedropdown()\">";
echo "<option selected></option>"; //blank option at the beginning of the list
echo "<option>destroyallpugz</option>";
$query = 'SELECT name FROM landing_pages ORDER BY ord';
$result = pg_query($dbconn,$query);
while ($row = pg_fetch_assoc($result))
{
 echo "<option>";
 echo $row['name']; 
 echo "</option>";
}
echo "</select>";
echo "</td>";
echo "</tr>";

echo "<tr>";
echo "<td class=\"linkfirstcolumn\"><p>URL:</p></td>";
echo "<td><a id=\"computedurllink\" href=\"\"></a></td>";
echo "</tr>";

echo "<tr>";
echo "<td/>";
echo "<td><button id=\"copybutton\" onclick=\"handlecopy()\" disabled>Copy</button></td>";
echo "</tr>";

echo "</tbody>";
echo "</table>";
echo "</body>";
echo "</html>";
?>