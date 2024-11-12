using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReTaskLibrary
{
    internal class CustomBookException:Exception
    {
        public CustomBookException(string message) : base(message)
        {
            
        }
    }
}
