using System.ComponentModel.DataAnnotations;

namespace S2IT.LocadoraGames.Application.ViewModels
{
    public class EnderecoViewModel
    {

        [Key]
        public int EnderecoId { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public int CidadeId { get; set; }

        //public virtual Cidade Cidade { get; set; }
        public virtual AmigoViewModel Amigo { get; set; }
    }
}
