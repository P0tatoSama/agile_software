<!DOCTYPE html>
<html>
<?php
		session_start();
		include "connection.php";
	?>
<head>
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
<style>
.dropbtn2 {
  background-color: red;
  color: white;
  padding: 16px;
  font-size: 16px;
  border: none;
}

.dropdown2 {
  position: relative;
  display: inline-block;
}

.dropdown-content2 {
  display: none;
  position: absolute;
  background-color: #f1f1f1;
  min-width: 220px;
  box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.2);
  z-index: 1;
}

.dropdown-content2 a {
  color: black;
  padding: 12px 16px;
  text-decoration: none;
  display: block;
}

.dropdown-content2 a:hover {background-color: #ddd;}

.dropdown2:hover .dropdown-content2 {display: block;}

.dropdown2:hover .dropbtn2 {background-color: red;}



.show {display: block;}
* {box-sizing: border-box;}

body {
  margin: 0;
  font-family: Arial, Helvetica, sans-serif;
}

.topnav {
  overflow: hidden;
  background-color: #e9e9e9;
}

.topnav a {
  float: left;
  display: block;
  color: black;
  text-align: center;
  padding: 14px 16px;
  text-decoration: none;
  font-size: 17px;
}

.topnav a:hover {
  background-color: #ddd;
  color: black;
}

.topnav a.active {
  background-color: #2196F3;
  color: white;
}

.topnav .search-container {
  float: right;
}

.topnav input[type=text] {
  padding: 6px;
  margin-top: 8px;
  font-size: 17px;
  border: none;
}

.topnav .search-container button {
  float: right;
  padding: 6px 10px;
  margin-top: 8px;
  margin-right: 16px;
  background: #ddd;
  font-size: 17px;
  border: none;
  cursor: pointer;
}

.topnav .search-container button:hover {
  background: #ccc;
}

@media screen and (max-width: 600px) {
  .topnav .search-container {
    float: none;
  }
  .topnav a, .topnav input[type=text], .topnav .search-container button {
    float: none;
    display: block;
    text-align: left;
    width: 100%;
    margin: 0;
    padding: 14px;
  }
  .topnav input[type=text] {
    border: 1px solid #ccc;  
  }
}
</style>
</head>
<body>

<div class="topnav">
  <a class="active" href="default.php">Home</a>
  <div class="search-container">
    <form action="relevant.php" method="post">
      <input type="text" placeholder="Search your location here" name="search">
      <button type="submit"><i class="fa fa-search"></i></button>
    </form>
  </div>
</div>

<div style="padding-left:80px">
  <h2>Location Result</h2>
<form action="rating.php" method="post" style="float:left;">
      <button type="submit">Sort by Rating</button>
      &nbsp;&nbsp;
    </form>
          <form action="review.php" method="post">
      <button type="submit">Sort by Review</button>
    </form>
<?php
	if(isset($_POST['search'])) {
	$searchq = $_POST['search'];
	$searchq = preg_replace("#[^0-9a-z]#i"," ",$searchq);
	
	$query = "SELECT * FROM location WHERE Location_Name LIKE '%$searchq%'";
	$result = mysqli_query($connect, $query);
	//if($count == 0){
		//$output = 'There was no search results!';
		//}else{
			while($rows=mysqli_fetch_array($result))
		{	
        echo "<section id='abouts' class='abouts'>";
        echo "<div class='container'>";
        echo "<div class='row'>";
        echo "<div class='abouts_content'>";
        echo "<div class=' text-left'>";
        echo "<div class='col-md-6'>";
        echo "<h4>". $rows['Location_Name'] ."</h4>";
        echo "<img src='" . $rows['Location_Photo'] . "'/>";
        echo "</div>";
        echo "<div class='col-md-6'>";
        
        echo "<p>". $rows['Location_Rating'] ."</p>";
        echo "<p>". $rows['Location_Review'] ."</p>";
        echo "<p>". $rows['Location_Address'] ."</p>";
        echo "<br/><br/>";
        echo "</div>";
        echo "</div>";
        echo "</div>";
        echo "</div>";
        echo "</div>";
        echo "</section>";
		}
		//}

	
	}
?>
<script>
/* When the user clicks on the button, 
toggle between hiding and showing the dropdown content */
function myFunction() {
  document.getElementById("myDropdown").classList.toggle("show");
}

// Close the dropdown if the user clicks outside of it
window.onclick = function(event) {
  if (!event.target.matches('.dropbtn')) {
    var dropdowns = document.getElementsByClassName("dropdown-content");
    var i;
    for (i = 0; i < dropdowns.length; i++) {
      var openDropdown = dropdowns[i];
      if (openDropdown.classList.contains('show')) {
        openDropdown.classList.remove('show');
      }
    }
  }
}
</script>  
</div>

</body>
</html>
