using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Configuration;

namespace shaolin
{
	/// <summary>
	/// Summary description for lohanView.
	/// </summary>
	public class lohanView : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button BTNclose;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public string belt = "";
		private System.Windows.Forms.RichTextBox LohanText;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label beltLabelTop;
		private System.Windows.Forms.Label lohanLabel5;
		public string lohan1 = "";
		public int totalLohans = 0;
		private System.Windows.Forms.Button flashCardBtn;
		private System.Windows.Forms.Button button1;
		public string[] lohanString;

		public lohanView()
		{
			//
			// Variables
            //
			belt = Form1.beltLevel;

			switch (belt)
			{
				case "Yellow":
					totalLohans = int.Parse(ConfigurationSettings.AppSettings["totalLohansYellow"]);
					break;
				case "Blue":
					totalLohans = int.Parse(ConfigurationSettings.AppSettings["totalLohansBlue"]);
					break;
				case "Green":
					totalLohans = int.Parse(ConfigurationSettings.AppSettings["totalLohansGreen"]);
					break;
				default:
					totalLohans = int.Parse(ConfigurationSettings.AppSettings["totalLohansBrown"]);
					break;
			}
					
			lohanString = new string[totalLohans];
	
			//
			// Functions
			//
			InitializeComponent();
			lohanString = loadData(lohanString, totalLohans);
			this.Show();

			//test
			//MessageBox.Show("Lohan Number " + (totalLohans - 1).ToString() + " is : " + lohanString[totalLohans - 1] );

			//
			// Build Screen
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(lohanView));
			this.BTNclose = new System.Windows.Forms.Button();
			this.LohanText = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.beltLabelTop = new System.Windows.Forms.Label();
			this.lohanLabel5 = new System.Windows.Forms.Label();
			this.flashCardBtn = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// BTNclose
			// 
			this.BTNclose.Location = new System.Drawing.Point(696, 496);
			this.BTNclose.Name = "BTNclose";
			this.BTNclose.Size = new System.Drawing.Size(64, 24);
			this.BTNclose.TabIndex = 2;
			this.BTNclose.Text = "Close";
			this.BTNclose.Click += new System.EventHandler(this.BTNclose_Click);
			// 
			// LohanText
			// 
			this.LohanText.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.LohanText.Location = new System.Drawing.Point(32, 72);
			this.LohanText.Name = "LohanText";
			this.LohanText.ReadOnly = true;
			this.LohanText.Size = new System.Drawing.Size(720, 328);
			this.LohanText.TabIndex = 3;
			this.LohanText.Text = "";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(256, 432);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 16);
			this.label1.TabIndex = 4;
			this.label1.Text = "(cs) = Cat Stance";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(256, 456);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 16);
			this.label2.TabIndex = 5;
			this.label2.Text = "(hs) = Horse Stance";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(400, 432);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(112, 16);
			this.label3.TabIndex = 6;
			this.label3.Text = "(bs) = Bow Stance";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(400, 456);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(112, 16);
			this.label4.TabIndex = 7;
			this.label4.Text = "(ns) = Natural Stance";
			// 
			// beltLabelTop
			// 
			this.beltLabelTop.BackColor = System.Drawing.Color.Transparent;
			this.beltLabelTop.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.beltLabelTop.Location = new System.Drawing.Point(280, 8);
			this.beltLabelTop.Name = "beltLabelTop";
			this.beltLabelTop.Size = new System.Drawing.Size(200, 24);
			this.beltLabelTop.TabIndex = 8;
			this.beltLabelTop.Text = "Lohan Short Forms";
			// 
			// lohanLabel5
			// 
			this.lohanLabel5.BackColor = System.Drawing.Color.Transparent;
			this.lohanLabel5.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lohanLabel5.Location = new System.Drawing.Point(256, 40);
			this.lohanLabel5.Name = "lohanLabel5";
			this.lohanLabel5.Size = new System.Drawing.Size(232, 24);
			this.lohanLabel5.TabIndex = 9;
			this.lohanLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// flashCardBtn
			// 
			this.flashCardBtn.Location = new System.Drawing.Point(336, 496);
			this.flashCardBtn.Name = "flashCardBtn";
			this.flashCardBtn.Size = new System.Drawing.Size(88, 24);
			this.flashCardBtn.TabIndex = 10;
			this.flashCardBtn.Text = "Flash Cards";
			this.flashCardBtn.Click += new System.EventHandler(this.flashCardBtn_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(72, 440);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(88, 24);
			this.button1.TabIndex = 11;
			this.button1.Text = "TEST";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// lohanView
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.SystemColors.Control;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(787, 548);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.flashCardBtn);
			this.Controls.Add(this.lohanLabel5);
			this.Controls.Add(this.beltLabelTop);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.LohanText);
			this.Controls.Add(this.BTNclose);
			this.Name = "lohanView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Lohans";
			this.ResumeLayout(false);

		}
		#endregion

		private void BTNclose_Click(object sender, System.EventArgs e)
		{
			this.Dispose();
		}

		public string[] loadData(string[] lohanStr, int totalLohans )
		{
			string appSettingsBuiltStringNameLohan = "";
			string LohanDisplayNameString = "Lohan ";
			this.lohanLabel5.Text = "For " + belt + " Belts";

			for(int x = 0; x < totalLohans; x++)
			{
				appSettingsBuiltStringNameLohan = "lohan" + (x + 1).ToString(); 
				lohanStr[x] = ConfigurationSettings.AppSettings[appSettingsBuiltStringNameLohan];

				this.LohanText.AppendText(LohanDisplayNameString + (x + 1).ToString() + ":   " + lohanStr[x]);
				this.LohanText.AppendText(Environment.NewLine);
				this.LohanText.AppendText(Environment.NewLine);
			}

			return lohanStr;
		}

		private void flashCardBtn_Click(object sender, System.EventArgs e)
		{
			// open the flash card dialog
			MainFlashCard LohanCards = new MainFlashCard(lohanString, totalLohans, "Lohans");
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			int b = -255;
			byte i = (byte)b;
			Console.WriteLine(i);
		}
	}
}
