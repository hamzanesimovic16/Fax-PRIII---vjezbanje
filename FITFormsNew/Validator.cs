using FITData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FITFormsNew
{
   public class Validator
    {
        public static bool Validiraj(Control box, ErrorProvider err, string poruka)
        {
            bool valid = true;


            if (box is PictureBox && (box as PictureBox).Image == null)
            {
                valid = false;
            }

            else if (box is ComboBox && (box as ComboBox).SelectedIndex < 0)
            {
                valid = false;
            }

            else if (box is TextBox && (box as TextBox).Text.IsSet() == false)
                valid = false;



            if (!valid)
            {
                err.SetError(box, poruka);
                return false;
            }
            err.Clear();
            return true;
        }
    }
}
