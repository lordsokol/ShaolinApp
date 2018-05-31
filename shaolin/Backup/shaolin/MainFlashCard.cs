using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace shaolin
{
	/// <summary>
	/// Summary description for MainFlashCard.
	/// </summary>
	public class MainFlashCard : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button nextCardBtn;
		private System.Windows.Forms.Label label1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public string groupNameGlobal;
		public int numberOfItemsGlobal;
		public string[] dataGroupGlobal;
		private System.Windows.Forms.Label FlashCardFront1;
		private System.Windows.Forms.Label FlashCardBack1;
		private System.Windows.Forms.Label mainLable;
		private System.Windows.Forms.Label mainLableBeltLevel;
		private System.Windows.Forms.Button BTNclose;

		public int currentItem = 0;

		public MainFlashCard(string[] dataGroup, int numberOfItems, string groupName)
		{
			groupNameGlobal = groupName;
			numberOfItemsGlobal = numberOfItems;
			dataGroupGlobal = dataGroup; 

			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			this.mainLableBeltLevel.Text = Form1.beltLevel + " Belt";
			this.mainLable.Text = groupName;
			loadFlashCards();

			//test
			//MessageBox.Show("Item Number " + (numberOfItems).ToString() + " is : " + dataGroup[numberOfItems - 1] + "\n  Out of " + numberOfItems + " total " + groupName);

			this.Show();

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(MainFlashCard));
			this.nextCardBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.FlashCardFront1 = new System.Windows.Forms.Label();
			this.FlashCardBack1 = new System.Windows.Forms.Label();
			this.mainLable = new System.Windows.Forms.Label();
			this.mainLableBeltLevel = new System.Windows.Forms.Label();
			this.BTNclose = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// nextCardBtn
			// 
			this.nextCardBtn.BackColor = System.Drawing.Color.Brown;
			this.nextCardBtn.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.nextCardBtn.Location = new System.Drawing.Point(200, 408);
			this.nextCardBtn.Name = "nextCardBtn";
			this.nextCardBtn.Size = new System.Drawing.Size(128, 32);
			this.nextCardBtn.TabIndex = 1;
			this.nextCardBtn.Text = "Next Card";
			this.nextCardBtn.Click += new System.EventHandler(this.nextCardBtn_Click);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(496, 224);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(184, 48);
			this.label1.TabIndex = 3;
			this.label1.Text = "Click the card to flip it over.";
			// 
			// FlashCardFront1
			// 
			this.FlashCardFront1.BackColor = System.Drawing.Color.Peru;
			this.FlashCardFront1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.FlashCardFront1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.FlashCardFront1.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FlashCardFront1.Location = new System.Drawing.Point(80, 128);
			this.FlashCardFront1.Name = "FlashCardFront1";
			this.FlashCardFront1.Size = new System.Drawing.Size(344, 248);
			this.FlashCardFront1.TabIndex = 4;
			this.FlashCardFront1.Text = "Front";
			this.FlashCardFront1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.FlashCardFront1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FlashCardFront_Clicked);
			// 
			// FlashCardBack1
			// 
			this.FlashCardBack1.BackColor = System.Drawing.Color.PaleGoldenrod;
			this.FlashCardBack1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.FlashCardBack1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.FlashCardBack1.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FlashCardBack1.Location = new System.Drawing.Point(80, 128);
			this.FlashCardBack1.Name = "FlashCardBack1";
			this.FlashCardBack1.Size = new System.Drawing.Size(344, 248);
			this.FlashCardBack1.TabIndex = 5;
			this.FlashCardBack1.Text = "Back";
			this.FlashCardBack1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.FlashCardBack1.Visible = false;
			this.FlashCardBack1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FlashCardBack_Clicked);
			// 
			// mainLable
			// 
			this.mainLable.BackColor = System.Drawing.Color.Transparent;
			this.mainLable.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.mainLable.Location = new System.Drawing.Point(248, 64);
			this.mainLable.Name = "mainLable";
			this.mainLable.Size = new System.Drawing.Size(344, 24);
			this.mainLable.TabIndex = 6;
			this.mainLable.Text = "Main Lable";
			this.mainLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// mainLableBeltLevel
			// 
			this.mainLableBeltLevel.BackColor = System.Drawing.Color.Transparent;
			this.mainLableBeltLevel.Font = new System.Drawing.Font("Tempus Sans ITC", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.mainLableBeltLevel.Location = new System.Drawing.Point(320, 24);
			this.mainLableBeltLevel.Name = "mainLableBeltLevel";
			this.mainLableBeltLevel.Size = new System.Drawing.Size(192, 24);
			this.mainLableBeltLevel.TabIndex = 7;
			this.mainLableBeltLevel.Text = "Belt Level";
			this.mainLableBeltLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// BTNclose
			// 
			this.BTNclose.Location = new System.Drawing.Point(672, 488);
			this.BTNclose.Name = "BTNclose";
			this.BTNclose.Size = new System.Drawing.Size(64, 24);
			this.BTNclose.TabIndex = 8;
			this.BTNclose.Text = "Close";
			this.BTNclose.Click += new System.EventHandler(this.BTNclose_Click);
			// 
			// MainFlashCard
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(787, 548);
			this.Controls.Add(this.BTNclose);
			this.Controls.Add(this.mainLableBeltLevel);
			this.Controls.Add(this.mainLable);
			this.Controls.Add(this.FlashCardFront1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.nextCardBtn);
			this.Controls.Add(this.FlashCardBack1);
			this.Name = "MainFlashCard";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Shaolin Flash Cards";
			this.ResumeLayout(false);

		}
		#endregion

		public void loadFlashCards()
		{
			//Reset Flash Card if necessary
			this.FlashCardFront1.Visible = true;
			this.FlashCardBack1.Visible = false;

			if(groupNameGlobal == "Lohans")
			{
				this.FlashCardFront1.Text = groupNameGlobal + " " + (currentItem + 1).ToString();
				this.FlashCardBack1.Text = dataGroupGlobal[currentItem];
			}
			else if(groupNameGlobal == "Sparring Techniques")
			{
				this.FlashCardFront1.Text = groupNameGlobal + " " + (currentItem + 1).ToString();
				this.FlashCardBack1.Text = dataGroupGlobal[currentItem];
			}
			else if(groupNameGlobal == "Chin Na")
			{
				this.FlashCardFront1.Text = groupNameGlobal + " " + (currentItem + 1).ToString();
				this.FlashCardBack1.Text = dataGroupGlobal[currentItem];
			}
			else if(groupNameGlobal == "One Step Techniques")
			{
				if(currentItem < 9)
				{
					this.FlashCardFront1.Text = "One Step Sparring Techniques " + (currentItem + 1).ToString() + Environment.NewLine + "Ie Pu Tue Ta";
					this.FlashCardBack1.Text = dataGroupGlobal[currentItem];
				}
				else
				{
					this.FlashCardFront1.Text = "One Step Fighting Techniques " + (currentItem - 8).ToString() + Environment.NewLine + "Ie Pu Fa Shu";
					this.FlashCardBack1.Text = dataGroupGlobal[currentItem];
				}
			}
			
		}

		private void FlashCardFront_Clicked(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			System.Console.WriteLine("Front Clicked");
			this.FlashCardFront1.Visible = false;
			this.FlashCardBack1.Visible = true;
		}

		private void FlashCardBack_Clicked(object sender,  System.Windows.Forms.MouseEventArgs e)
		{
			System.Console.WriteLine("Back Clicked");
			this.FlashCardFront1.Visible = true;
			this.FlashCardBack1.Visible = false;
		}

		private void nextCardBtn_Click(object sender, System.EventArgs e)
		{
			object messageBoxObj = new object();

			if(currentItem < numberOfItemsGlobal - 1)
			{
				currentItem++;
				loadFlashCards();
			}
			else
			{
				messageBoxObj = MessageBox.Show("You've reached then end of the list! Do you want to go again?", "No more Cards.", System.Windows.Forms.MessageBoxButtons.YesNo);

				if(messageBoxObj.ToString().Equals("Yes"))
				{
					currentItem = 0;
					loadFlashCards();
				}
				else
				{
					this.Dispose();
				}
			}
		}

		private void BTNclose_Click(object sender, System.EventArgs e)
		{
			this.Dispose();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			//printView printD = new printView();
			//printD.Show();
		}

	}
}
