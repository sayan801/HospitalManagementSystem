using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HospitalManagementSystem
{
    /// <summary>
    /// Interaction logic for DoctorsBrowser.xaml
    /// </summary>
    public partial class DoctorsBrowser : Window
    {
        public DoctorsBrowser()
        {
            InitializeComponent();
        }

        private void showPaymentsBtn_Click(object sender, RoutedEventArgs e)
        {
            AddNewCustomerWindow nd = new AddNewCustomerWindow();
            nd.ShowDialog();
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void printBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
