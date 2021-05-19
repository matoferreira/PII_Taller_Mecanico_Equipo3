using System;

namespace Library
{
    public class Mechanic
    {
        public String Name {get;}
        public String LastName {get;}
        public int CI {get;}
        public int HourlyRate {get;}
        public string Speciality {get;}
        public string Role {get; set;}
        public Mechanic (String name, string lastName, int cI, int hourlyRate, String speciality, String role)
        {
            this.Name = name;
            this.LastName = lastName;
            this.CI = cI;
            this.HourlyRate = hourlyRate;
            this.Speciality = speciality;
            this.Role = role;
        }
    }
}