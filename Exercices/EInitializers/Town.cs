using System.Collections.Generic;

namespace EInitializers
{
    public class Town
    {
        public string Name { get; set; }
        
        public IList<House> Houses { get; set; }

        public Town(string name)
        {
            Name = name;
        }

        public Town()
        {
        }

        public override string ToString()
        {
            string output = base.ToString() + "Name: " + Name + "\n";
            foreach (House house in Houses)
            {
                output += house.ToString() + "\n";
            }
            return output;
        }
    }
}