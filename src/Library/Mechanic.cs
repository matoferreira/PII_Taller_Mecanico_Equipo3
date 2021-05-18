using System;

namespace Library
{
    public class Mechanic
    {
        private String name;
        private String lastName;
        private int cI;
        private int hourlyRate;
        private string speciality;
        public String Name;
        public String LastName;
        public int CI;
        public int HourlyRate;
        public string Speciality;
        public Mechanic (String name, string lastName, int cI, int hourlyRate, String speciality)
        {
            this.Name = name;
            this.LastName = lastName;
            this.CI = cI;
            this.HourlyRate = hourlyRate;
            this.Speciality = speciality;
        }
    }
}