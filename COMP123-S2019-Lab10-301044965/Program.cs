﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lab10_301044965
{
    static class Program
    {
        public static EndForm endform;
        public static MainForm mainform;
        public static StartForm startform;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainform = new MainForm();
            endform = new EndForm();
            startform = new StartForm();
            Application.Run(startform);
        }

    }  
}

