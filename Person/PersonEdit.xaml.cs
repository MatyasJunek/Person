using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Person
{
    
    public partial class PersonEdit : Window
    {
        bool IsUpdating { get; set; }
        public PersonEdit()
        {
            InitializeComponent();
            DataContext = new PersonClass();
            IsUpdating = false;
        }
        public PersonEdit(PersonClass u)
        {
            InitializeComponent();
            DataContext = u;
            IsUpdating = true;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (IsUpdating == false)
            {
                PersonClass.AllPeople.Add((PersonClass)DataContext);
            }
            this.Close();
        }        
    }
}
