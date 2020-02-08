namespace RuEn_Dictionary
{
    partial class Form_Main
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
            this.TB_Word = new System.Windows.Forms.TextBox();
            this.BTN_Find = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BTN_Add = new System.Windows.Forms.Button();
            this.LBL_Rus = new System.Windows.Forms.Label();
            this.LBL_Eng = new System.Windows.Forms.Label();
            this.LBL_Desciption = new System.Windows.Forms.Label();
            this.recordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dictionaryContextBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dictionaryContextBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.BTN_Del = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dictionaryContextBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dictionaryContextBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_Word
            // 
            this.TB_Word.Location = new System.Drawing.Point(27, 26);
            this.TB_Word.Name = "TB_Word";
            this.TB_Word.Size = new System.Drawing.Size(274, 20);
            this.TB_Word.TabIndex = 0;
            // 
            // BTN_Find
            // 
            this.BTN_Find.Image = global::RuEn_Dictionary.Properties.Resources.search;
            this.BTN_Find.Location = new System.Drawing.Point(307, 18);
            this.BTN_Find.Name = "BTN_Find";
            this.BTN_Find.Size = new System.Drawing.Size(41, 35);
            this.BTN_Find.TabIndex = 1;
            this.BTN_Find.UseVisualStyleBackColor = true;
            this.BTN_Find.Click += new System.EventHandler(this.BTN_Find_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(415, 258);
            this.dataGridView1.TabIndex = 2;
            // 
            // BTN_Add
            // 
            this.BTN_Add.Location = new System.Drawing.Point(433, 180);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(75, 23);
            this.BTN_Add.TabIndex = 3;
            this.BTN_Add.Text = "Добавить";
            this.BTN_Add.UseVisualStyleBackColor = true;
            this.BTN_Add.Click += new System.EventHandler(this.BTN_Add_Click);
            // 
            // LBL_Rus
            // 
            this.LBL_Rus.AutoSize = true;
            this.LBL_Rus.Location = new System.Drawing.Point(24, 95);
            this.LBL_Rus.Name = "LBL_Rus";
            this.LBL_Rus.Size = new System.Drawing.Size(23, 13);
            this.LBL_Rus.TabIndex = 4;
            this.LBL_Rus.Text = "RU";
            // 
            // LBL_Eng
            // 
            this.LBL_Eng.AutoSize = true;
            this.LBL_Eng.Location = new System.Drawing.Point(24, 131);
            this.LBL_Eng.Name = "LBL_Eng";
            this.LBL_Eng.Size = new System.Drawing.Size(22, 13);
            this.LBL_Eng.TabIndex = 5;
            this.LBL_Eng.Text = "EN";
            // 
            // LBL_Desciption
            // 
            this.LBL_Desciption.Location = new System.Drawing.Point(142, 95);
            this.LBL_Desciption.Name = "LBL_Desciption";
            this.LBL_Desciption.Size = new System.Drawing.Size(366, 70);
            this.LBL_Desciption.TabIndex = 6;
            this.LBL_Desciption.Text = "Des";
            // 
            // recordBindingSource
            // 
            this.recordBindingSource.DataSource = typeof(RuEn_Dictionary.Record);
            // 
            // dictionaryContextBindingSource
            // 
            this.dictionaryContextBindingSource.DataSource = typeof(RuEn_Dictionary.DictionaryContext);
            // 
            // dictionaryContextBindingSource1
            // 
            this.dictionaryContextBindingSource1.DataSource = typeof(RuEn_Dictionary.DictionaryContext);
            // 
            // BTN_Del
            // 
            this.BTN_Del.Location = new System.Drawing.Point(433, 209);
            this.BTN_Del.Name = "BTN_Del";
            this.BTN_Del.Size = new System.Drawing.Size(75, 23);
            this.BTN_Del.TabIndex = 7;
            this.BTN_Del.Text = "Удалить";
            this.BTN_Del.UseVisualStyleBackColor = true;
            this.BTN_Del.Click += new System.EventHandler(this.BTN_Del_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RuEn_Dictionary.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(524, 450);
            this.Controls.Add(this.BTN_Del);
            this.Controls.Add(this.LBL_Desciption);
            this.Controls.Add(this.LBL_Eng);
            this.Controls.Add(this.LBL_Rus);
            this.Controls.Add(this.BTN_Add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BTN_Find);
            this.Controls.Add(this.TB_Word);
            this.Name = "Form_Main";
            this.Text = "Главная форма";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dictionaryContextBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dictionaryContextBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Word;
        private System.Windows.Forms.Button BTN_Find;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BTN_Add;
        private System.Windows.Forms.Label LBL_Rus;
        private System.Windows.Forms.Label LBL_Eng;
        private System.Windows.Forms.Label LBL_Desciption;
        private System.Windows.Forms.BindingSource recordBindingSource;
        private System.Windows.Forms.BindingSource dictionaryContextBindingSource;
        private System.Windows.Forms.BindingSource dictionaryContextBindingSource1;
        private System.Windows.Forms.Button BTN_Del;
    }
}