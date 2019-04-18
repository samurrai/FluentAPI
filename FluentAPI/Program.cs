﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new DataContext())
            {
                var users = context.Users.Where(user => user.Login == "login").ToList();
            }
        }
    }
}
