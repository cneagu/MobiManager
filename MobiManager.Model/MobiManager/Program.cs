using MobiManager.Business.Core;
using MobiManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobiManager
{
    class Program
    {
        static void Main(string[] args)
        {
       
            using (BusinessContext context = new BusinessContext())
            {
                List<User> =context.UserBusiness.ReadAll();
                Console.WriteLine(rez);
                Console.ReadLine();
            }
        }
    }
}
