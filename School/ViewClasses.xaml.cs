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
    /// Interaction logic for ViewClasses.xaml
    /// </summary>
    public partial class ViewClasses : Window
    {
        public ViewClasses()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            SchoolDataDataContext data = new SchoolDataDataContext();
            List<subject_t> subjects = (from s in data.subject_ts select s).ToList();

            ClassGrid.ItemsSource = subjects;
        }
    }
}
