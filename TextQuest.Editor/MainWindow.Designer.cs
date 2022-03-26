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
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SceneBodyEditor = new System.Windows.Forms.RichTextBox();
            this.SceneHeaderEditor = new System.Windows.Forms.TextBox();
            this.SceneIdEditor = new System.Windows.Forms.TextBox();
            this.ChildsBox = new System.Windows.Forms.GroupBox();
            this.CreateScene = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.PreviousScene = new System.Windows.Forms.Label();
            this.AllScenesBox = new System.Windows.Forms.GroupBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.SceneBox.SuspendLayout();
            this.ChildsBox.SuspendLayout();
            this.Menu.SuspendLayout();
            this.AllScenesBox.SuspendLayout();
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
            label3.Size = new System.Drawing.Size(65, 15);
            label3.TabIndex = 4;
            label3.Text = "Заголовок";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(6, 78);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(36, 15);
            label4.TabIndex = 5;
            label4.Text = "Текст";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SceneBox
            // 
            this.SceneBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SceneBox.Controls.Add(this.DeleteButton);
            this.SceneBox.Controls.Add(this.SaveButton);
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
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(662, 17);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 7;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(743, 17);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(123, 23);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
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
            this.SceneHeaderEditor.Location = new System.Drawing.Point(77, 51);
            this.SceneHeaderEditor.Name = "SceneHeaderEditor";
            this.SceneHeaderEditor.Size = new System.Drawing.Size(789, 23);
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
            this.ChildsBox.Controls.Add(this.CreateScene);
            this.ChildsBox.Location = new System.Drawing.Point(896, 50);
            this.ChildsBox.Name = "ChildsBox";
            this.ChildsBox.Size = new System.Drawing.Size(258, 325);
            this.ChildsBox.TabIndex = 2;
            this.ChildsBox.TabStop = false;
            this.ChildsBox.Text = "Переходы к";
            // 
            // CreateScene
            // 
            this.CreateScene.AutoSize = true;
            this.CreateScene.Location = new System.Drawing.Point(6, 19);
            this.CreateScene.Name = "CreateScene";
            this.CreateScene.Size = new System.Drawing.Size(50, 15);
            this.CreateScene.TabIndex = 0;
            this.CreateScene.Tag = "create_scene";
            this.CreateScene.Text = "Создать";
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
            this.NewMenuItem.Size = new System.Drawing.Size(133, 22);
            this.NewMenuItem.Text = "Новый";
            // 
            // OpenFileMenuItem
            // 
            this.OpenFileMenuItem.Name = "OpenFileMenuItem";
            this.OpenFileMenuItem.Size = new System.Drawing.Size(133, 22);
            this.OpenFileMenuItem.Text = "Открыть";
            // 
            // OpenMenuItem
            // 
            this.OpenMenuItem.Name = "OpenMenuItem";
            this.OpenMenuItem.Size = new System.Drawing.Size(133, 22);
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
            this.PreviousScene.Size = new System.Drawing.Size(74, 15);
            this.PreviousScene.TabIndex = 3;
            this.PreviousScene.Text = "Назад: None";
            // 
            // AllScenesBox
            // 
            this.AllScenesBox.Controls.Add(this.vScrollBar1);
            this.AllScenesBox.Location = new System.Drawing.Point(896, 381);
            this.AllScenesBox.Name = "AllScenesBox";
            this.AllScenesBox.Size = new System.Drawing.Size(258, 316);
            this.AllScenesBox.TabIndex = 4;
            this.AllScenesBox.TabStop = false;
            this.AllScenesBox.Text = "Все сцены";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(241, 19);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(14, 294);
            this.vScrollBar1.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 709);
            this.Controls.Add(this.AllScenesBox);
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
            this.ChildsBox.ResumeLayout(false);
            this.ChildsBox.PerformLayout();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.AllScenesBox.ResumeLayout(false);
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
        public Label CreateScene;
        private GroupBox AllScenesBox;
        private Button SaveButton;
        private Button DeleteButton;
        private VScrollBar vScrollBar1;
    }
}