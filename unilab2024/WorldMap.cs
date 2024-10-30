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
    public partial class WorldMap : Form
    {
        #region キー入力の設定等
        //会話用
        PictureBox pictureBox_Conv;
        byte[] Capt;
        List<Conversation> Conversations;

        private bool IsButtonToAnotherWorldEnabled;
        public WorldMap()
        {
            InitializeComponent();

            pictureBox_Conv = Func.CreatePictureBox_Conv(this);
            pictureBox_Conv.Click += new EventHandler(pictureBox_Conv_Click);

            this.KeyDown += new KeyEventHandler(WorldMap_KeyDown);
            this.KeyPreview = true;
        }
        #endregion

        #region 読み込み時
        private async void WorldMap_Load(object sender, EventArgs e)
        {
            // buttonに対する処理
            foreach (Control control in this.Controls)
            {
                if (control is CustomButton button)
                {
                    string NameWithoutButton = button.Name.Replace("button","");
                    if (int.TryParse(NameWithoutButton, out int i))
                    {
                        if (ClearCheck.IsButtonEnabled[i, 0])
                        {
                            button.ForeImage = null;
                            button.Cursor = Cursors.Hand;
                            if (ClearCheck.IsNew[i, 0])
                            {
                                button.BackColor = Color.FromArgb(255, 128, 128);
                                button.ConditionImage = Dictionaries.Img_Button["New"];
                            }
                            else if (ClearCheck.IsCleared[i, 0])
                            {
                                button.BackColor = Color.FromArgb(128, 255, 255);
                                button.ConditionImage = Dictionaries.Img_Button["Clear"];
                            }
                            else
                            {
                                button.ConditionImage = null;
                            }
                        }
                        else
                        {
                            button.ForeImage = Dictionaries.Img_Button["Lock"];
                            button.Cursor = Cursors.No;
                        }
                    }
                    else if(NameWithoutButton == "ToAnotherWorld")
                    {
                        if (ClearCheck.IsCleared[4, 0])
                        {
                            button.ForeImage = null;
                            button.Cursor = Cursors.Hand;
                            IsButtonToAnotherWorldEnabled = true;
                            if (Func.HasNewStageInWorld(false))
                            {
                                button.ConditionImage = Dictionaries.Img_Button["New"];
                            }
                            else if (Func.IsAllStageClearedInWorld(false))
                            {
                                button.ConditionImage = Dictionaries.Img_Button["Clear"];
                            }
                        }
                        else
                        {
                            button.ForeImage = Dictionaries.Img_Button["Lock"];
                            button.Cursor = Cursors.No;
                            IsButtonToAnotherWorldEnabled = false;
                            //button.Visible = false;
                            //button.Enabled = false;
                        }
                    }
                }
            }

            Func.ChangeControl(pictureBox_Conv, false);

            for (int i = 1; i < 4; i++)
            {
                if (ClearCheck.PlayAfterChapterI[i])
                {
                    ClearCheck.PlayAfterChapterI[i] = false;
                    string convFileName = "Story_AfterChapter" + i + "-WorldMap.csv";
                    Conversations = Func.LoadConversations(convFileName);
                    await Task.Delay((int)ConstNum.waitTime_Load);
                    Capt = Func.PlayConv(this, pictureBox_Conv,Conversations);
                    return;
                }
            }

            if (ClearCheck.PlayAfterChapter4Story)
            {
                string convFileName = "Story_AfterChapter4-WorldMap.csv";
                Conversations = Func.LoadConversations(convFileName);
                await Task.Delay((int)ConstNum.waitTime_Load);
                Capt = Func.PlayConv(this, pictureBox_Conv, Conversations);
            }
        }
        #endregion

        #region 会話用
        private void pictureBox_Conv_Click(object sender, EventArgs e)
        {
            Func.DrawConv(this,pictureBox_Conv, Capt, Conversations);
        }
        #endregion

        #region button押下後の処理

        private void buttonI_Click(object sender, EventArgs e)
        {
            CustomButton button = sender as CustomButton;
            if (button != null)
            {
                string NameWithoutButton = button.Name.Replace("button", "");
                if (int.TryParse(NameWithoutButton, out int i))
                {
                    if (!ClearCheck.IsButtonEnabled[i, 0]) return;
                    Func.CreateStageSelect(this, button.Text, i);
                }
            }
        }

        private void buttonToAnotherWorld_Click(object sender, EventArgs e)
        {
            if (!IsButtonToAnotherWorldEnabled) return;
            Func.CreateAnotherWorld(this);
        }
        #endregion

        #region クリアチェックスキップ用
        private void WorldMap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.M)
            {
                for (int i = 1; i <= 4; i++)
                {
                    for (int j = 0; j < (int)ConstNum.numStages; j++)
                    {
                        ClearCheck.IsNew[i, j] = false;
                        ClearCheck.IsCleared[i, j] = true;
                        ClearCheck.IsButtonEnabled[i, j] = true;
                    }
                }

                ClearCheck.PlayAfterChapter4Story = true;

                for (int i = 5; i < (int)ConstNum.numWorlds-1; i++)
                {
                    for (int j = 0; j <=1; j++)
                    {
                        ClearCheck.IsNew[i, j] = true;
                        ClearCheck.IsButtonEnabled[i, j] = true;
                    } 
                }
                
                Func.CreateWorldMap(this);
            }
        }
        #endregion
    }
}
