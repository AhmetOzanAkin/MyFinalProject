using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    // generic constraint = jenerik kısıtlama
    // class = referans tip, 
    // IEntity'yi implement eden classların referanslarını al sadece
    // new() : new'lenebilir olmalı, interface newlenemediği için IEntity'yi de egale etmiş olduk
    public interface IEntityRepository<T> where T : class, IEntity, new() 
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null); // filtre kullanmamıza yarar. örneğin şu kategorideki şu fiyat aralığındaki ürünleri getir.
        T Get(Expression<Func<T, bool>> filter); // ürünün detaylarını listeler
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);        
    }
}
