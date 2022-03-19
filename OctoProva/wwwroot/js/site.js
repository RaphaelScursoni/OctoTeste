$(document).ready(function() {
    $('#CPF').mask("000.000.000-00", { placeholder: "___.___.___-__" });
    $('#CNPJ').mask("00.000.000/0000-00", { placeholder: "__.___.___/____-__" });
    $('#cep').mask("00000-000", { placeholder: "_____-___" });
    $('#telefone1').mask("00000000000", { placeholder: "Digite o Telefone" });
    $('#telefone2').mask("00000000000");
    $('#numero').mask("000000000");
});
$(function () {
    $('#radio1').click(function () {
        $('#CPF').show();
        $('#CNPJ').hide();
        $('#CNPJ').val('');
        $('#CPFLabel').show();
        $('#CNPJLabel').hide();
    });
    $('#radio2').click(function () {
        $('#CNPJ').show();
        $('#CPF').hide();
        $('#CPF').val('');
        $('#CNPJLabel').show();
        $('#CPFLabel').hide();
    });
});
