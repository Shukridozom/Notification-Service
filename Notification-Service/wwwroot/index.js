$(document).ready(function(){
    $("#btn-send").click(function(){

        let adminToken = $("#admin-token").val();
        let fcmToken = $("#fcm-token").val();
        let title = $("#title").val();
        let body = $("#body").val();

        var settings = {
            "url": "https://localhost:7251/api/FCM",
            "method": "POST",
            "timeout": 0,
            "headers": {
                "Content-Type": "application/json",
                "Authorization": "Bearer " + adminToken
            },
            "data": JSON.stringify({
                "token": fcmToken,
                "title": title,
                "body": body
            }),
        };

        $.ajax(settings).done(function (response) {
            console.log(response);
        });



        // $.ajax({
        //     url:"https://localhost:7251",
        //     type: "POST",
        //     statusCode:{
        //         401: function(){alert("Error")},
        //         400: function(){alert("unAuth")},
        //         200: function(){alert("unAuth")}
        //     }
        // });
    });
});