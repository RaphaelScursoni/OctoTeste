using System;
using System.ComponentModel.DataAnnotations;

namespace OctoProva.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Nome { get; set; }
        [Required]
        [StringLength(30)]
        public string TipoCliente { get; set; } //Pessoa Juridica ou Pessoa física
        [Required]
        [StringLength(14)]
        public string Documento { get; set; } //CNPJ OU CPF
        [Required]
        [StringLength(12)]
        public string TipoTelefone1 { get; set; }
        [Required]
        [StringLength(12)]
        public string Telefone1 { get; set; }
        [StringLength(25)]
        public string TipoTelefone2 { get; set; }
        [StringLength(12)]
        public string Telefone2 { get; set; }
        [Required]
        [StringLength(25)]
        public string TipoEndereco { get; set; }
        [Required]
        [StringLength(100)]
        public string Endereco { get; set; }
        [Required]
        [StringLength(9)]
        public string CEP { get; set; }
        [Required]
        [StringLength(10)]
        public string Numero { get; set; }
        [StringLength(50)]
        public string Complemento { get; set; }
        [Required]
        [StringLength(50)]
        public string Bairro { get; set; }
        [Required]
        [StringLength(50)]
        public string Cidade { get; set; }
        [StringLength(15)]
        public string UF { get; set; }

        public void Validar()
        {
            if (string.IsNullOrEmpty(Nome))
                throw new ApplicationException("O campo nome é obrigatório.");
            
            if (Nome.Length > 100)
                throw new ApplicationException("O campo só pode conter 100 letras.");

            if (string.IsNullOrEmpty(Documento))
                throw new ApplicationException("O campo documentação é obrigatório.");

            if (Documento.Length > 14)
                throw new ApplicationException("O campo só pode conter no máximo 14 números.");

            if (Telefone1.Length > 12)
                    throw new ApplicationException("O telefone não pode ter mais que 16 números.");

            if (string.IsNullOrEmpty(TipoTelefone1))
                    throw new ApplicationException("É preciso preencher pelo menos 1 telefone junto com o tipo.");

            if (string.IsNullOrEmpty(Endereco))
                throw new ApplicationException("É preciso preencher o Endereço.");

            if (string.IsNullOrEmpty(TipoEndereco))
                throw new ApplicationException("É preciso preencher o endereço junto com o tipo.");

            if (Endereco.Length > 100)
                throw new ApplicationException("O endereço não pode ter mais que 100 letras");

            if (string.IsNullOrEmpty(CEP))
                throw new ApplicationException("É preciso preencher o CEP do seu endereço.");

            if (CEP.Length > 9)
                throw new ApplicationException("O CEP não pode ter mais que 9 dígitos");

            if (string.IsNullOrEmpty(Numero))
                throw new ApplicationException("É preciso preencher o Número de onde fica o seu endereço.");

            if (Numero.Length > 10)
                throw new ApplicationException("O Número do seu endereço não pode ser maior que 10 dígitos");

            if (string.IsNullOrEmpty(Bairro))
                throw new ApplicationException("É preciso preencher o Bairro de onde se localiza o seu endereço.");

            if (Bairro.Length > 50)
                throw new ApplicationException("O Bairro do seu endereço não pode ter mais que 50 letras");

            if (string.IsNullOrEmpty(Cidade))
                throw new ApplicationException("É preciso preencher a Cidade de onde se localiza o seu endereço.");

            if (Cidade.Length > 50)
                throw new ApplicationException("A Cidade do seu endereço não pode ter mais que 50 letras");
        }
    }
}
