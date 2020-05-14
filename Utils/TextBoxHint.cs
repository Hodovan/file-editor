using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Utils
{
    public class TextBoxHint : System.Windows.Forms.TextBox
    {
        System.Drawing.Color DefaultColor;
        public string HintText { get; set; }


        public TextBoxHint(string hintText)
        {
            DefaultColor = this.ForeColor;

            this.GotFocus += (object sender, EventArgs e) =>
            {
                this.Text = String.Empty;
                this.ForeColor = DefaultColor;
            };

            this.LostFocus += (object sender, EventArgs e) =>
            {
                if (String.IsNullOrEmpty(this.Text) || this.Text == HintText)
                {
                    this.ForeColor = System.Drawing.Color.Gray;
                    this.Text = HintText;
                }
                else
                {
                    this.ForeColor = DefaultColor;
                }
            };

            if (!string.IsNullOrEmpty(hintText))
            {
                this.ForeColor = System.Drawing.Color.Gray;
                HintText = hintText;
                this.Text = hintText;
            }
        }
    }
}
