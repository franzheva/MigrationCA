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
        public decimal[,] InitCA;
        public List<decimal[,]> CA = new List<decimal[,]>();
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
            CA.Add(MigrateAutomata(CA[IterationCounter]));
            IterationCounter += 1;
            IterationLbl.Text = IterationCounter.ToString();
            CreateBitmapAtRuntime(CA[IterationCounter]);
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
                        SetInitial();
                        CreateBitmapAtRuntime(InitCA);
                        CA.Add(InitCA);
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
                    int col = Convert.ToInt32((1 - A[i, j]) * 255);
                    flagGraphics.FillRectangle(new SolidBrush(Color.FromArgb(col, col, col)), j * CaScale, i * CaScale, CaScale, CaScale); 
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
                    : (!Regex.IsMatch(HeightTbx.Text, @"^[0-9]*$")
                    || !Regex.IsMatch(WidthTbx.Text, @"^[0-9]*$")
                    || !Regex.IsMatch(ScaleTbx.Text, @"^[0-9]*$"))  
                        ? "Only integers are allowed"
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
        public void SetInitial()
        {
            IterationCounter = 0;
            CA = new List<decimal[,]>();
            InitCA = new decimal[CaHeight, CaWidth];

            for (int i = 0; i < CaHeight; i++)
                for (int j = 0; j < CaWidth; j++)
                    InitCA[i, j] = (Convert.ToDecimal((new Random()).Next(100))) / 100;
        }
        public decimal[,] MigrateAutomata(decimal[,] automata)
        {
            var arrayRecalculated = new decimal[CaHeight,CaWidth];
            
            var migrationRate = new List<decimal[]>[CaHeight, CaWidth];
            for (int i = 0; i < CaHeight; i++)
                for (int j = 0; j < CaWidth; j++)
                {
                    migrationRate[i, j] = new List<decimal[]>();
                    var tettas = new decimal[9];
                    var sum = 0.0m;
                    for (int m = 0; m < 8; m++)
                    {
                        var div = 16.0m;
                        tettas[m] = 1/div;                        
                        sum += tettas[m];
                    }
                    tettas[8] = 0.5m;
                    sum += tettas[8];
                    for (int m = 0; m < 9; m++)
                        tettas[m] = tettas[m] / sum;
                    migrationRate[i, j].Add(tettas);                                       
                }
            for (int i = 0; i < CaHeight; i++)
                for (int j = 0; j < CaWidth; j++)
                {
                    var a = migrationRate[i, j].First()[0];
                    var b = migrationRate[i, j].First()[8];
                    arrayRecalculated[i,j]= (migrationRate[i, j].First()[0] * automata[(i - 1) != -1 ? (i - 1) : (CaHeight - 1), (j - 1) != -1 ? (j - 1) : (CaWidth - 1)] +
                        migrationRate[i, j].First()[1] * automata[(i - 1) != -1 ? (i - 1) : (CaHeight - 1), j] +
                        migrationRate[i, j].First()[2] * automata[(i - 1) != -1 ? (i - 1) : (CaHeight - 1), (j + 1) != CaWidth ? (j + 1) : 0] +
                        migrationRate[i, j].First()[7] * automata[i, (j - 1) != -1 ? (j - 1) : (CaWidth - 1)] +
                        migrationRate[i, j].First()[3] * automata[i, (j + 1) != CaWidth ? (j + 1) : 0] +
                        migrationRate[i, j].First()[6] * automata[(i + 1) != CaHeight ? (i + 1) : 0, (j - 1) != -1 ? (j - 1) : (CaWidth - 1)] +
                        migrationRate[i, j].First()[5] * automata[(i + 1) != CaHeight ? (i + 1) : 0, j] +
                        migrationRate[i, j].First()[4] * automata[(i + 1) != CaHeight ? (i + 1) : 0, (j + 1) != CaWidth ? (j + 1) : 0] +
                        migrationRate[i, j].First()[8] * automata[i,j]);
                }
            return arrayRecalculated;
        }
    }
}
