namespace mazeGame
{
    partial class MenuControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.creditsBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Dock = System.Windows.Forms.DockStyle.Top;
            this.title.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro Blac", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Margin = new System.Windows.Forms.Padding(3, 50, 3, 50);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(800, 138);
            this.title.TabIndex = 0;
            this.title.Text = "Maze";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro Blac", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startBtn.Location = new System.Drawing.Point(265, 191);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(271, 81);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            // 
            // creditsBtn
            // 
            this.creditsBtn.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro Blac", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.creditsBtn.Location = new System.Drawing.Point(265, 290);
            this.creditsBtn.Name = "creditsBtn";
            this.creditsBtn.Size = new System.Drawing.Size(271, 81);
            this.creditsBtn.TabIndex = 2;
            this.creditsBtn.Text = "Credits";
            this.creditsBtn.UseVisualStyleBackColor = true;
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro Blac", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exitBtn.Location = new System.Drawing.Point(265, 395);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(271, 81);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            // 
            // MenuControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.creditsBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.title);
            this.Name = "MenuControl";
            this.Size = new System.Drawing.Size(800, 600);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button creditsBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}
