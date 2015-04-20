function getCircleArea(radius) {
    return Math.PI * radius * radius;
}

var input = [7, 1.5, 20];
for (var item in input) {
    document.write('<p>r = '+input[item]+'; area = '+getCircleArea(input[item])+'</p>');
}