document.getElementById('checkbox').onclick = function () {
    show(this, 'divShow');
};

function show(box, id) {

    var element = document.getElementById(id);

    if (box.checked) {
        element.style.display = 'block';
    } else {
        element.style.display = 'none';
    }
}