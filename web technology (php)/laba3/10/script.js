let currentPlayer = 'X';
let cells = Array.from(document.querySelectorAll('.cell'));
let gameStatus = document.getElementById('status');

function checkWinner() {
    const winningCombos = [
        [0, 1, 2], [3, 4, 5], [6, 7, 8], // Rows
        [0, 3, 6], [1, 4, 7], [2, 5, 8], // Columns
        [0, 4, 8], [2, 4, 6]              // Diagonals
    ];

    for (let combo of winningCombos) {
        if (
            cells[combo[0]].innerText === currentPlayer &&
            cells[combo[1]].innerText === currentPlayer &&
            cells[combo[2]].innerText === currentPlayer
        ) {
            return true;
        }
    }
    return false;
}

function checkDraw() {
    return cells.every(cell => cell.innerText !== '');
}

function makeMove(index) {
    if (cells[index].innerText === '') {
        cells[index].innerText = currentPlayer;
        if (checkWinner()) {
            gameStatus.innerText = `Гравець ${currentPlayer} виграв!`;
            cells.forEach(cell => cell.onclick = null);
        } else if (checkDraw()) {
            gameStatus.innerText = "Це нічия!";
        } else {
            currentPlayer = currentPlayer === 'X' ? 'O' : 'X';
            gameStatus.innerText = `Гравця ${currentPlayer} черга`;
        }
    }
}

function resetGame() {
    currentPlayer = 'X';
    cells.forEach(cell => {
        cell.innerText = '';
        cell.onclick = function () {
            makeMove(cells.indexOf(cell));
        };
    });
    gameStatus.innerText = `Гравця ${currentPlayer} черга`;
}
