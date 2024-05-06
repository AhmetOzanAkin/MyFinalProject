using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        // injection yap
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            // iş kodları buraya yazılacak. Bir iş sınıfı başka bir sınıfı new'lememelidir.
            //  Yetkisi var mı? 
            //  Aynı ürün tekrar ekleniyor mu?
            return _productDal.GetAll();
        }
    }
}
