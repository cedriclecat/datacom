namespace IPCAM
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
            this.BtnPlay = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.AMC = new AxAXISMEDIACONTROLLib.AxAxisMediaControl();
            this.BtnTest = new System.Windows.Forms.Button();
            this.BtnUp = new System.Windows.Forms.Button();
            this.BtnDown = new System.Windows.Forms.Button();
            this.BtnRight = new System.Windows.Forms.Button();
            this.BtnLeft = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AMC)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnPlay
            // 
            this.BtnPlay.Location = new System.Drawing.Point(1187, 12);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(151, 23);
            this.BtnPlay.TabIndex = 1;
            this.BtnPlay.Text = "Play";
            this.BtnPlay.UseVisualStyleBackColor = true;
            this.BtnPlay.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.Location = new System.Drawing.Point(1187, 41);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(151, 23);
            this.BtnStop.TabIndex = 2;
            this.BtnStop.Text = "Stop";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // AMC
            // 
            this.AMC.Enabled = true;
            this.AMC.Location = new System.Drawing.Point(12, 12);
            this.AMC.Name = "AMC";
            this.AMC.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("AMC.OcxState")));
            this.AMC.Size = new System.Drawing.Size(800, 600);
            this.AMC.TabIndex = 0;
            // 
            // BtnTest
            // 
            this.BtnTest.Location = new System.Drawing.Point(1187, 70);
            this.BtnTest.Name = "BtnTest";
            this.BtnTest.Size = new System.Drawing.Size(151, 23);
            this.BtnTest.TabIndex = 3;
            this.BtnTest.Text = "test";
            this.BtnTest.UseVisualStyleBackColor = true;
            this.BtnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // BtnUp
            // 
            this.BtnUp.Location = new System.Drawing.Point(1109, 135);
            this.BtnUp.Name = "BtnUp";
            this.BtnUp.Size = new System.Drawing.Size(52, 45);
            this.BtnUp.TabIndex = 4;
            this.BtnUp.Text = "Up";
            this.BtnUp.UseVisualStyleBackColor = true;
            this.BtnUp.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // BtnDown
            // 
            this.BtnDown.Location = new System.Drawing.Point(1109, 277);
            this.BtnDown.Name = "BtnDown";
            this.BtnDown.Size = new System.Drawing.Size(52, 45);
            this.BtnDown.TabIndex = 5;
            this.BtnDown.Text = "Down";
            this.BtnDown.UseVisualStyleBackColor = true;
            this.BtnDown.Click += new System.EventHandler(this.BtnDown_Click);
            // 
            // BtnRight
            // 
            this.BtnRight.Location = new System.Drawing.Point(1187, 203);
            this.BtnRight.Name = "BtnRight";
            this.BtnRight.Size = new System.Drawing.Size(52, 45);
            this.BtnRight.TabIndex = 6;
            this.BtnRight.Text = "Right";
            this.BtnRight.UseVisualStyleBackColor = true;
            this.BtnRight.Click += new System.EventHandler(this.BtnRight_Click);
            // 
            // BtnLeft
            // 
            this.BtnLeft.Location = new System.Drawing.Point(1025, 203);
            this.BtnLeft.Name = "BtnLeft";
            this.BtnLeft.Size = new System.Drawing.Size(52, 45);
            this.BtnLeft.TabIndex = 7;
            this.BtnLeft.Text = "Left";
            this.BtnLeft.UseVisualStyleBackColor = true;
            this.BtnLeft.Click += new System.EventHandler(this.BtnLeft_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 653);
            this.Controls.Add(this.BtnLeft);
            this.Controls.Add(this.BtnRight);
            this.Controls.Add(this.BtnDown);
            this.Controls.Add(this.BtnUp);
            this.Controls.Add(this.BtnTest);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnPlay);
            this.Controls.Add(this.AMC);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.AMC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxAXISMEDIACONTROLLib.AxAxisMediaControl AMC;
        private System.Windows.Forms.Button BtnPlay;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button BtnTest;
        private System.Windows.Forms.Button BtnUp;
        private System.Windows.Forms.Button BtnDown;
        private System.Windows.Forms.Button BtnRight;
        private System.Windows.Forms.Button BtnLeft;
    }
}

