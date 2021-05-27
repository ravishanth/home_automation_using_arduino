using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOME3
{
    public partial class USER : Form
    {
        private int childFormNumber = 0;

        public USER()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dOORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DOOR DOOR = new DOOR();
            DOOR.Show();
        }

        private void lIGHTANDFANToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LIGHT_AND_FAN LIGHT_AND_FAN = new LIGHT_AND_FAN();
            LIGHT_AND_FAN.Show();

        }

        private void rOOM1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            USERLOGIN USERLOGIN = new USERLOGIN();
            USERLOGIN.Show();
        }

        private void dOORToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DOOR DOOR = new DOOR();
            DOOR.Show();
        }

        private void dOORToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DOOR DOOR = new DOOR();
            DOOR.Show();
        }

        private void lIGHTANDFANToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LIGHT_AND_FAN LIGHT_AND_FAN = new LIGHT_AND_FAN();
            LIGHT_AND_FAN.Show();
        }

        private void rOOM3ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lIGHTANDFANToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LIGHT_AND_FAN LIGHT_AND_FAN = new LIGHT_AND_FAN();
            LIGHT_AND_FAN.Show();
        }

        private void mAINDOORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DOOR DOOR = new DOOR();
            DOOR.Show();
        }

        private void USER_Load(object sender, EventArgs e)
        {

        }
    }
}
