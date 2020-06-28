var vetObj = [{id:0}];

var btnSbt = $("#send");

btnSbt.on('click', function () {

    var obj = { text: $("#message").val() };

    addObj(obj);

});

function addObj(obj) {

    obj.date = new Date();
    obj.id = vetObj[vetObj.length - 1].id + 1;
    obj.source = true;

    alert(obj.text);

    vetObj.push(obj);
}




