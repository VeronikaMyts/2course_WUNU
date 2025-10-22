<?php

function getColor($minute)
{
    $cycle_minute = $minute % 5;
    if ($cycle_minute < 3) {
        return "Зелений";
    } else {
        return "Червоний";
    }
}


$minute = 2;
echo "Сигнал світлофора на $minute хвилині: " . getColor($minute);
?>