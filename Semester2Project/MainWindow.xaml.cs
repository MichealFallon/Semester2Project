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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Semester2Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> AllStructures = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Material wood = new Material() { Name = "Wood" };
            //Material stone = new Material() { Name = "Stone" };
            //Material thatch = new Material() { Name = "Thatch" };
            Structure sw = new Structure() { Name = "Stone Wall", word = "Derp" };
            sw.Cost.Add("Wood", 1);

            AllStructures.Add(sw.Name);
            TextBlockCost.Text = "";
            
        }

        private void ListBoxStructures_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
