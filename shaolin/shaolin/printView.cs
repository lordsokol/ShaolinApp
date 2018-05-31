using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Configuration;


namespace shaolin
{
	/// <summary>
	/// Summary description for printView.
	/// </summary>
	public class printView : System.Windows.Forms.Form
	{
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		public string questionsLocation = "";
		public string wordLocation = ConfigurationSettings.AppSettings["wordLocation"];
		public StringBuilder textToPrint = new StringBuilder("");
		public Process displayQuestion = new Process();
	
		public printView(System.Text.StringBuilder textParameter)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			autoPrint(textParameter);

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(printView));
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.button1 = new System.Windows.Forms.Button();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.SuspendLayout();
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(256, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(336, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "Close Word After printing is finished";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printView
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(9, 25);
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(787, 548);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "printView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Print Flash Cards";
            this.ResumeLayout(false);

		}
		#endregion

		public void autoPrint(System.Text.StringBuilder textParameter)
		{
			CreateQuestionsFile(textParameter);
			displayQuestionsFileFile();
			//this.Dispose();
		}

		public void CreateQuestionsFile(System.Text.StringBuilder textParameter)
		{
			string fileDirectory = ConfigurationSettings.AppSettings["wordFilePath"];
			string wordFileName = ConfigurationSettings.AppSettings["wordFileName"];
			string FILE_PATH = fileDirectory + wordFileName;
			questionsLocation = FILE_PATH;
								
			try
			{
				FileStream logFileStream = new FileStream(FILE_PATH, FileMode.CreateNew);
				logFileStream.Close();
			}
			catch (Exception e)
			{
				Console.WriteLine( e.ToString() );
			}
						
			using (StreamWriter sw = new StreamWriter(FILE_PATH)) 
			{
				sw.WriteLine("   ");
				sw.WriteLine(textParameter.ToString());
				sw.WriteLine(sw.NewLine);
				sw.WriteLine(" EOF ");
			}
		
		}

		private void displayQuestionsFileFile()
		{
	
			displayQuestion.StartInfo.FileName = "c:\\ShaolinQuestions.Doc";
			//displayQuestion.StartInfo.Arguments =  "d:\\ShaolinQuestions.Doc /q /n /mFilePrintDefault /mFileExit";
			//displayQuestion.StartInfo.UseShellExecute = true;
			displayQuestion.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
			displayQuestion.Start();
		

			/*
			System.Diagnostics.Process.Start(wordLocation, questionsLocation);
			System.Diagnostics.Process WordProcess = System.Diagnostics.Process.GetCurrentProcess();
			*/
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			displayQuestion.Dispose();
			this.Dispose();
		}

			
	}
}
