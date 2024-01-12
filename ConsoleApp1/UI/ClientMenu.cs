using ConsoleApp1.Data;
using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1.UI
{
    internal class ClientMenu : Menu
    {
        private readonly DataContext POSDataBase;

        public ClientMenu(DataContext dataContext) : base(new string[] { "Adicionar Novo Cliente", "Editar dados de Cliente", "Apagar dados Cliente", "Menu Principal" })
        {
            POSDataBase = dataContext;
        }

        public void Start()
        {
            DisplayMenu();
        }

        protected override void ChoiceHandle(int choice)
        {
            switch (choice)
            {
                case 1:
                    AddClient();
                    break;
                case 2:
                    EditClient();
                    break;
                case 3:
                    DeleteClient();
                    break;
                case 4:
                    var mainMenu = new MainMenu(POSDataBase);
                    mainMenu.DisplayMenu();
                    break;
            }

            DisplayMenu(); // Reexibe o menu após a operação
        }

        private void AddClient()
        {
            var cliente = new Client();

            HeaderDisplay();
            Console.Write("\rInforme os dados do cliente \n----------------------------\n");


            cliente.Id = Guid.NewGuid();

            Console.Write("\r\nPrimeiro nome do Cliente: ");
            cliente.FirstName = Console.ReadLine();

            Console.Write("\r\nUltimo nome do Cliente: ");
            cliente.LastName = Console.ReadLine();

            Console.Write("\r\nNIF do Cliente: ");
            cliente.NIF = Console.ReadLine();

            Console.Write("\r\nE-mail: ");
            cliente.ContactEmail = Console.ReadLine();

            Console.Write("\r\nTelefone: ");
            cliente.ContactPhone = Console.ReadLine();

            Console.Write("\r\nAno de Nascimento: ");
            int anoNascimento = int.Parse(Console.ReadLine());

            Console.Write("\r\nMês de Nascimento: ");
            int mesNascimento = int.Parse(Console.ReadLine());

            Console.Write("\r\nDia do Nascimento: ");
            int diaNascimento = int.Parse(Console.ReadLine());

            cliente.BirthDate = new DateTime(anoNascimento, mesNascimento, diaNascimento);

            cliente.Adress = new Adress();

            Console.Write("\r\nEndereço: ");
            cliente.Adress.Address = Console.ReadLine();

            Console.Write("\r\nCidade: ");
            cliente.Adress.City = Console.ReadLine();

            Console.Write("\r\nDistrito: ");
            cliente.Adress.District = Console.ReadLine();

            Console.Write("\r\nPais: ");
            cliente.Adress.Country = Console.ReadLine();

            Console.Write("\r\nCódigo Postal: ");
            cliente.Adress.PostalCode = Console.ReadLine();

            POSDataBase.Add(cliente);

            POSDataBase.SaveChanges();
        }

        private void EditClient()
        {
            // Lógica de edição de cliente
            Console.WriteLine("Editar cliente...");
            // ...
        }

        private void DeleteClient()
        {
            // Lógica de remoção de cliente
            Console.WriteLine("Apagar cliente...");
            // ...
        }
    }
}
