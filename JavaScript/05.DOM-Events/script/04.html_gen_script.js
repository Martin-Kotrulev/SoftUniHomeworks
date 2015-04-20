function HTMLGenerator(){}
HTMLGenerator.prototype.createParagraph = function(id, text) {
    var p = document.createElement('p');
    p.innerHTML = text;
    document.getElementById(id).appendChild(p);
};
HTMLGenerator.prototype.createDiv = function(id, classs) {
    var div = document.createElement('div');
    div.setAttribute('class', classs);
    div.innerHTML = "I'm a div and I am alive!";
    document.getElementById(id).appendChild(div);
};
HTMLGenerator.prototype.createLink = function(id, text, url) {
    var link = document.createElement('a');
    link.setAttribute('href', url);
    link.innerHTML = text;
    document.getElementById(id).appendChild(link);
};

HTMLGen = new HTMLGenerator();
HTMLGen.createParagraph('wrapper', 'Soft Uni');
HTMLGen.createDiv('wrapper', 'section');
HTMLGen.createLink('book', 'C# basics book', 'http://www.introprogramming.info/');