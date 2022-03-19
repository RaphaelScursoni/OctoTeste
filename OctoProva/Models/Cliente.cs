using System;
using System.ComponentModel.DataAnnotations;

namespace OctoProva.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage="Nome é obrigatório")]
        [StringLength(70, ErrorMessage = "O Nome não pode ter mais que 70 caracteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Certifique-se de não enviar o formulário com o Documento vazio.")]
        [StringLength(18)]
        public string Documento { get; set; }
        [StringLength(14, MinimumLength = 14, ErrorMessage = "O CPF precisa conter no mínimo 11 dígitos")]
        public string CPF { get; set; }
        [StringLength(18, MinimumLength =18,ErrorMessage ="O CNPJ precisa conter no mínimo 14 dígitos")]
        public string CNPJ { get; set; }
        [StringLength(30)]
        public string TipoCliente { get; set; }
        [Required(ErrorMessage = "O tipo do primeiro telefone é obrigatório")]
        [StringLength(12)]
        public string TipoTelefone1 { get; set; }
        [Required(ErrorMessage = "Ao menos o primeiro telefone é obrigatório")]
        [StringLength(15, MinimumLength =11, ErrorMessage ="Preencha o Telefone 1 corretamente")]
        public string Telefone1 { get; set; }
        [StringLength(25)]
        public string TipoTelefone2 { get; set; }
        [StringLength(15, MinimumLength = 11, ErrorMessage = "Preencha o Telefone 2 corretamente")]
        public string Telefone2 { get; set; }
        [RegularExpression(@"^[a-zA-Z]+(([\'\,\.\- ][a-zA-Z ])?[a-zA-Z]*)*\s+<(\w[-._\w]*\w@\w[-._\w]*\w\.\w{2,3})>$|^(\w[-._\w]*\w@\w[-._\w]*\w\.\w{2,3})$", ErrorMessage = "Formato do E-mail Inválido.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "O Tipo do endereço é obrigatório")]
        [StringLength(25)]
        public string TipoEndereco { get; set; }
        [Required(ErrorMessage = "O endereço é obrigatório")]
        [StringLength(50,ErrorMessage = "O Endereço não pode ter mais que 50 caracteres")]
        public string Endereco { get; set; }
        [Required(ErrorMessage = "O CEP é obrigatório")]
        [StringLength(9, MinimumLength =9, ErrorMessage = "O CEP precisa conter 8 dígitos")]
        public string CEP { get; set; }
        [Required(ErrorMessage = "O número do seu endereço é obrigatório")]
        [StringLength(10)]
        public string Numero { get; set; }
        [StringLength(50)]
        public string Complemento { get; set; }
        [Required(ErrorMessage = "O bairro do seu endereço é obrigatório")]
        [StringLength(50)]
        public string Bairro { get; set; }
        [Required(ErrorMessage = "A cidade do seu endereço é obrigatório")]
        [StringLength(50, MinimumLength =2,ErrorMessage = "A Cidade precisa conter de 2 - 50 caracteres")]
        public string Cidade { get; set; }
        [StringLength(15)]
        public string UF { get; set; }

        public Cliente()
        {
        }

        public Cliente(string nome, string documento, string tipoCliente, string tipoTelefone1, string telefone1, string tipoTelefone2, string telefone2, string email, string tipoEndereco, string endereco, string cEP, string numero, string complemento, string bairro, string cidade, string uF)
        {
            Nome = nome;
            Documento = documento;
            TipoCliente = tipoCliente;
            TipoTelefone1 = tipoTelefone1;
            Telefone1 = telefone1;
            TipoTelefone2 = tipoTelefone2;
            Telefone2 = telefone2;
            Email = email;
            TipoEndereco = tipoEndereco;
            Endereco = endereco;
            CEP = cEP;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            UF = uF;
        }
        public Cliente(string nome, string documento, string cNPJ,string tipoCliente, string tipoTelefone1, string telefone1, string tipoTelefone2, string telefone2, string email, string tipoEndereco, string endereco, string cEP, string numero, string complemento, string bairro, string cidade, string uF) 
            :this(nome, documento, tipoCliente, tipoTelefone1,telefone1, tipoTelefone2,telefone2,email,tipoEndereco,endereco,cEP,numero,complemento,bairro,cidade,uF)
        {
            CNPJ = cNPJ;
        }
        public Cliente(string nome, string documento, string cPF, string cNPJ, string tipoCliente, string tipoTelefone1, string telefone1, string tipoTelefone2, string telefone2, string email, string tipoEndereco, string endereco, string cEP, string numero, string complemento, string bairro, string cidade, string uF)
            : this(nome, documento, tipoCliente, tipoTelefone1, telefone1, tipoTelefone2, telefone2, email, tipoEndereco, endereco, cEP, numero, complemento, bairro, cidade, uF)
        {
            CPF = cPF;
        }

    }
}
