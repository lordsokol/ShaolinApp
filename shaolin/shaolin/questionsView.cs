using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Configuration;
using System.Text;

namespace shaolin
{
	/// <summary>
	/// Summary description for questionsView.
	/// </summary>
	public class questionsView : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button BTNclose;
		private System.Windows.Forms.Label questionLable;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Label label1;
		public string belt = "";
		public int totalQuestions = 0;
		public string[] questionString;
		private System.Windows.Forms.RichTextBox questionsBox;
		private System.Windows.Forms.Button answersBtn;
		private System.Windows.Forms.Button questionsBtn;
		public string[] answerString;
		public StringBuilder questionStringB = new StringBuilder("");
		private System.Windows.Forms.Button button1;
		public StringBuilder answerStringB = new StringBuilder("");
		public bool showAnswers = false;

		public questionsView()
		{
			belt = Form1.beltLevel;

			switch (belt)
			{
				case "Yellow":
					totalQuestions = int.Parse(ConfigurationSettings.AppSettings["totalYellowQuestions"]);
					break;
				case "Blue":
					totalQuestions = int.Parse(ConfigurationSettings.AppSettings["totalBlueQuestions"]);
					break;
				case "Green":
					totalQuestions = int.Parse(ConfigurationSettings.AppSettings["totalGreenQuestions"]);
					break;
				default:
					totalQuestions = int.Parse(ConfigurationSettings.AppSettings["totalBrownQuestions"]);
					break;
			}

			questionString = new string[totalQuestions];
			answerString = new string[totalQuestions];

			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			populateLabels();
			showQuestions();
					
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(questionsView));
            this.BTNclose = new System.Windows.Forms.Button();
            this.questionLable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.questionsBox = new System.Windows.Forms.RichTextBox();
            this.answersBtn = new System.Windows.Forms.Button();
            this.questionsBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            // questionLable
            // 
            this.questionLable.BackColor = System.Drawing.Color.Transparent;
            this.questionLable.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLable.Location = new System.Drawing.Point(277, 72);
            this.questionLable.Name = "questionLable";
            this.questionLable.Size = new System.Drawing.Size(232, 24);
            this.questionLable.TabIndex = 10;
            this.questionLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Required Questions";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // questionsBox
            // 
            this.questionsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.questionsBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionsBox.Location = new System.Drawing.Point(40, 112);
            this.questionsBox.Name = "questionsBox";
            this.questionsBox.ReadOnly = true;
            this.questionsBox.Size = new System.Drawing.Size(704, 312);
            this.questionsBox.TabIndex = 18;
            this.questionsBox.Text = "";
            // 
            // answersBtn
            // 
            this.answersBtn.Location = new System.Drawing.Point(216, 432);
            this.answersBtn.Name = "answersBtn";
            this.answersBtn.Size = new System.Drawing.Size(120, 32);
            this.answersBtn.TabIndex = 19;
            this.answersBtn.Text = "Show Answers";
            this.answersBtn.Click += new System.EventHandler(this.answersBtn_Click);
            // 
            // questionsBtn
            // 
            this.questionsBtn.Location = new System.Drawing.Point(440, 432);
            this.questionsBtn.Name = "questionsBtn";
            this.questionsBtn.Size = new System.Drawing.Size(120, 32);
            this.questionsBtn.TabIndex = 20;
            this.questionsBtn.Text = "Hide Answers";
            this.questionsBtn.Click += new System.EventHandler(this.questionsBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 488);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 24);
            this.button1.TabIndex = 21;
            this.button1.Text = "Print";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // questionsView
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(787, 548);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.questionsBtn);
            this.Controls.Add(this.answersBtn);
            this.Controls.Add(this.questionsBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.questionLable);
            this.Controls.Add(this.BTNclose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "questionsView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Questions";
            this.ResumeLayout(false);

		}
		#endregion

		public void populateLabels()
		{
			int count = 0;
			int adjustedCounter = 0;

			this.questionLable.Text = "For " + belt + " Belts";

			for(count = 0; count < totalQuestions; count++)
			{
				adjustedCounter = count + 1;
				questionString[count] = ConfigurationSettings.AppSettings["question" + adjustedCounter.ToString()];
				answerString[count] = ConfigurationSettings.AppSettings["answer"  + adjustedCounter.ToString()];
			}

			loadQuestions();
			loadQuestionsAndAnswers();
		}

		public void showQuestions()
		{
			showAnswers = false;
			this.questionsBox.Text = questionStringB.ToString();
			
		}

		public void loadQuestions()
		{
			int count = 0;
			int questionNumber = 0;

			this.questionsBox.Text = "\n \n";
			
			for(count = 0; count < totalQuestions; count++)
			{
				questionNumber = count + 1;
				questionStringB.Append(questionNumber + ".  " + questionString[count] + "\n \n");
			}
		}

		public void loadQuestionsAndAnswers()
		{
			int count = 0;
			int questionNumber = 0;

			this.questionsBox.Text = "\n \n";
			
			for(count = 0; count < totalQuestions; count++)
			{
				questionNumber = count + 1;
				answerStringB.Append(questionNumber + ".  " + questionString[count] + "\n");
				answerStringB.Append("____________________________________________________________" + "\n");
				answerStringB.Append("          " + answerString[count] + "\n \n \n");
			}
		}

		public void showQuestionsAndAnswers()
		{
			this.questionsBox.Text = answerStringB.ToString();
		}

		private void BTNclose_Click(object sender, System.EventArgs e)
		{
			this.Dispose();
		}

		private void answersBtn_Click(object sender, System.EventArgs e)
		{
			showAnswers = true;
			showQuestionsAndAnswers();
		}

		private void questionsBtn_Click(object sender, System.EventArgs e)
		{
			showQuestions();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			if(showAnswers)
			{
				printView printD = new printView(answerStringB);
			}
			else
			{
				printView printD = new printView(questionStringB);
			}
			//printD.Show();
		}

	}
}
