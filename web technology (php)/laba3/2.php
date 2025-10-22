<?php

class Country {
    public $name;
    public $population;
    public $capital;

    public function __construct($name, $population, $capital) {
        $this->name = $name;
        $this->population = $population;
        $this->capital = $capital;
    }
}

// масив об'єктів країн
$countries = array(
    new Country("Україна", 44000000, "Київ"),
    new Country("США", 328000000, "Вашингтон"),
    new Country("Китай", 1390000000, "Пекін")
);


echo "<table border='1'>";
//Перебирає кожний елемент масиву та присвоює
foreach ($countries as $country) {
    echo "<tr>";
    echo "<td>Назва країни</td><td>{$country->name}</td>";
    echo "</tr>";
    echo "<tr>";
    echo "<td>Населення</td><td>{$country->population}</td>";
    echo "</tr>";
    echo "<tr>";
    echo "<td>Столиця</td><td>{$country->capital}</td>";
    echo "</tr>";
}
echo "</table>";

?>


