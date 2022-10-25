using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Backend.Repositories
{
    public interface DbRepository<T> where T : class
    {
        public T Create(T entity);
        public List<T> ReadAll();
        public T ReadById(int id);  
        public T Update(T entity);
        public void Delete(T entity);
        public void DeleteById(int id);
    }
}
