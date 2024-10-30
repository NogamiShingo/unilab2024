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
    public partial class StageSelect : Form
    {
        #region 各種メンバ変数の定義など
        //会話用
        PictureBox pictureBox_Conv;
        byte[] Capt;
        List<Conversation> Conversations;

        public StageSelect()
        {
            InitializeComponent();

            pictureBox_Conv = Func.CreatePictureBox_Conv(this);
            pictureBox_Conv.Click += new EventHandler(pictureBox_Conv_Click);

            this.KeyDown += new KeyEventHandler(WorldMap_KeyDown);
            this.KeyPreview = true;
        }
        private string _worldName;  //WorldMapで選択された学年
        private int _worldNumber;

        public string WorldName     //こう書くと別フォームからアクセスできるっぽい。原理はよくわからん
        {
            get { return _worldName; }
            set { _worldName = value; }
            //別フォームからのアクセス例
            //StageSelect form = new StageSelect();
            //form.WorldName = "学年";
        }
        public int WorldNumber
        {
            get { return _worldNumber; }
            set { _worldNumber = value; }
        }
        #endregion

        #region 読み込み時
        private async void StageSelect_Load(object sender, EventArgs e)
        {
            pictureBox_Background.BackgroundImage = Dictionaries.Img_Background["StageSelect" + _worldNumber];
            labelWorld.Text = _worldName;   //学年表示の書き換え
            // buttonに対する処理
            foreach (Control control in this.Controls)
            {
                if (control is CustomButton button)
                {
                    string NameWithoutButton = button.Name.Replace("button_Stage", "");
                    if (int.TryParse(NameWithoutButton, out int j))
                    {
                        if (_worldNumber < 4)
                        {
                            button.Text = j + "科目め";
                        }
                        else if (_worldNumber == 4 || _worldNumber == 8)
                        {
                            switch (j)
                            {
                                case 1:
                                    switch (_worldNumber)
                                    {
                                        case 4:
                                            button.Location = new Point(643, 600);
                                            button.Text = "卒業試験";
                                            break;
                                        case 8:
                                            button.Size = new Size(400, 80);
                                            button.Location = new Point(568, 600);
                                            button.Text = "ドラゴン退治";
                                            break;
                                    }
                                    break;
                                case 2:
                                case 3:
                                    button.Enabled = false;
                                    button.Visible = false;
                                    break;
                            }
                        }
                        else
                        {
                            button.Text = "ステージ" + j;
                        }
                        if (ClearCheck.IsButtonEnabled[_worldNumber, j])
                        {
                            button.ForeImage = null;
                            button.Cursor = Cursors.Hand;
                            if (ClearCheck.IsNew[_worldNumber, j])
                            {
                                button.BackColor = Color.FromArgb(255, 128, 128);
                                button.ConditionImage = Dictionaries.Img_Button["New"];
                            }
                            else if (ClearCheck.IsCleared[_worldNumber, j])
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

                        if(_worldNumber > 4)
                        {
                            string itemName = "";
                            switch (_worldNumber)
                            {
                                case 5:
                                    itemName = "Snow";
                                    break;
                                case 6:
                                    itemName = "Fruit";
                                    break;
                                case 7:
                                    itemName = "Watch";
                                    break;
                                case 8:
                                    itemName = "Dragon";
                                    break;
                                default :
                                    break;
                            }
                            if (!ClearCheck.IsCleared[_worldNumber, j])
                            {
                                itemName += "Gray";
                            }
                            button.BackgroundImage = Dictionaries.Img_Button[itemName];
                            button.BackgroundImageLayout = ImageLayout.Zoom;
                        }

                    }
                    else
                    {
                        bool isWorldMap = true;
                        if (_worldNumber >= 5) isWorldMap = false;
                        //理工展仕様
                        //if (!ClearCheck.IsCleared[1, 0])
                        //{
                        //    button.Enabled = false;
                        //    button.Visible = false;
                        //}
                        if (Func.HasNewStageFromStageSelect(isWorldMap, _worldNumber))
                        {
                            button.ConditionImage = Dictionaries.Img_Button["New"];
                        }
                    }
                }
            }

            Func.ChangeControl(pictureBox_Conv, false);

            //理工展仕様
            if (ClearCheck.PlayBeforeFirstStage)
            {
                ClearCheck.PlayBeforeFirstStage = false;
                string convFileName = "Story_AfterChapter1-0StageSelect.csv";
                Conversations = Func.LoadConversations(convFileName);
                await Task.Delay((int)ConstNum.waitTime_Load);
                Capt = Func.PlayConv(this, pictureBox_Conv, Conversations);
            }
            else if (ClearCheck.PlayAfterFirstStage)
            {
                ClearCheck.PlayAfterFirstStage = false;
                string convFileName = "Story_AfterChapter1-1StageSelect.csv";
                Conversations = Func.LoadConversations(convFileName);
                await Task.Delay((int)ConstNum.waitTime_Load);
                Capt = Func.PlayConv(this, pictureBox_Conv, Conversations);
            }
            else if(ClearCheck.PlayAfterChapter4Story)
            {
                string convFileName = "Story_AfterChapter4-StageSelect.csv";
                Conversations = Func.LoadConversations(convFileName);
                await Task.Delay((int)ConstNum.waitTime_Load);
                Capt = Func.PlayConv(this, pictureBox_Conv, Conversations);
            }
        }
        #endregion

        #region 各種ボタン押下後の処理
        private void button_StageI_Click(object sender, EventArgs e)
        {
            CustomButton button = sender as CustomButton;
            if (button != null)
            {
                string NameWithoutButton = button.Name.Replace("button_Stage", "");
                if (int.TryParse(NameWithoutButton, out int j))
                {
                    if (!ClearCheck.IsButtonEnabled[_worldNumber, j]) return;
                    ClearCheck.IsNew[_worldNumber, j] = false;
                    Func.UpdateIsNew();
                    Func.CreateStage(this, _worldName, _worldNumber, j);
                }
            }
        }
        private void pictureBox_Conv_Click(object sender, EventArgs e)
        {
            Func.DrawConv(this, pictureBox_Conv, Capt, Conversations);
        }

        private void buttonToMap_Click(object sender, EventArgs e)
        {
            if (_worldNumber <= 4) Func.CreateWorldMap(this);
            else Func.CreateAnotherWorld(this);
        }
        #endregion

        #region クリアチェックスキップ用
        private void WorldMap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.M)
            {
                
                for (int j = 0; j < (int)ConstNum.numStages; j++)
                {
                    ClearCheck.IsNew[_worldNumber, j] = false;
                    ClearCheck.IsCleared[_worldNumber, j] = true;
                    ClearCheck.IsButtonEnabled[_worldNumber, j] = true;
                }
                if (_worldNumber < 4)
                {
                    for (int j = 0; j <= 1; j++)
                    {
                        ClearCheck.IsButtonEnabled[_worldNumber + 1, j] = true;
                        ClearCheck.IsNew[_worldNumber + 1, j] = true;
                    }
                }
                else if( _worldNumber == 4)
                {
                    
                    ClearCheck.PlayAfterChapter4Story = true;
                    
                    ClearCheck.IsCleared[4,0] = true;
                    for (int i = 5; i < (int)ConstNum.numWorlds; i++)
                    {
                        for(int j = 0; j <= 1; j++)
                        {
                            ClearCheck.IsButtonEnabled[i, j] = true;
                            ClearCheck.IsNew[i, j] = true;
                        }
                    }
                }
                else if( _worldNumber == 8)
                {
                    ClearCheck.Completed = true;
                    ClearCheck.PlayAfterAnotherWorldStory = true;
                }

                Func.CreateStageSelect(this,_worldName, _worldNumber);
            }
        }
        #endregion
    }
}
