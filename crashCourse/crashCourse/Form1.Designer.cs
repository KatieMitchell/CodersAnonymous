namespace crashCourse
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
            this.gameArea = new System.Windows.Forms.Panel();
            this.card6 = new System.Windows.Forms.PictureBox();
            this.card5 = new System.Windows.Forms.PictureBox();
            this.card4 = new System.Windows.Forms.PictureBox();
            this.card3 = new System.Windows.Forms.PictureBox();
            this.card2 = new System.Windows.Forms.PictureBox();
            this.card1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gameArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.card6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameArea
            // 
            this.gameArea.BackColor = System.Drawing.Color.Black;
            this.gameArea.Controls.Add(this.card6);
            this.gameArea.Controls.Add(this.card5);
            this.gameArea.Controls.Add(this.card4);
            this.gameArea.Controls.Add(this.card3);
            this.gameArea.Controls.Add(this.card2);
            this.gameArea.Controls.Add(this.card1);
            this.gameArea.Location = new System.Drawing.Point(0, 100);
            this.gameArea.Name = "gameArea";
            this.gameArea.Size = new System.Drawing.Size(550, 500);
            this.gameArea.TabIndex = 1;
            // 
            // card6
            // 
            this.card6.Location = new System.Drawing.Point(300, 50);
            this.card6.Name = "card6";
            this.card6.Size = new System.Drawing.Size(200, 100);
            this.card6.TabIndex = 6;
            this.card6.TabStop = false;
            // 
            // card5
            // 
            this.card5.Location = new System.Drawing.Point(199, 274);
            this.card5.Name = "card5";
            this.card5.Size = new System.Drawing.Size(200, 100);
            this.card5.TabIndex = 4;
            this.card5.TabStop = false;
            // 
            // card4
            // 
            this.card4.Location = new System.Drawing.Point(191, 266);
            this.card4.Name = "card4";
            this.card4.Size = new System.Drawing.Size(200, 100);
            this.card4.TabIndex = 3;
            this.card4.TabStop = false;
            // 
            // card3
            // 
            this.card3.Location = new System.Drawing.Point(183, 258);
            this.card3.Name = "card3";
            this.card3.Size = new System.Drawing.Size(200, 100);
            this.card3.TabIndex = 2;
            this.card3.TabStop = false;
            // 
            // card2
            // 
            this.card2.Location = new System.Drawing.Point(175, 250);
            this.card2.Name = "card2";
            this.card2.Size = new System.Drawing.Size(200, 100);
            this.card2.TabIndex = 1;
            this.card2.TabStop = false;
            // 
            // card1
            // 
            this.card1.Location = new System.Drawing.Point(50, 50);
            this.card1.Name = "card1";
            this.card1.Size = new System.Drawing.Size(200, 100);
            this.card1.TabIndex = 0;
            this.card1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 600);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(550, 100);
            this.panel3.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gameArea);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 100);
            this.panel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 700);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gameArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.card6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel gameArea;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox card6;
        private System.Windows.Forms.PictureBox card5;
        private System.Windows.Forms.PictureBox card4;
        private System.Windows.Forms.PictureBox card3;
        private System.Windows.Forms.PictureBox card2;
        private System.Windows.Forms.PictureBox card1;
        private System.Windows.Forms.Panel panel1;
    }
}

