$(document).ready(function () {
    $('#visaOptions li').click(function () {
        $('.activeVisa').removeClass('activeVisa');
        $(this).addClass('activeVisa')
        var id = $(this).attr('id') + 'Content';
        $('#visaInfo div:visible').hide();
        $('#' + id).slideDown('slow');
    })
});

