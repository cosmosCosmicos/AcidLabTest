$(document).ready(function () {

    $('.datepicker').datepicker({
        autoclose: true,
        format: " yyyy",
        viewMode: "years",
        minViewMode: "years",
        startDate: '1948',
        endDate: new Date(),
    });

    $("#Process").click(function () {
        var countrycode = $("#CountryCode option:selected").val();
        var startDate = $("#StartDate").val().trim();
        var endDate = $("#EndDate").val().trim();
        var jsonObject = { "countryCode": countrycode, "startYear": startDate, "endYear": endDate };
        $.ajax({
            type: "POST",
            url: "/Indicator/getIndicator",
            data: JSON.stringify(jsonObject),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            error: function (response) {
                alert(response.responseText);
            },
            success: function (response) {
                alert(response);
            }

        });

    });
});