namespace unilab2024
{
    partial class AnotherWorld
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnotherWorld));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new unilab2024.CustomButton();
            this.button6 = new unilab2024.CustomButton();
            this.button7 = new unilab2024.CustomButton();
            this.buttonToWorldMap = new unilab2024.CustomButton();
            this.button8 = new unilab2024.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1536, 900);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.ConditionImage = null;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("游ゴシック", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button5.ForeImage = null;
            this.button5.Location = new System.Drawing.Point(1033, 679);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(150, 50);
            this.button5.TabIndex = 1;
            this.button5.Text = "冬山";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.buttonI_Click);
            // 
            // button6
            // 
            this.button6.ConditionImage = null;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Font = new System.Drawing.Font("游ゴシック", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button6.ForeImage = null;
            this.button6.Location = new System.Drawing.Point(241, 350);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(180, 50);
            this.button6.TabIndex = 2;
            this.button6.Text = "ジャングル";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.buttonI_Click);
            // 
            // button7
            // 
            this.button7.ConditionImage = null;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Font = new System.Drawing.Font("游ゴシック", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button7.ForeImage = null;
            this.button7.Location = new System.Drawing.Point(671, 423);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(200, 50);
            this.button7.TabIndex = 3;
            this.button7.Text = "ゆがんだ時空";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.buttonI_Click);
            // 
            // buttonToWorldMap
            // 
            this.buttonToWorldMap.BackColor = System.Drawing.Color.Gray;
            this.buttonToWorldMap.ConditionImage = null;
            this.buttonToWorldMap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonToWorldMap.Font = new System.Drawing.Font("游ゴシック", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonToWorldMap.ForeColor = System.Drawing.Color.White;
            this.buttonToWorldMap.ForeImage = null;
            this.buttonToWorldMap.Location = new System.Drawing.Point(50, 650);
            this.buttonToWorldMap.Name = "buttonToWorldMap";
            this.buttonToWorldMap.Size = new System.Drawing.Size(120, 40);
            this.buttonToWorldMap.TabIndex = 3;
            this.buttonToWorldMap.Text = "魔法学校へ";
            this.buttonToWorldMap.UseVisualStyleBackColor = false;
            this.buttonToWorldMap.Click += new System.EventHandler(this.buttonToWorldMap_Click);
            // 
            // button8
            // 
            this.button8.ConditionImage = null;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Font = new System.Drawing.Font("游ゴシック", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button8.ForeImage = null;
            this.button8.Location = new System.Drawing.Point(1096, 75);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(200, 50);
            this.button8.TabIndex = 4;
            this.button8.Text = "ドラゴン退治";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.buttonI_Click);
            // 
            // AnotherWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 861);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.buttonToWorldMap);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AnotherWorld";
            this.Text = "AnotherWorld";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AnotherWorld_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomButton button5;
        private CustomButton button6;
        private CustomButton button7;
        private CustomButton buttonToWorldMap;
        private CustomButton button8;
    }
}