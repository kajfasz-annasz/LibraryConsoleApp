using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka.Other
{
    class DisplayManager
    {
        public static void DrawMainMenu()
        {
            MenuManager.MainLogo();
            MenuManager.MainScreenOptions();
        }

        public static void DrawInformation()
        {
            MenuManager.InformationLogo();
            MenuManager.InformationText();
        }

        public static void DrawLogin()
        {
            MenuManager.LoginLogo();
            MenuManager.LoginOptions();
        }

        public static void DrawUserInterphace()
        {
            MenuManager.UserLogo();
            MenuManager.UserHello();
            MenuManager.UserOptions();
        }

        public static void DrawWorkerInterphace()
        {
            MenuManager.WorkerLogo();
            MenuManager.UserHello();
            MenuManager.WorkerOptions();
        }
    }
}
