using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Проводник
{
    class EmpltyCard
    {
        public EmpltyCard()
        {
            MainPanel = new Panel();
            NameFile = new Label();
            NameFile.Text = "Пусто";
            MainPanel.Controls.Add(NameFile);
        }
        
        public Label NameFile { get; set; }
        public PictureBox PicofFile { get; set; }
        public Panel MainPanel { get; set; }
    }
}
