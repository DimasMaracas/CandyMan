using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CandyShop
{
    public partial class ServiceStation : Form
    {
        CProduct cp = new CProduct();
        int maxcod;
        public ServiceStation ()
        {
            InitializeComponent();

            #region заполнение списка товаров содержащихся внутри торгового автомата
                        

            cp.SetProd();
            maxcod = cp.Keys.Max();

            int i = 0;
            foreach (var item in cp)
            {
                cp = item.Value;
                dataGridView1.Rows.Add();
                dataGridView1[0, i].Value = item.Key;
                dataGridView1[1, i].Value = cp.description;
                dataGridView1[2, i].Value = cp.price;
                dataGridView1[3, i].Value = cp.count;
                i++;
            }
            cp.GetEnumerator().Reset();
            #endregion
        }

        

        private void dataGridView1_UserAddedRow (object sender, DataGridViewRowEventArgs e)
        {
            dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value = ++maxcod;
            cp.Add(maxcod, new CProduct());             
        }

        private void dataGridView1_CellEndEdit (object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;            
            cp[(int)dataGridView1[0, r].Value].description = (string)dataGridView1[1, r].Value;
            cp[(int)dataGridView1[0, r].Value].price =       (double)dataGridView1[2, r].Value;
            cp[(int)dataGridView1[0, r].Value].count =          (int)dataGridView1[3, r].Value;
            //cp[(int)dataGridView1[e.ColumnIndex, e.RowIndex].Value].position = (int)dataGridView1.CurrentCell.Value;

        }
    }
}
