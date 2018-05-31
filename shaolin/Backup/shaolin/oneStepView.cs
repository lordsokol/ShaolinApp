using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Configuration;

namespace shaolin
{
	/// <summary>
	/// Summary description for oneStepView.
	/// </summary>
	public class oneStepView : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button BTNclose;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public string belt = "";
		private System.Windows.Forms.RichTextBox OneStepText;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label beltLabelTop;
		private System.Windows.Forms.Label OneStepLabel5;
		public string OneStep1 = "";
		public int totalOneSteps = 0;
		private System.Windows.Forms.Button flashCardBtn;
		public string[] OneStepString;

		public oneStepView()
		{
			//
			// Variables
			//
			belt = Form1.beltLevel;

			switch (belt)
			{
				case "Yellow":
					totalOneSteps = int.Parse(ConfigurationSettings.AppSettings["totalOneStepYellow"]);
					break;
				case "Blue":
					totalOneSteps = int.Parse(ConfigurationSettings.AppSettings["totalOneStepBlue"]);
					break;
				case "Green":
					totalOneSteps = int.Parse(ConfigurationSettings.AppSettings["totalOneStepGreen"]);
					break;
				default:
					totalOneSteps = int.Parse(ConfigurationSettings.AppSettings["totalOneStepBrown"]);
					break;
			}
					
			OneStepString = new string[totalOneSteps];
	
			//
			// Functions
			//
			InitializeComponent();
			OneStepString = loadData(OneStepString, totalOneSteps);
			this.Show();
					
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(oneStepView));
			this.BTNclose = new System.Windows.Forms.Button();
			this.OneStepText = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.beltLabelTop = new System.Windows.Forms.Label();
			this.OneStepLabel5 = new System.Windows.Forms.Label();
			this.flashCardBtn = new System.Windows.Forms.Button();
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
			// OneStepText
			// 
			this.OneStepText.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.OneStepText.Location = new System.Drawing.Point(32, 72);
			this.OneStepText.Name = "OneStepText";
			this.OneStepText.ReadOnly = true;
			this.OneStepText.Size = new System.Drawing.Size(720, 328);
			this.OneStepText.TabIndex = 3;
			this.OneStepText.Text = "";
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
			this.beltLabelTop.Location = new System.Drawing.Point(208, 8);
			this.beltLabelTop.Name = "beltLabelTop";
			this.beltLabelTop.Size = new System.Drawing.Size(416, 24);
			this.beltLabelTop.TabIndex = 8;
			this.beltLabelTop.Text = "One Step Techniques - Sparring and Fighting";
			// 
			// OneStepLabel5
			// 
			this.OneStepLabel5.BackColor = System.Drawing.Color.Transparent;
			this.OneStepLabel5.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.OneStepLabel5.Location = new System.Drawing.Point(232, 40);
			this.OneStepLabel5.Name = "OneStepLabel5";
			this.OneStepLabel5.Size = new System.Drawing.Size(368, 24);
			this.OneStepLabel5.TabIndex = 9;
			this.OneStepLabel5.Text = "One Step Techniques - Sparring and fighting";
			this.OneStepLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			// oneStepView
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.SystemColors.Control;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(787, 548);
			this.Controls.Add(this.flashCardBtn);
			this.Controls.Add(this.OneStepLabel5);
			this.Controls.Add(this.beltLabelTop);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.OneStepText);
			this.Controls.Add(this.BTNclose);
			this.Name = "oneStepView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "OneSteps";
			this.ResumeLayout(false);

		}
		#endregion

		private void BTNclose_Click(object sender, System.EventArgs e)
		{
			this.Dispose();
		}

		public string[] loadData(string[] OneStepStr, int totalOneSteps )
		{
			string appSettingsBuiltStringNameOneStep = "";
			string OneStepDisplayNameString = "One Step Sparring Technique  ";
			this.OneStepLabel5.Text = "For " + belt + " Belts";
			int FighTechInt = 0;

			for(int x = 0; x < totalOneSteps; x++)
			{
				appSettingsBuiltStringNameOneStep = "OneStep" + (x + 1).ToString(); 
				OneStepStr[x] = ConfigurationSettings.AppSettings[appSettingsBuiltStringNameOneStep];
	
				FighTechInt = x;
				if(x > 8)
				{
					OneStepDisplayNameString = "One Step Fighting Technique ";
					FighTechInt = x - 9;
				}

				this.OneStepText.AppendText(OneStepDisplayNameString + (FighTechInt + 1).ToString() + ":   " + OneStepStr[x]);
				this.OneStepText.AppendText(Environment.NewLine);
				this.OneStepText.AppendText(Environment.NewLine);
			}

			return OneStepStr;
		}

		private void flashCardBtn_Click(object sender, System.EventArgs e)
		{
			// open the flash card dialog
			MainFlashCard OneStepCards = new MainFlashCard(OneStepString, totalOneSteps, "One Step Techniques");
		}
	}
}