using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Configuration;

namespace shaolin
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button visualTrainingButton;
        private IContainer components;
		private System.Windows.Forms.Label beltlable;
		//private System.Windows.Forms.ListBox beltListBox;
		private System.Windows.Forms.Button button8;

		//Public Variables
		public static string beltLevel = "none";
		private System.Windows.Forms.Label beltDisplayLabel;
		private System.Windows.Forms.Label belDisplaylabel2;
		public lohanView lohans;
		public spTechniquesView sparringTechniques;
		public chinNaView chinNas;
		public oneStepView oneSteps;
		public formsView forms;
		private System.Windows.Forms.MainMenu mainMenu1;
		public System.Windows.Forms.MenuItem menuItemFile;
		private System.Windows.Forms.MenuItem menuItemConfiguration;
		private System.Windows.Forms.MenuItem menuItemHelp;
		private System.Windows.Forms.MenuItem menuItemExit;
		private System.Windows.Forms.MenuItem menuItem1;
		public questionsView questions;

		public System.Windows.Forms.ListBox beltListBox = new System.Windows.Forms.ListBox();

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			changeBeltLevel();
	
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		public void changeBeltLevel()
		{
			beltLevel = ConfigurationSettings.AppSettings["beltLevel"];
			switch (beltLevel)
			{
				case "Yellow":
					this.beltListBox.SelectedIndex = 0;
					break;
				case "Blue":
					this.beltListBox.SelectedIndex = 1;
					break;
				case "Green":
					this.beltListBox.SelectedIndex = 2;
					break;
				case "3rd Brown":
					this.beltListBox.SelectedIndex = 3;
					break;
				case "2nd Brown":
					this.beltListBox.SelectedIndex = 4;
					break;
				case "1st Brown":
					this.beltListBox.SelectedIndex = 5;
					break;
				case "Black":
					this.beltListBox.SelectedIndex = 6;
					break;
				default:
					this.beltListBox.SelectedIndex = 0;
					break;
			}
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
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
		public void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.visualTrainingButton = new System.Windows.Forms.Button();
            this.beltlable = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.beltDisplayLabel = new System.Windows.Forms.Label();
            this.belDisplaylabel2 = new System.Windows.Forms.Label();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItemFile = new System.Windows.Forms.MenuItem();
            this.menuItemConfiguration = new System.Windows.Forms.MenuItem();
            this.menuItemExit = new System.Windows.Forms.MenuItem();
            this.menuItemHelp = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tempus Sans ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(96, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Lohans";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tempus Sans ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Maroon;
            this.button2.Location = new System.Drawing.Point(96, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Chin Na";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Tempus Sans ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Maroon;
            this.button3.Location = new System.Drawing.Point(96, 400);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Sparring Techniques";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Tempus Sans ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Maroon;
            this.button4.Location = new System.Drawing.Point(320, 360);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Forms";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Tempus Sans ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Maroon;
            this.button5.Location = new System.Drawing.Point(320, 296);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "One Step Techniques";
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Tempus Sans ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Maroon;
            this.button6.Location = new System.Drawing.Point(536, 344);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(120, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "Questions";
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // visualTrainingButton
            // 
            this.visualTrainingButton.Font = new System.Drawing.Font("Tempus Sans ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visualTrainingButton.ForeColor = System.Drawing.Color.Maroon;
            this.visualTrainingButton.Location = new System.Drawing.Point(536, 304);
            this.visualTrainingButton.Name = "visualTrainingButton";
            this.visualTrainingButton.Size = new System.Drawing.Size(120, 23);
            this.visualTrainingButton.TabIndex = 5;
            this.visualTrainingButton.Text = "Visual Training";
            this.visualTrainingButton.Click += new System.EventHandler(this.visualTrainingButton_Click);
            // 
            // beltlable
            // 
            this.beltlable.BackColor = System.Drawing.Color.Transparent;
            this.beltlable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.beltlable.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beltlable.ForeColor = System.Drawing.Color.Maroon;
            this.beltlable.Location = new System.Drawing.Point(64, 40);
            this.beltlable.Name = "beltlable";
            this.beltlable.Size = new System.Drawing.Size(120, 23);
            this.beltlable.TabIndex = 4;
            this.beltlable.Text = "Select Belt Level:";
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Tempus Sans ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.DarkRed;
            this.button8.Location = new System.Drawing.Point(656, 512);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(120, 23);
            this.button8.TabIndex = 2;
            this.button8.Text = "Close Program";
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // beltListBox
            // 
            this.beltListBox.BackColor = System.Drawing.Color.Silver;
            this.beltListBox.ForeColor = System.Drawing.Color.Maroon;
            this.beltListBox.Items.AddRange(new object[] {
															 "Yellow",
															 "Blue",
															 "Green",
															 "3rd Brown",
															 "2nd Brown",
															 "1st Brown",
															 "Black"});
            this.beltListBox.Location = new System.Drawing.Point(64, 64);
            this.beltListBox.Name = "beltListBox";
            this.beltListBox.Size = new System.Drawing.Size(120, 95);
            this.beltListBox.TabIndex = 3;
            this.beltListBox.SelectedIndexChanged += new System.EventHandler(this.beltListBox_SelectedIndexChanged);
	
            // 
            // beltDisplayLabel
            // 
            this.beltDisplayLabel.BackColor = System.Drawing.Color.Transparent;
            this.beltDisplayLabel.Location = new System.Drawing.Point(192, 64);
            this.beltDisplayLabel.Name = "beltDisplayLabel";
            this.beltDisplayLabel.Size = new System.Drawing.Size(100, 23);
            this.beltDisplayLabel.TabIndex = 1;
            // 
            // belDisplaylabel2
            // 
            this.belDisplaylabel2.BackColor = System.Drawing.Color.Transparent;
            this.belDisplaylabel2.Location = new System.Drawing.Point(280, 64);
            this.belDisplaylabel2.Name = "belDisplaylabel2";
            this.belDisplaylabel2.Size = new System.Drawing.Size(100, 23);
            this.belDisplaylabel2.TabIndex = 0;
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemFile,
            this.menuItemHelp});
            // 
            // menuItemFile
            // 
            this.menuItemFile.Index = 0;
            this.menuItemFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemConfiguration,
            this.menuItemExit});
            this.menuItemFile.Text = "File";
            // 
            // menuItemConfiguration
            // 
            this.menuItemConfiguration.Index = 0;
            this.menuItemConfiguration.Text = "Configuration";
            this.menuItemConfiguration.Click += new System.EventHandler(this.menuItemConfiguration_Click);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Index = 1;
            this.menuItemExit.Text = "Exit";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // menuItemHelp
            // 
            this.menuItemHelp.Index = 1;
            this.menuItemHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1});
            this.menuItemHelp.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
            this.menuItemHelp.Text = "Help";
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "About";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(785, 566);
            this.Controls.Add(this.belDisplaylabel2);
            this.Controls.Add(this.beltDisplayLabel);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.beltListBox);
            this.Controls.Add(this.beltlable);
            this.Controls.Add(this.visualTrainingButton);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Chinese Shaolin Kung Fu Requirements";
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void beltListBox_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			beltLevel = this.beltListBox.Text;
			beltDisplayLabel.Text = beltLevel;
			belDisplaylabel2.Visible = true;
			System.Console.WriteLine("Belt level is " + beltLevel);
		}

		private void button8_Click(object sender, System.EventArgs e)
		{
			this.Dispose();
		}

		//Lohan button clicked
		private void button1_Click(object sender, System.EventArgs e)
		{
			if( beltLevel == "none")
			{
				MessageBox.Show("Please select your Belt Level.");
			}
			else
			{
				lohans = new lohanView();
				lohans.Show();
			}
		}

		//Sparring techniques button clicked
		private void button3_Click(object sender, System.EventArgs e)
		{
			if( beltLevel == "none")
			{
				MessageBox.Show("Please select your Belt Level.");
			}
			else
			{
				sparringTechniques = new spTechniquesView();
				sparringTechniques.Show();
			}
		}

		//Chin Na Button Clicked
		private void button2_Click(object sender, System.EventArgs e)
		{
			if( beltLevel == "none")
			{
				MessageBox.Show("Please select your Belt Level.");
			}
			else
			{
				chinNas = new chinNaView();
				chinNas.Show();
			}
		
		}

		//One Step Button Clicked
		private void button5_Click(object sender, System.EventArgs e)
		{
			if( beltLevel == "none")
			{
				MessageBox.Show("Please select your Belt Level.");
			}
			else
			{
				oneSteps = new oneStepView();
				oneSteps.Show();
			}
		
		}
		
		//Forms button clicked
		private void button4_Click(object sender, System.EventArgs e)
		{
			if( beltLevel == "none")
			{
				MessageBox.Show("Please select your Belt Level.");
			}
			else
			{
				forms = new formsView();
				forms.Show();
			}		
		}

		//Questions Button Clicked
		private void button6_Click(object sender, System.EventArgs e)
		{
			if( beltLevel == "none")
			{
				MessageBox.Show("Please select your Belt Level.");
			}
			else
			{
				questions = new questionsView();
				questions.Show();
			}
		}

		private void menuItemExit_Click(object sender, System.EventArgs e)
		{
			this.Dispose();
		}

		private void menuItemConfiguration_Click(object sender, System.EventArgs e)
		{
			ConfigForm ConfigurationSettings = new ConfigForm(this);
			ConfigurationSettings.Show();
		}

		private void menuItem1_Click(object sender, System.EventArgs e)
		{
			helpText aboutThis = new helpText();
			aboutThis.Show();
		}

        private void visualTrainingButton_Click(object sender, EventArgs e)
        {
            VisualTraining vt = new VisualTraining();
            vt.Show();

            /**
             * 
             * 
             * 
              // 
            // beltListBox
            // 
            this.beltListBox.BackColor = System.Drawing.Color.Silver;
            this.beltListBox.ForeColor = System.Drawing.Color.Maroon;
            this.beltListBox.Items.AddRange(new object[] {
															 "Yellow",
															 "Blue",
															 "Green",
															 "3rd Brown",
															 "2nd Brown",
															 "1st Brown",
															 "Black"});
            this.beltListBox.Location = new System.Drawing.Point(64, 64);
            this.beltListBox.Name = "beltListBox";
            this.beltListBox.Size = new System.Drawing.Size(120, 95);
            this.beltListBox.TabIndex = 3;
            this.beltListBox.SelectedIndexChanged += new System.EventHandler(this.beltListBox_SelectedIndexChanged);
	
             
             *
            // 
            // Form1
            //
             this.Controls.Add(this.beltListBox);
             */
        }


  }
}
