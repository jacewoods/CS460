
console.log("In watchbid.js");
var DetailID = window.location.href.split("/").slice(-1)[0];

$(document).ready(function () {
    console.log(DetailID);
    var source = "/Items/ShowBids/" + DetailID;
    console.log(source);
    var ajax_call = function () {
        $.ajax({
            type: "GET",
            dataType: "json",
            url: source,
            success: displayData,
            error: errorOnAjax
        });
    };

    var interval = 1000 * 5;
    window.setInterval(ajax_call, interval);


    function displayData(data) {

        //data.test += 1;

        console.log(data);
        if (data["test"] !== null) {
            $("#message").html(data["test"] + " ");
        }
    }
});
function errorOnAjax() {
    console.log("error");
}