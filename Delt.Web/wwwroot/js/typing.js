$(function () {
    typitvs();
});

function typitvs() {
    var h2 = $(".main h2, h1");
    var text = $(h2).text();
    $(h2).text("");
    var i = 0;
    var len = text.length;
    setInterval(function () {
        if (i < len) {
            $(h2).append(text[i]);
            i++;
        }
    }, 100);
}