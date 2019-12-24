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
    /// Interaction logic for EditStudent.xaml
    /// </summary>
    public partial class EditStudent : Window
    {
        public EditStudent()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SchoolDataDataContext data = new SchoolDataDataContext();
            List<student_t> students = (from s in data.student_ts select s).ToList();
            EditGrid.ItemsSource = students;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            student_t selected = EditGrid.SelectedItem as student_t;
            if (selected == null)
            {
                MessageBox.Show("You must select one person");
            }
            UpdateStudent student = new UpdateStudent(selected);
            student.ShowDialog();
            Window_Loaded(null, null);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            student_t selected = EditGrid.SelectedItem as student_t;
            if (selected == null)
            {
                MessageBox.Show("You must select one person");
            }
            else
            {
                if (MessageBoxResult.Yes == MessageBox.Show("Are you sure?","Delete Srudent", MessageBoxButton.YesNo, MessageBoxImage.Warning))
                {
                    Admin.DeleteStudent(selected);
                    Window_Loaded(null, null);
                }
            }
        }
    }
}
