var app = app || {}; app.pagina = app.pagina || {};

app.pagina.detalleProducto = app.pagina.detalleProducto || (function () {
    var URLS = { Detalles: '/Principal/Detalle' };
    function DetallesProductos() {
        var Id = $("#IdProducto").val();
        $.post(URLS.Detalles, { Id: Id })
            .done(function (response) {
                $(".containderDetalle").html(response);
            });
    }
    function init() {
        $(".btnNuevo").on("click", DetallesProductos);
    }
    return {
        init: init
    }
})();