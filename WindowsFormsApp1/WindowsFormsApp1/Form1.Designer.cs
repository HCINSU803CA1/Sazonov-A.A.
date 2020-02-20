namespace WindowsFormsApp1
{
    partial class Form1
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.NextButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.Checker = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.licenseText = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(645, 414);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(99, 24);
            this.NextButton.TabIndex = 0;
            this.NextButton.Text = "Далее";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.nextButton);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(55, 414);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(99, 24);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.cancelButton);
            // 
            // Checker
            // 
            this.Checker.AutoSize = true;
            this.Checker.Location = new System.Drawing.Point(645, 382);
            this.Checker.Name = "Checker";
            this.Checker.Size = new System.Drawing.Size(99, 17);
            this.Checker.TabIndex = 1;
            this.Checker.Text = "Вы согласны?";
            this.Checker.UseVisualStyleBackColor = true;
            this.Checker.CheckedChanged += new System.EventHandler(this.checkedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Лицензионное соглашение";
            // 
            // licenseText
            // 
            this.licenseText.Location = new System.Drawing.Point(55, 21);
            this.licenseText.Name = "licenseText";
            this.licenseText.Size = new System.Drawing.Size(689, 355);
            this.licenseText.TabIndex = 3;
            this.licenseText.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Checker);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.licenseText);
            this.Name = "Form1";
            this.Text = "Instalation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.CheckBox Checker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView licenseText;
    }
}

