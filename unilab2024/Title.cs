using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unilab2024
{
    public partial class Title : Form
    {
        public Title()
        {
            InitializeComponent();
        }

        #region button押下後の処理
        private void buttonStart_Click(object sender, EventArgs e)
        {
            string worldName;
            int worldNumber;
            int level;
            switch (CurrentFormState.FormName)
            {
                case "Prologue":
                    Func.CreatePrologue(this);
                    break;
                case "WorldMap":
                    Func.CreateWorldMap(this);
                    break;
                case "AnotherWorld":
                    Func.CreateAnotherWorld(this);
                    break;
                case "StageSelect":
                    worldName = (string)CurrentFormState.StateData["WorldName"];
                    worldNumber = (int)CurrentFormState.StateData["WorldNumber"];
                    Func.CreateStageSelect(this,worldName, worldNumber);
                    break;
                case "Stage":
                    worldName = (string)CurrentFormState.StateData["WorldName"];
                    worldNumber = (int)CurrentFormState.StateData["WorldNumber"];
                    level = (int)CurrentFormState.StateData["Level"];
                    Func.CreateStage(this, worldName, worldNumber, level);
                    break;
            }
        }
        #endregion
    }
}
