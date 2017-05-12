using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IEntity { }
    public class Promotion : IEntity
    {
        public string Name { get; set; }
        public Promotion(string name)
        {
            Name = name;
        }
        public List<IRule> Rules { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
