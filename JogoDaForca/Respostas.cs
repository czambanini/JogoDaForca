using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaForca
{
    internal class Respostas
    {
        public static char[] DictionaryDeRespostas()
        {
            Dictionary<string, string> respostas = new Dictionary<string, string>();
            respostas.Add("Beterraba", "É um vegetal");
            respostas.Add("Fichario", "Material escolar");
            respostas.Add("Estojo", "Material escolar");
            respostas.Add("Lapiseira", "Material escolar");
            respostas.Add("Marca texto", "Material escolar");
            respostas.Add("Corretivo", "Material escolar");
            respostas.Add("Transferidor", "Material escolar");
            respostas.Add("Divertidamente", "Filme da Disney");
            respostas.Add("Detona Ralph", "Filme da Disney");
            respostas.Add("Enrolados", "Filme da Disney");
            respostas.Add("Moana", "Filme da Disney");
            respostas.Add("Monstros SA", "Filme da Disney");
            respostas.Add("Stranger Things", "Série");
            respostas.Add("Game of Thrones", "Série");
            respostas.Add("Young Sheldon", "Série");
            respostas.Add("Flamingo", "Animal");
            respostas.Add("Texugo", "Animal");
            respostas.Add("Raposa", "Animal");
            respostas.Add("Crocodilo", "Animal");
            respostas.Add("Cegonha", "Animal");
            respostas.Add("Leopardo", "Animal");
            respostas.Add("Ornitorrinco", "Animal");

            Random randow = new Random();
            List<string> chaves = new List<string>(respostas.Keys);
            string palavraEscolhida = chaves[randow.Next(chaves.Count)];
            char[] resposta = Respostas.DecomporPalavra(palavraEscolhida);
            Console.WriteLine("Dica: {0}", respostas[palavraEscolhida]);

            return resposta;
        }

        public static char[] DecomporPalavra(String palavraCerta)
        {
            palavraCerta = palavraCerta.ToUpper();
            char[] resposta = palavraCerta.ToCharArray();
            return resposta;
        }

        
    }
}
