using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3_PivniukOlha
{
    public class Storage    
    {     
        private Product[] _products;  
        public Storage(int size)
        {
            _products = new Product[size];
        }
        public Product this[int index]
        {
            get
            {
                return _products[index];
            }
        }
        public void Add(Product em)
        {
            Product[] tmp = new Product[_products.Length + 1];
            int i;
            for (i = 0; i < _products.Length; i++)
                tmp[i] = _products[i];
            tmp[i] = em;
            _products = tmp;
        }
        public void FillDataByInitialization()
        {          
             _products = new Product[6]
            {
                new Product ("Cabbage", 24),                              
                new Dairy_products ("Milk", 25, 3),
                new Dairy_products ("Sour cream", 35, 1),                
                new Dairy_products ("Butter", 56, 18),
                new Meat ("Dried meat", 87, CategoryProduct.HigherGrade, KindProduct.Veal),
                new Meat ("Sausage", 90, CategoryProduct.SecondGrade, KindProduct.Pork),         
            };
        }
        public void Print()
        {                             
            for (int i = 0; i < _products.Length; i++)
            {
                Console.Write(_products[i]);
                if (i < _products.Length - 1)
                {
                    Console.Write(",");
                }
            }
        }
        public Product[] FindAllMeatProducts()        
        {
            Product[] tmp = new Product[_products.Length + 1];
            int i = 0;
            foreach (var meat in _products)
            {               
                if (meat is Meat)
                {
                    tmp[i] = meat;
                    i++;
                }                            
            }
            return tmp;
        }
        public void ChangePriceByGivenPercentage()
        {            
            foreach (var product in _products)
            {               
                    product.ChangePrice(10);               
            }        
        }
    }
}
