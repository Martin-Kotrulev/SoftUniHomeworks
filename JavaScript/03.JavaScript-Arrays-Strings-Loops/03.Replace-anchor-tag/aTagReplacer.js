/**
 * 03. Replace <a> Tag
 * Write a JavaScript function replaceATag(str) that replaces in a
 * HTML document given as string all the tags <a href="…">…</a> with
 * corresponding tags [URL=…]…/URL]. Write JS program aTagReplacer.js
 * that invokes your function with the sample input data below and prints the output at the console.
 */

function replaceATag(str) {

    str = str.replace(/(<a)/g, '[URL');
    str = str.replace(/(>\b)/g, ']');
    str = str.replace(/(<\/a>)/g, '[/URL]');
    str = str.replace('><', '>\n\t<');
    str = str.replace('>[', '>\n\t\t[');
    str = str.replace(']<', ']\n\t<');
    str = str.replace('><', '>\n<');
    console.log(str);
}

replaceATag(
    '<ul>' +
    '<li>' +
    '<a href=http://softuni.bg>SoftUni</a>' +
    '</li>' +
    '</ul>'
);