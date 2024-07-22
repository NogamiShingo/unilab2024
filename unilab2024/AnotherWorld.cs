﻿using System;
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
    public partial class AnotherWorld : Form
    {
        #region キー入力の設定等
        //会話用
        Dictionary<string, PictureBox> PictureBoxes;
        Dictionary<string, Bitmap> Bitmaps;
        List<Conversation> Conversations;
        public AnotherWorld()
        {
            InitializeComponent();

            (PictureBoxes, Bitmaps) = Func.CreateConvPictureBox(this);
            PictureBoxes["Dialogue"].Click += new EventHandler(pictureBox_Dialogue_Click);

            this.KeyDown += new KeyEventHandler(WorldMap_KeyDown);
            this.KeyPreview = true;
        }
        #endregion

        #region 読み込み時
        private void AnotherWorld_Load(object sender, EventArgs e)
        {
            // buttonに対する処理
            foreach (Control control in this.Controls)
            {
                if (control is CustomButton button)
                {
                    string NameWithoutButton = button.Name.Replace("button", "");
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
                    else if (NameWithoutButton == "ToWorldMap")
                    {
                        if (ClearCheck.IsCleared[4, 0])
                        {
                            button.ForeImage = null;
                            button.Cursor = Cursors.Hand;
                            if (Func.HasNewStageInWorld(true))
                            {
                                button.ConditionImage = Dictionaries.Img_Button["New"];
                            }
                            else if (Func.IsAllStageClearedInWorld(true))
                            {
                                button.ConditionImage = Dictionaries.Img_Button["Clear"];
                            }
                        }
                        else
                        {
                            button.ForeImage = Dictionaries.Img_Button["Lock"];
                            button.Cursor = Cursors.No;
                        }
                    }
                }
            }

            if (ClearCheck.PlayAfterChapter4Story)
            {
                ClearCheck.PlayAfterChapter4Story = false;
                string convFileName = "Story_AfterChapter4-AnotherWorld.csv";
                Conversations = Func.LoadConversations(convFileName);
                Func.StartConversations(this, PictureBoxes, Bitmaps, Conversations);
            }
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
        private void buttonToWorldMap_Click(object sender, EventArgs e)
        {
            Func.CreateWorldMap(this);
        }
        #endregion

        #region 会話用
        private void pictureBox_Dialogue_Click(object sender, EventArgs e)
        {
            Func.DrawConversations(this, PictureBoxes, Bitmaps, Conversations);
        }
        #endregion

        #region クリアチェックスキップ用
        private void WorldMap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.M)
            {
                for (int i = 5; i < (int)ConstNum.numWorlds; i++)
                {
                    for (int j = 0; j < (int)ConstNum.numStages; j++)
                    {   
                        ClearCheck.IsNew[i, j] = false;
                        ClearCheck.IsCleared[i, j] = true;
                        ClearCheck.IsButtonEnabled[i, j] = true;
                    }
                }

                Func.CreateAnotherWorld(this);
            }
        }
        #endregion
    }
}
