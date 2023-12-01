using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaForca
{
    internal class Logicas
    {
        public static int Tentativa(char[] resposta, List<char> letrasCertas, char chute, int vida)
        {
            bool chuteValido = ValidarChute(chute, letrasCertas);
            
            if (chuteValido == true)
            {
                bool encontrado = false;
                foreach (char c in resposta)
                {
                    if (c == chute)
                    {
                        encontrado = true;
                    }
                }
                if (encontrado == false)
                {
                    vida = ChuteErrado(vida);
                }
                else
                {
                    letrasCertas.Add(chute);
                }
            }
            return vida;
        }

        public static bool EscreverStatus(char[] resposta, List<char> letrasCertas)
        {
            bool ganhou = true;
            foreach (char c in resposta)
            {
                bool letraDesconhecida = true;
                foreach (char letra in letrasCertas)
                {
                    if (c == letra)
                    {
                        Console.Write(c);
                        letraDesconhecida = false;
                    }

                }
                if (letraDesconhecida == true)
                {
                    Console.Write("_");
                    ganhou = false;
                }
            }
            return ganhou;
        }

        public static bool ValidarChute(char chute, List<char> letrasCertas)
        {
            bool valido = true;
            foreach (char letra in letrasCertas)
            {
                if (letra == chute)
                {
                    valido = false;
                }
            }
            return valido;
        }
        public static int ChuteErrado(int vida)
        {
            vida = vida - 1;
            Console.WriteLine("\nA letra digitada não existe na palavra-chave");
            Console.WriteLine($"Tentativas restantes: {vida} \n");
            return vida;
        }

        
    }
  
}
