
namespace Tyuiu.GalyameevMR.Project.V6
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.openFileDialog_GMR = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog_GMR = new System.Windows.Forms.SaveFileDialog();
            this.buttonOpenPacient_GMR = new System.Windows.Forms.Button();
            this.dataGridViewRes_GMR = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonPacient_GKU = new System.Windows.Forms.Button();
            this.buttonDelete_GMR = new System.Windows.Forms.Button();
            this.pictureBoxBin_GMR = new System.Windows.Forms.PictureBox();
            this.toolTip_GMR = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxInfo_GMR = new System.Windows.Forms.PictureBox();
            this.buttonSavePacientBase_GKU = new System.Windows.Forms.Button();
            this.buttonAdd_GMR = new System.Windows.Forms.Button();
            this.textBoxSearch_GMR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSortName_GMR = new System.Windows.Forms.Button();
            this.buttonSortSurname_GMR = new System.Windows.Forms.Button();
            this.buttonSortFath_GMR = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonEdit_GMR = new System.Windows.Forms.Button();
            this.buttonSortILL_GMR = new System.Windows.Forms.Button();
            this.chartiLLness_GMR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonForm_GMR = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_GMR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBin_GMR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo_GMR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartiLLness_GMR)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog_GMR
            // 
            this.openFileDialog_GMR.FileName = "openFileDialog_GMR";
            this.openFileDialog_GMR.Filter = "Excel|*.csv";
            // 
            // buttonOpenPacient_GMR
            // 
            this.buttonOpenPacient_GMR.Location = new System.Drawing.Point(96, 60);
            this.buttonOpenPacient_GMR.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpenPacient_GMR.Name = "buttonOpenPacient_GMR";
            this.buttonOpenPacient_GMR.Size = new System.Drawing.Size(85, 19);
            this.buttonOpenPacient_GMR.TabIndex = 0;
            this.buttonOpenPacient_GMR.Text = "Открыть";
            this.buttonOpenPacient_GMR.UseVisualStyleBackColor = true;
            this.buttonOpenPacient_GMR.Visible = false;
            this.buttonOpenPacient_GMR.Click += new System.EventHandler(this.buttonOpenPacient_GMR_Click);
            // 
            // dataGridViewRes_GMR
            // 
            this.dataGridViewRes_GMR.AllowUserToDeleteRows = false;
            this.dataGridViewRes_GMR.AllowUserToOrderColumns = true;
            this.dataGridViewRes_GMR.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewRes_GMR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewRes_GMR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRes_GMR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.COl,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridViewRes_GMR.Location = new System.Drawing.Point(-1, -1);
            this.dataGridViewRes_GMR.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewRes_GMR.Name = "dataGridViewRes_GMR";
            this.dataGridViewRes_GMR.RowHeadersVisible = false;
            this.dataGridViewRes_GMR.RowHeadersWidth = 51;
            this.dataGridViewRes_GMR.RowTemplate.Height = 24;
            this.dataGridViewRes_GMR.Size = new System.Drawing.Size(734, 409);
            this.dataGridViewRes_GMR.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Номер";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 65;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Фамилия";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 70;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Имя";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 65;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Отчество";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 70;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Дата рождения";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 65;
            // 
            // COl
            // 
            this.COl.HeaderText = "Инициалы врача";
            this.COl.Name = "COl";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Выставленный диагноз";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Срок болезни";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Примечание";
            this.Column8.Name = "Column8";
            // 
            // buttonPacient_GKU
            // 
            this.buttonPacient_GKU.Location = new System.Drawing.Point(197, 57);
            this.buttonPacient_GKU.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPacient_GKU.Name = "buttonPacient_GKU";
            this.buttonPacient_GKU.Size = new System.Drawing.Size(73, 22);
            this.buttonPacient_GKU.TabIndex = 2;
            this.buttonPacient_GKU.Text = "Загрузить";
            this.buttonPacient_GKU.UseVisualStyleBackColor = true;
            this.buttonPacient_GKU.Visible = false;
            this.buttonPacient_GKU.Click += new System.EventHandler(this.buttonPacient_GKU_Click);
            // 
            // buttonDelete_GMR
            // 
            this.buttonDelete_GMR.Location = new System.Drawing.Point(297, 60);
            this.buttonDelete_GMR.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDelete_GMR.Name = "buttonDelete_GMR";
            this.buttonDelete_GMR.Size = new System.Drawing.Size(68, 22);
            this.buttonDelete_GMR.TabIndex = 3;
            this.buttonDelete_GMR.Text = "Удалить";
            this.buttonDelete_GMR.UseVisualStyleBackColor = true;
            this.buttonDelete_GMR.Visible = false;
            this.buttonDelete_GMR.Click += new System.EventHandler(this.buttonDelete_GMR_Click);
            // 
            // pictureBoxBin_GMR
            // 
            this.pictureBoxBin_GMR.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBin_GMR.Image")));
            this.pictureBoxBin_GMR.Location = new System.Drawing.Point(265, 28);
            this.pictureBoxBin_GMR.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxBin_GMR.Name = "pictureBoxBin_GMR";
            this.pictureBoxBin_GMR.Size = new System.Drawing.Size(65, 61);
            this.pictureBoxBin_GMR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBin_GMR.TabIndex = 4;
            this.pictureBoxBin_GMR.TabStop = false;
            this.toolTip_GMR.SetToolTip(this.pictureBoxBin_GMR, "Удалить выбранную строку");
            this.pictureBoxBin_GMR.Click += new System.EventHandler(this.buttonDelete_GMR_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(565, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.toolTip_GMR.SetToolTip(this.pictureBox1, "Сохранить файл ");
            this.pictureBox1.Click += new System.EventHandler(this.buttonSavePacientBase_GKU_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(177, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 61);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.toolTip_GMR.SetToolTip(this.pictureBox2, "Загрузить файл");
            this.pictureBox2.Click += new System.EventHandler(this.buttonPacient_GKU_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(468, 28);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(64, 61);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 20;
            this.pictureBox5.TabStop = false;
            this.toolTip_GMR.SetToolTip(this.pictureBox5, "Редактировать данные");
            this.pictureBox5.Click += new System.EventHandler(this.buttonEdit_GMR_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(84, 28);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(62, 61);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.toolTip_GMR.SetToolTip(this.pictureBox3, "Добавить файл");
            this.pictureBox3.Click += new System.EventHandler(this.buttonOpenPacient_GMR_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(361, 28);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(69, 61);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            this.toolTip_GMR.SetToolTip(this.pictureBox4, "Добавить строку");
            this.pictureBox4.Click += new System.EventHandler(this.buttonAdd_GMR_Click);
            // 
            // pictureBoxInfo_GMR
            // 
            this.pictureBoxInfo_GMR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxInfo_GMR.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxInfo_GMR.Image")));
            this.pictureBoxInfo_GMR.Location = new System.Drawing.Point(9, 528);
            this.pictureBoxInfo_GMR.Name = "pictureBoxInfo_GMR";
            this.pictureBoxInfo_GMR.Size = new System.Drawing.Size(55, 49);
            this.pictureBoxInfo_GMR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxInfo_GMR.TabIndex = 26;
            this.pictureBoxInfo_GMR.TabStop = false;
            this.toolTip_GMR.SetToolTip(this.pictureBoxInfo_GMR, "Справка");
            this.pictureBoxInfo_GMR.Click += new System.EventHandler(this.buttonForm_GMR_Click);
            // 
            // buttonSavePacientBase_GKU
            // 
            this.buttonSavePacientBase_GKU.Location = new System.Drawing.Point(468, 62);
            this.buttonSavePacientBase_GKU.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSavePacientBase_GKU.Name = "buttonSavePacientBase_GKU";
            this.buttonSavePacientBase_GKU.Size = new System.Drawing.Size(76, 19);
            this.buttonSavePacientBase_GKU.TabIndex = 5;
            this.buttonSavePacientBase_GKU.Text = "Сохранить";
            this.buttonSavePacientBase_GKU.UseVisualStyleBackColor = true;
            this.buttonSavePacientBase_GKU.Visible = false;
            this.buttonSavePacientBase_GKU.Click += new System.EventHandler(this.buttonSavePacientBase_GKU_Click);
            // 
            // buttonAdd_GMR
            // 
            this.buttonAdd_GMR.Location = new System.Drawing.Point(388, 58);
            this.buttonAdd_GMR.Name = "buttonAdd_GMR";
            this.buttonAdd_GMR.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd_GMR.TabIndex = 9;
            this.buttonAdd_GMR.Text = "Добавить";
            this.buttonAdd_GMR.UseVisualStyleBackColor = true;
            this.buttonAdd_GMR.Visible = false;
            this.buttonAdd_GMR.Click += new System.EventHandler(this.buttonAdd_GMR_Click);
            // 
            // textBoxSearch_GMR
            // 
            this.textBoxSearch_GMR.Location = new System.Drawing.Point(84, 127);
            this.textBoxSearch_GMR.Name = "textBoxSearch_GMR";
            this.textBoxSearch_GMR.Size = new System.Drawing.Size(548, 20);
            this.textBoxSearch_GMR.TabIndex = 11;
            this.textBoxSearch_GMR.TextChanged += new System.EventHandler(this.textBoxSearch_GMR_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(82, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Поиск:";
            // 
            // buttonSortName_GMR
            // 
            this.buttonSortName_GMR.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSortName_GMR.Location = new System.Drawing.Point(23, 55);
            this.buttonSortName_GMR.Name = "buttonSortName_GMR";
            this.buttonSortName_GMR.Size = new System.Drawing.Size(107, 23);
            this.buttonSortName_GMR.TabIndex = 13;
            this.buttonSortName_GMR.Text = "Имени";
            this.buttonSortName_GMR.UseVisualStyleBackColor = false;
            // 
            // buttonSortSurname_GMR
            // 
            this.buttonSortSurname_GMR.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSortSurname_GMR.Location = new System.Drawing.Point(23, 30);
            this.buttonSortSurname_GMR.Name = "buttonSortSurname_GMR";
            this.buttonSortSurname_GMR.Size = new System.Drawing.Size(107, 23);
            this.buttonSortSurname_GMR.TabIndex = 15;
            this.buttonSortSurname_GMR.TabStop = false;
            this.buttonSortSurname_GMR.Text = "Фамилии";
            this.buttonSortSurname_GMR.UseVisualStyleBackColor = false;
            this.buttonSortSurname_GMR.Click += new System.EventHandler(this.buttonSortSurname_GMR_Click);
            // 
            // buttonSortFath_GMR
            // 
            this.buttonSortFath_GMR.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSortFath_GMR.Location = new System.Drawing.Point(23, 82);
            this.buttonSortFath_GMR.Name = "buttonSortFath_GMR";
            this.buttonSortFath_GMR.Size = new System.Drawing.Size(107, 23);
            this.buttonSortFath_GMR.TabIndex = 16;
            this.buttonSortFath_GMR.Text = "Отчеству";
            this.buttonSortFath_GMR.UseVisualStyleBackColor = false;
            this.buttonSortFath_GMR.Click += new System.EventHandler(this.buttonSortFath_GMR_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ravie", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Сортировать по:";
            // 
            // buttonEdit_GMR
            // 
            this.buttonEdit_GMR.Location = new System.Drawing.Point(501, 49);
            this.buttonEdit_GMR.Name = "buttonEdit_GMR";
            this.buttonEdit_GMR.Size = new System.Drawing.Size(57, 20);
            this.buttonEdit_GMR.TabIndex = 19;
            this.buttonEdit_GMR.Text = "Редактировать";
            this.buttonEdit_GMR.UseVisualStyleBackColor = true;
            this.buttonEdit_GMR.Visible = false;
            this.buttonEdit_GMR.Click += new System.EventHandler(this.buttonEdit_GMR_Click);
            // 
            // buttonSortILL_GMR
            // 
            this.buttonSortILL_GMR.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSortILL_GMR.Location = new System.Drawing.Point(23, 108);
            this.buttonSortILL_GMR.Name = "buttonSortILL_GMR";
            this.buttonSortILL_GMR.Size = new System.Drawing.Size(107, 23);
            this.buttonSortILL_GMR.TabIndex = 21;
            this.buttonSortILL_GMR.Text = "Болезни";
            this.buttonSortILL_GMR.UseVisualStyleBackColor = false;
 
            // 
            // chartiLLness_GMR
            // 
            chartArea2.Name = "ChartArea1";
            this.chartiLLness_GMR.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartiLLness_GMR.Legends.Add(legend2);
            this.chartiLLness_GMR.Location = new System.Drawing.Point(838, 68);
            this.chartiLLness_GMR.Name = "chartiLLness_GMR";
            this.chartiLLness_GMR.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = " ";
            this.chartiLLness_GMR.Series.Add(series2);
            this.chartiLLness_GMR.Size = new System.Drawing.Size(398, 496);
            this.chartiLLness_GMR.TabIndex = 22;
            // 
            // buttonForm_GMR
            // 
            this.buttonForm_GMR.Location = new System.Drawing.Point(12, 528);
            this.buttonForm_GMR.Name = "buttonForm_GMR";
            this.buttonForm_GMR.Size = new System.Drawing.Size(55, 52);
            this.buttonForm_GMR.TabIndex = 25;
            this.buttonForm_GMR.Text = "button1";
            this.buttonForm_GMR.UseVisualStyleBackColor = true;
            this.buttonForm_GMR.Visible = false;
            this.buttonForm_GMR.Click += new System.EventHandler(this.buttonForm_GMR_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(381, 22);
            this.label3.TabIndex = 27;
            this.label3.Text = "График распространенности болезни: \r\n";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridViewRes_GMR);
            this.panel1.Location = new System.Drawing.Point(73, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 412);
            this.panel1.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(73, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(571, 55);
            this.panel2.TabIndex = 29;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.buttonEdit_GMR);
            this.panel3.Location = new System.Drawing.Point(73, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(571, 80);
            this.panel3.TabIndex = 30;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.buttonSortName_GMR);
            this.panel4.Controls.Add(this.buttonSortILL_GMR);
            this.panel4.Controls.Add(this.buttonSortFath_GMR);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.buttonSortSurname_GMR);
            this.panel4.Location = new System.Drawing.Point(655, 18);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(152, 141);
            this.panel4.TabIndex = 31;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(823, 18);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(421, 562);
            this.panel5.TabIndex = 32;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1248, 605);
            this.Controls.Add(this.pictureBoxInfo_GMR);
            this.Controls.Add(this.buttonForm_GMR);
            this.Controls.Add(this.chartiLLness_GMR);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSearch_GMR);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.buttonAdd_GMR);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonSavePacientBase_GKU);
            this.Controls.Add(this.pictureBoxBin_GMR);
            this.Controls.Add(this.buttonDelete_GMR);
            this.Controls.Add(this.buttonPacient_GKU);
            this.Controls.Add(this.buttonOpenPacient_GMR);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_GMR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBin_GMR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo_GMR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartiLLness_GMR)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog_GMR;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_GMR;
        private System.Windows.Forms.Button buttonOpenPacient_GMR;
        private System.Windows.Forms.DataGridView dataGridViewRes_GMR;
        private System.Windows.Forms.Button buttonPacient_GKU;
        private System.Windows.Forms.Button buttonDelete_GMR;
        private System.Windows.Forms.PictureBox pictureBoxBin_GMR;
        private System.Windows.Forms.ToolTip toolTip_GMR;
        private System.Windows.Forms.Button buttonSavePacientBase_GKU;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button buttonAdd_GMR;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox textBoxSearch_GMR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSortName_GMR;
        private System.Windows.Forms.Button buttonSortSurname_GMR;
        private System.Windows.Forms.Button buttonSortFath_GMR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonEdit_GMR;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn COl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button buttonSortILL_GMR;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartiLLness_GMR;
        private System.Windows.Forms.Button buttonForm_GMR;
        private System.Windows.Forms.PictureBox pictureBoxInfo_GMR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}

