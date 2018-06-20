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
				var guid = new Guid("127e61cf-859c-4031-9a4e-33d465447ac0");
                var rez = context.UserBusiness.ReadByID(guid);
				//foreach (var item in rez)
				//{
					Console.WriteLine(rez.LastName);
				//}
				//Console.WriteLine(rez);
				Console.ReadLine();
            }
        }
    }
}
