using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using System.Text;

namespace shaolin
{
	/// <summary>
	/// Summary description for ConfigForm.
	/// </summary>
	public class ConfigForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox beltListBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.ToolTip advancedSettingsToolTip;
		private System.Windows.Forms.Button button5;
		private System.ComponentModel.IContainer components;
		private string appConfigFilePath = "C:\\temp\\shaolin\\shaolin\\";
		public StringBuilder appConfigFileString = new StringBuilder();
		public Form1 mainAccess = new Form1();
			

		public ConfigForm(Form1 mainForm)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			mainAccess = mainForm;
			
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.beltListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.advancedSettingsToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tan;
            this.button1.Location = new System.Drawing.Point(224, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter your belt level:";
            // 
            // beltListBox
            // 
            this.beltListBox.BackColor = System.Drawing.Color.Tan;
            this.beltListBox.ForeColor = System.Drawing.Color.Black;
            this.beltListBox.ItemHeight = 16;
            this.beltListBox.Items.AddRange(new object[] {
            "Yellow",
            "Blue",
            "Green",
            "3rd Brown",
            "2nd Brown",
            "1st Brown",
            "Black"});
            this.beltListBox.Location = new System.Drawing.Point(51, 62);
            this.beltListBox.Name = "beltListBox";
            this.beltListBox.Size = new System.Drawing.Size(120, 84);
            this.beltListBox.TabIndex = 4;
            this.beltListBox.SelectedIndexChanged += new System.EventHandler(this.beltListBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(264, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "ADVANCED SETTINGS:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(264, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(224, 24);
            this.button2.TabIndex = 8;
            this.button2.Text = "Set Microsoft Word Path (location)";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(264, 112);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(224, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Set File Name for Test Questions";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(264, 152);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(224, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Set directory location for Test Questions";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(64, 152);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "Set Belt level";
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ConfigForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(536, 293);
            this.ControlBox = false;
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.beltListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuration Settings";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			mainAccess.Refresh();
			this.Dispose();
		}

		private void ConfigForm_Load(object sender, System.EventArgs e)
		{
		
		}

		private void beltListBox_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			string beltLevel = this.beltListBox.Text;
			System.Console.WriteLine("Belt level is " + beltLevel);

			//need to call a function that will write to an XML file
			//  i.e.  my app.config file.  See RoutBuilder application.

			//ConfigurationSettings.AppSettings["totalYellowForms"];
		}

		private void label4_Click(object sender, System.EventArgs e)
		{
		
		}

		public StringBuilder getAppConfigAsString(StringBuilder tempFileString)
		{
			StringBuilder newFile = new StringBuilder();
			
			int index = 0;
			
			//Open existing App.config file and add contents to a string
			StreamReader reader = new  StreamReader(appConfigFilePath + "App.config");
			try   
			{    
				do
				{
					tempFileString.Append(reader.ReadLine() + "\n");
					index++;
				} 
				while(reader.Peek() != -1);
			}      
         
			catch 
			{ 
				System.Console.WriteLine("File is empty");
			}

			finally
			{
				reader.Close();
			}
			
			return tempFileString;
		
		}

		public StringBuilder modifyAppCongfig(StringBuilder tempFileString, StringBuilder changeString)
		{
			string key = " ";
			string valueField = "";
			string usableChangeString = "";
			string oldValue = "";
			
			int endOfKey = 0;
			int startOfValue = 0;
			int endOfValue = 1;
	
			usableChangeString = changeString.ToString();
			endOfKey = usableChangeString.IndexOf(":");
			key = usableChangeString.Substring(0, endOfKey);
			oldValue = ConfigurationSettings.AppSettings[key];

			startOfValue = endOfKey + 1;
			endOfValue = usableChangeString.Length - 1;
			valueField = usableChangeString.Substring(startOfValue);

			//find the key in the app.config file
			string appConfigString = tempFileString.ToString();
			
			string valueInAppConfig = ConfigurationSettings.AppSettings[key];
			string replaceString = "";
			string newValueString = "";

			int endOfKeyInAppConfig = 0;
			int startOfValueInAppConfig = 0;
			int lengthOfReplaceKey = 0;
			
			endOfKeyInAppConfig = appConfigString.IndexOf(key) + key.Length;
			startOfValueInAppConfig = endOfKeyInAppConfig + 10;

			lengthOfReplaceKey = oldValue.Length + 7; // include the quotes

			replaceString = appConfigString.Substring(startOfValueInAppConfig);
			newValueString = valueField + "\" /> \n";
			newValueString += appConfigString.Substring(startOfValueInAppConfig + lengthOfReplaceKey);
	
			appConfigString = appConfigString.Replace(replaceString, newValueString);
			
			StringBuilder newString = new StringBuilder();
			newString.Append(appConfigString);

			return newString;
		}

		public int saveModifiedAppConfig(StringBuilder tempFileString)
		{
			StreamWriter writer = new StreamWriter(appConfigFilePath + "tempApp.config");

			//this writes to the new file.
			try   
			{ 
				writer.WriteLine(tempFileString);
			}
			catch 
			{ 
				System.Console.WriteLine("Error writing to file");
				return -1;
			}
			finally
			{
				writer.Close();
			}

			// must rename the new file as "App.config"
			File.SetAttributes(appConfigFilePath + "tempApp.config",System.IO.FileAttributes.Normal);
			File.Delete(appConfigFilePath + "App.config");
			File.Move(appConfigFilePath + "tempApp.config", appConfigFilePath + "App.config");
			return 1;
		}

		//Set belt level button clicked
		private void button5_Click(object sender, System.EventArgs e)
		{
			StringBuilder itemChanged = new StringBuilder();
			int rc = 1;

			itemChanged.Append("beltLevel:");
			itemChanged.Append(this.beltListBox.SelectedItem);
				
			appConfigFileString = getAppConfigAsString(appConfigFileString);

			//make changes
			appConfigFileString = modifyAppCongfig(appConfigFileString, itemChanged);

			// rc is return Code  1 is success -1 is fail
			rc = saveModifiedAppConfig(appConfigFileString);

			// now change the displayed belt level
			string newSelection = this.beltListBox.SelectedItem.ToString();
			newSelection = ConfigurationSettings.AppSettings["beltLevel"];
			switch (newSelection)
			{
				case "Yellow":
					mainAccess.beltListBox.SelectedIndex = 0;
					break;
				case "Blue":
					mainAccess.beltListBox.SelectedIndex = 1;
					break;
				case "Green":
					mainAccess.beltListBox.SelectedIndex = 2;
					break;
				case "3rd Brown":
					mainAccess.beltListBox.SelectedIndex = 3;
					break;
				case "2nd Brown":
					mainAccess.beltListBox.SelectedIndex = 4;
					break;
				case "1st Brown":
					mainAccess.beltListBox.SelectedIndex = 5;
					break;
				case "Black":
					mainAccess.beltListBox.SelectedIndex = 6;
					break;
				default:
					mainAccess.beltListBox.SelectedIndex = 0;
					break;
			}

			mainAccess.Refresh();
			showMessage();
							
		}
		
		public void showMessage()
		{
			MessageBox.Show(null, "You will have to restart your application for the changes to take effect.", "Notification");

		}
	}

}
