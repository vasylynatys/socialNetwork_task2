﻿using System;
using System.Windows.Forms;

namespace SocialNetwork
{
    static class MainPr
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginPage());
        }
    }
}
