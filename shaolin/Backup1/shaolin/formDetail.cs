using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace shaolin
{
    public partial class Details : Form
    {
        private static string formDetailString = "";

        public Details()
        {
            InitializeComponent();
        }

        public Details(String formName)
        {
            InitializeComponent();
            setFormDetailString(ConfigurationSettings.AppSettings[formName + "detail"]);
            formLabel.Text = ConfigurationSettings.AppSettings[formName];
            descriptionArea.Text = getFormDetailString();
            descriptionArea.Select(0, 1);
        }

        public void setFormDetailString(string details)
        {
            formDetailString = details;
        }

        public string getFormDetailString()
        {
            return formDetailString;
        }

        private void Details_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //print button
        private void button2_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder stringBuilderDescription = new StringBuilder(getFormDetailString());
            printView printD = new printView(stringBuilderDescription);
        }
     
    }
}
