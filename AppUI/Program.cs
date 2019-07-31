using SamuraiApp.Data;
using SamuraiApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppUI
{
    class Program
    {
        static void Main(string[] args)
        {
            InsertSamurai();
        }
        private static void InsertSamurai()
        {
            var samurai = new Samurai { Name = "Ichigo" };
            using (var context = new SamuraiContext())
            {
                context.Samurais.Add(samurai);
                context.SaveChanges();
            }
        }


    }
}
