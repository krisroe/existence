<?php
echo "<html>";

echo "<head>";
echo "<title>Audio Files</title>";
echo "<link rel=\"stylesheet\" href=\"";
echo "{stylefilename}";
echo "\">";
echo "<link rel=\"icon\" type=\"image/png\" href=\"destroyallpugz.png\"/>";
echo "</head>";

echo "<body>";
echo "<p id=\"homelink\"><a href=\"../index.html\">Home</a></p>";
echo "<div>";
echo "<table>";

echo "<tr><th>Number</th><th>Song</th><th>Suggestion</th></tr>";

$dbconn = pg_connect("{pgconnstr}");
$query = 'SELECT a.googledrivefileid,a.number,a.name,a.suggestion FROM public.audios a ORDER BY a.ord';
$result = pg_query($dbconn,$query);

while ($row = pg_fetch_assoc($result)) {
 echo "<tr>";
 echo "<td>";
 echo $row['number'];
 echo "</td>";
 echo "<td>";
 echo "<a href=\"https://drive.google.com/file/d/";
 echo $row['googledrivefileid'];
 echo "\">";
 echo $row['name'];
 echo "</a>";
 echo "</td>";
 echo "<td>";
 echo $row['suggestion'];
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