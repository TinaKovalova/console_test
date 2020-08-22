using System;
using System.Collections.Generic;

namespace console_test
{
    public class Repository
    {
        public int Get(int id)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<int> GetAll()
        {
            throw new NotImplementedException();
        }
        public void Put(int value)
        {
            System.Console.WriteLine();
        }
        public void Delete(int value)
        {
            System.Console.WriteLine();
        }
    }
}