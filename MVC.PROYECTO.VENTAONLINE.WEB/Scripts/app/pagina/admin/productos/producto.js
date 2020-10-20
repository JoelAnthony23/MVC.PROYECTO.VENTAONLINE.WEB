var app = app || {}; app.pagina = app.pagina || {}; app.pagina.admin = app.pagina.admin || {};

app.pagina.admin.producto = app.pagina.admin.producto || (function () {
    var URLS = { create: '/ProductoAdmi/AdminProductos/Create' };
    var URLSEdit = { edit: '/ProductoAdmi/AdminProductos/Edit' };

    function init() {
        $(".btnNuevo").on("click", nuevo);
    }
    function initCreate() {
        $.validator.unobtrusive.parse($("#frmProductoNuevo"));
        $(".btnGuardar").on("click", guardar);
    }


    function initActualizar() {
        $(".btnActualizar").on("click", actualizar);
    }


    function initEdit() {
        $.validator.unobtrusive.parse($("#frmProductoNuevo"));
        $(".btnActualizar").on("click", editar);
    }
    function nuevo() {
        app.lib.common.ShowModal("Nuevo Producto", URLS.create, RespuestaGuardar, "ModalProductoNuevoID");
    }
    function actualizar() {
        app.lib.common.ShowModal("Actualizar Producto", URLSEdit.edit, RespuestaGuardar, "ModalProductoNuevoID");
    }

    function guardar(event) {
        event.preventDefault();
        var form = $("#frmProductoNuevo");
        if (form.valid()) {

            $.post(URLS.create, form.serialize())
                .done(function (response) {
                    if (response === true) {
                        alert("Los datos se grabaron correctamente");
                        app.lib.common.CloseModal(response, "ModalProductoNuevoID");

                    }
                    else {
                        alert("Error al guardar la informacion");
                    }
                })
                .fail(function (response) {
                    alert(response);
                });
        }

    }
    function RespuestaGuardar() {

    }

    return {
        init: init,
        initCreate: initCreate,
        initActualizar: initActualizar
    }
})();
