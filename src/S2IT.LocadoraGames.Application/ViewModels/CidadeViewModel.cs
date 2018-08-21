using System.ComponentModel.DataAnnotations;

namespace S2IT.LocadoraGames.Application.ViewModels
{
    public class CidadeViewModel
    {
        [Key]
        public int CidadeId { get; set; }
        public string Nome { get; set; }
        public string UF { get; set; }
    }
}