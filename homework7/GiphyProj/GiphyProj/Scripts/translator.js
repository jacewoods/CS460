console.log("In translator.js")

// List of boring words to check against the input word
var boringWordDict =
    ["i'm", "to", "my", "and", "it", "where", "i", "me", "we", "us", "those",
        "you", "she", "he", "him", "they", "them", "going", "that", "which", "who",
        "whom", "whose", "is", "whichever", "whoever", "whomever", "this", "these",
        "anybody", "anyone", "anything", "each", "either", "everybody", "everyone",
        "everything", "neither", "nobody", "no", "nothing", "one", "somebody",
        "someone", "something", "both", "few", "many", "several", "all", "any",
        "most", "none", "some", "myself", "ourselves", "yourself", "yourselves",
        "himself", "herself", "itself", "themselves", "her", "its", "our",
        "your", "their", "mine", "yours", "his", "hers", "ours", "theirs"];

$("#UserWord").bind('keypress', function (e) {
    if (e.key === ' ' || e.key === 'Spacebar') {

        // Get the last word typed in input box
        var word = $("#UserWord").val().split(" ").slice(-1);

        // Checks if the input word is in the boring word dictionary
        var isBoring = false;
        for (var i = 0; i < boringWordDict.length; i++) {
            if (boringWordDict[i] == word[0].toLowerCase()) {
                isBoring = true;
            }
        }

        // If input word is boring, use BoringWords result, else use FindGiphy result
        if (isBoring == true) {
            var source = "/Word/BoringWords/" + word;
        }
        else {
            var source = "/Word/FindGiphy/" + word;
        }
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

function displayData(info) {
    // Use this if-statement if it is a boring word as determined in call above
    if (info.inputText != null) {
        $("#message").append(info.inputText + " ");
    }

    // Use this if-statement if it is another word and there is data in the json object
    else if (info.data.type != "undefined") {
        $("#message").append("<img src='" + info.data.images.original_still.url + "' style='height:140px; width:140px; margin:25px;'/>");
    }
}

function errorOnAjax() {
    console.log("error");
}