$(document).ready(function () {
    $('#visaOptions li').click(function () {
        $('.active').removeClass('active');
        $(this).addClass('active')
        var id = $(this).attr('id') + 'Content';
        $('#visaInfo div:visible').hide();
        $('#' + id).slideDown('slow');
    })
});

