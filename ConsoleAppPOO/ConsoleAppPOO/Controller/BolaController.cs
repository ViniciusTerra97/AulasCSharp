using ConsoleAppPOO.Model;

namespace ConsoleAppPOO.Controller
{
    public class BolaController
    {
        List<Bola> listaBola = new List<Bola>();


        public List<Bola> Adicionar(Bola bola)
        {
            listaBola.Add(bola);
            return listaBola;
        }


        public void Listar(List<Bola> lista)
        {
            if (lista.Count == 0)
            {
                Console.WriteLine("Lista vazia");
            }
            else
            {
                foreach (Bola bola in lista)
                {
                    Console.WriteLine($"ID: {bola.Id}\n" +
                    $"Descrição: {bola.Descricao}\n" +
                    $"Preço: {bola.Preco}");
                }
            }

        }
    }
}
