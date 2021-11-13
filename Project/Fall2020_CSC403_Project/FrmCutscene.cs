using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmCutscene : ChildForm
    {
        private int cutsceneVar = 0;
        private FrmLevel frmLevel;

        public FrmCutscene()
        {
            InitializeComponent();
        }

        private void buttonProgressCutscene_Click(object sender, EventArgs e)
        {
            if(cutsceneVar == 0)
            {
                cutsceneVar = 1;
                pictureBoxCutscene.Image = Properties.Resources.cutscene2;
            }
            else if(cutsceneVar == 1)
            {
                cutsceneVar = 2;
                pictureBoxCutscene.Image = Properties.Resources.cutscene3;
            }
            else if(cutsceneVar == 2)
            {
                cutsceneVar = 3;
                pictureBoxCutscene.Image = Properties.Resources.cutscene4;
            }
            else if(cutsceneVar == 3)
            {
                cutsceneVar = 4;
                pictureBoxCutscene.Image = Properties.Resources.cutscene5;
            }
            else if(cutsceneVar == 4)
            {
                cutsceneVar = 5;
                pictureBoxCutscene.Image = Properties.Resources.cutscene6;
            }
            else if(cutsceneVar == 5)
            {
                cutsceneVar = 6;
                pictureBoxCutscene.Image = Properties.Resources.cutscene7;
            }
            else if(cutsceneVar == 6)
            {
                cutsceneVar = 7;
                pictureBoxCutscene.Image = Properties.Resources.cutscene8;
            }
            else if(cutsceneVar == 7)
            {
                cutsceneVar = 8;
                pictureBoxCutscene.Image = Properties.Resources.controls;
            }    
            else if(cutsceneVar == 8)
            {
                cutsceneVar = 0;
                FrmLevel.lose = false;
                frmLevel = (FrmLevel)CreateChild(new FrmLevel());
                frmLevel.MdiParent = this.MdiParent;
                frmLevel.RequestShow();
                pictureBoxCutscene.Image = Properties.Resources.cutscene1;
                Close();
            }
        }
    }
}
