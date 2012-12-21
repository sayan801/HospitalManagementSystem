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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HospitalManagementSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void expander1_Expanded(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PatientsBrowser pb = new PatientsBrowser();
            pb.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            InstrumentsBrowser ib = new InstrumentsBrowser();
            ib.ShowDialog();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            PatientRegistration pr = new PatientRegistration();
            pr.ShowDialog();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            DoctorsBrowser db = new DoctorsBrowser();
            db.ShowDialog();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            BillingWindow bw = new BillingWindow();
            bw.ShowDialog();
        }

        private void Label_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            EmployeesBrowser eb = new EmployeesBrowser();
            eb.ShowDialog();
        }
    }
}
