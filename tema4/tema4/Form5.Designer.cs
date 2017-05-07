namespace tema4
{
    partial class Form5
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
            this.menu1 = new tema4.Menu();
            this.results1 = new tema4.Results();
            this.add1 = new tema4.Add();
            this.advancedSearch1 = new tema4.AdvancedSearch();
            this.SuspendLayout();
            // 
            // menu1
            // 
            this.menu1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.menu1.ForeColor = System.Drawing.Color.White;
            this.menu1.Location = new System.Drawing.Point(0, -2);
            this.menu1.Margin = new System.Windows.Forms.Padding(0);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(876, 37);
            this.menu1.TabIndex = 0;
            // 
            // results1
            // 
            this.results1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.results1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.results1.Location = new System.Drawing.Point(9, 44);
            this.results1.Margin = new System.Windows.Forms.Padding(0, 9, 0, 9);
            this.results1.Name = "results1";
            this.results1.Size = new System.Drawing.Size(857, 614);
            this.results1.TabIndex = 2;
            // 
            // add1
            // 
            this.add1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add1.AutoScroll = true;
            this.add1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.add1.Location = new System.Drawing.Point(9, 44);
            this.add1.Margin = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.add1.Name = "add1";
            this.add1.Size = new System.Drawing.Size(857, 614);
            this.add1.TabIndex = 3;
            // 
            // advancedSearch1
            // 
            this.advancedSearch1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.advancedSearch1.AutoScroll = true;
            this.advancedSearch1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.advancedSearch1.Location = new System.Drawing.Point(9, 44);
            this.advancedSearch1.Margin = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.advancedSearch1.MinimumSize = new System.Drawing.Size(500, 0);
            this.advancedSearch1.Name = "advancedSearch1";
            this.advancedSearch1.Size = new System.Drawing.Size(857, 614);
            this.advancedSearch1.TabIndex = 4;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(875, 667);
            this.Controls.Add(this.menu1);
            this.Controls.Add(this.advancedSearch1);
            this.Controls.Add(this.add1);
            this.Controls.Add(this.results1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.Shown += new System.EventHandler(this.Form5_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private Menu menu1;
        private Results results1;
        private Add add1;
        private AdvancedSearch advancedSearch1;
    }
}