namespace RuEn_Dictionary
{
    partial class Form_Welcome
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
            this.LBL_Welcome = new System.Windows.Forms.Label();
            this.BTN_Continue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBL_Welcome
            // 
            this.LBL_Welcome.AutoSize = true;
            this.LBL_Welcome.Location = new System.Drawing.Point(29, 23);
            this.LBL_Welcome.Name = "LBL_Welcome";
            this.LBL_Welcome.Size = new System.Drawing.Size(258, 13);
            this.LBL_Welcome.TabIndex = 0;
            this.LBL_Welcome.Text = "Добро пожаловать в русско-английский словарь";
            // 
            // BTN_Continue
            // 
            this.BTN_Continue.Location = new System.Drawing.Point(116, 54);
            this.BTN_Continue.Name = "BTN_Continue";
            this.BTN_Continue.Size = new System.Drawing.Size(75, 23);
            this.BTN_Continue.TabIndex = 1;
            this.BTN_Continue.Text = "Продолжить";
            this.BTN_Continue.UseVisualStyleBackColor = true;
            this.BTN_Continue.Click += new System.EventHandler(this.BTN_Continue_Click);
            // 
            // Form_Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RuEn_Dictionary.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(331, 113);
            this.Controls.Add(this.BTN_Continue);
            this.Controls.Add(this.LBL_Welcome);
            this.Name = "Form_Welcome";
            this.Text = "Форма приветствия";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Welcome;
        private System.Windows.Forms.Button BTN_Continue;
    }
}

