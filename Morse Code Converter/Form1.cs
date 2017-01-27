using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Morse_Code_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {

            label1.Text = "";
            Dictionary<char, String> mcode = new Dictionary<char, String>()
            {
                {'a' , ".-"},
                { 'b' , "-..."},
                { 'c' , "-.-."},
                {'d' , "-.."},
                { 'e' , "."},
                { 'f' , "..-."},
                {'g' , "--."},
                { 'h' , "...."},
                { 'i' , ".."},
                {'j' , ".---"},
                { 'k' , "-.-"},
                { 'l' , ".-.."},
                {'m' , "--"},
                { 'n' , "-."},
                { 'o' , "---"},
                {'p' , ".--."},
                { 'q' , "--.-"},
                { 'r' , ".-."},
                {'s' , ".-."},
                { 't' , "-"},
                { 'u' , "..-"},
                {'v' , "...-"},
                { 'w' , ".--"},
                { 'x' , "-..-"},
                {'y' , "-.--"},
                { 'z' , "--.."},
                {'0' , "-----"},
                { '1' , ".----"},
                { '2' , "..----"},
                { '3' , "...--"},
                {'4' , "....-"},
                { '5' , "....."},
                { '6' , "-...."},
                { '7' , "--..."},
                {'8' , "---.."},
                { '9' , "----."},
            };
            string userText = textBox1.Text;
            userText = userText.ToLower();
            for (int index = 0; index < userText.Length; index++)
            {
                char x = userText[index];
                if (mcode.ContainsKey(x))
                {
                    label1.Text += (mcode[x]);
                }
            }
        }
    }
}
