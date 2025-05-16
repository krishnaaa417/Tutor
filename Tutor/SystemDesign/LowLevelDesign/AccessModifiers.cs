using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Tutor.SystemDesign.LowLevelDesign
{
    public class AccessModifiers
    {
        static void Main(string[] args)
        {
          Encaps e  = new Encaps();
            e.SetUserName("admin");
            e.SetPassword("password");

            Console.WriteLine(e.GetUserName());
            Console.WriteLine(e.GetPassword());
        }

    }

    public class Encaps
    {
        private string _username;
        private string _password;

        public void SetUserName(string username)
        {
            this._username = username;
        }

        public string GetUserName()
        {
            return _username;
        }

        public void SetPassword(string password)
        {
            this._password = password;
        }
        public string GetPassword()
        {
            return this._password;
        }
    }

    public class Car
    {
      public  string company;
        public int tyres;
        private double speed;

        public void Display()
        {
            Console.WriteLine(company);
            Console.WriteLine(tyres);
        }


    }
}
