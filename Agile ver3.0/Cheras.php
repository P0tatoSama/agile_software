<!DOCTYPE html>
<html>
<?php
		session_start();
		include "connection.php";
	?>
<head>
<link rel="stylesheet" href="font-awesome.min.css">
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


.dropbtn1 {
  background-color: #4CAF50;
  color: white;
  padding: 16px;
  font-size: 16px;
  border: none;
}

.dropdown1 {
  position: relative;
  display: inline-block;
}

.dropdown-content1 {
  display: none;
  position: absolute;
  background-color: #f1f1f1;
  min-width: 160px;
  box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.2);
  z-index: 1;
}

.dropdown-content1 a {
  color: black;
  padding: 12px 16px;
  text-decoration: none;
  display: block;
}

.dropdown-content1 a:hover {background-color: #ddd;}

.dropdown1:hover .dropdown-content1 {display: block;}

.dropdown1:hover .dropbtn1 {background-color: #3e8e41;}


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

.dropbtn {
  background-color: #3498DB;
  color: white;
  padding: 16px;
  font-size: 16px;
  border: none;
  cursor: pointer;
}

.dropbtn:hover, .dropbtn:focus {
  background-color: #2980B9;
}

.dropdown {
  position: relative;
  display: inline-block;
}

.dropdown-content {
  display: none;
  position: absolute;
  background-color: #f1f1f1;
  min-width: 160px;
  overflow: auto;
  box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.2);
  z-index: 1;
}

.dropdown-content a {
  color: black;
  padding: 12px 16px;
  text-decoration: none;
  display: block;
}

.dropdown a:hover {background-color: #ddd;}

.show {display: block;}
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
  <h2>Location In Cheras</h2>
<div class="dropdown1">
  <button class="dropbtn1">Sort By</button>
  <div class="dropdown-content1">
    <a href="rating.php">Rating</a>
    <a href="review.php">Review</a>
  </div>
</div>

<div class="dropdown">
  <button onclick="myFunction()" class="dropbtn">Select City</button>
  <div id="myDropdown" class="dropdown-content">
    <a href="Setapak.php">Setapak</a>
    <a href="Cheras.php">Cheras</a>
    <a href="BukitJalil.php">Bukit Jalil</a>
    <a href="BukitBintang.php">Bukit Bintang</a>
    <a href="SubangJaya.php">Subang Jaya</a>
  </div>
</div>

<div class="dropdown2">
  <button class="dropbtn2">Category</button>
  <div class="dropdown-content2">
    <a href="FnB.php">Food & Beverage</a>
    <a href="AnE.php">Attraction & Entertainment</a>
  </div>
</div>

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

<?php	
	$query = "SELECT * FROM location WHERE Location_City = 'Cheras' ORDER BY Location_Name ASC";
	$result = mysqli_query($connect, $query);
	$i=0;
		while($rows=mysqli_fetch_array($result))
		{	
        echo "<section ID='abouts' class='abouts'>";
        echo "<div class='container'>";
        echo "<div class='row'>";
        echo "<div class='abouts_content'>";
        echo "<div class=' text-left'>";
        echo "<div class='col-md-6'>";
        echo "<h4>". $rows['Location_Name'] ."</h4>";
        echo "<img src='" . $rows['Location_Photo'] . "'/>";
        echo "</div>";
        echo "<div class='col-md-6'>";
        echo "<p>". $rows['Location_City'] ."</p>";
        echo "<p>". $rows['Location_Rating'] ." Rating</p>";
        echo "<p>". $rows['Location_Review'] ." Review</p>";
        echo "<p>". $rows['Location_Address'] ."</p>";
        echo "<br/><br/>";
        echo "</div>";
        echo "</div>";
        echo "</div>";
        echo "</div>";
        echo "</div>";
        echo "</section>";
         $i++;
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
