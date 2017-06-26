
function obtenerSedes(idPelicula) {
    var idSeleccionada = $("#versiones").find(":selected").val();

    $.ajax({
        type: "GET",
        url: "/Peliculas/ObtenerSedesPorVersion?id=" + idSeleccionada + "&id2=" + idPelicula,
        dataType: "json",
        contentType: 'application/json; charset=utf-8',
        success: function (result) {
			$('#sedes').empty();
            var sedes = JSON.parse(JSON.stringify(result));

            console.log(JSON.stringify(result));

            for (var int = 0; int < sedes.items.length; int++) {
                $('#sedes').append('<option value="' + sedes.items[int].sedeId + '">' + sedes.items[int].nombreSede + '</option>');
            }




        },
        error: function () {

            alert("Error");
        }


    });
}
