using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Configuration;

namespace shaolin
{
	/// <summary>
	/// Summary description for spTechniquesView.
	/// </summary>
	public class spTechniquesView : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button BTNclose;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public string belt = "";
		private System.Windows.Forms.RichTextBox SpTechText;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label beltLabelTop;
		private System.Windows.Forms.Label SpTechLabel5;
		public string SpTech1 = "";
		public int totalSpTechniques = 0;
		private System.Windows.Forms.Button flashCardBtn;
		public string[] SpTechString;

		public spTechniquesView()
		{
			//
			// Variables
			//
			belt = Form1.beltLevel;

			switch (belt)
			{
				case "Yellow":
					totalSpTechniques = int.Parse(ConfigurationSettings.AppSettings["totalSpTechsYellow"]);
					break;
				case "Blue":
					totalSpTechniques = int.Parse(ConfigurationSettings.AppSettings["totalSpTechsBlue"]);
					break;
				case "Green":
					totalSpTechniques = int.Parse(ConfigurationSettings.AppSettings["totalSpTechsGreen"]);
					break;
				default:
					totalSpTechniques = int.Parse(ConfigurationSettings.AppSettings["totalSpTechsBrown"]);
					break;
			}
					
			SpTechString = new string[totalSpTechniques];
	
			//
			// Functions
			//
			InitializeComponent();
			SpTechString = loadData(SpTechString, totalSpTechniques);
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(spTechniquesView));
            this.BTNclose = new System.Windows.Forms.Button();
            this.SpTechText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.beltLabelTop = new System.Windows.Forms.Label();
            this.SpTechLabel5 = new System.Windows.Forms.Label();
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
            // SpTechText
            // 
            this.SpTechText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SpTechText.Location = new System.Drawing.Point(32, 72);
            this.SpTechText.Name = "SpTechText";
            this.SpTechText.ReadOnly = true;
            this.SpTechText.Size = new System.Drawing.Size(720, 328);
            this.SpTechText.TabIndex = 3;
            this.SpTechText.Text = "";
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
            this.beltLabelTop.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beltLabelTop.Location = new System.Drawing.Point(280, 8);
            this.beltLabelTop.Name = "beltLabelTop";
            this.beltLabelTop.Size = new System.Drawing.Size(200, 24);
            this.beltLabelTop.TabIndex = 8;
            this.beltLabelTop.Text = "Sparring Techniques";
            // 
            // SpTechLabel5
            // 
            this.SpTechLabel5.BackColor = System.Drawing.Color.Transparent;
            this.SpTechLabel5.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpTechLabel5.Location = new System.Drawing.Point(256, 40);
            this.SpTechLabel5.Name = "SpTechLabel5";
            this.SpTechLabel5.Size = new System.Drawing.Size(232, 24);
            this.SpTechLabel5.TabIndex = 9;
            this.SpTechLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // spTechniquesView
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(787, 548);
            this.Controls.Add(this.flashCardBtn);
            this.Controls.Add(this.SpTechLabel5);
            this.Controls.Add(this.beltLabelTop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SpTechText);
            this.Controls.Add(this.BTNclose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "spTechniquesView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SpTechs";
            this.ResumeLayout(false);

		}
		#endregion

		private void BTNclose_Click(object sender, System.EventArgs e)
		{
			this.Dispose();
		}

		public string[] loadData(string[] SpTechStr, int totalSpTechniques )
		{
			string appSettingsBuiltStringNameSpTech = "";
			string SpTechDisplayNameString = "Sparring Technique  ";
			this.SpTechLabel5.Text = "For " + belt + " Belts";
			
			for(int x = 0; x < totalSpTechniques; x++)
			{
				appSettingsBuiltStringNameSpTech = "SpTech" + (x + 1).ToString(); 
				SpTechStr[x] = ConfigurationSettings.AppSettings[appSettingsBuiltStringNameSpTech];

					this.SpTechText.AppendText(SpTechDisplayNameString + (x + 1).ToString() + ":   " + SpTechStr[x]);
				this.SpTechText.AppendText(Environment.NewLine);
				this.SpTechText.AppendText(Environment.NewLine);
			}

			return SpTechStr;
		}

		private void flashCardBtn_Click(object sender, System.EventArgs e)
		{
			// open the flash card dialog
			MainFlashCard SpTechCards = new MainFlashCard(SpTechString, totalSpTechniques, "Sparring Techniques");
		}
	}
}

