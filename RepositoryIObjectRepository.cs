using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using static System.Console;

namespace console_test
{
    class RepositoryIObjectRepository
    {
        List<IObjectRepository> list;
        public RepositoryIObjectRepository()
        {
            list = new List<IObjectRepository>();
        }
        public void AddNewItem(IObjectRepository obj)=> list.Add(obj);
        public  IObjectRepository Get(int id) => list.FirstOrDefault(x => x.ID == id);
        public  IEnumerable<IObjectRepository> GetAll() => list;
        public void Delete(int value)
        {
            try
            {
                var deleteItem = list.FirstOrDefault(x => x.ID == value);
                list.Remove(deleteItem);
            }
            catch
            {

            }
        }
        public void Put(int value)
        {
            try
            {
                WriteLine($"{ list.FirstOrDefault(x => x.ID == value).ToString()}");
            }
            catch
            {

            }
        }

    }
}
