function add() {
    let num1 = parseFloat(document.getElementById('input1').value);
    let num2 = parseFloat(document.getElementById('input2').value);
    if (isNaN(num1) || isNaN(num2)) {
        document.getElementById('result').innerHTML = "Please enter valid numbers.";
    } else {
        document.getElementById('result').innerHTML = num1 + num2;
    }
}

function subtract() {
    let num1 = parseFloat(document.getElementById('input1').value);
    let num2 = parseFloat(document.getElementById('input2').value);
    if (isNaN(num1) || isNaN(num2)) {
        document.getElementById('result').innerHTML = "Please enter valid numbers.";
    } else {
        document.getElementById('result').innerHTML = num1 - num2;
    }
}

function multiply() {
    let num1 = parseFloat(document.getElementById('input1').value);
    let num2 = parseFloat(document.getElementById('input2').value);
    if (isNaN(num1) || isNaN(num2)) {
        document.getElementById('result').innerHTML = "Please enter valid numbers.";
    } else {
        document.getElementById('result').innerHTML = num1 * num2;
    }
}

function divide() {
    let num1 = parseFloat(document.getElementById('input1').value);
    let num2 = parseFloat(document.getElementById('input2').value);
    if (isNaN(num1) || isNaN(num2)) {
        document.getElementById('result').innerHTML = "Please enter valid numbers.";
    } else if (num2 === 0) {
        document.getElementById('result').innerHTML = "Cannot divide by zero.";
    } else {
        document.getElementById('result').innerHTML = num1 / num2;
    }
}

function modulo() {
    let num1 = parseFloat(document.getElementById('input1').value);
    let num2 = parseFloat(document.getElementById('input2').value);
    if (isNaN(num1) || isNaN(num2)) {
        document.getElementById('result').innerHTML = "Please enter valid numbers.";
    } else if (num2 === 0) {
        document.getElementById('result').innerHTML = "Cannot divide by zero.";
    } else {
        document.getElementById('result').innerHTML = num1 % num2;
    }
}

function power() {
    let num1 = parseFloat(document.getElementById('input1').value);
    let num2 = parseFloat(document.getElementById('input2').value);
    if (isNaN(num1) || isNaN(num2)) {
        document.getElementById('result').innerHTML = "Please enter valid numbers.";
    } else {
        document.getElementById('result').innerHTML = Math.pow(num1, num2);
    }
}

function squareRoot() {
    let num1 = parseFloat(document.getElementById('input1').value);
    if (isNaN(num1) || num1 < 0) {
        document.getElementById('result').innerHTML = "Please enter a valid non-negative number.";
    } else {
        document.getElementById('result').innerHTML = Math.sqrt(num1);
    }
}
