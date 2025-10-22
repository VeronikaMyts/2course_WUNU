<?php
function ArrMax($array)//приймає однорівневий числовий
// масив як параметр і повертає його максимальний елемент
{
    $max=$array[0];//ініціалізується значенням першого елемента масиву(0)

    for($i=1; $i< count($array); $i++)
    {
        if($array[$i]>$max)
        {
            $max=$array[$i];
        }
    }
    return $max;
}
$array=[3,5,4,2,6,9];
$max=ArrMax($array);
echo"Максимальний елемент масиву:$max";