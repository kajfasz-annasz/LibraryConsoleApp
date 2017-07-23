using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteka.Model;
using Biblioteka.Other;

namespace Biblioteka.Database
{
    public static class Mock
    {
        public static List<User> _users = new List<User>()
        {
            new User()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Krzysztof",
                Login = "chris",
                Password = "123",
                IsWorker = false,
                Year = 1996,
                Books = new List<Book>()
            },

            new User()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Mariusz",
                Login = "muczka",
                Password = "123",
                IsWorker = false,
                Year = 1994,
                Books = new List<Book>()
            },

            new User()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Piotr",
                Login = "burek",
                Password = "123",
                IsWorker = false,
                Year = 1992,
                Books = new List<Book>()
            },

            new User()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Grzegorz",
                Login = "bibliotek",
                Password = "123",
                IsWorker = true,
                Year = 1972
            },
        };

        public static List<Book> _books = new List<Book>()
        {
            new Book()
            {
                Id = Guid.NewGuid().ToString(),
                Title = "Bezrobotni w Świecie",
                Author = "Stefan Wąs",
                Publisher = "Garretta",
                Year = 2012,
            },

            new Book()
            {
                Id = Guid.NewGuid().ToString(),
                Title = "Apokalipsa 1900",
                Author = "Druid Dżon",
                Publisher = "Sobieski Press",
                Year = 1873,
            },

            new Book()
            {
                Id = Guid.NewGuid().ToString(),
                Title = "Gdzie Jest Borubar?",
                Author = "Grzegorz Lato",
                Publisher = "Koperta",
                Year = 2011,
            },

            new Book()
            {
                Id = Guid.NewGuid().ToString(),
                Title = "Opowieści z Narnii: Lew, Czarownica i Stara Szafa",
                Author = "C.S.Lewis",
                Publisher = "Media Rodzina",
                Year = 1950,
            },
            
            new Book()
            {
                Id = Guid.NewGuid().ToString(),
                Title = "Opowieści z Narnii: Książe Kaspian",
                Author = "C.S.Lewis",
                Publisher = "Media Rodzina",
                Year = 1951,
            },

            new Book()
            {
                Id = Guid.NewGuid().ToString(),
                Title = "Opowieści z Narnii: Podróż Wędrowca do Świtu",
                Author = "C.S.Lewis",
                Publisher = "Media Rodzina",
                Year = 1952,
            },

            new Book()
            {
                Id = Guid.NewGuid().ToString(),
                Title = "Opowieści z Narnii: Srebrne Krzesło",
                Author = "C.S.Lewis",
                Publisher = "Media Rodzina",
                Year = 1953,
            },

            new Book()
            {
                Id = Guid.NewGuid().ToString(),
                Title = "Opowieści z Narnii: Koń i Jego Chłopiec",
                Author = "C.S.Lewis",
                Publisher = "Media Rodzina",
                Year = 1954,
            },

            new Book()
            {
                Id = Guid.NewGuid().ToString(),
                Title = "Opowieści z Narnii: Siostrzeniec Czarodzieja",
                Author = "C.S.Lewis",
                Publisher = "Media Rodzina",
                Year = 1955,
            },

            new Book()
            {
                Id = Guid.NewGuid().ToString(),
                Title = "Opowieści z Narnii: Ostatnia Bitwa",
                Author = "C.S.Lewis",
                Publisher = "Media Rodzina",
                Year = 1956,
            },

            new Book()
            {
                Id = Guid.NewGuid().ToString(),
                Title = "Słoń w Himalajach",
                Author = "Stanisław Burczybas",
                Publisher = "Mediaton",
                Year = 2013,
            },

            new Book()
            {
                Id = Guid.NewGuid().ToString(),
                Title = "Gitary bez Strun",
                Author = "Adam Biedny",
                Publisher = "PowerSound",
                Year = 2003,
            },

            new Book()
            {
                Id = Guid.NewGuid().ToString(),
                Title = "Harry Potter i Kamień Filozoficzny",
                Author = "J.K. Rowling",
                Publisher = "Media Rodzina",
                Year = 1997,
            },
            
            new Book()
            {
                Id = Guid.NewGuid().ToString(),
                Title = "Harry Potter i Komnata Tajemnic",
                Author = "J.K. Rowling",
                Publisher = "Media Rodzina",
                Year = 1998,
            },

            new Book()
            {
                Id = Guid.NewGuid().ToString(),
                Title = "Harry Potter i Więzień Azkabanu",
                Author = "J.K. Rowling",
                Publisher = "Media Rodzina",
                Year = 1999,
            },

            new Book()
            {
                Id = Guid.NewGuid().ToString(),
                Title = "Harry Potter i Czara Ognia",
                Author = "J.K. Rowling",
                Publisher = "Media Rodzina",
                Year = 2000,
            },

            new Book()
            {
                Id = Guid.NewGuid().ToString(),
                Title = "Harry Potter i Zakon Feniksa",
                Author = "J.K. Rowling",
                Publisher = "Media Rodzina",
                Year = 2003,
            },

            new Book()
            {
                Id = Guid.NewGuid().ToString(),
                Title = "Harry Potter i Książe Półkrwi",
                Author = "J.K. Rowling",
                Publisher = "Media Rodzina",
                Year = 2005,
            },

            new Book()
            {
                Id = Guid.NewGuid().ToString(),
                Title = "Harry Potter i Insygnia Śmierci",
                Author = "J.K. Rowling",
                Publisher = "Media Rodzina",
                Year = 2007,
            },

            new Book()
            {
                Id = Guid.NewGuid().ToString(),
                Title = "Płać i Płacz",
                Author = "Aaron Szehter",
                Publisher = "Piniądz S.A.",
                Year = 2014,
            },

            new Book()
            {
                Id = Guid.NewGuid().ToString(),
                Title = "Atomizery i Gejzery",
                Author = "Hipolit Vappman",
                Publisher = "Buh Buh Production",
                Year = 2011,
            },

            new Book()
            {
                Id = Guid.NewGuid().ToString(),
                Title = "Kane: Pajęczyna Ciemności",
                Author = "K.E. Wagner",
                Publisher = "Phantom Press",
                Year = 1970,
            },

            new Book()
            {
                Id = Guid.NewGuid().ToString(),
                Title = "Kane: Krwawnik",
                Author = "K.E. Wagner",
                Publisher = "Phantom Press",
                Year = 1975,
            },

            new Book()
            {
                Id = Guid.NewGuid().ToString(),
                Title = "Kane: Wichry Nocy",
                Author = "K.E. Wagner",
                Publisher = "Phantom Press",
                Year = 1978,
            },

            new Book()
            {
                Id = Guid.NewGuid().ToString(),
                Title = "Kane: Cień Anioła Śmierci",
                Author = "K.E. Wagner",
                Publisher = "Phantom Press",
                Year = 1973,
            },

            new Book()
            {
                Id = Guid.NewGuid().ToString(),
                Title = "Kane: Mroczna Krucjata",
                Author = "K.E. Wagner",
                Publisher = "Phantom Press",
                Year = 1976,
            },

            new Book()
            {
                Id = Guid.NewGuid().ToString(),
                Title = "Afrykańska Miłość Mumby Kumby",
                Author = "Moomba Coomba",
                Publisher = "The Mariush Press",
                Year = 2005,
            },

            new Book()
            {
                Id = Guid.NewGuid().ToString(),
                Title = "Afrykańska Miłość II: Brat Mumby Kumby",
                Author = "Moomba Coomba",
                Publisher = "The Mariush Press",
                Year = 2008,
            },

            new Book()
            {
                Id = Guid.NewGuid().ToString(),
                Title = "Algebra Liniowa",
                Author = "Vladimir Liniow",
                Publisher = "Children Entertainment",
                Year = 2015,
            },

            new Book()
            {
                Id = Guid.NewGuid().ToString(),
                Title = "Teoria Spiskowa",
                Author = "Antoni Leonid Spiskov",
                Publisher = "Children Entertainment",
                Year = 1983,
            },

            new Book()
            {
                Id = Guid.NewGuid().ToString(),
                Title = "Sen Łysiejącego Mariusza",
                Author = "Piotr Mazepa",
                Publisher = "Bezrobotni S.A.",
                Year = 1987,
            },

            new Book()
            {
                Id = Guid.NewGuid().ToString(),
                Title = "Szła Baba Karaba do Dziada",
                Author = "Ireneusz Swędziwór",
                Publisher = "Pamparampam",
                Year = 1994,
            },

            new Book()
            {
                Id = Guid.NewGuid().ToString(),
                Title = "Któż To Napisał",
                Author = "Mirosław Któż",
                Publisher = "Słoń Trojański",
                Year = 2002,
            },

            new Book()
            {
                Id = Guid.NewGuid().ToString(),
                Title = "Mięsko dla Kojota",
                Author = "Jarosław Kojot",
                Publisher = "Trombiński Cell",
                Year = 2017,
            },

        };


        public static bool validData;
        public static bool isAdmin;
        public static bool isWorker;
        public static string userName;
        public static string userID;

        public static void CorrectData(string login, string password)
        {
            var user = _users.FirstOrDefault(m => m.Login == login);

            if (user == null)
            {
                validData = false;
            }

            if (user != null)
            {
                validData = true;

                if (user.Password != password)
                {
                    validData = false;
                }
                else
                {
                    if (user.IsWorker == true)
                    {
                        isWorker = true;
                    }
                    else
                    {
                        isWorker = false;
                    }

                    userName = user.Name;
                    userID = user.Id;
                }
            }
        }

        public static void userBooks(bool displayFix)
        {
            User loggedUser = new User();

            foreach(User user in _users)
            {
                if(user.Id == userID)
                {
                    loggedUser = user;
                }
            }

            if(loggedUser != null)
            {
                if(loggedUser.Books.Count == 0)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.DarkBlue;

                    string info1 = "╔════════════════════════════════════════╗";
                    string info2 = "║ BRAK WYPOŻYCZONYCH KSIĄŻEK W SYSTEMIE! ║";
                    string info3 = "╚════════════════════════════════════════╝";

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
                    if (displayFix)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.DarkBlue;

                        string info1 = "╔══════════════════════════════════════════╗";
                        string info2 = "║ LISTA KSIĄŻEK WYPOŻYCZONYCH Z BIBLIOTEKI ║";
                        string info3 = "╚══════════════════════════════════════════╝";

                        Console.WriteLine();
                        Console.SetCursorPosition((Console.WindowWidth - info1.Length) / 2, Console.CursorTop);
                        Console.WriteLine(info1);
                        Console.SetCursorPosition((Console.WindowWidth - info2.Length) / 2, Console.CursorTop);
                        Console.WriteLine(info2);
                        Console.SetCursorPosition((Console.WindowWidth - info3.Length) / 2, Console.CursorTop);
                        Console.WriteLine(info3);
                    }
                    int bookNumber = 0;

                    foreach(Book book in loggedUser.Books)
                    {
                        bookNumber++;
                        MenuManager.BookListDrawer(book, bookNumber, true);
                    }

                    Console.ResetColor();
                }
            }
        }

        public static double bookPageCounter = 0;

        public static void ViewAllBooksList(int i)
        {
            i = i * 4;

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            double bookCount = _books.Count;
            int limit = 0;

            bookPageCounter = Math.Ceiling(bookCount / 4);

            if (bookCount - 4 < i)
            {
                if (bookCount % 4 == 0)
                {
                    limit = 4;
                }
                else if (bookCount % 4 == 1)
                {
                    limit = 1;
                }
                else if (bookCount % 4 == 2)
                {
                    limit = 2;
                }
                else if (bookCount % 4 == 3)
                {
                    limit = 3;
                }
            }
            else
            {
                limit = 4;
            }

            if (bookCount > 0)
            {
                for (int j = 0; j < limit; j++)
                {
                    if(_books[i].IsLended)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                    }

                    MenuManager.BookListDrawer(_books[i], i + 1, _books[i].IsLended);
                    i++;
                }

                if (limit == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                }
                else if (limit == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                }
                else if (limit == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = ConsoleColor.Blue;

                string info4 = "╔═══════╗";
                string info5 = "<-║ Dalej ║->";
                string info6 = "╚═══════╝";

                Console.WriteLine();
                Console.SetCursorPosition((Console.WindowWidth - info4.Length) / 2, Console.CursorTop);
                Console.WriteLine(info4);
                Console.SetCursorPosition((Console.WindowWidth - info5.Length) / 2, Console.CursorTop);
                Console.WriteLine(info5);
                Console.SetCursorPosition((Console.WindowWidth - info6.Length) / 2, Console.CursorTop);
                Console.WriteLine(info6);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.DarkBlue;

                string info1 = "╔══════════════════════════════════╗";
                string info2 = "║ AKTUALNIE BRAK KSIĄŻEK NA LIŚCIE ║";
                string info3 = "╚══════════════════════════════════╝";

                Console.WriteLine();
                Console.SetCursorPosition((Console.WindowWidth - info1.Length) / 2, Console.CursorTop);
                Console.WriteLine(info1);
                Console.SetCursorPosition((Console.WindowWidth - info2.Length) / 2, Console.CursorTop);
                Console.WriteLine(info2);
                Console.SetCursorPosition((Console.WindowWidth - info3.Length) / 2, Console.CursorTop);
                Console.WriteLine(info3);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = ConsoleColor.Blue;

                string info4 = "╔════════╗";
                string info5 = "║ POWRÓT ║";
                string info6 = "╚════════╝";

                Console.WriteLine();
                Console.SetCursorPosition((Console.WindowWidth - info4.Length) / 2, Console.CursorTop);
                Console.WriteLine(info4);
                Console.SetCursorPosition((Console.WindowWidth - info5.Length) / 2, Console.CursorTop);
                Console.WriteLine(info5);
                Console.SetCursorPosition((Console.WindowWidth - info6.Length) / 2, Console.CursorTop);
                Console.WriteLine(info6);

                do
                {
                    Program.keyInfo = Console.ReadKey(true);
                } while (Program.keyInfo.Key != ConsoleKey.Enter);
            }
        }

        public static void LendingBookChecker(int bookNumber)
        {
            User loggedUser = new User();

            foreach (User user in _users)
            {
                if (user.Id == userID)
                {
                    loggedUser = user;
                }
            }

            try
            {
                if (!_books[bookNumber].IsLended && loggedUser.Books.Count < 4)
                {
                    _books[bookNumber].IsLended = true;
                    _books[bookNumber].Date = DateTime.Now.AddDays(30).ToShortDateString();
                    loggedUser.Books.Add(_books[bookNumber]);

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.DarkBlue;

                    string info1 = "╔════════════════════════════════════════════════╗";
                    string info2 = "║ KSIĄŻKA ZOSTAŁA DODANA DO LISTY WYPOŻYCZONYCH! ║";
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
                }
                else if (!_books[bookNumber].IsLended && loggedUser.Books.Count >= 4)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.DarkBlue;

                    string info1 = "╔═══════════════════════════════════════╗";
                    string info2 = "║ NIE MOŻESZ WYPOŻYCZYĆ WIĘCEJ KSIĄŻEK! ║";
                    string info3 = "╚═══════════════════════════════════════╝";

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.SetCursorPosition((Console.WindowWidth - info1.Length) / 2, Console.CursorTop);
                    Console.WriteLine(info1);
                    Console.SetCursorPosition((Console.WindowWidth - info2.Length) / 2, Console.CursorTop);
                    Console.WriteLine(info2);
                    Console.SetCursorPosition((Console.WindowWidth - info3.Length) / 2, Console.CursorTop);
                    Console.WriteLine(info3);
                }
                else
                {
                    string info1 = "╔═════════════════════════════════════╗";
                    string info2 = "║ KSIĄŻKA JEST AKTUALNIE NIEDOSTĘPNA! ║";
                    string info3 = "╚═════════════════════════════════════╝";

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.SetCursorPosition((Console.WindowWidth - info1.Length) / 2, Console.CursorTop);
                    Console.WriteLine(info1);
                    Console.SetCursorPosition((Console.WindowWidth - info2.Length) / 2, Console.CursorTop);
                    Console.WriteLine(info2);
                    Console.SetCursorPosition((Console.WindowWidth - info3.Length) / 2, Console.CursorTop);
                    Console.WriteLine(info3);
                }
            }
            catch(Exception)
            {
                _books[bookNumber].IsLended = false;

                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.DarkBlue;

                string info1 = "╔══════════════════════════════════════════╗";
                string info2 = "║ BRAK KSIĄŻKI Z PODANYM NUMEREM NA LIŚCIE ║";
                string info3 = "╚══════════════════════════════════════════╝";

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.SetCursorPosition((Console.WindowWidth - info1.Length) / 2, Console.CursorTop);
                Console.WriteLine(info1);
                Console.SetCursorPosition((Console.WindowWidth - info2.Length) / 2, Console.CursorTop);
                Console.WriteLine(info2);
                Console.SetCursorPosition((Console.WindowWidth - info3.Length) / 2, Console.CursorTop);
                Console.WriteLine(info3);

                Console.ReadKey();
            }
        }

        public static User LoggedUserChecker()
        {
            User loggedUser = new User();

            foreach (User user in _users)
            {
                if (user.Id == userID)
                {
                    loggedUser = user;
                }
            }

            return loggedUser;
        }
    }
}
