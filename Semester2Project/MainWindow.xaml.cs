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
        List<int> OrderCost = new List<int>();
        List<string> OrderCostDisplay = new List<string>();
        #region Material Lists
        List<Structure> StoneStructures = new List<Structure>();
        List<Structure> MetalStructures = new List<Structure>();
        List<String> OrderedStructures = new List<String>();
        #endregion
        #region Structure Type Lists
        List<Structure> Walls = new List<Structure>();
        List<Structure> Foundations = new List<Structure>();
        List<Structure> Doors = new List<Structure>();
        List<Structure> DoorFrames = new List<Structure>();
        List<Structure> Celings = new List<Structure>();
        List<Structure> SlopedWalls = new List<Structure>();
        List<Structure> SlopedCelings = new List<Structure>();
        List<Structure> Pilars = new List<Structure>();
        #endregion


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            #region OrderCostSetup
            //Stone
            OrderCost.Add(0);
            //Wood
            OrderCost.Add(0);
            //Thatch
            OrderCost.Add(0);
            //Metal
            OrderCost.Add(0);
            //CementingPaste
            OrderCost.Add(0);
            //Crystal
            OrderCost.Add(0);
            //Polymer
            OrderCost.Add(0);
            #endregion
            #region StoneWall
            Structure stoneWall = new Structure() { Name = "Stone Wall" };
            stoneWall.MaterialType.Add("Stone");
            stoneWall.MaterialType.Add("Wood");
            stoneWall.MaterialType.Add("Thatch");

            stoneWall.MaterialAmmount.Add(40);
            stoneWall.MaterialAmmount.Add(20);
            stoneWall.MaterialAmmount.Add(15);

            AllStructures.Add(stoneWall);
            StoneStructures.Add(stoneWall);
            Walls.Add(stoneWall);
            #endregion

            #region StoneFoundation
            Structure stoneFoundation = new Structure() { Name = "Stone Foundation" };
            stoneFoundation.MaterialType.Add("Stone");
            stoneFoundation.MaterialType.Add("Wood");
            stoneFoundation.MaterialType.Add("Thatch");

            stoneFoundation.MaterialAmmount.Add(80);
            stoneFoundation.MaterialAmmount.Add(40);
            stoneFoundation.MaterialAmmount.Add(30);

            AllStructures.Add(stoneFoundation);
            StoneStructures.Add(stoneFoundation);
            Foundations.Add(stoneFoundation);
            #endregion

            #region StoneDoorFrame
            Structure stoneDoorFrame = new Structure() { Name = "Stone Door Frame" };
            stoneDoorFrame.MaterialType.Add("Stone");
            stoneDoorFrame.MaterialType.Add("Wood");
            stoneDoorFrame.MaterialType.Add("Thatch");

            stoneDoorFrame.MaterialAmmount.Add(30);
            stoneDoorFrame.MaterialAmmount.Add(16);
            stoneDoorFrame.MaterialAmmount.Add(12);

            AllStructures.Add(stoneDoorFrame);
            StoneStructures.Add(stoneDoorFrame);
            DoorFrames.Add(stoneDoorFrame);
            #endregion

            #region StoneDoor
            Structure stoneDoor = new Structure() { Name = "Stone Door" };
            stoneDoor.MaterialType.Add("Stone");
            stoneDoor.MaterialType.Add("Wood");
            stoneDoor.MaterialType.Add("Thatch");

            stoneDoor.MaterialAmmount.Add(20);
            stoneDoor.MaterialAmmount.Add(14);
            stoneDoor.MaterialAmmount.Add(8);

            AllStructures.Add(stoneDoor);
            StoneStructures.Add(stoneDoor);
            Doors.Add(stoneDoor);
            #endregion

            #region StonePilar
            Structure stonePilar = new Structure() { Name = "Stone Pilar" };
            stonePilar.MaterialType.Add("Stone");
            stonePilar.MaterialType.Add("Wood");
            stonePilar.MaterialType.Add("Thatch");

            stonePilar.MaterialAmmount.Add(90);
            stonePilar.MaterialAmmount.Add(45);
            stonePilar.MaterialAmmount.Add(30);

            AllStructures.Add(stonePilar);
            StoneStructures.Add(stonePilar);
            Pilars.Add(stonePilar);
            #endregion

            #region StoneCeling
            Structure stoneCeling = new Structure() { Name = "Stone Celing" };
            stoneCeling.MaterialType.Add("Stone");
            stoneCeling.MaterialType.Add("Wood");
            stoneCeling.MaterialType.Add("Thatch");

            stoneCeling.MaterialAmmount.Add(60);
            stoneCeling.MaterialAmmount.Add(30);
            stoneCeling.MaterialAmmount.Add(20);

            AllStructures.Add(stoneCeling);
            StoneStructures.Add(stoneCeling);
            Celings.Add(stoneCeling);
            #endregion

            #region StoneDoubleDoorFrame
            Structure stoneDoubleDoorFrame = new Structure() { Name = "Stone Double Door Frame" };
            stoneDoubleDoorFrame.MaterialType.Add("Stone");
            stoneDoubleDoorFrame.MaterialType.Add("Wood");
            stoneDoubleDoorFrame.MaterialType.Add("Thatch");

            stoneDoubleDoorFrame.MaterialAmmount.Add(30);
            stoneDoubleDoorFrame.MaterialAmmount.Add(16);
            stoneDoubleDoorFrame.MaterialAmmount.Add(12);

            AllStructures.Add(stoneDoubleDoorFrame);
            StoneStructures.Add(stoneDoubleDoorFrame);
            DoorFrames.Add(stoneDoubleDoorFrame);
            #endregion

            #region StoneDoubleDoor
            Structure stoneDoubleDoor = new Structure() { Name = "Stone Double Door" };
            stoneDoubleDoor.MaterialType.Add("Stone");
            stoneDoubleDoor.MaterialType.Add("Wood");
            stoneDoubleDoor.MaterialType.Add("Thatch");

            stoneDoubleDoor.MaterialAmmount.Add(40);
            stoneDoubleDoor.MaterialAmmount.Add(28);
            stoneDoubleDoor.MaterialAmmount.Add(16);

            AllStructures.Add(stoneDoubleDoorFrame);
            StoneStructures.Add(stoneDoubleDoorFrame);
            Doors.Add(stoneDoubleDoor);
            #endregion

            #region StoneSlopedWallLeft
            Structure stoneSlopedWallL = new Structure() { Name = "Stone Sloped Wall Left" };
            stoneSlopedWallL.MaterialType.Add("Stone");
            stoneSlopedWallL.MaterialType.Add("Wood");
            stoneSlopedWallL.MaterialType.Add("Thatch");

            stoneSlopedWallL.MaterialAmmount.Add(20);
            stoneSlopedWallL.MaterialAmmount.Add(10);
            stoneSlopedWallL.MaterialAmmount.Add(10);

            AllStructures.Add(stoneSlopedWallL);
            StoneStructures.Add(stoneSlopedWallL);
            SlopedWalls.Add(stoneSlopedWallL);
            #endregion

            #region StoneSlopedWallRight
            Structure stoneSlopedWallR = new Structure() { Name = "Stone Sloped Wall Right" };
            stoneSlopedWallR.MaterialType.Add("Stone");
            stoneSlopedWallR.MaterialType.Add("Wood");
            stoneSlopedWallR.MaterialType.Add("Thatch");

            stoneSlopedWallR.MaterialAmmount.Add(20);
            stoneSlopedWallR.MaterialAmmount.Add(10);
            stoneSlopedWallR.MaterialAmmount.Add(10);

            AllStructures.Add(stoneSlopedWallR);
            StoneStructures.Add(stoneSlopedWallR);
            SlopedWalls.Add(stoneSlopedWallR);

            #endregion

            #region StoneSlopedCeling
            Structure stoneSlopedCeling = new Structure() { Name = "Stone Sloped Celing" };
            stoneSlopedCeling.MaterialType.Add("Stone");
            stoneSlopedCeling.MaterialType.Add("Wood");
            stoneSlopedCeling.MaterialType.Add("Thatch");

            stoneSlopedCeling.MaterialAmmount.Add(60);
            stoneSlopedCeling.MaterialAmmount.Add(30);
            stoneSlopedCeling.MaterialAmmount.Add(20);

            AllStructures.Add(stoneSlopedCeling);
            StoneStructures.Add(stoneSlopedCeling);
            SlopedCelings.Add(stoneSlopedCeling);
            #endregion




            OrderCostDisplay.Add(string.Format("{0} x Stone\n{1} x Wood\n{2} x Thatch\n{3} x Metal\n{4} x Cemeneting Paste\n{5} x Crystal\n{6} x Polymer", OrderCost[0], OrderCost[1], OrderCost[2], OrderCost[3], OrderCost[4], OrderCost[5], OrderCost[6]));

            ListBoxOrderCost.ItemsSource = null;
            ListBoxOrderCost.ItemsSource = OrderCostDisplay;
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
                //List order Stone-Wood-Thatch-Metal-CementingPaste-Cryatal-Polymer
                for(int i = 0; i < selected.MaterialType.Count;i++)
                {
                    switch(selected.MaterialType[i])
                    {
                        case "Stone":
                            OrderCost[0] += selected.MaterialAmmount[i];
                            break;
                        case "Wood":
                            OrderCost[1] += selected.MaterialAmmount[i];
                            break;
                        case "Thatch":
                            OrderCost[2] += selected.MaterialAmmount[i];
                            break;
                        case "Metal":
                            OrderCost[3] += selected.MaterialAmmount[i];
                            break;
                        case "CementingPaste":
                            OrderCost[4] += selected.MaterialAmmount[i];
                            break;
                        case "Crystal":
                            OrderCost[5] += selected.MaterialAmmount[i];
                            break;
                        case "Polymer":
                            OrderCost[6] += selected.MaterialAmmount[i];
                            break;

                    }
                }
                OrderCostDisplay.RemoveAt(0);
                OrderCostDisplay.Add(string.Format("{0} x Stone\n{1} x Wood\n{2} x Thatch\n{3} x Metal\n{4} x Cemeneting Paste\n{5} x Crystal\n{6} x Polymer", OrderCost[0], OrderCost[1], OrderCost[2], OrderCost[3], OrderCost[4], OrderCost[5], OrderCost[6]));

                ListBoxOrderCost.ItemsSource = null;
                ListBoxOrderCost.ItemsSource = OrderCostDisplay;
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
                    ListBoxStructures.ItemsSource = MetalStructures;
                    break;
            }
        }

        private void ComboBoxFilterByStructure_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int choice = ComboBoxFilterByStructure.SelectedIndex;

            switch (choice)
            {
                case 0:
                    ListBoxStructures.ItemsSource = null;
                    ListBoxStructures.ItemsSource = AllStructures;
                    break;
                case 1:
                    ListBoxStructures.ItemsSource = null;
                    ListBoxStructures.ItemsSource = Walls;
                    break;
                case 2:
                    ListBoxStructures.ItemsSource = null;
                    ListBoxStructures.ItemsSource = Foundations;
                    break;
            }
        }
    }
}
