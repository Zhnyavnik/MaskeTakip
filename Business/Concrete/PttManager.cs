using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{

    public class PttManager : ISupplierService
    {
        private IApplicantService _applicantService;

        public PttManager(IApplicantService applicantService) //Constructor
        {
            _applicantService = applicantService;
        }

        public void GiveMask(Person person)
        {
            PersonManager personManager = new PersonManager();

            if (_applicantService.CheskPerson(person))
            {
                Console.WriteLine(person.FirstName + "için maske verildi.");
            }

            else
            {
                Console.WriteLine(person.FirstName + "için maske verilemedi.");
            }

        }
    }
}


