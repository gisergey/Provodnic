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
using System.Security.AccessControl;

namespace Проводник
{
    public partial class ProvodnicForm : Form
    {
        List<EmpltyCard> SeeFiles = new List<EmpltyCard>();
        public ProvodnicForm()
        {
            InitializeComponent();

        }

        private void ProvodnicForm_Load(object sender, EventArgs e)
        {
   
            ImageList imageList = new ImageList();
            imageList.Images.Add(Properties.Resources.DirectoryFile);
            imageList.Images.Add(Properties.Resources.FilePicture);
            imageList.Images.Add(Properties.Resources.DiskDrive);
            DiskTreeView.ImageList = imageList;
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                TreeNode node = new TreeNode();
                node.Text = drive.Name;
                node.ImageIndex = 2;
                node.SelectedImageIndex = 2;
                node.Tag = drive.Name;
                foreach (string directory in Directory.GetDirectories(drive.Name))
                    DirectoryAdd(node, new DirectoryInfo(directory));
                DiskTreeView.Nodes.Add(node);
            }

        }
        private bool CanIwatchthisdirectoryplease(string path)
        {
            try
            {
                Directory.GetDirectories(path);
                return true;
            }
            catch
            {
                return false;
            }
        }
        private void DirectoryAdd(TreeNode whereadd, DirectoryInfo directory)
        {

            TreeNode thisdirectory = new TreeNode();
            thisdirectory.Tag = directory.FullName;
            thisdirectory.Text = directory.Name;
            //if (CanIwatchthisdirectoryplease(directory.FullName))
            //{
            //    foreach (string dir in Directory.GetDirectories(directory.FullName))
            //        DirectoryAdd(thisdirectory, new DirectoryInfo(dir));
            //}
            whereadd.Nodes.Add(thisdirectory);

        }

        private void DiskTreeView_AfterExpand(object sender, TreeViewEventArgs e)
        {
            if (!e.Node.Nodes.Equals(null))
            {

                foreach (TreeNode noddd in e.Node.Nodes)
                {
                    if (noddd.Nodes.Count.Equals(0))
                    {
                        DirectoryInfo directory = new DirectoryInfo((string)noddd.Tag);
                        if (CanIwatchthisdirectoryplease(directory.FullName))
                        {
                            foreach (string dir in Directory.GetDirectories(directory.FullName))
                            {

                                DirectoryAdd(noddd, new DirectoryInfo(dir));

                            }


                        }
                    }
                }
            }
        }

        private void DiskTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            for (int i = 0; i < SeeFiles.Count; i++)
            {
                SplitContainer.Panel2.Controls.Remove(SeeFiles[i].MainPanel);
            }
            SeeFiles.Clear();
            RigthTextBox.Text = (string)e.Node.Tag;
            DirectoryInfo dir = new DirectoryInfo((string)e.Node.Tag);
            if (CanIwatchthisdirectoryplease(dir.FullName))
            {
                foreach (DirectoryInfo subdirs in dir.GetDirectories())
                {
                    Papcalabel dirpap = new Papcalabel(SplitContainer.Panel2.Size.Width, subdirs);

                    SeeFiles.Add(dirpap);
                }
                foreach(FileInfo subfile in dir.GetFiles())
                {
                    Filecard filepap = new Filecard(SplitContainer.Panel2.Size.Width, subfile);
                    SeeFiles.Add(filepap);
                }
                if (SeeFiles.Count == 0)
                {
                    SeeFiles.Add(new EmpltyCard());
                }
            }
            for(int i = 0; i < SeeFiles.Count; i++)
            {
                SeeFiles[i].MainPanel.Location = new Point(10, 30 + i * 60);
                SplitContainer.Panel2.Controls.Add(SeeFiles[i].MainPanel);
            }



        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ComandButtonPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
