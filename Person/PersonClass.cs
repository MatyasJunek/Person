using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Person
{
    public class PersonClass : INotifyPropertyChanged
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



        public static ObservableCollection<PersonClass> AllPeople { get; set; } = new ObservableCollection<PersonClass>();

        public static void InitPeople()
        {
            AllPeople.Add( new PersonClass
            {
                Name = "Jan",
                Surname = "Kornienko",
                Date = new DateTime(2003, 6, 1, 7, 47, 0),
              
            });
            AllPeople.Add(new PersonClass
            {
                Name = "Josef",
                Surname = "Vejvoda",
                Date = new DateTime(1975, 9, 3, 5, 35, 0),
               
            });
            AllPeople.Add(new PersonClass
            {
                Name = "Matěj",
                Surname = "Petrík",
                Date = new DateTime(2002, 9, 10, 3, 25, 0),
               
            });
            AllPeople.Add(new PersonClass
            {
                Name = "Lukáš",
                Surname = "Novák",
                Date = new DateTime(1995, 7, 3, 7, 47, 0),
               
            });
        }
    }
}
