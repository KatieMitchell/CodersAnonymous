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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.livesPanel = new System.Windows.Forms.Panel();
            this.loadingPic = new System.Windows.Forms.PictureBox();
            this.life1 = new System.Windows.Forms.PictureBox();
            this.life2 = new System.Windows.Forms.PictureBox();
            this.life3 = new System.Windows.Forms.PictureBox();
            this.pBoxCar = new System.Windows.Forms.PictureBox();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.livesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCar)).BeginInit();
            this.SuspendLayout();
            // 
            // livesPanel
            // 
            this.livesPanel.BackColor = System.Drawing.Color.Transparent;
            this.livesPanel.Controls.Add(this.life3);
            this.livesPanel.Controls.Add(this.life2);
            this.livesPanel.Controls.Add(this.life1);
            this.livesPanel.Controls.Add(this.pBoxCar);
            this.livesPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.livesPanel.Location = new System.Drawing.Point(0, 600);
            this.livesPanel.Name = "livesPanel";
            this.livesPanel.Size = new System.Drawing.Size(550, 100);
            this.livesPanel.TabIndex = 2;
            // 
            // loadingPic
            // 
            this.loadingPic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loadingPic.BackgroundImage")));
            this.loadingPic.Location = new System.Drawing.Point(0, 0);
            this.loadingPic.Name = "loadingPic";
            this.loadingPic.Size = new System.Drawing.Size(550, 700);
            this.loadingPic.TabIndex = 3;
            this.loadingPic.TabStop = false;
            this.loadingPic.Click += new System.EventHandler(this.loadingPic_Click);
            // 
            // life1
            // 
            this.life1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("life1.BackgroundImage")));
            this.life1.Location = new System.Drawing.Point(260, 20);
            this.life1.Name = "life1";
            this.life1.Size = new System.Drawing.Size(97, 61);
            this.life1.TabIndex = 0;
            this.life1.TabStop = false;
            // 
            // life2
            // 
            this.life2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("life2.BackgroundImage")));
            this.life2.Location = new System.Drawing.Point(356, 20);
            this.life2.Name = "life2";
            this.life2.Size = new System.Drawing.Size(97, 61);
            this.life2.TabIndex = 1;
            this.life2.TabStop = false;
            // 
            // life3
            // 
            this.life3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("life3.BackgroundImage")));
            this.life3.Location = new System.Drawing.Point(453, 20);
            this.life3.Name = "life3";
            this.life3.Size = new System.Drawing.Size(97, 61);
            this.life3.TabIndex = 2;
            this.life3.TabStop = false;
            // 
            // pBoxCar
            // 
            this.pBoxCar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pBoxCar.BackgroundImage")));
            this.pBoxCar.Location = new System.Drawing.Point(0, 20);
            this.pBoxCar.Name = "pBoxCar";
            this.pBoxCar.Size = new System.Drawing.Size(65, 60);
            this.pBoxCar.TabIndex = 3;
            this.pBoxCar.TabStop = false;
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.BackColor = System.Drawing.Color.Transparent;
            this.QuestionLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(189)))), ((int)(((byte)(175)))));
            this.QuestionLabel.Location = new System.Drawing.Point(107, 46);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(0, 28);
            this.QuestionLabel.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(550, 700);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.livesPanel);
            this.Controls.Add(this.loadingPic);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.livesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loadingPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel livesPanel;
        private System.Windows.Forms.PictureBox loadingPic;
        private System.Windows.Forms.PictureBox life3;
        private System.Windows.Forms.PictureBox life2;
        private System.Windows.Forms.PictureBox life1;
        private System.Windows.Forms.PictureBox pBoxCar;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.Timer animationTimer;
    }
}

