﻿namespace unilab2024
{
    partial class Stage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button_Start = new System.Windows.Forms.Button();
            this.button_ResetInput = new System.Windows.Forms.Button();
            this.button_A_Reset = new System.Windows.Forms.Button();
            this.button_Retry = new System.Windows.Forms.Button();
            this.button_Hint = new System.Windows.Forms.Button();
            this.listBox_Input = new System.Windows.Forms.ListBox();
            this.listBox_A = new System.Windows.Forms.ListBox();
            this.listBox_B = new System.Windows.Forms.ListBox();
            this.label_Result = new System.Windows.Forms.Label();
            this.label_Error = new System.Windows.Forms.Label();
            this.textBox_ForCount = new System.Windows.Forms.TextBox();
            this.label_Info = new System.Windows.Forms.Label();
            this.labelStageName = new System.Windows.Forms.Label();
            this.button_Explain = new System.Windows.Forms.Button();
            this.label_Input = new System.Windows.Forms.Label();
            this.label_A = new System.Windows.Forms.Label();
            this.label_B = new System.Windows.Forms.Label();
            this.button_Breset = new System.Windows.Forms.Button();
            this.pictureBox_Background = new System.Windows.Forms.PictureBox();
            this.uiButtonObject_for = new unilab2024.UIButtonObject();
            this.uiButtonObject_endfor = new unilab2024.UIButtonObject();
            this.uiButtonObject_B = new unilab2024.UIButtonObject();
            this.uiButtonObject_A = new unilab2024.UIButtonObject();
            this.uiButtonObject_down = new unilab2024.UIButtonObject();
            this.uiButtonObject_right = new unilab2024.UIButtonObject();
            this.uiButtonObject_left = new unilab2024.UIButtonObject();
            this.uiButtonObject_up = new unilab2024.UIButtonObject();
            this.button_ToMap = new unilab2024.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Background)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(38, 108);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1140, 1026);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(38, 108);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1140, 1026);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // button_Start
            // 
            this.button_Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Start.Font = new System.Drawing.Font("游明朝 Demibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Start.ForeColor = System.Drawing.Color.Navy;
            this.button_Start.Location = new System.Drawing.Point(1625, 1011);
            this.button_Start.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(372, 150);
            this.button_Start.TabIndex = 3;
            this.button_Start.Text = "出発！";
            this.button_Start.UseVisualStyleBackColor = false;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // button_ResetInput
            // 
            this.button_ResetInput.BackColor = System.Drawing.Color.Red;
            this.button_ResetInput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ResetInput.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button_ResetInput.FlatAppearance.BorderSize = 0;
            this.button_ResetInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ResetInput.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_ResetInput.ForeColor = System.Drawing.Color.White;
            this.button_ResetInput.Location = new System.Drawing.Point(1250, 160);
            this.button_ResetInput.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.button_ResetInput.Name = "button_ResetInput";
            this.button_ResetInput.Size = new System.Drawing.Size(148, 48);
            this.button_ResetInput.TabIndex = 4;
            this.button_ResetInput.Text = "リセット";
            this.button_ResetInput.UseVisualStyleBackColor = false;
            this.button_ResetInput.Click += new System.EventHandler(this.button_Input_Reset_Click);
            // 
            // button_A_Reset
            // 
            this.button_A_Reset.BackColor = System.Drawing.Color.Red;
            this.button_A_Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_A_Reset.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button_A_Reset.FlatAppearance.BorderSize = 0;
            this.button_A_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_A_Reset.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold);
            this.button_A_Reset.ForeColor = System.Drawing.Color.White;
            this.button_A_Reset.Location = new System.Drawing.Point(1667, 160);
            this.button_A_Reset.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.button_A_Reset.Name = "button_A_Reset";
            this.button_A_Reset.Size = new System.Drawing.Size(148, 48);
            this.button_A_Reset.TabIndex = 6;
            this.button_A_Reset.Text = "リセット";
            this.button_A_Reset.UseVisualStyleBackColor = false;
            this.button_A_Reset.Visible = false;
            this.button_A_Reset.Click += new System.EventHandler(this.button_A_Reset_Click);
            // 
            // button_Retry
            // 
            this.button_Retry.BackColor = System.Drawing.Color.Tomato;
            this.button_Retry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Retry.Font = new System.Drawing.Font("游明朝 Demibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Retry.ForeColor = System.Drawing.Color.White;
            this.button_Retry.Location = new System.Drawing.Point(2057, 1086);
            this.button_Retry.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.button_Retry.Name = "button_Retry";
            this.button_Retry.Size = new System.Drawing.Size(372, 75);
            this.button_Retry.TabIndex = 8;
            this.button_Retry.Text = "リトライ！";
            this.button_Retry.UseVisualStyleBackColor = false;
            this.button_Retry.Click += new System.EventHandler(this.button_Retry_Click);
            // 
            // button_Hint
            // 
            this.button_Hint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_Hint.Font = new System.Drawing.Font("游明朝 Demibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Hint.ForeColor = System.Drawing.Color.Black;
            this.button_Hint.Location = new System.Drawing.Point(452, 1162);
            this.button_Hint.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.button_Hint.Name = "button_Hint";
            this.button_Hint.Size = new System.Drawing.Size(258, 69);
            this.button_Hint.TabIndex = 10;
            this.button_Hint.Text = "ヒント！";
            this.button_Hint.UseVisualStyleBackColor = false;
            this.button_Hint.Visible = false;
            this.button_Hint.Click += new System.EventHandler(this.button_Hint_Click);
            // 
            // listBox_Input
            // 
            this.listBox_Input.BackColor = System.Drawing.Color.Black;
            this.listBox_Input.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.listBox_Input.ForeColor = System.Drawing.SystemColors.Info;
            this.listBox_Input.FormattingEnabled = true;
            this.listBox_Input.ItemHeight = 54;
            this.listBox_Input.Location = new System.Drawing.Point(1250, 225);
            this.listBox_Input.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.listBox_Input.Name = "listBox_Input";
            this.listBox_Input.Size = new System.Drawing.Size(701, 220);
            this.listBox_Input.TabIndex = 11;
            this.listBox_Input.Visible = false;
            this.listBox_Input.Click += new System.EventHandler(this.listBox_Input_Click);
            this.listBox_Input.DoubleClick += new System.EventHandler(this.Change_item_click);
            // 
            // listBox_A
            // 
            this.listBox_A.BackColor = System.Drawing.SystemColors.Info;
            this.listBox_A.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.listBox_A.FormattingEnabled = true;
            this.listBox_A.ItemHeight = 54;
            this.listBox_A.Location = new System.Drawing.Point(12500, 225);
            this.listBox_A.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.listBox_A.Name = "listBox_A";
            this.listBox_A.Size = new System.Drawing.Size(701, 220);
            this.listBox_A.TabIndex = 13;
            this.listBox_A.Visible = false;
            this.listBox_A.Click += new System.EventHandler(this.listBox_A_Click);
            // 
            // listBox_B
            // 
            this.listBox_B.BackColor = System.Drawing.SystemColors.Info;
            this.listBox_B.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.listBox_B.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBox_B.FormattingEnabled = true;
            this.listBox_B.ItemHeight = 54;
            this.listBox_B.Location = new System.Drawing.Point(1250, 225);
            this.listBox_B.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.listBox_B.Name = "listBox_B";
            this.listBox_B.Size = new System.Drawing.Size(701, 220);
            this.listBox_B.TabIndex = 14;
            this.listBox_B.Visible = false;
            this.listBox_B.Click += new System.EventHandler(this.listBox_B_Click);
            // 
            // label_Result
            // 
            this.label_Result.AutoSize = true;
            this.label_Result.BackColor = System.Drawing.Color.White;
            this.label_Result.Font = new System.Drawing.Font("游明朝 Demibold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_Result.ForeColor = System.Drawing.Color.Red;
            this.label_Result.Location = new System.Drawing.Point(393, 501);
            this.label_Result.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_Result.Name = "label_Result";
            this.label_Result.Size = new System.Drawing.Size(340, 124);
            this.label_Result.TabIndex = 16;
            this.label_Result.Text = "ミス！";
            // 
            // label_Error
            // 
            this.label_Error.AutoSize = true;
            this.label_Error.BackColor = System.Drawing.Color.White;
            this.label_Error.Font = new System.Drawing.Font("游明朝 Demibold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_Error.ForeColor = System.Drawing.Color.Red;
            this.label_Error.Location = new System.Drawing.Point(80, 360);
            this.label_Error.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_Error.Name = "label_Error";
            this.label_Error.Size = new System.Drawing.Size(340, 124);
            this.label_Error.TabIndex = 20;
            this.label_Error.Text = "ミス！";
            // 
            // textBox_ForCount
            // 
            this.textBox_ForCount.Font = new System.Drawing.Font("メイリオ", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_ForCount.Location = new System.Drawing.Point(1382, 549);
            this.textBox_ForCount.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_ForCount.Name = "textBox_ForCount";
            this.textBox_ForCount.Size = new System.Drawing.Size(77, 115);
            this.textBox_ForCount.TabIndex = 30;
            this.textBox_ForCount.Visible = false;
            this.textBox_ForCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_ForCount_KeyPress);
            // 
            // label_Info
            // 
            this.label_Info.AutoSize = true;
            this.label_Info.Font = new System.Drawing.Font("メイリオ", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_Info.Location = new System.Drawing.Point(1337, 432);
            this.label_Info.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Info.Name = "label_Info";
            this.label_Info.Size = new System.Drawing.Size(276, 108);
            this.label_Info.TabIndex = 31;
            this.label_Info.Text = "label1";
            this.label_Info.Visible = false;
            // 
            // labelStageName
            // 
            this.labelStageName.AutoSize = true;
            this.labelStageName.Font = new System.Drawing.Font("游ゴシック", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelStageName.Location = new System.Drawing.Point(25, 20);
            this.labelStageName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelStageName.Name = "labelStageName";
            this.labelStageName.Size = new System.Drawing.Size(348, 72);
            this.labelStageName.TabIndex = 36;
            this.labelStageName.Text = "StageName";
            // 
            // button_Explain
            // 
            this.button_Explain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_Explain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Explain.Font = new System.Drawing.Font("游明朝 Demibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Explain.ForeColor = System.Drawing.Color.Black;
            this.button_Explain.Location = new System.Drawing.Point(103, 1162);
            this.button_Explain.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.button_Explain.Name = "button_Explain";
            this.button_Explain.Size = new System.Drawing.Size(258, 69);
            this.button_Explain.TabIndex = 40;
            this.button_Explain.Text = "説明";
            this.button_Explain.UseVisualStyleBackColor = false;
            this.button_Explain.Click += new System.EventHandler(this.button_Explain_Click);
            // 
            // label_Input
            // 
            this.label_Input.AutoSize = true;
            this.label_Input.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label_Input.Font = new System.Drawing.Font("メイリオ", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_Input.Location = new System.Drawing.Point(1250, 75);
            this.label_Input.Name = "label_Input";
            this.label_Input.Size = new System.Drawing.Size(222, 72);
            this.label_Input.TabIndex = 41;
            this.label_Input.Text = "起動魔法";
            // 
            // label_A
            // 
            this.label_A.AutoSize = true;
            this.label_A.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label_A.Font = new System.Drawing.Font("メイリオ", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_A.Location = new System.Drawing.Point(1667, 75);
            this.label_A.Name = "label_A";
            this.label_A.Size = new System.Drawing.Size(210, 72);
            this.label_A.TabIndex = 42;
            this.label_A.Text = "Aの魔法";
            this.label_A.Visible = false;
            // 
            // label_B
            // 
            this.label_B.AutoSize = true;
            this.label_B.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label_B.Font = new System.Drawing.Font("メイリオ", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_B.Location = new System.Drawing.Point(2083, 75);
            this.label_B.Name = "label_B";
            this.label_B.Size = new System.Drawing.Size(209, 72);
            this.label_B.TabIndex = 43;
            this.label_B.Text = "Bの魔法";
            this.label_B.Visible = false;
            // 
            // button_Breset
            // 
            this.button_Breset.BackColor = System.Drawing.Color.Red;
            this.button_Breset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Breset.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button_Breset.FlatAppearance.BorderSize = 0;
            this.button_Breset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Breset.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold);
            this.button_Breset.ForeColor = System.Drawing.Color.White;
            this.button_Breset.Location = new System.Drawing.Point(2083, 160);
            this.button_Breset.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.button_Breset.Name = "button_Breset";
            this.button_Breset.Size = new System.Drawing.Size(148, 48);
            this.button_Breset.TabIndex = 44;
            this.button_Breset.Text = "リセット";
            this.button_Breset.UseVisualStyleBackColor = false;
            this.button_Breset.Visible = false;
            this.button_Breset.Click += new System.EventHandler(this.button_B_Reset_Click);
            // 
            // pictureBox_Background
            // 
            this.pictureBox_Background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Background.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Background.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBox_Background.Name = "pictureBox_Background";
            this.pictureBox_Background.Size = new System.Drawing.Size(2560, 1350);
            this.pictureBox_Background.TabIndex = 45;
            this.pictureBox_Background.TabStop = false;
            // 
            // uiButtonObject_for
            // 
            this.uiButtonObject_for.BackColor = System.Drawing.Color.Transparent;
            this.uiButtonObject_for.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiButtonObject_for.BackgroundImage")));
            this.uiButtonObject_for.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.uiButtonObject_for.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButtonObject_for.Location = new System.Drawing.Point(2000, 561);
            this.uiButtonObject_for.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.uiButtonObject_for.Name = "uiButtonObject_for";
            this.uiButtonObject_for.Size = new System.Drawing.Size(133, 120);
            this.uiButtonObject_for.TabIndex = 29;
            this.uiButtonObject_for.Click += new System.EventHandler(this.uiButtonObject_for_Click);
            // 
            // uiButtonObject_endfor
            // 
            this.uiButtonObject_endfor.BackColor = System.Drawing.Color.Transparent;
            this.uiButtonObject_endfor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiButtonObject_endfor.BackgroundImage")));
            this.uiButtonObject_endfor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.uiButtonObject_endfor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButtonObject_endfor.Location = new System.Drawing.Point(1875, 675);
            this.uiButtonObject_endfor.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.uiButtonObject_endfor.Name = "uiButtonObject_endfor";
            this.uiButtonObject_endfor.Size = new System.Drawing.Size(133, 120);
            this.uiButtonObject_endfor.TabIndex = 28;
            this.uiButtonObject_endfor.Click += new System.EventHandler(this.uiButtonObject_endfor_Click);
            // 
            // uiButtonObject_B
            // 
            this.uiButtonObject_B.BackColor = System.Drawing.Color.Transparent;
            this.uiButtonObject_B.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiButtonObject_B.BackgroundImage")));
            this.uiButtonObject_B.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.uiButtonObject_B.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButtonObject_B.Location = new System.Drawing.Point(2000, 789);
            this.uiButtonObject_B.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.uiButtonObject_B.Name = "uiButtonObject_B";
            this.uiButtonObject_B.Size = new System.Drawing.Size(133, 120);
            this.uiButtonObject_B.TabIndex = 27;
            this.uiButtonObject_B.Click += new System.EventHandler(this.uiButtonObject_B_Click);
            // 
            // uiButtonObject_A
            // 
            this.uiButtonObject_A.BackColor = System.Drawing.Color.Transparent;
            this.uiButtonObject_A.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiButtonObject_A.BackgroundImage")));
            this.uiButtonObject_A.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.uiButtonObject_A.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButtonObject_A.Location = new System.Drawing.Point(2125, 675);
            this.uiButtonObject_A.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.uiButtonObject_A.Name = "uiButtonObject_A";
            this.uiButtonObject_A.Size = new System.Drawing.Size(133, 120);
            this.uiButtonObject_A.TabIndex = 26;
            this.uiButtonObject_A.Click += new System.EventHandler(this.uiButtonObject_A_Click);
            // 
            // uiButtonObject_down
            // 
            this.uiButtonObject_down.BackColor = System.Drawing.Color.Transparent;
            this.uiButtonObject_down.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiButtonObject_down.BackgroundImage")));
            this.uiButtonObject_down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.uiButtonObject_down.Cursor = System.Windows.Forms.Cursors.PanSouth;
            this.uiButtonObject_down.Location = new System.Drawing.Point(1542, 789);
            this.uiButtonObject_down.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.uiButtonObject_down.Name = "uiButtonObject_down";
            this.uiButtonObject_down.Size = new System.Drawing.Size(133, 120);
            this.uiButtonObject_down.TabIndex = 25;
            this.uiButtonObject_down.Click += new System.EventHandler(this.uiButtonObject_down_Click);
            // 
            // uiButtonObject_right
            // 
            this.uiButtonObject_right.BackColor = System.Drawing.Color.Transparent;
            this.uiButtonObject_right.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiButtonObject_right.BackgroundImage")));
            this.uiButtonObject_right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.uiButtonObject_right.Cursor = System.Windows.Forms.Cursors.PanEast;
            this.uiButtonObject_right.Location = new System.Drawing.Point(1667, 675);
            this.uiButtonObject_right.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.uiButtonObject_right.Name = "uiButtonObject_right";
            this.uiButtonObject_right.Size = new System.Drawing.Size(133, 120);
            this.uiButtonObject_right.TabIndex = 24;
            this.uiButtonObject_right.Click += new System.EventHandler(this.uiButtonObject_right_Click);
            // 
            // uiButtonObject_left
            // 
            this.uiButtonObject_left.BackColor = System.Drawing.Color.Transparent;
            this.uiButtonObject_left.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiButtonObject_left.BackgroundImage")));
            this.uiButtonObject_left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.uiButtonObject_left.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.uiButtonObject_left.Location = new System.Drawing.Point(1417, 675);
            this.uiButtonObject_left.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.uiButtonObject_left.Name = "uiButtonObject_left";
            this.uiButtonObject_left.Size = new System.Drawing.Size(133, 120);
            this.uiButtonObject_left.TabIndex = 23;
            this.uiButtonObject_left.Click += new System.EventHandler(this.uiButtonObject_left_Click);
            // 
            // uiButtonObject_up
            // 
            this.uiButtonObject_up.BackColor = System.Drawing.Color.Transparent;
            this.uiButtonObject_up.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiButtonObject_up.BackgroundImage")));
            this.uiButtonObject_up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.uiButtonObject_up.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.uiButtonObject_up.Location = new System.Drawing.Point(1542, 561);
            this.uiButtonObject_up.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.uiButtonObject_up.Name = "uiButtonObject_up";
            this.uiButtonObject_up.Size = new System.Drawing.Size(133, 120);
            this.uiButtonObject_up.TabIndex = 22;
            this.uiButtonObject_up.Click += new System.EventHandler(this.uiButtonObject_up_Click);
            // 
            // button_ToMap
            // 
            this.button_ToMap.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_ToMap.ConditionImage = null;
            this.button_ToMap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ToMap.Font = new System.Drawing.Font("游ゴシック", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_ToMap.ForeColor = System.Drawing.Color.White;
            this.button_ToMap.ForeImage = null;
            this.button_ToMap.Location = new System.Drawing.Point(807, 14);
            this.button_ToMap.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.button_ToMap.Name = "button_ToMap";
            this.button_ToMap.Size = new System.Drawing.Size(372, 75);
            this.button_ToMap.TabIndex = 7;
            this.button_ToMap.Text = "教室に戻る";
            this.button_ToMap.UseVisualStyleBackColor = false;
            this.button_ToMap.Click += new System.EventHandler(this.button_ToMap_Click);
            // 
            // Stage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(2533, 1292);
            this.Controls.Add(this.button_Breset);
            this.Controls.Add(this.label_B);
            this.Controls.Add(this.label_A);
            this.Controls.Add(this.label_Input);
            this.Controls.Add(this.button_Explain);
            this.Controls.Add(this.labelStageName);
            this.Controls.Add(this.label_Info);
            this.Controls.Add(this.textBox_ForCount);
            this.Controls.Add(this.uiButtonObject_for);
            this.Controls.Add(this.uiButtonObject_endfor);
            this.Controls.Add(this.uiButtonObject_B);
            this.Controls.Add(this.uiButtonObject_A);
            this.Controls.Add(this.uiButtonObject_down);
            this.Controls.Add(this.uiButtonObject_right);
            this.Controls.Add(this.uiButtonObject_left);
            this.Controls.Add(this.uiButtonObject_up);
            this.Controls.Add(this.label_Error);
            this.Controls.Add(this.label_Result);
            this.Controls.Add(this.listBox_B);
            this.Controls.Add(this.listBox_A);
            this.Controls.Add(this.listBox_Input);
            this.Controls.Add(this.button_Hint);
            this.Controls.Add(this.button_Retry);
            this.Controls.Add(this.button_ToMap);
            this.Controls.Add(this.button_A_Reset);
            this.Controls.Add(this.button_ResetInput);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox_Background);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Stage";
            this.Text = "ゲーム画面";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Stage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Button button_ResetInput;
        private System.Windows.Forms.Button button_A_Reset;
        private CustomButton button_ToMap;
        private System.Windows.Forms.Button button_Retry;
        private System.Windows.Forms.Button button_Hint;
        private System.Windows.Forms.ListBox listBox_Input;
        private System.Windows.Forms.ListBox listBox_A;
        private System.Windows.Forms.ListBox listBox_B;
        private System.Windows.Forms.Label label_Result;
        private System.Windows.Forms.Label label_Error;
        private UIButtonObject uiButtonObject_up;
        private UIButtonObject uiButtonObject_left;
        private UIButtonObject uiButtonObject_right;
        private UIButtonObject uiButtonObject_down;
        private UIButtonObject uiButtonObject_A;
        private UIButtonObject uiButtonObject_B;
        private UIButtonObject uiButtonObject_endfor;
        private UIButtonObject uiButtonObject_for;
        private System.Windows.Forms.TextBox textBox_ForCount;
        private System.Windows.Forms.Label label_Info;
        private System.Windows.Forms.Label labelStageName;
        private System.Windows.Forms.Button button_Explain;
        private System.Windows.Forms.Label label_Input;
        private System.Windows.Forms.Label label_A;
        private System.Windows.Forms.Label label_B;
        private System.Windows.Forms.Button button_Breset;
        private System.Windows.Forms.PictureBox pictureBox_Background;
    }
}