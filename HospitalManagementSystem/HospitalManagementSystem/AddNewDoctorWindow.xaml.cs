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

using System.Text.RegularExpressions;

namespace HospitalManagementSystem
{
    /// <summary>
    /// Interaction logic for AddNewCustomerWindow.xaml
    /// </summary>
    public partial class AddNewCustomerWindow : Window
    {
       
        public AddNewCustomerWindow()
        {
            InitializeComponent();
        }     

        #region validation
        private static bool onlyNumeric(string text)
        {
            Regex regex = new Regex("[^0-9.-]+"); //regex that matches disallowed text
            return !regex.IsMatch(text);
        }
        private static bool onlyAlphabet(string text)
        {
            Regex regex = new Regex("[^A-Z|^a-z|^ |^\t]"); //regex that matches disallowed text
            return !regex.IsMatch(text);
        }
        
        private static bool onlyAlphaNumeric(string text)
        {
            Regex regex = new Regex("^[a-zA-Z0-9]*$"); //regex that matches disallowed text
            return !regex.IsMatch(text);
        }

        private void NameDataTB_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !onlyAlphabet(e.Text);
        }

        private void AddrDataTB_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            //e.Handled = !onlyAlphaNumeric(e.Text);
        }

        private void phDataTB_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !onlyNumeric(e.Text);
        }

        private void vatdataTB_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = onlyAlphaNumeric(e.Text);
        }
        #endregion

        private void cancelBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
