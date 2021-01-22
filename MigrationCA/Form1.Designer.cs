namespace MigrationCA
{
    partial class MigrationMainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ValidationLbl = new System.Windows.Forms.Label();
            this.ScaleTbx = new System.Windows.Forms.TextBox();
            this.WidthTbx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.HeightTbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IterationLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StartStopBtn = new System.Windows.Forms.Button();
            this.DrawingPanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.PanelForSettings.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelForSettings
            // 
            this.PanelForSettings.Controls.Add(this.panel1);
            this.PanelForSettings.Controls.Add(this.IterationLbl);
            this.PanelForSettings.Controls.Add(this.label1);
            this.PanelForSettings.Controls.Add(this.StartStopBtn);
            this.PanelForSettings.Location = new System.Drawing.Point(0, 0);
            this.PanelForSettings.Name = "PanelForSettings";
            this.PanelForSettings.Size = new System.Drawing.Size(1251, 74);
            this.PanelForSettings.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.ValidationLbl);
            this.panel1.Controls.Add(this.ScaleTbx);
            this.panel1.Controls.Add(this.WidthTbx);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.HeightTbx);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 74);
            this.panel1.TabIndex = 7;
            // 
            // ValidationLbl
            // 
            this.ValidationLbl.AutoSize = true;
            this.ValidationLbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ValidationLbl.ForeColor = System.Drawing.Color.Red;
            this.ValidationLbl.Location = new System.Drawing.Point(83, 51);
            this.ValidationLbl.Name = "ValidationLbl";
            this.ValidationLbl.Size = new System.Drawing.Size(0, 19);
            this.ValidationLbl.TabIndex = 0;
            // 
            // ScaleTbx
            // 
            this.ScaleTbx.ForeColor = System.Drawing.Color.Silver;
            this.ScaleTbx.Location = new System.Drawing.Point(302, 28);
            this.ScaleTbx.Name = "ScaleTbx";
            this.ScaleTbx.Size = new System.Drawing.Size(60, 23);
            this.ScaleTbx.TabIndex = 9;
            this.ScaleTbx.Text = "Scale";
            this.ScaleTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ScaleTbx.Leave += new System.EventHandler(this.ScaleTbx_Leave);
            this.ScaleTbx.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ScaleTbx_MouseDown);
            // 
            // WidthTbx
            // 
            this.WidthTbx.ForeColor = System.Drawing.Color.Silver;
            this.WidthTbx.Location = new System.Drawing.Point(182, 28);
            this.WidthTbx.Name = "WidthTbx";
            this.WidthTbx.Size = new System.Drawing.Size(60, 23);
            this.WidthTbx.TabIndex = 9;
            this.WidthTbx.Text = "Width";
            this.WidthTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WidthTbx.Leave += new System.EventHandler(this.WidthTbx_Leave);
            this.WidthTbx.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WidthTbx_MouseDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(253, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Scale:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(128, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Width:";
            // 
            // HeightTbx
            // 
            this.HeightTbx.ForeColor = System.Drawing.Color.Silver;
            this.HeightTbx.Location = new System.Drawing.Point(62, 28);
            this.HeightTbx.Name = "HeightTbx";
            this.HeightTbx.Size = new System.Drawing.Size(60, 23);
            this.HeightTbx.TabIndex = 0;
            this.HeightTbx.Text = "Height";
            this.HeightTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HeightTbx.Leave += new System.EventHandler(this.HeightTbx_Leave);
            this.HeightTbx.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeightTbx_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Height:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(132, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "CA lattice setup";
            // 
            // IterationLbl
            // 
            this.IterationLbl.AutoSize = true;
            this.IterationLbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IterationLbl.Location = new System.Drawing.Point(565, 18);
            this.IterationLbl.Name = "IterationLbl";
            this.IterationLbl.Size = new System.Drawing.Size(17, 19);
            this.IterationLbl.TabIndex = 4;
            this.IterationLbl.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(484, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Iteration:";
            // 
            // StartStopBtn
            // 
            this.StartStopBtn.Location = new System.Drawing.Point(367, 2);
            this.StartStopBtn.Name = "StartStopBtn";
            this.StartStopBtn.Size = new System.Drawing.Size(100, 70);
            this.StartStopBtn.TabIndex = 2;
            this.StartStopBtn.Text = "Start/Stop Migration";
            this.StartStopBtn.UseVisualStyleBackColor = true;
            this.StartStopBtn.Click += new System.EventHandler(this.StartStopBtn_Click);
            // 
            // DrawingPanel
            // 
            this.DrawingPanel.Location = new System.Drawing.Point(0, 80);
            this.DrawingPanel.Name = "DrawingPanel";
            this.DrawingPanel.Size = new System.Drawing.Size(1251, 382);
            this.DrawingPanel.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MigrationMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 474);
            this.Controls.Add(this.DrawingPanel);
            this.Controls.Add(this.PanelForSettings);
            this.Name = "MigrationMainForm";
            this.Text = "Migration";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.PanelForSettings.ResumeLayout(false);
            this.PanelForSettings.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelForSettings;
        private System.Windows.Forms.Panel DrawingPanel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button StartStopBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ValidationLbl;
        private System.Windows.Forms.TextBox ScaleTbx;
        private System.Windows.Forms.TextBox WidthTbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox HeightTbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label IterationLbl;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

