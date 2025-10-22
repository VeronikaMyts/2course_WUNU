<?php
class MultiplicationTable {
    private $number;
// таблиця
    public function __construct($number) {
        $this->number = $number;
    }

    public function generateTable() {
        echo "<h2>Таблиця множення для числа {$this->number}</h2>";
        echo "<table border='1'>";

        for ($i = 1; $i <= 10; $i++) {
            echo "<tr>";
            echo "<td>{$this->number}</td>";
            echo "<td>*</td>";
            echo "<td>{$i}</td>";
            echo "<td>=</td>";
            echo "<td>" . ($this->number * $i) . "</td>";
            echo "</tr>";
        }
        echo "</table>";
    }
}


$table2 = new MultiplicationTable(2);
$table3 = new MultiplicationTable(3);
$table5 = new MultiplicationTable(5);

// Виводимо
$table2->generateTable();
$table3->generateTable();
$table5->generateTable();

?>
