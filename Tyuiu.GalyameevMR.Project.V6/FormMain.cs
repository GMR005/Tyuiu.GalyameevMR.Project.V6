using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.GalyameevMR.Project.V6.Lib;

namespace Tyuiu.GalyameevMR.Project.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialog_GMR.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialog_GMR.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.";
        }
        static int rows;
        static int columns;
        static string openFilePath;
        DataService DataService = new DataService();
       
        public void buttonOpenPacient_GMR_Click(object sender, EventArgs e)
        {
            openFileDialog_GMR.ShowDialog();
            openFilePath = openFileDialog_GMR.FileName;
            string[,] arrayValues = new string[rows, columns];
            arrayValues = LoadFromFileData(openFilePath);
        }
        public static string[,] LoadFromFileData(string filePath)
        {
            string FileData = File.ReadAllText(filePath);

            FileData = FileData.Replace('\n', '\r');
            string[] lines = FileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            string[,] arrayValues = new string[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = line_r[c];
                }
            }
            return arrayValues;
        }
        public void buttonPacient_GKU_Click(object sender, EventArgs e)
        {
            dataGridViewRes_GMR.ColumnCount = columns;
            dataGridViewRes_GMR.RowCount = rows;
            dataGridViewRes_GMR.Rows[0].ReadOnly = true;
            dataGridViewRes_GMR.Columns[0].ReadOnly = true;

            string[,] arrayValues = new string[rows, columns];
            arrayValues = LoadFromFileData(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewRes_GMR.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = DataService.GetBase(openFilePath);
        }

        private void buttonDelete_GMR_Click(object sender, EventArgs e)
        {
                try
                {
                    if (dataGridViewRes_GMR.CurrentRow.Index >= 0)
                    {
                        int a = dataGridViewRes_GMR.CurrentRow.Index;
                    dataGridViewRes_GMR.Rows.Remove(dataGridViewRes_GMR.Rows[a]);
                        if (dataGridViewRes_GMR.Rows.Count == 1)
                        {
                        dataGridViewRes_GMR.Rows.Clear();
                        }
                    }
                    if (dataGridViewRes_GMR.Rows.Count <= 1)
                    {
                    buttonDelete_GMR.Enabled = false;
                    buttonDelete_GMR.Enabled = false;
                    buttonDelete_GMR.Enabled = false;
                    }
                    if (dataGridViewRes_GMR.Rows.Count > 1)
                    {
                    buttonDelete_GMR.Enabled = true;
                    }
                    buttonPacient_GKU.Enabled = false;

                }
                catch
                {
                    MessageBox.Show("Ошибка при удалении книги", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
         
        }
        private void buttonSavePacientBase_GKU_Click(object sender, EventArgs e)
        {
            saveFileDialog_GMR.FileName = "PacientBase.csv";
            saveFileDialog_GMR.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_GMR.ShowDialog();

            string path = saveFileDialog_GMR.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool FileExists = fileInfo.Exists;

            if (FileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewRes_GMR.RowCount;
            int columns = dataGridViewRes_GMR.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewRes_GMR.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewRes_GMR.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

    }
}
