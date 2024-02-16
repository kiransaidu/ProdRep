using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppProduct
{
    internal class ProductManagement
    {

        static SortedList<int, Products1> listProduct = new SortedList<int, Products1>()
       {
           {1,new Products1(){PName="books",PPrice=23.4,PBrand="bbbb",MfDate=new DateTime(day:2,month:3,year:2023),ExpDate=new DateTime(day:2,month:4,year:2025) } },
           {2,new Products1(){PName="Laptops",PPrice=80000.4,PBrand="llll",MfDate=new DateTime(day:3,month:3,year:2023),ExpDate=new DateTime(day:4,month:4,year:2034) } },
            {3,new Products1(){PName="phonew",PPrice=30000.4,PBrand="pppp",MfDate=new DateTime(day:1,month:1,year:2023),ExpDate=new DateTime(day:1,month:1,year:2029) } },
            {4,new Products1(){PName="Earphones",PPrice=300.4,PBrand="eeee",MfDate=new DateTime(day:2,month:2,year:2023),ExpDate=new DateTime(day:2,month:2,year:2029) } }
       };
        public SortedList<int, Products1> AllProducts()
        {
            return listProduct;
        }
    }
}
