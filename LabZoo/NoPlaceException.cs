using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabZoo
{
    public class NoPlaceException : Exception
    {
        public NoPlaceException(string e) : base(e)
        {

        }
    }
}
