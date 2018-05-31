namespace shaolin
{
    partial class Details
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Details));
            this.descriptionArea = new System.Windows.Forms.TextBox();
            this.formLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // descriptionArea
            // 
            this.descriptionArea.BackColor = System.Drawing.Color.Beige;
            this.descriptionArea.Location = new System.Drawing.Point(57, 45);
            this.descriptionArea.Multiline = true;
            this.descriptionArea.Name = "descriptionArea";
            this.descriptionArea.ReadOnly = true;
            this.descriptionArea.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionArea.Size = new System.Drawing.Size(700, 466);
            this.descriptionArea.TabIndex = 0;
            // 
            // formLabel
            // 
            this.formLabel.AutoSize = true;
            this.formLabel.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.formLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formLabel.Location = new System.Drawing.Point(54, 20);
            this.formLabel.Name = "formLabel";
            this.formLabel.Size = new System.Drawing.Size(80, 17);
            this.formLabel.TabIndex = 1;
            this.formLabel.Text = "form label";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(710, 517);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 21);
            this.button1.TabIndex = 2;
            this.button1.Text = "close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(315, 517);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 20);
            this.button2.TabIndex = 3;
            this.button2.Text = "Export to Word Document";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::shaolin.Properties.Resources.tableBack;
            this.ClientSize = new System.Drawing.Size(787, 548);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.formLabel);
            this.Controls.Add(this.descriptionArea);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Details";
            this.Text = "Details";
            this.Load += new System.EventHandler(this.Details_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox descriptionArea;
        private System.Windows.Forms.Label formLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}