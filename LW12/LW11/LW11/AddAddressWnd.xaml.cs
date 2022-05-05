using LW11.Classes;
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

namespace LW11
{
    /// <summary>
    /// Логика взаимодействия для AddAddressWnd.xaml
    /// </summary>
    public partial class AddAddressWnd : Window
    {
        public AddAddressWnd()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Address address = new Address();
            try
            {
                address.ID = Convert.ToInt32(IDBox.Text);
                address.Street = StreetBox.Text;
                address.City = CityBox.Text;
                address.Home = HomeBox.Text;
                address.C_Index = Convert.ToInt32(IndexBox.Text);

                MessageBox.Show("Address added!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            using (UniversityModel db = new UniversityModel())
            {
                try
                {
                    db.Addresses.Add(address);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            this.Close();
        }
    }
}
