using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteka.Database;
using Biblioteka.Other;

namespace Biblioteka.Model
{
    public class User : Resource
    {
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool IsWorker { get; set; }
        public List<Book> Books { get; set; }

        public static void UsersListDrawer(int userListNumber)
        {
            string info1 = "NAZWA UŻYTKOWNIKA: ";
            string info2 = "LOGIN UŻYTKOWNIKA: ";
            string info3 = "TYP UŻYTKOWNIKA:   PRACOWNIK";
            string info4 = "TYP UŻYTKOWNIKA:   CZYTELNIK";

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            
            Console.SetCursorPosition(MenuManager.usersListPosition + 6 , Console.CursorTop);
            Console.WriteLine(userListNumber+1 + ". " + info1 + Mock._users[userListNumber].Name);
            Console.SetCursorPosition(MenuManager.usersListPosition + 9 , Console.CursorTop);
            Console.WriteLine(info2 + Mock._users[userListNumber].Login);
            if (Mock._users[userListNumber].IsWorker == true)
            {
                Console.SetCursorPosition(MenuManager.usersListPosition + 9 , Console.CursorTop);
                Console.WriteLine(info3);
            }
            else
            {
                Console.SetCursorPosition(MenuManager.usersListPosition + 9 , Console.CursorTop);
                Console.WriteLine(info4);
            }
            Console.WriteLine();
        }
    }
}
