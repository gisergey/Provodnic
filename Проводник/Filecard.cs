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
    class Filecard:EmpltyCard
    {
        public Filecard(int width,FileInfo file)
        {
            MainPanel = new Panel();
            NameFile = new Label();
            PicofFile = new PictureBox();

            MainPanel.Size = new Size(width - 50, 20);
            NameFile.Text = file.Name;
            NameFile.Location = new Point(40, 2);

            PicofFile.Size = new Size(20, 20);
            PicofFile.Location = new Point(0, 0);

            PicofFile.BackgroundImage = Properties.Resources.FilePicture;
            PicofFile.BackgroundImageLayout = ImageLayout.Stretch;
            MainPanel.Controls.Add(NameFile);
            MainPanel.Controls.Add(PicofFile);
            MainPanel.BackColor = Color.FromArgb(255, 255, 255);
            MainPanel.Tag = this;
        }

    
        public FileInfo File { get; set; }
        

    }
}
