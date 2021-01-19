namespace MigrationCA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PanelForSettings = new System.Windows.Forms.Panel();
            this.IterationLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SettingsBtn = new System.Windows.Forms.Button();
            this.StartStopBtn = new System.Windows.Forms.Button();
            this.DrawingPanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PanelForSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelForSettings
            // 
            this.PanelForSettings.Controls.Add(this.IterationLbl);
            this.PanelForSettings.Controls.Add(this.label1);
            this.PanelForSettings.Controls.Add(this.SettingsBtn);
            this.PanelForSettings.Controls.Add(this.StartStopBtn);
            this.PanelForSettings.Location = new System.Drawing.Point(0, 0);
            this.PanelForSettings.Name = "PanelForSettings";
            this.PanelForSettings.Size = new System.Drawing.Size(1251, 104);
            this.PanelForSettings.TabIndex = 0;
            // 
            // IterationLbl
            // 
            this.IterationLbl.AutoSize = true;
            this.IterationLbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IterationLbl.Location = new System.Drawing.Point(190, 15);
            this.IterationLbl.Name = "IterationLbl";
            this.IterationLbl.Size = new System.Drawing.Size(17, 19);
            this.IterationLbl.TabIndex = 3;
            this.IterationLbl.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(120, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Iteration:";
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.Location = new System.Drawing.Point(1, 0);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(116, 50);
            this.SettingsBtn.TabIndex = 2;
            this.SettingsBtn.Text = "Settings";
            this.SettingsBtn.UseVisualStyleBackColor = true;
            this.SettingsBtn.Click += new System.EventHandler(this.StartStopBtn_Click);
            // 
            // StartStopBtn
            // 
            this.StartStopBtn.Location = new System.Drawing.Point(1, 53);
            this.StartStopBtn.Name = "StartStopBtn";
            this.StartStopBtn.Size = new System.Drawing.Size(116, 50);
            this.StartStopBtn.TabIndex = 2;
            this.StartStopBtn.Text = "Start/Stop Migration";
            this.StartStopBtn.UseVisualStyleBackColor = true;
            this.StartStopBtn.Click += new System.EventHandler(this.StartStopBtn_Click);
            // 
            // DrawingPanel
            // 
            this.DrawingPanel.Location = new System.Drawing.Point(0, 110);
            this.DrawingPanel.Name = "DrawingPanel";
            this.DrawingPanel.Size = new System.Drawing.Size(1251, 352);
            this.DrawingPanel.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 474);
            this.Controls.Add(this.DrawingPanel);
            this.Controls.Add(this.PanelForSettings);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.PanelForSettings.ResumeLayout(false);
            this.PanelForSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelForSettings;
        private System.Windows.Forms.Panel DrawingPanel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button StartStopBtn;
        private System.Windows.Forms.Label IterationLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SettingsBtn;
    }
}

