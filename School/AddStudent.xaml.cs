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
    /// Interaction logic for AddStudent.xaml
    /// </summary>
    public partial class AddStudent : Window
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            float gpa;
            if (txtfirstname.Text.Trim() == "")
            {
                MessageBox.Show("Missing First Name");
            }
             if (txtlastname.Text.Trim()== "")
             {
                MessageBox.Show("Missing Last Name");
             }
             if (Male.IsChecked == false && Female.IsChecked == false && Other.IsChecked == false)
             {
                MessageBox.Show("Choose one Gender");
             }
            if (Male.IsChecked == true && Female.IsChecked == true && Other.IsChecked == true)
            {
                MessageBox.Show("You must chose one");
            }
            if (float.TryParse(txtgpa.Text, out gpa) == false )
            {
                MessageBox.Show("You must enter a number");
            }
            else if (gpa < 0 || gpa > 5)
            {
                MessageBox.Show("GPA must be between 0 and 5");
            }
            else
            {
                student_t student_T = new student_t();
                student_T.first_name = txtfirstname.Text.Trim();
                student_T.last_name = txtlastname.Text.Trim();
                if (Male.IsChecked == true)
                    student_T.gender = "M";
                else if (Female.IsChecked == true)
                    student_T.gender = "F";
                else
                    student_T.gender = "O";
                student_T.gpa = gpa;

               // student_t student = null;
                Admin.AddStudent(student_T);
                MessageBox.Show(student_T.first_name + "Was added.");

                DialogResult = true;
                Window_MouseDoubleClick(null, null);

            }


        }

        private void Window_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
