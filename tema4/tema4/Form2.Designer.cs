namespace tema4
{
    partial class Form2
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
            this.searchButton = new System.Windows.Forms.Button();
            this.cameraTxtBox = new System.Windows.Forms.TextBox();
            this.memoryTxtBox = new System.Windows.Forms.TextBox();
            this.osVerTxtBox = new System.Windows.Forms.TextBox();
            this.osTxtBox = new System.Windows.Forms.TextBox();
            this.modelTxtBox = new System.Windows.Forms.TextBox();
            this.brandTxtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.brandLbl = new System.Windows.Forms.Label();
            this.modelLbl = new System.Windows.Forms.Label();
            this.osLbl = new System.Windows.Forms.Label();
            this.osVerLbl = new System.Windows.Forms.Label();
            this.memoryLbl = new System.Windows.Forms.Label();
            this.cameraLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(132, 162);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 23);
            this.searchButton.TabIndex = 25;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // cameraTxtBox
            // 
            this.cameraTxtBox.Location = new System.Drawing.Point(132, 136);
            this.cameraTxtBox.Name = "cameraTxtBox";
            this.cameraTxtBox.Size = new System.Drawing.Size(100, 20);
            this.cameraTxtBox.TabIndex = 24;
            // 
            // memoryTxtBox
            // 
            this.memoryTxtBox.Location = new System.Drawing.Point(132, 110);
            this.memoryTxtBox.Name = "memoryTxtBox";
            this.memoryTxtBox.Size = new System.Drawing.Size(100, 20);
            this.memoryTxtBox.TabIndex = 23;
            // 
            // osVerTxtBox
            // 
            this.osVerTxtBox.Location = new System.Drawing.Point(132, 84);
            this.osVerTxtBox.Name = "osVerTxtBox";
            this.osVerTxtBox.Size = new System.Drawing.Size(100, 20);
            this.osVerTxtBox.TabIndex = 22;
            // 
            // osTxtBox
            // 
            this.osTxtBox.Location = new System.Drawing.Point(132, 58);
            this.osTxtBox.Name = "osTxtBox";
            this.osTxtBox.Size = new System.Drawing.Size(100, 20);
            this.osTxtBox.TabIndex = 21;
            // 
            // modelTxtBox
            // 
            this.modelTxtBox.Location = new System.Drawing.Point(132, 32);
            this.modelTxtBox.Name = "modelTxtBox";
            this.modelTxtBox.Size = new System.Drawing.Size(100, 20);
            this.modelTxtBox.TabIndex = 20;
            // 
            // brandTxtBox
            // 
            this.brandTxtBox.Location = new System.Drawing.Point(132, 6);
            this.brandTxtBox.Name = "brandTxtBox";
            this.brandTxtBox.Size = new System.Drawing.Size(100, 20);
            this.brandTxtBox.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Camera:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Memory:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "OS version:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Operating System:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Model:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Brand:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 210);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(219, 95);
            this.listBox1.TabIndex = 26;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // brandLbl
            // 
            this.brandLbl.AutoSize = true;
            this.brandLbl.Location = new System.Drawing.Point(285, 9);
            this.brandLbl.Name = "brandLbl";
            this.brandLbl.Size = new System.Drawing.Size(35, 13);
            this.brandLbl.TabIndex = 27;
            this.brandLbl.Text = "label7";
            // 
            // modelLbl
            // 
            this.modelLbl.AutoSize = true;
            this.modelLbl.Location = new System.Drawing.Point(285, 35);
            this.modelLbl.Name = "modelLbl";
            this.modelLbl.Size = new System.Drawing.Size(35, 13);
            this.modelLbl.TabIndex = 28;
            this.modelLbl.Text = "label8";
            // 
            // osLbl
            // 
            this.osLbl.AutoSize = true;
            this.osLbl.Location = new System.Drawing.Point(285, 61);
            this.osLbl.Name = "osLbl";
            this.osLbl.Size = new System.Drawing.Size(35, 13);
            this.osLbl.TabIndex = 29;
            this.osLbl.Text = "label9";
            // 
            // osVerLbl
            // 
            this.osVerLbl.AutoSize = true;
            this.osVerLbl.Location = new System.Drawing.Point(285, 87);
            this.osVerLbl.Name = "osVerLbl";
            this.osVerLbl.Size = new System.Drawing.Size(41, 13);
            this.osVerLbl.TabIndex = 30;
            this.osVerLbl.Text = "label10";
            // 
            // memoryLbl
            // 
            this.memoryLbl.AutoSize = true;
            this.memoryLbl.Location = new System.Drawing.Point(285, 113);
            this.memoryLbl.Name = "memoryLbl";
            this.memoryLbl.Size = new System.Drawing.Size(41, 13);
            this.memoryLbl.TabIndex = 31;
            this.memoryLbl.Text = "label11";
            // 
            // cameraLbl
            // 
            this.cameraLbl.AutoSize = true;
            this.cameraLbl.Location = new System.Drawing.Point(285, 139);
            this.cameraLbl.Name = "cameraLbl";
            this.cameraLbl.Size = new System.Drawing.Size(41, 13);
            this.cameraLbl.TabIndex = 32;
            this.cameraLbl.Text = "label12";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 321);
            this.Controls.Add(this.cameraLbl);
            this.Controls.Add(this.memoryLbl);
            this.Controls.Add(this.osVerLbl);
            this.Controls.Add(this.osLbl);
            this.Controls.Add(this.modelLbl);
            this.Controls.Add(this.brandLbl);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.cameraTxtBox);
            this.Controls.Add(this.memoryTxtBox);
            this.Controls.Add(this.osVerTxtBox);
            this.Controls.Add(this.osTxtBox);
            this.Controls.Add(this.modelTxtBox);
            this.Controls.Add(this.brandTxtBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Shown += new System.EventHandler(this.Form2_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox cameraTxtBox;
        private System.Windows.Forms.TextBox memoryTxtBox;
        private System.Windows.Forms.TextBox osVerTxtBox;
        private System.Windows.Forms.TextBox osTxtBox;
        private System.Windows.Forms.TextBox modelTxtBox;
        private System.Windows.Forms.TextBox brandTxtBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label brandLbl;
        private System.Windows.Forms.Label modelLbl;
        private System.Windows.Forms.Label osLbl;
        private System.Windows.Forms.Label osVerLbl;
        private System.Windows.Forms.Label memoryLbl;
        private System.Windows.Forms.Label cameraLbl;
    }
}