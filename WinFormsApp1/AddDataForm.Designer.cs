namespace WinFormsApp1
{
    partial class AddDataForm
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
            components = new System.ComponentModel.Container();
            buttonNext = new Button();
            textBoxTitle = new TextBox();
            textBoxNote = new TextBox();
            textBoxBudget = new TextBox();
            textBoxCountPeople = new TextBox();
            textBoxRevenue = new TextBox();
            textBoxSponsor = new TextBox();
            textBoxGuests = new TextBox();
            textBoxTime = new TextBox();
            checkBoxClosedness = new CheckBox();
            labelError = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            dateTimePicker1 = new DateTimePicker();
            toolTip1 = new ToolTip(components);
            comboBox1 = new ComboBox();
            label11 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            groupBox1 = new GroupBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            comboBox2 = new ComboBox();
            label17 = new Label();
            label18 = new Label();
            label16 = new Label();
            label20 = new Label();
            textBoxNoteUser = new TextBox();
            textBoxMail = new TextBox();
            textBoxPhone = new TextBox();
            label19 = new Label();
            label21 = new Label();
            textBoxCode = new TextBox();
            label22 = new Label();
            label23 = new Label();
            textBoxPassword = new TextBox();
            textBoxLogin = new TextBox();
            label24 = new Label();
            textBoxHeld = new TextBox();
            label25 = new Label();
            textBoxCodeHeld = new TextBox();
            textBoxFullName = new TextBox();
            label26 = new Label();
            label27 = new Label();
            label28 = new Label();
            label29 = new Label();
            label30 = new Label();
            label31 = new Label();
            label32 = new Label();
            checkBox2 = new CheckBox();
            dateTimePicker3 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            textBox8 = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label33 = new Label();
            label34 = new Label();
            label35 = new Label();
            label36 = new Label();
            label37 = new Label();
            label38 = new Label();
            label39 = new Label();
            label40 = new Label();
            label41 = new Label();
            label42 = new Label();
            label43 = new Label();
            label44 = new Label();
            label45 = new Label();
            label46 = new Label();
            label47 = new Label();
            label48 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonNext
            // 
            buttonNext.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonNext.Location = new Point(319, 403);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(128, 35);
            buttonNext.TabIndex = 0;
            buttonNext.Text = "Продолжить";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += button1_Click;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTitle.Location = new Point(88, 133);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(163, 25);
            textBoxTitle.TabIndex = 1;
            textBoxTitle.Visible = false;
            // 
            // textBoxNote
            // 
            textBoxNote.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNote.Location = new Point(507, 327);
            textBoxNote.Name = "textBoxNote";
            textBoxNote.Size = new Size(163, 25);
            textBoxNote.TabIndex = 2;
            textBoxNote.Visible = false;
            // 
            // textBoxBudget
            // 
            textBoxBudget.BackColor = SystemColors.Window;
            textBoxBudget.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxBudget.Location = new Point(298, 261);
            textBoxBudget.Name = "textBoxBudget";
            textBoxBudget.Size = new Size(163, 25);
            textBoxBudget.TabIndex = 4;
            textBoxBudget.Visible = false;
            // 
            // textBoxCountPeople
            // 
            textBoxCountPeople.BackColor = SystemColors.Window;
            textBoxCountPeople.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCountPeople.Location = new Point(507, 133);
            textBoxCountPeople.Name = "textBoxCountPeople";
            textBoxCountPeople.Size = new Size(163, 25);
            textBoxCountPeople.TabIndex = 5;
            textBoxCountPeople.Text = "0";
            textBoxCountPeople.Visible = false;
            // 
            // textBoxRevenue
            // 
            textBoxRevenue.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxRevenue.Location = new Point(507, 192);
            textBoxRevenue.Name = "textBoxRevenue";
            textBoxRevenue.Size = new Size(163, 25);
            textBoxRevenue.TabIndex = 7;
            textBoxRevenue.Visible = false;
            // 
            // textBoxSponsor
            // 
            textBoxSponsor.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSponsor.Location = new Point(298, 133);
            textBoxSponsor.Name = "textBoxSponsor";
            textBoxSponsor.Size = new Size(163, 25);
            textBoxSponsor.TabIndex = 9;
            textBoxSponsor.Visible = false;
            // 
            // textBoxGuests
            // 
            textBoxGuests.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxGuests.Location = new Point(88, 327);
            textBoxGuests.Name = "textBoxGuests";
            textBoxGuests.Size = new Size(163, 25);
            textBoxGuests.TabIndex = 10;
            textBoxGuests.Visible = false;
            // 
            // textBoxTime
            // 
            textBoxTime.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTime.Location = new Point(88, 261);
            textBoxTime.Name = "textBoxTime";
            textBoxTime.Size = new Size(163, 25);
            textBoxTime.TabIndex = 11;
            textBoxTime.Visible = false;
            // 
            // checkBoxClosedness
            // 
            checkBoxClosedness.AutoSize = true;
            checkBoxClosedness.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxClosedness.Location = new Point(298, 326);
            checkBoxClosedness.Name = "checkBoxClosedness";
            checkBoxClosedness.Size = new Size(98, 25);
            checkBoxClosedness.TabIndex = 13;
            checkBoxClosedness.Text = "Закрытое";
            checkBoxClosedness.UseVisualStyleBackColor = true;
            checkBoxClosedness.Visible = false;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelError.ForeColor = Color.Red;
            labelError.Location = new Point(275, 380);
            labelError.Name = "labelError";
            labelError.Size = new Size(235, 20);
            labelError.TabIndex = 14;
            labelError.Text = "Не все важные данные введены";
            labelError.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(88, 111);
            label1.Name = "label1";
            label1.Size = new Size(158, 19);
            label1.TabIndex = 16;
            label1.Text = "Название мероприятия";
            label1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(298, 111);
            label2.Name = "label2";
            label2.Size = new Size(153, 19);
            label2.TabIndex = 17;
            label2.Text = "Спонсор мероприятия";
            toolTip1.SetToolTip(label2, "Компания спонсор");
            label2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(507, 111);
            label3.Name = "label3";
            label3.Size = new Size(171, 19);
            label3.TabIndex = 18;
            label3.Text = "Колличество посетителей";
            label3.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(88, 170);
            label4.Name = "label4";
            label4.Size = new Size(119, 19);
            label4.TabIndex = 19;
            label4.Text = "Дата проведения";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(298, 170);
            label5.Name = "label5";
            label5.Size = new Size(115, 19);
            label5.TabIndex = 20;
            label5.Text = "Номер договора";
            label5.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(507, 170);
            label6.Name = "label6";
            label6.Size = new Size(125, 19);
            label6.TabIndex = 21;
            label6.Text = "Итоговая выручка";
            label6.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(88, 239);
            label7.Name = "label7";
            label7.Size = new Size(129, 19);
            label7.TabIndex = 22;
            label7.Text = "Время проведения";
            toolTip1.SetToolTip(label7, "Сколько часов будет идти");
            label7.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(298, 239);
            label8.Name = "label8";
            label8.Size = new Size(144, 19);
            label8.TabIndex = 23;
            label8.Text = "Выделенный бюджет";
            label8.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(507, 305);
            label9.Name = "label9";
            label9.Size = new Size(90, 19);
            label9.TabIndex = 24;
            label9.Text = "Примечание";
            label9.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(88, 305);
            label10.Name = "label10";
            label10.Size = new Size(142, 19);
            label10.TabIndex = 25;
            label10.Text = "Приглашенные гости";
            toolTip1.SetToolTip(label10, "Количество приглашенных гостей");
            label10.Visible = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(62, 194);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 27;
            dateTimePicker1.Visible = false;
            // 
            // toolTip1
            // 
            toolTip1.IsBalloon = true;
            toolTip1.OwnerDraw = true;
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(298, 197);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(163, 25);
            comboBox1.TabIndex = 28;
            comboBox1.Visible = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(507, 239);
            label11.Name = "label11";
            label11.Size = new Size(0, 19);
            label11.TabIndex = 29;
            label11.Visible = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(4, 17);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(35, 23);
            radioButton1.TabIndex = 30;
            radioButton1.TabStop = true;
            radioButton1.Tag = "1";
            radioButton1.Text = "1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(39, 17);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(35, 23);
            radioButton2.TabIndex = 31;
            radioButton2.TabStop = true;
            radioButton2.Tag = "2";
            radioButton2.Text = "2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(74, 17);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(35, 23);
            radioButton3.TabIndex = 32;
            radioButton3.TabStop = true;
            radioButton3.Tag = "3";
            radioButton3.Text = "3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(106, 17);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(35, 23);
            radioButton4.TabIndex = 33;
            radioButton4.TabStop = true;
            radioButton4.Tag = "4";
            radioButton4.Text = "4";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(142, 17);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(35, 23);
            radioButton5.TabIndex = 34;
            radioButton5.TabStop = true;
            radioButton5.Tag = "5";
            radioButton5.Text = "5";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton5);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(507, 239);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 47);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            groupBox1.Text = "* Оценка гостя";
            groupBox1.Visible = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(78, 111);
            label12.Name = "label12";
            label12.Size = new Size(15, 20);
            label12.TabIndex = 36;
            label12.Text = "*";
            label12.Visible = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.Red;
            label13.Location = new Point(288, 111);
            label13.Name = "label13";
            label13.Size = new Size(15, 20);
            label13.TabIndex = 37;
            label13.Text = "*";
            label13.Visible = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.Red;
            label14.Location = new Point(77, 171);
            label14.Name = "label14";
            label14.Size = new Size(15, 20);
            label14.TabIndex = 38;
            label14.Text = "*";
            label14.Visible = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.Red;
            label15.Location = new Point(288, 170);
            label15.Name = "label15";
            label15.Size = new Size(15, 20);
            label15.TabIndex = 39;
            label15.Text = "*";
            label15.Visible = false;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.White;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Enabled = false;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Спонсоры", "Дополнительные услуги", "Учет посещения мероприятий", "Участники проводящие мероприятия", "О мероприятии" });
            comboBox2.Location = new Point(176, 57);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 41;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(73, 58);
            label17.Name = "label17";
            label17.Size = new Size(101, 19);
            label17.TabIndex = 42;
            label17.Text = "Добавление в ";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label18.ForeColor = Color.Red;
            label18.Location = new Point(288, 239);
            label18.Name = "label18";
            label18.Size = new Size(15, 20);
            label18.TabIndex = 43;
            label18.Text = "*";
            label18.Visible = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = Color.Red;
            label16.Location = new Point(495, 111);
            label16.Name = "label16";
            label16.Size = new Size(15, 20);
            label16.TabIndex = 44;
            label16.Text = "*";
            label16.Visible = false;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(180, 319);
            label20.Name = "label20";
            label20.Size = new Size(90, 19);
            label20.TabIndex = 112;
            label20.Text = "Примечание";
            label20.Visible = false;
            // 
            // textBoxNoteUser
            // 
            textBoxNoteUser.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNoteUser.Location = new Point(180, 341);
            textBoxNoteUser.Name = "textBoxNoteUser";
            textBoxNoteUser.Size = new Size(163, 25);
            textBoxNoteUser.TabIndex = 111;
            textBoxNoteUser.Visible = false;
            // 
            // textBoxMail
            // 
            textBoxMail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxMail.Location = new Point(460, 285);
            textBoxMail.Name = "textBoxMail";
            textBoxMail.Size = new Size(163, 25);
            textBoxMail.TabIndex = 110;
            textBoxMail.Visible = false;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPhone.Location = new Point(180, 285);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(163, 25);
            textBoxPhone.TabIndex = 109;
            textBoxPhone.Visible = false;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(460, 263);
            label19.Name = "label19";
            label19.Size = new Size(47, 19);
            label19.TabIndex = 108;
            label19.Text = "E-mail";
            label19.Visible = false;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(180, 263);
            label21.Name = "label21";
            label21.Size = new Size(116, 19);
            label21.TabIndex = 107;
            label21.Text = "Номер телефона";
            label21.Visible = false;
            // 
            // textBoxCode
            // 
            textBoxCode.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCode.Location = new Point(460, 107);
            textBoxCode.Name = "textBoxCode";
            textBoxCode.Size = new Size(163, 25);
            textBoxCode.TabIndex = 106;
            textBoxCode.Visible = false;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(460, 85);
            label22.Name = "label22";
            label22.Size = new Size(137, 19);
            label22.TabIndex = 105;
            label22.Text = "Код восстановления";
            label22.Visible = false;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label23.Location = new Point(460, 204);
            label23.Name = "label23";
            label23.Size = new Size(56, 19);
            label23.TabIndex = 104;
            label23.Text = "Пароль";
            label23.Visible = false;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(460, 226);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(163, 25);
            textBoxPassword.TabIndex = 103;
            textBoxPassword.Visible = false;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLogin.Location = new Point(180, 226);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(163, 25);
            textBoxLogin.TabIndex = 102;
            textBoxLogin.Visible = false;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label24.Location = new Point(180, 204);
            label24.Name = "label24";
            label24.Size = new Size(47, 19);
            label24.TabIndex = 101;
            label24.Text = "Логин";
            label24.Visible = false;
            // 
            // textBoxHeld
            // 
            textBoxHeld.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxHeld.Location = new Point(460, 166);
            textBoxHeld.Name = "textBoxHeld";
            textBoxHeld.Size = new Size(163, 25);
            textBoxHeld.TabIndex = 100;
            textBoxHeld.Visible = false;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label25.Location = new Point(460, 144);
            label25.Name = "label25";
            label25.Size = new Size(160, 19);
            label25.TabIndex = 99;
            label25.Text = "Занимаемая должность";
            label25.Visible = false;
            // 
            // textBoxCodeHeld
            // 
            textBoxCodeHeld.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCodeHeld.Location = new Point(180, 166);
            textBoxCodeHeld.Name = "textBoxCodeHeld";
            textBoxCodeHeld.Size = new Size(163, 25);
            textBoxCodeHeld.TabIndex = 98;
            textBoxCodeHeld.Visible = false;
            // 
            // textBoxFullName
            // 
            textBoxFullName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxFullName.Location = new Point(180, 107);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(163, 25);
            textBoxFullName.TabIndex = 97;
            textBoxFullName.Visible = false;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label26.Location = new Point(178, 144);
            label26.Name = "label26";
            label26.Size = new Size(189, 19);
            label26.TabIndex = 96;
            label26.Text = "Код занимаемой должности";
            label26.Visible = false;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label27.Location = new Point(180, 85);
            label27.Name = "label27";
            label27.Size = new Size(117, 19);
            label27.TabIndex = 95;
            label27.Text = "ФИО сотрудника";
            label27.Visible = false;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label28.ForeColor = Color.Red;
            label28.Location = new Point(169, 86);
            label28.Name = "label28";
            label28.Size = new Size(15, 20);
            label28.TabIndex = 113;
            label28.Text = "*";
            label28.Visible = false;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label29.ForeColor = Color.Red;
            label29.Location = new Point(449, 146);
            label29.Name = "label29";
            label29.Size = new Size(15, 20);
            label29.TabIndex = 114;
            label29.Text = "*";
            label29.Visible = false;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label30.ForeColor = Color.Red;
            label30.Location = new Point(168, 146);
            label30.Name = "label30";
            label30.Size = new Size(15, 20);
            label30.TabIndex = 115;
            label30.Text = "*";
            label30.Visible = false;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label31.ForeColor = Color.Red;
            label31.Location = new Point(169, 204);
            label31.Name = "label31";
            label31.Size = new Size(15, 20);
            label31.TabIndex = 116;
            label31.Text = "*";
            label31.Visible = false;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label32.ForeColor = Color.Red;
            label32.Location = new Point(450, 204);
            label32.Name = "label32";
            label32.Size = new Size(15, 20);
            label32.TabIndex = 117;
            label32.Text = "*";
            label32.Visible = false;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox2.Location = new Point(440, 175);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(180, 25);
            checkBox2.TabIndex = 128;
            checkBox2.Text = "Приглашенный гость";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.Visible = false;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(160, 243);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.ShowUpDown = true;
            dateTimePicker3.Size = new Size(200, 23);
            dateTimePicker3.TabIndex = 127;
            dateTimePicker3.Visible = false;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(440, 243);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 126;
            dateTimePicker2.Visible = false;
            // 
            // textBox8
            // 
            textBox8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox8.Location = new Point(160, 124);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(163, 25);
            textBox8.TabIndex = 125;
            textBox8.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(440, 302);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(163, 25);
            textBox1.TabIndex = 124;
            textBox1.Visible = false;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(160, 302);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(163, 25);
            textBox2.TabIndex = 123;
            textBox2.Visible = false;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(440, 124);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(163, 25);
            textBox3.TabIndex = 122;
            textBox3.Visible = false;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(440, 243);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(163, 25);
            textBox4.TabIndex = 121;
            textBox4.Visible = false;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(160, 243);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(163, 25);
            textBox5.TabIndex = 120;
            textBox5.Visible = false;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(440, 183);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(163, 25);
            textBox6.TabIndex = 119;
            textBox6.Visible = false;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.Location = new Point(160, 183);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(163, 25);
            textBox7.TabIndex = 118;
            textBox7.Visible = false;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label33.Location = new Point(160, 102);
            label33.Name = "label33";
            label33.Size = new Size(17, 19);
            label33.TabIndex = 129;
            label33.Text = "2";
            label33.Visible = false;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label34.Location = new Point(440, 102);
            label34.Name = "label34";
            label34.Size = new Size(17, 19);
            label34.TabIndex = 130;
            label34.Text = "2";
            label34.Visible = false;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label35.Location = new Point(160, 161);
            label35.Name = "label35";
            label35.Size = new Size(17, 19);
            label35.TabIndex = 131;
            label35.Text = "2";
            label35.Visible = false;
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label36.Location = new Point(440, 161);
            label36.Name = "label36";
            label36.Size = new Size(17, 19);
            label36.TabIndex = 132;
            label36.Text = "2";
            label36.Visible = false;
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label37.Location = new Point(160, 220);
            label37.Name = "label37";
            label37.Size = new Size(17, 19);
            label37.TabIndex = 133;
            label37.Text = "2";
            label37.Visible = false;
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label38.Location = new Point(440, 221);
            label38.Name = "label38";
            label38.Size = new Size(17, 19);
            label38.TabIndex = 134;
            label38.Text = "2";
            label38.Visible = false;
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label39.Location = new Point(160, 280);
            label39.Name = "label39";
            label39.Size = new Size(17, 19);
            label39.TabIndex = 135;
            label39.Text = "2";
            label39.Visible = false;
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label40.Location = new Point(440, 280);
            label40.Name = "label40";
            label40.Size = new Size(17, 19);
            label40.TabIndex = 136;
            label40.Text = "2";
            label40.Visible = false;
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label41.ForeColor = Color.Red;
            label41.Location = new Point(148, 102);
            label41.Name = "label41";
            label41.Size = new Size(15, 20);
            label41.TabIndex = 137;
            label41.Text = "*";
            label41.Visible = false;
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label42.ForeColor = Color.Red;
            label42.Location = new Point(427, 102);
            label42.Name = "label42";
            label42.Size = new Size(15, 20);
            label42.TabIndex = 138;
            label42.Text = "*";
            label42.Visible = false;
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label43.ForeColor = Color.Red;
            label43.Location = new Point(427, 161);
            label43.Name = "label43";
            label43.Size = new Size(15, 20);
            label43.TabIndex = 139;
            label43.Text = "*";
            label43.Visible = false;
            // 
            // label44
            // 
            label44.AutoSize = true;
            label44.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label44.ForeColor = Color.Red;
            label44.Location = new Point(148, 161);
            label44.Name = "label44";
            label44.Size = new Size(15, 20);
            label44.TabIndex = 140;
            label44.Text = "*";
            label44.Visible = false;
            // 
            // label45
            // 
            label45.AutoSize = true;
            label45.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label45.ForeColor = Color.Red;
            label45.Location = new Point(427, 220);
            label45.Name = "label45";
            label45.Size = new Size(15, 20);
            label45.TabIndex = 141;
            label45.Text = "*";
            label45.Visible = false;
            // 
            // label46
            // 
            label46.AutoSize = true;
            label46.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label46.ForeColor = Color.Red;
            label46.Location = new Point(148, 220);
            label46.Name = "label46";
            label46.Size = new Size(15, 20);
            label46.TabIndex = 142;
            label46.Text = "*";
            label46.Visible = false;
            // 
            // label47
            // 
            label47.AutoSize = true;
            label47.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label47.ForeColor = Color.Red;
            label47.Location = new Point(427, 280);
            label47.Name = "label47";
            label47.Size = new Size(15, 20);
            label47.TabIndex = 143;
            label47.Text = "*";
            label47.Visible = false;
            // 
            // label48
            // 
            label48.AutoSize = true;
            label48.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label48.ForeColor = Color.Red;
            label48.Location = new Point(148, 280);
            label48.Name = "label48";
            label48.Size = new Size(15, 20);
            label48.TabIndex = 144;
            label48.Text = "*";
            label48.Visible = false;
            // 
            // AddDataForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label48);
            Controls.Add(label47);
            Controls.Add(label46);
            Controls.Add(label45);
            Controls.Add(label44);
            Controls.Add(label43);
            Controls.Add(label42);
            Controls.Add(label41);
            Controls.Add(label40);
            Controls.Add(label39);
            Controls.Add(label38);
            Controls.Add(label37);
            Controls.Add(label36);
            Controls.Add(label35);
            Controls.Add(label34);
            Controls.Add(label33);
            Controls.Add(checkBox2);
            Controls.Add(dateTimePicker3);
            Controls.Add(dateTimePicker2);
            Controls.Add(textBox8);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(textBox5);
            Controls.Add(textBox6);
            Controls.Add(textBox7);
            Controls.Add(label32);
            Controls.Add(label31);
            Controls.Add(label30);
            Controls.Add(label29);
            Controls.Add(label28);
            Controls.Add(label20);
            Controls.Add(textBoxNoteUser);
            Controls.Add(textBoxMail);
            Controls.Add(textBoxPhone);
            Controls.Add(label19);
            Controls.Add(label21);
            Controls.Add(textBoxCode);
            Controls.Add(label22);
            Controls.Add(label23);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(label24);
            Controls.Add(textBoxHeld);
            Controls.Add(label25);
            Controls.Add(textBoxCodeHeld);
            Controls.Add(textBoxFullName);
            Controls.Add(label26);
            Controls.Add(label27);
            Controls.Add(label16);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(comboBox2);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(groupBox1);
            Controls.Add(label11);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelError);
            Controls.Add(checkBoxClosedness);
            Controls.Add(textBoxTime);
            Controls.Add(textBoxGuests);
            Controls.Add(textBoxSponsor);
            Controls.Add(textBoxRevenue);
            Controls.Add(textBoxCountPeople);
            Controls.Add(textBoxBudget);
            Controls.Add(textBoxNote);
            Controls.Add(textBoxTitle);
            Controls.Add(buttonNext);
            Name = "AddDataForm";
            Text = "Добавление";
            Load += AddEventsForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonNext;
        private TextBox textBoxTitle;
        private TextBox textBoxNote;
        private TextBox textBoxBudget;
        private TextBox textBoxCountPeople;
        private TextBox textBoxRevenue;
        private TextBox textBoxSponsor;
        private TextBox textBoxGuests;
        private TextBox textBoxTime;
        private CheckBox checkBoxClosedness;
        private Label labelError;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private DateTimePicker dateTimePicker1;
        private ToolTip toolTip1;
        private ComboBox comboBox1;
        private Label label11;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private GroupBox groupBox1;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private ComboBox comboBox2;
        private Label label17;
        private Label label18;
        private Label label16;
        private Label label20;
        private TextBox textBoxNoteUser;
        private TextBox textBoxMail;
        private TextBox textBoxPhone;
        private Label label19;
        private Label label21;
        private TextBox textBoxCode;
        private Label label22;
        private Label label23;
        private TextBox textBoxPassword;
        private TextBox textBoxLogin;
        private Label label24;
        private TextBox textBoxHeld;
        private Label label25;
        private TextBox textBoxCodeHeld;
        private TextBox textBoxFullName;
        private Label label26;
        private Label label27;
        private Label label28;
        private Label label29;
        private Label label30;
        private Label label31;
        private Label label32;
        private CheckBox checkBox2;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker2;
        private TextBox textBox8;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label33;
        private Label label34;
        private Label label35;
        private Label label36;
        private Label label37;
        private Label label38;
        private Label label39;
        private Label label40;
        private Label label41;
        private Label label42;
        private Label label43;
        private Label label44;
        private Label label45;
        private Label label46;
        private Label label47;
        private Label label48;
    }
}