"use strict";

var app = app || {};app.pagina = app.pagina || {};

app.pagina.Login = app.pagina.Login || (function () {
    var URLS = { Logear: '/Login/ValidarUsuario' };
    function ValidarUsuarios() {
        var usuario = $(".txtusuario").val();
        var password = $(".txtpassword").val();
        $.post(URLS.Logear, { Usuario: usuario, Password: password }).done(function (response) {
            $(".main-content").html(response);
        });
    }
    function init() {
        $(".btn-buscar").on("click", ValidarUsuarios);
    }
    return {
        init: init
    };
})();

