<?php
function findMinElementAndIndex($array) {
    $minValue = $array[0][0];
    // використовуватися для збереження мін. значення

    $minRowIndex = 0;
    $minColIndex = 0;

    $rows = count($array);
    $cols = count($array[0]);

    // Проходимо по всіх елементах масиву, щоб знайти мінімальний елемент та його індекси
    for ($i = 0; $i < $rows; $i++) {
        for ($j = 0; $j < $cols; $j++) {
            if ($array[$i][$j] < $minValue) {
                $minValue = $array[$i][$j];
                $minRowIndex = $i;
                $minColIndex = $j;
            }
        }
    }

    // Повертаємо мінімальний елемент та його індекси у вигляді асоціативного масиву
    return array(
        'value' => $minValue,
        'row' => $minRowIndex,
        'col' => $minColIndex
    );
}

// Задання масиву FR(4,6)
$FR = array(
    array(3, 8, 2, 7, 1, 9),
    array(4, 6, 5, 3, 2, 8),
    array(9, 2, 6, 1, 5, 4),
    array(7, 3, 1, 8, 4, 2)
);

// Знаходження мінімального елемента та його індексів
$result = findMinElementAndIndex($FR);

// Виведення результатів на екран
echo "Мінімальний елемент: " . $result['value'] . "\n";
echo "Індекс рядка: " . $result['row'] . "\n";
echo "Індекс стовпця: " . $result['col'] . "\n";

