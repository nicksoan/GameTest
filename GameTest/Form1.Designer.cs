namespace GameTest
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
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.player = new System.Windows.Forms.PictureBox();
            this.ground1 = new System.Windows.Forms.PictureBox();
            this.ground2 = new System.Windows.Forms.PictureBox();
            this.pauseMenu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pauseMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 1;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.SystemColors.ControlLight;
            this.player.Location = new System.Drawing.Point(100, 498);
            this.player.Margin = new System.Windows.Forms.Padding(0);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(100, 50);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // ground1
            // 
            this.ground1.AccessibleDescription = "ground";
            this.ground1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ground1.Location = new System.Drawing.Point(-11, 563);
            this.ground1.Margin = new System.Windows.Forms.Padding(0);
            this.ground1.Name = "ground1";
            this.ground1.Size = new System.Drawing.Size(473, 50);
            this.ground1.TabIndex = 1;
            this.ground1.TabStop = false;
            // 
            // ground2
            // 
            this.ground2.AccessibleDescription = "ground";
            this.ground2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ground2.Location = new System.Drawing.Point(483, 563);
            this.ground2.Margin = new System.Windows.Forms.Padding(0);
            this.ground2.Name = "ground2";
            this.ground2.Size = new System.Drawing.Size(1146, 50);
            this.ground2.TabIndex = 2;
            this.ground2.TabStop = false;
            // 
            // pauseMenu
            // 
            this.pauseMenu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pauseMenu.Location = new System.Drawing.Point(483, 49);
            this.pauseMenu.Name = "pauseMenu";
            this.pauseMenu.Size = new System.Drawing.Size(476, 349);
            this.pauseMenu.TabIndex = 3;
            this.pauseMenu.TabStop = false;
            this.pauseMenu.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1550, 820);
            this.Controls.Add(this.player);
            this.Controls.Add(this.ground2);
            this.Controls.Add(this.ground1);
            this.Controls.Add(this.pauseMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pauseMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox ground1;
        private System.Windows.Forms.PictureBox ground2;
        private System.Windows.Forms.PictureBox pauseMenu;
    }
}

