using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Business.Abstract;
using Business.Concrete;

namespace MaskeTakip
{
     class  Program
    {

        static void Main(string[] args)
        {

            Person person1 = new Person();
            person1.FirstName = "Zihni";
            person1.Surname = "YAVNIK";
            person1.DateOfBirthYear = 1996;
            person1.NationalIdenty = 37741878612;



            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
        }

       


    }
}
