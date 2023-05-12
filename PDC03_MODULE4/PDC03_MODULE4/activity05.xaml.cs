using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC03_MODULE4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class activity05 : ContentPage
    {
        List<Contacts> contacts;
        public activity05()
        {
            InitializeComponent();
            SetupData();
            listView.ItemsSource = contacts;
        }
        async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (listView.SelectedItem != null)
            {
                var detailPage = new DetailPage();
                detailPage.BindingContext = e.SelectedItem as Contacts;
                listView.SelectedItem = null;
                await Navigation.PushModalAsync(detailPage);
            }
        }

        void SetupData()
        {
            contacts = new List<Contacts>();
            contacts.Add(new Contacts
            {
                Name = "Killian Vitug",
                Age = 21,
                Occupation = "Student",
                Country = "Philippines"

            });

            contacts.Add(new Contacts
            {
                Name = "Korin Vitug",
                Age = 25,
                Occupation = "Brother",
                Country = "Philippines"

            });

            contacts.Add(new Contacts
            {
                Name = "Keith Vitug",
                Age = 27,
                Occupation = "Brother",
                Country = "Philippines"

            });

            contacts.Add(new Contacts
            {
                Name = "Kyle Vitug",
                Age = 30,
                Occupation = "Brother",
                Country = "Philippines"

            });

            contacts.Add(new Contacts
            {
                Name = "Evelyn Vitug",
                Age = 70,
                Occupation = "Mother",
                Country = "Philippines"

            });
        }
    }
}