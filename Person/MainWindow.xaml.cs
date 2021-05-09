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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Person
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PersonClass.InitPeople();
            PersonClass p = new PersonClass();
            People.DataContext = p;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            People.SelectedIndex = 0; 
        }

        private void Person_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            PersonClass pc = (PersonClass)((sender as ListBox).SelectedItem);
            DataContext = pc;
        }

        private void People_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            PersonClass pc = (PersonClass)((sender as ListBox).SelectedItem);
           PersonEdit pce = new PersonEdit(pc);
            pce.ShowDialog();
        }
    }
}
