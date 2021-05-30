using System;
using Entities.Concrete;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using MernisServiceReference1;

namespace Business.Concrete
{
    public class PersonManager: IApplicantService
    {
        
        //encapsulation
        public void ApplyForMask(Person person)
        {


        }
        public List<Person> Getlist()
        {
            return null;
        }
        
        public bool CheskPerson(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(person.NationalIdenty,person.FirstName,person.Surname,person.DateOfBirthYear))).Result.Body.TCKimlikNoDogrulaResult;
    
        }
    }
}
