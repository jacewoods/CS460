
console.log("In watchbid.js");
var id = window.location.href.split("/").slice(-1)[0];

$(document).ready(function () {
    var source = "/Items/ShowBids/" + id;

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

        var bidUpdater = "<table class = \"table\"><thead><tr><th>Buyer Name</th><th>Bid Price</th></tr></thead><tbody>";

        $.each(data, function (i, item) {

            bidUpdater += "<tr>" + "<td>" + item.BuyerName +
                "</td>" + "<td> $" + item.Price + "</td>" + "</tr>";

        });

        $("#message").html(bidUpdater);

    }
});
function errorOnAjax() {
    console.log("error");
}