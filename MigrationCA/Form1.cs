using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MigrationCA
{
    public partial class MigrationMainForm : Form
    {
        public bool isFirstLaunch = true;
        public bool AllowRunMigration = true;
        public int IterationCounter = 0;
        public bool isValid = false;
        public int CaWidth = 0;
        public int CaHeight = 0; 
        public int CaScale=0;
        PictureBox migrationPictureBox = new PictureBox();
        public MigrationMainForm()
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
                SettingsValidation();
                if (isValid)
                {
                    if (isFirstLaunch)
                    {
                        int.TryParse(HeightTbx.Text, out CaHeight);
                        int.TryParse(WidthTbx.Text, out CaWidth);
                        int.TryParse(ScaleTbx.Text, out CaScale);
                        timer1.Enabled = true;
                        isFirstLaunch = false;
                    }
                    timer1.Enabled = true;
                    AllowRunMigration = false;
                    HeightTbx.ReadOnly = true;
                    WidthTbx.ReadOnly = true;
                    ScaleTbx.ReadOnly = true;
                }
            }
            else
            {
                timer1.Enabled = false;
                HeightTbx.ReadOnly = false;
                WidthTbx.ReadOnly = false;
                ScaleTbx.ReadOnly = false;
                AllowRunMigration = true;
            }
            
        }
        public void CreateBitmapAtRuntime(decimal[,] A)
        {            
            migrationPictureBox.Size = new Size(CaWidth * CaScale + 10, CaHeight * CaScale + 10);
            DrawingPanel.Controls.Add(migrationPictureBox);
            Bitmap myAutomataField = new Bitmap(CaWidth * CaScale, CaHeight * CaScale);
            Graphics flagGraphics = Graphics.FromImage(myAutomataField);
            for (int j = 0; j < CaWidth; j++)
            {
                for (int i = 0; i < CaHeight; i++)
                {
                    int col = Convert.ToInt32((1 - A[i, j]) * 255); //Math.Abs(1 - A[j, i]) old version
                    flagGraphics.FillRectangle(new SolidBrush(Color.FromArgb(col, col, col)), j * CaScale, i * CaScale, CaScale, CaScale); //(col, col, col) try to (col, 0, 0)
                }
            }

            migrationPictureBox.Image = myAutomataField;

        }

        public void SettingsValidation()
        {
            ValidationLbl.Text = (HeightTbx.Text == string.Empty || HeightTbx.Text == "Height")
                || (WidthTbx.Text == string.Empty || WidthTbx.Text == "Width")
                || (ScaleTbx.Text == string.Empty || ScaleTbx.Text == "Scale")
                ? "Empty fields are not allowed"
                    : (!Regex.IsMatch(HeightTbx.Text, @"^[0-9]*?(\,)?[0-9]*$")
                    || !Regex.IsMatch(WidthTbx.Text, @"^[0-9]*?(\,)?[0-9]*$")
                    || !Regex.IsMatch(ScaleTbx.Text, @"^[0-9]*?(\,)?[0-9]*$"))  
                        ? "Only digitals are allowed"
                        :string.Empty;
           
            isValid = ValidationLbl.Text == string.Empty;
        }

        private void HeightTbx_MouseDown(object sender, MouseEventArgs e)
        {
            HeightTbx.Text = (HeightTbx.Text == string.Empty || HeightTbx.Text == "Height")? string.Empty:HeightTbx.Text;
            HeightTbx.ForeColor = Color.Black;
        }       

        private void HeightTbx_Leave(object sender, EventArgs e)
        {
            HeightTbx.ForeColor = HeightTbx.Text == string.Empty ? Color.Silver : Color.Black;
            HeightTbx.Text = HeightTbx.Text == string.Empty ? "Height" : HeightTbx.Text;
            isFirstLaunch = HeightTbx.Text != CaHeight.ToString();
        }

        private void WidthTbx_Leave(object sender, EventArgs e)
        {
            WidthTbx.ForeColor = WidthTbx.Text == string.Empty ? Color.Silver : Color.Black;
            WidthTbx.Text = WidthTbx.Text == string.Empty ? "Width" : WidthTbx.Text;
            isFirstLaunch = WidthTbx.Text != CaWidth.ToString();
        }

        private void WidthTbx_MouseDown(object sender, MouseEventArgs e)
        {
            WidthTbx.Text = (WidthTbx.Text == string.Empty || WidthTbx.Text == "Width") ? string.Empty : WidthTbx.Text;
            WidthTbx.ForeColor = Color.Black;
        }

        private void ScaleTbx_MouseDown(object sender, MouseEventArgs e)
        {
            ScaleTbx.Text = (ScaleTbx.Text == string.Empty || ScaleTbx.Text == "Scale") ? string.Empty : ScaleTbx.Text;
            ScaleTbx.ForeColor = Color.Black;
        }

        private void ScaleTbx_Leave(object sender, EventArgs e)
        {
            ScaleTbx.ForeColor = ScaleTbx.Text == string.Empty ? Color.Silver : Color.Black;
            ScaleTbx.Text = ScaleTbx.Text == string.Empty ? "Scale" : ScaleTbx.Text;
            isFirstLaunch = ScaleTbx.Text != CaScale.ToString();
        }
    }
}
