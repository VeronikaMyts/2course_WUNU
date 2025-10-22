const readline = require('readline');

const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});


function inputNumbers() {
    return new Promise((resolve, reject) => {
        rl.question('Введіть три цілих числа через пробіл: ', (input) => {
            const numbers = input.split(' ').map(num => parseInt(num));
            if (numbers.length !== 3 || numbers.some(isNaN)) {
                reject(new Error('Введені дані мають бути три цілі числа, розділені пробілом.'));
            } else {
                resolve(numbers);
            }
        });
    });
}


function findMin(numbers) {
    return Math.min(...numbers);
}


function findTwoMin(numbers) {
    const sortedNumbers = numbers.slice().sort((a, b) => a - b);
    return sortedNumbers.slice(0, 2);
}
function calculateAverage(numbers) {
    const sum = numbers.reduce((acc, curr) => acc + curr, 0);
    return sum / numbers.length;
}


async function main() {
    let numbers;
    try {
        numbers = await inputNumbers();
    } catch (error) {
        console.error(error.message);
        rl.close();
        return;
    }

    let choice;
    do {
        console.log('\nМеню:');
        console.log('1) Вивести найменше число');
        console.log('2) Вивести два менші числа');
        console.log('3) Обчислити середнє арифметичне');
        console.log('4) Вийти');

        choice = await new Promise((resolve) => {
            rl.question('\nВаш вибір: ', (input) => {
                resolve(parseInt(input));
            });
        });

        switch (choice) {
            case 1:
                console.log('Найменше число: ', findMin(numbers));
                break;
            case 2:
                console.log('Два менші числа: ', findTwoMin(numbers));
                break;
            case 3:
                console.log('Середнє арифметичне: ', calculateAverage(numbers));
                break;
            case 4:
                console.log('До побачення!');
                break;
            default:
                console.log('Неправильний вибір. Спробуйте ще раз.');
        }

    } while (choice !== 4);

    rl.close();
}


main();
