$(document).ready(function () {
    $('#feedbackFormId').validate({
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
            'AuthorName': {
                required: true
            },

            'AuthorSurname': {
                required: true
            },

            'FeedbackText': {
                required: true
            }
        },
        messages: {
            'AuthorName': 'Please enter valid name',

            'AuthorSurname': {
                required: 'Please enter valid surname'
            },

            'FeedbackText': {
                required: 'Text is required'
            }
        }
    });
});