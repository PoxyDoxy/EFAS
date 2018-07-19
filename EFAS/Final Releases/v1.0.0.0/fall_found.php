<?php

// EFAS - HTTP GET - Website Response Code
// Used to process the Messages from the EFAS Application
// This script is a proof of concept. DO NOT trust the security of the code below.

$collected_data_points = 0;
$long = "";
$lat = "";
$stalegps = "";
$time = "";
$fallposition = "";
$test = "";

if(isset($_GET["long"])) {
	$long = $_GET["long"];
	if(preg_match("/(\d+\.\d+)/", $long)){
		$collected_data_points++;
	}
}

if(isset($_GET["lat"])) {
	$lat = $_GET["lat"];
	if(preg_match("/(\d+\.\d+)/", $lat)){
		$collected_data_points++;
	}
}

if(isset($_GET["stalegps"])) {
	$stalegps = $_GET["stalegps"];
	$stalegps = strtolower($stalegps);
	if($stalegps == "true" | $stalegps == "false"){
		$collected_data_points++;
	}
}

if(isset($_GET["time"])) {
	$time = $_GET["time"];
		if(preg_match("/(\d+\.\d+)/", $time)){
		$collected_data_points++;
	}
}

if(isset($_GET["fallposition"])) {
	$fallposition = $_GET["fallposition"];
	$collected_data_points++;
}

if(isset($_GET["test"])) {
	$test = $_GET["test"];
	$test = strtolower($test);
	if($test == "true" | $test == "false"){
		$collected_data_points++;
	}
}

if($collected_data_points == 6){
	// All 6 data points have been collected. Return the values back.
	echo "WEBSITE RESPONSE: Long:[$long] Lat:[$lat] StaleGPS:[$stalegps] Time:[$time] FallPosition:[$fallposition] Test[$test]";
} else {
	// Else spit out an error.
	echo "WEBSITE RESPONSE: Error -> Data not recieved correctly.";
}

?>