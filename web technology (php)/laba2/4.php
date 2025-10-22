<?php

$counter_file = 'counter.txt';

function incrementCounter($counter_file) {

if (file_exists($counter_file))  {

$count = (int)file_get_contents($counter_file);
$count++;
file_put_contents($counter_file, $count);
} else {

file_put_contents($counter_file, 1);
}
}

// Функція для перевірки
function checkAndDisplayMessage($counter_file) {
$count = (int)file_get_contents($counter_file);
if ($count % 10 == 0) {
echo "Ласкаво просимо! Ця сторінка відвідана $count разів.";
}
}


incrementCounter($counter_file);


checkAndDisplayMessage($counter_file);
?>

