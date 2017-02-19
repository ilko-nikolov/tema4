namespace tema4
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.brandTxtBox = new System.Windows.Forms.TextBox();
            this.modelTxtBox = new System.Windows.Forms.TextBox();
            this.osTxtBox = new System.Windows.Forms.TextBox();
            this.osVerTxtBox = new System.Windows.Forms.TextBox();
            this.memoryTxtBox = new System.Windows.Forms.TextBox();
            this.cameraTxtBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Brand:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Operating System:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "OS version:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Memory:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Camera:";
            // 
            // brandTxtBox
            // 
            this.brandTxtBox.Location = new System.Drawing.Point(134, 13);
            this.brandTxtBox.Name = "brandTxtBox";
            this.brandTxtBox.Size = new System.Drawing.Size(293, 20);
            this.brandTxtBox.TabIndex = 6;
            this.brandTxtBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // modelTxtBox
            // 
            this.modelTxtBox.Location = new System.Drawing.Point(134, 39);
            this.modelTxtBox.Name = "modelTxtBox";
            this.modelTxtBox.Size = new System.Drawing.Size(293, 20);
            this.modelTxtBox.TabIndex = 7;
            this.modelTxtBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // osTxtBox
            // 
            this.osTxtBox.Location = new System.Drawing.Point(134, 65);
            this.osTxtBox.Name = "osTxtBox";
            this.osTxtBox.Size = new System.Drawing.Size(293, 20);
            this.osTxtBox.TabIndex = 8;
            this.osTxtBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // osVerTxtBox
            // 
            this.osVerTxtBox.Location = new System.Drawing.Point(134, 91);
            this.osVerTxtBox.Name = "osVerTxtBox";
            this.osVerTxtBox.Size = new System.Drawing.Size(293, 20);
            this.osVerTxtBox.TabIndex = 9;
            this.osVerTxtBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // memoryTxtBox
            // 
            this.memoryTxtBox.Location = new System.Drawing.Point(134, 117);
            this.memoryTxtBox.Name = "memoryTxtBox";
            this.memoryTxtBox.Size = new System.Drawing.Size(293, 20);
            this.memoryTxtBox.TabIndex = 10;
            this.memoryTxtBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cameraTxtBox
            // 
            this.cameraTxtBox.Location = new System.Drawing.Point(134, 143);
            this.cameraTxtBox.Name = "cameraTxtBox";
            this.cameraTxtBox.Size = new System.Drawing.Size(293, 20);
            this.cameraTxtBox.TabIndex = 11;
            this.cameraTxtBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(134, 169);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 23);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 227);
            this.Controls.Add(this.addButton);
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
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox brandTxtBox;
        private System.Windows.Forms.TextBox modelTxtBox;
        private System.Windows.Forms.TextBox osTxtBox;
        private System.Windows.Forms.TextBox osVerTxtBox;
        private System.Windows.Forms.TextBox memoryTxtBox;
        private System.Windows.Forms.TextBox cameraTxtBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}