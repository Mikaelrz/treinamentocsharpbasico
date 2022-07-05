using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoGitHub.InterfaceConsole
{//inicio do namespace
    internal class Program
    {//inicio de classe
        static void Main(string[] args)
        {//inicio do método
            /*
             * Main - principal
             * O método inicia-se com aletra maiuscula
             * 
             */
            //Variável
            /*
             * É um espaço reservado na memória
             */
            /*Tipos de dados
             * Inteiro - int
             * Real -double
             * Texto -string*/
            /*
             * + - adição
             * - - subtração
             * * - multiplicação
             * / - divisão
             * % - mod (módulo da divisão)
             */

            string comando;
            int pontos = 0;
            
            
            string resposta = "git remote add origin";
            Console.WriteLine("Qual o comando para iniciar git?");
            comando = Console.ReadLine();
            string[] subcomando = comando.Split(' ');
            foreach (var item in subcomando)
            {
                Console.WriteLine(item);
            }

            if (comando.Equals(resposta))                                                                                                                                                                                                                                                                        
            {
                Console.WriteLine("acertou");
            }
            else
            {
                Console.WriteLine("errou");
            }
            Console.WriteLine($"A resposta é {resposta}");
            Console.WriteLine("Alô Mundo"!");
            Console.ReadKey();

        }//Fim do método
    }//Fim da classe
}//fim do namespace
