console.log("In hellowworld.js")



$("#Request").keypress(function (e) {
    if (e.key === ' ' || e.key === 'Spacebar') {
        $("#message").html("Hello, World.");
        var a = 5;
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
    $("message").text(data["message"]);
}

function errorOnAjax() {
    console.log("error");
}