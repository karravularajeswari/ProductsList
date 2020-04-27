using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCPractice.Models
{
    public class ProductData
    {
        public IEnumerable<Product> GetProducts
        {
            get
            {
                List<Product> prdts = new List<Product>()
                {
                    new Product{Pid=1,Pname="Sampoo",Pprice=270,photo="~/Folder/sampoo.jpg"},
                    new Product{Pid=2,Pname="Soap",Pprice=30,photo="~/Folder/soap.jpg"},
                    new Product{Pid=3,Pname="Oil",Pprice=160,photo="~/Folder/oil.jpg"},
                    new Product{Pid=4,Pname="Tv",Pprice=35000,photo="~/Folder/Tv.jpg"},
                    new Product{Pid=5,Pname="shoes",Pprice=2000,photo="~/Folder/shoes.jpg"}
                };
                return prdts;
            }
        }
    }
}