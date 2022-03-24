using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semester2Project
{
    public class Material
    {
        public string Name { get; set; }
    }
    public class Structure
    {
        public string Name { get; set; }
        public Dictionary<string , int> Cost { get; set; }
        public string word { get; set; }
        public Structure()
        {
            this.Cost = new Dictionary<string, int>();
        }
        public override string ToString()
        {
            return (word);
        }
        public string CostDisplay()
        {
            string costs = "";
            foreach(var x in Cost)
            {
                costs = ("{0} x {1}", x.Value.ToString(), x.Key.ToString());
            }
            return costs;
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
