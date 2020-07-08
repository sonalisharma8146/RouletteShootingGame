namespace RouletteShootingGame
{
    partial class MainScreen
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
            this.pictureResult = new System.Windows.Forms.PictureBox();
            this.pictureProcess = new System.Windows.Forms.PictureBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSpin = new System.Windows.Forms.Button();
            this.buttonPress = new System.Windows.Forms.Button();
            this.lblRemaining = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProcess)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureResult
            // 
            this.pictureResult.Image = global::RouletteShootingGame.Properties.Resources.menwithgun;
            this.pictureResult.Location = new System.Drawing.Point(12, 38);
            this.pictureResult.Name = "pictureResult";
            this.pictureResult.Size = new System.Drawing.Size(400, 200);
            this.pictureResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureResult.TabIndex = 0;
            this.pictureResult.TabStop = false;
            // 
            // pictureProcess
            // 
            this.pictureProcess.Image = global::RouletteShootingGame.Properties.Resources.emptychamber;
            this.pictureProcess.Location = new System.Drawing.Point(625, 12);
            this.pictureProcess.Name = "pictureProcess";
            this.pictureProcess.Size = new System.Drawing.Size(300, 300);
            this.pictureProcess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureProcess.TabIndex = 1;
            this.pictureProcess.TabStop = false;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Tempus Sans ITC", 36F, System.Drawing.FontStyle.Bold);
            this.lblMessage.Location = new System.Drawing.Point(52, 361);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(706, 78);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "Click To Start The Game...";
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Tempus Sans ITC", 24F, System.Drawing.FontStyle.Bold);
            this.buttonStart.Location = new System.Drawing.Point(65, 463);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(398, 100);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Start Game";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Font = new System.Drawing.Font("Tempus Sans ITC", 24F, System.Drawing.FontStyle.Bold);
            this.buttonLoad.Location = new System.Drawing.Point(533, 463);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(372, 100);
            this.buttonLoad.TabIndex = 4;
            this.buttonLoad.Text = "Load the Bullet";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSpin
            // 
            this.buttonSpin.Font = new System.Drawing.Font("Tempus Sans ITC", 24F, System.Drawing.FontStyle.Bold);
            this.buttonSpin.Location = new System.Drawing.Point(65, 603);
            this.buttonSpin.Name = "buttonSpin";
            this.buttonSpin.Size = new System.Drawing.Size(398, 100);
            this.buttonSpin.TabIndex = 5;
            this.buttonSpin.Text = "Spin the Chamber";
            this.buttonSpin.UseVisualStyleBackColor = true;
            this.buttonSpin.Click += new System.EventHandler(this.buttonSpin_Click);
            // 
            // buttonPress
            // 
            this.buttonPress.Font = new System.Drawing.Font("Tempus Sans ITC", 24F, System.Drawing.FontStyle.Bold);
            this.buttonPress.Location = new System.Drawing.Point(533, 603);
            this.buttonPress.Name = "buttonPress";
            this.buttonPress.Size = new System.Drawing.Size(372, 100);
            this.buttonPress.TabIndex = 6;
            this.buttonPress.Text = "Press the Trigger";
            this.buttonPress.UseVisualStyleBackColor = true;
            this.buttonPress.Click += new System.EventHandler(this.buttonPress_Click);
            // 
            // lblRemaining
            // 
            this.lblRemaining.AutoSize = true;
            this.lblRemaining.Font = new System.Drawing.Font("Tempus Sans ITC", 20F, System.Drawing.FontStyle.Bold);
            this.lblRemaining.Location = new System.Drawing.Point(12, 267);
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.Size = new System.Drawing.Size(0, 45);
            this.lblRemaining.TabIndex = 7;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 731);
            this.Controls.Add(this.lblRemaining);
            this.Controls.Add(this.buttonPress);
            this.Controls.Add(this.buttonSpin);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.pictureProcess);
            this.Controls.Add(this.pictureResult);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roulette Shooting";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainScreen_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProcess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureResult;
        private System.Windows.Forms.PictureBox pictureProcess;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSpin;
        private System.Windows.Forms.Button buttonPress;
        private System.Windows.Forms.Label lblRemaining;
    }
}