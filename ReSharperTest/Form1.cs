using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ReSharperTest
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var test = new List<String>();
            Console.WriteLine(test[0]);

        }
    }
}
