using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatternText
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textBox1.Text = Properties.Settings.Default.Subject;
            textBox2.Text = Properties.Settings.Default.Body;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Subject = textBox1.Text; // Записываем содержимое richTextBox1 в Save_text
            Properties.Settings.Default.Body = textBox2.Text;
            Properties.Settings.Default.Save(); // Сохраняем переменные.
            MessageBox.Show("Шаблон сохранен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }
    }
}
