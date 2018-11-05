using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SQLite;

namespace CandyShop
{
    class CProduct : IDictionary<int, CProduct>, IEnumerable
    {        
        public string description { get; set; }  //описание        
        public double price { get; set; }        //цена
        public int count { get; set; }          //количество товара

        Dictionary<int, CProduct> IProduct = new Dictionary<int, CProduct>();

        
        public void SetProd ()
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=Mydb.db; Version=3;");
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM product", conn);
            
            conn.Open();
            try
            {
                SQLiteDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    Add(r.GetInt32(0), new CProduct(r[1], r[2], r[3]));
                }
                r.Close();
            }
            catch (SQLiteException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        public ICollection<int> Keys
        {
            get
            {
                return IProduct.Keys;
            }
        }

        public ICollection<CProduct> Values
        {
            get
            {
                return IProduct.Values;
            }
        }

        public int Count
        {
            get
            {
                return IProduct.Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public CProduct this[int key]
        {
            get
            {
                return IProduct[key];
            }

            set
            {
                
            }
        }

        public CProduct ()
        {
            //description = default(string);
            //price = default(double);
            //count = default(int);
            //DateTime = default(DateTime);
        }

        public CProduct (object Desc, object Price, object Count)
        {
            //cod = (int)id;
            description = (string)Desc;
            price = (double)Price;
            count = (int)Count;
        }

        public bool ContainsKey (int key)
        {
            throw new NotImplementedException();
        }

        public void Add (int key, CProduct value)
        {
            IProduct.Add(key, value);
        }

        public bool Remove (int key)
        {
            return IProduct.Remove(key);
        }

        public bool TryGetValue (int key, out CProduct value)
        {
            throw new NotImplementedException();
        }

        public void Add (KeyValuePair<int, CProduct> item)
        {
            throw new NotImplementedException();
        }

        public void Clear ()
        {
            throw new NotImplementedException();
        }

        public bool Contains (KeyValuePair<int, CProduct> item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo (KeyValuePair<int, CProduct>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove (KeyValuePair<int, CProduct> item)
        {
            return IProduct.Remove(item.Key);
        }

        public IEnumerator<KeyValuePair<int, CProduct>> GetEnumerator ()
        {
            return IProduct.GetEnumerator();
            //throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator ()
        {
            return (IEnumerator)IProduct.GetEnumerator();
        }

    }
}
