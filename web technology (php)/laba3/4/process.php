<?php
// Перевіряємо, чи всі поля заповнені
if(isset($_POST['surname']) && isset($_POST['name']) && isset($_POST['age']) && isset($_POST['email'])) {
    // Отримуємо дані з форми
    $surname = $_POST['surname'];
    $name = $_POST['name'];
    $age = $_POST['age'];
    $email = $_POST['email'];

    // Створюємо об'єкт користувача
    $user = new User($surname, $name, $age, $email);

    // Виводимо дані користувача
    $user->displayInfo();

} else {
    echo "Будь ласка, заповніть всі поля!";
}

// Клас користувача
class User {
    public $surname;
    public $name;
    public $age;
    public $email;


    function __construct($surname, $name, $age, $email) {
        $this->surname = $surname;
        $this->name = $name;
        $this->age = $age;
        $this->email = $email;
    }


    function displayInfo() {
        echo "Прізвище: " . $this->surname . "<br>";
        echo "Ім'я: " . $this->name . "<br>";
        echo "Вік: " . $this->age . "<br>";
        echo "E-mail: " . $this->email . "<br>";
    }

}
?>
