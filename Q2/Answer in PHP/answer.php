<?php
$number = 5;#We could take value from user via HTML but i prefer give value manually
$cntr = 0;
$c = false;
for($i = 2;;$i++){
	if($cntr >= $number) break;
	else{
		for($j=2;$j<$i;$j++){
			if($i % $j == 0){
				$c = true;
				break;
			}
		}
		if($c == false){
			echo $i." ";
			$cntr++;
		}
		$c = false;			
	}
}

?>