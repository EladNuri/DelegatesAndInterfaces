﻿using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowVersion : IMenuClickListener
    {
        public void MenuClick()
        {
            showVersion();
        }

        private void showVersion()
        {
            Console.WriteLine("Version: 20.2.4.30620");
        }
    }
}
