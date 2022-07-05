using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoGitHub.AulaDois
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //contador
            int cont = 1;
            //condição
            string c = "git status";
            while (cont <= 1000000)
            {
                if(cont > 10)
                {
                    c = "git status";
                }
               Console.WriteLine($"<{cont}> - {c}");
                //incremento
                cont++;
            }
            Console.ReadLine();
        }
    }
}
