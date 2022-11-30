using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_indexer.Interfaces
{
    public interface IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string ShowInfo();
    }
}
