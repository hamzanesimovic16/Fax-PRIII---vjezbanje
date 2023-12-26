using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace FITData
{
    public static class Ekstenzije
    {

        public static bool IsSet(this string sadrzaj)
        {
            return !string.IsNullOrWhiteSpace(sadrzaj);
        }


       
        public static void UcitajPodatke<T>(this ComboBox cb,List<T> dataSource, string valueMember="Id", string displayMember="Naziv")
        
        {
            cb.DataSource = dataSource;
            cb.ValueMember = $"{valueMember}";
            cb.DisplayMember = $"{displayMember}";
            
        }


        public static Image UcitajSliku(this byte[] data)
        {
            var ms=new MemoryStream(data);

            return Image.FromStream(ms);
        }

        public static byte[] PrebaciUBajtove(this Image slika)
        {
            var ms = new MemoryStream();
            slika.Save(ms, ImageFormat.Jpeg);
            return ms.ToArray();
        }
    }
}
