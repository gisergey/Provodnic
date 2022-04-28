
namespace Проводник
{
    partial class ProvodnicForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProvodnicForm));
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.DiskTreeView = new System.Windows.Forms.TreeView();
            this.RigthTextBox = new System.Windows.Forms.TextBox();
            this.PanelforCommandbutton = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.Panel2.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // SplitContainer
            // 
            this.SplitContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer.Location = new System.Drawing.Point(0, 100);
            this.SplitContainer.Name = "SplitContainer";
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SplitContainer.Panel1.Controls.Add(this.DiskTreeView);
            this.SplitContainer.Panel1MinSize = 100;
            // 
            // SplitContainer.Panel2
            // 
            this.SplitContainer.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SplitContainer.Panel2.Controls.Add(this.RigthTextBox);
            this.SplitContainer.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.SplitContainer.Panel2MinSize = 100;
            this.SplitContainer.Size = new System.Drawing.Size(1142, 641);
            this.SplitContainer.SplitterDistance = 156;
            this.SplitContainer.TabIndex = 1;
            // 
            // DiskTreeView
            // 
            this.DiskTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DiskTreeView.Location = new System.Drawing.Point(0, 0);
            this.DiskTreeView.Name = "DiskTreeView";
            this.DiskTreeView.Size = new System.Drawing.Size(156, 641);
            this.DiskTreeView.TabIndex = 0;
            this.DiskTreeView.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.DiskTreeView_AfterExpand);
            this.DiskTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.DiskTreeView_AfterSelect);
            // 
            // RigthTextBox
            // 
            this.RigthTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.RigthTextBox.Location = new System.Drawing.Point(0, 0);
            this.RigthTextBox.Name = "RigthTextBox";
            this.RigthTextBox.ReadOnly = true;
            this.RigthTextBox.Size = new System.Drawing.Size(982, 20);
            this.RigthTextBox.TabIndex = 0;
            // 
            // PanelforCommandbutton
            // 
            this.PanelforCommandbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelforCommandbutton.Location = new System.Drawing.Point(0, 0);
            this.PanelforCommandbutton.Name = "PanelforCommandbutton";
            this.PanelforCommandbutton.Size = new System.Drawing.Size(1142, 100);
            this.PanelforCommandbutton.TabIndex = 2;
            // 
            // ProvodnicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 741);
            this.Controls.Add(this.SplitContainer);
            this.Controls.Add(this.PanelforCommandbutton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(356, 279);
            this.Name = "ProvodnicForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Проводник";
            this.Load += new System.EventHandler(this.ProvodnicForm_Load);
            this.SplitContainer.Panel1.ResumeLayout(false);
            this.SplitContainer.Panel2.ResumeLayout(false);
            this.SplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer SplitContainer;
        private System.Windows.Forms.TextBox RigthTextBox;
        private System.Windows.Forms.TreeView DiskTreeView;
        private System.Windows.Forms.Panel PanelforCommandbutton;
    }
}

