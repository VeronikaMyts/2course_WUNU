<?php
function countDigits($n) {
    return strlen((string)$n);
}

function sumOfDigits($n) {
    $sum = 0;
    while ($n != 0) {
        $sum += $n % 10;
        $n = (int)($n / 10);
    }
    return $sum;
}

// Приклад використання:
$n = 12345;
echo "Кількість цифр у числі $n: " . countDigits($n) . "\n";
echo "Сума цифр числа $n: " . sumOfDigits($n);
?>
