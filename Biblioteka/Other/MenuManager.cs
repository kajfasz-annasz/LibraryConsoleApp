using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteka.Database;
using Biblioteka.Model;

namespace Biblioteka.Other
{
    class MenuManager
    {
        public static ConsoleKeyInfo keyInfo;

        public static int mainMenuChoice = 1;
        public static int InformationChoice = 1;

        public static int userMainMenuChoice = 1;

        public static int lendingButtonHover = 1;

        public static int fixPanelPosition;

        public static int optionsLength;
        public static int option1Position;
        public static int option2Position;
        public static int option3Position;
        public static int infLength;
        public static int inf1Length;
        public static int inf2Length;
        public static int loginPosition;

        public static int lendingHoverPosition1;
        public static int lendingHoverPosition2;

        public static int userMainMenuOption1Position;
        public static int userMainMenuOption2Position;
        public static int userMainMenuOption3Position;
        public static int userMainMenuOption4Position;

        public static int accesCounter = 0;

        public static void MainLogo()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            string logo1 = "╔══════════════════════════════════════════════════════════════════════════╗";
            string logo2 = "║ ██████╗ ██╗██████╗ ██╗     ██╗ ██████╗ ████████╗███████╗██╗  ██╗ █████╗  ║";
            string logo3 = "║ ██╔══██╗██║██╔══██╗██║     ██║██╔═══██╗╚══██╔══╝██╔════╝██║ ██╔╝██╔══██╗ ║";
            string logo4 = "║ ██████╔╝██║██████╔╝██║     ██║██║   ██║   ██║   █████╗  █████╔╝ ███████║ ║";
            string logo5 = "║ ██╔══██╗██║██╔══██╗██║     ██║██║   ██║   ██║   ██╔══╝  ██╔═██╗ ██╔══██║ ║";
            string logo6 = "║ ██████╔╝██║██████╔╝███████╗██║╚██████╔╝   ██║   ███████╗██║  ██╗██║  ██║ ║";
            string logo7 = "╚══════════════════════════════════════════════════════════════════════════╝";

            Console.WriteLine("");
            Console.SetCursorPosition((Console.WindowWidth - logo1.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo1);
            Console.SetCursorPosition((Console.WindowWidth - logo2.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo2);
            Console.SetCursorPosition((Console.WindowWidth - logo3.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo3);
            Console.SetCursorPosition((Console.WindowWidth - logo4.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo4);
            Console.SetCursorPosition((Console.WindowWidth - logo5.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo5);
            Console.SetCursorPosition((Console.WindowWidth - logo6.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo6);
            Console.SetCursorPosition((Console.WindowWidth - logo7.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo7);
        }

        public static void MainScreenOptions()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            string options1 = "╔═══════════════════════════╗";
            string options2 = "║ WYBIERZ CO CHCESZ ZROBIĆ: ║";
            string options3 = "╚═══════════════════════════╝";

            Console.WriteLine("");
            Console.SetCursorPosition((Console.WindowWidth - options1.Length) / 2, Console.CursorTop);
            Console.WriteLine(options1);
            Console.SetCursorPosition((Console.WindowWidth - options2.Length) / 2, Console.CursorTop);
            Console.WriteLine(options2);
            Console.SetCursorPosition((Console.WindowWidth - options3.Length) / 2, Console.CursorTop);
            Console.WriteLine(options3);
            Console.WriteLine("");

            string space = "  ";

            string options4 = "╔═════════╗"; string options7 = "╔════════════╗"; string options11 = "╔═══════╗";
            string options5 = "║ ZALOGUJ ║"; string options8 = "║ INFORMACJE ║"; string options12 = "║ WYJDŹ ║";
            string options6 = "╚═════════╝"; string options9 = "╚════════════╝"; string options13 = "╚═══════╝";

            optionsLength = (Console.WindowWidth - (options4.Length + options7.Length + options11.Length + space.Length * 2)) / 2;

            option1Position = optionsLength;
            option2Position = option1Position + options4.Length + space.Length;
            option3Position = option2Position + options7.Length + space.Length;

            Console.SetCursorPosition((Console.WindowWidth - (options4.Length + options7.Length + options11.Length + space.Length * 2)) / 2, Console.CursorTop);
            Console.Write(options4);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(space);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(options7);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(space);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(options11);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine();
            Console.SetCursorPosition((Console.WindowWidth - (options5.Length + options8.Length + options12.Length + space.Length * 2)) / 2, Console.CursorTop);
            Console.Write(options5);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(space);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(options8);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(space);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(options12);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine();
            Console.SetCursorPosition((Console.WindowWidth - (options6.Length + options9.Length + options13.Length + space.Length * 2)) / 2, Console.CursorTop);
            Console.Write(options6);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(space);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(options9);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(space);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(options13);
            Console.ResetColor();
        }

        public static void InformationLogo()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            string inf1 = "╔═══════════════════════════════════════════════════════════════════════════════════╗";
            string inf2 = "║ ██╗███╗   ██╗███████╗ ██████╗ ██████╗ ███╗   ███╗ █████╗  ██████╗     ██╗███████╗ ║";
            string inf3 = "║ ██║████╗  ██║██╔════╝██╔═══██╗██╔══██╗████╗ ████║██╔══██╗██╔════╝     ██║██╔════╝ ║";
            string inf4 = "║ ██║██╔██╗ ██║█████╗  ██║   ██║██████╔╝██╔████╔██║███████║██║          ██║█████╗   ║";
            string inf5 = "║ ██║██║╚██╗██║██╔══╝  ██║   ██║██╔══██╗██║╚██╔╝██║██╔══██║██║     ██   ██║██╔══╝   ║";
            string inf6 = "║ ██║██║ ╚████║██║     ╚██████╔╝██║  ██║██║ ╚═╝ ██║██║  ██║╚██████╗╚█████╔╝███████╗ ║";
            string inf7 = "╚═══════════════════════════════════════════════════════════════════════════════════╝";

            Console.WriteLine("");
            Console.SetCursorPosition((Console.WindowWidth - inf1.Length) / 2, Console.CursorTop);
            Console.WriteLine(inf1);
            Console.SetCursorPosition((Console.WindowWidth - inf2.Length) / 2, Console.CursorTop);
            Console.WriteLine(inf2);
            Console.SetCursorPosition((Console.WindowWidth - inf3.Length) / 2, Console.CursorTop);
            Console.WriteLine(inf3);
            Console.SetCursorPosition((Console.WindowWidth - inf4.Length) / 2, Console.CursorTop);
            Console.WriteLine(inf4);
            Console.SetCursorPosition((Console.WindowWidth - inf5.Length) / 2, Console.CursorTop);
            Console.WriteLine(inf5);
            Console.SetCursorPosition((Console.WindowWidth - inf6.Length) / 2, Console.CursorTop);
            Console.WriteLine(inf6);
            Console.SetCursorPosition((Console.WindowWidth - inf7.Length) / 2, Console.CursorTop);
            Console.WriteLine(inf7);
        }

        public static void InformationText()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            string text1 = "╔═══════════════════════════════════════════════════════════════════════════════════╗";
            string text2 = "║ Witam! Oprogramowanie zostało stworzone na potrzeby projektu KOLOR UG. Służy ono  ║";
            string text3 = "║ do zarządzania biblioteką wcielając się w bibliotekarza, jak i użytkowania jej    ║";
            string text4 = "║ jako użytkownik - czytelnik. Wybór opcji jest dokonywany poprzez 'aktywowanie'    ║";
            string text5 = "║ konkretnego przycisku za pomocą strzałek. Zapraszam do zapoznania się z zasobami  ║";
            string text6 = "║ oraz dostępnymi opcjami.                                                          ║";
            string text7 = "║                                                           Autor: Krzysztof Mazepa ║";
            string text8 = "╚═══════════════════════════════════════════════════════════════════════════════════╝";

            Console.WriteLine("");
            Console.SetCursorPosition((Console.WindowWidth - text1.Length) / 2, Console.CursorTop);
            Console.WriteLine(text1);
            Console.SetCursorPosition((Console.WindowWidth - text2.Length) / 2, Console.CursorTop);
            Console.WriteLine(text2);
            Console.SetCursorPosition((Console.WindowWidth - text3.Length) / 2, Console.CursorTop);
            Console.WriteLine(text3);
            Console.SetCursorPosition((Console.WindowWidth - text4.Length) / 2, Console.CursorTop);
            Console.WriteLine(text4);
            Console.SetCursorPosition((Console.WindowWidth - text5.Length) / 2, Console.CursorTop);
            Console.WriteLine(text5);
            Console.SetCursorPosition((Console.WindowWidth - text6.Length) / 2, Console.CursorTop);
            Console.WriteLine(text6);
            Console.SetCursorPosition((Console.WindowWidth - text7.Length) / 2, Console.CursorTop);
            Console.WriteLine(text7);
            Console.SetCursorPosition((Console.WindowWidth - text7.Length) / 2, Console.CursorTop);
            Console.WriteLine(text8);

            string space = "  ";

            string back1 = "╔════════╗"; string exit1 = "╔═══════╗";
            string back2 = "║ POWRÓT ║"; string exit2 = "║ WYJDŹ ║";
            string back3 = "╚════════╝"; string exit3 = "╚═══════╝";

            Console.WriteLine();
            Console.SetCursorPosition((Console.WindowWidth - (back1.Length + exit1.Length + space.Length * 2)) / 2, Console.CursorTop);
            Console.Write(back1);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(space);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(exit1);
            Console.WriteLine();
            Console.SetCursorPosition((Console.WindowWidth - (back1.Length + exit1.Length + space.Length * 2)) / 2, Console.CursorTop);
            Console.Write(back2);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(space);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(exit2);
            Console.WriteLine();
            Console.SetCursorPosition((Console.WindowWidth - (back1.Length + exit1.Length + space.Length * 2)) / 2, Console.CursorTop);
            Console.Write(back3);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(space);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(exit3);

            infLength = (Console.WindowWidth - (back1.Length + exit1.Length + space.Length * 2)) / 2;
            inf1Length = infLength;
            inf2Length = inf1Length + back1.Length + space.Length;
        }

        public static void LoginLogo()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            string log1 = "╔═════════════════════════════════════════════════════════════╗";
            string log2 = "║ ███████╗ █████╗ ██╗      ██████╗  ██████╗ ██╗   ██╗     ██╗ ║";
            string log3 = "║ ╚══███╔╝██╔══██╗██║     ██╔═══██╗██╔════╝ ██║   ██║     ██║ ║";
            string log4 = "║   ███╔╝ ███████║██║     ██║   ██║██║  ███╗██║   ██║     ██║ ║";
            string log5 = "║  ███╔╝  ██╔══██║██║     ██║   ██║██║   ██║██║   ██║██   ██║ ║";
            string log6 = "║ ███████╗██║  ██║███████╗╚██████╔╝╚██████╔╝╚██████╔╝╚█████╔╝ ║";
            string log7 = "╚═════════════════════════════════════════════════════════════╝";

            Console.WriteLine("");
            Console.SetCursorPosition((Console.WindowWidth - log1.Length) / 2, Console.CursorTop);
            Console.WriteLine(log1);
            Console.SetCursorPosition((Console.WindowWidth - log2.Length) / 2, Console.CursorTop);
            Console.WriteLine(log2);
            Console.SetCursorPosition((Console.WindowWidth - log3.Length) / 2, Console.CursorTop);
            Console.WriteLine(log3);
            Console.SetCursorPosition((Console.WindowWidth - log4.Length) / 2, Console.CursorTop);
            Console.WriteLine(log4);
            Console.SetCursorPosition((Console.WindowWidth - log5.Length) / 2, Console.CursorTop);
            Console.WriteLine(log5);
            Console.SetCursorPosition((Console.WindowWidth - log6.Length) / 2, Console.CursorTop);
            Console.WriteLine(log6);
            Console.SetCursorPosition((Console.WindowWidth - log7.Length) / 2, Console.CursorTop);
            Console.WriteLine(log7);
        }

        public static void LoginOptions()
        {

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            string opt1 = "╔═══════════════════════════════════════╗";
            string opt2 = "║ WPISZ LOGIN I HASŁO ABY SIĘ ZALOGOWAĆ ║";
            string opt3 = "╚═══════════════════════════════════════╝";

            Console.WriteLine("");
            Console.SetCursorPosition((Console.WindowWidth - opt1.Length) / 2, Console.CursorTop);
            Console.WriteLine(opt1);
            Console.SetCursorPosition((Console.WindowWidth - opt2.Length) / 2, Console.CursorTop);
            Console.WriteLine(opt2);
            Console.SetCursorPosition((Console.WindowWidth - opt3.Length) / 2, Console.CursorTop);
            Console.WriteLine(opt3);

            string menu1 = "╔═══════════════════════════════════════╗";
            string menu2 = "║ LOGIN:                                ║";
            string menu3 = "║ HASŁO:                                ║";
            string menu4 = "╚═══════════════════════════════════════╝";

            Console.WriteLine("");
            Console.SetCursorPosition((Console.WindowWidth - menu1.Length) / 2, Console.CursorTop);
            Console.WriteLine(menu1);
            Console.SetCursorPosition((Console.WindowWidth - menu2.Length) / 2, Console.CursorTop);
            Console.WriteLine(menu2);
            Console.SetCursorPosition((Console.WindowWidth - menu3.Length) / 2, Console.CursorTop);
            Console.WriteLine(menu3);
            Console.SetCursorPosition((Console.WindowWidth - menu4.Length) / 2, Console.CursorTop);
            Console.WriteLine(menu4);

            loginPosition = (Console.WindowWidth - menu1.Length) / 2 + 9;
        }
        
        public static void LoginFailed()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            string opt1 = "╔════════════════════════════════════════╗";
            string opt2 = "║ DANE NIEPRAWIDŁOWE - PRÓBA NR: " + accesCounter + "/3     ║";
            string opt3 = "╚════════════════════════════════════════╝";

            Console.SetCursorPosition((Console.WindowWidth - opt1.Length) / 2, Console.CursorTop + 3);
            Console.WriteLine(opt1);
            Console.SetCursorPosition((Console.WindowWidth - opt2.Length) / 2, Console.CursorTop);
            Console.WriteLine(opt2);
            Console.SetCursorPosition((Console.WindowWidth - opt3.Length) / 2, Console.CursorTop);
            Console.WriteLine(opt3);

            Console.SetCursorPosition(loginPosition, 14);
            Console.WriteLine("                    ");
            Console.SetCursorPosition(loginPosition, 15);
            Console.WriteLine("                    ");
        }

        public static void AccesDisabled()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            string opt1 = "╔═════════════════════════════════════════════╗";
            string opt2 = "║ PRZEKROCZONO LIMIT POMYŁEK - ODMOWA DOSTĘPU!║";
            string opt3 = "╚═════════════════════════════════════════════╝";

            Console.SetCursorPosition((Console.WindowWidth - opt1.Length) / 2, Console.CursorTop + 2);
            Console.WriteLine(opt1);
            Console.SetCursorPosition((Console.WindowWidth - opt2.Length) / 2, Console.CursorTop);
            Console.WriteLine(opt2);
            Console.SetCursorPosition((Console.WindowWidth - opt3.Length) / 2, Console.CursorTop);
            Console.WriteLine(opt3);

            Console.SetCursorPosition(loginPosition, 14);
            Console.WriteLine("                    ");
            Console.SetCursorPosition(loginPosition, 15);
            Console.WriteLine("                    ");
        }

        public static void UserLogo()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            string logo1 = "╔═════════════════════════════════════════════════════════════════════════╗";
            string logo2 = "║  ██████╗███████╗██╗   ██╗████████╗███████╗██╗     ███╗   ██╗██╗██╗  ██╗ ║";
            string logo3 = "║ ██╔════╝╚══███╔╝╚██╗ ██╔╝╚══██╔══╝██╔════╝██║     ████╗  ██║██║██║ ██╔╝ ║";
            string logo4 = "║ ██║       ███╔╝  ╚████╔╝    ██║   █████╗  ██║     ██╔██╗ ██║██║█████╔╝  ║";
            string logo5 = "║ ██║      ███╔╝    ╚██╔╝     ██║   ██╔══╝  ██║     ██║╚██╗██║██║██╔═██╗  ║";
            string logo6 = "║ ╚██████╗███████╗   ██║      ██║   ███████╗███████╗██║ ╚████║██║██║  ██╗ ║";
            string logo7 = "╚═════════════════════════════════════════════════════════════════════════╝";

            Console.WriteLine("");
            Console.SetCursorPosition((Console.WindowWidth - logo1.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo1);
            Console.SetCursorPosition((Console.WindowWidth - logo2.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo2);
            Console.SetCursorPosition((Console.WindowWidth - logo3.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo3);
            Console.SetCursorPosition((Console.WindowWidth - logo4.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo4);
            Console.SetCursorPosition((Console.WindowWidth - logo5.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo5);
            Console.SetCursorPosition((Console.WindowWidth - logo6.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo6);
            Console.SetCursorPosition((Console.WindowWidth - logo7.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo7);
        }

        public static void UserHello()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            string info1 = "╔════════════════════════════╗";
            string info3 = "║ Witaj,                     ║";
            string info4 = "║ WYBIERZ, CO CHCESZ ZROBIĆ: ║";
            string info5 = "╚════════════════════════════╝";

            Console.WriteLine();
            Console.SetCursorPosition((Console.WindowWidth - info1.Length) / 2, Console.CursorTop);
            Console.WriteLine(info1);
            Console.SetCursorPosition((Console.WindowWidth - info3.Length) / 2, Console.CursorTop);
            Console.WriteLine(info3);
            Console.SetCursorPosition((Console.WindowWidth - info4.Length) / 2, Console.CursorTop);
            Console.WriteLine(info4);
            Console.SetCursorPosition((Console.WindowWidth - info4.Length) / 2, Console.CursorTop);
            Console.WriteLine(info5);
            Console.WriteLine();

            Console.SetCursorPosition(((Console.WindowWidth - info1.Length) / 2) + 9, 10);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Mock.userName);
        }

        public static void UserOptions()
        { 
            string button11 = "╔═════════════════════╗"; string button21 = "╔════════════════════╗"; string button31 = "╔═══════════════╗"; string button41 = "╔═════════╗";
            string button12 = "║ KSIĄŻKI WYPOŻYCZONE ║"; string button22 = "║ DODAJ WYPOŻYCZENIE ║"; string button32 = "║ ODDAJ KSIĄŻKĘ ║"; string button42 = "║ WYLOGUJ ║";
            string button13 = "╚═════════════════════╝"; string button23 = "╚════════════════════╝"; string button33 = "╚═══════════════╝"; string button43 = "╚═════════╝";

            string space = "  ";

            Console.ForegroundColor = ConsoleColor.White;

            userMainMenuOption1Position = (Console.WindowWidth - (button11.Length + button21.Length + button31.Length + button41.Length + space.Length * 3)) / 2;
            userMainMenuOption2Position = userMainMenuOption1Position + button11.Length + space.Length;
            userMainMenuOption3Position = userMainMenuOption2Position + button21.Length + space.Length;
            userMainMenuOption4Position = userMainMenuOption3Position + button31.Length + space.Length;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.SetCursorPosition((Console.WindowWidth - (button11.Length + button21.Length + button31.Length + button41.Length + space.Length*3)) / 2, Console.CursorTop);
            Console.Write(button11);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(space);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(button21);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(space);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(button31);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(space);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(button41);
            Console.WriteLine();
            Console.SetCursorPosition((Console.WindowWidth - (button11.Length + button21.Length + button31.Length + button41.Length + space.Length * 3)) / 2, Console.CursorTop);
            Console.Write(button12);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(space);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(button22);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(space);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(button32);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(space);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(button42);
            Console.WriteLine();
            Console.SetCursorPosition((Console.WindowWidth - (button11.Length + button21.Length + button31.Length + button41.Length + space.Length * 3)) / 2, Console.CursorTop);
            Console.Write(button13);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(space);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(button23);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(space);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(button33);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(space);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(button43);
            Console.WriteLine();
        }

        public static void userMainMenuChoiceHover()
        {

            if (userMainMenuChoice == 1)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.SetCursorPosition(userMainMenuOption1Position, 14);
                Console.Write("╔═════════════════════╗");
                Console.SetCursorPosition(userMainMenuOption1Position, 15);
                Console.Write("║ KSIĄŻKI WYPOŻYCZONE ║");
                Console.SetCursorPosition(userMainMenuOption1Position, 16);
                Console.Write("╚═════════════════════╝");

                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;

                Console.SetCursorPosition(userMainMenuOption2Position, 14);
                Console.Write("╔════════════════════╗");
                Console.SetCursorPosition(userMainMenuOption2Position, 15);
                Console.Write("║ DODAJ WYPOŻYCZENIE ║");
                Console.SetCursorPosition(userMainMenuOption2Position, 16);
                Console.Write("╚════════════════════╝");

                Console.SetCursorPosition(userMainMenuOption3Position, 14);
                Console.Write("╔═══════════════╗");
                Console.SetCursorPosition(userMainMenuOption3Position, 15);
                Console.Write("║ ODDAJ KSIĄŻKĘ ║");
                Console.SetCursorPosition(userMainMenuOption3Position, 16);
                Console.Write("╚═══════════════╝");

                Console.SetCursorPosition(userMainMenuOption4Position, 14);
                Console.Write("╔═════════╗");
                Console.SetCursorPosition(userMainMenuOption4Position, 15);
                Console.Write("║ WYLOGUJ ║");
                Console.SetCursorPosition(userMainMenuOption4Position, 16);
                Console.Write("╚═════════╝");

                Console.ResetColor();
            }
            else if (userMainMenuChoice == 2)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;

                Console.SetCursorPosition(userMainMenuOption1Position, 14);
                Console.Write("╔═════════════════════╗");
                Console.SetCursorPosition(userMainMenuOption1Position, 15);
                Console.Write("║ KSIĄŻKI WYPOŻYCZONE ║");
                Console.SetCursorPosition(userMainMenuOption1Position, 16);
                Console.Write("╚═════════════════════╝");

                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.SetCursorPosition(userMainMenuOption2Position, 14);
                Console.Write("╔════════════════════╗");
                Console.SetCursorPosition(userMainMenuOption2Position, 15);
                Console.Write("║ DODAJ WYPOŻYCZENIE ║");
                Console.SetCursorPosition(userMainMenuOption2Position, 16);
                Console.Write("╚════════════════════╝");

                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;

                Console.SetCursorPosition(userMainMenuOption3Position, 14);
                Console.Write("╔═══════════════╗");
                Console.SetCursorPosition(userMainMenuOption3Position, 15);
                Console.Write("║ ODDAJ KSIĄŻKĘ ║");
                Console.SetCursorPosition(userMainMenuOption3Position, 16);
                Console.Write("╚═══════════════╝");

                Console.SetCursorPosition(userMainMenuOption4Position, 14);
                Console.Write("╔═════════╗");
                Console.SetCursorPosition(userMainMenuOption4Position, 15);
                Console.Write("║ WYLOGUJ ║");
                Console.SetCursorPosition(userMainMenuOption4Position, 16);
                Console.Write("╚═════════╝");

                Console.ResetColor();
            }
            else if (userMainMenuChoice == 3)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;

                Console.SetCursorPosition(userMainMenuOption1Position, 14);
                Console.Write("╔═════════════════════╗");
                Console.SetCursorPosition(userMainMenuOption1Position, 15);
                Console.Write("║ KSIĄŻKI WYPOŻYCZONE ║");
                Console.SetCursorPosition(userMainMenuOption1Position, 16);
                Console.Write("╚═════════════════════╝");

                Console.SetCursorPosition(userMainMenuOption2Position, 14);
                Console.Write("╔════════════════════╗");
                Console.SetCursorPosition(userMainMenuOption2Position, 15);
                Console.Write("║ DODAJ WYPOŻYCZENIE ║");
                Console.SetCursorPosition(userMainMenuOption2Position, 16);
                Console.Write("╚════════════════════╝");

                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.SetCursorPosition(userMainMenuOption3Position, 14);
                Console.Write("╔═══════════════╗");
                Console.SetCursorPosition(userMainMenuOption3Position, 15);
                Console.Write("║ ODDAJ KSIĄŻKĘ ║");
                Console.SetCursorPosition(userMainMenuOption3Position, 16);
                Console.Write("╚═══════════════╝");

                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;

                Console.SetCursorPosition(userMainMenuOption4Position, 14);
                Console.Write("╔═════════╗");
                Console.SetCursorPosition(userMainMenuOption4Position, 15);
                Console.Write("║ WYLOGUJ ║");
                Console.SetCursorPosition(userMainMenuOption4Position, 16);
                Console.Write("╚═════════╝");

                Console.ResetColor();
            }

            else if (userMainMenuChoice == 4)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;

                Console.SetCursorPosition(userMainMenuOption1Position, 14);
                Console.Write("╔═════════════════════╗");
                Console.SetCursorPosition(userMainMenuOption1Position, 15);
                Console.Write("║ KSIĄŻKI WYPOŻYCZONE ║");
                Console.SetCursorPosition(userMainMenuOption1Position, 16);
                Console.Write("╚═════════════════════╝");

                Console.SetCursorPosition(userMainMenuOption2Position, 14);
                Console.Write("╔════════════════════╗");
                Console.SetCursorPosition(userMainMenuOption2Position, 15);
                Console.Write("║ DODAJ WYPOŻYCZENIE ║");
                Console.SetCursorPosition(userMainMenuOption2Position, 16);
                Console.Write("╚════════════════════╝");

                Console.SetCursorPosition(userMainMenuOption3Position, 14);
                Console.Write("╔═══════════════╗");
                Console.SetCursorPosition(userMainMenuOption3Position, 15);
                Console.Write("║ ODDAJ KSIĄŻKĘ ║");
                Console.SetCursorPosition(userMainMenuOption3Position, 16);
                Console.Write("╚═══════════════╝");

                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.SetCursorPosition(userMainMenuOption4Position, 14);
                Console.Write("╔═════════╗");
                Console.SetCursorPosition(userMainMenuOption4Position, 15);
                Console.Write("║ WYLOGUJ ║");
                Console.SetCursorPosition(userMainMenuOption4Position, 16);
                Console.Write("╚═════════╝");

                Console.ResetColor();
            }
        }

        public static void UserBookListLogo()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            string logo1 = "╔══════════════════════════════════════════════════════════════════════════════════════════════════╗";
            string logo2 = "║ ██╗    ██╗██╗   ██╗██████╗  ██████╗ ███████╗██╗   ██╗ ██████╗███████╗ ██████╗ ███╗   ██╗███████╗ ║";
            string logo3 = "║ ██║    ██║╚██╗ ██╔╝██╔══██╗██╔═══██╗╚══███╔╝╚██╗ ██╔╝██╔════╝╚══███╔╝██╔═══██╗████╗  ██║██╔════╝ ║";
            string logo4 = "║ ██║ █╗ ██║ ╚████╔╝ ██████╔╝██║   ██║  ███╔╝  ╚████╔╝ ██║       ███╔╝ ██║   ██║██╔██╗ ██║█████╗   ║";
            string logo5 = "║ ██║███╗██║  ╚██╔╝  ██╔═══╝ ██║   ██║ ███╔╝    ╚██╔╝  ██║      ███╔╝  ██║   ██║██║╚██╗██║██╔══╝   ║";
            string logo6 = "║ ╚███╔███╔╝   ██║   ██║     ╚██████╔╝███████╗   ██║   ╚██████╗███████╗╚██████╔╝██║ ╚████║███████╗ ║";
            string logo7 = "╚══════════════════════════════════════════════════════════════════════════════════════════════════╝";

            Console.WriteLine("");
            Console.SetCursorPosition((Console.WindowWidth - logo1.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo1);
            Console.SetCursorPosition((Console.WindowWidth - logo2.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo2);
            Console.SetCursorPosition((Console.WindowWidth - logo3.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo3);
            Console.SetCursorPosition((Console.WindowWidth - logo4.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo4);
            Console.SetCursorPosition((Console.WindowWidth - logo5.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo5);
            Console.SetCursorPosition((Console.WindowWidth - logo6.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo6);
            Console.SetCursorPosition((Console.WindowWidth - logo7.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo7);
        }

        public static void MainMenuOptionsHover()
        {
            if (MenuManager.mainMenuChoice == 1)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.SetCursorPosition(MenuManager.option1Position, 13);
                Console.Write("╔═════════╗");
                Console.SetCursorPosition(MenuManager.option1Position, 14);
                Console.Write("║ ZALOGUJ ║");
                Console.SetCursorPosition(MenuManager.option1Position, 15);
                Console.Write("╚═════════╝");

                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;

                Console.SetCursorPosition(MenuManager.option2Position, 13);
                Console.Write("╔════════════╗");
                Console.SetCursorPosition(MenuManager.option2Position, 14);
                Console.Write("║ INFORMACJE ║");
                Console.SetCursorPosition(MenuManager.option2Position, 15);
                Console.Write("╚════════════╝");

                Console.SetCursorPosition(MenuManager.option3Position, 13);
                Console.Write("╔═══════╗");
                Console.SetCursorPosition(MenuManager.option3Position, 14);
                Console.Write("║ WYJDŹ ║");
                Console.SetCursorPosition(MenuManager.option3Position, 15);
                Console.Write("╚═══════╝");

                Console.ResetColor();
            }
            else if (MenuManager.mainMenuChoice == 2)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;

                Console.SetCursorPosition(MenuManager.option1Position, 13);
                Console.Write("╔═════════╗");
                Console.SetCursorPosition(MenuManager.option1Position, 14);
                Console.Write("║ ZALOGUJ ║");
                Console.SetCursorPosition(MenuManager.option1Position, 15);
                Console.Write("╚═════════╝");

                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.SetCursorPosition(MenuManager.option2Position, 13);
                Console.Write("╔════════════╗");
                Console.SetCursorPosition(MenuManager.option2Position, 14);
                Console.Write("║ INFORMACJE ║");
                Console.SetCursorPosition(MenuManager.option2Position, 15);
                Console.Write("╚════════════╝");

                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;

                Console.SetCursorPosition(MenuManager.option3Position, 13);
                Console.Write("╔═══════╗");
                Console.SetCursorPosition(MenuManager.option3Position, 14);
                Console.Write("║ WYJDŹ ║");
                Console.SetCursorPosition(MenuManager.option3Position, 15);
                Console.Write("╚═══════╝");

                Console.ResetColor();
            }
            else if (MenuManager.mainMenuChoice == 3)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;

                Console.SetCursorPosition(MenuManager.option1Position, 13);
                Console.Write("╔═════════╗");
                Console.SetCursorPosition(MenuManager.option1Position, 14);
                Console.Write("║ ZALOGUJ ║");
                Console.SetCursorPosition(MenuManager.option1Position, 15);
                Console.Write("╚═════════╝");

                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;

                Console.SetCursorPosition(MenuManager.option2Position, 13);
                Console.Write("╔════════════╗");
                Console.SetCursorPosition(MenuManager.option2Position, 14);
                Console.Write("║ INFORMACJE ║");
                Console.SetCursorPosition(MenuManager.option2Position, 15);
                Console.Write("╚════════════╝");

                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.SetCursorPosition(MenuManager.option3Position, 13);
                Console.Write("╔═══════╗");
                Console.SetCursorPosition(MenuManager.option3Position, 14);
                Console.Write("║ WYJDŹ ║");
                Console.SetCursorPosition(MenuManager.option3Position, 15);
                Console.Write("╚═══════╝");

                Console.ResetColor();
            }
        }

        public static void mainMenuInformationHover()
        {
            if (MenuManager.InformationChoice == 1)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.SetCursorPosition(MenuManager.inf1Length, 18);
                Console.Write("╔════════╗");
                Console.SetCursorPosition(MenuManager.inf1Length, 19);
                Console.Write("║ POWRÓT ║");
                Console.SetCursorPosition(MenuManager.inf1Length, 20);
                Console.Write("╚════════╝");

                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;

                Console.SetCursorPosition(MenuManager.inf2Length, 18);
                Console.Write("╔═══════╗");
                Console.SetCursorPosition(MenuManager.inf2Length, 19);
                Console.Write("║ WYJDŹ ║");
                Console.SetCursorPosition(MenuManager.inf2Length, 20);
                Console.Write("╚═══════╝");

                Console.ResetColor();
            }
            else if (MenuManager.InformationChoice == 2)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;

                Console.SetCursorPosition(MenuManager.inf1Length, 18);
                Console.Write("╔════════╗");
                Console.SetCursorPosition(MenuManager.inf1Length, 19);
                Console.Write("║ POWRÓT ║");
                Console.SetCursorPosition(MenuManager.inf1Length, 20);
                Console.Write("╚════════╝");

                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.SetCursorPosition(MenuManager.inf2Length, 18);
                Console.Write("╔═══════╗");
                Console.SetCursorPosition(MenuManager.inf2Length, 19);
                Console.Write("║ WYJDŹ ║");
                Console.SetCursorPosition(MenuManager.inf2Length, 20);
                Console.Write("╚═══════╝");

                Console.ResetColor();
            }
        }

        public static void UserBackButton()
        {
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

            Console.ResetColor();
        }

        public static void BookListDrawer(Book book, int bookNumber, bool IsLended)
        {
            Console.WriteLine();
            Console.SetCursorPosition((Console.WindowWidth - (book.Title.Length + 5)) / 2, Console.CursorTop);
            Console.WriteLine(bookNumber+". "+'"' + book.Title + '"');
            if (IsLended)
            {
                Console.SetCursorPosition((Console.WindowWidth - (book.Publisher.Length + Convert.ToString(book.Year).Length + book.Author.Length + 3 + 10 + 16)) / 2, Console.CursorTop);
            }
            else
            {
                Console.SetCursorPosition((Console.WindowWidth - (book.Publisher.Length + Convert.ToString(book.Year).Length + book.Author.Length + 3)) / 2, Console.CursorTop);
            }
            Console.Write(book.Author);
            Console.Write(", ");
            Console.Write(book.Publisher);
            Console.Write(" ");
            Console.Write(book.Year);
            if (IsLended)
            {
                Console.Write("," + " Data Oddania: " + book.Date);
            }
            Console.WriteLine();
        }

        public static void LendingLogo()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            string logo1 = "╔═══════════════════════════════════════════════════════════════════════╗";
            string logo2 = "║ ██╗    ██╗██╗   ██╗██████╗  ██████╗ ███████╗██╗   ██╗ ██████╗███████╗ ║";
            string logo3 = "║ ██║    ██║╚██╗ ██╔╝██╔══██╗██╔═══██╗╚══███╔╝╚██╗ ██╔╝██╔════╝╚══███╔╝ ║";
            string logo4 = "║ ██║ █╗ ██║ ╚████╔╝ ██████╔╝██║   ██║  ███╔╝  ╚████╔╝ ██║       ███╔╝  ║";
            string logo5 = "║ ██║███╗██║  ╚██╔╝  ██╔═══╝ ██║   ██║ ███╔╝    ╚██╔╝  ██║      ███╔╝   ║";
            string logo6 = "║ ╚███╔███╔╝   ██║   ██║     ╚██████╔╝███████╗   ██║   ╚██████╗███████╗ ║";
            string logo7 = "╚═══════════════════════════════════════════════════════════════════════╝";

            Console.WriteLine("");
            Console.SetCursorPosition((Console.WindowWidth - logo1.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo1);
            Console.SetCursorPosition((Console.WindowWidth - logo2.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo2);
            Console.SetCursorPosition((Console.WindowWidth - logo3.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo3);
            Console.SetCursorPosition((Console.WindowWidth - logo4.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo4);
            Console.SetCursorPosition((Console.WindowWidth - logo5.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo5);
            Console.SetCursorPosition((Console.WindowWidth - logo6.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo6);
            Console.SetCursorPosition((Console.WindowWidth - logo7.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo7);
        }

        public static void LendingText()
        { 
            string info1 = "╔══════════════════════════════════════════════════╗";
            string info2 = "║ WYBIERZ, CO CHCESZ WYPOŻYCZYĆ (ZAPAMIĘTAJ NR):   ║";
            string info3 = "║ KOLOR ZIELONY: NA STANIE, CZERWONY: WYPOŻYCZONE: ║";
            string info4 = "╚══════════════════════════════════════════════════╝";

            Console.WriteLine();
            Console.SetCursorPosition((Console.WindowWidth - info1.Length) / 2, Console.CursorTop);
            Console.WriteLine(info1);
            Console.SetCursorPosition((Console.WindowWidth - info2.Length) / 2, Console.CursorTop);
            Console.WriteLine(info2);
            Console.SetCursorPosition((Console.WindowWidth - info3.Length) / 2, Console.CursorTop);
            Console.WriteLine(info3);
            Console.SetCursorPosition((Console.WindowWidth - info4.Length) / 2, Console.CursorTop);
            Console.WriteLine(info4);
            Console.WriteLine();

            Console.SetCursorPosition((Console.WindowWidth - info1.Length) / 2 + 8, 11);
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("ZIELONY:");

            Console.SetCursorPosition((Console.WindowWidth - info1.Length) / 2 + 28, 11);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("CZERWONY:");
            Console.WriteLine();

            Console.ResetColor();
        }

        public static void BookLendingOptions()
        {    
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;

            string space = "  ";

            string back1 = "╔══════════╗"; string exit1 = "╔════════╗";
            string back2 = "║ WYPOŻYCZ ║"; string exit2 = "║ POWRÓT ║";
            string back3 = "╚══════════╝"; string exit3 = "╚════════╝";

            lendingHoverPosition1 = (Console.WindowWidth - (back1.Length + exit1.Length + space.Length * 2)) / 2;
            lendingHoverPosition2 = lendingHoverPosition1 + 14;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.SetCursorPosition((Console.WindowWidth - (back1.Length + exit1.Length + space.Length * 2)) / 2, Console.CursorTop);
            Console.Write(back1);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(space);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(exit1);
            Console.WriteLine();
            Console.SetCursorPosition((Console.WindowWidth - (back1.Length + exit1.Length + space.Length * 2)) / 2, Console.CursorTop);
            Console.Write(back2);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(space);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(exit2);
            Console.WriteLine();
            Console.SetCursorPosition((Console.WindowWidth - (back1.Length + exit1.Length + space.Length * 2)) / 2, Console.CursorTop);
            Console.Write(back3);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(space);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(exit3);
        }

        public static void UserLendingOptionsHover()
        {
            if (MenuManager.lendingButtonHover == 1)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.SetCursorPosition(MenuManager.lendingHoverPosition1, 14);
                Console.Write("╔══════════╗");
                Console.SetCursorPosition(MenuManager.lendingHoverPosition1, 15);
                Console.Write("║ WYPOŻYCZ ║");
                Console.SetCursorPosition(MenuManager.lendingHoverPosition1, 16);
                Console.Write("╚══════════╝");

                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;

                Console.SetCursorPosition(MenuManager.lendingHoverPosition2, 14);
                Console.Write("╔════════╗");
                Console.SetCursorPosition(MenuManager.lendingHoverPosition2, 15);
                Console.Write("║ POWRÓT ║");
                Console.SetCursorPosition(MenuManager.lendingHoverPosition2, 16);
                Console.Write("╚════════╝");

                Console.ResetColor();
            }
            else if (MenuManager.lendingButtonHover == 2)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;

                Console.SetCursorPosition(MenuManager.lendingHoverPosition1, 14);
                Console.Write("╔══════════╗");
                Console.SetCursorPosition(MenuManager.lendingHoverPosition1, 15);
                Console.Write("║ WYPOŻYCZ ║");
                Console.SetCursorPosition(MenuManager.lendingHoverPosition1, 16);
                Console.Write("╚══════════╝");

                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.SetCursorPosition(MenuManager.lendingHoverPosition2, 14);
                Console.Write("╔════════╗");
                Console.SetCursorPosition(MenuManager.lendingHoverPosition2, 15);
                Console.Write("║ POWRÓT ║");
                Console.SetCursorPosition(MenuManager.lendingHoverPosition2, 16);
                Console.Write("╚════════╝"); ;

                Console.ResetColor();
            }        
        }

        public static void lendingChoiceDrawer()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;

            string info1 = "╔══════════════════════════════════════════════════╗";
            string info2 = "║ WPISZ NR KSIĄŻKI, KTÓRĄ CHCESZ WYPOŻYCZYĆ:       ║";
            string info3 = "╚══════════════════════════════════════════════════╝";

            Console.WriteLine();
            Console.WriteLine();
            Console.SetCursorPosition((Console.WindowWidth - info1.Length) / 2, Console.CursorTop);
            Console.WriteLine(info1);
            Console.SetCursorPosition((Console.WindowWidth - info2.Length) / 2, Console.CursorTop);
            Console.WriteLine(info2);
            Console.SetCursorPosition((Console.WindowWidth - info3.Length) / 2, Console.CursorTop);
            Console.WriteLine(info3);
            Console.WriteLine();

            fixPanelPosition = (Console.WindowWidth - info3.Length) / 2 + 45;

            Console.SetCursorPosition((Console.WindowWidth - info3.Length) / 2 + 45, 19);
        }

        public static void ReturnBookLogo()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            string logo1 = "╔═══════════════════════════════════════════╗";
            string logo2 = "║  ██████╗ ██████╗ ██████╗  █████╗      ██╗ ║";
            string logo3 = "║ ██╔═══██╗██╔══██╗██╔══██╗██╔══██╗     ██║ ║";
            string logo4 = "║ ██║   ██║██║  ██║██║  ██║███████║     ██║ ║";
            string logo5 = "║ ██║   ██║██║  ██║██║  ██║██╔══██║██   ██║ ║";
            string logo6 = "║ ╚██████╔╝██████╔╝██████╔╝██║  ██║╚█████╔╝ ║";
            string logo7 = "╚═══════════════════════════════════════════╝";

            Console.WriteLine("");
            Console.SetCursorPosition((Console.WindowWidth - logo1.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo1);
            Console.SetCursorPosition((Console.WindowWidth - logo2.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo2);
            Console.SetCursorPosition((Console.WindowWidth - logo3.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo3);
            Console.SetCursorPosition((Console.WindowWidth - logo4.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo4);
            Console.SetCursorPosition((Console.WindowWidth - logo5.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo5);
            Console.SetCursorPosition((Console.WindowWidth - logo6.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo6);
            Console.SetCursorPosition((Console.WindowWidth - logo7.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo7);

            string info1 = "╔══════════════════════════════════════╗";
            string info2 = "║ WYBIERZ, KTÓRĄ KSIĄŻKĘ CHCESZ ODDAĆ: ║";
            string info3 = "║ ZAPAMIĘTAJ JEJ NUMER NA LIŚCIE:      ║";
            string info4 = "╚══════════════════════════════════════╝";

            Console.WriteLine();
            Console.SetCursorPosition((Console.WindowWidth - info1.Length) / 2, Console.CursorTop);
            Console.WriteLine(info1);
            Console.SetCursorPosition((Console.WindowWidth - info2.Length) / 2, Console.CursorTop);
            Console.WriteLine(info2);
            Console.SetCursorPosition((Console.WindowWidth - info3.Length) / 2, Console.CursorTop);
            Console.WriteLine(info3);
            Console.SetCursorPosition((Console.WindowWidth - info4.Length) / 2, Console.CursorTop);
            Console.WriteLine(info4);
        }

        public static int ReturnBookHoverPosition1;
        public static int ReturnBookHoverPosition2;

        public static void ReturnBookOptions()
        {
            User myUser = new User();
            bool returnBookDecision = false;
            int returnBookDecisionCounter = 1;

            myUser = Mock.LoggedUserChecker();

            if (myUser.Books.Count != 0)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.DarkBlue;

                string space = "  ";

                string back1 = "╔════════╗"; string exit1 = "╔══════════╗";
                string back2 = "║ POWRÓT ║"; string exit2 = "║ ODDAJ:   ║";
                string back3 = "╚════════╝"; string exit3 = "╚══════════╝";

                Console.WriteLine();
                Console.SetCursorPosition((Console.WindowWidth - (back1.Length + exit1.Length + space.Length * 2)) / 2, 26);
                Console.Write(back1);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(space);
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.Write(exit1);
                Console.WriteLine();
                Console.SetCursorPosition((Console.WindowWidth - (back1.Length + exit1.Length + space.Length * 2)) / 2, 27);
                Console.Write(back2);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(space);
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.Write(exit2);
                Console.WriteLine();
                Console.SetCursorPosition((Console.WindowWidth - (back1.Length + exit1.Length + space.Length * 2)) / 2, 28);
                Console.Write(back3);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(space);
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.Write(exit3);

                ReturnBookHoverPosition1 = (Console.WindowWidth - (back1.Length + exit1.Length + space.Length * 2)) / 2;
                ReturnBookHoverPosition2 = ReturnBookHoverPosition1 + 12;

                do
                {
                    if (returnBookDecisionCounter == 1)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.Yellow;

                        Console.SetCursorPosition(ReturnBookHoverPosition1, 26);
                        Console.Write("╔════════╗");
                        Console.SetCursorPosition(ReturnBookHoverPosition1, 27);
                        Console.Write("║ POWRÓT ║");
                        Console.SetCursorPosition(ReturnBookHoverPosition1, 28);
                        Console.Write("╚════════╝");

                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.ForegroundColor = ConsoleColor.White;

                        Console.SetCursorPosition(ReturnBookHoverPosition2, 26);
                        Console.Write("╔══════════╗");
                        Console.SetCursorPosition(ReturnBookHoverPosition2, 27);
                        Console.Write("║ ODDAJ:   ║");
                        Console.SetCursorPosition(ReturnBookHoverPosition2, 28);
                        Console.Write("╚══════════╝");

                        Console.ResetColor();
                    }
                    else if (returnBookDecisionCounter == 2)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.ForegroundColor = ConsoleColor.White;

                        Console.SetCursorPosition(ReturnBookHoverPosition1, 26);
                        Console.Write("╔════════╗");
                        Console.SetCursorPosition(ReturnBookHoverPosition1, 27);
                        Console.Write("║ POWRÓT ║");
                        Console.SetCursorPosition(ReturnBookHoverPosition1, 28);
                        Console.Write("╚════════╝");

                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.Yellow;

                        Console.SetCursorPosition(ReturnBookHoverPosition2, 26);
                        Console.Write("╔══════════╗");
                        Console.SetCursorPosition(ReturnBookHoverPosition2, 27);
                        Console.Write("║ ODDAJ:   ║");
                        Console.SetCursorPosition(ReturnBookHoverPosition2, 28);
                        Console.Write("╚══════════╝");

                        Console.ResetColor();
                    }

                    keyInfo = Console.ReadKey(true);

                    if (keyInfo.Key == ConsoleKey.LeftArrow)
                    {
                        if (returnBookDecisionCounter == 2)
                        {
                            returnBookDecisionCounter--;
                        }
                        else
                        {
                            returnBookDecisionCounter = 2;
                        }
                    }
                    else if (keyInfo.Key == ConsoleKey.RightArrow)
                    {
                        if (returnBookDecisionCounter == 1)
                        {
                            returnBookDecisionCounter++;
                        }
                        else
                        {
                            returnBookDecisionCounter = 1;
                        }
                    }
                    else if (keyInfo.Key == ConsoleKey.Enter)
                    {
                        returnBookDecision = true;
                    }
                }
                while (returnBookDecision == false);

                returnBookDecision = false;

                if (returnBookDecisionCounter == 2)
                {
                    string returnedBookNumber = "";
                    int returnedBookNumberConverted = 0;

                    Console.CursorVisible = true;

                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    Console.SetCursorPosition(ReturnBookHoverPosition2 + 9, 27);
                    Console.Write(" ");
                    Console.SetCursorPosition(ReturnBookHoverPosition2 + 9, 27);

                    do
                    {
                        keyInfo = Console.ReadKey(true);

                        if (keyInfo.Key != ConsoleKey.Backspace && keyInfo.Key != ConsoleKey.Enter && returnedBookNumber.Length < 1 && (keyInfo.Key == ConsoleKey.D1 || keyInfo.Key == ConsoleKey.D2 || keyInfo.Key == ConsoleKey.D3 || keyInfo.Key == ConsoleKey.D4 || keyInfo.Key == ConsoleKey.NumPad1 || keyInfo.Key == ConsoleKey.NumPad2 || keyInfo.Key == ConsoleKey.NumPad3 || keyInfo.Key == ConsoleKey.NumPad4))
                        {
                            if (keyInfo.KeyChar != '\t')
                            {
                                returnedBookNumber += keyInfo.KeyChar;
                            }
                            else
                            {
                                returnedBookNumber += " ";
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
                        else if (keyInfo.Key == ConsoleKey.Backspace && returnedBookNumber.Length > 0)
                        {
                            returnedBookNumber = returnedBookNumber.Substring(0, (returnedBookNumber.Length - 1));
                            Console.Write("\b \b");
                        }
                        else if (keyInfo.Key == ConsoleKey.Escape)
                        {
                            returnedBookNumberConverted = -1;
                            break;
                        }
                    }
                    while (keyInfo.Key != ConsoleKey.Enter);

                    Console.CursorVisible = false;
                    if (returnedBookNumber != "")
                    {
                        returnedBookNumberConverted = Convert.ToInt32(returnedBookNumber) - 1;
                        returnedBookNumber = "";
                    }
                    else
                    {
                        returnedBookNumberConverted = -1;
                        returnedBookNumber = "";
                    }

                    Console.ResetColor();

                    try
                    {
                        string myId;

                        myId = myUser.Books[returnedBookNumberConverted].Id;
                        
                        foreach(Book book in Mock._books)
                        {
                            if(myId == book.Id)
                            {
                                book.IsLended = false;
                            }
                        }

                        myUser.Books.RemoveAt(returnedBookNumberConverted);

                        string cleaner = "                                                                                ";

                        Console.SetCursorPosition((Console.WindowWidth - cleaner.Length) /2 , 13);

                        for (int i = 0; i < 16; i++)
                        {
                            Console.SetCursorPosition((Console.WindowWidth - cleaner.Length) / 2, Console.CursorTop);
                            Console.WriteLine(cleaner);
                        }

                        Console.SetCursorPosition((Console.WindowWidth - cleaner.Length) / 2, 13);

                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.ForegroundColor = ConsoleColor.White;

                        string info1 = "╔══════════════════════════════════╗";
                        string info2 = "║ KSIĄŻKA ZOSTAŁA POMYŚLNIE ODDANA ║";
                        string info3 = "╚══════════════════════════════════╝";

                        Console.WriteLine();
                        Console.SetCursorPosition((Console.WindowWidth - info1.Length) / 2, Console.CursorTop);
                        Console.WriteLine(info1);
                        Console.SetCursorPosition((Console.WindowWidth - info2.Length) / 2, Console.CursorTop);
                        Console.WriteLine(info2);
                        Console.SetCursorPosition((Console.WindowWidth - info3.Length) / 2, Console.CursorTop);
                        Console.WriteLine(info3);

                        UserBackButton();

                        do
                        {
                            keyInfo = Console.ReadKey(true);
                        } while (keyInfo.Key != ConsoleKey.Enter);
                    }
                    catch
                    {
                        string cleaner = "                                                                                ";

                        Console.SetCursorPosition((Console.WindowWidth - cleaner.Length) / 2, 13);

                        for (int i = 0; i < 16; i++)
                        {
                            Console.SetCursorPosition((Console.WindowWidth - cleaner.Length) / 2, Console.CursorTop);
                            Console.WriteLine(cleaner);
                        }

                        Console.SetCursorPosition((Console.WindowWidth - cleaner.Length) / 2, 13);

                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.ForegroundColor = ConsoleColor.White;

                        string info1 = "╔══════════════════════════════════╗";
                        string info2 = "║ NIE ZNALEZIONO KSIĄŻKI NA LIŚCIE ║";
                        string info3 = "║ AKCJA ZOSTAŁA ANULOWANA!         ║";
                        string info4 = "╚══════════════════════════════════╝";

                        Console.WriteLine();
                        Console.SetCursorPosition((Console.WindowWidth - info1.Length) / 2, Console.CursorTop);
                        Console.WriteLine(info1);
                        Console.SetCursorPosition((Console.WindowWidth - info2.Length) / 2, Console.CursorTop);
                        Console.WriteLine(info2);
                        Console.SetCursorPosition((Console.WindowWidth - info3.Length) / 2, Console.CursorTop);
                        Console.WriteLine(info3);
                        Console.SetCursorPosition((Console.WindowWidth - info3.Length) / 2, Console.CursorTop);
                        Console.WriteLine(info4);

                        UserBackButton();

                        do
                        {
                            keyInfo = Console.ReadKey(true);
                        } while (keyInfo.Key != ConsoleKey.Enter);
                    }
                }             
            }
            else
            {
                UserBackButton();

                do
                {
                    keyInfo = Console.ReadKey(true);
                }
                while (keyInfo.Key != ConsoleKey.Enter);
            }
        }

        public static void WorkerLogo()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            string inf1 = "╔══════════════════════════════════════════════════════════════════════════╗";
            string inf2 = "║ ██████╗ ██████╗  █████╗  ██████╗ ██████╗ ██╗    ██╗███╗   ██╗██╗██╗  ██╗ ║";
            string inf3 = "║ ██╔══██╗██╔══██╗██╔══██╗██╔════╝██╔═══██╗██║    ██║████╗  ██║██║██║ ██╔╝ ║";
            string inf4 = "║ ██████╔╝██████╔╝███████║██║     ██║   ██║██║ █╗ ██║██╔██╗ ██║██║█████╔╝  ║";
            string inf5 = "║ ██╔═══╝ ██╔══██╗██╔══██║██║     ██║   ██║██║███╗██║██║╚██╗██║██║██╔═██╗  ║";
            string inf6 = "║ ██║     ██║  ██║██║  ██║╚██████╗╚██████╔╝╚███╔███╔╝██║ ╚████║██║██║  ██╗ ║";
            string inf7 = "╚══════════════════════════════════════════════════════════════════════════╝";

            Console.WriteLine("");
            Console.SetCursorPosition((Console.WindowWidth - inf1.Length) / 2, Console.CursorTop);
            Console.WriteLine(inf1);
            Console.SetCursorPosition((Console.WindowWidth - inf2.Length) / 2, Console.CursorTop);
            Console.WriteLine(inf2);
            Console.SetCursorPosition((Console.WindowWidth - inf3.Length) / 2, Console.CursorTop);
            Console.WriteLine(inf3);
            Console.SetCursorPosition((Console.WindowWidth - inf4.Length) / 2, Console.CursorTop);
            Console.WriteLine(inf4);
            Console.SetCursorPosition((Console.WindowWidth - inf5.Length) / 2, Console.CursorTop);
            Console.WriteLine(inf5);
            Console.SetCursorPosition((Console.WindowWidth - inf6.Length) / 2, Console.CursorTop);
            Console.WriteLine(inf6);
            Console.SetCursorPosition((Console.WindowWidth - inf7.Length) / 2, Console.CursorTop);
            Console.WriteLine(inf7);
        }

        public static int workerHoverPosition1;
        public static int workerHoverPosition2;
        public static int workerHoverPosition3;
        public static int workerHoverPosition4;
        public static int workerHoverPosition5;

        public static void WorkerOptions()
        {
            string button11 = "╔═══════════════╗"; string button21 = "╔══════════════╗"; string button31 = "╔════════════════╗"; string button41 = "╔═════════════╗"; string button51 = "╔═════════╗";
            string button12 = "║ DODAJ KSIĄŻKĘ ║"; string button22 = "║ USUŃ KSIĄŻKĘ ║"; string button32 = "║ EDYTUJ KSIĄŻKĘ ║"; string button42 = "║ UŻYTKOWNICY ║"; string button52 = "║ WYLOGUJ ║";
            string button13 = "╚═══════════════╝"; string button23 = "╚══════════════╝"; string button33 = "╚════════════════╝"; string button43 = "╚═════════════╝"; string button53 = "╚═════════╝";

            string space = "  ";

            workerHoverPosition1 = (Console.WindowWidth - (button11.Length + button21.Length + button31.Length + button41.Length + button51.Length + space.Length * 3)) / 2;
            workerHoverPosition2 = workerHoverPosition1 + 19;
            workerHoverPosition3 = workerHoverPosition2 + 18;
            workerHoverPosition4 = workerHoverPosition3 + 20;
            workerHoverPosition5 = workerHoverPosition4 + 17;

        Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.SetCursorPosition((Console.WindowWidth - (button11.Length + button21.Length + button31.Length + button41.Length + button51.Length + space.Length * 3)) / 2, Console.CursorTop);
            Console.Write(button11);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(space);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(button21);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(space);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(button31);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(space);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(button41);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(space);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(button51);
            Console.WriteLine();
            Console.SetCursorPosition((Console.WindowWidth - (button11.Length + button21.Length + button31.Length + button41.Length + button51.Length + space.Length * 3)) / 2, Console.CursorTop);
            Console.Write(button12);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(space);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(button22);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(space);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(button32);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(space);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(button42);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(space);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(button52);
            Console.WriteLine();
            Console.SetCursorPosition((Console.WindowWidth - (button11.Length + button21.Length + button31.Length + button41.Length + button51.Length + space.Length * 3)) / 2, Console.CursorTop);
            Console.Write(button13);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(space);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(button23);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(space);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(button33);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(space);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(button43);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(space);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(button53);
            Console.WriteLine();

            Console.ResetColor();
        }

        public static void WorkerOptionsHover(int workerMainDecisionCounter)
        {
            if (workerMainDecisionCounter == 1)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.SetCursorPosition(workerHoverPosition1, 14);
                Console.Write("╔═══════════════╗");
                Console.SetCursorPosition(workerHoverPosition1, 15);
                Console.Write("║ DODAJ KSIĄŻKĘ ║");
                Console.SetCursorPosition(workerHoverPosition1, 16);
                Console.Write("╚═══════════════╝");

                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;

                Console.SetCursorPosition(workerHoverPosition2, 14);
                Console.Write("╔══════════════╗");
                Console.SetCursorPosition(workerHoverPosition2, 15);
                Console.Write("║ USUŃ KSIĄŻKĘ ║");
                Console.SetCursorPosition(workerHoverPosition2, 16);
                Console.Write("╚══════════════╝");

                Console.SetCursorPosition(workerHoverPosition3, 14);
                Console.Write("╔════════════════╗");
                Console.SetCursorPosition(workerHoverPosition3, 15);
                Console.Write("║ EDYTUJ KSIĄŻKĘ ║");
                Console.SetCursorPosition(workerHoverPosition3, 16);
                Console.Write("╚════════════════╝");

                Console.SetCursorPosition(workerHoverPosition4, 14);
                Console.Write("╔═════════════╗");
                Console.SetCursorPosition(workerHoverPosition4, 15);
                Console.Write("║ UŻYTKOWNICY ║");
                Console.SetCursorPosition(workerHoverPosition4, 16);
                Console.Write("╚═════════════╝");

                Console.SetCursorPosition(workerHoverPosition5, 14);
                Console.Write("╔═════════╗");
                Console.SetCursorPosition(workerHoverPosition5, 15);
                Console.Write("║ WYLOGUJ ║");
                Console.SetCursorPosition(workerHoverPosition5, 16);
                Console.Write("╚═════════╝");

                Console.ResetColor();
            }
            else if (workerMainDecisionCounter == 2)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;

                Console.SetCursorPosition(workerHoverPosition1, 14);
                Console.Write("╔═══════════════╗");
                Console.SetCursorPosition(workerHoverPosition1, 15);
                Console.Write("║ DODAJ KSIĄŻKĘ ║");
                Console.SetCursorPosition(workerHoverPosition1, 16);
                Console.Write("╚═══════════════╝");

                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.SetCursorPosition(workerHoverPosition2, 14);
                Console.Write("╔══════════════╗");
                Console.SetCursorPosition(workerHoverPosition2, 15);
                Console.Write("║ USUŃ KSIĄŻKĘ ║");
                Console.SetCursorPosition(workerHoverPosition2, 16);
                Console.Write("╚══════════════╝");

                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;

                Console.SetCursorPosition(workerHoverPosition3, 14);
                Console.Write("╔════════════════╗");
                Console.SetCursorPosition(workerHoverPosition3, 15);
                Console.Write("║ EDYTUJ KSIĄŻKĘ ║");
                Console.SetCursorPosition(workerHoverPosition3, 16);
                Console.Write("╚════════════════╝");

                Console.SetCursorPosition(workerHoverPosition4, 14);
                Console.Write("╔═════════════╗");
                Console.SetCursorPosition(workerHoverPosition4, 15);
                Console.Write("║ UŻYTKOWNICY ║");
                Console.SetCursorPosition(workerHoverPosition4, 16);
                Console.Write("╚═════════════╝");

                Console.SetCursorPosition(workerHoverPosition5, 14);
                Console.Write("╔═════════╗");
                Console.SetCursorPosition(workerHoverPosition5, 15);
                Console.Write("║ WYLOGUJ ║");
                Console.SetCursorPosition(workerHoverPosition5, 16);
                Console.Write("╚═════════╝");

                Console.ResetColor();
            }
            else if (workerMainDecisionCounter == 3)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;

                Console.SetCursorPosition(workerHoverPosition1, 14);
                Console.Write("╔═══════════════╗");
                Console.SetCursorPosition(workerHoverPosition1, 15);
                Console.Write("║ DODAJ KSIĄŻKĘ ║");
                Console.SetCursorPosition(workerHoverPosition1, 16);
                Console.Write("╚═══════════════╝");

                Console.SetCursorPosition(workerHoverPosition2, 14);
                Console.Write("╔══════════════╗");
                Console.SetCursorPosition(workerHoverPosition2, 15);
                Console.Write("║ USUŃ KSIĄŻKĘ ║");
                Console.SetCursorPosition(workerHoverPosition2, 16);
                Console.Write("╚══════════════╝");

                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.SetCursorPosition(workerHoverPosition3, 14);
                Console.Write("╔════════════════╗");
                Console.SetCursorPosition(workerHoverPosition3, 15);
                Console.Write("║ EDYTUJ KSIĄŻKĘ ║");
                Console.SetCursorPosition(workerHoverPosition3, 16);
                Console.Write("╚════════════════╝");

                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;

                Console.SetCursorPosition(workerHoverPosition4, 14);
                Console.Write("╔═════════════╗");
                Console.SetCursorPosition(workerHoverPosition4, 15);
                Console.Write("║ UŻYTKOWNICY ║");
                Console.SetCursorPosition(workerHoverPosition4, 16);
                Console.Write("╚═════════════╝");

                Console.SetCursorPosition(workerHoverPosition5, 14);
                Console.Write("╔═════════╗");
                Console.SetCursorPosition(workerHoverPosition5, 15);
                Console.Write("║ WYLOGUJ ║");
                Console.SetCursorPosition(workerHoverPosition5, 16);
                Console.Write("╚═════════╝");

                Console.ResetColor();
            }
            else if (workerMainDecisionCounter == 4)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;

                Console.SetCursorPosition(workerHoverPosition1, 14);
                Console.Write("╔═══════════════╗");
                Console.SetCursorPosition(workerHoverPosition1, 15);
                Console.Write("║ DODAJ KSIĄŻKĘ ║");
                Console.SetCursorPosition(workerHoverPosition1, 16);
                Console.Write("╚═══════════════╝");

                Console.SetCursorPosition(workerHoverPosition2, 14);
                Console.Write("╔══════════════╗");
                Console.SetCursorPosition(workerHoverPosition2, 15);
                Console.Write("║ USUŃ KSIĄŻKĘ ║");
                Console.SetCursorPosition(workerHoverPosition2, 16);
                Console.Write("╚══════════════╝");

                Console.SetCursorPosition(workerHoverPosition3, 14);
                Console.Write("╔════════════════╗");
                Console.SetCursorPosition(workerHoverPosition3, 15);
                Console.Write("║ EDYTUJ KSIĄŻKĘ ║");
                Console.SetCursorPosition(workerHoverPosition3, 16);
                Console.Write("╚════════════════╝");

                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.SetCursorPosition(workerHoverPosition4, 14);
                Console.Write("╔═════════════╗");
                Console.SetCursorPosition(workerHoverPosition4, 15);
                Console.Write("║ UŻYTKOWNICY ║");
                Console.SetCursorPosition(workerHoverPosition4, 16);
                Console.Write("╚═════════════╝");

                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;

                Console.SetCursorPosition(workerHoverPosition5, 14);
                Console.Write("╔═════════╗");
                Console.SetCursorPosition(workerHoverPosition5, 15);
                Console.Write("║ WYLOGUJ ║");
                Console.SetCursorPosition(workerHoverPosition5, 16);
                Console.Write("╚═════════╝");

                Console.ResetColor();
            }
            else if (workerMainDecisionCounter == 5)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;

                Console.SetCursorPosition(workerHoverPosition1, 14);
                Console.Write("╔═══════════════╗");
                Console.SetCursorPosition(workerHoverPosition1, 15);
                Console.Write("║ DODAJ KSIĄŻKĘ ║");
                Console.SetCursorPosition(workerHoverPosition1, 16);
                Console.Write("╚═══════════════╝");

                Console.SetCursorPosition(workerHoverPosition2, 14);
                Console.Write("╔══════════════╗");
                Console.SetCursorPosition(workerHoverPosition2, 15);
                Console.Write("║ USUŃ KSIĄŻKĘ ║");
                Console.SetCursorPosition(workerHoverPosition2, 16);
                Console.Write("╚══════════════╝");

                Console.SetCursorPosition(workerHoverPosition3, 14);
                Console.Write("╔════════════════╗");
                Console.SetCursorPosition(workerHoverPosition3, 15);
                Console.Write("║ EDYTUJ KSIĄŻKĘ ║");
                Console.SetCursorPosition(workerHoverPosition3, 16);
                Console.Write("╚════════════════╝");

                Console.SetCursorPosition(workerHoverPosition4, 14);
                Console.Write("╔═════════════╗");
                Console.SetCursorPosition(workerHoverPosition4, 15);
                Console.Write("║ UŻYTKOWNICY ║");
                Console.SetCursorPosition(workerHoverPosition4, 16);
                Console.Write("╚═════════════╝");

                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.SetCursorPosition(workerHoverPosition5, 14);
                Console.Write("╔═════════╗");
                Console.SetCursorPosition(workerHoverPosition5, 15);
                Console.Write("║ WYLOGUJ ║");
                Console.SetCursorPosition(workerHoverPosition5, 16);
                Console.Write("╚═════════╝");

                Console.ResetColor();
            }
        }

        public static int usersListPosition = 0;

        public static void UsersListLogo()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            string inf1 = "╔══════════════════════════════════════════════════════════════════════════════════════════════╗";
            string inf2 = "║ ██╗   ██╗███████╗██╗   ██╗████████╗██╗  ██╗ ██████╗ ██╗    ██╗███╗   ██╗██╗ ██████╗██╗   ██╗ ║";
            string inf3 = "║ ██║   ██║╚══███╔╝╚██╗ ██╔╝╚══██╔══╝██║ ██╔╝██╔═══██╗██║    ██║████╗  ██║██║██╔════╝╚██╗ ██╔╝ ║";
            string inf4 = "║ ██║   ██║  ███╔╝  ╚████╔╝    ██║   █████╔╝ ██║   ██║██║ █╗ ██║██╔██╗ ██║██║██║      ╚████╔╝  ║";
            string inf5 = "║ ██║   ██║ ███╔╝    ╚██╔╝     ██║   ██╔═██╗ ██║   ██║██║███╗██║██║╚██╗██║██║██║       ╚██╔╝   ║";
            string inf6 = "║ ╚██████╔╝███████╗   ██║      ██║   ██║  ██╗╚██████╔╝╚███╔███╔╝██║ ╚████║██║╚██████╗   ██║    ║";
            string inf7 = "╚══════════════════════════════════════════════════════════════════════════════════════════════╝";

            Console.WriteLine("");
            Console.SetCursorPosition((Console.WindowWidth - inf1.Length) / 2, Console.CursorTop);
            Console.WriteLine(inf1);
            Console.SetCursorPosition((Console.WindowWidth - inf2.Length) / 2, Console.CursorTop);
            Console.WriteLine(inf2);
            Console.SetCursorPosition((Console.WindowWidth - inf3.Length) / 2, Console.CursorTop);
            Console.WriteLine(inf3);
            Console.SetCursorPosition((Console.WindowWidth - inf4.Length) / 2, Console.CursorTop);
            Console.WriteLine(inf4);
            Console.SetCursorPosition((Console.WindowWidth - inf5.Length) / 2, Console.CursorTop);
            Console.WriteLine(inf5);
            Console.SetCursorPosition((Console.WindowWidth - inf6.Length) / 2, Console.CursorTop);
            Console.WriteLine(inf6);
            Console.SetCursorPosition((Console.WindowWidth - inf7.Length) / 2, Console.CursorTop);
            Console.WriteLine(inf7);

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;

            string info1 = "╔═════════════════════════════════════════╗";
            string info2 = "║ LISTA WSZYSTKICH UŻYTKOWNIKÓW APLIKACJI ║";
            string info3 = "║ UŻYJ KLAWISZY STRZAŁEK BY NAWIGOWAĆ     ║";
            string info4 = "╚═════════════════════════════════════════╝";

            usersListPosition = (Console.WindowWidth - info1.Length) / 2;

            Console.WriteLine();
            Console.SetCursorPosition((Console.WindowWidth - info1.Length) / 2, Console.CursorTop);
            Console.WriteLine(info1);
            Console.SetCursorPosition((Console.WindowWidth - info2.Length) / 2, Console.CursorTop);
            Console.WriteLine(info2);
            Console.SetCursorPosition((Console.WindowWidth - info3.Length) / 2, Console.CursorTop);
            Console.WriteLine(info3);
            Console.SetCursorPosition((Console.WindowWidth - info4.Length) / 2, Console.CursorTop);
            Console.WriteLine(info4);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Yellow;

            string info5 = "╔═══════╗";
            string info6 = "<-║ Dalej ║->";
            string info7 = "╚═══════╝";

            Console.WriteLine();
            Console.SetCursorPosition((Console.WindowWidth - info5.Length) / 2, Console.CursorTop);
            Console.WriteLine(info5);
            Console.SetCursorPosition((Console.WindowWidth - info6.Length) / 2, Console.CursorTop);
            Console.WriteLine(info6);
            Console.SetCursorPosition((Console.WindowWidth - info7.Length) / 2, Console.CursorTop);
            Console.WriteLine(info7);

            Console.ResetColor();
        }

        public static int bookWritingPosition = 0;

        public static void AddBookDrawer()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            string logo1 = "╔═══════════════════════════════════════════╗";
            string logo2 = "║ ██████╗  ██████╗ ██████╗  █████╗      ██╗ ║";
            string logo3 = "║ ██╔══██╗██╔═══██╗██╔══██╗██╔══██╗     ██║ ║";
            string logo4 = "║ ██║  ██║██║   ██║██║  ██║███████║     ██║ ║";
            string logo5 = "║ ██║  ██║██║   ██║██║  ██║██╔══██║██   ██║ ║";
            string logo6 = "║ ██████╔╝╚██████╔╝██████╔╝██║  ██║╚█████╔╝ ║";
            string logo7 = "╚═══════════════════════════════════════════╝";

            Console.WriteLine("");
            Console.SetCursorPosition((Console.WindowWidth - logo1.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo1);
            Console.SetCursorPosition((Console.WindowWidth - logo2.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo2);
            Console.SetCursorPosition((Console.WindowWidth - logo3.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo3);
            Console.SetCursorPosition((Console.WindowWidth - logo4.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo4);
            Console.SetCursorPosition((Console.WindowWidth - logo5.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo5);
            Console.SetCursorPosition((Console.WindowWidth - logo6.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo6);
            Console.SetCursorPosition((Console.WindowWidth - logo7.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo7);

            string info1 = "╔══════════════════════════════════════════╗";
            string info2 = "║ WPISZ ODPOWIEDNIE DANE ABY DODAĆ KSIĄŻKĘ ║";
            string info3 = "║ ABY ANULOWAĆ ZOSTAW POLA PUSTE ( >= 1 )  ║";
            string info4 = "╚══════════════════════════════════════════╝";

            Console.WriteLine();
            Console.SetCursorPosition((Console.WindowWidth - info1.Length) / 2, Console.CursorTop);
            Console.WriteLine(info1);
            Console.SetCursorPosition((Console.WindowWidth - info2.Length) / 2, Console.CursorTop);
            Console.WriteLine(info2);
            Console.SetCursorPosition((Console.WindowWidth - info2.Length) / 2, Console.CursorTop);
            Console.WriteLine(info3);
            Console.SetCursorPosition((Console.WindowWidth - info4.Length) / 2, Console.CursorTop);
            Console.WriteLine(info4);

            string info5 =  "╔════════════════════════════════════════════════════════════════════════╗";
            string info6 =  "║       TYTUŁ:                                                           ║";
            string info7 =  "║       AUTOR:                                                           ║";
            string info8 =  "║ ROK WYDANIA:                                                           ║";
            string info9 =  "║ WYDAWNICTWO:                                                           ║";
            string info10 = "╚════════════════════════════════════════════════════════════════════════╝";

            bookWritingPosition = ((Console.WindowWidth - info5.Length) / 2) + 15;

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
        }

        public static void EditBookDrawer()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            string logo1 = "╔═════════════════════════════════════════════════════╗";
            string logo2 = "║ ███████╗██████╗ ██╗   ██╗████████╗██╗   ██╗     ██╗ ║";
            string logo3 = "║ ██╔════╝██╔══██╗╚██╗ ██╔╝╚══██╔══╝██║   ██║     ██║ ║";
            string logo4 = "║ █████╗  ██║  ██║ ╚████╔╝    ██║   ██║   ██║     ██║ ║";
            string logo5 = "║ ██╔══╝  ██║  ██║  ╚██╔╝     ██║   ██║   ██║██   ██║ ║";
            string logo6 = "║ ███████╗██████╔╝   ██║      ██║   ╚██████╔╝╚█████╔╝ ║";
            string logo7 = "╚═════════════════════════════════════════════════════╝";

            Console.WriteLine("");
            Console.SetCursorPosition((Console.WindowWidth - logo1.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo1);
            Console.SetCursorPosition((Console.WindowWidth - logo2.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo2);
            Console.SetCursorPosition((Console.WindowWidth - logo3.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo3);
            Console.SetCursorPosition((Console.WindowWidth - logo4.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo4);
            Console.SetCursorPosition((Console.WindowWidth - logo5.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo5);
            Console.SetCursorPosition((Console.WindowWidth - logo6.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo6);
            Console.SetCursorPosition((Console.WindowWidth - logo7.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo7);

            string info1 = "╔════════════════════════════════════════════════════════╗";
            string info2 = "║ WYBIERZ, KTÓRĄ POZYCJĘ CHCESZ EDYTOWAĆ [ZAPAMIĘTAJ NR] ║";
            string info3 = "║ KOLOR ZIELONY: NA STANIE, CZERWONY: WYPOŻYCZONE:       ║";
            string info4 = "╚════════════════════════════════════════════════════════╝";

            Console.WriteLine();
            Console.SetCursorPosition((Console.WindowWidth - info1.Length) / 2, Console.CursorTop);
            Console.WriteLine(info1);
            Console.SetCursorPosition((Console.WindowWidth - info2.Length) / 2, Console.CursorTop);
            Console.WriteLine(info2);
            Console.SetCursorPosition((Console.WindowWidth - info3.Length) / 2, Console.CursorTop);
            Console.WriteLine(info3);
            Console.SetCursorPosition((Console.WindowWidth - info4.Length) / 2, Console.CursorTop);
            Console.WriteLine(info4);
            Console.WriteLine();

            Console.SetCursorPosition((Console.WindowWidth - info1.Length) / 2 + 8, 11);
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("ZIELONY:");

            Console.SetCursorPosition((Console.WindowWidth - info1.Length) / 2 + 28, 11);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("CZERWONY:");
            Console.WriteLine();

            Console.ResetColor();
        }

        public static void DeleteBookDrawer()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            string logo1 = "╔══════════════════════════════════════╗";
            string logo2 = "║ ██╗   ██╗███████╗██╗   ██╗███╗   ██╗ ║";
            string logo3 = "║ ██║   ██║██╔════╝██║   ██║████╗  ██║ ║";
            string logo4 = "║ ██║   ██║███████╗██║   ██║██╔██╗ ██║ ║";
            string logo5 = "║ ██║   ██║╚════██║██║   ██║██║╚██╗██║ ║";
            string logo6 = "║ ╚██████╔╝███████║╚██████╔╝██║ ╚████║ ║";
            string logo7 = "╚══════════════════════════════════════╝";

            Console.WriteLine("");
            Console.SetCursorPosition((Console.WindowWidth - logo1.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo1);
            Console.SetCursorPosition((Console.WindowWidth - logo2.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo2);
            Console.SetCursorPosition((Console.WindowWidth - logo3.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo3);
            Console.SetCursorPosition((Console.WindowWidth - logo4.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo4);
            Console.SetCursorPosition((Console.WindowWidth - logo5.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo5);
            Console.SetCursorPosition((Console.WindowWidth - logo6.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo6);
            Console.SetCursorPosition((Console.WindowWidth - logo7.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo7);

            string info1 = "╔══════════════════════════════════════════════════════╗";
            string info2 = "║ WYBIERZ, KTÓRĄ POZYCJĘ CHCESZ USUNĄĆ [ZAPAMIĘTAJ NR] ║";
            string info3 = "║ KOLOR ZIELONY: NA STANIE, CZERWONY: WYPOŻYCZONE:     ║";
            string info4 = "╚══════════════════════════════════════════════════════╝";

            Console.WriteLine();
            Console.SetCursorPosition((Console.WindowWidth - info1.Length) / 2, Console.CursorTop);
            Console.WriteLine(info1);
            Console.SetCursorPosition((Console.WindowWidth - info2.Length) / 2, Console.CursorTop);
            Console.WriteLine(info2);
            Console.SetCursorPosition((Console.WindowWidth - info3.Length) / 2, Console.CursorTop);
            Console.WriteLine(info3);
            Console.SetCursorPosition((Console.WindowWidth - info4.Length) / 2, Console.CursorTop);
            Console.WriteLine(info4);
            Console.WriteLine();

            Console.SetCursorPosition((Console.WindowWidth - info1.Length) / 2 + 8, 11);
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("ZIELONY:");

            Console.SetCursorPosition((Console.WindowWidth - info1.Length) / 2 + 28, 11);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("CZERWONY:");
            Console.WriteLine();

            Console.ResetColor();
        }

        public static void BookDeletingOptions()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;

            string space = "  ";

            string back1 = "╔══════╗"; string exit1 = "╔════════╗";
            string back2 = "║ USUŃ ║"; string exit2 = "║ POWRÓT ║";
            string back3 = "╚══════╝"; string exit3 = "╚════════╝";

            lendingHoverPosition1 = (Console.WindowWidth - (back1.Length + exit1.Length + space.Length * 2)) / 2;
            lendingHoverPosition2 = lendingHoverPosition1 + 14;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.SetCursorPosition((Console.WindowWidth - (back1.Length + exit1.Length + space.Length * 2)) / 2, Console.CursorTop);
            Console.Write(back1);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(space);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(exit1);
            Console.WriteLine();
            Console.SetCursorPosition((Console.WindowWidth - (back1.Length + exit1.Length + space.Length * 2)) / 2, Console.CursorTop);
            Console.Write(back2);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(space);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(exit2);
            Console.WriteLine();
            Console.SetCursorPosition((Console.WindowWidth - (back1.Length + exit1.Length + space.Length * 2)) / 2, Console.CursorTop);
            Console.Write(back3);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(space);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(exit3);
        }

        public static void DeletingBookHover(int counter)
        {
            if (counter == 1)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.SetCursorPosition(MenuManager.lendingHoverPosition1, 14);
                Console.Write("╔══════╗");
                Console.SetCursorPosition(MenuManager.lendingHoverPosition1, 15);
                Console.Write("║ USUŃ ║");
                Console.SetCursorPosition(MenuManager.lendingHoverPosition1, 16);
                Console.Write("╚══════╝");

                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;

                Console.SetCursorPosition(MenuManager.lendingHoverPosition2 - 4, 14);
                Console.Write("╔════════╗");
                Console.SetCursorPosition(MenuManager.lendingHoverPosition2 - 4, 15);
                Console.Write("║ POWRÓT ║");
                Console.SetCursorPosition(MenuManager.lendingHoverPosition2 - 4, 16);
                Console.Write("╚════════╝");

                Console.ResetColor();
            }
            else if (counter == 2)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;

                Console.SetCursorPosition(MenuManager.lendingHoverPosition1, 14);
                Console.Write("╔══════╗");
                Console.SetCursorPosition(MenuManager.lendingHoverPosition1, 15);
                Console.Write("║ USUŃ ║");
                Console.SetCursorPosition(MenuManager.lendingHoverPosition1, 16);
                Console.Write("╚══════╝");

                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.SetCursorPosition(MenuManager.lendingHoverPosition2 - 4, 14);
                Console.Write("╔════════╗");
                Console.SetCursorPosition(MenuManager.lendingHoverPosition2 - 4, 15);
                Console.Write("║ POWRÓT ║");
                Console.SetCursorPosition(MenuManager.lendingHoverPosition2 - 4, 16);
                Console.Write("╚════════╝"); ;

                Console.ResetColor();
            }
        }

            public static void deletingChoiceDrawer()
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;

                string info1 = "╔══════════════════════════════════════════════╗";
                string info2 = "║ WPISZ NR KSIĄŻKI, KTÓRĄ CHCESZ USUNĄĆ:       ║";
                string info3 = "╚══════════════════════════════════════════════╝";

                Console.WriteLine();
                Console.WriteLine();
                Console.SetCursorPosition((Console.WindowWidth - info1.Length) / 2, Console.CursorTop);
                Console.WriteLine(info1);
                Console.SetCursorPosition((Console.WindowWidth - info2.Length) / 2, Console.CursorTop);
                Console.WriteLine(info2);
                Console.SetCursorPosition((Console.WindowWidth - info3.Length) / 2, Console.CursorTop);
                Console.WriteLine(info3);
                Console.WriteLine();

                fixPanelPosition = (Console.WindowWidth - info3.Length) / 2 + 45;

                Console.SetCursorPosition((Console.WindowWidth - info3.Length) / 2 + 45 - 4, 19);
            }

        public static void DeleteBookDrawerLogo()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            string logo1 = "╔══════════════════════════════════════╗";
            string logo2 = "║ ██╗   ██╗███████╗██╗   ██╗███╗   ██╗ ║";
            string logo3 = "║ ██║   ██║██╔════╝██║   ██║████╗  ██║ ║";
            string logo4 = "║ ██║   ██║███████╗██║   ██║██╔██╗ ██║ ║";
            string logo5 = "║ ██║   ██║╚════██║██║   ██║██║╚██╗██║ ║";
            string logo6 = "║ ╚██████╔╝███████║╚██████╔╝██║ ╚████║ ║";
            string logo7 = "╚══════════════════════════════════════╝";

            Console.WriteLine("");
            Console.SetCursorPosition((Console.WindowWidth - logo1.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo1);
            Console.SetCursorPosition((Console.WindowWidth - logo2.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo2);
            Console.SetCursorPosition((Console.WindowWidth - logo3.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo3);
            Console.SetCursorPosition((Console.WindowWidth - logo4.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo4);
            Console.SetCursorPosition((Console.WindowWidth - logo5.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo5);
            Console.SetCursorPosition((Console.WindowWidth - logo6.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo6);
            Console.SetCursorPosition((Console.WindowWidth - logo7.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo7);

            Console.ResetColor();
        }

        public static void EditBookDrawerLogo()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            string logo1 = "╔═════════════════════════════════════════════════════╗";
            string logo2 = "║ ███████╗██████╗ ██╗   ██╗████████╗██╗   ██╗     ██╗ ║";
            string logo3 = "║ ██╔════╝██╔══██╗╚██╗ ██╔╝╚══██╔══╝██║   ██║     ██║ ║";
            string logo4 = "║ █████╗  ██║  ██║ ╚████╔╝    ██║   ██║   ██║     ██║ ║";
            string logo5 = "║ ██╔══╝  ██║  ██║  ╚██╔╝     ██║   ██║   ██║██   ██║ ║";
            string logo6 = "║ ███████╗██████╔╝   ██║      ██║   ╚██████╔╝╚█████╔╝ ║";
            string logo7 = "╚═════════════════════════════════════════════════════╝";

            Console.WriteLine("");
            Console.SetCursorPosition((Console.WindowWidth - logo1.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo1);
            Console.SetCursorPosition((Console.WindowWidth - logo2.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo2);
            Console.SetCursorPosition((Console.WindowWidth - logo3.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo3);
            Console.SetCursorPosition((Console.WindowWidth - logo4.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo4);
            Console.SetCursorPosition((Console.WindowWidth - logo5.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo5);
            Console.SetCursorPosition((Console.WindowWidth - logo6.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo6);
            Console.SetCursorPosition((Console.WindowWidth - logo7.Length) / 2, Console.CursorTop);
            Console.WriteLine(logo7);

            Console.ResetColor();
        }

        public static void EditBookOptionsDrawer()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;

            string space = "  ";

            string back1 = "╔════════╗"; string exit1 = "╔════════╗";
            string back2 = "║ EDYTUJ ║"; string exit2 = "║ POWRÓT ║";
            string back3 = "╚════════╝"; string exit3 = "╚════════╝";

            lendingHoverPosition1 = (Console.WindowWidth - (back1.Length + exit1.Length + space.Length * 2)) / 2;
            lendingHoverPosition2 = lendingHoverPosition1 + 14;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.SetCursorPosition((Console.WindowWidth - (back1.Length + exit1.Length + space.Length * 2)) / 2, Console.CursorTop);
            Console.Write(back1);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(space);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(exit1);
            Console.WriteLine();
            Console.SetCursorPosition((Console.WindowWidth - (back1.Length + exit1.Length + space.Length * 2)) / 2, Console.CursorTop);
            Console.Write(back2);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(space);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(exit2);
            Console.WriteLine();
            Console.SetCursorPosition((Console.WindowWidth - (back1.Length + exit1.Length + space.Length * 2)) / 2, Console.CursorTop);
            Console.Write(back3);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(space);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(exit3);
        }

        public static void EditBookOptionsHoover(int counter)
        {
            if (counter == 1)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.SetCursorPosition(MenuManager.lendingHoverPosition1, 14);
                Console.Write("╔════════╗");
                Console.SetCursorPosition(MenuManager.lendingHoverPosition1, 15);
                Console.Write("║ EDYTUJ ║");
                Console.SetCursorPosition(MenuManager.lendingHoverPosition1, 16);
                Console.Write("╚════════╝");

                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;

                Console.SetCursorPosition(MenuManager.lendingHoverPosition2 - 2, 14);
                Console.Write("╔════════╗");
                Console.SetCursorPosition(MenuManager.lendingHoverPosition2 - 2, 15);
                Console.Write("║ POWRÓT ║");
                Console.SetCursorPosition(MenuManager.lendingHoverPosition2 - 2, 16);
                Console.Write("╚════════╝");

                Console.ResetColor();
            }
            else if (counter == 2)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;

                Console.SetCursorPosition(MenuManager.lendingHoverPosition1, 14);
                Console.Write("╔════════╗");
                Console.SetCursorPosition(MenuManager.lendingHoverPosition1, 15);
                Console.Write("║ EDYTUJ ║");
                Console.SetCursorPosition(MenuManager.lendingHoverPosition1, 16);
                Console.Write("╚════════╝");

                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.SetCursorPosition(MenuManager.lendingHoverPosition2 - 2, 14);
                Console.Write("╔════════╗");
                Console.SetCursorPosition(MenuManager.lendingHoverPosition2 - 2, 15);
                Console.Write("║ POWRÓT ║");
                Console.SetCursorPosition(MenuManager.lendingHoverPosition2 - 2, 16);
                Console.Write("╚════════╝"); ;

                Console.ResetColor();
            }
        }

        public static void EditBookTextBox()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;

            string info1 = "╔════════════════════════════════════════════════╗";
            string info2 = "║ WPISZ NR KSIĄŻKI, KTÓRĄ CHCESZ EDYTOWAĆ:       ║";
            string info3 = "╚════════════════════════════════════════════════╝";

            Console.WriteLine();
            Console.WriteLine();
            Console.SetCursorPosition((Console.WindowWidth - info1.Length) / 2, Console.CursorTop);
            Console.WriteLine(info1);
            Console.SetCursorPosition((Console.WindowWidth - info2.Length) / 2, Console.CursorTop);
            Console.WriteLine(info2);
            Console.SetCursorPosition((Console.WindowWidth - info3.Length) / 2, Console.CursorTop);
            Console.WriteLine(info3);
            Console.WriteLine();

            Console.SetCursorPosition((Console.WindowWidth - info3.Length) / 2 + 45 - 2, 19);
        }
    }
}