﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace svchost
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new 我曾踏足山巅());
        }
    }
}
