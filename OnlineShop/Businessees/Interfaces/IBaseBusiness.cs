using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Businessees.Interfaces
{
    public interface IBaseBusiness<T> where T : class
    {
        public List<T> GetAll();
        public bool Add(T item);
        public bool Delete(int id);
        public bool Update(T item);
    }
}
