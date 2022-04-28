using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Проводник
{
    public partial class CreateDirectory : Form
    {
        private string path;
        public CreateDirectory(string path)
        {
            this.path = path;
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Equals(""))
            {
                MessageBox.Show("название папки не может быть пустым");
            }
            else if (textBox.Text.Contains(@"\"))
            {
                MessageBox.Show("название папки не может содеражать специальный символ");
                
            }
            else if ((new DirectoryInfo(path + @"\" + textBox.Text)).Exists)
            {
                MessageBox.Show("папки не могут повторяться в каталоге");
            }
            else
            {
                Directory.CreateDirectory(path + @"\" + textBox.Text);
                Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
