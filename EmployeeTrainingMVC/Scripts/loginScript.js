$(function () {

    let form = document.querySelector('form');

    form.addEventListener('submit', (e) => {
        e.preventDefault();
        return false;
    });

    $("#btnRegister").click(function () {
        //toastr.info('Page under construction');
        //console.log("here")
        window.location = '/Account/Register';

    });

    //clcik event for sign in button
    //fetch()
    $("#btnLogin").click(function () {

        var emailAddress = $("#emailAddress").val();
        var password = $("#password").val();

        if (emailAddress == '' || password == '') {
            toastr.error("Username and Password cannot be null");
            return false;
        }

        var Obj = { Email: emailAddress, Password: password };
        $.ajax({
            type: "POST",
            url: "/Account/Authenticate",
            data: Obj,
            dataType: "json",
            success: function (response) {
                if (response.result) {

                    toastr.success("Authentication Succeed. Redirecting to relevent page.....");
                    window.location = response.url;

                    //setTimeout(() => {
                    //    window.location = response.url;
                    //}, 2000)
                }
                else {
                    toastr.error('Unable to Authenticate user');
                    return false;
                }
            },
            failure: function (response) {
                toastr.error('Unable to make request!!');
            },
            error: function (response) {
                toastr.error('Something happened, Please contact Administrator!! ', response);

            }
        });
    });



});