<?php

function generateKey() {
    $original_alphabet = range('A', 'Z'); // Оригінальний алфавіт
    $shuffled_alphabet = $original_alphabet;
    shuffle($shuffled_alphabet); // Перемішуємо алфавіт
    $key = array_combine($original_alphabet, $shuffled_alphabet);
    return $key;
}


function encryptText($text, $key) {
    $encrypted_text = '';
    $text = strtoupper($text);
    for ($i = 0; $i < strlen($text); $i++) {
        $char = $text[$i];

        $encrypted_text .= isset($key[$char]) ? $key[$char] : $char;
    }
    return $encrypted_text;
}


function decryptText($encrypted_text, $key) {
    $decrypted_text = '';
    foreach (str_split($encrypted_text) as $char) {

        $decrypted_text .= array_search($char, $key) ?: $char;
    }
    return $decrypted_text;
}



// Генеруємо ключ
$key = generateKey();
print_r($key);


$text_to_encrypt = "HELLO WORLD";

// Шифруємо текст
$encrypted_text = encryptText($text_to_encrypt, $key);
echo "Encrypted Text: " . $encrypted_text . "\n";


$decrypted_text = decryptText($encrypted_text, $key);
echo "Decrypted Text: " . $decrypted_text . "\n";
?>