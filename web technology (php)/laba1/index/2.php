<?php
function isPalindrome($number)
{
    $number = (string)$number; // Перетворюємо число на рядок для зручності порівняння
    // Порівнюємо першу половину рядка зі зворотньою другої половини
    $length = strlen($number);//визначає довжину рядка
    for ($i = 0; $i < $length / 2; $i++) {
        if ($number[$i] !== $number[$length - $i - 1]) {
            return false;
        }
    }
    return true;
}
$number=12323;
if (isPalindrome($number)) {
    echo "$number - є паліндромом";
} else {
    echo "$number - не є паліндромом";
}
