using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka.Model
{
    public abstract class Resource
    {
        public string Id { get; set; }
        public int Year { get; set; }
    }
}
