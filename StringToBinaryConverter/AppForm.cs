using System;
using System.Linq;
using System.Text;
using MetroFramework.Forms;

namespace StringToBinaryConverter
{
    public partial class AppForm : MetroForm
    {
        public AppForm()
        {
            InitializeComponent();
        }

        private void inputText_TextChanged(object sender, EventArgs e)
        {
            string incomingText = inputText.Text;
            outText.Text = ToBinary(incomingText, Encoding.ASCII);
        }
        private string ToBinary(string text, Encoding encoding)
        {
            return string.Join(" ", encoding.
                GetBytes(text)
                .Select(t => Convert
                    .ToString(t, 2)
                    .PadLeft(8, '0')));
        }
    }
}
