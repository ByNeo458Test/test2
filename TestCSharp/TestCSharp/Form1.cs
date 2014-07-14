﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCSharp
{
    public partial class Form1 : Form
    {
        string path;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            path = folderBrowserDialog1.SelectedPath;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Değişiklik Yapıldı");
            try
            {
                string newName = path + "\\" + textBox1.Text;

                if (!Directory.Exists(newName))  // if it doesn't exist, create
                    Directory.CreateDirectory(newName);
            }
            catch (System.IO.IOException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
