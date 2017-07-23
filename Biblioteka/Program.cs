using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteka.Other;
using Biblioteka.Database;
using Biblioteka.Model;

namespace Biblioteka
{
    class Program
    {
        public static ConsoleKeyInfo keyInfo;

        static void Main(string[] args)
        {
            bool aplicationExit = false;
            bool userLoggedIn = false;
            bool lendingBookListManager = false;
            bool lendingDecision = false;
            bool lendingWriteFix = false;

            string lendedBookNumber = "";
            int lendedBookNumberConverted;

            /// Dodanie początkowych wartości dla rożnorodności
            /// 
            Mock._users[0].Books.Add(Mock._books[4]);
            Mock._users[1].Books.Add(Mock._books[26]);
            Mock._users[1].Books.Add(Mock._books[27]);
            Mock._users[2].Books.Add(Mock._books[15]);
            Mock._users[2].Books.Add(Mock._books[30]);
            Mock._users[2].Books.Add(Mock._books[21]);
            Mock._books[4].IsLended = true;
            Mock._books[4].Date = DateTime.Now.AddDays(23).ToShortDateString();
            Mock._books[26].IsLended = true;
            Mock._books[26].Date = DateTime.Now.AddDays(10).ToShortDateString();
            Mock._books[27].IsLended = true;
            Mock._books[27].Date = DateTime.Now.AddDays(15).ToShortDateString();
            Mock._books[15].IsLended = true;
            Mock._books[15].Date = DateTime.Now.AddDays(1).ToShortDateString();
            Mock._books[30].IsLended = true;
            Mock._books[30].Date = DateTime.Now.AddDays(27).ToShortDateString();
            Mock._books[21].IsLended = true;
            Mock._books[21].Date = DateTime.Now.AddDays(17).ToShortDateString();

            do
            {
                bool mainMenuDecision = false;
                bool informationDecision = false;

                bool userMainMenuDecision = false;

                string login = "";
                string password = "";

                DisplayManager.DrawMainMenu();
                Console.ResetColor();

                do
                {
                    Console.CursorVisible = false;

                    MenuManager.MainMenuOptionsHover();

                        keyInfo = Console.ReadKey(true);

                    if (keyInfo.Key == ConsoleKey.Enter)
                    {
                        mainMenuDecision = true;
                    }

                    if (keyInfo.Key == ConsoleKey.LeftArrow)
                    {
                        if (MenuManager.mainMenuChoice > 1)
                        {
                            MenuManager.mainMenuChoice--;
                        }
                        else
                        {
                            MenuManager.mainMenuChoice = 3;
                        }
                    }

                    if (keyInfo.Key == ConsoleKey.RightArrow)
                    {
                        if (MenuManager.mainMenuChoice < 3)
                        {
                            MenuManager.mainMenuChoice++;
                        }
                        else
                        {
                            MenuManager.mainMenuChoice = 1;
                        }
                    }
                }
                while (mainMenuDecision != true);

                if (MenuManager.mainMenuChoice == 1)
                {
                    MenuManager.mainMenuChoice = 1;
                    Console.Clear();

                    DisplayManager.DrawLogin();

                    do {
                        Console.CursorVisible = true;
                        Console.SetCursorPosition(MenuManager.loginPosition, 14);
                        do
                        {
                            keyInfo = Console.ReadKey(true);
                            if (keyInfo.Key != ConsoleKey.Backspace && keyInfo.Key != ConsoleKey.Enter && login.Length < 20)
                            {
                                if (keyInfo.KeyChar != '\t')
                                {
                                    login += keyInfo.KeyChar;
                                }
                                else
                                {
                                    login += " ";
                                }

                                if (keyInfo.KeyChar != '\t')
                                {
                                    Console.Write(keyInfo.KeyChar);
                                }
                                else
                                {
                                    Console.Write(" ");
                                }
                            }
                            else if (keyInfo.Key == ConsoleKey.Backspace && login.Length > 0)
                            {
                                login = login.Substring(0, (login.Length - 1));
                                Console.Write("\b \b");
                            }
                        }
                        while (keyInfo.Key != ConsoleKey.Enter);
                    
                            Console.SetCursorPosition(MenuManager.loginPosition, 15);
                            do
                            {
                                keyInfo = Console.ReadKey(true);
                                if (keyInfo.Key != ConsoleKey.Backspace && keyInfo.Key != ConsoleKey.Enter && password.Length < 20)
                                {
                                    if (keyInfo.KeyChar != '\t')
                                    {
                                        password += keyInfo.KeyChar;
                                    }
                                    else
                                    {
                                        password += " ";
                                    }
                                    Console.Write('*');
                                }
                                else if (keyInfo.Key == ConsoleKey.Backspace && password.Length > 0)
                                {
                                    password = password.Substring(0, (password.Length - 1));
                                    Console.Write("\b \b");
                                }
                            }
                            while (keyInfo.Key != ConsoleKey.Enter);

                        MenuManager.accesCounter++;

                            Console.CursorVisible = false;

                            Mock.CorrectData(login, password);

                            if (Mock.validData == false)
                            {
                                MenuManager.LoginFailed();

                                login = "";
                                password = "";
                            }
                        }
                    while (Mock.validData == false && MenuManager.accesCounter != 3);

                    if (MenuManager.accesCounter == 3 && Mock.validData == false)

                    {
                        MenuManager.AccesDisabled();
                        Console.ReadKey();
                        Environment.Exit(0);
                    }

                    MenuManager.accesCounter = 0;

                    userLoggedIn = true;

                    Console.ResetColor();
                    Console.Clear();

                    int workerMainDecisionCounter = 1;

                    ///AKCJE DOSTĘPNE PO ZALOGOWANIU, SPRAWDZENIE TYPU UŻYTKOWNIKA I WYŚWIETLENIE ODPOWIEDNICH TREŚCI I MOŻLIWOŚCi
                    do {
                        /// AKCE BIBLIOTEKARZA

                        if (Mock.isWorker == true)
                        {
                            bool workerMainDecision = false;

                            DisplayManager.DrawWorkerInterphace();

                            do
                            {
                                MenuManager.WorkerOptionsHover(workerMainDecisionCounter);

                                keyInfo = Console.ReadKey(true);

                                if (keyInfo.Key == ConsoleKey.Enter)
                                {
                                    workerMainDecision = true;
                                }
                                else if(keyInfo.Key == ConsoleKey.LeftArrow)
                                {
                                    if(workerMainDecisionCounter > 1)
                                    {
                                        workerMainDecisionCounter--;
                                    }
                                    else
                                    {
                                        workerMainDecisionCounter = 5;
                                    }
                                }
                                else if (keyInfo.Key == ConsoleKey.RightArrow)
                                {
                                    if(workerMainDecisionCounter < 5)
                                    {
                                        workerMainDecisionCounter++;
                                    }
                                    else
                                    {
                                        workerMainDecisionCounter = 1;
                                    }
                                }
                            }
                            while (workerMainDecision == false);

                            workerMainDecision = false;

                            if(workerMainDecisionCounter == 1)
                            {
                                /// Dodaj książkę

                                string bookTitle = "";
                                string bookAuthor = "";
                                string bookPublisher = "";
                                string bookYear = "";
                                int bookYearConverted = 0;

                                workerMainDecisionCounter = 1;
                                Console.ResetColor();
                                Console.Clear();
                                MenuManager.AddBookDrawer();
                                Console.SetCursorPosition(MenuManager.bookWritingPosition, 15);
                                do
                                {
                                    Console.CursorVisible = true;
                                    keyInfo = Console.ReadKey(true);

                                    if (keyInfo.Key != ConsoleKey.Backspace && keyInfo.Key != ConsoleKey.Enter && bookTitle.Length < 57)
                                    {
                                        if (keyInfo.KeyChar != '\t')
                                        {
                                            bookTitle += keyInfo.KeyChar;
                                        }
                                        else
                                        {
                                            bookTitle += " ";
                                        }

                                        if (keyInfo.KeyChar != '\t')
                                        {
                                            Console.Write(keyInfo.KeyChar);
                                        }
                                        else
                                        {
                                            Console.Write(" ");
                                        }
                                    }
                                    else if (keyInfo.Key == ConsoleKey.Backspace && bookTitle.Length > 0)
                                    {
                                        bookTitle = bookTitle.Substring(0, (bookTitle.Length - 1));
                                        Console.Write("\b \b");
                                    }
                                }
                                while (keyInfo.Key != ConsoleKey.Enter);

                                Console.SetCursorPosition(MenuManager.bookWritingPosition, 16);

                                do
                                {
                                    Console.CursorVisible = true;
                                    keyInfo = Console.ReadKey(true);

                                    if (keyInfo.Key != ConsoleKey.Backspace && keyInfo.Key != ConsoleKey.Enter && bookAuthor.Length < 57)
                                    {
                                        if (keyInfo.KeyChar != '\t')
                                        {
                                            bookAuthor += keyInfo.KeyChar;
                                        }
                                        else
                                        {
                                            bookAuthor += " ";
                                        }

                                        if (keyInfo.KeyChar != '\t')
                                        {
                                            Console.Write(keyInfo.KeyChar);
                                        }
                                        else
                                        {
                                            Console.Write(" ");
                                        }
                                    }
                                    else if (keyInfo.Key == ConsoleKey.Backspace && bookAuthor.Length > 0)
                                    {
                                        bookAuthor = bookAuthor.Substring(0, (bookAuthor.Length - 1));
                                        Console.Write("\b \b");
                                    }
                                }
                                while (keyInfo.Key != ConsoleKey.Enter);

                                Console.SetCursorPosition(MenuManager.bookWritingPosition, 17);

                                do
                                {
                                    Console.CursorVisible = true;
                                    keyInfo = Console.ReadKey(true);

                                    if (keyInfo.Key != ConsoleKey.Backspace && keyInfo.Key != ConsoleKey.Enter && bookYear.Length < 4 && (keyInfo.Key == ConsoleKey.D0 || keyInfo.Key == ConsoleKey.D1 || keyInfo.Key == ConsoleKey.D2 || keyInfo.Key == ConsoleKey.D3 || keyInfo.Key == ConsoleKey.D4 || keyInfo.Key == ConsoleKey.D5 || keyInfo.Key == ConsoleKey.D6 || keyInfo.Key == ConsoleKey.D7 || keyInfo.Key == ConsoleKey.D8 || keyInfo.Key == ConsoleKey.D9 || keyInfo.Key == ConsoleKey.NumPad0 || keyInfo.Key == ConsoleKey.NumPad1 || keyInfo.Key == ConsoleKey.NumPad2 || keyInfo.Key == ConsoleKey.NumPad3 || keyInfo.Key == ConsoleKey.NumPad4 || keyInfo.Key == ConsoleKey.NumPad5 || keyInfo.Key == ConsoleKey.NumPad6 || keyInfo.Key == ConsoleKey.NumPad7 || keyInfo.Key == ConsoleKey.NumPad8 || keyInfo.Key == ConsoleKey.NumPad9))
                                    {
                                        if (keyInfo.KeyChar != '\t')
                                        {
                                            bookYear += keyInfo.KeyChar;
                                        }
                                        else
                                        {
                                            bookYear += " ";
                                        }

                                        if (keyInfo.KeyChar != '\t')
                                        {
                                            Console.Write(keyInfo.KeyChar);
                                        }
                                        else
                                        {
                                            Console.Write(" ");
                                        }
                                    }
                                    else if (keyInfo.Key == ConsoleKey.Backspace && bookYear.Length > 0)
                                    {
                                        bookYear = bookYear.Substring(0, (bookYear.Length - 1));
                                        Console.Write("\b \b");
                                    }
                                }
                                while (keyInfo.Key != ConsoleKey.Enter);

                                if (bookYear != "")
                                {
                                    bookYearConverted = Convert.ToInt32(bookYear);
                                }

                                Console.SetCursorPosition(MenuManager.bookWritingPosition, 18);

                                do
                                {
                                    Console.CursorVisible = true;
                                    keyInfo = Console.ReadKey(true);

                                    if (keyInfo.Key != ConsoleKey.Backspace && keyInfo.Key != ConsoleKey.Enter && bookPublisher.Length < 57)
                                    {
                                        if (keyInfo.KeyChar != '\t')
                                        {
                                            bookPublisher += keyInfo.KeyChar;
                                        }
                                        else
                                        {
                                            bookPublisher += " ";
                                        }

                                        if (keyInfo.KeyChar != '\t')
                                        {
                                            Console.Write(keyInfo.KeyChar);
                                        }
                                        else
                                        {
                                            Console.Write(" ");
                                        }
                                    }
                                    else if (keyInfo.Key == ConsoleKey.Backspace && bookPublisher.Length > 0)
                                    {
                                        bookPublisher = bookPublisher.Substring(0, (bookPublisher.Length - 1));
                                        Console.Write("\b \b");
                                    }
                                }
                                while (keyInfo.Key != ConsoleKey.Enter);

                                if (bookTitle != "" && bookAuthor != "" && bookPublisher != "" && bookYearConverted != 0)
                                {
                                    Book.AddBook(bookTitle, bookAuthor, bookPublisher, bookYearConverted);

                                    string info1 = "╔══════════════════════════════════╗";
                                    string info2 = "║ KSIĄŻKA ZOSTAŁA DODANA POMYŚLNIE ║";
                                    string info4 = "╚══════════════════════════════════╝";

                                    Console.WriteLine();
                                    Console.SetCursorPosition((Console.WindowWidth - info1.Length) / 2, 21);
                                    Console.WriteLine(info1);
                                    Console.SetCursorPosition((Console.WindowWidth - info2.Length) / 2, 22);
                                    Console.WriteLine(info2);
                                    Console.SetCursorPosition((Console.WindowWidth - info4.Length) / 2, 23);
                                    Console.WriteLine(info4);
                                }
                                else
                                {
                                    string info1 = "╔═══════════════════════════════════════════════╗";
                                    string info2 = "║ NIE UDAŁO SIĘ DODAĆ KSIĄŻKI - AKCJA ANULOWANA ║";
                                    string info4 = "╚═══════════════════════════════════════════════╝";

                                    Console.WriteLine();
                                    Console.SetCursorPosition((Console.WindowWidth - info1.Length) / 2, 21);
                                    Console.WriteLine(info1);
                                    Console.SetCursorPosition((Console.WindowWidth - info2.Length) / 2, 22);
                                    Console.WriteLine(info2);
                                    Console.SetCursorPosition((Console.WindowWidth - info4.Length) / 2, 23);
                                    Console.WriteLine(info4);
                                }

                                Console.CursorVisible = false;

                                bookTitle = "";
                                bookAuthor = "";
                                bookPublisher = "";
                                bookYear = "";
                                bookYearConverted = 0;

                                do
                                {
                                    keyInfo = Console.ReadKey(true);
                                }
                                while (keyInfo.Key != ConsoleKey.Enter);
                            }
                            else if (workerMainDecisionCounter == 2)
                            {
                                /// USUŃ Książkę

                                Console.ResetColor();
                                Console.Clear();
                                workerMainDecisionCounter = 1;

                                MenuManager.DeleteBookDrawer();

                                int pageNumber = 0;
                                bool deleteBookDecision = false;
                                string cleaner = "                                                                                          ";

                                do
                                {
                                    Console.ResetColor();

                                    Console.ResetColor();
                                    Console.SetCursorPosition((Console.WindowWidth - cleaner.Length) / 2, 13);

                                    for (int i = 0; i < 16; i++)
                                    {
                                        Console.SetCursorPosition((Console.WindowWidth - cleaner.Length) / 2, Console.CursorTop);
                                        Console.WriteLine(cleaner);
                                    }

                                    Console.SetCursorPosition(0, 13);

                                    Mock.ViewAllBooksList(pageNumber);

                                    keyInfo = Console.ReadKey(true);

                                    if (keyInfo.Key == ConsoleKey.LeftArrow)
                                    {
                                        if (pageNumber > 0)
                                        {
                                            pageNumber--;
                                        }
                                        else
                                        {
                                            do
                                            {
                                                keyInfo = Console.ReadKey(true);
                                                if (keyInfo.Key == ConsoleKey.Enter)
                                                {
                                                    deleteBookDecision = true;
                                                    break;
                                                }
                                            } while (keyInfo.Key != ConsoleKey.RightArrow);

                                            if (pageNumber != Mock.bookPageCounter - 1)
                                            {
                                                pageNumber++;
                                            }
                                        }
                                    }
                                    else if (keyInfo.Key == ConsoleKey.RightArrow)
                                    {
                                        if (pageNumber != Mock.bookPageCounter - 1)
                                        {
                                            pageNumber++;
                                        }
                                        else
                                        {
                                            do
                                            {
                                                keyInfo = Console.ReadKey(true);
                                                if (keyInfo.Key == ConsoleKey.Enter)
                                                {
                                                    deleteBookDecision = true;
                                                    break;
                                                }
                                            } while (keyInfo.Key != ConsoleKey.LeftArrow);

                                            if (pageNumber > 0)
                                            {
                                                pageNumber--;
                                            }
                                        }
                                    }
                                    else if (keyInfo.Key == ConsoleKey.Enter)
                                    {
                                        deleteBookDecision = true;
                                    }
                                }
                                while (deleteBookDecision == false);

                                deleteBookDecision = false;

                                Console.ResetColor();
                                Console.Clear();
                                MenuManager.DeleteBookDrawerLogo();
                                MenuManager.UserHello();
                                MenuManager.BookDeletingOptions();

                                int deletingBookHoverCounter = 1;

                                do
                                {
                                    MenuManager.DeletingBookHover(deletingBookHoverCounter);

                                    keyInfo = Console.ReadKey(true);

                                    if (keyInfo.Key == ConsoleKey.LeftArrow)
                                    {
                                        if (deletingBookHoverCounter == 2)
                                        {
                                            deletingBookHoverCounter--;
                                        }
                                        else
                                        {
                                            deletingBookHoverCounter = 2;
                                        }
                                    }
                                    else if (keyInfo.Key == ConsoleKey.RightArrow)
                                    {
                                        if (deletingBookHoverCounter == 1)
                                        {
                                            deletingBookHoverCounter++;
                                        }
                                        else
                                        {
                                            deletingBookHoverCounter = 1;
                                        }
                                    }
                                }
                                while (keyInfo.Key != ConsoleKey.Enter);

                                if(deletingBookHoverCounter == 2)
                                {

                                }
                                else if (deletingBookHoverCounter == 1)
                                {
                                    deletingBookHoverCounter = 1;

                                    MenuManager.deletingChoiceDrawer();

                                    string deletingNumber = "";
                                    int deletingNumberConverted = 0;

                                    Console.CursorVisible = true;

                                    do
                                    {
                                        keyInfo = Console.ReadKey(true);

                                        if (keyInfo.Key != ConsoleKey.Backspace && keyInfo.Key != ConsoleKey.Enter && deletingNumber.Length < 5 && (keyInfo.Key == ConsoleKey.D0 || keyInfo.Key == ConsoleKey.D1 || keyInfo.Key == ConsoleKey.D2 || keyInfo.Key == ConsoleKey.D3 || keyInfo.Key == ConsoleKey.D4 || keyInfo.Key == ConsoleKey.D5 || keyInfo.Key == ConsoleKey.D6 || keyInfo.Key == ConsoleKey.D7 || keyInfo.Key == ConsoleKey.D8 || keyInfo.Key == ConsoleKey.D9 || keyInfo.Key == ConsoleKey.NumPad0 || keyInfo.Key == ConsoleKey.NumPad1 || keyInfo.Key == ConsoleKey.NumPad2 || keyInfo.Key == ConsoleKey.NumPad3 || keyInfo.Key == ConsoleKey.NumPad4 || keyInfo.Key == ConsoleKey.NumPad5 || keyInfo.Key == ConsoleKey.NumPad6 || keyInfo.Key == ConsoleKey.NumPad7 || keyInfo.Key == ConsoleKey.NumPad8 || keyInfo.Key == ConsoleKey.NumPad9))
                                        {
                                            if (keyInfo.KeyChar != '\t')
                                            {
                                                deletingNumber += keyInfo.KeyChar;
                                            }
                                            else
                                            {
                                                deletingNumber += " ";
                                            }

                                            if (keyInfo.KeyChar != '\t')
                                            {
                                                Console.Write(keyInfo.KeyChar);
                                            }
                                            else
                                            {
                                                Console.Write(" ");
                                            }
                                        }
                                        else if (keyInfo.Key == ConsoleKey.Backspace && deletingNumber.Length > 0)
                                        {
                                            deletingNumber = deletingNumber.Substring(0, (deletingNumber.Length - 1));
                                            Console.Write("\b \b");
                                        }
                                    }
                                    while (keyInfo.Key != ConsoleKey.Enter && keyInfo.Key != ConsoleKey.Escape);

                                    Console.CursorVisible = false;

                                    if (deletingNumber != "")
                                    {
                                        deletingNumberConverted = Convert.ToInt32(deletingNumber) - 1;
                                    }
                                    else
                                    {
                                        deletingNumberConverted = -1;
                                    }

                                    Book.DeleteBook(deletingNumberConverted);

                                    do
                                    {
                                        keyInfo = Console.ReadKey(true);
                                    }
                                    while (keyInfo.Key != ConsoleKey.Enter);
                                }
                            }
                            else if (workerMainDecisionCounter == 3)
                            {
                                /// EDYTUJ Książkę
                                workerMainDecisionCounter = 1;
                                Console.ResetColor();
                                Console.Clear();

                                MenuManager.EditBookDrawer();

                                int pageNumber = 0;
                                bool deleteBookDecision = false;
                                string cleaner = "                                                                                          ";

                                do
                                {
                                    Console.ResetColor();

                                    Console.ResetColor();
                                    Console.SetCursorPosition((Console.WindowWidth - cleaner.Length) / 2, 13);

                                    for (int i = 0; i < 16; i++)
                                    {
                                        Console.SetCursorPosition((Console.WindowWidth - cleaner.Length) / 2, Console.CursorTop);
                                        Console.WriteLine(cleaner);
                                    }

                                    Console.SetCursorPosition(0, 13);

                                    Mock.ViewAllBooksList(pageNumber);

                                    keyInfo = Console.ReadKey(true);

                                    if (keyInfo.Key == ConsoleKey.LeftArrow)
                                    {
                                        if (pageNumber > 0)
                                        {
                                            pageNumber--;
                                        }
                                        else
                                        {
                                            do
                                            {
                                                keyInfo = Console.ReadKey(true);
                                                if (keyInfo.Key == ConsoleKey.Enter)
                                                {
                                                    deleteBookDecision = true;
                                                    break;
                                                }
                                            } while (keyInfo.Key != ConsoleKey.RightArrow);

                                            if (pageNumber != Mock.bookPageCounter - 1)
                                            {
                                                pageNumber++;
                                            }
                                        }
                                    }
                                    else if (keyInfo.Key == ConsoleKey.RightArrow)
                                    {
                                        if (pageNumber != Mock.bookPageCounter - 1)
                                        {
                                            pageNumber++;
                                        }
                                        else
                                        {
                                            do
                                            {
                                                keyInfo = Console.ReadKey(true);
                                                if (keyInfo.Key == ConsoleKey.Enter)
                                                {
                                                    deleteBookDecision = true;
                                                    break;
                                                }
                                            } while (keyInfo.Key != ConsoleKey.LeftArrow);

                                            if (pageNumber > 0)
                                            {
                                                pageNumber--;
                                            }
                                        }
                                    }
                                    else if (keyInfo.Key == ConsoleKey.Enter)
                                    {
                                        deleteBookDecision = true;
                                    }
                                }
                                while (deleteBookDecision == false);

                                deleteBookDecision = false;

                                Console.ResetColor();
                                Console.Clear();
                                MenuManager.EditBookDrawerLogo();
                                MenuManager.UserHello();
                                MenuManager.EditBookOptionsDrawer();

                                int editBookHooverCounter = 1;

                                do
                                {
                                    MenuManager.EditBookOptionsHoover(editBookHooverCounter);

                                    keyInfo = Console.ReadKey(true);

                                    if(keyInfo.Key == ConsoleKey.LeftArrow)
                                    {
                                        if(editBookHooverCounter == 2)
                                        {
                                            editBookHooverCounter--;
                                        }
                                        else
                                        {
                                            editBookHooverCounter = 2;
                                        }
                                    }
                                    else if (keyInfo.Key == ConsoleKey.RightArrow)
                                    {
                                        if (editBookHooverCounter == 1)
                                        {
                                            editBookHooverCounter++;
                                        }
                                        else
                                        {
                                            editBookHooverCounter = 1;
                                        }
                                    }
                                }
                                while (keyInfo.Key != ConsoleKey.Enter);

                                if (editBookHooverCounter == 1)
                                {
                                    MenuManager.EditBookTextBox();
                                    Console.CursorVisible = true;

                                    string editNumber = "";
                                    int editNumberConverted = 0;

                                    do
                                    {
                                        keyInfo = Console.ReadKey(true);

                                        if (keyInfo.Key != ConsoleKey.Backspace && keyInfo.Key != ConsoleKey.Enter && editNumber.Length < 5 && (keyInfo.Key == ConsoleKey.D0 || keyInfo.Key == ConsoleKey.D1 || keyInfo.Key == ConsoleKey.D2 || keyInfo.Key == ConsoleKey.D3 || keyInfo.Key == ConsoleKey.D4 || keyInfo.Key == ConsoleKey.D5 || keyInfo.Key == ConsoleKey.D6 || keyInfo.Key == ConsoleKey.D7 || keyInfo.Key == ConsoleKey.D8 || keyInfo.Key == ConsoleKey.D9 || keyInfo.Key == ConsoleKey.NumPad0 || keyInfo.Key == ConsoleKey.NumPad1 || keyInfo.Key == ConsoleKey.NumPad2 || keyInfo.Key == ConsoleKey.NumPad3 || keyInfo.Key == ConsoleKey.NumPad4 || keyInfo.Key == ConsoleKey.NumPad5 || keyInfo.Key == ConsoleKey.NumPad6 || keyInfo.Key == ConsoleKey.NumPad7 || keyInfo.Key == ConsoleKey.NumPad8 || keyInfo.Key == ConsoleKey.NumPad9))
                                        {
                                            if (keyInfo.KeyChar != '\t')
                                            {
                                                editNumber += keyInfo.KeyChar;
                                            }
                                            else
                                            {
                                                editNumber += " ";
                                            }

                                            if (keyInfo.KeyChar != '\t')
                                            {
                                                Console.Write(keyInfo.KeyChar);
                                            }
                                            else
                                            {
                                                Console.Write(" ");
                                            }
                                        }
                                        else if (keyInfo.Key == ConsoleKey.Backspace && editNumber.Length > 0)
                                        {
                                            editNumber = editNumber.Substring(0, (editNumber.Length - 1));
                                            Console.Write("\b \b");
                                        }
                                    }
                                    while (keyInfo.Key != ConsoleKey.Enter && keyInfo.Key != ConsoleKey.Escape);

                                    if(editNumber != "")
                                    {
                                        editNumberConverted = Convert.ToInt32(editNumber) - 1;
                                    }
                                    else
                                    {
                                        editNumberConverted = -1;
                                    }

                                    string bookTitle = "";
                                    string bookAuthor = "";
                                    string bookYear = "";
                                    int bookYearConverted = 0;
                                    string bookPublisher = "";

                                    Console.CursorVisible = false;

                                    Book.EditBook(editNumberConverted, bookTitle, bookAuthor, bookYear, bookYearConverted, bookPublisher);
                                }

                                Console.CursorVisible = false;

                            }
                            else if (workerMainDecisionCounter == 4)
                            {
                                /// Wyświetlanie listy użytkowników

                                workerMainDecisionCounter = 1;
                                Console.ResetColor();
                                Console.Clear();

                                MenuManager.UsersListLogo();

                                int pageNumber = 0;
                                int pageCount = 0;
                                int pageModulo = 0;
                                int pageNumberFix = 0;

                                pageCount = Mock._users.Count / 3;
                                pageCount = (int)Math.Ceiling(Convert.ToDecimal(pageCount));
                                pageModulo = Mock._users.Count % 3;

                                do
                                {
                                    Console.SetCursorPosition(0, 14);

                                    Console.BackgroundColor = ConsoleColor.Black;
                                    string cleaner = "                                                                      ";
                                    for (int i = 0; i < 12; i++)
                                    {
                                        Console.SetCursorPosition((Console.WindowWidth - cleaner.Length) / 2, Console.CursorTop);
                                        Console.WriteLine(cleaner);
                                    }
                                    Console.BackgroundColor = ConsoleColor.DarkBlue;

                                    Console.SetCursorPosition(0, 14);

                                    pageNumberFix = pageNumber * 3;

                                    if (pageNumber == pageCount)
                                    {
                                        if (pageModulo == 0)
                                        {
                                            User.UsersListDrawer(pageNumberFix);
                                            User.UsersListDrawer(pageNumberFix + 1);
                                            User.UsersListDrawer(pageNumberFix + 2);
                                        }
                                        else if (pageModulo == 1)
                                        {
                                            User.UsersListDrawer(pageNumberFix);
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                        }
                                        else if (pageModulo == 2)
                                        {
                                            User.UsersListDrawer(pageNumberFix);
                                            User.UsersListDrawer(pageNumberFix + 1);
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                        }
                                    }
                                    else
                                    {
                                        User.UsersListDrawer(pageNumberFix);
                                        User.UsersListDrawer(pageNumberFix + 1);
                                        User.UsersListDrawer(pageNumberFix + 2);
                                    }

                                    keyInfo = Console.ReadKey(true);

                                    if(keyInfo.Key == ConsoleKey.LeftArrow)
                                    {
                                        if(pageNumber > 0)
                                        {
                                            pageNumber--;
                                        }
                                        
                                    }
                                    else if (keyInfo.Key == ConsoleKey.RightArrow)
                                    {
                                        if(pageNumberFix < pageCount)
                                        {
                                            pageNumber++;
                                        }
                                    }
                                }
                                while (keyInfo.Key != ConsoleKey.Enter);
                            }
                            else if (workerMainDecisionCounter == 5)
                            {
                                workerMainDecisionCounter = 1;
                                userLoggedIn = false;
                            }

                            Console.ResetColor();
                            Console.Clear();

                        }
                        else
                            {
                                /// AKCJE UŻYTKOWNIKA - CZYTELNIKA
                                DisplayManager.DrawUserInterphace();

                                do
                                {
                                    Console.CursorVisible = false;

                                    MenuManager.userMainMenuChoiceHover();

                                    keyInfo = Console.ReadKey(true);

                                    if (keyInfo.Key == ConsoleKey.Enter)
                                    {
                                        userMainMenuDecision = true;
                                    }

                                    if (keyInfo.Key == ConsoleKey.LeftArrow)
                                    {
                                        if (MenuManager.userMainMenuChoice > 1)
                                        {
                                            MenuManager.userMainMenuChoice--;
                                        }
                                        else
                                        {
                                            MenuManager.userMainMenuChoice = 4;
                                        }
                                    }

                                    if (keyInfo.Key == ConsoleKey.RightArrow)
                                    {
                                        if (MenuManager.userMainMenuChoice < 4)
                                        {
                                            MenuManager.userMainMenuChoice++;
                                        }
                                        else
                                        {
                                            MenuManager.userMainMenuChoice = 1;
                                        }
                                    }
                                }
                                while (userMainMenuDecision == false);

                                if (MenuManager.userMainMenuChoice == 1)
                                {
                                    userMainMenuDecision = false;
                                    Console.Clear();
                                    MenuManager.UserBookListLogo();

                                    /// Lista książek wypożyczonych do wglądu
                                    Mock.userBooks(true);
                                    MenuManager.UserBackButton();

                                    do
                                    {
                                        keyInfo = Console.ReadKey(true);
                                    } while (keyInfo.Key != ConsoleKey.Enter);

                                }
                                else if (MenuManager.userMainMenuChoice == 2)
                                {
                                    userMainMenuDecision = false;
                                    MenuManager.userMainMenuChoice = 1;
                                    int pageNumber = 0;
                                    Console.CursorVisible = false;

                                    /// Lista książek z możliwością dodania książki do zamówionych do wypożyczenia

                                    Console.Clear();
                                    Console.ResetColor();
                                    MenuManager.LendingLogo();
                                    MenuManager.LendingText();

                                    string cleaner = "                                                                                          ";

                                    do
                                    {
                                        Console.ResetColor();

                                        Console.ResetColor();
                                        Console.SetCursorPosition((Console.WindowWidth - cleaner.Length)/2, 13);

                                        for (int i = 0; i < 16; i++)
                                        {
                                            Console.SetCursorPosition((Console.WindowWidth - cleaner.Length) / 2, Console.CursorTop);
                                            Console.WriteLine(cleaner);
                                        }

                                        Console.SetCursorPosition(0, 13);

                                        Mock.ViewAllBooksList(pageNumber);

                                        keyInfo = Console.ReadKey(true);

                                        if(keyInfo.Key == ConsoleKey.LeftArrow)
                                        {
                                            if(pageNumber > 0)
                                            {
                                                pageNumber--;
                                            }
                                            else
                                            {
                                                do
                                                {
                                                    keyInfo = Console.ReadKey(true);
                                                    if (keyInfo.Key == ConsoleKey.Enter)
                                                    {
                                                        lendingBookListManager = true;
                                                        break;
                                                    }
                                                } while (keyInfo.Key != ConsoleKey.RightArrow);

                                                if (pageNumber != Mock.bookPageCounter - 1)
                                                {
                                                    pageNumber++;
                                                }
                                            }
                                        }
                                        else if(keyInfo.Key == ConsoleKey.RightArrow)
                                        {
                                            if(pageNumber != Mock.bookPageCounter-1)
                                            {
                                                pageNumber++;
                                            }
                                            else
                                            {
                                                do
                                                {
                                                    keyInfo = Console.ReadKey(true);
                                                    if(keyInfo.Key == ConsoleKey.Enter)
                                                    {
                                                        lendingBookListManager = true;
                                                        break;
                                                    }
                                                } while (keyInfo.Key != ConsoleKey.LeftArrow);

                                                if (pageNumber > 0)
                                                {
                                                    pageNumber--;
                                                }
                                            }
                                        }
                                        else if (keyInfo.Key == ConsoleKey.Enter)
                                        {
                                            lendingBookListManager = true;
                                        }
                                    }
                                    while (lendingBookListManager == false);

                                    lendingBookListManager = false;

                                    Console.ResetColor();
                                    Console.Clear();
                                    MenuManager.LendingLogo();
                                    MenuManager.UserHello();
                                    MenuManager.BookLendingOptions();

                                    do
                                    {
                                        MenuManager.UserLendingOptionsHover();
                                        keyInfo = Console.ReadKey(true);

                                        if (keyInfo.Key == ConsoleKey.LeftArrow)
                                        {
                                            if (MenuManager.lendingButtonHover > 1)
                                            {
                                                MenuManager.lendingButtonHover--;
                                            }
                                            else
                                            {
                                                MenuManager.lendingButtonHover = 2;
                                            }
                                        }
                                        else if (keyInfo.Key == ConsoleKey.RightArrow)
                                        {
                                            if (MenuManager.lendingButtonHover < 2)
                                            {
                                                MenuManager.lendingButtonHover++;
                                            }
                                            else
                                            {
                                                MenuManager.lendingButtonHover = 1;
                                            }
                                        }
                                        else if(keyInfo.Key == ConsoleKey.Enter)
                                        {
                                            lendingDecision = true;
                                        }
                                    }
                                    while (lendingDecision == false);

                                    lendingDecision = false;

                                    if (MenuManager.lendingButtonHover == 1)
                                    {
                                        MenuManager.lendingChoiceDrawer();

                                        do {
                                            Console.SetCursorPosition(MenuManager.fixPanelPosition, 19);
                                            Console.WriteLine("     ");
                                            Console.SetCursorPosition(MenuManager.fixPanelPosition, 19);
                                            Console.CursorVisible = true;
                                            try
                                            {
                                                do
                                                {
                                                    keyInfo = Console.ReadKey(true);

                                                    if (keyInfo.Key != ConsoleKey.Backspace && keyInfo.Key != ConsoleKey.Enter && lendedBookNumber.Length < 5 && (keyInfo.Key == ConsoleKey.D0 || keyInfo.Key == ConsoleKey.D1 || keyInfo.Key == ConsoleKey.D2 || keyInfo.Key == ConsoleKey.D3 || keyInfo.Key == ConsoleKey.D4 || keyInfo.Key == ConsoleKey.D5 || keyInfo.Key == ConsoleKey.D6 || keyInfo.Key == ConsoleKey.D7 || keyInfo.Key == ConsoleKey.D8 || keyInfo.Key == ConsoleKey.D9 || keyInfo.Key == ConsoleKey.NumPad0 || keyInfo.Key == ConsoleKey.NumPad1 || keyInfo.Key == ConsoleKey.NumPad2 || keyInfo.Key == ConsoleKey.NumPad3 || keyInfo.Key == ConsoleKey.NumPad4 || keyInfo.Key == ConsoleKey.NumPad5 || keyInfo.Key == ConsoleKey.NumPad6 || keyInfo.Key == ConsoleKey.NumPad7 || keyInfo.Key == ConsoleKey.NumPad8 || keyInfo.Key == ConsoleKey.NumPad9))
                                                    {
                                                        if (keyInfo.KeyChar != '\t')
                                                        {
                                                            lendedBookNumber += keyInfo.KeyChar;
                                                        }
                                                        else
                                                        {
                                                            lendedBookNumber += " ";
                                                        }

                                                        if (keyInfo.KeyChar != '\t')
                                                        {
                                                            Console.Write(keyInfo.KeyChar);
                                                        }
                                                        else
                                                        {
                                                            Console.Write(" ");
                                                        }
                                                    }
                                                    else if (keyInfo.Key == ConsoleKey.Backspace && lendedBookNumber.Length > 0)
                                                    {
                                                        lendedBookNumber = lendedBookNumber.Substring(0, (lendedBookNumber.Length - 1));
                                                        Console.Write("\b \b");
                                                    }
                                                }
                                                while (keyInfo.Key != ConsoleKey.Enter);

                                                lendedBookNumberConverted = Convert.ToInt32(lendedBookNumber) - 1;
                                                lendedBookNumber = "";

                                                /// Sprawdzenie czy książka jest dostępna (czy numer istnieje i czy nie jest już wypożyczona)

                                                Mock.LendingBookChecker(lendedBookNumberConverted);

                                                lendingWriteFix = true;
                                            }
                                            catch (Exception)
                                            {
                                                lendingWriteFix = false;
                                            }
                                        }
                                        while (lendingWriteFix == false);

                                        lendingWriteFix = false;

                                        Console.CursorVisible = false;
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        MenuManager.lendingButtonHover = 1;
                                        Console.Clear();
                                    }
                                }
                                else if (MenuManager.userMainMenuChoice == 3)
                                {
                                    userMainMenuDecision = false;
                                    MenuManager.userMainMenuChoice = 1;

                                    Console.Clear();
                                    MenuManager.ReturnBookLogo();

                                    Mock.userBooks(false);

                                    MenuManager.ReturnBookOptions();

                                    /// Usuwanie wypożyczeń (oddawanie książek)
                                }
                                else if (MenuManager.userMainMenuChoice == 4)
                                {
                                    userMainMenuDecision = false;
                                    MenuManager.userMainMenuChoice = 1;
                                    userLoggedIn = false;
                                }

                                Console.ResetColor();
                                Console.Clear();
                            }
                    }
                    while (userLoggedIn == true);
                }
                else if (MenuManager.mainMenuChoice == 2)
                {
                    MenuManager.mainMenuChoice = 1;
                    Console.Clear();

                    DisplayManager.DrawInformation();

                    do
                    {
                        Console.CursorVisible = false;

                        MenuManager.mainMenuInformationHover();

                        keyInfo = Console.ReadKey(true);

                        if (keyInfo.Key == ConsoleKey.Enter)
                        {
                            informationDecision = true;
                        }
                        else if (keyInfo.Key == ConsoleKey.LeftArrow)
                        {
                            if(MenuManager.InformationChoice > 1)
                            {
                                MenuManager.InformationChoice--;
                            }
                            else
                            {
                                MenuManager.InformationChoice = 2;
                            }
                        }
                        else if (keyInfo.Key == ConsoleKey.RightArrow)
                        {
                            if(MenuManager.InformationChoice < 2)
                            {
                                MenuManager.InformationChoice++;
                            }
                            else
                            {
                                MenuManager.InformationChoice = 1;
                            }
                        }
                    }
                    while (informationDecision == false);

                    if (MenuManager.InformationChoice == 1)
                    {
                        Console.Clear();
                    }
                    else if (MenuManager.InformationChoice == 2)
                    {
                        Environment.Exit(0);
                    }

                    Console.CursorVisible = true;
                }
                else if (MenuManager.mainMenuChoice == 3)
                {
                    Environment.Exit(0);
                }

                Console.CursorVisible = true;
            }
            while (!aplicationExit);
        }
    }
}
