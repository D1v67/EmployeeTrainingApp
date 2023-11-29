function registerUser() {

    let form = document.querySelector('form');

    form.addEventListener('submit', (e) => {
        e.preventDefault()
        return false;
    });

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

    console.log('here')
    
    $.ajax({
        type: 'POST',
        url: '/Account/Register', 
        data: {
            FirstName: $('#FirstName').val(),
            LastName: $('#LastName').val(),
            Email: $('#Email').val(),
            NIC: $('#NIC').val(),
            MobileNumber: $('#MobileNumber').val(),
            Password: password },
        success: function (response) {
             
            console.log(response);
           window.location = response.url;
            //window.location = '/User/Index'; 

        },
        error: function (error) {
            window.location = "/Home/Index"
            
            console.error(error);
        }
    });
}