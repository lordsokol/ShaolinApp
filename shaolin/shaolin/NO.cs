using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace shaolin
{
    public partial class NO : Form
    {
        public NO()
        {
            InitializeComponent();
        }

        public NO(int howMany)
        {
            InitializeComponent();
            howManyLabel.Text = howMany.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
