using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Person
{
    class PersonClass : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string name;
        public string Name
        {
            get => name;
            set { name = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name")); }
        }
        private string surname;
        public string Surname
        {
            get => surname;
            set { surname = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Surname")); }
        }



        private DateTime date;
        public DateTime Date
        {
            get => date;
            set { date = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Date")); }
        }

        private string id;
        public string Id
        {
            get => id;
            set { id = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Id")); }
        }

        public static Dictionary<string, PersonClass> AllPeople = new Dictionary<string, PersonClass>();

        public static void InitPeople()
        {
            AllPeople["1"] = new PersonClass
            {
                Name = "Jan",
                Surname = "Kornienko",
                Date = new DateTime(2003, 6, 1, 7, 47, 0),
                Id = "030601/0020"
            };
            AllPeople["2"] = new PersonClass
            {
                Name = "Josef",
                Surname = "Vejvoda",
                Date = new DateTime(1975, 9, 3, 5, 35, 0),
                Id = "750903/0225"
            };
            AllPeople["3"] = new PersonClass
            {
                Name = "Matěj",
                Surname = "Petrík",
                Date = new DateTime(2002, 9, 10, 3, 25, 0),
                Id = "020910/4510"
            };
            AllPeople["4"] = new PersonClass
            {
                Name = "Lukáš",
                Surname = "Novák",
                Date = new DateTime(1995, 7, 3, 7, 47, 0),
                Id = "950703/2222"
            };
        }
    }
}
