
$(document).ready(function () {
    $(".alert-box .close-action").click(function () {
        $(".alert-box").fadeOut("100");
    });
    
    $("body").keyup(function (e) {
        if (e.which == 27)
            $(".alert-box").fadeOut("100");
    });

    $('#LoginBtn').click(function() {
        $('#LoginForm').submit();
    });
    
    $('#GoHead').click(function () {
        $('#IsTestConnection').val("false");
        if ($("#IsConnectionCorrect").val() == "True") {
            $('#dbConnectionForm').slideUp();
            //$('#dbSettingsForm').slideDown();
            window.location.href = "/GetCommandResult";
        } else {
            alert("Lütfen Bağlantıyı kontrol ediniz.", "Uyarı");
        }
        return false;
    }); 

    $('#GoBack').click(function () {
        //$('#dbConnectionForm').slideDown();
        $('#dbSettingsForm').slideUp();
        window.location.href = "/Connection";
    });

    $('#TestConnection').click(function () {
        $('#IsTestConnection').val("true");
    });

    $('#GetCommand').click(function () {
        if ($('#SelectedDbTable').val() == "" && $('#CommandText').val() == "") {
            alert("Lütfen tablo seçiniz veya sql komutunuzu yazınız.", "Hata!");
            return false;
        }
    });

});

function AjaxOnSucces(result) {
    if (result.data == "True")
        alert("Bağlantı Başarılı.", "İşlem Başarılı");
    else
        alert("Lütfen bilgilerinizi kontrol ediniz.", "İşlem Hatalı");
    
    $("#IsConnectionCorrect").val(result.data);
}




function alert(a, b) {
    if (b == null)
        b = "Uyarı";
    $(".alert-box").fadeIn("100");
    $(".alert-box").find("h2").text(b);
    $(".alert-box").find("p").text(a);
}