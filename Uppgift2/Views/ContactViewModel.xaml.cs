using System;
using System.Collections.Generic;
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

namespace Uppgift2.Views
{
    /// <summary>
    /// Interaction logic for ContactViewModel.xaml
    /// </summary>
    public partial class ContactViewModel : UserControl
    {
        public ContactViewModel()
        {
            InitializeComponent();

            //skapar en lista med hard kodat värde
            var contacts = new List<string>() {
                "Donald",
                "Kalle",
                "Anka"
            };

            var roles = new List<string>()
            {
                "CEO",
                "Production Manager",
                "Web developer"
            };

            //loopar igenom hela contacts och lägger till ny kontakt till en contactList i xaml. Sedan ökar indexen med +1
            for (int i = 0; i < contacts.Count; i++)
            {
                contactList.Children.Add(new Controls.ContactControl() { ContactName = contacts[i], ContactRole = roles[i] });

            }

        }
    }
}
