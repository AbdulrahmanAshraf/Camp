
$(function () {
    var placeholder=$('#placeHolder')
    $('#runDeviceModel').click(function (e) {
        var url = $(this).data('url')
        $.get(url).done(function (data) {
            placeholder.html(data);
            placeholder.find('.modal').modal('show')
        })
    })
    });


