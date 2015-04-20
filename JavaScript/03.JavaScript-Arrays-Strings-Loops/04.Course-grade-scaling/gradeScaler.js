/**
 * 04. Course grade scaling
 * You are given a JSON string containing an array of Students (Objects).
 * Your task is to scale their scores upwards by increasing them with 10%.
 * After that you should add a field that shows whether the student
 * has passed or failed the exam (passed exam means 100 or more points at the exam).
 * Finally you should filter out only the students that have passed the exam and print them out sorted alphabetically.
 */

function getPassed(students) {

    var result = [];
    for (var i in students) {
        students[i].score = parseFloat(((Number(students[i].score))*1.1).toFixed(1));

        if(students[i].score > 100){
            students[i].hasPassed = true;
        }else{
            students[i].hasPassed = false;
        }
    }

    result = students.filter(function(a){
        return a.hasPassed === true;
    })

    result.sort(function (a, b){
        return a.name > b.name;
    });

    console.log(JSON.stringify(result));

}

getPassed([
    {
        'name' : 'Пешо',
        'score' : 91
    },
    {
        'name' : 'Лилия',
        'score' : 290
    },
    {
        'name' : 'Алекс',
        'score' : 343
    },
    {
        'name' : 'Габриела',
        'score' : 400
    },
    {
        'name' : 'Жичка',
        'score' : 70
    }

])