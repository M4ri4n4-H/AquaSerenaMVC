const yoga = document.getElementById("yoga");
const meditacion = document.getElementById("meditacion");
const masaje = document.getElementById("masaje");
const descripcionActividad = document.getElementById("descripcionActividad");

if (yoga !== null && meditacion !== null && masaje !== null && descripcionActividad !== null) {
    yoga.addEventListener("click", function () {
        descripcionActividad.textContent = "Movimientos suaves y respiración consciente para recuperar el equilibrio.";
    });

    meditacion.addEventListener("click", function () {
        descripcionActividad.textContent = "Sesiones tranquilas para reducir el estrés y conectar con el momento presente.";
    });

    masaje.addEventListener("click", function () {
        descripcionActividad.textContent = "Un espacio de descanso para liberar tensiones y cuidar tu cuerpo.";
    });
}
