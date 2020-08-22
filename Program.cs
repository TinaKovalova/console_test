using System;

namespace console_test
{
    class Program
    {
        static void Main(string[] args)
        {
            var repo = new Repository();
            repo.GetAll();
            repo.Put();
            repo.Delete();
        }
    }
}
