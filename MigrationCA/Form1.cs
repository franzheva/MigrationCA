using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MigrationCA
{
    public partial class Form1 : Form
    {
        public bool isFirstLaunch = true;
        public bool AllowRunMigration = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PanelForSettings_Position();
        }
        public void PanelForSettings_Position()
        {
            PanelForSettings.Width = this.Width;
            DrawingPanel.Location = new System.Drawing.Point(0, PanelForSettings.Height);
            DrawingPanel.Width = this.Width;
            DrawingPanel.Height = this.Height - PanelForSettings.Height;

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            PanelForSettings_Position();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //call migration recalculation
        }

        private void StartStopBtn_Click(object sender, EventArgs e)
        {
            if (AllowRunMigration)
            {
                if (isFirstLaunch)
                {
                    timer1.Enabled = true;
                    isFirstLaunch = false;
                }
                timer1.Enabled = true;
                AllowRunMigration = false;
            }
            else {
                timer1.Enabled = false;
                AllowRunMigration = true;
            }
        }
    }
}
