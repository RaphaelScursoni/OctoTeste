//Inplantando - JQuery Mask Plugin
$(document).ready(function () {
    $('#CPF').mask("000.000.000-00", { placeholder: "___.___.___-__" });
    $('#CNPJ').mask("00.000.000/0000-00", { placeholder: "__.___.___/____-__" });
    $('#ATTCPF').mask("000.000.000-00", { placeholder: "___.___.___-__" });
    $('#ATTCNPJ').mask("00.000.000/0000-00", { placeholder: "__.___.___/____-__" });
    $('#cep').mask("00000-000", { placeholder: "_____-___" });
    $('#telefone1').mask("00000000000", { placeholder: "Digite o Telefone" });
    $('#telefone2').mask("00000000000");
    $('#numero').mask("000000000");
});


//Comandos OnClick do Radio Button: Pessoa Física e Jurídica.
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

$(function () {
    $('#btn1').click(function () {
        $('#CNPJLabel').show();
        $('#CNPJ').show();
        $('#CNPJ').onfocus(alert("Edite corretamente o CNPJ."));
    });
    $('#btn2').click(function () {
        $('#CPFLabel').show();
        $('#CPF').show();
        $('#CPF').onfocus(alert("Edite corretamente o CPF."));
    });
});

