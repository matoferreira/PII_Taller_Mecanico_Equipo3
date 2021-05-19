/*Acorde a los Patrones y principios vistos en clase:
Customer cumple con SRP porque tiene una sola razón de cambio,
la cual es por cómo esta compuesta la clase Customer.
Acorde Expert, es la experta en verificar que, a través de IdUtils, se cumpla con el requisito de que la ID sea válida*/
using System;

namespace Library
{
    public class Customer
    {
        public Customer(string name, string lastName, int numberPhone, string id)
        {
            this.Name = name;
            this.LastName = lastName;
            this.NumberPhone = numberPhone;
            this.ID = id;
        }

        private string name;

        private string lastName;

        private int numberPhone;

        private string id;

        public string Name
        {
            get
            {
                return this.name;
            }
            
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
            }
        }

             public string LastName
        {
            get
            {
                return this.lastName;
            }
            
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.lastName = value;
                }
            }
        }
        
            public int NumberPhone
        {
            get
            {
                return this.numberPhone;
            }
            
            set
            {
                
                this.numberPhone = value;
                
            }
        }

        public string ID
        {
            get
            {
                return this.id;
            }

            set
            {
                if (IdUtils.IdIsValid(value))
                {
                    this.id = value;
                }
            }
    }
    }
}

    
