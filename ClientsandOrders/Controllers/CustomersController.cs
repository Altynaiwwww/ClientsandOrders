using ClientsandOrders.Common;
using ClientsandOrders.Data.Enteties;
using ClientsandOrders.SqlServer;
using Microsoft.EntityFrameworkCore;
using System;

namespace ClientsandOrders.Controllers
{
    public class Methods<T> : Interfaces<T>
    where T : BaseEntity
    {
        private readonly AppDBContext _context;

        public Methods(AppDBContext context)
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

      

        public void Delete(T item)
        {
            DbSet<T> dbSet = _context.Set<T>();

            if (dbSet == default(DbSet<T>))
                return;

            dbSet.Remove(item);
            _context.SaveChanges();
        }
    

        public void  Update(T item)
        {
            DbSet<T> dbSet = _context.Set<T>();

            if (dbSet != default(DbSet<T>))
                return;

             dbSet.Update(item);
            _context.SaveChanges();

        }

        public T ReturnToMenu()
        {
            Exit();
            return default(T);
        }

        private void Exit()
        {
            throw new NotImplementedException();
        }

        public T ShowClientsOrders(T item)
        {
            throw new NotImplementedException();

        }

        T Interfaces<T>.Exit()
        {
            throw new NotImplementedException();
        }

        public T OrderDate()
        {
            throw new NotImplementedException();
        }

        public T GetbyID()
        {
            throw new NotImplementedException();
        }

        public T AddDescription(T item)
        {
            throw new NotImplementedException();
        }

        public T OrderPrice(T item)
        {
            throw new NotImplementedException();
        }

        public T CloseDate(T item)
        {
            throw new NotImplementedException();
        }
    }

}      
