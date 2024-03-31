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
using ef_npd211.Data;
using ef_npd211.Data.Entities;

namespace ef_npd211
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ShopDbContext context = new();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            table.ItemsSource = context.Categories.ToList();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            table.ItemsSource = context.Products.ToList();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var order = new Order()
            {
                Date = DateTime.Now,
                TotalPrice = new Random().Next(50, 10000)
            };

            // add new item
            context.Orders.Add(order);

            // remove item by value
            //context.Orders.Remove(order);

            // find item by Id
            //var item = context.Orders.Find(2);
            // find item by condition
            //item = context.Orders.FirstOrDefault(i => i.TotalPrice > 5000);

            // send sql commands
            context.SaveChanges(); 
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            table.ItemsSource = context.Orders.OrderByDescending(x => x.TotalPrice).ToList();
        }
    }
}