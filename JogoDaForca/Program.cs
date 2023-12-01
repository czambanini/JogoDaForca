namespace JogoDaForca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variaveis
            int vida = 6;
            bool terminar = false;
            bool ganhou = false;

            //inicializar lista de letras chutadas corretas
            List<char> letrasCertas = new List<char>();
            letrasCertas.Add(' ');

            //puxar palavra e dica aleatória da classe Respostas
            char[] resposta = Respostas.DictionaryDeRespostas();
            Logicas.EscreverStatus(resposta, letrasCertas);
            
            
            while (terminar == false)
            {
                //Leitura do chute
                Console.WriteLine("\n\nEscolha uma letra:");
                char chute = Console.ReadKey().KeyChar;
                Console.WriteLine("\n");
                chute = Char.ToUpper(chute);

                //chama o método Tentativa e EscreverStatus para escrever andamento da palavra
                vida = Logicas.Tentativa(resposta, letrasCertas, chute, vida);
                ganhou = Logicas.EscreverStatus(resposta, letrasCertas);

                //sai do loop while se a vida zerar ou palavra for finalizada
                if (vida == 0)
                {
                    terminar = true;
                    Console.WriteLine("\nVocê perdeu :(");
                }
                if (ganhou == true)
                {
                    terminar = true;
                    Console.WriteLine("\nVocê ganhou! :D");
                }

            }

        }

    }
}
