using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.UI
{
    public class Menu
    {
        private readonly List<string> options;

        public Menu (string[] opcoes)
        {
            this.options = new List<string>(opcoes);
        }

        public void DisplayMenu()
        {
            int escolha;
            do
            {
                HeaderDisplay();
                for (int i = 0; i < options.Count; i++)
                {
                    Console.WriteLine($"{i + 1}) {options[i]}");
                }
                Console.WriteLine($"{options.Count + 1}) Sair");
                Console.Write("\r\nSelecione uma opção: ");
            }
            while (!int.TryParse(Console.ReadLine(), out escolha) || escolha < 1 || escolha > options.Count + 1);
            if (escolha <= options.Count)
            {
                ChoiceHandle(escolha);
            }
            else if (escolha == options.Count+1)
            {
                Console.WriteLine("Obrigado pela sua visita");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }

        protected virtual void ChoiceHandle(int escolha)
        {
            // Processar a escolha aqui ou nas classes derivadas
            Console.WriteLine($"Opção escolhida: {options[escolha - 1]}");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
        public void HeaderDisplay()
        {
            Console.Clear();
            Console.WriteLine("«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»");
            Console.WriteLine("«»«»«»«»«»«»«»«»«»«»«»«»«»«»      POS     «»«»«»«»«»«»«»«»«»«»«»«»«»«»");
            Console.WriteLine("«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»\n");
        }
    }
}
