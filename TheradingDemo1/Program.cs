﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheradingDemo1
{

    public partial class Form1 : Form
    {
        InitializerComponent();
    }
    private void btnpPocess1_Click(object sender, EventArgs e)
    {
        MessageBox.Show("İslem 1 çalıştı");
    }
    private void btnProcess2_Click(object sender, EventArgs e)
    {
        MessageBox.Show("İslem 2 çalıştı");
    }

    //internal static class Program
    //{
    //    /// <summary>
    //    /// The main entry point for the application.
    //    /// </summary>
    //    [STAThread]
    //    static void Main()
    //    {
    //        Application.EnableVisualStyles();
    //        Application.SetCompatibleTextRenderingDefault(false);
    //        Application.Run(new Form1());
    //    }
    //}
}
