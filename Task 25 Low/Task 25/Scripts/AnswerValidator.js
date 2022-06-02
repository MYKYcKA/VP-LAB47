$(document).ready(function () {
    $('#answerFormId').validate({
        errorClass: 'help-block animation-slideDown', // You can change the animation class for a different entrance animation - check animations page  
        errorElement: 'div',
        errorPlacement: function (error, e) {
            e.parents('.form-group > div').append(error);
        },
        highlight: function (e) {

            $(e).closest('.form-group').removeClass('has-success has-error').addClass('has-error');
            $(e).closest('.help-block').remove();
        },
        success: function (e) {
            e.closest('.form-group').removeClass('has-success has-error');
            e.closest('.help-block').remove();
        },
        rules: {
            'Name': {
                required: true
            },

            'Surname': {
                required: true
            },

            'Framework': {
                required: true
            },

            'Language': {
                required: true
            },
        },
        messages: {
            'Name': 'Please enter your name',

            'Surname': 'Please enter your surname',

            'Framework': 'Choose your framework',

            'Language': 'Choose your language'
        }
    });
});