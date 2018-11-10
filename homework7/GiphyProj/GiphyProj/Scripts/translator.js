console.log("In translator.js")



$("#Request").bind('keypress', function (e) {
    if (e.key === ' ' || e.key === 'Spacebar') {
        var word = $("#Request").val().split(" ").slice(-1);
        //console.log(word);

        if (word == "cat") {
            var source = "/Word/WordConvert/" + word;
        }
        else {
            var source = "/Word/FindGiphy/" + word;
        }
        //console.log(source);
    }

    $.ajax({
        type: "GET",
        dataType: "json",
        url: source,
        success: displayData,
        error: errorOnAjax
    });

});

function displayData(info) {
    //console.log(data);
    if (info.inputText != null) {
        $("#message").append(info.inputText + " ");
    }
    else if (info.data.type != "undefined") {
        $("#message").append("<img src='" + info.data.images.original_still.url + "' style='height:100px; width:100px;'/>" + " ");
    }
}

function errorOnAjax() {
    console.log("error");
}