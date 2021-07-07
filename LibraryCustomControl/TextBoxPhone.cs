using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryCustomControl
{
    public class TextBoxPhone : TextBox
    {
        public TextBoxPhone()
        {
            this.TextChanged += TextBoxPhone_TextChanged;
        }

        void TextBoxPhone_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider err = new ErrorProvider();
            TextBox tb = sender as TextBox;
            var regexItem = new Regex("^[a-zA-Z0-9 ]*$");
            if (!regexItem.IsMatch(tb.Text))
            {
                err.SetError(tb, "Không được chứa ký tự đặc biệt");
            }

            else
            {
                err.SetError(tb, null);
            } 
        }
    }
}
