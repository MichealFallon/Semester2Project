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
        List<Structure> AllStructures = new List<Structure>();
        List<Structure> WoodStructures = new List<Structure>();
        List<Structure> StoneStructures = new List<Structure>();
        List<String> OrderedStructures = new List<String>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ComboBoxFilterByMaterial.SelectedIndex = 0;
            Material wood = new Material() { Name = "Wood" };
            Material stone = new Material() { Name = "Stone" };
            Material thatch = new Material() { Name = "Thatch" };
            Material fibre = new Material() { Name = "Fibre" };
            
            Structure stoneWall = new Structure() { Name = "Stone Wall" };
            stoneWall.Cost.Add("Wood", 20);
            stoneWall.Cost.Add("Stone", 40);
            stoneWall.Cost.Add("Thatch", 15);
            AllStructures.Add(stoneWall);
            StoneStructures.Add(stoneWall);

            Structure stoneFoundation = new Structure() { Name = "Stone Foundation" };
            stoneFoundation.Cost.Add("Stone", 80);
            stoneFoundation.Cost.Add("Wood", 40);
            stoneFoundation.Cost.Add("Thatch", 30);
            AllStructures.Add(stoneFoundation);
            StoneStructures.Add(stoneFoundation);


            Structure stoneDoorFrame = new Structure() { Name = "Stone Door Frame" };
            stoneDoorFrame.Cost.Add("Stone", 30);
            stoneDoorFrame.Cost.Add("Wood", 16);
            stoneDoorFrame.Cost.Add("Thatch", 12);
            AllStructures.Add(stoneDoorFrame);
            StoneStructures.Add(stoneDoorFrame);

            Structure stoneDoor = new Structure() { Name = "Stone Door" };
            stoneDoor.Cost.Add("Stone", 20);
            stoneDoor.Cost.Add("Wood", 14);
            stoneDoor.Cost.Add("Thatch", 8);
            AllStructures.Add(stoneDoor);
            StoneStructures.Add(stoneDoor);

            Structure woodFoundation = new Structure() { Name = "Wooden Foundation" };
            woodFoundation.Cost.Add("Wood", 80);
            woodFoundation.Cost.Add("Thatch", 20);
            woodFoundation.Cost.Add("Fibre", 15);
            AllStructures.Add(woodFoundation);
            WoodStructures.Add(woodFoundation);

            
            
            ListBoxStructures.ItemsSource = AllStructures;

            
        }

        private void ListBoxStructures_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Structure Selected = ListBoxStructures.SelectedItem as Structure;
            if(Selected != null)
            {
                ListBoxCost.ItemsSource = Selected.CostDisplay();
            }
        }

        private void ButtonAddToOrder_Click(object sender, RoutedEventArgs e)
        {
            Structure selected = ListBoxStructures.SelectedItem as Structure;
            if(selected != null)
            {

                string quantityForDisplay = "1";
                int quantity = 1;
                if (TextBoxQuantity.Text != null && TextBoxQuantity.Text != "")
                {
                    quantityForDisplay = TextBoxQuantity.Text;
                    quantity = int.Parse(TextBoxQuantity.Text);
                }
                string displayString = string.Format("{0} x {1}",quantityForDisplay, selected.Name.ToString());
                OrderedStructures.Add(displayString);
                ListBoxOrder.ItemsSource = null;
                ListBoxOrder.ItemsSource = OrderedStructures;

            }
        }

        private void ComboBoxFilterByMaterial_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int choice = ComboBoxFilterByMaterial.SelectedIndex;
            
            switch(choice)
            {
                case 0:
                    ListBoxStructures.ItemsSource = null;
                    ListBoxStructures.ItemsSource = AllStructures;
                    break;
                case 1:
                    ListBoxStructures.ItemsSource = null;
                    ListBoxStructures.ItemsSource = StoneStructures;
                    break;
                case 2:
                    ListBoxStructures.ItemsSource = null;
                    ListBoxStructures.ItemsSource = WoodStructures;
                    break;
            }
        }

        private void ComboBoxFilterByStructure_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
