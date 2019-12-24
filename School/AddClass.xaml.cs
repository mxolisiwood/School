using BusinessLogic;
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

namespace School
{
    /// <summary>
    /// Interaction logic for AddClass.xaml
    /// </summary>
    public partial class ViewClass : Window
    {
        public ViewClass()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            int credit;
            if (txtclass.Text.Trim() == "")
            {
                MessageBox.Show("Missing Class");
            }
            if (txtdescription.Text.Trim() == "")
            {
                MessageBox.Show("Description is required");
            }
            if (int.TryParse(txtcredits.Text, out credit) == false)
            {
                MessageBox.Show("You must enter a number");
            }

            else
            {
                subject_t subjects_ = new subject_t();
                subjects_.subject_name = txtclass.Text.Trim();
                subjects_.subject_desctiption = txtdescription.Text.Trim();
                subjects_.subject_credits = credit;

                Admin.AddClass(subjects_);
                MessageBox.Show(subjects_.subject_name + "Was added.");

                DialogResult = true;
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
