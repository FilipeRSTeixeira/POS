using ConsoleApp1.Data;
using ConsoleApp1.UI;
using System;

namespace ConsoleApp1
{
    internal class MainMenu : Menu
    {
        private readonly DataContext POSDataBase;

        public MainMenu(DataContext dataContext) : base(new string[] { "Clientes", "Produtos", "Login" })
        {
            POSDataBase = dataContext;
        }

        protected override void ChoiceHandle(int Choice)
        {
            switch (Choice)
            {
                case 1:
                    Console.WriteLine("Cliente selecionado.");
                    var clientsMenu = new ClientMenu(POSDataBase);
                    clientsMenu.Start();
                    break;
                case 2:
                    Console.WriteLine("Produto selecionado.");
                    // Implemente a lógica para o módulo de produto
                    break;
                case 3:
                    var dataContext = new DataContext();
                    var login = new Login(dataContext);
                    login.Start();
                    break;
            }
        }
    }
}
