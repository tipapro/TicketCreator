namespace WordTicket
{
    partial class TicketSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketSettingsForm));
            this.FacultyName = new System.Windows.Forms.TextBox();
            this.DepartmentAbbreviation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DisciplineName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PreparationDirection = new System.Windows.Forms.TextBox();
            this.Course = new System.Windows.Forms.ComboBox();
            this.Groups = new System.Windows.Forms.TextBox();
            this.TrainingForm = new System.Windows.Forms.ComboBox();
            this.ProtocolNumber = new System.Windows.Forms.TextBox();
            this.SignatoryPosition = new System.Windows.Forms.ComboBox();
            this.FacultyAbbreviation = new System.Windows.Forms.TextBox();
            this.FullName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.AddSignatureBtn = new System.Windows.Forms.Button();
            this.ShowExampleTicketBtn = new System.Windows.Forms.Button();
            this.ApplyBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.University = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.DeleteSignatureBtn = new System.Windows.Forms.Button();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.TicketNumber = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.SignatureImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TicketNumber)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SignatureImage)).BeginInit();
            this.SuspendLayout();
            // 
            // FacultyName
            // 
            this.FacultyName.Location = new System.Drawing.Point(366, 29);
            this.FacultyName.Name = "FacultyName";
            this.FacultyName.Size = new System.Drawing.Size(313, 20);
            this.FacultyName.TabIndex = 0;
            this.FacultyName.TextChanged += new System.EventHandler(this.FacultyName_TextChanged);
            // 
            // DepartmentAbbreviation
            // 
            this.DepartmentAbbreviation.Location = new System.Drawing.Point(685, 29);
            this.DepartmentAbbreviation.Name = "DepartmentAbbreviation";
            this.DepartmentAbbreviation.Size = new System.Drawing.Size(143, 20);
            this.DepartmentAbbreviation.TabIndex = 1;
            this.DepartmentAbbreviation.TextChanged += new System.EventHandler(this.DepartmentAbbreviation_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(366, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Наименование факультета/института";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(685, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Аббревиатура кафедры";
            // 
            // DisciplineName
            // 
            this.DisciplineName.Location = new System.Drawing.Point(3, 29);
            this.DisciplineName.Name = "DisciplineName";
            this.DisciplineName.Size = new System.Drawing.Size(396, 20);
            this.DisciplineName.TabIndex = 4;
            this.DisciplineName.TextChanged += new System.EventHandler(this.DisciplineName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Названия дисциплины";
            // 
            // PreparationDirection
            // 
            this.PreparationDirection.Location = new System.Drawing.Point(405, 29);
            this.PreparationDirection.Name = "PreparationDirection";
            this.PreparationDirection.Size = new System.Drawing.Size(358, 20);
            this.PreparationDirection.TabIndex = 6;
            this.PreparationDirection.TextChanged += new System.EventHandler(this.PreparationDirection_TextChanged);
            // 
            // Course
            // 
            this.Course.FormattingEnabled = true;
            this.Course.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.Course.Location = new System.Drawing.Point(3, 29);
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(43, 21);
            this.Course.TabIndex = 7;
            this.Course.SelectedIndexChanged += new System.EventHandler(this.Course_SelectedIndexChanged);
            // 
            // Groups
            // 
            this.Groups.Location = new System.Drawing.Point(52, 29);
            this.Groups.Name = "Groups";
            this.Groups.Size = new System.Drawing.Size(144, 20);
            this.Groups.TabIndex = 8;
            this.Groups.TextChanged += new System.EventHandler(this.Groups_TextChanged);
            // 
            // TrainingForm
            // 
            this.TrainingForm.FormattingEnabled = true;
            this.TrainingForm.Items.AddRange(new object[] {
            "очная",
            "очно-заочная",
            "заочная"});
            this.TrainingForm.Location = new System.Drawing.Point(202, 29);
            this.TrainingForm.Name = "TrainingForm";
            this.TrainingForm.Size = new System.Drawing.Size(101, 21);
            this.TrainingForm.TabIndex = 10;
            this.TrainingForm.SelectedIndexChanged += new System.EventHandler(this.TrainingForm_SelectedIndexChanged);
            // 
            // ProtocolNumber
            // 
            this.ProtocolNumber.Location = new System.Drawing.Point(461, 29);
            this.ProtocolNumber.Name = "ProtocolNumber";
            this.ProtocolNumber.Size = new System.Drawing.Size(108, 20);
            this.ProtocolNumber.TabIndex = 11;
            this.ProtocolNumber.TextChanged += new System.EventHandler(this.ProtocolNumber_TextChanged);
            // 
            // SignatoryPosition
            // 
            this.SignatoryPosition.FormattingEnabled = true;
            this.SignatoryPosition.Items.AddRange(new object[] {
            "Зав. кафедрой",
            "И.о. зав. Кафедрой"});
            this.SignatoryPosition.Location = new System.Drawing.Point(3, 29);
            this.SignatoryPosition.Name = "SignatoryPosition";
            this.SignatoryPosition.Size = new System.Drawing.Size(162, 21);
            this.SignatoryPosition.TabIndex = 12;
            this.SignatoryPosition.SelectedIndexChanged += new System.EventHandler(this.SignatoryPosition_SelectedIndexChanged);
            // 
            // FacultyAbbreviation
            // 
            this.FacultyAbbreviation.Location = new System.Drawing.Point(173, 29);
            this.FacultyAbbreviation.Name = "FacultyAbbreviation";
            this.FacultyAbbreviation.Size = new System.Drawing.Size(229, 20);
            this.FacultyAbbreviation.TabIndex = 13;
            this.FacultyAbbreviation.TextChanged += new System.EventHandler(this.FacultyAbbreviation_TextChanged);
            // 
            // FullName
            // 
            this.FullName.Location = new System.Drawing.Point(409, 29);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(208, 20);
            this.FullName.TabIndex = 14;
            this.FullName.TextChanged += new System.EventHandler(this.FullName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(405, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Направление подготовки";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Курс";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(52, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Группы";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(202, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Форма обучения";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(312, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Дата";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(461, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Номер протокола";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "Должность подписанта";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(173, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(229, 15);
            this.label11.TabIndex = 22;
            this.label11.Text = "Аббревиатура института/факультета ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(409, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 15);
            this.label12.TabIndex = 23;
            this.label12.Text = "ФИО";
            // 
            // AddSignatureBtn
            // 
            this.AddSignatureBtn.Location = new System.Drawing.Point(688, 144);
            this.AddSignatureBtn.Name = "AddSignatureBtn";
            this.AddSignatureBtn.Size = new System.Drawing.Size(90, 58);
            this.AddSignatureBtn.TabIndex = 24;
            this.AddSignatureBtn.Text = "Добавить изображение подписи";
            this.AddSignatureBtn.UseVisualStyleBackColor = true;
            this.AddSignatureBtn.Click += new System.EventHandler(this.AddSignatureBtn_Click);
            // 
            // ShowExampleTicketBtn
            // 
            this.ShowExampleTicketBtn.Location = new System.Drawing.Point(784, 210);
            this.ShowExampleTicketBtn.Name = "ShowExampleTicketBtn";
            this.ShowExampleTicketBtn.Size = new System.Drawing.Size(100, 60);
            this.ShowExampleTicketBtn.TabIndex = 25;
            this.ShowExampleTicketBtn.Text = "Посмотреть пример билета с этими данными";
            this.ShowExampleTicketBtn.UseVisualStyleBackColor = true;
            this.ShowExampleTicketBtn.Click += new System.EventHandler(this.ShowExampleTicketBtn_Click);
            // 
            // ApplyBtn
            // 
            this.ApplyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApplyBtn.Location = new System.Drawing.Point(359, 276);
            this.ApplyBtn.Name = "ApplyBtn";
            this.ApplyBtn.Size = new System.Drawing.Size(110, 33);
            this.ApplyBtn.TabIndex = 26;
            this.ApplyBtn.Text = "Применить";
            this.ApplyBtn.UseVisualStyleBackColor = true;
            this.ApplyBtn.Click += new System.EventHandler(this.ApplyBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(784, 286);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(100, 23);
            this.ClearBtn.TabIndex = 27;
            this.ClearBtn.Text = "Очистить всё";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // University
            // 
            this.University.Location = new System.Drawing.Point(3, 29);
            this.University.Name = "University";
            this.University.Size = new System.Drawing.Size(357, 20);
            this.University.TabIndex = 28;
            this.University.TextChanged += new System.EventHandler(this.University_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(193, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Университет Московского политеха";
            // 
            // DeleteSignatureBtn
            // 
            this.DeleteSignatureBtn.Location = new System.Drawing.Point(598, 144);
            this.DeleteSignatureBtn.Name = "DeleteSignatureBtn";
            this.DeleteSignatureBtn.Size = new System.Drawing.Size(84, 58);
            this.DeleteSignatureBtn.TabIndex = 31;
            this.DeleteSignatureBtn.Text = "Убрать изображение подписи";
            this.DeleteSignatureBtn.UseVisualStyleBackColor = true;
            this.DeleteSignatureBtn.Click += new System.EventHandler(this.DeleteSignatureBtn_Click);
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(312, 29);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(141, 20);
            this.Date.TabIndex = 32;
            this.Date.ValueChanged += new System.EventHandler(this.Date_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(623, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "Кол-во билетов на листе";
            // 
            // TicketNumber
            // 
            this.TicketNumber.Location = new System.Drawing.Point(623, 29);
            this.TicketNumber.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.TicketNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TicketNumber.Name = "TicketNumber";
            this.TicketNumber.Size = new System.Drawing.Size(132, 20);
            this.TicketNumber.TabIndex = 35;
            this.TicketNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TicketNumber.ValueChanged += new System.EventHandler(this.TicketNumber_ValueChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.25615F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.74385F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 189F));
            this.tableLayoutPanel1.Controls.Add(this.University, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.FacultyName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.DepartmentAbbreviation, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.90244F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.09756F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(872, 60);
            this.tableLayoutPanel1.TabIndex = 36;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.52293F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.47707F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.DisciplineName, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.PreparationDirection, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 78);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.90244F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.09756F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(766, 60);
            this.tableLayoutPanel2.TabIndex = 37;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.63054F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.36946F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tableLayoutPanel3.Controls.Add(this.Course, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.Groups, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label6, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.TrainingForm, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.label7, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.Date, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.label8, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.label9, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.ProtocolNumber, 4, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(12, 144);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.90244F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.09756F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(580, 60);
            this.tableLayoutPanel3.TabIndex = 38;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.95122F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.04878F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 214F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableLayoutPanel4.Controls.Add(this.SignatoryPosition, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.FacultyAbbreviation, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label11, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.TicketNumber, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.FullName, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.label14, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.label12, 2, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(12, 210);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.90244F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.09756F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(766, 60);
            this.tableLayoutPanel4.TabIndex = 39;
            // 
            // SignatureImage
            // 
            this.SignatureImage.BackColor = System.Drawing.Color.Transparent;
            this.SignatureImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SignatureImage.Location = new System.Drawing.Point(784, 102);
            this.SignatureImage.MaximumSize = new System.Drawing.Size(100, 100);
            this.SignatureImage.Name = "SignatureImage";
            this.SignatureImage.Size = new System.Drawing.Size(100, 100);
            this.SignatureImage.TabIndex = 30;
            this.SignatureImage.TabStop = false;
            // 
            // TicketSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 319);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.DeleteSignatureBtn);
            this.Controls.Add(this.SignatureImage);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.ApplyBtn);
            this.Controls.Add(this.ShowExampleTicketBtn);
            this.Controls.Add(this.AddSignatureBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TicketSettingsForm";
            this.Text = "Настройка билета";
            ((System.ComponentModel.ISupportInitialize)(this.TicketNumber)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SignatureImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;

        private System.Windows.Forms.TextBox University;
        private System.Windows.Forms.TextBox FacultyName;
        private System.Windows.Forms.TextBox DepartmentAbbreviation;
        private System.Windows.Forms.TextBox DisciplineName;
        private System.Windows.Forms.TextBox PreparationDirection;
        private System.Windows.Forms.ComboBox Course;
        private System.Windows.Forms.TextBox Groups;
        private System.Windows.Forms.ComboBox TrainingForm;
        private System.Windows.Forms.TextBox ProtocolNumber;
        private System.Windows.Forms.ComboBox SignatoryPosition;
        private System.Windows.Forms.TextBox FacultyAbbreviation;
        private System.Windows.Forms.TextBox FullName;
        private System.Windows.Forms.Button AddSignatureBtn;
        private System.Windows.Forms.Button ShowExampleTicketBtn;
        private System.Windows.Forms.Button ApplyBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.PictureBox SignatureImage;
        private System.Windows.Forms.Button DeleteSignatureBtn;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown TicketNumber;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
    }
}