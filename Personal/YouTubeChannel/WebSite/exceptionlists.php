<?php

class MemberType
{
	public $id;
	public $name;
}
class ExceptionList
{
	public $id;
	public $name;
	public $identifier;
	public $youtubeid;
	public $categories;
	public $detail;
	public function __construct()
	{
		$this->categories = array();
	}
}
class ExceptionListCategory
{
	public $membertype;
	public $members;
	public function __construct()
	{
		$this->members = array();
	}
}
class ExceptionListMember
{
	public $name;
	public $youtubeid;
	public $shortname;
}


echo "<html>";

echo "<head>";
echo "<title>Exception Lists</title>";
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

$dbconn = pg_connect("{pgconnstr}");

//retrieve member types
$exceptionlistmembertypes = [];
$query = 'SELECT id,name FROM public.exception_list_member_types ORDER BY ord';
$result = pg_query($dbconn,$query);
while ($line = pg_fetch_array($result, null, PGSQL_ASSOC))
{
 $nextmembertype = new MemberType();
 $nextmembertype->id = $line['id'];
 $nextmembertype->name = $line['name'];
 array_push($exceptionlistmembertypes,$nextmembertype);
}
pg_free_result($result);

//retrieve exception lists
$exceptionlists = [];
$query = 'SELECT el.id,el.name,el.detail,v.identifier,v.youtubeid FROM public.exception_lists el INNER JOIN videos v ON v.id=el.videoid ORDER BY el.ord';
$result = pg_query($dbconn,$query);
while ($line = pg_fetch_array($result, null, PGSQL_ASSOC))
{
 $nextexceptionlist = new ExceptionList();
 $nextexceptionlist->id = $line['id'];
 $nextexceptionlist->name = $line['name'];
 $nextexceptionlist->detail = $line['detail'];
 $nextexceptionlist->identifier = $line['identifier'];
 $nextexceptionlist->youtubeid = $line['youtubeid'];
 array_push($exceptionlists,$nextexceptionlist);
}
pg_free_result($result);

//retrieve exception list members
$query = 'SELECT el.id AS exceptionlistid,elmt.id AS membercategoryid,elm.name,v.youtubeid,v.shortname FROM public.exception_list_members elm INNER JOIN public.exception_lists el ON elm.exceptionlistid=el.id INNER JOIN public.exception_list_member_types elmt ON elmt.id=elm.categoryid INNER JOIN videos v ON v.id=elm.videoid ORDER BY el.ord,elmt.ord,elm.ord';
$result = pg_query($dbconn,$query);
while ($line = pg_fetch_array($result, null, PGSQL_ASSOC))
{
	$exceptionlistid = $line['exceptionlistid'];
	$membercategoryid = $line['membercategoryid'];
	$foundcategory = null;
	foreach ($exceptionlists as $nextexceptionlist)
	{
		$nextexceptionlistid = $nextexceptionlist->id; //exception list id
		if ($exceptionlistid == $nextexceptionlistid)
		{
			foreach ($nextexceptionlist->categories as $nextcategory) //find existing category
			{
				if ($nextcategory->membertype->id == $membercategoryid)
				{
					$foundcategory = $nextcategory;
					break;
				}
			}
			
			if ($foundcategory == null) //create new category if needed
			{
				$foundcategory = new ExceptionListCategory();				
				foreach ($exceptionlistmembertypes as $nextmembertype)
				{
					if ($nextmembertype->id == $membercategoryid)
					{
				        $foundcategory->membertype = $nextmembertype;
						break;
					}
				}
				array_push($nextexceptionlist->categories, $foundcategory);
			}

			$newmember = new ExceptionListMember();
			$newmember->name = $line['name'];
			$newmember->youtubeid = $line['youtubeid'];
			$newmember->shortname = $line['shortname'];
			array_push($foundcategory->members,$newmember);
		}
		if ($foundcategory != null)
		{
			break;
		}
	}
}
pg_free_result($result);

pg_close($dbconn);

$exceptionlistcounter = 0;
foreach ($exceptionlists as $nextexceptionlist)
{
	echo "<h2>";
	echo $nextexceptionlist->name;
	echo "</h2>";
	echo $nextexceptionlist->detail;
	echo "<ul>";
	$nextexceptionlist = $exceptionlists[$exceptionlistcounter];
	foreach ($nextexceptionlist->categories as $nextcategory)
	{
			echo "<li>";
			$nextcategoryname = $nextcategory->membertype->name;
			echo $nextcategoryname;
			echo "<ul>";
			foreach ($nextcategory->members as $nextmember)
			{
				echo "<li>";
				echo $nextmember->name;
				echo " (";
				echo "<a href=\"javascript:void(0);\" onclick=\"doPlayVideo('";
				echo $nextmember->youtubeid;
				echo "')\">";
				echo $nextmember->shortname;
				echo "</a>";
				echo ")";
				echo "</li>";
			}			
			echo "</ul>";
	}		
	echo "</ul>";
	$exceptionlistcounter++;
}

echo "<h3>Infrequently Asked Questions</h3>";
echo "<ul>";
echo "<li>Am I on the main exception list?";
echo "<ul>";
echo "<li>If you are (metaphorically) someone on the main exception list, that gets you on the list, but it doesn't excuse violations of Rule #8 (no watching my videos) or Rule #40 (no using this web site)</li>";
echo "</ul>";
echo "</li>";
echo "</ul>";

echo "</div>";

echo "</body>";
echo "</html>";
?>