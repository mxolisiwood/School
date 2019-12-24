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
using BusinessLogic;

namespace School
{
    /// <summary>
    /// Interaction logic for ViewStudents.xaml
    /// </summary>
    public partial class ViewStudents : Window
    {
        public ViewStudents()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SchoolDataDataContext data = new SchoolDataDataContext();
            List<student_t> students = (from s in data.student_ts select s).ToList();

            StudentGrid.ItemsSource = students;
        }

        private void StudentGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
