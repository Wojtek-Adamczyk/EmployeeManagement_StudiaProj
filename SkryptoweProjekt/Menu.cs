﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkryptoweProjekt
{
    internal class Menu
    {
        static public void CallMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1. Show all employees");
            Console.WriteLine("2. Search employees by:");
            Console.WriteLine("3. Add new employee");
            Console.WriteLine("4. Delete employee");
            Console.WriteLine("5. Change employee salary");
            Console.WriteLine("6. Change employee departament");
            Console.WriteLine("7. Log out");
        }

        public static void SearchEmployee()
        {
            Console.WriteLine();
            Console.WriteLine("1. by name");
            Console.WriteLine("2. by surname");
            Console.WriteLine("3. by departament");
            Console.WriteLine("4. by salary");
            Console.WriteLine("5. by date hired");
        }   
    }
}
