﻿using MobiManager.Business.Core;
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
                string rez = context.UserBusiness.ReadUserName("amanea");
				//foreach(var item in rez)
				//{
				//    Console.WriteLine(item.LastName);
				//}
				Console.WriteLine(rez);
                Console.ReadLine();
            }
        }
    }
}
