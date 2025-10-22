<?php
$string1 = "Hello, Students!";
$string2 = "Hello, PHPStorm!";

// Кількість символів для порівняння
$n = 5;

// Відділення перших n символів з кожного рядка
$substring1 = substr($string1, 0, $n);
$substring2 = substr($string2, 0, $n);

// Порівняння підстрічок (строга рівність)
if ($substring1 === $substring2) {
    echo "Перші $n символів рівні: $substring1\n";
} else {
    echo "Перші $n символів не рівні:\n";
    echo "Рядок 1: $substring1\n";
    echo "Рядок 2: $substring2\n";
}