using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Concession

{
    public class ConcessionCalculator
    {
        public const int TotalFare = 500;
        public string CalculateConcession(int age)
            {
                if (age <= 5)
                {
                    return $"Little Champs - Free Ticket (Name: {Name}, Age: {age})";

                }
                else if (age > 60)
                {
                    double concessionAmount = TotalFare * 0.3;
                    return $"Senior Citizen - Fare: {TotalFare - concessionAmount:C} (Name: {Name}, Age: {age})";
                }
                else
                {
                    return $"Ticket Booked - Fare: {TotalFare:C} (Name: {Name}, Age: {age})";

                }

            }

            public string Name { get; set; }
            public int Age { get; set; }
            

        }
    }

