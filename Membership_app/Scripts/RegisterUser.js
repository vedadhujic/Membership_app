$(function () {
    var registerUserCheckBox = $('#AcceptUserAgreement').click(
        onToggleRegisterUserDisableClick);

    function onToggleRegisterUserDisableClick() {
        $('.register-user-panel button').toggleClass('disabled');
    }

    var registerUserButton = $('.register-user-panel button').click(
        onRegisterUserClick);

    function onRegisterUserClick() {
        var url = '/Account/RegisterUserAsync';
        var antiForgery = $('[name="__RequestVerificationToken"]').val();
        var name = $('.register-user-panel .first-name').val();
        var email = $('.register-user-panel .email').val();
        var psw = $('.register-user-panel .password').val();

        $.post(url, { __RequestVerificationToken: antiForgery, email: email, name: name, password: psw, acceptUserAgreement: true },
            function (data) {
                var parsed = $.parseHTML(data);
                var hasErrors = $(parsed).find('[data-valmsg-summary]').text().replace(/\n|\r/g, "").length > 0;

                if (hasErrors == true) {
                    $('.register-user-panel').html(data);

                    registerUserCheckBox = $('#AcceptUserAgreement').click(
                        onToggleRegisterUserDisableClick);

                    registerUserButton = $('.register-user-panel button').click(
                        onRegisterUserClick);

                    $('.register-user-panel button').removeClass('disabled');
                }
                else {
                    registerUserCheckBox = $('#AcceptUserAgreement').click(
                        onToggleRegisterUserDisableClick);

                    registerUserButton = $('.register-user-panel button').click(
                        onRegisterUserClick);

                    location.href = '/Home/Index';
                }

            }).fail(function (xhr, status, error) {
                alert('Post unsuccessful');
            })
    }
});