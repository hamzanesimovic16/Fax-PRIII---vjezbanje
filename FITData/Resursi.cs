using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace FITData
{
    public class Resursi
    {
        static ResourceManager tarik = new ResourceManager("FITData.Resource1", Assembly.GetExecutingAssembly());

        public static string Get(string name)
        {
            return tarik.GetString(name);
        }

    }
}
