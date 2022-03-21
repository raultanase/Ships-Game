namespace Atestat_Vapoare
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.initializareJocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aseazaVapoareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aseazaVapoareCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startJocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.initializareJocToolStripMenuItem,
            this.startJocToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // initializareJocToolStripMenuItem
            // 
            this.initializareJocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aseazaVapoareToolStripMenuItem,
            this.aseazaVapoareCalculatorToolStripMenuItem});
            this.initializareJocToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initializareJocToolStripMenuItem.Name = "initializareJocToolStripMenuItem";
            this.initializareJocToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.initializareJocToolStripMenuItem.Text = "Initializare joc";
            // 
            // aseazaVapoareToolStripMenuItem
            // 
            this.aseazaVapoareToolStripMenuItem.Name = "aseazaVapoareToolStripMenuItem";
            this.aseazaVapoareToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.aseazaVapoareToolStripMenuItem.Text = "Aseaza vapoare";
            this.aseazaVapoareToolStripMenuItem.Click += new System.EventHandler(this.aseazaVapoareToolStripMenuItem_Click_1);
            // 
            // aseazaVapoareCalculatorToolStripMenuItem
            // 
            this.aseazaVapoareCalculatorToolStripMenuItem.Name = "aseazaVapoareCalculatorToolStripMenuItem";
            this.aseazaVapoareCalculatorToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.aseazaVapoareCalculatorToolStripMenuItem.Text = "Aseaza vapoare calculator";
            this.aseazaVapoareCalculatorToolStripMenuItem.Click += new System.EventHandler(this.aseazaVapoareCalculatorToolStripMenuItem_Click_1);
            // 
            // startJocToolStripMenuItem
            // 
            this.startJocToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startJocToolStripMenuItem.Name = "startJocToolStripMenuItem";
            this.startJocToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.startJocToolStripMenuItem.Text = "Start joc";
            this.startJocToolStripMenuItem.Click += new System.EventHandler(this.startJocToolStripMenuItem_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(686, 366);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem initializareJocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aseazaVapoareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aseazaVapoareCalculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startJocToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

