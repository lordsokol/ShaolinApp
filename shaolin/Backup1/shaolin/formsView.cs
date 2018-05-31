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
        private Label formLabel12;
        private Label formLabel11;
        private Label formLabel10;
        private Label formLabel9;
        private Label formLabel8;
        private Label formLabel7;
        private Label formLabel14;
        private Label formLabel13;
        private Label formLabel15;
        private Label formLabel30;
        private Label formLabel29;
        private Label formLabel28;
        private Label formLabel27;
        private Label formLabel26;
        private Label formLabel25;
        private Label formLabel24;
        private Label formLabel23;
        private Label formLabel22;
        private Label formLabel21;
        private Label formLabel20;
        private Label formLabel19;
        private Label formLabel18;
        private Label formLabel17;
        private Label formLabel16;
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
                case "Black":
                    totalForms = int.Parse(ConfigurationSettings.AppSettings["totalBlackForms"]);
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formsView));
            this.BTNclose = new System.Windows.Forms.Button();
            this.formLable = new System.Windows.Forms.Label();
            this.formLabel1 = new System.Windows.Forms.Label();
            this.formLabel2 = new System.Windows.Forms.Label();
            this.formLabel3 = new System.Windows.Forms.Label();
            this.formLabel4 = new System.Windows.Forms.Label();
            this.formLabel5 = new System.Windows.Forms.Label();
            this.formLabel6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.formLabel12 = new System.Windows.Forms.Label();
            this.formLabel11 = new System.Windows.Forms.Label();
            this.formLabel10 = new System.Windows.Forms.Label();
            this.formLabel9 = new System.Windows.Forms.Label();
            this.formLabel8 = new System.Windows.Forms.Label();
            this.formLabel7 = new System.Windows.Forms.Label();
            this.formLabel14 = new System.Windows.Forms.Label();
            this.formLabel13 = new System.Windows.Forms.Label();
            this.formLabel15 = new System.Windows.Forms.Label();
            this.formLabel30 = new System.Windows.Forms.Label();
            this.formLabel29 = new System.Windows.Forms.Label();
            this.formLabel28 = new System.Windows.Forms.Label();
            this.formLabel27 = new System.Windows.Forms.Label();
            this.formLabel26 = new System.Windows.Forms.Label();
            this.formLabel25 = new System.Windows.Forms.Label();
            this.formLabel24 = new System.Windows.Forms.Label();
            this.formLabel23 = new System.Windows.Forms.Label();
            this.formLabel22 = new System.Windows.Forms.Label();
            this.formLabel21 = new System.Windows.Forms.Label();
            this.formLabel20 = new System.Windows.Forms.Label();
            this.formLabel19 = new System.Windows.Forms.Label();
            this.formLabel18 = new System.Windows.Forms.Label();
            this.formLabel17 = new System.Windows.Forms.Label();
            this.formLabel16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTNclose
            // 
            this.BTNclose.Location = new System.Drawing.Point(701, 519);
            this.BTNclose.Name = "BTNclose";
            this.BTNclose.Size = new System.Drawing.Size(64, 24);
            this.BTNclose.TabIndex = 3;
            this.BTNclose.Text = "Close";
            this.BTNclose.Click += new System.EventHandler(this.BTNclose_Click);
            // 
            // formLable
            // 
            this.formLable.BackColor = System.Drawing.Color.Transparent;
            this.formLable.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formLable.Location = new System.Drawing.Point(277, 72);
            this.formLable.Name = "formLable";
            this.formLable.Size = new System.Drawing.Size(232, 24);
            this.formLable.TabIndex = 10;
            this.formLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formLabel1
            // 
            this.formLabel1.BackColor = System.Drawing.Color.Transparent;
            this.formLabel1.Location = new System.Drawing.Point(21, 25);
            this.formLabel1.Name = "formLabel1";
            this.formLabel1.Size = new System.Drawing.Size(372, 24);
            this.formLabel1.TabIndex = 11;
            this.formLabel1.MouseLeave += new System.EventHandler(this.mouseLeaveFormLabel1);
            this.formLabel1.Click += new System.EventHandler(this.formLabel1_Click);
            this.formLabel1.MouseEnter += new System.EventHandler(this.mouseEnterFormLabel1);
            // 
            // formLabel2
            // 
            this.formLabel2.BackColor = System.Drawing.Color.Transparent;
            this.formLabel2.Location = new System.Drawing.Point(21, 60);
            this.formLabel2.Name = "formLabel2";
            this.formLabel2.Size = new System.Drawing.Size(372, 24);
            this.formLabel2.TabIndex = 12;
            this.formLabel2.MouseLeave += new System.EventHandler(this.mouseLeaveFormLabel2);
            this.formLabel2.Click += new System.EventHandler(this.formLabel2_Click);
            this.formLabel2.MouseEnter += new System.EventHandler(this.mouseEnterFormLabel2);
            // 
            // formLabel3
            // 
            this.formLabel3.BackColor = System.Drawing.Color.Transparent;
            this.formLabel3.Location = new System.Drawing.Point(21, 96);
            this.formLabel3.Name = "formLabel3";
            this.formLabel3.Size = new System.Drawing.Size(372, 24);
            this.formLabel3.TabIndex = 13;
            this.formLabel3.MouseLeave += new System.EventHandler(this.mouseLeaveFormLabel3);
            this.formLabel3.Click += new System.EventHandler(this.formLabel3_Click);
            this.formLabel3.MouseEnter += new System.EventHandler(this.mouseEnterFormLabel3);
            // 
            // formLabel4
            // 
            this.formLabel4.BackColor = System.Drawing.Color.Transparent;
            this.formLabel4.Location = new System.Drawing.Point(21, 132);
            this.formLabel4.Name = "formLabel4";
            this.formLabel4.Size = new System.Drawing.Size(372, 24);
            this.formLabel4.TabIndex = 14;
            this.formLabel4.MouseLeave += new System.EventHandler(this.mouseLeaveFormLabel4);
            this.formLabel4.Click += new System.EventHandler(this.formLabel4_Click);
            this.formLabel4.MouseEnter += new System.EventHandler(this.mouseEnterFormLabel4);
            // 
            // formLabel5
            // 
            this.formLabel5.BackColor = System.Drawing.Color.Transparent;
            this.formLabel5.Location = new System.Drawing.Point(21, 168);
            this.formLabel5.Name = "formLabel5";
            this.formLabel5.Size = new System.Drawing.Size(372, 24);
            this.formLabel5.TabIndex = 15;
            this.formLabel5.MouseLeave += new System.EventHandler(this.mouseLeaveFormLabel5);
            this.formLabel5.Click += new System.EventHandler(this.formLabel5_Click);
            this.formLabel5.MouseEnter += new System.EventHandler(this.mouseEnterFormLabel5);
            // 
            // formLabel6
            // 
            this.formLabel6.BackColor = System.Drawing.Color.Transparent;
            this.formLabel6.Location = new System.Drawing.Point(21, 206);
            this.formLabel6.Name = "formLabel6";
            this.formLabel6.Size = new System.Drawing.Size(372, 24);
            this.formLabel6.TabIndex = 16;
            this.formLabel6.MouseLeave += new System.EventHandler(this.mouseLeaveFormLabel6);
            this.formLabel6.Click += new System.EventHandler(this.formLabel6_Click);
            this.formLabel6.MouseEnter += new System.EventHandler(this.mouseEnterFormLabel6);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Required Forms";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formLabel12
            // 
            this.formLabel12.BackColor = System.Drawing.Color.Transparent;
            this.formLabel12.Location = new System.Drawing.Point(21, 422);
            this.formLabel12.Name = "formLabel12";
            this.formLabel12.Size = new System.Drawing.Size(372, 24);
            this.formLabel12.TabIndex = 23;
            this.formLabel12.MouseLeave += new System.EventHandler(this.mouseLeaveFormLabel12);
            this.formLabel12.Click += new System.EventHandler(this.formLabel12_Click);
            this.formLabel12.MouseEnter += new System.EventHandler(this.mouseEnterFormLabel12);
            // 
            // formLabel11
            // 
            this.formLabel11.BackColor = System.Drawing.Color.Transparent;
            this.formLabel11.Location = new System.Drawing.Point(21, 384);
            this.formLabel11.Name = "formLabel11";
            this.formLabel11.Size = new System.Drawing.Size(372, 24);
            this.formLabel11.TabIndex = 22;
            this.formLabel11.MouseLeave += new System.EventHandler(this.mouseLeaveFormLabel11);
            this.formLabel11.Click += new System.EventHandler(this.formLabel11_Click);
            this.formLabel11.MouseEnter += new System.EventHandler(this.mouseEnterFormLabel11);
            // 
            // formLabel10
            // 
            this.formLabel10.BackColor = System.Drawing.Color.Transparent;
            this.formLabel10.Location = new System.Drawing.Point(21, 348);
            this.formLabel10.Name = "formLabel10";
            this.formLabel10.Size = new System.Drawing.Size(372, 24);
            this.formLabel10.TabIndex = 21;
            this.formLabel10.MouseLeave += new System.EventHandler(this.mouseLeaveFormLabel10);
            this.formLabel10.Click += new System.EventHandler(this.formLabel10_Click);
            this.formLabel10.MouseEnter += new System.EventHandler(this.mouseEnterFormLabel10);
            // 
            // formLabel9
            // 
            this.formLabel9.BackColor = System.Drawing.Color.Transparent;
            this.formLabel9.Location = new System.Drawing.Point(21, 312);
            this.formLabel9.Name = "formLabel9";
            this.formLabel9.Size = new System.Drawing.Size(372, 24);
            this.formLabel9.TabIndex = 20;
            this.formLabel9.MouseLeave += new System.EventHandler(this.mouseLeaveFormLabel9);
            this.formLabel9.Click += new System.EventHandler(this.formLabel9_Click);
            this.formLabel9.MouseEnter += new System.EventHandler(this.mouseEnterFormLabel9);
            // 
            // formLabel8
            // 
            this.formLabel8.BackColor = System.Drawing.Color.Transparent;
            this.formLabel8.Location = new System.Drawing.Point(21, 276);
            this.formLabel8.Name = "formLabel8";
            this.formLabel8.Size = new System.Drawing.Size(372, 24);
            this.formLabel8.TabIndex = 19;
            this.formLabel8.MouseLeave += new System.EventHandler(this.mouseLeaveFormLabel8);
            this.formLabel8.Click += new System.EventHandler(this.formLabel8_Click);
            this.formLabel8.MouseEnter += new System.EventHandler(this.mouseEnterFormLabel8);
            // 
            // formLabel7
            // 
            this.formLabel7.BackColor = System.Drawing.Color.Transparent;
            this.formLabel7.Location = new System.Drawing.Point(21, 241);
            this.formLabel7.Name = "formLabel7";
            this.formLabel7.Size = new System.Drawing.Size(372, 24);
            this.formLabel7.TabIndex = 18;
            this.formLabel7.MouseLeave += new System.EventHandler(this.mouseLeaveFormLabel7);
            this.formLabel7.Click += new System.EventHandler(this.formLabel7_Click);
            this.formLabel7.MouseEnter += new System.EventHandler(this.mouseEnterFormLabel7);
            // 
            // formLabel14
            // 
            this.formLabel14.BackColor = System.Drawing.Color.Transparent;
            this.formLabel14.Location = new System.Drawing.Point(21, 488);
            this.formLabel14.Name = "formLabel14";
            this.formLabel14.Size = new System.Drawing.Size(372, 24);
            this.formLabel14.TabIndex = 25;
            this.formLabel14.MouseLeave += new System.EventHandler(this.mouseLeaveFormLabel14);
            this.formLabel14.Click += new System.EventHandler(this.formLabel14_Click);
            this.formLabel14.MouseEnter += new System.EventHandler(this.mouseEnterFormLabel14);
            // 
            // formLabel13
            // 
            this.formLabel13.BackColor = System.Drawing.Color.Transparent;
            this.formLabel13.Location = new System.Drawing.Point(21, 456);
            this.formLabel13.Name = "formLabel13";
            this.formLabel13.Size = new System.Drawing.Size(372, 24);
            this.formLabel13.TabIndex = 24;
            this.formLabel13.MouseLeave += new System.EventHandler(this.mouseLeaveFormLabel13);
            this.formLabel13.Click += new System.EventHandler(this.formLabel13_Click);
            this.formLabel13.MouseEnter += new System.EventHandler(this.mouseEnterFormLabel13);
            // 
            // formLabel15
            // 
            this.formLabel15.BackColor = System.Drawing.Color.Transparent;
            this.formLabel15.Location = new System.Drawing.Point(21, 519);
            this.formLabel15.Name = "formLabel15";
            this.formLabel15.Size = new System.Drawing.Size(372, 24);
            this.formLabel15.TabIndex = 26;
            this.formLabel15.MouseLeave += new System.EventHandler(this.mouseLeaveFormLabel15);
            this.formLabel15.Click += new System.EventHandler(this.formLabel15_Click);
            this.formLabel15.MouseEnter += new System.EventHandler(this.mouseEnterFormLabel15);
            // 
            // formLabel30
            // 
            this.formLabel30.BackColor = System.Drawing.Color.Transparent;
            this.formLabel30.Location = new System.Drawing.Point(403, 519);
            this.formLabel30.Name = "formLabel30";
            this.formLabel30.Size = new System.Drawing.Size(282, 24);
            this.formLabel30.TabIndex = 41;
            // 
            // formLabel29
            // 
            this.formLabel29.BackColor = System.Drawing.Color.Transparent;
            this.formLabel29.Location = new System.Drawing.Point(403, 488);
            this.formLabel29.Name = "formLabel29";
            this.formLabel29.Size = new System.Drawing.Size(372, 24);
            this.formLabel29.TabIndex = 40;
            // 
            // formLabel28
            // 
            this.formLabel28.BackColor = System.Drawing.Color.Transparent;
            this.formLabel28.Location = new System.Drawing.Point(403, 456);
            this.formLabel28.Name = "formLabel28";
            this.formLabel28.Size = new System.Drawing.Size(372, 24);
            this.formLabel28.TabIndex = 39;
            // 
            // formLabel27
            // 
            this.formLabel27.BackColor = System.Drawing.Color.Transparent;
            this.formLabel27.Location = new System.Drawing.Point(403, 422);
            this.formLabel27.Name = "formLabel27";
            this.formLabel27.Size = new System.Drawing.Size(372, 24);
            this.formLabel27.TabIndex = 38;
            // 
            // formLabel26
            // 
            this.formLabel26.BackColor = System.Drawing.Color.Transparent;
            this.formLabel26.Location = new System.Drawing.Point(403, 384);
            this.formLabel26.Name = "formLabel26";
            this.formLabel26.Size = new System.Drawing.Size(372, 24);
            this.formLabel26.TabIndex = 37;
            this.formLabel26.MouseLeave += new System.EventHandler(this.mouseLeaveFormLabel26);
            this.formLabel26.Click += new System.EventHandler(this.formLabel26_Click);
            this.formLabel26.MouseEnter += new System.EventHandler(this.mouseEnterFormLabel26);
            // 
            // formLabel25
            // 
            this.formLabel25.BackColor = System.Drawing.Color.Transparent;
            this.formLabel25.Location = new System.Drawing.Point(403, 348);
            this.formLabel25.Name = "formLabel25";
            this.formLabel25.Size = new System.Drawing.Size(372, 24);
            this.formLabel25.TabIndex = 36;
            this.formLabel25.MouseLeave += new System.EventHandler(this.mouseLeaveFormLabel25);
            this.formLabel25.Click += new System.EventHandler(this.formLabel25_Click);
            this.formLabel25.MouseEnter += new System.EventHandler(this.mouseEnterFormLabel25);
            // 
            // formLabel24
            // 
            this.formLabel24.BackColor = System.Drawing.Color.Transparent;
            this.formLabel24.Location = new System.Drawing.Point(403, 312);
            this.formLabel24.Name = "formLabel24";
            this.formLabel24.Size = new System.Drawing.Size(372, 24);
            this.formLabel24.TabIndex = 35;
            this.formLabel24.MouseLeave += new System.EventHandler(this.mouseLeaveFormLabel24);
            this.formLabel24.Click += new System.EventHandler(this.formLabel24_Click);
            this.formLabel24.MouseEnter += new System.EventHandler(this.mouseEnterFormLabel24);
            // 
            // formLabel23
            // 
            this.formLabel23.BackColor = System.Drawing.Color.Transparent;
            this.formLabel23.Location = new System.Drawing.Point(403, 276);
            this.formLabel23.Name = "formLabel23";
            this.formLabel23.Size = new System.Drawing.Size(372, 24);
            this.formLabel23.TabIndex = 34;
            this.formLabel23.MouseLeave += new System.EventHandler(this.mouseLeaveFormLabel23);
            this.formLabel23.Click += new System.EventHandler(this.formLabel23_Click);
            this.formLabel23.MouseEnter += new System.EventHandler(this.mouseEnterFormLabel23);
            // 
            // formLabel22
            // 
            this.formLabel22.BackColor = System.Drawing.Color.Transparent;
            this.formLabel22.Location = new System.Drawing.Point(403, 241);
            this.formLabel22.Name = "formLabel22";
            this.formLabel22.Size = new System.Drawing.Size(372, 24);
            this.formLabel22.TabIndex = 33;
            this.formLabel22.MouseLeave += new System.EventHandler(this.mouseLeaveFormLabel22);
            this.formLabel22.Click += new System.EventHandler(this.formLabel22_Click);
            this.formLabel22.MouseEnter += new System.EventHandler(this.mouseEnterFormLabel22);
            // 
            // formLabel21
            // 
            this.formLabel21.BackColor = System.Drawing.Color.Transparent;
            this.formLabel21.Location = new System.Drawing.Point(403, 206);
            this.formLabel21.Name = "formLabel21";
            this.formLabel21.Size = new System.Drawing.Size(372, 24);
            this.formLabel21.TabIndex = 32;
            this.formLabel21.MouseLeave += new System.EventHandler(this.mouseLeaveFormLabel21);
            this.formLabel21.Click += new System.EventHandler(this.formLabel21_Click);
            this.formLabel21.MouseEnter += new System.EventHandler(this.mouseEnterFormLabel21);
            // 
            // formLabel20
            // 
            this.formLabel20.BackColor = System.Drawing.Color.Transparent;
            this.formLabel20.Location = new System.Drawing.Point(403, 168);
            this.formLabel20.Name = "formLabel20";
            this.formLabel20.Size = new System.Drawing.Size(372, 24);
            this.formLabel20.TabIndex = 31;
            this.formLabel20.MouseLeave += new System.EventHandler(this.mouseLeaveFormLabel20);
            this.formLabel20.Click += new System.EventHandler(this.formLabel20_Click);
            this.formLabel20.MouseEnter += new System.EventHandler(this.mouseEnterFormLabel20);
            // 
            // formLabel19
            // 
            this.formLabel19.BackColor = System.Drawing.Color.Transparent;
            this.formLabel19.Location = new System.Drawing.Point(403, 132);
            this.formLabel19.Name = "formLabel19";
            this.formLabel19.Size = new System.Drawing.Size(372, 24);
            this.formLabel19.TabIndex = 30;
            this.formLabel19.MouseLeave += new System.EventHandler(this.mouseLeaveFormLabel19);
            this.formLabel19.Click += new System.EventHandler(this.formLabel19_Click);
            this.formLabel19.MouseEnter += new System.EventHandler(this.mouseEnterFormLabel19);
            // 
            // formLabel18
            // 
            this.formLabel18.BackColor = System.Drawing.Color.Transparent;
            this.formLabel18.Location = new System.Drawing.Point(403, 96);
            this.formLabel18.Name = "formLabel18";
            this.formLabel18.Size = new System.Drawing.Size(372, 24);
            this.formLabel18.TabIndex = 29;
            this.formLabel18.MouseLeave += new System.EventHandler(this.mouseLeaveFormLabel18);
            this.formLabel18.Click += new System.EventHandler(this.formLabel18_Click);
            this.formLabel18.MouseEnter += new System.EventHandler(this.mouseEnterFormLabel18);
            // 
            // formLabel17
            // 
            this.formLabel17.BackColor = System.Drawing.Color.Transparent;
            this.formLabel17.Location = new System.Drawing.Point(403, 60);
            this.formLabel17.Name = "formLabel17";
            this.formLabel17.Size = new System.Drawing.Size(372, 24);
            this.formLabel17.TabIndex = 28;
            this.formLabel17.MouseLeave += new System.EventHandler(this.mouseLeaveFormLabel17);
            this.formLabel17.Click += new System.EventHandler(this.formLabel17_Click);
            this.formLabel17.MouseEnter += new System.EventHandler(this.mouseEnterFormLabel17);
            // 
            // formLabel16
            // 
            this.formLabel16.BackColor = System.Drawing.Color.Transparent;
            this.formLabel16.Location = new System.Drawing.Point(403, 25);
            this.formLabel16.Name = "formLabel16";
            this.formLabel16.Size = new System.Drawing.Size(372, 24);
            this.formLabel16.TabIndex = 27;
            this.formLabel16.MouseLeave += new System.EventHandler(this.mouseLeaveFormLabel16);
            this.formLabel16.Click += new System.EventHandler(this.formLabel16_Click);
            this.formLabel16.MouseEnter += new System.EventHandler(this.mouseEnterFormLabel16);
            // 
            // formsView
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(787, 548);
            this.Controls.Add(this.formLabel30);
            this.Controls.Add(this.formLabel29);
            this.Controls.Add(this.formLabel28);
            this.Controls.Add(this.formLabel27);
            this.Controls.Add(this.formLabel26);
            this.Controls.Add(this.formLabel25);
            this.Controls.Add(this.formLabel24);
            this.Controls.Add(this.formLabel23);
            this.Controls.Add(this.formLabel22);
            this.Controls.Add(this.formLabel21);
            this.Controls.Add(this.formLabel20);
            this.Controls.Add(this.formLabel19);
            this.Controls.Add(this.formLabel18);
            this.Controls.Add(this.formLabel17);
            this.Controls.Add(this.formLabel16);
            this.Controls.Add(this.formLabel15);
            this.Controls.Add(this.formLabel14);
            this.Controls.Add(this.formLabel13);
            this.Controls.Add(this.formLabel12);
            this.Controls.Add(this.formLabel11);
            this.Controls.Add(this.formLabel10);
            this.Controls.Add(this.formLabel9);
            this.Controls.Add(this.formLabel8);
            this.Controls.Add(this.formLabel7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.formLabel6);
            this.Controls.Add(this.formLabel5);
            this.Controls.Add(this.formLabel4);
            this.Controls.Add(this.formLabel3);
            this.Controls.Add(this.formLabel2);
            this.Controls.Add(this.formLabel1);
            this.Controls.Add(this.formLable);
            this.Controls.Add(this.BTNclose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formsView";
            this.Text = "Forms";
            this.ResumeLayout(false);

		}
		#endregion

		public void populateLabels()
		{

			//this.formLable.Text = "For " + belt + " Belts";
	
			switch (totalForms)
			{
				case 0:
                    formLabel1.Text = ConfigurationSettings.AppSettings["form1"];
                    formLabel2.Text = ConfigurationSettings.AppSettings["form2"];
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
                case 14:
                    formLabel1.Text = ConfigurationSettings.AppSettings["form1"];
                    formLabel2.Text = ConfigurationSettings.AppSettings["form2"];
                    formLabel3.Text = ConfigurationSettings.AppSettings["form3"];
                    formLabel4.Text = ConfigurationSettings.AppSettings["form4"];
                    formLabel5.Text = ConfigurationSettings.AppSettings["form5"];
                    formLabel6.Text = ConfigurationSettings.AppSettings["form6"];
                    formLabel7.Text = ConfigurationSettings.AppSettings["form7"];
                    formLabel8.Text = ConfigurationSettings.AppSettings["form8"];
                    formLabel9.Text = ConfigurationSettings.AppSettings["form9"];
                    formLabel10.Text = ConfigurationSettings.AppSettings["form10"];
                    formLabel11.Text = ConfigurationSettings.AppSettings["form11"];
                    formLabel12.Text = ConfigurationSettings.AppSettings["form12"];
                    formLabel13.Text = ConfigurationSettings.AppSettings["form13"];
                    formLabel14.Text = ConfigurationSettings.AppSettings["form14"];
                    formLabel15.Text = ConfigurationSettings.AppSettings["form15"];
                    formLabel16.Text = ConfigurationSettings.AppSettings["form16"];
                    formLabel17.Text = ConfigurationSettings.AppSettings["form17"];
                    formLabel18.Text = ConfigurationSettings.AppSettings["form18"];
                    formLabel19.Text = ConfigurationSettings.AppSettings["form19"];
                    formLabel20.Text = ConfigurationSettings.AppSettings["form20"];
                    formLabel21.Text = ConfigurationSettings.AppSettings["form21"];
                    formLabel22.Text = ConfigurationSettings.AppSettings["form22"];
                    break;
				default:
					formLabel1.Text = "Learn these forms.";
					break;
			}
        }

        #region Handlers form details
        /**
         *   onclicks for form details
         */
        //HANDLERS

        //formLabel1_Click
        private void formLabel1_Click(object sender, System.EventArgs e)
        {
            Details details = new Details("form1");
            details.Show();
        }

        private void formLabel2_Click(object sender, System.EventArgs e)
        {
            Details details = new Details("form2");
            details.Show();
        }

        private void formLabel3_Click(object sender, System.EventArgs e)
        {
            Details details = new Details("form3");
            details.Show();
        }

        private void formLabel4_Click(object sender, System.EventArgs e)
        {
            Details details = new Details("form4");
            details.Show();
        }

        private void formLabel5_Click(object sender, System.EventArgs e)
        {
            Details details = new Details("form5");
            details.Show();
        }

        private void formLabel6_Click(object sender, System.EventArgs e)
        {
            Details details = new Details("form6");
            details.Show();
        }
		
        private void formLabel7_Click(object sender, EventArgs e)
        {
            Details details = new Details("form7");
            details.Show();
        }

        private void formLabel8_Click(object sender, EventArgs e)
        {
            Details details = new Details("form8");
            details.Show();
        }
        private void formLabel9_Click(object sender, EventArgs e)
        {
            Details details = new Details("form9");
            details.Show();
        }
        private void formLabel10_Click(object sender, EventArgs e)
        {
            Details details = new Details("form10");
            details.Show();
        }
        private void formLabel11_Click(object sender, EventArgs e)
        {
            Details details = new Details("form11");
            details.Show();
        }

        private void formLabel12_Click(object sender, EventArgs e)
        {
            Details details = new Details("form12");
            details.Show();
        }

        private void formLabel13_Click(object sender, EventArgs e)
        {
            Details details = new Details("form13");
            details.Show();
        }

        private void formLabel14_Click(object sender, EventArgs e)
        {
            Details details = new Details("form14");
            details.Show();
        }

        private void formLabel15_Click(object sender, EventArgs e)
        {
            Details details = new Details("form15");
            details.Show();
        }

        private void formLabel16_Click(object sender, EventArgs e)
        {
            Details details = new Details("form16");
            details.Show();
        }

        private void formLabel17_Click(object sender, EventArgs e)
        {
            Details details = new Details("form17");
            details.Show();
        }

        private void formLabel18_Click(object sender, EventArgs e)
        {
            Details details = new Details("form18");
            details.Show();
        }

        private void formLabel19_Click(object sender, EventArgs e)
        {
            Details details = new Details("form19");
            details.Show();
        }

        private void formLabel20_Click(object sender, EventArgs e)
        {
            Details details = new Details("form20");
            details.Show();
        }

        private void formLabel21_Click(object sender, EventArgs e)
        {
            Details details = new Details("form21");
            details.Show();
        }

        private void formLabel22_Click(object sender, EventArgs e)
        {
            Details details = new Details("form22");
            details.Show();
        }

        private void formLabel23_Click(object sender, EventArgs e)
        {
            Details details = new Details("form23");
            details.Show();
        }

        private void formLabel24_Click(object sender, EventArgs e)
        {
            Details details = new Details("form24");
            details.Show();
        }

        private void formLabel25_Click(object sender, EventArgs e)
        {
            Details details = new Details("form25");
            details.Show();
        }

        private void formLabel26_Click(object sender, EventArgs e)
        {
            Details details = new Details("form26");
            details.Show();
        }

        private void BTNclose_Click(object sender, System.EventArgs e)
        {
            this.Dispose();
        }
        #endregion


        #region Handlers mouse over actions
        /**
         *   ouse overs for forms naviagation
         */

        //  Need a generic method to handle these....
        //mouseEnterFormLabel
        private void mouseEnterFormLabel1(object sender, EventArgs e)
        {
            this.formLabel1.ForeColor = Color.ForestGreen;
        }

        //mouseLeaveFormLabel
        private void mouseLeaveFormLabel1(object sender, EventArgs e)
        {
            this.formLabel1.ForeColor = Color.Black;
        }

        //mouseEnterFormLabel
        private void mouseEnterFormLabel2(object sender, EventArgs e)
        {
            this.formLabel2.ForeColor = Color.ForestGreen;
        }

        //mouseLeaveFormLabel
        private void mouseLeaveFormLabel2(object sender, EventArgs e)
        {
            this.formLabel2.ForeColor = Color.Black;
        }
        //mouseEnterFormLabel
        private void mouseEnterFormLabel3(object sender, EventArgs e)
        {
            this.formLabel3.ForeColor = Color.ForestGreen;
        }

        //mouseLeaveFormLabel
        private void mouseLeaveFormLabel3(object sender, EventArgs e)
        {
            this.formLabel3.ForeColor = Color.Black;
        }
        //mouseEnterFormLabel
        private void mouseEnterFormLabel4(object sender, EventArgs e)
        {
            this.formLabel4.ForeColor = Color.ForestGreen;
        }

        //mouseLeaveFormLabel
        private void mouseLeaveFormLabel4(object sender, EventArgs e)
        {
            this.formLabel4.ForeColor = Color.Black;
        }
        //mouseEnterFormLabel
        private void mouseEnterFormLabel5(object sender, EventArgs e)
        {
            this.formLabel5.ForeColor = Color.ForestGreen;
        }

        //mouseLeaveFormLabel
        private void mouseLeaveFormLabel5(object sender, EventArgs e)
        {
            this.formLabel5.ForeColor = Color.Black;
        }
        //mouseEnterFormLabel
        private void mouseEnterFormLabel6(object sender, EventArgs e)
        {
            this.formLabel6.ForeColor = Color.ForestGreen;
        }

        //mouseLeaveFormLabel
        private void mouseLeaveFormLabel6(object sender, EventArgs e)
        {
            this.formLabel6.ForeColor = Color.Black;
        }
        //mouseEnterFormLabel
        private void mouseEnterFormLabel7(object sender, EventArgs e)
        {
            this.formLabel7.ForeColor = Color.ForestGreen;
        }

        //mouseLeaveFormLabel
        private void mouseLeaveFormLabel7(object sender, EventArgs e)
        {
            this.formLabel7.ForeColor = Color.Black;
        }
        //mouseEnterFormLabel
        private void mouseEnterFormLabel8(object sender, EventArgs e)
        {
            this.formLabel8.ForeColor = Color.ForestGreen;
        }

        //mouseLeaveFormLabel
        private void mouseLeaveFormLabel8(object sender, EventArgs e)
        {
            this.formLabel8.ForeColor = Color.Black;
        }
        //mouseEnterFormLabel
        private void mouseEnterFormLabel9(object sender, EventArgs e)
        {
            this.formLabel9.ForeColor = Color.ForestGreen;
        }

        //mouseLeaveFormLabel
        private void mouseLeaveFormLabel9(object sender, EventArgs e)
        {
            this.formLabel9.ForeColor = Color.Black;
        }
        //mouseEnterFormLabel
        private void mouseEnterFormLabel10(object sender, EventArgs e)
        {
            this.formLabel10.ForeColor = Color.ForestGreen;
        }

        //mouseLeaveFormLabel
        private void mouseLeaveFormLabel10(object sender, EventArgs e)
        {
            this.formLabel10.ForeColor = Color.Black;
        }
        //mouseEnterFormLabel
        private void mouseEnterFormLabel11(object sender, EventArgs e)
        {
            this.formLabel11.ForeColor = Color.ForestGreen;
        }

        //mouseLeaveFormLabel
        private void mouseLeaveFormLabel11(object sender, EventArgs e)
        {
            this.formLabel11.ForeColor = Color.Black;
        }
        //mouseEnterFormLabel
        private void mouseEnterFormLabel12(object sender, EventArgs e)
        {
            this.formLabel12.ForeColor = Color.ForestGreen;
        }

        //mouseLeaveFormLabel
        private void mouseLeaveFormLabel12(object sender, EventArgs e)
        {
            this.formLabel12.ForeColor = Color.Black;
        }
        //mouseEnterFormLabel
        private void mouseEnterFormLabel13(object sender, EventArgs e)
        {
            this.formLabel13.ForeColor = Color.ForestGreen;
        }

        //mouseLeaveFormLabel
        private void mouseLeaveFormLabel13(object sender, EventArgs e)
        {
            this.formLabel13.ForeColor = Color.Black;
        }
        //mouseEnterFormLabel
        private void mouseEnterFormLabel14(object sender, EventArgs e)
        {
            this.formLabel14.ForeColor = Color.ForestGreen;
        }

        //mouseLeaveFormLabel
        private void mouseLeaveFormLabel14(object sender, EventArgs e)
        {
            this.formLabel14.ForeColor = Color.Black;
        }
        //mouseEnterFormLabel
        private void mouseEnterFormLabel15(object sender, EventArgs e)
        {
            this.formLabel15.ForeColor = Color.ForestGreen;
        }

        //mouseLeaveFormLabel
        private void mouseLeaveFormLabel15(object sender, EventArgs e)
        {
            this.formLabel15.ForeColor = Color.Black;
        }
        //mouseEnterFormLabel
        private void mouseEnterFormLabel16(object sender, EventArgs e)
        {
            this.formLabel16.ForeColor = Color.ForestGreen;
        }

        //mouseLeaveFormLabel
        private void mouseLeaveFormLabel16(object sender, EventArgs e)
        {
            this.formLabel16.ForeColor = Color.Black;
        }
        //mouseEnterFormLabel
        private void mouseEnterFormLabel17(object sender, EventArgs e)
        {
            this.formLabel17.ForeColor = Color.ForestGreen;
        }

        //mouseLeaveFormLabel
        private void mouseLeaveFormLabel17(object sender, EventArgs e)
        {
            this.formLabel17.ForeColor = Color.Black;
        }
        //mouseEnterFormLabel
        private void mouseEnterFormLabel18(object sender, EventArgs e)
        {
            this.formLabel18.ForeColor = Color.ForestGreen;
        }

        //mouseLeaveFormLabel
        private void mouseLeaveFormLabel18(object sender, EventArgs e)
        {
            this.formLabel18.ForeColor = Color.Black;
        }
        //mouseEnterFormLabel
        private void mouseEnterFormLabel19(object sender, EventArgs e)
        {
            this.formLabel19.ForeColor = Color.ForestGreen;
        }

        //mouseLeaveFormLabel
        private void mouseLeaveFormLabel19(object sender, EventArgs e)
        {
            this.formLabel19.ForeColor = Color.Black;
        }
        //mouseEnterFormLabel
        private void mouseEnterFormLabel20(object sender, EventArgs e)
        {
            this.formLabel20.ForeColor = Color.ForestGreen;
        }

        //mouseLeaveFormLabel
        private void mouseLeaveFormLabel20(object sender, EventArgs e)
        {
            this.formLabel20.ForeColor = Color.Black;
        }
        //mouseEnterFormLabel
        private void mouseEnterFormLabel21(object sender, EventArgs e)
        {
            this.formLabel21.ForeColor = Color.ForestGreen;
        }

        //mouseLeaveFormLabel
        private void mouseLeaveFormLabel21(object sender, EventArgs e)
        {
            this.formLabel21.ForeColor = Color.Black;
        }
        //mouseEnterFormLabel
        private void mouseEnterFormLabel22(object sender, EventArgs e)
        {
            this.formLabel22.ForeColor = Color.ForestGreen;
        }

        //mouseLeaveFormLabel
        private void mouseLeaveFormLabel22(object sender, EventArgs e)
        {
            this.formLabel22.ForeColor = Color.Black;
        }
        //mouseEnterFormLabel
        private void mouseEnterFormLabel23(object sender, EventArgs e)
        {
            this.formLabel23.ForeColor = Color.ForestGreen;
        }

        //mouseLeaveFormLabel
        private void mouseLeaveFormLabel23(object sender, EventArgs e)
        {
            this.formLabel23.ForeColor = Color.Black;
        }
        //mouseEnterFormLabel
        private void mouseEnterFormLabel24(object sender, EventArgs e)
        {
            this.formLabel24.ForeColor = Color.ForestGreen;
        }

        //mouseLeaveFormLabel
        private void mouseLeaveFormLabel24(object sender, EventArgs e)
        {
            this.formLabel24.ForeColor = Color.Black;
        }
        //mouseEnterFormLabel
        private void mouseEnterFormLabel25(object sender, EventArgs e)
        {
            this.formLabel25.ForeColor = Color.ForestGreen;
        }

        //mouseLeaveFormLabel
        private void mouseLeaveFormLabel25(object sender, EventArgs e)
        {
            this.formLabel25.ForeColor = Color.Black;
        }
        //mouseEnterFormLabel
        private void mouseEnterFormLabel26(object sender, EventArgs e)
        {
            this.formLabel26.ForeColor = Color.ForestGreen;
        }

        //mouseLeaveFormLabel
        private void mouseLeaveFormLabel26(object sender, EventArgs e)
        {
            this.formLabel26.ForeColor = Color.Black;
        }

        #endregion

    }
}
