using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteka.Database;
using Biblioteka.Other;

namespace Biblioteka.Model
{
    public class Book : Resource
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string Date { get; set; }
        public bool IsLended { get; set; }

        public static ConsoleKeyInfo keyInfo;

        public static void AddBook(string bookTitle, string bookAuthor, string bookPublisher, int bookYear)
        {
            Book book = new Book();

            book.Id = Guid.NewGuid().ToString();
            book.Title = bookTitle;
            book.Author = bookAuthor;
            book.Publisher = bookPublisher;
            book.Year = bookYear;

            Mock._books.Add(book);
        }

        public static void DeleteBook(int bookNumber)
        {
            try
            {
                if (Mock._books[bookNumber].IsLended == false)
                {
                    Mock._books.RemoveAt(bookNumber);

                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.White;

                    string info1 = "╔════════════════════════════════════╗";
                    string info2 = "║ KSIĄŻKA ZOSTAŁA POMYŚLNIE USUNIĘTA ║";
                    string info3 = "╚════════════════════════════════════╝";

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.SetCursorPosition((Console.WindowWidth - info1.Length) / 2, Console.CursorTop);
                    Console.WriteLine(info1);
                    Console.SetCursorPosition((Console.WindowWidth - info2.Length) / 2, Console.CursorTop);
                    Console.WriteLine(info2);
                    Console.SetCursorPosition((Console.WindowWidth - info3.Length) / 2, Console.CursorTop);
                    Console.WriteLine(info3);

                    Console.ResetColor();
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.White;

                    string info1 = "╔════════════════════════════════════════════════╗";
                    string info2 = "║ NIE UDAŁO SIĘ USUNĄĆ KSIĄŻKI - AKCJA ANULOWANA ║";
                    string info3 = "╚════════════════════════════════════════════════╝";

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.SetCursorPosition((Console.WindowWidth - info1.Length) / 2, Console.CursorTop);
                    Console.WriteLine(info1);
                    Console.SetCursorPosition((Console.WindowWidth - info2.Length) / 2, Console.CursorTop);
                    Console.WriteLine(info2);
                    Console.SetCursorPosition((Console.WindowWidth - info3.Length) / 2, Console.CursorTop);
                    Console.WriteLine(info3);

                    Console.ResetColor();
                }
            }
            catch(Exception)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;

                string info1 = "╔════════════════════════════════════════════════╗";
                string info2 = "║ NIE UDAŁO SIĘ USUNĄĆ KSIĄŻKI - AKCJA ANULOWANA ║";
                string info3 = "╚════════════════════════════════════════════════╝";

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.SetCursorPosition((Console.WindowWidth - info1.Length) / 2, Console.CursorTop);
                Console.WriteLine(info1);
                Console.SetCursorPosition((Console.WindowWidth - info2.Length) / 2, Console.CursorTop);
                Console.WriteLine(info2);
                Console.SetCursorPosition((Console.WindowWidth - info3.Length) / 2, Console.CursorTop);
                Console.WriteLine(info3);

                Console.ResetColor();
            }
        }

        public static void EditBook(int bookNumber, string bookTitle, string bookAuthor, string bookYear, int bookYearConverted, string bookPublisher)
        {
            if(bookNumber == -1 || bookNumber + 1 > Mock._books.Count)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;

                string info1 = "╔══════════════════════════════════════════════════╗";
                string info2 = "║ BRAK PODANEJ KSIĄŻKI NA LIŚCIE - AKCJA ANULOWANA ║";
                string info3 = "╚══════════════════════════════════════════════════╝";

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.SetCursorPosition((Console.WindowWidth - info1.Length) / 2, Console.CursorTop);
                Console.WriteLine(info1);
                Console.SetCursorPosition((Console.WindowWidth - info2.Length) / 2, Console.CursorTop);
                Console.WriteLine(info2);
                Console.SetCursorPosition((Console.WindowWidth - info3.Length) / 2, Console.CursorTop);
                Console.WriteLine(info3);
                Console.WriteLine();

                Console.ResetColor();

                do
                {
                    keyInfo = Console.ReadKey(true);
                }
                while (keyInfo.Key != ConsoleKey.Enter);
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;

                string info5 =  "╔════════════════════════════════════════════════════════════════════════╗";
                string info6 =  "║       TYTUŁ:                                                           ║";
                string info7 =  "║       AUTOR:                                                           ║";
                string info8 =  "║ ROK WYDANIA:                                                           ║";
                string info9 =  "║ WYDAWNICTWO:                                                           ║";
                string info10 = "╚════════════════════════════════════════════════════════════════════════╝";

                Console.SetCursorPosition((Console.WindowWidth - info5.Length) / 2, 13);
                Console.WriteLine();
                Console.SetCursorPosition((Console.WindowWidth - info5.Length) / 2, Console.CursorTop);
                Console.WriteLine(info5);
                Console.SetCursorPosition((Console.WindowWidth - info6.Length) / 2, Console.CursorTop);
                Console.WriteLine(info6);
                Console.SetCursorPosition((Console.WindowWidth - info7.Length) / 2, Console.CursorTop);
                Console.WriteLine(info7);
                Console.SetCursorPosition((Console.WindowWidth - info8.Length) / 2, Console.CursorTop);
                Console.WriteLine(info8);
                Console.SetCursorPosition((Console.WindowWidth - info9.Length) / 2, Console.CursorTop);
                Console.WriteLine(info9);
                Console.SetCursorPosition((Console.WindowWidth - info10.Length) / 2, Console.CursorTop);
                Console.WriteLine(info10);

                MenuManager.bookWritingPosition = ((Console.WindowWidth - info5.Length) / 2) + 15;

                Console.BackgroundColor = ConsoleColor.Black;
                Console.SetCursorPosition((Console.WindowWidth - info10.Length) / 2, Console.CursorTop);
                Console.WriteLine("                                                                                ");
                Console.BackgroundColor = ConsoleColor.DarkBlue;

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
                    EditBookMethod(bookNumber, bookTitle, bookAuthor, bookPublisher, bookYearConverted);

                    string info1 = "╔═════════════════════════════════════╗";
                    string info2 = "║ KSIĄŻKA ZOSTAŁA EDYTOWANA POMYŚLNIE ║";
                    string info4 = "╚═════════════════════════════════════╝";

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
                    string info1 = "╔══════════════════════════════════════════════════╗";
                    string info2 = "║ NIE UDAŁO SIĘ EDYTOWAĆ KSIĄŻKI - AKCJA ANULOWANA ║";
                    string info4 = "╚══════════════════════════════════════════════════╝";

                    Console.WriteLine();
                    Console.SetCursorPosition((Console.WindowWidth - info1.Length) / 2, 21);
                    Console.WriteLine(info1);
                    Console.SetCursorPosition((Console.WindowWidth - info2.Length) / 2, 22);
                    Console.WriteLine(info2);
                    Console.SetCursorPosition((Console.WindowWidth - info4.Length) / 2, 23);
                    Console.WriteLine(info4);
                }

                bookTitle = "";
                bookAuthor = "";
                bookPublisher = "";
                bookYear = "";
                bookYearConverted = 0;

                Console.CursorVisible = false;

                do
                {
                    keyInfo = Console.ReadKey(true);
                }
                while (keyInfo.Key != ConsoleKey.Enter);

                Console.ResetColor();
            }
        }

        public static void EditBookMethod(int bookNumber, string bookTitle, string bookAuthor, string bookPublisher, int bookYear)
        {
            Mock._books[bookNumber].Title = bookTitle;
            Mock._books[bookNumber].Author = bookAuthor;
            Mock._books[bookNumber].Publisher = bookPublisher;
            Mock._books[bookNumber].Year = bookYear;
        }
    }
}
