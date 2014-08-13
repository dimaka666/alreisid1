function menuAction(optionName)
{
    $('#visaInfo div').hide('slow');
    var option = $('[optionName=' + optionName + ']');
    if(option.is(':visible'))
    {
        option.hide('slow');
    }
    else
    {
        option.show('slow');
    }
}