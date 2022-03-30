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
        public List<string> CostDisplay()
        {
            
            foreach(var x in Cost)
            {
                return ("{0} x {1}", x.Value., x.Key.ToString());
            }
            
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
