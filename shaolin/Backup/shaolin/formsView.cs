using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Configuration;

namespace shaolin
{
	/// <summary>
	/// Summary description for formsView.
	/// </summary>
	public class formsView : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button BTNclose;
		private System.Windows.Forms.Label formLable;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Label formLabel1;
		private System.Windows.Forms.Label formLabel2;
		private System.Windows.Forms.Label formLabel3;
		private System.Windows.Forms.Label formLabel4;
		private System.Windows.Forms.Label formLabel5;
		private System.Windows.Forms.Label formLabel6;
		private System.Windows.Forms.Label label1;
		public string belt = "";
		public int totalForms = 0;
		public string[] formString;

		public formsView()
		{
			belt = Form1.beltLevel;

			switch (belt)
			{
				case "Yellow":
					totalForms = int.Parse(ConfigurationSettings.AppSettings["totalYellowForms"]);
					break;
				case "Blue":
					totalForms = int.Parse(ConfigurationSettings.AppSettings["totalBlueForms"]);
					break;
				case "Green":
					totalForms = int.Parse(ConfigurationSettings.AppSettings["totalGreenForms"]);
					break;
				default:
					totalForms = int.Parse(ConfigurationSettings.AppSettings["totalBrownForms"]);
					break;
			}

			formString = new string[totalForms];

			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			populateLabels();
			
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(formsView));
			this.BTNclose = new System.Windows.Forms.Button();
			this.formLable = new System.Windows.Forms.Label();
			this.formLabel1 = new System.Windows.Forms.Label();
			this.formLabel2 = new System.Windows.Forms.Label();
			this.formLabel3 = new System.Windows.Forms.Label();
			this.formLabel4 = new System.Windows.Forms.Label();
			this.formLabel5 = new System.Windows.Forms.Label();
			this.formLabel6 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// BTNclose
			// 
			this.BTNclose.Location = new System.Drawing.Point(696, 512);
			this.BTNclose.Name = "BTNclose";
			this.BTNclose.Size = new System.Drawing.Size(64, 24);
			this.BTNclose.TabIndex = 3;
			this.BTNclose.Text = "Close";
			this.BTNclose.Click += new System.EventHandler(this.BTNclose_Click);
			// 
			// formLable
			// 
			this.formLable.BackColor = System.Drawing.Color.Transparent;
			this.formLable.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.formLable.Location = new System.Drawing.Point(277, 72);
			this.formLable.Name = "formLable";
			this.formLable.Size = new System.Drawing.Size(232, 24);
			this.formLable.TabIndex = 10;
			this.formLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// formLabel1
			// 
			this.formLabel1.BackColor = System.Drawing.Color.Transparent;
			this.formLabel1.Location = new System.Drawing.Point(24, 152);
			this.formLabel1.Name = "formLabel1";
			this.formLabel1.Size = new System.Drawing.Size(744, 40);
			this.formLabel1.TabIndex = 11;
			// 
			// formLabel2
			// 
			this.formLabel2.BackColor = System.Drawing.Color.Transparent;
			this.formLabel2.Location = new System.Drawing.Point(21, 208);
			this.formLabel2.Name = "formLabel2";
			this.formLabel2.Size = new System.Drawing.Size(744, 40);
			this.formLabel2.TabIndex = 12;
			// 
			// formLabel3
			// 
			this.formLabel3.BackColor = System.Drawing.Color.Transparent;
			this.formLabel3.Location = new System.Drawing.Point(21, 264);
			this.formLabel3.Name = "formLabel3";
			this.formLabel3.Size = new System.Drawing.Size(744, 40);
			this.formLabel3.TabIndex = 13;
			// 
			// formLabel4
			// 
			this.formLabel4.BackColor = System.Drawing.Color.Transparent;
			this.formLabel4.Location = new System.Drawing.Point(21, 320);
			this.formLabel4.Name = "formLabel4";
			this.formLabel4.Size = new System.Drawing.Size(744, 40);
			this.formLabel4.TabIndex = 14;
			// 
			// formLabel5
			// 
			this.formLabel5.BackColor = System.Drawing.Color.Transparent;
			this.formLabel5.Location = new System.Drawing.Point(21, 376);
			this.formLabel5.Name = "formLabel5";
			this.formLabel5.Size = new System.Drawing.Size(744, 40);
			this.formLabel5.TabIndex = 15;
			// 
			// formLabel6
			// 
			this.formLabel6.BackColor = System.Drawing.Color.Transparent;
			this.formLabel6.Location = new System.Drawing.Point(21, 432);
			this.formLabel6.Name = "formLabel6";
			this.formLabel6.Size = new System.Drawing.Size(744, 40);
			this.formLabel6.TabIndex = 16;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(277, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(232, 24);
			this.label1.TabIndex = 17;
			this.label1.Text = "Required Forms";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// formsView
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(787, 548);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.formLabel6);
			this.Controls.Add(this.formLabel5);
			this.Controls.Add(this.formLabel4);
			this.Controls.Add(this.formLabel3);
			this.Controls.Add(this.formLabel2);
			this.Controls.Add(this.formLabel1);
			this.Controls.Add(this.formLable);
			this.Controls.Add(this.BTNclose);
			this.Name = "formsView";
			this.Text = "Forms";
			this.ResumeLayout(false);

		}
		#endregion

		public void populateLabels()
		{

			this.formLable.Text = "For " + belt + " Belts";
	
			switch (totalForms)
			{
				case 0:
					formLabel1.Text = "There are no forms for white to yellow belt.";
					break;
				case 2:
					formLabel1.Text  = ConfigurationSettings.AppSettings["form1"];
					formLabel2.Text  = ConfigurationSettings.AppSettings["form2"];
					break;
				case 4:
					formLabel1.Text  = ConfigurationSettings.AppSettings["form1"];
					formLabel2.Text  = ConfigurationSettings.AppSettings["form2"];
					formLabel3.Text  = ConfigurationSettings.AppSettings["form3"];
					formLabel4.Text  = ConfigurationSettings.AppSettings["form4"];					
					break;
				case 6:
					formLabel1.Text  = ConfigurationSettings.AppSettings["form1"];
					formLabel2.Text  = ConfigurationSettings.AppSettings["form2"];
					formLabel3.Text  = ConfigurationSettings.AppSettings["form3"];
					formLabel4.Text  = ConfigurationSettings.AppSettings["form4"];
					formLabel5.Text  = ConfigurationSettings.AppSettings["form5"];
					formLabel6.Text  = ConfigurationSettings.AppSettings["form6"];					
					break;
				default:
					formLabel1.Text = "There are no forms for white to yellow belt.";
					break;
			}
		}

		private void BTNclose_Click(object sender, System.EventArgs e)
		{
			this.Dispose();
		}

	}
}
