using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalagring_CarDealership_FECore.Domain.Model
{
    class Car
    {
        public Car(string registrationNumber, string brand, string model, string makeYear, decimal price)
        {
            RegistrationNumber = registrationNumber;
            Brand = brand;
            Model = model;
            MakeYear = makeYear;
            Price = price;
        }

        public int Id { get; protected set; }
        public string RegistrationNumber { get; protected set; }
        public string Brand { get; protected set; }
        public string Model { get; protected set; }
        public string MakeYear { get; protected set; }
        public decimal Price { get; protected set; }
    }
}
