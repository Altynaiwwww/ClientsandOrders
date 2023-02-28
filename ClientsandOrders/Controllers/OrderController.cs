using ClientsandOrders.Common;
using ClientsandOrders.SqlServer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ClientsandOrders.Controllers
{
    public class OrderController<T> : Interfaces<T>
        where T : BaseEntity
    {
        private readonly AppDBContext _context;
        private int Id;

        public OrderController(AppDBContext context)
        {
            _context = context;

        }

        public T Add(T item)
        {
            DbSet<T> dbSet = _context.Set<T>();

            if (dbSet == default(DbSet<T>))
                return default(T);

            T result = dbSet.Add(item).Entity;
            _context.SaveChanges();

            return result;

        }

       

        public T AddDescription(T item)
        {
            DbSet<T> dbSet = _context.Set<T>();

            if (dbSet == default(DbSet<T>))
                return default(T);

            T result = dbSet.Add(item).Entity;
            _context.SaveChanges();

            return result;
        }

       
        public T CloseDate(T item)
        {
            throw new NotImplementedException();
        }

        public void Delete(T item)
        {
            DbSet<T> dbSet = _context.Set<T>();

            if (dbSet == default(DbSet<T>))
                return;

            dbSet.Remove(item);
            _context.SaveChanges();
        }

        public T Exit()
        {
            throw new NotImplementedException();
        }

        public T GetbyID()
        {
            DbSet<T> dbSet = _context.Set<T>();

            if (dbSet == default(DbSet<T>))
                return default(T);

            T item = dbSet
                .FirstOrDefault(obj => obj.ID == Id);

            return item;
        }

        public T OrderDate()
        {
            throw new NotImplementedException();
        }

        public T OrderPrice( T item)
        {
            DbSet<T> dbSet = _context.Set<T>();

            if (dbSet == default(DbSet<T>))
                return default(T);

            T result = dbSet.Add(item).Entity;
            _context.SaveChanges();

            return result;
        }

        public T ShowClientsOrders(T item)
        {
            throw new NotImplementedException();
        }

        public void Update(T item)
        {
            DbSet<T> dbSet = _context.Set<T>();

            if (dbSet != default(DbSet<T>))
                return;

            dbSet.Update(item);
            _context.SaveChanges();
        }
    }
}
