﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    static void Main(string[] args)
    {
        DelegateExercises delegateExercises = new DelegateExercises();
        delegateExercises.Method3();
        Console.ReadLine();
    }
}
public delegate void MyDelegate();

public class DelegateExercises
{
    void Method1()
    
         {
            System.Console.WriteLine("Method1");

        }
        public void Method3()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate();
        }
    }








