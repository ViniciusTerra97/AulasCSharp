namespace ConsoleAppPOO.Model
{
    public class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public Produto() { }
        public Produto(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }
        public void Apresentar(Produto produto)
        {
            Console.WriteLine($"ID: {produto.Id}\n" +
                $"Descrição: {produto.Descricao}");
        }
        public void ApresentarLista(List<Produto> produtos)
        {
            if (produtos.Count == 0)
            {
                Console.WriteLine("Lista vazia");
            }
            else
            {
                foreach (Produto produto in produtos)
                {
                    Console.WriteLine($"ID: {produto.Id}\n" +
                    $"Descrição: {produto.Descricao}");
                }
            }

        }

    }  
}
