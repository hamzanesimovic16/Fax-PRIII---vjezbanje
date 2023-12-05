using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FITData
{
    public static class Ekstenzije
    {

        public static bool IsSet(this string sadrzaj)
        {
            return !string.IsNullOrWhiteSpace(sadrzaj);
        }
    }
}
