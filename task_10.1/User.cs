using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_10._1
{
    class User
    {
        public string Surname { get; private set; }
        public string Name { get; private set; }
        public string Patronymic { get; private set; }

        private string phoneNumber;
        public string PhoneNumber
        {
            get { return $"+375{phoneNumber}"; }
            set
            {
                if (value.Length == 13 && value.StartsWith("+375"))   
                {
                    phoneNumber = value.Substring(4);
                }
                else if (value.Length == 9)
                {
                    phoneNumber = value;
                }
                    
            }
        }

        private string passportSeries;
        public string PassportSeries
        {
            get { return "**"; }
            set { passportSeries = value; }
        }

        private string passportNumber;
        public string PassportNumber
        {
            get { return "*******"; }
            set { passportNumber = value; }
        }

        public User()
        {
            Surname = "";
            Name = "";
            Patronymic = "";
            PhoneNumber = "";
            passportSeries = "";
            passportNumber = "";
        }

        public User(string surname, string name, string patronymic,
            string phoneNumber, string passportSeries, string passportNumber)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            PhoneNumber = phoneNumber;
            PassportSeries = passportSeries;
            PassportNumber = passportNumber;
        }

    }


}
