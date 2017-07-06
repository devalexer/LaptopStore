function GetAllProducts()
{
    jQuery.support.cors = true;
    $.ajax({
        url: 'http://localhost:52188/api/get',
        type: 'GET',
        datatype: 'json',
        success: function (data) {
            ConsoleWrite(data)
        },
        error: function () {
            alert("Error");
        }

    });
}