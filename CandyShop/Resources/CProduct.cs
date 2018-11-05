using System;
using System.Collections;
using System.Collections.Generic;

namespace TestDB
{
    class CProduct : IDictionary<int, CProduct>
    {           
        public string description;  //описание
        public DateTime DateTime;   //дата и время продажи
        public double price;        //цена
        public uint count;          //количество товара

        Dictionary<int, CProduct> IProduct = new Dictionary<int, CProduct>();

        public ICollection<int> Keys
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public ICollection<CProduct> Values
        {
            get
            {
                throw new NotImplementedException();
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
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public CProduct()
        {            
            description = default(string);
            price = default(double);
            count = default(uint);
            DateTime = default(DateTime);
        }

        public CProduct(string Desc, double Price, uint Count, DateTime date_time)
        {            
            description = Desc;
            price = Price;
            count = Count;
            DateTime = date_time;
        }       

        public bool ContainsKey(int key)
        {
            throw new NotImplementedException();
        }

        public void Add(int key, CProduct value)
        {
            IProduct.Add(key, value);
        }

        public bool Remove(int key)
        {
            throw new NotImplementedException();
        }

        public bool TryGetValue(int key, out CProduct value)
        {
            throw new NotImplementedException();
        }

        public void Add(KeyValuePair<int, CProduct> item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(KeyValuePair<int, CProduct> item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(KeyValuePair<int, CProduct>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(KeyValuePair<int, CProduct> item)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<KeyValuePair<int, CProduct>> GetEnumerator()
        {
           return IProduct.GetEnumerator();
            //throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
