using System;
namespace RC3Students
{
    public class Student
    {
        public string Firstname;
        private string Middlename;
        public string Lastname;

        private int age;
        public string Homecountry;

        //constructor
        public Student (string _firstname,
                        string _Middlename,
                        string _Lastname
                        
                       )
        {
            Firstname = _firstname;
            Middlename = _Middlename;
            Lastname = _Lastname;

        }

        //fuctions
        public string GEtstudentname()
        {
            return Firstname + Lastname;
        }

        public string GETHomeCountry()
        {
            return Homecountry;
        }
    }
}
