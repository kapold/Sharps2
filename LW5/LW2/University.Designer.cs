namespace LW2
{
    partial class University
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.studentName = new System.Windows.Forms.TextBox();
            this.studentSecondName = new System.Windows.Forms.TextBox();
            this.studentSurname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.studentBirthday = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.studentSpeciality = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.studentCourse = new System.Windows.Forms.ComboBox();
            this.studentGroup = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.addressCity = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.addressStreet = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.addressHome = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.addressIndex = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.studentAverageMark = new System.Windows.Forms.TrackBar();
            this.infoTableAboutStudents = new System.Windows.Forms.DataGridView();
            this.studName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studSpeciality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studCourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studAverageMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studMale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label17 = new System.Windows.Forms.Label();
            this.BuilderBtn = new System.Windows.Forms.Button();
            this.SingletonBtn = new System.Windows.Forms.Button();
            this.AbsFactBtn = new System.Windows.Forms.Button();
            this.PrototypeBtn = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.factoryBox = new System.Windows.Forms.ComboBox();
            this.saveStateBtn = new System.Windows.Forms.Button();
            this.decrStateBtn = new System.Windows.Forms.Button();
            this.outObj = new System.Windows.Forms.Button();
            this.returnStateBtn = new System.Windows.Forms.Button();
            this.poxyBtnState = new System.Windows.Forms.Button();
            this.lowPrxyBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.studentAverageMark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.infoTableAboutStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Университет";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label2.Location = new System.Drawing.Point(24, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label3.Location = new System.Drawing.Point(24, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Фамилия:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label4.Location = new System.Drawing.Point(24, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Отчество:";
            // 
            // studentName
            // 
            this.studentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.studentName.Location = new System.Drawing.Point(28, 157);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(233, 30);
            this.studentName.TabIndex = 4;
            // 
            // studentSecondName
            // 
            this.studentSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.studentSecondName.Location = new System.Drawing.Point(28, 221);
            this.studentSecondName.Name = "studentSecondName";
            this.studentSecondName.Size = new System.Drawing.Size(233, 30);
            this.studentSecondName.TabIndex = 5;
            // 
            // studentSurname
            // 
            this.studentSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.studentSurname.Location = new System.Drawing.Point(28, 283);
            this.studentSurname.Name = "studentSurname";
            this.studentSurname.Size = new System.Drawing.Size(233, 30);
            this.studentSurname.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label5.Location = new System.Drawing.Point(24, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "День рождения:";
            // 
            // studentBirthday
            // 
            this.studentBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.studentBirthday.Location = new System.Drawing.Point(28, 369);
            this.studentBirthday.Name = "studentBirthday";
            this.studentBirthday.Size = new System.Drawing.Size(233, 22);
            this.studentBirthday.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label6.Location = new System.Drawing.Point(24, 414);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Специальность:";
            // 
            // studentSpeciality
            // 
            this.studentSpeciality.FormattingEnabled = true;
            this.studentSpeciality.Items.AddRange(new object[] {"ПОИБМС", "ПОИТ", "ИСИТ", "ДЭВИ"});
            this.studentSpeciality.Location = new System.Drawing.Point(28, 438);
            this.studentSpeciality.Name = "studentSpeciality";
            this.studentSpeciality.Size = new System.Drawing.Size(233, 24);
            this.studentSpeciality.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label7.Location = new System.Drawing.Point(24, 476);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Курс:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label8.Location = new System.Drawing.Point(144, 476);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Группа:";
            // 
            // studentCourse
            // 
            this.studentCourse.FormattingEnabled = true;
            this.studentCourse.Items.AddRange(new object[] {"1", "2", "3", "4"});
            this.studentCourse.Location = new System.Drawing.Point(28, 500);
            this.studentCourse.Name = "studentCourse";
            this.studentCourse.Size = new System.Drawing.Size(92, 24);
            this.studentCourse.TabIndex = 13;
            // 
            // studentGroup
            // 
            this.studentGroup.FormattingEnabled = true;
            this.studentGroup.Items.AddRange(new object[] {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"});
            this.studentGroup.Location = new System.Drawing.Point(148, 500);
            this.studentGroup.Name = "studentGroup";
            this.studentGroup.Size = new System.Drawing.Size(92, 24);
            this.studentGroup.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label9.Location = new System.Drawing.Point(28, 552);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Средняя оценка:";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label10.Location = new System.Drawing.Point(28, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 25);
            this.label10.TabIndex = 17;
            this.label10.Text = "БГТУ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label11.Location = new System.Drawing.Point(28, 635);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Пол:";
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.Location = new System.Drawing.Point(38, 658);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(96, 35);
            this.maleRadioButton.TabIndex = 19;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "МУЖ";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.Location = new System.Drawing.Point(120, 658);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(96, 35);
            this.femaleRadioButton.TabIndex = 20;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.Text = "ЖЕН";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label12.Location = new System.Drawing.Point(483, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 37);
            this.label12.TabIndex = 21;
            this.label12.Text = "Адрес";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label13.Location = new System.Drawing.Point(519, 134);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 20);
            this.label13.TabIndex = 22;
            this.label13.Text = "Город:";
            // 
            // addressCity
            // 
            this.addressCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.addressCity.Location = new System.Drawing.Point(352, 157);
            this.addressCity.Multiline = true;
            this.addressCity.Name = "addressCity";
            this.addressCity.Size = new System.Drawing.Size(233, 30);
            this.addressCity.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label14.Location = new System.Drawing.Point(520, 198);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 20);
            this.label14.TabIndex = 24;
            this.label14.Text = "Улица:";
            // 
            // addressStreet
            // 
            this.addressStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.addressStreet.Location = new System.Drawing.Point(352, 221);
            this.addressStreet.Multiline = true;
            this.addressStreet.Name = "addressStreet";
            this.addressStreet.Size = new System.Drawing.Size(233, 30);
            this.addressStreet.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label15.Location = new System.Drawing.Point(450, 260);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(135, 20);
            this.label15.TabIndex = 26;
            this.label15.Text = "Дом/Квартира:";
            // 
            // addressHome
            // 
            this.addressHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.addressHome.Location = new System.Drawing.Point(352, 283);
            this.addressHome.MaxLength = 3;
            this.addressHome.Name = "addressHome";
            this.addressHome.Size = new System.Drawing.Size(233, 30);
            this.addressHome.TabIndex = 27;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label16.Location = new System.Drawing.Point(510, 345);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 20);
            this.label16.TabIndex = 28;
            this.label16.Text = "Индекс:";
            // 
            // addressIndex
            // 
            this.addressIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.addressIndex.Location = new System.Drawing.Point(438, 369);
            this.addressIndex.MaxLength = 6;
            this.addressIndex.Name = "addressIndex";
            this.addressIndex.Size = new System.Drawing.Size(147, 30);
            this.addressIndex.TabIndex = 29;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.addButton.Location = new System.Drawing.Point(352, 438);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(233, 57);
            this.addButton.TabIndex = 30;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddStudentButton);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.clearButton.Location = new System.Drawing.Point(352, 501);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(233, 57);
            this.clearButton.TabIndex = 31;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearFormButton);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.button3.Location = new System.Drawing.Point(352, 564);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(233, 57);
            this.button3.TabIndex = 32;
            this.button3.Text = "In XML";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ConvertToXml);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.button4.Location = new System.Drawing.Point(352, 627);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(233, 57);
            this.button4.TabIndex = 33;
            this.button4.Text = "From XML";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ShowFromXml);
            // 
            // studentAverageMark
            // 
            this.studentAverageMark.Location = new System.Drawing.Point(28, 576);
            this.studentAverageMark.Name = "studentAverageMark";
            this.studentAverageMark.Size = new System.Drawing.Size(233, 56);
            this.studentAverageMark.TabIndex = 34;
            // 
            // infoTableAboutStudents
            // 
            this.infoTableAboutStudents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.infoTableAboutStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infoTableAboutStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.studName, this.studSpeciality, this.studBirthday, this.studCourse, this.studGroup, this.studAverageMark, this.studMale, this.studAddress});
            this.infoTableAboutStudents.Location = new System.Drawing.Point(672, 260);
            this.infoTableAboutStudents.Name = "infoTableAboutStudents";
            this.infoTableAboutStudents.RowHeadersVisible = false;
            this.infoTableAboutStudents.RowHeadersWidth = 51;
            this.infoTableAboutStudents.RowTemplate.Height = 24;
            this.infoTableAboutStudents.Size = new System.Drawing.Size(879, 424);
            this.infoTableAboutStudents.TabIndex = 36;
            // 
            // studName
            // 
            this.studName.HeaderText = "Name";
            this.studName.MinimumWidth = 6;
            this.studName.Name = "studName";
            this.studName.ReadOnly = true;
            this.studName.Width = 140;
            // 
            // studSpeciality
            // 
            this.studSpeciality.HeaderText = "Speciality";
            this.studSpeciality.MinimumWidth = 6;
            this.studSpeciality.Name = "studSpeciality";
            this.studSpeciality.ReadOnly = true;
            this.studSpeciality.Width = 70;
            // 
            // studBirthday
            // 
            this.studBirthday.HeaderText = "Birthday";
            this.studBirthday.MinimumWidth = 6;
            this.studBirthday.Name = "studBirthday";
            this.studBirthday.ReadOnly = true;
            this.studBirthday.Width = 120;
            // 
            // studCourse
            // 
            this.studCourse.HeaderText = "Course";
            this.studCourse.MinimumWidth = 6;
            this.studCourse.Name = "studCourse";
            this.studCourse.ReadOnly = true;
            this.studCourse.Width = 70;
            // 
            // studGroup
            // 
            this.studGroup.HeaderText = "Group";
            this.studGroup.MinimumWidth = 6;
            this.studGroup.Name = "studGroup";
            this.studGroup.ReadOnly = true;
            this.studGroup.Width = 70;
            // 
            // studAverageMark
            // 
            this.studAverageMark.HeaderText = "AverMark";
            this.studAverageMark.MinimumWidth = 6;
            this.studAverageMark.Name = "studAverageMark";
            this.studAverageMark.ReadOnly = true;
            this.studAverageMark.Width = 80;
            // 
            // studMale
            // 
            this.studMale.HeaderText = "Male";
            this.studMale.MinimumWidth = 6;
            this.studMale.Name = "studMale";
            this.studMale.ReadOnly = true;
            this.studMale.Width = 80;
            // 
            // studAddress
            // 
            this.studAddress.HeaderText = "Address";
            this.studAddress.MinimumWidth = 6;
            this.studAddress.Name = "studAddress";
            this.studAddress.ReadOnly = true;
            this.studAddress.Width = 140;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label17.Location = new System.Drawing.Point(1352, 19);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(199, 74);
            this.label17.TabIndex = 37;
            this.label17.Text = "Информация\r\nО Студентах";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BuilderBtn
            // 
            this.BuilderBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.BuilderBtn.Location = new System.Drawing.Point(683, 584);
            this.BuilderBtn.Name = "BuilderBtn";
            this.BuilderBtn.Size = new System.Drawing.Size(240, 91);
            this.BuilderBtn.TabIndex = 42;
            this.BuilderBtn.Text = "Создать случайного студента";
            this.BuilderBtn.UseVisualStyleBackColor = true;
            this.BuilderBtn.Visible = false;
            this.BuilderBtn.Click += new System.EventHandler(this.BuilderBtn_Click);
            // 
            // SingletonBtn
            // 
            this.SingletonBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.SingletonBtn.Location = new System.Drawing.Point(683, 521);
            this.SingletonBtn.Name = "SingletonBtn";
            this.SingletonBtn.Size = new System.Drawing.Size(276, 57);
            this.SingletonBtn.TabIndex = 43;
            this.SingletonBtn.Text = "Информация о форме";
            this.SingletonBtn.UseVisualStyleBackColor = true;
            this.SingletonBtn.Visible = false;
            this.SingletonBtn.Click += new System.EventHandler(this.SingletonBtn_Click);
            // 
            // AbsFactBtn
            // 
            this.AbsFactBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.AbsFactBtn.Location = new System.Drawing.Point(929, 607);
            this.AbsFactBtn.Name = "AbsFactBtn";
            this.AbsFactBtn.Size = new System.Drawing.Size(173, 68);
            this.AbsFactBtn.TabIndex = 44;
            this.AbsFactBtn.Text = "Абстрактная фабрика";
            this.AbsFactBtn.UseVisualStyleBackColor = true;
            this.AbsFactBtn.Visible = false;
            this.AbsFactBtn.Click += new System.EventHandler(this.AbsFactBtn_Click);
            // 
            // PrototypeBtn
            // 
            this.PrototypeBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.PrototypeBtn.Location = new System.Drawing.Point(965, 521);
            this.PrototypeBtn.Name = "PrototypeBtn";
            this.PrototypeBtn.Size = new System.Drawing.Size(137, 80);
            this.PrototypeBtn.TabIndex = 45;
            this.PrototypeBtn.Text = "Прототип студента";
            this.PrototypeBtn.UseVisualStyleBackColor = true;
            this.PrototypeBtn.Visible = false;
            this.PrototypeBtn.Click += new System.EventHandler(this.PrototypeBtn_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label18.Location = new System.Drawing.Point(1121, 521);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(89, 20);
            this.label18.TabIndex = 46;
            this.label18.Text = "Фабрика:";
            this.label18.Visible = false;
            // 
            // factoryBox
            // 
            this.factoryBox.FormattingEnabled = true;
            this.factoryBox.Items.AddRange(new object[] {"School", "Univer"});
            this.factoryBox.Location = new System.Drawing.Point(1121, 544);
            this.factoryBox.Name = "factoryBox";
            this.factoryBox.Size = new System.Drawing.Size(136, 24);
            this.factoryBox.TabIndex = 47;
            this.factoryBox.Visible = false;
            // 
            // saveStateBtn
            // 
            this.saveStateBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.saveStateBtn.Location = new System.Drawing.Point(672, 99);
            this.saveStateBtn.Name = "saveStateBtn";
            this.saveStateBtn.Size = new System.Drawing.Size(173, 68);
            this.saveStateBtn.TabIndex = 48;
            this.saveStateBtn.Text = "Сохранить состояние";
            this.saveStateBtn.UseVisualStyleBackColor = true;
            this.saveStateBtn.Click += new System.EventHandler(this.saveStateBtn_Click);
            // 
            // decrStateBtn
            // 
            this.decrStateBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.decrStateBtn.Location = new System.Drawing.Point(851, 99);
            this.decrStateBtn.Name = "decrStateBtn";
            this.decrStateBtn.Size = new System.Drawing.Size(173, 68);
            this.decrStateBtn.TabIndex = 49;
            this.decrStateBtn.Text = "Уменьшить оценку";
            this.decrStateBtn.UseVisualStyleBackColor = true;
            this.decrStateBtn.Click += new System.EventHandler(this.decrStateBtn_Click);
            // 
            // outObj
            // 
            this.outObj.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.outObj.Location = new System.Drawing.Point(672, 22);
            this.outObj.Name = "outObj";
            this.outObj.Size = new System.Drawing.Size(173, 68);
            this.outObj.TabIndex = 50;
            this.outObj.Text = "Выбрать студента";
            this.outObj.UseVisualStyleBackColor = true;
            this.outObj.Click += new System.EventHandler(this.outObj_Click);
            // 
            // returnStateBtn
            // 
            this.returnStateBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.returnStateBtn.Location = new System.Drawing.Point(851, 22);
            this.returnStateBtn.Name = "returnStateBtn";
            this.returnStateBtn.Size = new System.Drawing.Size(173, 68);
            this.returnStateBtn.TabIndex = 51;
            this.returnStateBtn.Text = "Вернуть состояние";
            this.returnStateBtn.UseVisualStyleBackColor = true;
            this.returnStateBtn.Click += new System.EventHandler(this.returnStateBtn_Click);
            // 
            // poxyBtnState
            // 
            this.poxyBtnState.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.poxyBtnState.Location = new System.Drawing.Point(1079, 25);
            this.poxyBtnState.Name = "poxyBtnState";
            this.poxyBtnState.Size = new System.Drawing.Size(245, 65);
            this.poxyBtnState.TabIndex = 52;
            this.poxyBtnState.Text = "Состояние объекта через прокси";
            this.poxyBtnState.UseVisualStyleBackColor = true;
            this.poxyBtnState.Click += new System.EventHandler(this.poxyBtnState_Click);
            // 
            // lowPrxyBtn
            // 
            this.lowPrxyBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.lowPrxyBtn.Location = new System.Drawing.Point(1079, 96);
            this.lowPrxyBtn.Name = "lowPrxyBtn";
            this.lowPrxyBtn.Size = new System.Drawing.Size(245, 65);
            this.lowPrxyBtn.TabIndex = 53;
            this.lowPrxyBtn.Text = "Уменьшение оценки через прокси";
            this.lowPrxyBtn.UseVisualStyleBackColor = true;
            this.lowPrxyBtn.Click += new System.EventHandler(this.lowPrxyBtn_Click);
            // 
            // University
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1598, 715);
            this.Controls.Add(this.lowPrxyBtn);
            this.Controls.Add(this.poxyBtnState);
            this.Controls.Add(this.returnStateBtn);
            this.Controls.Add(this.outObj);
            this.Controls.Add(this.decrStateBtn);
            this.Controls.Add(this.saveStateBtn);
            this.Controls.Add(this.factoryBox);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.PrototypeBtn);
            this.Controls.Add(this.AbsFactBtn);
            this.Controls.Add(this.SingletonBtn);
            this.Controls.Add(this.BuilderBtn);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.infoTableAboutStudents);
            this.Controls.Add(this.studentAverageMark);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.addressIndex);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.addressHome);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.addressStreet);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.addressCity);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.femaleRadioButton);
            this.Controls.Add(this.maleRadioButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.studentGroup);
            this.Controls.Add(this.studentCourse);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.studentSpeciality);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.studentBirthday);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.studentSurname);
            this.Controls.Add(this.studentSecondName);
            this.Controls.Add(this.studentName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(15, 15);
            this.MaximizeBox = false;
            this.Name = "University";
            this.Load += new System.EventHandler(this.University_Load);
            ((System.ComponentModel.ISupportInitialize) (this.studentAverageMark)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.infoTableAboutStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button lowPrxyBtn;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Button poxyBtnState;

        private System.Windows.Forms.Button proxyBtn;

        private System.Windows.Forms.Button returnStateBtn;

        private System.Windows.Forms.Button outObj;

        private System.Windows.Forms.Button saveStateBtn;
        private System.Windows.Forms.Button decrStateBtn;

        private System.Windows.Forms.ComboBox factoryBox;

        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox comboBox1;

        private System.Windows.Forms.Button PrototypeBtn;

        private System.Windows.Forms.Button AbsFactBtn;

        private System.Windows.Forms.Button SingletonBtn;

        private System.Windows.Forms.Button BuilderBtn;

        private System.Windows.Forms.Label label17;

        private System.Windows.Forms.DataGridView infoTableAboutStudents;

        private System.Windows.Forms.TrackBar studentAverageMark;

        private System.Windows.Forms.Button clearButton;

        private System.Windows.Forms.Button addButton;

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;


        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox addressIndex;

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox addressStreet;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox addressHome;

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox addressCity;

        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.RadioButton femaleRadioButton;

        private System.Windows.Forms.Label label11;

        private System.Windows.Forms.Label label10;

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox studentName;
        private System.Windows.Forms.TextBox studentSecondName;
        private System.Windows.Forms.TextBox studentSurname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker studentBirthday;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox studentSpeciality;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox studentCourse;
        private System.Windows.Forms.ComboBox studentGroup;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn studName;
        private System.Windows.Forms.DataGridViewTextBoxColumn studSpeciality;
        private System.Windows.Forms.DataGridViewTextBoxColumn studBirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn studCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn studGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn studAverageMark;
        private System.Windows.Forms.DataGridViewTextBoxColumn studMale;
        private System.Windows.Forms.DataGridViewTextBoxColumn studAddress;
    }
}

