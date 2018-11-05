using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Collections;

namespace CandyShop
{
    public partial class FormShop : System.Windows.Forms.Form
    {
        public void number (string s)
        {
            if (label_pos.Text.Length > 1)
            {
                MessageBox.Show("Длина номера позиции товара не может превышать ДВУХ символов", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else { label_pos.Text += s; }
        }
        public FormShop()
        {
            InitializeComponent();
            
            //заполнение массива информацией с кодами товаров.
            //позиции записывать в .ini - файл            

        }
        #region Buttons
        private void FormShop_Load(object sender, EventArgs e)
        {

        }

        private void button_add_cash_Click(object sender, EventArgs e)
        {       
            label_money.Text = textBox_money.Text + " рублей.";
            textBox_money.Clear();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            number(button6.Text);
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void button1_Click (object sender, EventArgs e)
        {
            number(button1.Text);
        }

        private void button2_Click (object sender, EventArgs e)
        {
            number(button2.Text);
        }

        private void button3_Click (object sender, EventArgs e)
        {
            number(button3.Text);
        }

        private void button4_Click (object sender, EventArgs e)
        {
            number(button4.Text);
        }

        private void button5_Click (object sender, EventArgs e)
        {
            number(button5.Text);
        }

        private void button7_Click (object sender, EventArgs e)
        {
            number(button7.Text);
        }

        private void button8_Click (object sender, EventArgs e)
        {
            number(button8.Text);
        }

        private void button9_Click (object sender, EventArgs e)
        {
            number(button9.Text);
        }
#endregion
        private void button_delete_Click (object sender, EventArgs e)
        {            
            label_pos.Text = label_pos.Text.Trim('1','2','3','4','5','6','7','8','9');
        }

        

        private void выходToolStripMenuItem_Click (object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void button_get_staff_Click (object sender, EventArgs e)
        {
            //Выполняется запрос с уменьшением, на единицу, товарной позиции - продажей
            //Создаётся строка в в таблице sale с текущей продажей.

            //ГЛАВНОЙ ЗАДАЧЕЙ - является получение кода проданной позиции

            //SQLiteConnection conn = new SQLiteConnection("Data Source=Mydb.db; Version=3;");
            //SQLiteCommand cmd = new SQLiteCommand("INSERT INTO sale(id_product, date_price) VALUES (1, STRFTIME('%Y-%m-%d %H:%M', 'NOW'));" +
            // "UPDATE product SET count_pr = count_pr - 1 WHERE id = 1; ", conn);

            //conn.Open();
            //cmd.ExecuteNonQuery();
            //conn.Close();
        }

        private void сервисToolStripMenuItem_Click (object sender, EventArgs e)
        {
            ServiceStation sv = new ServiceStation();
            sv.ShowDialog();
        }
    }
}
