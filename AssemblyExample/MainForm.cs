using System;
using System.IO;
using System.Windows.Forms;

namespace BaseProjectSolidWorks2
{
    public partial class MainForm : Form
    {

        ProjectDocument pd = new ProjectDocument();

        public MainForm()
        {
            InitializeComponent();
            UpdateInput();
            PathToMufta.Text = Path.GetFullPath(ProjectDocument.workPath + ProjectDocument.asmName);
            SelectMufta.Filter = ProjectDocument.asmName + "|"
                + ProjectDocument.asmName + "|Любые(*.*)|*.*";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PathToMufta.Text.EndsWith(ProjectDocument.asmName))
            {
                UpdateInput();
                pd.Build();
                MessageBox.Show("Build finished");
            }
            else
            {
                MessageBox.Show("Выберите " + ProjectDocument.asmName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateInput();

        }

        private void UpdateInput()
        {
            pd.nominalTorque = Int32.Parse(NominalTorque.Text);
            pd.countFingers = Int32.Parse(Fingers.Text);
            pd.assemblyPath = PathToMufta.Text;
            pd.UpdateParams();
            MuftaParams.Text = $"Расчитанный диаметр {pd.calculatedDiameter * 1000.0:F2} мм"
                + Environment.NewLine +
                $"Принятый диаметр {pd.nominalDiameter * 1000.0} мм по ряду R20";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MuftaParams_Click(object sender, EventArgs e)
        {

        }

        private void OpenMufta_Click(object sender, EventArgs e)
        {
            if (SelectMufta.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = SelectMufta.FileName;

            PathToMufta.Text = filename;
        }
    }
}
