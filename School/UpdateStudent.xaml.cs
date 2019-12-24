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
    /// Interaction logic for UpdateStudent.xaml
    /// </summary>
    public partial class UpdateStudent : Window
    {
        private student_t student;
        public UpdateStudent(student_t student)
        {
            InitializeComponent();
            this.student = student;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtfirstname.Text = student.first_name.Trim();
            txtlastname.Text = student.last_name.Trim();
            txtgpa.Text = student.gpa.ToString();
            if (student.gender == "M")
                Male.IsChecked = true;
            else if (student.gender == "F")
                Female.IsChecked = true;
            else
                Other.IsChecked = true;





        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            float gpa;
            if (txtfirstname.Text.Trim() == "")
            {
                MessageBox.Show("Missing First Name");
            }
            if (txtlastname.Text.Trim() == "")
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
            if (float.TryParse(txtgpa.Text, out gpa) == false)
            {
                MessageBox.Show("You must enter a number");
            }
            else if (gpa < 0 || gpa > 5)
            {
                MessageBox.Show("GPA must be between 0 and 5");
            }
            else
            {
                
                student.first_name = txtfirstname.Text.Trim();
                student.last_name = txtlastname.Text.Trim();
                if (Male.IsChecked == true)
                    student.gender = "M";
                else if (Female.IsChecked == true)
                    student.gender = "F";
                else
                    student.gender = "O";
                student.gpa = gpa;

                // student_t student = null;
                Admin.UpdateStudent(student);
                MessageBox.Show(student.first_name + " Was updated.");

                DialogResult = true;

            }
        }

            void btnCancel_Click(object sender, RoutedEventArgs e)
            {
                DialogResult = false;
            }
        }
    }

