function validateForm() {
    var n = document.forms["Contact"]["name"].value;
    var p = document.forms["Contact"]["phone"].value;
    var e = document.forms["Contact"]["email"].value;
    var m = document.forms["Contact"]["message"].value;

    if (n == "" || m == "" || p == "" || e == "") {
        alert("Todos os campos do formulário são obrigatórios e devem ser preenchidos corretamente.");
        return false;
    }
} 