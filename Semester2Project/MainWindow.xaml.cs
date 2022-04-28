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
        List<Structure> TekStructures = new List<Structure>();
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

            #region Stone Structures
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

            stonePilar.MaterialAmmount.Add(30);
            stonePilar.MaterialAmmount.Add(15);
            stonePilar.MaterialAmmount.Add(10);

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

            AllStructures.Add(stoneDoubleDoor);
            StoneStructures.Add(stoneDoubleDoor);
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
            #endregion

            #region Metal Structures
            #region Metal Wall
            Structure metalWall = new Structure() { Name = "Metal Wall" };
            metalWall.MaterialType.Add("Metal");
            metalWall.MaterialType.Add("CementingPaste");
            
            metalWall.MaterialAmmount.Add(25);
            metalWall.MaterialAmmount.Add(7);
           

            AllStructures.Add(metalWall);
            MetalStructures.Add(metalWall);
            Walls.Add(metalWall);
            #endregion

            #region Metal Foundation
            Structure metalFoundation = new Structure() { Name = "Metal Foundation" };
            metalFoundation.MaterialType.Add("Metal");
            metalFoundation.MaterialType.Add("CementingPaste");
            
            metalFoundation.MaterialAmmount.Add(50);
            metalFoundation.MaterialAmmount.Add(15);
            

            AllStructures.Add(metalFoundation);
            MetalStructures.Add(metalFoundation);
            Foundations.Add(metalFoundation);
            #endregion

            #region Metal Door Frame
            Structure metalDoorFrame = new Structure() { Name = "Metal Door Frame" };
            metalDoorFrame.MaterialType.Add("Metal");
            metalDoorFrame.MaterialType.Add("CementingPaste");

            metalDoorFrame.MaterialAmmount.Add(20);
            metalDoorFrame.MaterialAmmount.Add(6);

            AllStructures.Add(metalDoorFrame);
            MetalStructures.Add(metalDoorFrame);
            DoorFrames.Add(metalDoorFrame);
            #endregion

            #region Metal Door
            Structure metalDoor = new Structure() { Name = "Metal Door" };
            metalDoor.MaterialType.Add("Metal");
            metalDoor.MaterialType.Add("CementingPaste");

            metalDoor.MaterialAmmount.Add(10);
            metalDoor.MaterialAmmount.Add(4);

            AllStructures.Add(metalDoor);
            MetalStructures.Add(metalDoor);
            Doors.Add(metalDoor);
            #endregion

            #region Metal Pilar
            Structure metalPilar = new Structure() { Name = "Metal Pilar" };
            metalPilar.MaterialType.Add("Metal");
            metalPilar.MaterialType.Add("CementingPaste");

            metalPilar.MaterialAmmount.Add(25);
            metalPilar.MaterialAmmount.Add(7);

            AllStructures.Add(metalPilar);
            MetalStructures.Add(metalPilar);
            Pilars.Add(metalPilar);
            #endregion

            #region Metal Celing
            Structure metalCeling = new Structure() { Name = "Metal Celing" };
            metalCeling.MaterialType.Add("Metal");
            metalCeling.MaterialType.Add("CementingPaste");

            metalCeling.MaterialAmmount.Add(45);
            metalCeling.MaterialAmmount.Add(10);

            AllStructures.Add(metalCeling);
            MetalStructures.Add(metalCeling);
            Celings.Add(metalCeling);
            #endregion

            #region Metal Double Door Frame
            Structure metalDoubleDoorFrame = new Structure() { Name = "Metal Double Door Frame" };
            metalDoubleDoorFrame.MaterialType.Add("Metal");
            metalDoubleDoorFrame.MaterialType.Add("CementingPaste");

            metalDoubleDoorFrame.MaterialAmmount.Add(20);
            metalDoubleDoorFrame.MaterialAmmount.Add(6);

            AllStructures.Add(metalDoubleDoorFrame);
            MetalStructures.Add(metalDoubleDoorFrame);
            DoorFrames.Add(metalDoubleDoorFrame);
            #endregion

            #region Metal Double  Door
            Structure metalDoubleDoor = new Structure() { Name = "Metal Double Door" };
            metalDoubleDoor.MaterialType.Add("Metal");
            metalDoubleDoor.MaterialType.Add("CementingPaste");

            metalDoubleDoor.MaterialAmmount.Add(20);
            metalDoubleDoor.MaterialAmmount.Add(8);

            AllStructures.Add(metalDoubleDoor);
            MetalStructures.Add(metalDoubleDoor);
            Doors.Add(metalDoubleDoor);
            #endregion

            #region Metal Sloped Wall Left
            Structure metalSlopedWallL = new Structure() { Name = "Metal Sloped Wall Left" };
            metalSlopedWallL.MaterialType.Add("Metal");
            metalSlopedWallL.MaterialType.Add("CementingPaste");

            metalSlopedWallL.MaterialAmmount.Add(15);
            metalSlopedWallL.MaterialAmmount.Add(5);

            AllStructures.Add(metalSlopedWallL);
            MetalStructures.Add(metalSlopedWallL);
            SlopedWalls.Add(metalSlopedWallL);
            #endregion

            #region Metal Sloped Wall Right
            Structure metalSlopedWallR = new Structure() { Name = "Metal Sloped Wall Right" };
            metalSlopedWallR.MaterialType.Add("Metal");
            metalSlopedWallR.MaterialType.Add("CementingPaste");

            metalSlopedWallR.MaterialAmmount.Add(15);
            metalSlopedWallR.MaterialAmmount.Add(5);

            AllStructures.Add(metalSlopedWallR);
            MetalStructures.Add(metalSlopedWallR);
            SlopedWalls.Add(metalSlopedWallR);

            #endregion

            #region Metal Sloped Celing
            Structure metalSlopedCeling = new Structure() { Name = "Metal Sloped Celing" };
            metalSlopedCeling.MaterialType.Add("Metal");
            metalSlopedCeling.MaterialType.Add("CementingPaste");

            metalSlopedCeling.MaterialAmmount.Add(35);
            metalSlopedCeling.MaterialAmmount.Add(10);

            AllStructures.Add(metalSlopedCeling);
            MetalStructures.Add(metalSlopedCeling);
            SlopedCelings.Add(metalSlopedCeling);
            #endregion
            #endregion

            #region Tek Structures
            #region Tek Wall
            Structure tekWall = new Structure() { Name = "Tek Wall" };
            tekWall.MaterialType.Add("Metal");
            tekWall.MaterialType.Add("Polymer");
            tekWall.MaterialType.Add("Crystal");

            tekWall.MaterialAmmount.Add(35);
            tekWall.MaterialAmmount.Add(20);
            tekWall.MaterialAmmount.Add(15);

            AllStructures.Add(tekWall);
            TekStructures.Add(tekWall);
            Walls.Add(tekWall);
            #endregion

            #region Tek Foundation
            Structure tekFoundation = new Structure() { Name = "Tek Foundation" };
            tekFoundation.MaterialType.Add("Metal");
            tekFoundation.MaterialType.Add("Polymer");
            tekFoundation.MaterialType.Add("Crystal");

            tekFoundation.MaterialAmmount.Add(100);
            tekFoundation.MaterialAmmount.Add(45);
            tekFoundation.MaterialAmmount.Add(20);


            AllStructures.Add(tekFoundation);
            TekStructures.Add(tekFoundation);
            Foundations.Add(tekFoundation);
            #endregion

            #region Tek Door Frame
            Structure tekDoorFrame = new Structure() { Name = "Tek Door Frame" };
            tekDoorFrame.MaterialType.Add("Metal");
            tekDoorFrame.MaterialType.Add("Polymer");
            tekDoorFrame.MaterialType.Add("Crystal");

            tekDoorFrame.MaterialAmmount.Add(30);
            tekDoorFrame.MaterialAmmount.Add(15);
            tekDoorFrame.MaterialAmmount.Add(5);

            AllStructures.Add(tekDoorFrame);
            TekStructures.Add(tekDoorFrame);
            DoorFrames.Add(tekDoorFrame);
            #endregion

            #region Tek Door
            Structure tekDoor = new Structure() { Name = "Tek Door" };
            tekDoor.MaterialType.Add("Polymer");
            tekDoor.MaterialType.Add("Crystal");

            tekDoor.MaterialAmmount.Add(40);
            tekDoor.MaterialAmmount.Add(60);

            AllStructures.Add(tekDoor);
            TekStructures.Add(tekDoor);
            Doors.Add(tekDoor);
            #endregion

            #region Tek Pilar
            Structure tekPilar = new Structure() { Name = "Tek Pilar" };
            tekDoor.MaterialType.Add("Metal");
            tekDoor.MaterialType.Add("Polymer");
            tekDoor.MaterialType.Add("Crystal");

            tekDoor.MaterialAmmount.Add(60);
            tekDoor.MaterialAmmount.Add(14);
            tekDoor.MaterialAmmount.Add(10);

            AllStructures.Add(tekPilar);
            TekStructures.Add(tekPilar);
            Pilars.Add(tekPilar);
            #endregion

            #region Tek Celing
            Structure tekCeling = new Structure() { Name = "Tek Celing" };
            tekDoor.MaterialType.Add("Metal");
            tekDoor.MaterialType.Add("Polymer");
            tekDoor.MaterialType.Add("Crystal");

            tekDoor.MaterialAmmount.Add(50);
            tekDoor.MaterialAmmount.Add(25);
            tekDoor.MaterialAmmount.Add(20);

            AllStructures.Add(tekCeling);
            TekStructures.Add(tekCeling);
            Celings.Add(tekCeling);
            #endregion

            #region Tek Double Door Frame
            Structure tekDoubleDoorFrame = new Structure() { Name = "Tek Double Door Frame" };
            tekDoor.MaterialType.Add("Metal");
            tekDoor.MaterialType.Add("Polymer");
            tekDoor.MaterialType.Add("Crystal");

            tekDoor.MaterialAmmount.Add(30);
            tekDoor.MaterialAmmount.Add(15);
            tekDoor.MaterialAmmount.Add(5);

            AllStructures.Add(tekDoubleDoorFrame);
            TekStructures.Add(tekDoubleDoorFrame);
            DoorFrames.Add(tekDoubleDoorFrame);
            #endregion

            #region Tek Double  Door
            Structure tekDoubleDoor = new Structure() { Name = "Tek Double Door" };
            tekDoor.MaterialType.Add("Polymer");
            tekDoor.MaterialType.Add("Crystal");

            tekDoor.MaterialAmmount.Add(80);
            tekDoor.MaterialAmmount.Add(120);

            AllStructures.Add(tekDoubleDoor);
            TekStructures.Add(tekDoubleDoor);
            Doors.Add(tekDoubleDoor);
            #endregion

            #region Tek Sloped Wall Left
            Structure tekSlopedWallL = new Structure() { Name = "Tek Sloped Wall Left" };
            tekSlopedWallL.MaterialType.Add("Metal");
            tekSlopedWallL.MaterialType.Add("CementingPaste");

            tekSlopedWallL.MaterialAmmount.Add(15);
            tekSlopedWallL.MaterialAmmount.Add(5);

            AllStructures.Add(tekSlopedWallL);
            MetalStructures.Add(tekSlopedWallL);
            SlopedWalls.Add(tekSlopedWallL);
            #endregion

            #region Tek Sloped Wall Right
            Structure tekSlopedWallR = new Structure() { Name = "Tek Sloped Wall Right" };
            metalSlopedWallR.MaterialType.Add("Metal");
            metalSlopedWallR.MaterialType.Add("CementingPaste");

            metalSlopedWallR.MaterialAmmount.Add(15);
            metalSlopedWallR.MaterialAmmount.Add(5);

            AllStructures.Add(tekSlopedWallR);
            TekStructures.Add(tekSlopedWallR);
            SlopedWalls.Add(tekSlopedWallR);
            #endregion

            #region Tek Sloped Celing
            Structure tekSlopedCeling = new Structure() { Name = "Tek Sloped Celing" };
            tekSlopedCeling.MaterialType.Add("Metal");
            tekSlopedCeling.MaterialType.Add("CementingPaste");

            tekSlopedCeling.MaterialAmmount.Add(35);
            tekSlopedCeling.MaterialAmmount.Add(10);

            AllStructures.Add(tekSlopedCeling);
            TekStructures.Add(tekSlopedCeling);
            SlopedCelings.Add(tekSlopedCeling);
            #endregion
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
                case 3:
                    ListBoxStructures.ItemsSource = null;
                    ListBoxStructures.ItemsSource = TekStructures;
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
                case 3:
                    ListBoxStructures.ItemsSource = null;
                    ListBoxStructures.ItemsSource = Doors;
                    break;
                case 4:
                    ListBoxStructures.ItemsSource = null;
                    ListBoxStructures.ItemsSource = DoorFrames;
                    break;
                case 5:
                    ListBoxStructures.ItemsSource = null;
                    ListBoxStructures.ItemsSource = Celings;
                    break;
                case 6:
                    ListBoxStructures.ItemsSource = null;
                    ListBoxStructures.ItemsSource = SlopedWalls;
                    break;
                case 7:
                    ListBoxStructures.ItemsSource = null;
                    ListBoxStructures.ItemsSource = SlopedCelings;
                    break;
                case 8:
                    ListBoxStructures.ItemsSource = null;
                    ListBoxStructures.ItemsSource = Pilars;
                    break;

            }
        }
    }
}
