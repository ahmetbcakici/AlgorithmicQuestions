<?php
$number = 32;
$arr = array();
$c = false;
for($i = 3,$cntr = 0;$i < $number;$i++){
		for($j = 2;$j < $i;$j++){
			if($i % $j == 0){
				$c = false;
				break;
			}
			else
				$c = true;
		}
		if ($c == true){
			$arr[$cntr] = $i;
			$cntr++;
		}
		$c = false;
}
$max = 0;
foreach($arr as $item){
	if($max < $item) $max = $item;
}
echo $max;
?>