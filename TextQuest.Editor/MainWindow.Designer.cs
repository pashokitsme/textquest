namespace TextQuest.Editor
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            this.SceneBox = new System.Windows.Forms.GroupBox();
            this.SceneBodyEditor = new System.Windows.Forms.RichTextBox();
            this.SceneHeaderEditor = new System.Windows.Forms.TextBox();
            this.SceneIdEditor = new System.Windows.Forms.TextBox();
            this.ChildsBox = new System.Windows.Forms.GroupBox();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.PreviousScene = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.SceneBox.SuspendLayout();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 25);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(17, 15);
            label2.TabIndex = 3;
            label2.Text = "Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 54);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(45, 15);
            label3.TabIndex = 4;
            label3.Text = "Header";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(6, 78);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(34, 15);
            label4.TabIndex = 5;
            label4.Text = "Body";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SceneBox
            // 
            this.SceneBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SceneBox.Controls.Add(label4);
            this.SceneBox.Controls.Add(label3);
            this.SceneBox.Controls.Add(label2);
            this.SceneBox.Controls.Add(this.SceneBodyEditor);
            this.SceneBox.Controls.Add(this.SceneHeaderEditor);
            this.SceneBox.Controls.Add(this.SceneIdEditor);
            this.SceneBox.Location = new System.Drawing.Point(12, 25);
            this.SceneBox.Name = "SceneBox";
            this.SceneBox.Size = new System.Drawing.Size(878, 672);
            this.SceneBox.TabIndex = 0;
            this.SceneBox.TabStop = false;
            this.SceneBox.Text = "Сцена";
            // 
            // SceneBodyEditor
            // 
            this.SceneBodyEditor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SceneBodyEditor.Location = new System.Drawing.Point(6, 96);
            this.SceneBodyEditor.Name = "SceneBodyEditor";
            this.SceneBodyEditor.Size = new System.Drawing.Size(872, 254);
            this.SceneBodyEditor.TabIndex = 2;
            this.SceneBodyEditor.Text = "";
            // 
            // SceneHeaderEditor
            // 
            this.SceneHeaderEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SceneHeaderEditor.Location = new System.Drawing.Point(57, 51);
            this.SceneHeaderEditor.Name = "SceneHeaderEditor";
            this.SceneHeaderEditor.Size = new System.Drawing.Size(809, 23);
            this.SceneHeaderEditor.TabIndex = 1;
            // 
            // SceneIdEditor
            // 
            this.SceneIdEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SceneIdEditor.Location = new System.Drawing.Point(57, 22);
            this.SceneIdEditor.Name = "SceneIdEditor";
            this.SceneIdEditor.Size = new System.Drawing.Size(245, 23);
            this.SceneIdEditor.TabIndex = 0;
            // 
            // ChildsBox
            // 
            this.ChildsBox.Location = new System.Drawing.Point(896, 50);
            this.ChildsBox.Name = "ChildsBox";
            this.ChildsBox.Size = new System.Drawing.Size(258, 348);
            this.ChildsBox.TabIndex = 2;
            this.ChildsBox.TabStop = false;
            this.ChildsBox.Text = "Переходы к";
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.загрузитьToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(1166, 24);
            this.Menu.TabIndex = 2;
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewMenuItem,
            this.OpenFileMenuItem,
            this.OpenMenuItem});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileMenuItem.Text = "Файл";
            // 
            // NewMenuItem
            // 
            this.NewMenuItem.Name = "NewMenuItem";
            this.NewMenuItem.Size = new System.Drawing.Size(180, 22);
            this.NewMenuItem.Text = "Новый";
            // 
            // OpenFileMenuItem
            // 
            this.OpenFileMenuItem.Name = "OpenFileMenuItem";
            this.OpenFileMenuItem.Size = new System.Drawing.Size(180, 22);
            this.OpenFileMenuItem.Text = "Открыть";
            // 
            // OpenMenuItem
            // 
            this.OpenMenuItem.Name = "OpenMenuItem";
            this.OpenMenuItem.Size = new System.Drawing.Size(180, 22);
            this.OpenMenuItem.Text = "Сохранить";
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.LoadSceneEditor);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // PreviousScene
            // 
            this.PreviousScene.AutoSize = true;
            this.PreviousScene.Location = new System.Drawing.Point(902, 32);
            this.PreviousScene.Name = "PreviousScene";
            this.PreviousScene.Size = new System.Drawing.Size(87, 15);
            this.PreviousScene.TabIndex = 3;
            this.PreviousScene.Text = "Previous: None";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 709);
            this.Controls.Add(this.PreviousScene);
            this.Controls.Add(this.ChildsBox);
            this.Controls.Add(this.SceneBox);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TextQuest Editor";
            this.Load += new System.EventHandler(this.Loaded);
            this.SceneBox.ResumeLayout(false);
            this.SceneBox.PerformLayout();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox SceneBox;
        private MenuStrip Menu;
        private ToolStripMenuItem FileMenuItem;
        private ToolStripMenuItem OpenFileMenuItem;
        private ToolStripMenuItem OpenMenuItem;
        private ToolStripMenuItem NewMenuItem;
        private Label label1;
        private ToolStripMenuItem загрузитьToolStripMenuItem;
        public GroupBox ChildsBox;
        public RichTextBox SceneBodyEditor;
        public TextBox SceneHeaderEditor;
        public TextBox SceneIdEditor;
        public Label PreviousScene;
    }
}