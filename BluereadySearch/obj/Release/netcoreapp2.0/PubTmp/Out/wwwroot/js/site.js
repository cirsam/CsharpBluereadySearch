// Write your JavaScript code.
"use strict";
(function () {
    $("input[name=post]").click(function () {
        if ($("#contact_type").val() == "") {
            alert("You must select a department");

            return false;
        }

        $.post("/home/EmailMessage", { firstname: $("input[name=firstname]").val(), lastname: $("input[name=lastname]").val(), email: $("input[name=email]").val(), phone: $("input[name=phone]").val(), message: $("textarea[name=message]").val() }, function (data) {

            $("#contactus").html("<h1 style=\"color:green;\">" + data + " we will be in touch within 24 hours.</h1>");

        });
    });
})();