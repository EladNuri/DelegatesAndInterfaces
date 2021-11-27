using System;
using MenuInterfaces = Ex04.Menus.Interfaces;
using MenuDelegates = Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            beginMenu();
            endProgramShow();
            Console.ReadKey();
        }

        private static void beginMenu()
        {
            runInterfaceMenu();
            runDelegateMenu();
        }

        private static void runInterfaceMenu()
        {
            const bool v_IsMainMenu = false;

            MenuInterfaces.MainMenu mainMenuInterfaces = new MenuInterfaces.MainMenu("Interfaces Main Menu");

            MenuInterfaces.SubMenu subMenuVersionAndDigitsInterface = new MenuInterfaces.SubMenu("Version and Digits", v_IsMainMenu);
            MenuInterfaces.SubMenu subMenuDateAndTimeInterface = new MenuInterfaces.SubMenu("Show Date/Time", v_IsMainMenu);

            MenuInterfaces.MenuItemExecutable countCaptialsInterface = new MenuInterfaces.MenuItemExecutable("Count Captials");
            countCaptialsInterface.AddListener(new CountCaptials() as MenuInterfaces.IMenuClickListener);
            MenuInterfaces.MenuItemExecutable showVersionInterface = new MenuInterfaces.MenuItemExecutable("Show Version");
            showVersionInterface.AddListener(new ShowVersion() as MenuInterfaces.IMenuClickListener);
            MenuInterfaces.MenuItemExecutable showTimeInterface = new MenuInterfaces.MenuItemExecutable("Show Time");
            showTimeInterface.AddListener(new ShowTime() as MenuInterfaces.IMenuClickListener);
            MenuInterfaces.MenuItemExecutable showDateInterface = new MenuInterfaces.MenuItemExecutable("Show Date");
            showDateInterface.AddListener(new ShowDate() as MenuInterfaces.IMenuClickListener);

            subMenuVersionAndDigitsInterface.AddItemToSubMenu(countCaptialsInterface);
            subMenuVersionAndDigitsInterface.AddItemToSubMenu(showVersionInterface);
            subMenuDateAndTimeInterface.AddItemToSubMenu(showTimeInterface);
            subMenuDateAndTimeInterface.AddItemToSubMenu(showDateInterface);

            mainMenuInterfaces.AddMenuItemToMainMenu(subMenuVersionAndDigitsInterface);
            mainMenuInterfaces.AddMenuItemToMainMenu(subMenuDateAndTimeInterface);
            mainMenuInterfaces.Show();
        }

        private static void runDelegateMenu()
        {
            const bool v_IsMainMenu = false;
            MethodsForMenusDelegates methodsForMenusDelegates = new MethodsForMenusDelegates();

            MenuDelegates.MainMenu mainMenuDelegates = new MenuDelegates.MainMenu("Delegates Main Menu");

            MenuDelegates.SubMenu subMenuVersionAndDigitsDelegate = new MenuDelegates.SubMenu("Version and Digits", v_IsMainMenu);
            MenuDelegates.SubMenu subMenuDateAndTimeDelegate = new MenuDelegates.SubMenu("Show Date/Time", v_IsMainMenu);

            MenuDelegates.MenuItemExecutable countCaptialsDelegate = new MenuDelegates.MenuItemExecutable("Count Captials");
            countCaptialsDelegate.MenuItemClicked += methodsForMenusDelegates.CountCaptials;
            MenuDelegates.MenuItemExecutable showVersionDelegate = new MenuDelegates.MenuItemExecutable("Show Version");
            showVersionDelegate.MenuItemClicked += methodsForMenusDelegates.ShowVersion;
            MenuDelegates.MenuItemExecutable showTimeDelegate = new MenuDelegates.MenuItemExecutable("Show Time");
            showTimeDelegate.MenuItemClicked += methodsForMenusDelegates.ShowTime;
            MenuDelegates.MenuItemExecutable showDateDelegate = new MenuDelegates.MenuItemExecutable("Show Date");
            showDateDelegate.MenuItemClicked += methodsForMenusDelegates.ShowDate;

            subMenuVersionAndDigitsDelegate.AddItemToSubMenu(countCaptialsDelegate);
            subMenuVersionAndDigitsDelegate.AddItemToSubMenu(showVersionDelegate);
            subMenuDateAndTimeDelegate.AddItemToSubMenu(showTimeDelegate);
            subMenuDateAndTimeDelegate.AddItemToSubMenu(showDateDelegate);

            mainMenuDelegates.AddMenuItemToMainMenu(subMenuVersionAndDigitsDelegate);
            mainMenuDelegates.AddMenuItemToMainMenu(subMenuDateAndTimeDelegate);
            mainMenuDelegates.Show();
        }

        private static void endProgramShow()
        {
            Console.WriteLine("Goodbye");
            Console.Write("Press any key for continue...");
        }
    }
}
