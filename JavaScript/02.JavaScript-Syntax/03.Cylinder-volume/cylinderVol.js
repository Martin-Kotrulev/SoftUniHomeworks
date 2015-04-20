function calcCylinderVol(arr) {
    var radius = arr[0],
        height = arr[1],
        volume = (Math.PI * Math.pow(radius, 2) * height).toFixed(3);
    console.log(volume);
}

calcCylinderVol([2, 4]);
calcCylinderVol([5, 8]);
calcCylinderVol([12, 3]);