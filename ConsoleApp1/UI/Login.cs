using ConsoleApp1.Data;
using System;
using System.Collections.Generic;

namespace ConsoleApp1.UI
{
    internal class Login : Menu
    {
        private readonly DataContext POSDataBase;
        private Dictionary<string, string> SistemUsers { get; set; }
        private int FailedAtempttsCounter { get; set; }

        public Login(DataContext dataContext) : base(new string[] { "Login" })
        {
            POSDataBase = dataContext;
            BaseUsersList();
        }

        private void BaseUsersList()
        {
            SistemUsers = new Dictionary<string, string>();
            SistemUsers.Add("1", "1");
            SistemUsers.Add("Maria", "456");
            SistemUsers.Add("João", "789");
        }

        public void Start()
        {
            HeaderDisplay();
            EnterPasswordAndUser();
        }

        private bool UserPasswordValidation(string user, string password)
        {
            return SistemUsers.TryGetValue(user, out var storedPassword) && storedPassword == password;
        }

        private void EnterPasswordAndUser()
        {
            if (FailedAtempttsCounter >= 3)
            {
                Console.WriteLine("Sistema bloqueado devido a tentativas de acesso incorretas");
                Console.ReadLine();
                Environment.Exit(0);
                return;                
            }
            
            Console.Write("\r\nInsira o Utilizador: ");
            var user = Console.ReadLine();
            Console.Write("\r\nInsira a Senha: ");
            var password = Console.ReadLine();

            if (UserPasswordValidation(user, password))
            {
                // Se o login for bem-sucedido, exibe o MainMenu
                var mainMenu = new MainMenu(POSDataBase);
                mainMenu.DisplayMenu();
            }
            else
            {
                FailedAtempttsCounter++;
                HeaderDisplay();

                EnterPasswordAndUser();
            }
        }

        // Não é necessário implementar ProcessarEscolha aqui
    }
}
