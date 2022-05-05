using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW11.Patterns
{
    public interface IRepository<T> : IDisposable where T : class
    {
        IEnumerable<T> GetList();  // Получаем все объекты
        T GetSingle(int id);       // Получение 1 объекта по id
        void Create(T student);    // Создание объекта
        void Update(T student);    // Изменение объекта
        void Delete(int id);       // Удаление объекта
        void Save();               // Сохранение объекта
    }
}
