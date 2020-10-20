var app = app || {}; app.pagina = app.pagina || {};

app.pagina.busquedaProducto = app.pagina.busquedaProducto || (function () {
    var URLS = { busquedaProductos: '/Login/BuscarProducto' };
    function buscarProductos() {
        var nombre = $(".txtsearch").val();
        $.post(URLS.busquedaProductos, { NomProducto: nombre })
            .done(function (response) {
                $(".container-body").html(response);
            });
    }
    function init() {
        $(".btnSearch").on("click", buscarProductos);
    }
    return {
        init: init
    }
})();
