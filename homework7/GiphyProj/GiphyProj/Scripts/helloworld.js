console.log("In helloworld.js")



$("#Request").bind('keypress', function (e) {
    if (e.key === ' ' || e.key === 'Spacebar') {
        //$("#message").append("Hello, World! ");
        var a = $("#Request").val();
        console.log(a);
        var source = "/Hello/HelloWorld/" + a;
        console.log(source);
    }

    $.ajax({
        type: "GET",
        dataType: "json",
        url: source,
        success: displayData,
        error: errorOnAjax
    });

});

function displayData(data) {
    console.log(data);
    $("#message").append(data["test"] + " ");
}

function errorOnAjax() {
    console.log("error");
}