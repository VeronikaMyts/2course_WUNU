<?php

class User {
    public $surname;
    public $name;
    public $age;
    public $email;


    public function __construct($surname, $name, $age, $email) {
        $this->surname = $surname;
        $this->name = $name;
        $this->age = $age;
        $this->email = $email;
    }

    //  отримання повного імені користувача
    public function getFullName() {
        return $this->surname . ' ' . $this->name;
    }

    //  виведення інформації про користувача
    public function getInfo() {
        return "Прізвище: {$this->surname}, Ім'я: {$this->name}, Вік: {$this->age}, E-mail: {$this->email}";
    }
}


$user1 = new User("Петренко", "Іван", 25, "ivan@example.com");
$user2 = new User("Сидоренко", "Марина", 30, "marina@example.com");

echo $user1->getInfo() . "<br>";
echo $user2->getInfo() . "<br>";
?>



