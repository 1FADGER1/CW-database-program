namespace WinFormsApp1
{
    partial class ChooseForm
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
            label1 = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            label2 = new Label();
            buttonNext = new Button();
            buttonSaveAs = new Button();
            buttonSelect = new Button();
            dataGridView1 = new DataGridView();
            groupBoxSort = new GroupBox();
            label4 = new Label();
            buttonSort = new Button();
            textBoxText = new TextBox();
            comboBoxField = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBoxSort.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 1;
            label1.Text = "Выберите таблицы:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Расписание мероприятий", "Пользователи системы", "Учет договоров", "Учет посещения мероприятия", "Участники проводящие мероприятие", "Спонсоры", "Дополнительные услуги", "О мероприятие" });
            listBox1.Location = new Point(12, 33);
            listBox1.Name = "listBox1";
            listBox1.SelectionMode = SelectionMode.MultiSimple;
            listBox1.Size = new Size(166, 79);
            listBox1.TabIndex = 5;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(253, 33);
            listBox2.Name = "listBox2";
            listBox2.SelectionMode = SelectionMode.MultiSimple;
            listBox2.Size = new Size(205, 79);
            listBox2.TabIndex = 6;
            listBox2.Visible = false;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(253, 15);
            label2.Name = "label2";
            label2.Size = new Size(150, 15);
            label2.TabIndex = 7;
            label2.Text = "Выберите поля(столбцы):";
            label2.Visible = false;
            // 
            // buttonNext
            // 
            buttonNext.Location = new Point(198, 89);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(75, 23);
            buttonNext.TabIndex = 8;
            buttonNext.Text = "Далее";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click;
            // 
            // buttonSaveAs
            // 
            buttonSaveAs.Location = new Point(858, 68);
            buttonSaveAs.Name = "buttonSaveAs";
            buttonSaveAs.Size = new Size(117, 23);
            buttonSaveAs.TabIndex = 9;
            buttonSaveAs.Text = "Сохранить как";
            buttonSaveAs.UseVisualStyleBackColor = true;
            buttonSaveAs.Visible = false;
            buttonSaveAs.Click += buttonSaveAs_Click;
            // 
            // buttonSelect
            // 
            buttonSelect.Location = new Point(480, 68);
            buttonSelect.Name = "buttonSelect";
            buttonSelect.Size = new Size(90, 23);
            buttonSelect.TabIndex = 10;
            buttonSelect.Text = "Выбрать";
            buttonSelect.UseVisualStyleBackColor = true;
            buttonSelect.Visible = false;
            buttonSelect.Click += buttonSelect_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 127);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(995, 390);
            dataGridView1.TabIndex = 11;
            // 
            // groupBoxSort
            // 
            groupBoxSort.Controls.Add(label4);
            groupBoxSort.Controls.Add(buttonSort);
            groupBoxSort.Controls.Add(textBoxText);
            groupBoxSort.Controls.Add(comboBoxField);
            groupBoxSort.Controls.Add(label3);
            groupBoxSort.Location = new Point(576, 15);
            groupBoxSort.Name = "groupBoxSort";
            groupBoxSort.Size = new Size(276, 97);
            groupBoxSort.TabIndex = 12;
            groupBoxSort.TabStop = false;
            groupBoxSort.Text = "Сортировка";
            groupBoxSort.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 43);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 12;
            label4.Text = "Текст";
            // 
            // buttonSort
            // 
            buttonSort.Location = new Point(180, 61);
            buttonSort.Name = "buttonSort";
            buttonSort.Size = new Size(90, 23);
            buttonSort.TabIndex = 11;
            buttonSort.Text = "Сортировать";
            buttonSort.UseVisualStyleBackColor = true;
            buttonSort.Click += buttonSort_Click;
            // 
            // textBoxText
            // 
            textBoxText.Location = new Point(9, 61);
            textBoxText.Name = "textBoxText";
            textBoxText.Size = new Size(165, 23);
            textBoxText.TabIndex = 2;
            // 
            // comboBoxField
            // 
            comboBoxField.FormattingEnabled = true;
            comboBoxField.Location = new Point(104, 16);
            comboBoxField.Name = "comboBoxField";
            comboBoxField.Size = new Size(166, 23);
            comboBoxField.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 19);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 0;
            label3.Text = "Столбец(поле)";
            // 
            // ChooseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 529);
            Controls.Add(groupBoxSort);
            Controls.Add(dataGridView1);
            Controls.Add(buttonSelect);
            Controls.Add(buttonSaveAs);
            Controls.Add(buttonNext);
            Controls.Add(label2);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Name = "ChooseForm";
            Text = "ChooseForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBoxSort.ResumeLayout(false);
            groupBoxSort.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ListBox listBox1;
        private ListBox listBox2;
        private Label label2;
        private Button buttonNext;
        private Button buttonSaveAs;
        private Button buttonSelect;
        private DataGridView dataGridView1;
        private Button buttonSort;
        private TextBox textBoxText;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxField;
        private GroupBox groupBoxSort;
    }
}