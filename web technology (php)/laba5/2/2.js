function calculate() {

    var length = parseFloat(document.getElementById('length').value);
    var width = parseFloat(document.getElementById('width').value);


    if (isNaN(length) || isNaN(width)) {

        document.getElementById('perimeter').innerText = '0';
        document.getElementById('area').innerText = '0';
        document.getElementById('diagonal').innerText = '0';
        return;
    }


    var perimeter = 2 * (length + width);


    var area = length * width;


    var diagonal = Math.sqrt(Math.pow(length, 2) + Math.pow(width, 2));


    document.getElementById('perimeter').innerText = perimeter.toFixed(4);
    document.getElementById('area').innerText = area.toFixed(4);
    document.getElementById('diagonal').innerText = diagonal.toFixed(4);
}


document.getElementById('length').addEventListener('input', calculate);
document.getElementById('width').addEventListener('input', calculate);
