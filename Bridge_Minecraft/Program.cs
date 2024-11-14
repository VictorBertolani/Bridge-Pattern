using System;

namespace Bridge_Minecraft
{
    public class Program
    {
        static void Main(string[] args)
        {
            int EscolhaMinerios = 0;
            int EscolhaFerramentas = 0;

            // Solicita a escolha da ferramenta
            Console.WriteLine("Olá!");
            Console.WriteLine("Escolha qual ferramenta você vai criar: 1 = Espada, 2 = Picareta");
            EscolhaFerramentas = int.Parse(Console.ReadLine());

            // Variáveis para armazenar as ferramentas
            Ferramenta ferramenta = null;

            // Instanciando a ferramenta com base na escolha
            switch (EscolhaFerramentas)
            {
                case 1:
                    ferramenta = new Espada();
                    break;
                case 2:
                    ferramenta = new Picareta();
                    break;
                default:
                    Console.WriteLine("Erro, reinicie o código");
                    return; // Saímos do método se a escolha for inválida
            }

            // Solicita a escolha do minério
            Console.WriteLine("Ótimo! Agora de qual minério será feito sua ferramenta? 1 = Diamante, 2 = Ferro");
            EscolhaMinerios = int.Parse(Console.ReadLine());

            // Variável para armazenar o minério
            Minerios minerio = null;

            // Instanciando o minério com base na escolha
            switch (EscolhaMinerios)
            {
                case 1:
                    minerio = new Diamante();
                    break;
                case 2:
                    minerio = new Ferro();
                    break;
                default:
                    Console.WriteLine("Erro, reinicie o código");
                    return; // Saímos do método se a escolha for inválida
            }

            // Criando a instância da Bridge passando a ferramenta e o minério escolhidos
            Bridge bridge = new Bridge(ferramenta, minerio);

            // Executando o método de craft
            bridge.CraftFerramenta();
        }
    }
}