using System.ComponentModel.DataAnnotations;

namespace OctoProva.Models
{
    public class Cliente
    {
        
        public int Id { get; set; }
        [Required]
        [StringLength(70, MinimumLength = 3)]
        public string Nome { get; set; }
        public string TipoCliente { get; set; } //Pessoa Juridica ou fisica
        [Required]
        public string Documento { get; set; } //CNPJ OU CPF
        [DataType(DataType.PhoneNumber)]
        public string TelefoneCelular { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string TelefoneComercial { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string TelefoneResidencial { get; set; }
        public string TipoEndereco1 { get; set; }
        public string Endereco1 { get; set; }
        public string TipoEndereco2 { get; set; }
        public string Endereco2 { get; set; }
    }
}
