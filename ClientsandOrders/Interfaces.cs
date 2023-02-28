using ClientsandOrders.Common;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientsandOrders
{
   public  interface Interfaces<T> where T : BaseEntity   
    {
        public T  Add(T item);
        public void Update(T item);
        public void  Delete(T item);
        public T ShowClientsOrders(T item);
        public T Exit();
        public T OrderDate();
        public T GetbyID();
        public T AddDescription(T item);
        public T OrderPrice(T item);
        public T CloseDate(T item);
        
   }
}
