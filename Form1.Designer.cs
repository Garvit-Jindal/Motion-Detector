namespace Project_FaceRecognition
{
    partial class FrmMain
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
            this.imgCamUser = new Emgu.CV.UI.ImageBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.picCapturedUser = new Emgu.CV.UI.ImageBox();
            this.btnAuthenticate = new System.Windows.Forms.Button();
            this.bckGroundTrainer = new System.ComponentModel.BackgroundWorker();
            this.lblTrainingStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgCamUser)).BeginInit();
            this.grpOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCapturedUser)).BeginInit();
            this.SuspendLayout();
            // 
            // imgCamUser
            // 
            this.imgCamUser.Location = new System.Drawing.Point(12, 41);
            this.imgCamUser.Name = "imgCamUser";
            this.imgCamUser.Size = new System.Drawing.Size(571, 556);
            this.imgCamUser.TabIndex = 2;
            this.imgCamUser.TabStop = false;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(137, 39);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(13, 13);
            this.lblMessage.TabIndex = 4;
            this.lblMessage.Text = "..";
            // 
            // grpOptions
            // 
            this.grpOptions.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpOptions.Controls.Add(this.picCapturedUser);
            this.grpOptions.Controls.Add(this.btnAuthenticate);
            this.grpOptions.Controls.Add(this.lblMessage);
            this.grpOptions.Location = new System.Drawing.Point(599, 41);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(367, 277);
            this.grpOptions.TabIndex = 5;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Options";
            // 
            // picCapturedUser
            // 
            this.picCapturedUser.Location = new System.Drawing.Point(29, 42);
            this.picCapturedUser.Name = "picCapturedUser";
            this.picCapturedUser.Size = new System.Drawing.Size(200, 200);
            this.picCapturedUser.TabIndex = 2;
            this.picCapturedUser.TabStop = false;
            // 
            // btnAuthenticate
            // 
            this.btnAuthenticate.Location = new System.Drawing.Point(0, 0);
            this.btnAuthenticate.Name = "btnAuthenticate";
            this.btnAuthenticate.Size = new System.Drawing.Size(75, 23);
            this.btnAuthenticate.TabIndex = 5;
            // 
            // lblTrainingStatus
            // 
            this.lblTrainingStatus.Location = new System.Drawing.Point(596, 9);
            this.lblTrainingStatus.Name = "lblTrainingStatus";
            this.lblTrainingStatus.Size = new System.Drawing.Size(100, 23);
            this.lblTrainingStatus.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(713, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 633);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTrainingStatus);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.imgCamUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgCamUser)).EndInit();
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCapturedUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imgCamUser;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.Button btnAuthenticate;
        private Emgu.CV.UI.ImageBox picCapturedUser;
        private System.ComponentModel.BackgroundWorker bckGroundTrainer;
        private System.Windows.Forms.Label lblTrainingStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

