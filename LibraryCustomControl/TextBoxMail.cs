using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryCustomControl
{
    public class TextBoxMail : TextBox
    {
        public TextBoxMail()
        {
            this.Validating += TextBoxMail_Validating;
        }

        void TextBoxMail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
             TextBox txt = sender as TextBox;
                string emailform = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
                Regex reg = new Regex(emailform);
                if (!reg.IsMatch(txt.ToString()))
                {
                    errorProvider1.SetError(txt, "Không đúng định dạng");
                }
                else
                {
                    errorProvider1.SetError(txt, null);
                }
            }

            ErrorProvider errorProvider1 = new ErrorProvider();
        }
    }
