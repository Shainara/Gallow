namespace Gallow
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.developerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblWord = new System.Windows.Forms.Label();
            this.lblErrors = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.gbGame = new System.Windows.Forms.GroupBox();
            this.img = new System.Windows.Forms.PictureBox();
            this.lblCountText = new System.Windows.Forms.Label();
            this.lblErrorsText = new System.Windows.Forms.Label();
            this.lblWordText = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tbLetter = new System.Windows.Forms.TextBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.gbGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.img)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.menuToolStripMenuItem, this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(707, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.startToolStripMenuItem, this.stopToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.rulesToolStripMenuItem, this.developerToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // rulesToolStripMenuItem
            // 
            this.rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
            this.rulesToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.rulesToolStripMenuItem.Text = "Rules";
            this.rulesToolStripMenuItem.Click += new System.EventHandler(this.rulesToolStripMenuItem_Click);
            // 
            // developerToolStripMenuItem
            // 
            this.developerToolStripMenuItem.Name = "developerToolStripMenuItem";
            this.developerToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.developerToolStripMenuItem.Text = "Developer";
            this.developerToolStripMenuItem.Click += new System.EventHandler(this.developerToolStripMenuItem_Click);
            // 
            // lblWord
            // 
            this.lblWord.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblWord.Location = new System.Drawing.Point(276, 62);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(128, 30);
            this.lblWord.TabIndex = 1;
            this.lblWord.Text = "Слово:";
            // 
            // lblErrors
            // 
            this.lblErrors.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblErrors.Location = new System.Drawing.Point(276, 92);
            this.lblErrors.Name = "lblErrors";
            this.lblErrors.Size = new System.Drawing.Size(128, 30);
            this.lblErrors.TabIndex = 2;
            this.lblErrors.Text = "Проверены:";
            // 
            // lblCount
            // 
            this.lblCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCount.Location = new System.Drawing.Point(276, 122);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(128, 30);
            this.lblCount.TabIndex = 4;
            this.lblCount.Text = "Попытки:";
            // 
            // gbGame
            // 
            this.gbGame.Controls.Add(this.btnSet);
            this.gbGame.Controls.Add(this.tbLetter);
            this.gbGame.Controls.Add(this.img);
            this.gbGame.Controls.Add(this.lblCountText);
            this.gbGame.Controls.Add(this.lblErrorsText);
            this.gbGame.Controls.Add(this.lblWordText);
            this.gbGame.Controls.Add(this.lblWord);
            this.gbGame.Controls.Add(this.lblCount);
            this.gbGame.Controls.Add(this.lblErrors);
            this.gbGame.Location = new System.Drawing.Point(12, 27);
            this.gbGame.Name = "gbGame";
            this.gbGame.Size = new System.Drawing.Size(685, 288);
            this.gbGame.TabIndex = 5;
            this.gbGame.TabStop = false;
            this.gbGame.Text = "Игра";
            // 
            // img
            // 
            this.img.ErrorImage = ((System.Drawing.Image) (resources.GetObject("img.ErrorImage")));
            this.img.Image = ((System.Drawing.Image) (resources.GetObject("img.Image")));
            this.img.InitialImage = ((System.Drawing.Image) (resources.GetObject("img.InitialImage")));
            this.img.Location = new System.Drawing.Point(15, 22);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(241, 248);
            this.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img.TabIndex = 9;
            this.img.TabStop = false;
            // 
            // lblCountText
            // 
            this.lblCountText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCountText.Location = new System.Drawing.Point(410, 122);
            this.lblCountText.Name = "lblCountText";
            this.lblCountText.Size = new System.Drawing.Size(247, 30);
            this.lblCountText.TabIndex = 7;
            // 
            // lblErrorsText
            // 
            this.lblErrorsText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblErrorsText.Location = new System.Drawing.Point(410, 92);
            this.lblErrorsText.Name = "lblErrorsText";
            this.lblErrorsText.Size = new System.Drawing.Size(247, 30);
            this.lblErrorsText.TabIndex = 6;
            // 
            // lblWordText
            // 
            this.lblWordText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblWordText.Location = new System.Drawing.Point(410, 62);
            this.lblWordText.Name = "lblWordText";
            this.lblWordText.Size = new System.Drawing.Size(247, 30);
            this.lblWordText.TabIndex = 5;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream =
                ((System.Windows.Forms.ImageListStreamer) (resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Black;
            this.imageList1.Images.SetKeyName(0, "Hangman-0.png");
            // 
            // tbLetter
            // 
            this.tbLetter.Enabled = false;
            this.tbLetter.Location = new System.Drawing.Point(388, 193);
            this.tbLetter.Name = "tbLetter";
            this.tbLetter.Size = new System.Drawing.Size(164, 23);
            this.tbLetter.TabIndex = 10;
            // 
            // btnSet
            // 
            this.btnSet.Enabled = false;
            this.btnSet.Location = new System.Drawing.Point(388, 222);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(164, 23);
            this.btnSet.TabIndex = 11;
            this.btnSet.Text = "Проверить букву";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 327);
            this.Controls.Add(this.gbGame);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Виселица";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbGame.ResumeLayout(false);
            this.gbGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label lblErrors;
        private System.Windows.Forms.GroupBox gbGame;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblWordText;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem developerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.Label lblErrorsText;
        private System.Windows.Forms.Label lblCountText;
        private System.Windows.Forms.TextBox tbLetter;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.PictureBox img;
    }
}