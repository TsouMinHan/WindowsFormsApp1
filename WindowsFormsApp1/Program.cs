﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Order_From());

            if (false) {
                var Login = new Login_Form();
                var User = new Main_Form();
                DialogResult result = Login.ShowDialog();
                if (result == DialogResult.OK) {
                    Application.Run(new Main_Form());
                }
                else {
                    MessageBox.Show("Cencel");
                }
            }

        }
    }
}
