using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RuEn_Dictionary
{
    public partial class Form_AddRecord : Form
    {
        DictionaryContext db;

        public Form_AddRecord(DictionaryContext db)
        {
            InitializeComponent();
            this.db = db;
        }

        //add record button
        private void button1_Click(object sender, EventArgs e)
        {

            Record record = new Record();
            record.Rus = textBox1.Text;
            record.Eng = textBox2.Text;
            record.Transcription = textBox3.Text;
            record.Description = textBox4.Text;
            db.Records.Add(record);
            db.SaveChanges();

            this.Close();
        }
    }
}
