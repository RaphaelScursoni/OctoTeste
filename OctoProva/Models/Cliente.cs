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
        [Required(ErrorMessage = "O Tipo do cliente é obrigatório")]
        [StringLength(30)]
        public string TipoCliente { get; set; } //Pessoa Juridica ou Pessoa física
        [Required(ErrorMessage = "O documento é obrigatório")]
        [StringLength(18)]
        public string Documento { get; set; } //CNPJ OU CPF
        [Required(ErrorMessage = "O tipo do primeiro telefone é obrigatório")]
        [StringLength(12)]
        public string TipoTelefone1 { get; set; }
        [Required(ErrorMessage = "Ao menos o primeiro telefone é obrigatório")]
        [StringLength(15)]
        public string Telefone1 { get; set; }
        [StringLength(25)]
        public string TipoTelefone2 { get; set; }
        [StringLength(15)]
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
        [StringLength(9)]
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
        [StringLength(50,ErrorMessage = "A Cidade não pode ter mais que 50 caracteres")]
        public string Cidade { get; set; }
        [StringLength(15)]
        public string UF { get; set; }
    }
}
