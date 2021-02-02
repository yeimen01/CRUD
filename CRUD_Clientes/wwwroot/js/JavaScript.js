//Codigo en Js

$(document).ready(function () {
    AgregarCampo();
});

function AgregarCampo() {
    //BtnAgregar
    $("#BtnAgregar").click(function () {

        var textbox = "";

        textbox = " <div class=form-controlB' > " +
            "<input asp-for='Cliente.StrDirección' type='text' class='form-controlB' />" +
            "</div > <br>";

        $("#AgregarTextBox").append(textbox);
    })
}