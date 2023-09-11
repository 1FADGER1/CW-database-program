namespace WinFormsApp1
{
    partial class SignInForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            buttonExit = new Button();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            textBoxPositionHeld = new TextBox();
            textBoxCodePosition = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            toolTip1 = new ToolTip(components);
            label8 = new Label();
            label9 = new Label();
            labelResetPassword = new Label();
            labelResetLogin = new Label();
            buttonContinue = new Button();
            label6 = new Label();
            label7 = new Label();
            labelState = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // buttonExit
            // 
            buttonExit.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonExit.Location = new Point(349, 411);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(101, 32);
            buttonExit.TabIndex = 0;
            buttonExit.Text = "Выход";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLogin.Location = new Point(12, 101);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(196, 29);
            textBoxLogin.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(12, 161);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(196, 29);
            textBoxPassword.TabIndex = 3;
            // 
            // textBoxPositionHeld
            // 
            textBoxPositionHeld.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPositionHeld.Location = new Point(12, 231);
            textBoxPositionHeld.Name = "textBoxPositionHeld";
            textBoxPositionHeld.Size = new Size(222, 29);
            textBoxPositionHeld.TabIndex = 4;
            // 
            // textBoxCodePosition
            // 
            textBoxCodePosition.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCodePosition.Location = new Point(288, 231);
            textBoxCodePosition.Name = "textBoxCodePosition";
            textBoxCodePosition.Size = new Size(162, 29);
            textBoxCodePosition.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(240, 237);
            label1.Name = "label1";
            label1.Size = new Size(42, 19);
            label1.TabIndex = 6;
            label1.Text = "ИЛИ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 79);
            label2.Name = "label2";
            label2.Size = new Size(49, 19);
            label2.TabIndex = 7;
            label2.Text = "Логин";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 139);
            label3.Name = "label3";
            label3.Size = new Size(57, 19);
            label3.TabIndex = 8;
            label3.Text = "Пароль";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 209);
            label4.Name = "label4";
            label4.Size = new Size(132, 19);
            label4.TabIndex = 9;
            label4.Text = "Роль пользователя";
            toolTip1.SetToolTip(label4, "Ваша должность в компании");
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(275, 209);
            label5.Name = "label5";
            label5.Size = new Size(162, 19);
            label5.TabIndex = 10;
            label5.Text = "Код роли пользователя";
            toolTip1.SetToolTip(label5, "Код вашей должности в компании (можете спросить у разработчика)");
            // 
            // toolTip1
            // 
            toolTip1.IsBalloon = true;
            toolTip1.OwnerDraw = true;
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(0, 0, 192);
            label8.Location = new Point(142, 209);
            label8.Name = "label8";
            label8.Size = new Size(15, 19);
            label8.TabIndex = 16;
            label8.Text = "?";
            toolTip1.SetToolTip(label8, "Ваша должность в компании");
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(0, 0, 192);
            label9.Location = new Point(435, 209);
            label9.Name = "label9";
            label9.Size = new Size(15, 19);
            label9.TabIndex = 17;
            label9.Text = "?";
            toolTip1.SetToolTip(label9, "Код вашей должности в компании (можете спросить у разработчика)");
            // 
            // labelResetPassword
            // 
            labelResetPassword.AutoSize = true;
            labelResetPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelResetPassword.ForeColor = Color.MidnightBlue;
            labelResetPassword.Location = new Point(314, 169);
            labelResetPassword.Name = "labelResetPassword";
            labelResetPassword.Size = new Size(101, 15);
            labelResetPassword.TabIndex = 11;
            labelResetPassword.Text = "Забыли пароль?";
            labelResetPassword.Click += labelResetPassword_Click;
            // 
            // labelResetLogin
            // 
            labelResetLogin.AutoSize = true;
            labelResetLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelResetLogin.ForeColor = Color.MidnightBlue;
            labelResetLogin.Location = new Point(321, 109);
            labelResetLogin.Name = "labelResetLogin";
            labelResetLogin.Size = new Size(94, 15);
            labelResetLogin.TabIndex = 12;
            labelResetLogin.Text = "Забыли логин?";
            labelResetLogin.Click += labelResetLogin_Click;
            // 
            // buttonContinue
            // 
            buttonContinue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonContinue.Location = new Point(179, 306);
            buttonContinue.Name = "buttonContinue";
            buttonContinue.Size = new Size(116, 32);
            buttonContinue.TabIndex = 13;
            buttonContinue.Text = "Продолжить";
            buttonContinue.UseVisualStyleBackColor = true;
            buttonContinue.Click += buttonContinue_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(204, 22);
            label6.Name = "label6";
            label6.Size = new Size(78, 30);
            label6.TabIndex = 14;
            label6.Text = "ВХОД";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(163, 52);
            label7.Name = "label7";
            label7.Size = new Size(171, 21);
            label7.TabIndex = 15;
            label7.Text = "Добро пожаловать!!!";
            // 
            // labelState
            // 
            labelState.AutoSize = true;
            labelState.Location = new Point(12, 431);
            labelState.Name = "labelState";
            labelState.Size = new Size(0, 15);
            labelState.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.FromArgb(192, 0, 0);
            label10.Location = new Point(169, 288);
            label10.Name = "label10";
            label10.Size = new Size(127, 15);
            label10.TabIndex = 19;
            label10.Text = "Этих данных нет в БД!";
            label10.Visible = false;
            // 
            // SignInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 455);
            Controls.Add(label10);
            Controls.Add(labelState);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(buttonContinue);
            Controls.Add(labelResetLogin);
            Controls.Add(labelResetPassword);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxCodePosition);
            Controls.Add(textBoxPositionHeld);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(buttonExit);
            Name = "SignInForm";
            Text = "Вход в программу";
            Load += SignInForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonExit;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private TextBox textBoxPositionHeld;
        private TextBox textBoxCodePosition;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ToolTip toolTip1;
        private Label labelResetPassword;
        private Label labelResetLogin;
        private Button buttonContinue;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label labelState;
        private Label label10;
    }
}