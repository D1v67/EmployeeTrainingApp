function registerUser() {
    var password = $('#Password').val();
    var confirmPassword = $('#ConfirmPassword').val();

    if (password !== confirmPassword) {
        alert("Password and Confirm Password do not match.");
        return;
    }

    var formData = {
        FirstName: $('#FirstName').val(),
        LastName: $('#LastName').val(),
        Email: $('#Email').val(),
        NIC: $('#NIC').val(),
        MobileNumber: $('#MobileNumber').val(),
        Password: password,

    };

    // Perform AJAX POST request
    $.ajax({
        type: 'POST',
        url: '/Login/Register', // Update with your controller name
        data: {
            FirstName: $('#FirstName').val(),
            LastName: $('#LastName').val(),
            Email: $('#Email').val(),
            NIC: $('#NIC').val(),
            MobileNumber: $('#MobileNumber').val(),
            Password: password },
        success: function (data) {
            // Handle success
            console.log(data);
        },
        error: function (error) {
            // Handle error
            console.error(error);
        }
    });
}