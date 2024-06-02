using ProductManager.DI.Enumeradores;

namespace ProductManager.DI.Entidade
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Tipo Tipo { get; set; }
        public decimal PrecoUnitario { get; set; }
    }
}
