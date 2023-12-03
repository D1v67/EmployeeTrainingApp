//$(function () {



//    let form = document.querySelector('form');

//    form.addEventListener('submit', (e) => {
//        e.preventDefault()
//        return false;
//    });

//    var password = $('#Password').val();
//    var confirmPassword = $('#ConfirmPassword').val();

//    if (password !== confirmPassword) {
//        alert("Password and Confirm Password do not match.");
//        return;
//    }

//    var formData = {
//        FirstName: $('#FirstName').val(),
//        LastName: $('#LastName').val(),
//        Email: $('#Email').val(),
//        NIC: $('#NIC').val(),
//        MobileNumber: $('#MobileNumber').val(),
//        Password: password,

//    };

//    //clcik event for sign in button
//    //fetch()
//    $("#btnRegister").submit(function () {


   
//        $.ajax({
//            type: "POST",
//            url: "/Account/Register",
//            data: {
//                FirstName: $('#FirstName').val(),
//                LastName: $('#LastName').val(),
//                Email: $('#Email').val(),
//                NIC: $('#NIC').val(),
//                MobileNumber: $('#MobileNumber').val(),
//                Password: password
//            },
//            dataType: "json",
//            success: function (response) {
//                if (response.result) {

//                    toastr.success("Authentication Succeed. Redirecting to relevent page.....");
//                    window.location = response.url;

//                    //setTimeout(() => {
//                    //    window.location = response.url;
//                    //}, 2000)
//                }
//                else {
//                    toastr.error('Unable to Authenticate user');
//                    return false;
//                }
//            },
//            failure: function (response) {
//                toastr.error('Unable to make request!!');
//            },
//            error: function (response) {
//                toastr.error('Something happened, Please contact Administrator!!');

//            }
//        });
//    });



//});