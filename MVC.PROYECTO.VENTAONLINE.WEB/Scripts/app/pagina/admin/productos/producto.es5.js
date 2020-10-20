"use strict";

var app = app || {};app.pagina = app.pagina || {};

app.pagina.producto = app.pagina.producto || (function () {
    var URLS = { create: '/Principal/Detalle' };

    function init() {
        $(".btnNuevo").on("click", nuevo);
    }
    function initCreate() {
        $.validator.unobtrusive.parse($("#frmProductoNuevo"));
        $(".btnGuardar").on("click", guardar);
    }
    function nuevo() {
        app.lib.common.ShowModal("Detalle Producto", URLS.create, RespuestaGuardar, "ModalProductoNuevoID");
    }
    function guardar(event) {
        event.preventDefault();
        var form = $("#frmProductoNuevo");
        if (form.valid()) {

            $.post(URLS.create, form.serialize()).done(function (response) {
                if (response === true) {
                    alert("Los datos se grabaron correctamente");
                    app.lib.common.CloseModal(response, "ModalProductoNuevoID");
                } else {
                    alert("Error al guardar la informacion");
                }
            }).fail(function (response) {
                alert(response);
            });
        }
    }
    function RespuestaGuardar() {}
    return {
        init: init,
        initCreate: initCreate
    };
})();

