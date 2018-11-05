using System;
using System.Windows.Forms;

namespace CandyShop
{
    public partial class SrviceStation : Form
    {
        public SrviceStation ()
        {
            InitializeComponent();                       
        }

        private void dataGridView1_CellContentDoubleClick (object sender, DataGridViewCellEventArgs e)
        {

            // INSERT INTO product(destription, price, count_pr, position) VALUES('Сникерс', 65, 15, 22)
            /*
             INSERT INTO sale(id_product, date_price) VALUES (1, STRFTIME('%Y-%m-%d %H:%M', 'NOW'));
             UPDATE product SET count_pr = count_pr -1 WHERE id = 1;
             */
        }

        private void SrviceStation_Load (object sender, EventArgs e)
        {
            //int i = 0;
            //CProduct Products = new CProduct();
            //foreach (var p in Products.SetProd())
            //{
            //    CProduct cp = p.Value;
            //    dataGridView1.Rows.Add();

            //    dataGridView1[0, i].Value = cp.description;
            //    dataGridView1[1, i].Value = cp.price;
            //    dataGridView1[2, i].Value = cp.count;
            //    //dataGridView1[3, i].Value = cp.description;
            //    i++;
            //}         
        }
    }
}
