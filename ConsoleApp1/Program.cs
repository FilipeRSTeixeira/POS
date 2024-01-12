using ConsoleApp1.Data;
using ConsoleApp1.UI;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dataContext = new DataContext(); 
            var login = new Login(dataContext);
            login.Start();
        }
    }
}