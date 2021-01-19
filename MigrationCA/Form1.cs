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
        public int IterationCounter = 0;
        PictureBox migrationPictureBox = new PictureBox();
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
            IterationCounter += 1;
            IterationLbl.Text = IterationCounter.ToString();
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
        public void CreateBitmapAtRuntime(decimal[,] A)
        {
           var  HeightField = f.HeightImg;
            WidthField = f.WidthImg;
            var scale = f.scale;
            migrationPictureBox.Size = new Size(WidthField * scale + 10, HeightField * scale + 10);
            
            DrawingPanel.Controls.Add(migrationPictureBox);
            Bitmap myAutomataField = new Bitmap(WidthField * scale, HeightField * scale);
            Graphics flagGraphics = Graphics.FromImage(myAutomataField);
            for (int j = 0; j < WidthField; j++)
            {
                for (int i = 0; i < HeightField; i++)
                {
                    int col = Convert.ToInt32((1 - A[i, j]) * 255); //Math.Abs(1 - A[j, i]) old version
                    flagGraphics.FillRectangle(new SolidBrush(Color.FromArgb(col, col, col)), j * scale, i * scale, scale, scale); //(col, col, col) try to (col, 0, 0)
                }
            }

            migrationPictureBox.Image = myAutomataField;
            
        }
    }
}
