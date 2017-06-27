
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

function obtenerFechas(idPelicula) {
    var idVersion = $("#versiones").find(":selected").val();
    var idSede = $("#sedes").find(":selected").val();

    $.ajax({
        type: "GET",
        url: "/Peliculas/ObtenerFechasPorSedes?id=" + idVersion + "&id2=" + idPelicula + "&id3=" + idSede,
        dataType: "json",
        contentType: 'application/json; charset=utf-8',
        success: function (result) {

            $('#dias').empty();
            var fechas = JSON.parse(JSON.stringify(result));

            console.log(JSON.stringify(result));


            for (var int = 0; int < fechas.items.length; int++) {
                $('#dias').append('<option value="' + fechas.items[int] + '">' + fechas.items[int] + '</option>');
            }




        },
        error: function () {

            alert("Error");
        }


    });
}

function obtenerHoras(idPelicula) {
    var idVersion = $("#versiones").find(":selected").val();
    var idSede = $("#sedes").find(":selected").val();
    var idDia = $("#dias").find(":selected").val();

    $.ajax({
        type: "GET",
        url: "/Peliculas/ObtenerHorarios?id=" + idVersion + "&id2=" + idPelicula + "&id3=" + idSede + "&id4=" + idDia,
        dataType: "json",
        contentType: 'application/json; charset=utf-8',
        success: function (result) {

            $('#horarios').empty();
            var fechas = JSON.parse(JSON.stringify(result));

            console.log(JSON.stringify(result));


            for (var int = 0; int < fechas.items.length; int++) {
                $('#horarios').append('<option value="' + fechas.items[int].HoraInt + '">' + fechas.items[int].HoraString + '</option>');
            }




        },
        error: function () {

            alert("Error");
        }


    });
}
