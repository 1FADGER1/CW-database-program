namespace WinFormsApp1
{
    partial class FormError
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
            buttonExit = new Button();
            labelErrorMessage = new Label();
            SuspendLayout();
            // 
            // buttonExit
            // 
            buttonExit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonExit.Location = new Point(493, 162);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(85, 28);
            buttonExit.TabIndex = 0;
            buttonExit.Text = "Выход";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // labelErrorMessage
            // 
            labelErrorMessage.AutoSize = true;
            labelErrorMessage.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelErrorMessage.Location = new Point(31, 45);
            labelErrorMessage.Name = "labelErrorMessage";
            labelErrorMessage.Size = new Size(0, 20);
            labelErrorMessage.TabIndex = 1;
            // 
            // FormError
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 202);
            Controls.Add(labelErrorMessage);
            Controls.Add(buttonExit);
            Name = "FormError";
            Text = "Error";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonExit;
        private Label labelErrorMessage;
    }
}