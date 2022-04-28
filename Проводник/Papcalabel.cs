using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
namespace Проводник
{
    class Papcalabel:EmpltyCard
    {
        public Papcalabel(int width,DirectoryInfo dir)
        {
            MainPanel = new Panel();
            NameFile = new Label();
            PicofFile = new PictureBox();
       

            Direct = dir;
            MainPanel.Size = new Size(width - 50, 20);

            NameFile.Text = dir.Name;
            NameFile.Location = new Point(40, 2);


            PicofFile.Size = new Size(20, 20);
            PicofFile.Location = new Point(0, 0);
            PicofFile.BackgroundImage = Properties.Resources.DirectoryFile;
            PicofFile.BackgroundImageLayout= ImageLayout.Stretch;
            MainPanel.Controls.Add(NameFile);
            MainPanel.Controls.Add(PicofFile);
            MainPanel.BackColor = Color.FromArgb(255, 255, 255);
       
            MainPanel.Tag = this;
        }
        public DirectoryInfo Direct { get; private set; }
 
       
    }
}
