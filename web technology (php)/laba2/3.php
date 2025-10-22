<?php
function highlightWord($text, $word) {
    // Разбиваємо текст на слова
    $words = preg_split("/[\s,]+/", $text);


    foreach ($words as &$w) {
        if (stripos($w, $word) !== false) {
            $w = '<span style="color:red">' . $w . '</span>';
        }
    }

    return implode(" ", $words);
}

$text = "MasterWebs - Форум веб-майстрів";
$word = "майстр";

echo highlightWord($text, $word);
?>