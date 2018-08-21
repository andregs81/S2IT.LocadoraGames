using S2IT.LocadoraGames.Domain.Entities.Amigos;

namespace S2IT.LocadoraGames.Domain.Entities.Geografia
{
    public class Endereco
    {
        public int EnderecoId { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }        
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public int CidadeId { get; set; }

        public virtual Cidade Cidade { get; set; }
        public virtual Amigo Amigo { get; set; }

    }
}
