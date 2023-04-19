using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorXML
{
    [Keyless]
    public class XmlModel
    {
        //public int Id { get; set; }
        public string xml { get; set; }
    }
}
