namespace Exercize_1_WinForms
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
            this.label1 = new System.Windows.Forms.Label();
            this.AValueTextBox = new System.Windows.Forms.TextBox();
            this.BValueTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GetAnswerButton = new System.Windows.Forms.Button();
            this.AnswerTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите первое число:";
            // 
            // AValueTextBox
            // 
            this.AValueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AValueTextBox.Location = new System.Drawing.Point(206, 12);
            this.AValueTextBox.Name = "AValueTextBox";
            this.AValueTextBox.Size = new System.Drawing.Size(170, 26);
            this.AValueTextBox.TabIndex = 1;
            // 
            // BValueTextBox
            // 
            this.BValueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BValueTextBox.Location = new System.Drawing.Point(206, 46);
            this.BValueTextBox.Name = "BValueTextBox";
            this.BValueTextBox.Size = new System.Drawing.Size(170, 26);
            this.BValueTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите второе число:";
            // 
            // GetAnswerButton
            // 
            this.GetAnswerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetAnswerButton.Location = new System.Drawing.Point(128, 78);
            this.GetAnswerButton.Name = "GetAnswerButton";
            this.GetAnswerButton.Size = new System.Drawing.Size(140, 34);
            this.GetAnswerButton.TabIndex = 4;
            this.GetAnswerButton.Text = "Получить ответ";
            this.GetAnswerButton.UseVisualStyleBackColor = true;
            this.GetAnswerButton.Click += new System.EventHandler(this.GetAnswerButton_Click);
            // 
            // AnswerTextBox
            // 
            this.AnswerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnswerTextBox.Location = new System.Drawing.Point(8, 118);
            this.AnswerTextBox.Name = "AnswerTextBox";
            this.AnswerTextBox.Size = new System.Drawing.Size(368, 194);
            this.AnswerTextBox.TabIndex = 5;
            this.AnswerTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 320);
            this.Controls.Add(this.AnswerTextBox);
            this.Controls.Add(this.GetAnswerButton);
            this.Controls.Add(this.BValueTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AValueTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AValueTextBox;
        private System.Windows.Forms.TextBox BValueTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GetAnswerButton;
        private System.Windows.Forms.RichTextBox AnswerTextBox;
    }
}

