
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
            this.openFileDialog_GMR = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog_GMR = new System.Windows.Forms.SaveFileDialog();
            this.buttonOpenPacient_GMR = new System.Windows.Forms.Button();
            this.dataGridViewRes_GMR = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonPacient_GKU = new System.Windows.Forms.Button();
            this.buttonDelete_GMR = new System.Windows.Forms.Button();
            this.pictureBoxBin_GMR = new System.Windows.Forms.PictureBox();
            this.toolTip_GMR = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonSavePacientBase_GKU = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.buttonChange_GMR = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_GMR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBin_GMR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog_GMR
            // 
            this.openFileDialog_GMR.FileName = "openFileDialog_GMR";
            this.openFileDialog_GMR.Filter = "Excel|*.csv";
            // 
            // buttonOpenPacient_GMR
            // 
            this.buttonOpenPacient_GMR.Location = new System.Drawing.Point(72, 75);
            this.buttonOpenPacient_GMR.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpenPacient_GMR.Name = "buttonOpenPacient_GMR";
            this.buttonOpenPacient_GMR.Size = new System.Drawing.Size(71, 19);
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
            this.dataGridViewRes_GMR.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewRes_GMR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewRes_GMR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRes_GMR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewRes_GMR.Location = new System.Drawing.Point(57, 142);
            this.dataGridViewRes_GMR.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewRes_GMR.Name = "dataGridViewRes_GMR";
            this.dataGridViewRes_GMR.RowHeadersVisible = false;
            this.dataGridViewRes_GMR.RowHeadersWidth = 51;
            this.dataGridViewRes_GMR.RowTemplate.Height = 24;
            this.dataGridViewRes_GMR.Size = new System.Drawing.Size(493, 416);
            this.dataGridViewRes_GMR.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Номер";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 45;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Фамилия";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 70;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Имя";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 35;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Отчество";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 70;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Дата рождения";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // buttonPacient_GKU
            // 
            this.buttonPacient_GKU.Location = new System.Drawing.Point(160, 75);
            this.buttonPacient_GKU.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPacient_GKU.Name = "buttonPacient_GKU";
            this.buttonPacient_GKU.Size = new System.Drawing.Size(73, 19);
            this.buttonPacient_GKU.TabIndex = 2;
            this.buttonPacient_GKU.Text = "Загрузить";
            this.buttonPacient_GKU.UseVisualStyleBackColor = true;
            this.buttonPacient_GKU.Visible = false;
            this.buttonPacient_GKU.Click += new System.EventHandler(this.buttonPacient_GKU_Click);
            // 
            // buttonDelete_GMR
            // 
            this.buttonDelete_GMR.Location = new System.Drawing.Point(355, 75);
            this.buttonDelete_GMR.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDelete_GMR.Name = "buttonDelete_GMR";
            this.buttonDelete_GMR.Size = new System.Drawing.Size(72, 19);
            this.buttonDelete_GMR.TabIndex = 3;
            this.buttonDelete_GMR.Text = "Удалить";
            this.buttonDelete_GMR.UseVisualStyleBackColor = true;
            this.buttonDelete_GMR.Visible = false;
            this.buttonDelete_GMR.Click += new System.EventHandler(this.buttonDelete_GMR_Click);
            // 
            // pictureBoxBin_GMR
            // 
            this.pictureBoxBin_GMR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxBin_GMR.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBin_GMR.Image")));
            this.pictureBoxBin_GMR.Location = new System.Drawing.Point(345, 12);
            this.pictureBoxBin_GMR.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxBin_GMR.Name = "pictureBoxBin_GMR";
            this.pictureBoxBin_GMR.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxBin_GMR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxBin_GMR.TabIndex = 4;
            this.pictureBoxBin_GMR.TabStop = false;
            this.toolTip_GMR.SetToolTip(this.pictureBoxBin_GMR, "Удалите выбранную строку");
            this.pictureBoxBin_GMR.Click += new System.EventHandler(this.buttonDelete_GMR_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(57, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.toolTip_GMR.SetToolTip(this.pictureBox1, " Выберите файл");
            this.pictureBox1.Click += new System.EventHandler(this.buttonOpenPacient_GMR_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(149, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(104, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.toolTip_GMR.SetToolTip(this.pictureBox2, "Загрузите файл");
            this.pictureBox2.Click += new System.EventHandler(this.buttonPacient_GKU_Click);
            // 
            // buttonSavePacientBase_GKU
            // 
            this.buttonSavePacientBase_GKU.Location = new System.Drawing.Point(250, 75);
            this.buttonSavePacientBase_GKU.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSavePacientBase_GKU.Name = "buttonSavePacientBase_GKU";
            this.buttonSavePacientBase_GKU.Size = new System.Drawing.Size(76, 19);
            this.buttonSavePacientBase_GKU.TabIndex = 5;
            this.buttonSavePacientBase_GKU.Text = "Сохранить";
            this.buttonSavePacientBase_GKU.UseVisualStyleBackColor = true;
            this.buttonSavePacientBase_GKU.Visible = false;
            this.buttonSavePacientBase_GKU.Click += new System.EventHandler(this.buttonSavePacientBase_GKU_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(250, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.buttonSavePacientBase_GKU_Click);
            // 
            // buttonChange_GMR
            // 
            this.buttonChange_GMR.Location = new System.Drawing.Point(440, 73);
            this.buttonChange_GMR.Name = "buttonChange_GMR";
            this.buttonChange_GMR.Size = new System.Drawing.Size(100, 23);
            this.buttonChange_GMR.TabIndex = 15;
            this.buttonChange_GMR.Text = "Редактировать";
            this.buttonChange_GMR.UseVisualStyleBackColor = true;
            this.buttonChange_GMR.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(440, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 605);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.buttonChange_GMR);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonSavePacientBase_GKU);
            this.Controls.Add(this.pictureBoxBin_GMR);
            this.Controls.Add(this.buttonDelete_GMR);
            this.Controls.Add(this.buttonPacient_GKU);
            this.Controls.Add(this.dataGridViewRes_GMR);
            this.Controls.Add(this.buttonOpenPacient_GMR);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_GMR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBin_GMR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button buttonChange_GMR;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

