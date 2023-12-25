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
            string FileData = File.ReadAllText(filePath, Encoding.UTF8);

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
            this.chartiLLness_GMR.ChartAreas[0].AxisX.Title = "Болезнь";
            this.chartiLLness_GMR.ChartAreas[0].AxisY.Title = "Количество больных";
            string[] columnArray = ConvertColumnToArray(dataGridViewRes_GMR, 5);
            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (string value in columnArray)
            {
                if (counts.ContainsKey(value))
                {
                    counts[value]++;
                }
                else
                {
                    counts[value] = 1;
                }
            }
            foreach (var pair in counts)
            {
                chartiLLness_GMR.Series[0].Points.AddXY(pair.Key, pair.Value);
            }
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
                buttonDelete_GMR.Enabled = false;

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

        private void buttonAdd_GMR_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            int lastIndex = dataGridViewRes_GMR.Rows.Count - 1;
            int ourIndex = dataGridViewRes_GMR.CurrentCell.RowIndex;
            if (lastIndex == ourIndex)
            {
                dataGridViewRes_GMR.Rows.Add(row);
            }
            else if (lastIndex != ourIndex)
            {
                dataGridViewRes_GMR.Rows.Insert(dataGridViewRes_GMR.CurrentCell.RowIndex + 1, row);
            }
        }

        private void textBoxSearch_GMR_TextChanged(object sender, EventArgs e)
        {
            string search = textBoxSearch_GMR.Text.ToLower();

            foreach (DataGridViewRow row in dataGridViewRes_GMR.Rows)
            {
                if (row.IsNewRow)
                    continue;

                bool rowExist = false;

                for (int i= 0; i < dataGridViewRes_GMR.Columns.Count; i++)
                {
                    if (row.Cells[i].Value != null && row.Cells[i].Value.ToString().ToLower().Contains(search))
                    {
                        rowExist = true;
                        break;
                    }
                }

                row.Visible = rowExist;
            }
        }

        private void buttonSortName_GMR_Click(object sender, EventArgs e)
        {
            dataGridViewRes_GMR.Sort(dataGridViewRes_GMR.Columns[2], ListSortDirection.Ascending);
        }

        private void buttonSortSurname_GMR_Click(object sender, EventArgs e)
        {
            dataGridViewRes_GMR.Sort(dataGridViewRes_GMR.Columns[1], ListSortDirection.Ascending);
        }

        private void buttonSortFath_GMR_Click(object sender, EventArgs e)
        {
            dataGridViewRes_GMR.Sort(dataGridViewRes_GMR.Columns[3], ListSortDirection.Ascending);
        }

        private void buttonEdit_GMR_Click(object sender, EventArgs e)
        {
            dataGridViewRes_GMR.Rows[0].ReadOnly = false;
            dataGridViewRes_GMR.Columns[0].ReadOnly = false;
        }

        private void buttonSortILL_GMR_Click(object sender, EventArgs e)
        {
            dataGridViewRes_GMR.Sort(dataGridViewRes_GMR.Columns[7], ListSortDirection.Ascending);
        }
        private string[] ConvertColumnToArray(DataGridView dataGridView, int a)
        {
            List<string> columnData = new List<string>();

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[6].Value != null)
                {
                    columnData.Add(row.Cells[6].Value.ToString());
                }
            }

            return columnData.ToArray();
        }
        private string[] ConvertNewColumnToArray(DataGridView dataGridView, int a)
        {
            List<string> columnData = new List<string>();

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[5].Value != null)
                {
                    columnData.Add(row.Cells[5].Value.ToString());
                }
            }

            return columnData.ToArray();
        }


        private void buttonForm_GMR_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }


    }
}
