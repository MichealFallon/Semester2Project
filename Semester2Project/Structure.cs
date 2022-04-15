using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semester2Project
{
    public class Structure
    {
        public string Name { get; set; }
        public List<string> MaterialType { get; set; }
        public List<int> MaterialAmmount { get; set; }
        public Structure()
        {
            MaterialType = new List<string>();
            MaterialAmmount = new List<int>();
            
        }
        public override string ToString()
        {
            return (Name);
        }
        
        //Provides string list of details in dictionary for display
        public List<string> CostDisplay()
        {

            List<string> details = new List<string>();
            for (int i = 0; i < MaterialType.Count; i++)
            {
                details.Add(string.Format("{0} x {1}", MaterialAmmount[i], MaterialType[i]));
            }

            return details;
        }

    }




















    //public class StoneWall
    //{
    //    public Dictionary<Material, int> Cost  { get; set; }

    //    public StoneWall()
    //    {
    //        this.Cost.Add(new Material() { Name = "Thatch" }, 15);
    //        this.Cost.Add(new Material() { Name = "Stone" }, 40);
    //        this.Cost.Add(new Material() { Name = "Wood" }, 20);
    //    }

    //}
}
