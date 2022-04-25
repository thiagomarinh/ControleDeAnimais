using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeAnimais
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal();
            Animal a2 = new Animal();
            Animal a3 = new Animal();
            Animal a4 = new Animal();
            Animal a5 = new Animal();

            int tlcachorro = 0, tlgato = 0, tlpeixe = 0;

            Console.WriteLine("Controle de Animais");
            Console.WriteLine("Digite o nome do animal 1: ");
            a1.Nome = Console.ReadLine();
            Console.WriteLine("Digite o tipo do Animal: ");
            a1.Tipo = Console.ReadLine();

            if (a1.Tipo == "cachorro") tlcachorro++;
            if (a1.Tipo == "gato") tlgato++;
            if (a1.Tipo == "peixe") tlpeixe++;

            Console.WriteLine("Controle de Animais");
            Console.WriteLine("Digite o nome do animal 2: ");
            a2.Nome = Console.ReadLine();
            Console.WriteLine("Digite o tipo do Animal: ");
            a2.Tipo = Console.ReadLine();
            
            if (a2.Tipo == "cachorro") tlcachorro++;
            if (a2.Tipo == "gato") tlgato++;
            if (a2.Tipo == "peixe") tlpeixe++;

            Console.WriteLine("Controle de Animais");
            Console.WriteLine("Digite o nome do animal 3: ");
            a3.Nome = Console.ReadLine();
            Console.WriteLine("Digite o tipo do Animal: ");
            a3.Tipo = Console.ReadLine();

            if (a3.Tipo == "cachorro") tlcachorro++;
            if (a3.Tipo == "gato") tlgato++;
            if (a3.Tipo == "peixe") tlpeixe++;

            Console.WriteLine("Controle de Animais");
            Console.WriteLine("Digite o nome do animal 4: ");
            a4.Nome = Console.ReadLine();
            Console.WriteLine("Digite o tipo do Animal: ");
            a4.Tipo = Console.ReadLine();

            if (a4.Tipo == "cachorro") tlcachorro++;
            if (a4.Tipo == "gato") tlgato++;
            if (a4.Tipo == "peixe") tlpeixe++;

            Console.WriteLine("Controle de Animais");
            Console.WriteLine("Digite o nome do animal 5: ");
            a5.Nome = Console.ReadLine();
            Console.WriteLine("Digite o tipo do Animal: ");
            a5.Tipo = Console.ReadLine();

            if (a5.Tipo == "cachorro") tlcachorro++;
            if (a5.Tipo == "gato") tlgato++;
            if (a5.Tipo == "peixe") tlpeixe++;

            Console.WriteLine("Cachorros : " + tlcachorro);
            Console.WriteLine("Gatos : " + tlgato);
            Console.WriteLine("Peixes: " + tlpeixe);

            Console.ReadKey();


        }
    }
}
