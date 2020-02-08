using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RuEn_Dictionary
{
    public partial class Form_Main : Form
    {
        DictionaryContext db;

        public Form_Main()
        {
            InitializeComponent();

            db = new DictionaryContext();
            db.Records.Load();
            Console.WriteLine(db.Records.Local.Count());
            dataGridView1.DataSource = db.Records.Local.ToBindingList();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        //open form for add record
        private void BTN_Add_Click(object sender, EventArgs e)
        {
            Form_AddRecord form_AddRecord = new Form_AddRecord(db);
            form_AddRecord.ShowDialog();
            dataGridView1.DataSource = db.Records.Local.OrderBy(x => x.Rus).ToList();
        }

        //search record
        private void BTN_Find_Click(object sender, EventArgs e)
        {
            LBL_Rus.Text = string.Empty;
            LBL_Eng.Text = string.Empty;
            LBL_Desciption.Text = string.Empty;
            if (!ReferenceEquals(TB_Word.Text,null) && TB_Word.Text.Length>=1)
            {
                var record = db.Records.Local.Where(x => x.Rus.Trim() == TB_Word.Text).FirstOrDefault(); ;
                if (!ReferenceEquals(record,null))
                {
                    LBL_Rus.Text = record.Rus;
                    LBL_Eng.Text = record.Eng;
                    LBL_Desciption.Text = $"{record.Transcription} : {record.Description }";
                }
                else
                {
                    LBL_Desciption.Text = "Запись не найдена!";
                }
            }
            else
            {
                LBL_Desciption.Text = "Заполните поле поиска!";
            }
            TB_Word.Text = string.Empty;
        }

        //dell record
        private void BTN_Del_Click(object sender, EventArgs e)
        {
            var index = dataGridView1.CurrentCell.RowIndex;
            var value = dataGridView1[0, index].Value.ToString();
            Record record = db.Records.Local.FirstOrDefault(m => m.Rus == value);

            db.Records.Remove(record);
            db.SaveChanges();

            dataGridView1.DataSource = db.Records.Local.OrderBy(x => x.Rus).ToList();
        }
    }
}
