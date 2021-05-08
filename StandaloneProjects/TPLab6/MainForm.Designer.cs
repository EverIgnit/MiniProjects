namespace WindowsFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Students_L = new System.Windows.Forms.Label();
            this.Students_LB = new System.Windows.Forms.ListBox();
            this.Add_B = new System.Windows.Forms.Button();
            this.Edit_B = new System.Windows.Forms.Button();
            this.Del_B = new System.Windows.Forms.Button();
            this.Main_SS = new System.Windows.Forms.StatusStrip();
            this.FIO_TSSL = new System.Windows.Forms.ToolStripStatusLabel();
            this.SchoolNum_TSSL = new System.Windows.Forms.ToolStripStatusLabel();
            this.ClassNum_TSSL = new System.Windows.Forms.ToolStripStatusLabel();
            this.TestMark_TSSL = new System.Windows.Forms.ToolStripStatusLabel();
            this.FormatStudents_LB = new System.Windows.Forms.ListBox();
            this.Main_MS = new System.Windows.Forms.MenuStrip();
            this.Actions_MMS = new System.Windows.Forms.ToolStripMenuItem();
            this.Add_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Load_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Save_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Calc_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Main_TS = new System.Windows.Forms.ToolStrip();
            this.Add_TSB = new System.Windows.Forms.ToolStripButton();
            this.Edit_TSB = new System.Windows.Forms.ToolStripButton();
            this.Delete_TSB = new System.Windows.Forms.ToolStripButton();
            this.Open_TSB = new System.Windows.Forms.ToolStripButton();
            this.Save_TSB = new System.Windows.Forms.ToolStripButton();
            this.Calc_TSB = new System.Windows.Forms.ToolStripButton();
            this.Load_B = new System.Windows.Forms.Button();
            this.Save_B = new System.Windows.Forms.Button();
            this.Calc_B = new System.Windows.Forms.Button();
            this.FormatStudents_L = new System.Windows.Forms.Label();
            this.Open_FD = new System.Windows.Forms.OpenFileDialog();
            this.Save_FD = new System.Windows.Forms.SaveFileDialog();
            this.Main_SS.SuspendLayout();
            this.Main_MS.SuspendLayout();
            this.Main_TS.SuspendLayout();
            this.SuspendLayout();
            // 
            // Students_L
            // 
            this.Students_L.AutoSize = true;
            this.Students_L.Location = new System.Drawing.Point(7, 63);
            this.Students_L.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Students_L.Name = "Students_L";
            this.Students_L.Size = new System.Drawing.Size(93, 13);
            this.Students_L.TabIndex = 0;
            this.Students_L.Text = "Спи&сок учеников";
            // 
            // Students_LB
            // 
            this.Students_LB.FormattingEnabled = true;
            this.Students_LB.Location = new System.Drawing.Point(9, 80);
            this.Students_LB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Students_LB.Name = "Students_LB";
            this.Students_LB.Size = new System.Drawing.Size(190, 173);
            this.Students_LB.TabIndex = 1;
            this.Students_LB.SelectedIndexChanged += new System.EventHandler(this.Students_LB_SelectedIndexChanged);
            // 
            // Add_B
            // 
            this.Add_B.Location = new System.Drawing.Point(203, 80);
            this.Add_B.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Add_B.Name = "Add_B";
            this.Add_B.Size = new System.Drawing.Size(77, 26);
            this.Add_B.TabIndex = 2;
            this.Add_B.Text = "Доб&авить";
            this.Add_B.UseVisualStyleBackColor = true;
            this.Add_B.Click += new System.EventHandler(this.Add_B_Click);
            // 
            // Edit_B
            // 
            this.Edit_B.Location = new System.Drawing.Point(203, 110);
            this.Edit_B.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Edit_B.Name = "Edit_B";
            this.Edit_B.Size = new System.Drawing.Size(77, 26);
            this.Edit_B.TabIndex = 3;
            this.Edit_B.Text = "И&зменить";
            this.Edit_B.UseVisualStyleBackColor = true;
            this.Edit_B.Click += new System.EventHandler(this.Edit_B_Click);
            // 
            // Del_B
            // 
            this.Del_B.Location = new System.Drawing.Point(203, 141);
            this.Del_B.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Del_B.Name = "Del_B";
            this.Del_B.Size = new System.Drawing.Size(77, 26);
            this.Del_B.TabIndex = 4;
            this.Del_B.Text = "Уда&лить";
            this.Del_B.UseVisualStyleBackColor = true;
            this.Del_B.Click += new System.EventHandler(this.Del_B_Click);
            // 
            // Main_SS
            // 
            this.Main_SS.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Main_SS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FIO_TSSL,
            this.SchoolNum_TSSL,
            this.ClassNum_TSSL,
            this.TestMark_TSSL});
            this.Main_SS.Location = new System.Drawing.Point(0, 262);
            this.Main_SS.Name = "Main_SS";
            this.Main_SS.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.Main_SS.Size = new System.Drawing.Size(485, 22);
            this.Main_SS.TabIndex = 5;
            this.Main_SS.Text = "statusStrip1";
            // 
            // FIO_TSSL
            // 
            this.FIO_TSSL.Name = "FIO_TSSL";
            this.FIO_TSSL.Size = new System.Drawing.Size(0, 17);
            // 
            // SchoolNum_TSSL
            // 
            this.SchoolNum_TSSL.Name = "SchoolNum_TSSL";
            this.SchoolNum_TSSL.Size = new System.Drawing.Size(0, 17);
            // 
            // ClassNum_TSSL
            // 
            this.ClassNum_TSSL.Name = "ClassNum_TSSL";
            this.ClassNum_TSSL.Size = new System.Drawing.Size(0, 17);
            // 
            // TestMark_TSSL
            // 
            this.TestMark_TSSL.Name = "TestMark_TSSL";
            this.TestMark_TSSL.Size = new System.Drawing.Size(0, 17);
            // 
            // FormatStudents_LB
            // 
            this.FormatStudents_LB.FormattingEnabled = true;
            this.FormatStudents_LB.Location = new System.Drawing.Point(285, 80);
            this.FormatStudents_LB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FormatStudents_LB.Name = "FormatStudents_LB";
            this.FormatStudents_LB.Size = new System.Drawing.Size(190, 173);
            this.FormatStudents_LB.TabIndex = 6;
            // 
            // Main_MS
            // 
            this.Main_MS.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Main_MS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Actions_MMS});
            this.Main_MS.Location = new System.Drawing.Point(0, 0);
            this.Main_MS.Name = "Main_MS";
            this.Main_MS.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.Main_MS.Size = new System.Drawing.Size(485, 24);
            this.Main_MS.TabIndex = 7;
            this.Main_MS.Text = "menuStrip1";
            // 
            // Actions_MMS
            // 
            this.Actions_MMS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_TSMI,
            this.Edit_TSMI,
            this.Delete_TSMI,
            this.Load_TSMI,
            this.Save_TSMI,
            this.Calc_TSMI});
            this.Actions_MMS.Name = "Actions_MMS";
            this.Actions_MMS.Size = new System.Drawing.Size(70, 20);
            this.Actions_MMS.Text = "Действия";
            // 
            // Add_TSMI
            // 
            this.Add_TSMI.Name = "Add_TSMI";
            this.Add_TSMI.Size = new System.Drawing.Size(133, 22);
            this.Add_TSMI.Text = "Добавить";
            this.Add_TSMI.Click += new System.EventHandler(this.Add_B_Click);
            // 
            // Edit_TSMI
            // 
            this.Edit_TSMI.Name = "Edit_TSMI";
            this.Edit_TSMI.Size = new System.Drawing.Size(133, 22);
            this.Edit_TSMI.Text = "Изменить";
            this.Edit_TSMI.Click += new System.EventHandler(this.Edit_B_Click);
            // 
            // Delete_TSMI
            // 
            this.Delete_TSMI.Name = "Delete_TSMI";
            this.Delete_TSMI.Size = new System.Drawing.Size(133, 22);
            this.Delete_TSMI.Text = "Удалить";
            this.Delete_TSMI.Click += new System.EventHandler(this.Del_B_Click);
            // 
            // Load_TSMI
            // 
            this.Load_TSMI.Name = "Load_TSMI";
            this.Load_TSMI.Size = new System.Drawing.Size(133, 22);
            this.Load_TSMI.Text = "Загрузить";
            this.Load_TSMI.Click += new System.EventHandler(this.Load_B_Click);
            // 
            // Save_TSMI
            // 
            this.Save_TSMI.Name = "Save_TSMI";
            this.Save_TSMI.Size = new System.Drawing.Size(133, 22);
            this.Save_TSMI.Text = "Сохранить";
            this.Save_TSMI.Click += new System.EventHandler(this.Save_B_Click);
            // 
            // Calc_TSMI
            // 
            this.Calc_TSMI.Name = "Calc_TSMI";
            this.Calc_TSMI.Size = new System.Drawing.Size(133, 22);
            this.Calc_TSMI.Text = "Расчёт";
            this.Calc_TSMI.Click += new System.EventHandler(this.Calc_B_Click);
            // 
            // Main_TS
            // 
            this.Main_TS.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Main_TS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_TSB,
            this.Edit_TSB,
            this.Delete_TSB,
            this.Open_TSB,
            this.Save_TSB,
            this.Calc_TSB});
            this.Main_TS.Location = new System.Drawing.Point(0, 24);
            this.Main_TS.Name = "Main_TS";
            this.Main_TS.Size = new System.Drawing.Size(485, 27);
            this.Main_TS.TabIndex = 8;
            this.Main_TS.Text = "toolStrip1";
            // 
            // Add_TSB
            // 
            this.Add_TSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Add_TSB.Image = ((System.Drawing.Image)(resources.GetObject("Add_TSB.Image")));
            this.Add_TSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Add_TSB.Name = "Add_TSB";
            this.Add_TSB.Size = new System.Drawing.Size(24, 24);
            this.Add_TSB.Text = "Добавить";
            this.Add_TSB.Click += new System.EventHandler(this.Add_B_Click);
            // 
            // Edit_TSB
            // 
            this.Edit_TSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Edit_TSB.Image = ((System.Drawing.Image)(resources.GetObject("Edit_TSB.Image")));
            this.Edit_TSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Edit_TSB.Name = "Edit_TSB";
            this.Edit_TSB.Size = new System.Drawing.Size(24, 24);
            this.Edit_TSB.Text = "Изменить";
            this.Edit_TSB.Click += new System.EventHandler(this.Edit_B_Click);
            // 
            // Delete_TSB
            // 
            this.Delete_TSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Delete_TSB.Image = ((System.Drawing.Image)(resources.GetObject("Delete_TSB.Image")));
            this.Delete_TSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Delete_TSB.Name = "Delete_TSB";
            this.Delete_TSB.Size = new System.Drawing.Size(24, 24);
            this.Delete_TSB.Text = "Удалить";
            this.Delete_TSB.Click += new System.EventHandler(this.Del_B_Click);
            // 
            // Open_TSB
            // 
            this.Open_TSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Open_TSB.Image = ((System.Drawing.Image)(resources.GetObject("Open_TSB.Image")));
            this.Open_TSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Open_TSB.Name = "Open_TSB";
            this.Open_TSB.Size = new System.Drawing.Size(24, 24);
            this.Open_TSB.Text = "Загрузить";
            this.Open_TSB.Click += new System.EventHandler(this.Load_B_Click);
            // 
            // Save_TSB
            // 
            this.Save_TSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Save_TSB.Image = ((System.Drawing.Image)(resources.GetObject("Save_TSB.Image")));
            this.Save_TSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Save_TSB.Name = "Save_TSB";
            this.Save_TSB.Size = new System.Drawing.Size(24, 24);
            this.Save_TSB.Text = "Сохранить";
            this.Save_TSB.Click += new System.EventHandler(this.Save_B_Click);
            // 
            // Calc_TSB
            // 
            this.Calc_TSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Calc_TSB.Image = ((System.Drawing.Image)(resources.GetObject("Calc_TSB.Image")));
            this.Calc_TSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Calc_TSB.Name = "Calc_TSB";
            this.Calc_TSB.Size = new System.Drawing.Size(24, 24);
            this.Calc_TSB.Text = "Расчёт";
            this.Calc_TSB.Click += new System.EventHandler(this.Calc_B_Click);
            // 
            // Load_B
            // 
            this.Load_B.Location = new System.Drawing.Point(203, 180);
            this.Load_B.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Load_B.Name = "Load_B";
            this.Load_B.Size = new System.Drawing.Size(77, 21);
            this.Load_B.TabIndex = 9;
            this.Load_B.Text = "&Загрузить";
            this.Load_B.UseVisualStyleBackColor = true;
            this.Load_B.Click += new System.EventHandler(this.Load_B_Click);
            // 
            // Save_B
            // 
            this.Save_B.Location = new System.Drawing.Point(203, 206);
            this.Save_B.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Save_B.Name = "Save_B";
            this.Save_B.Size = new System.Drawing.Size(77, 21);
            this.Save_B.TabIndex = 10;
            this.Save_B.Text = "Со&хранить";
            this.Save_B.UseVisualStyleBackColor = true;
            this.Save_B.Click += new System.EventHandler(this.Save_B_Click);
            // 
            // Calc_B
            // 
            this.Calc_B.Location = new System.Drawing.Point(203, 232);
            this.Calc_B.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Calc_B.Name = "Calc_B";
            this.Calc_B.Size = new System.Drawing.Size(77, 20);
            this.Calc_B.TabIndex = 11;
            this.Calc_B.Text = "&Расчёт";
            this.Calc_B.UseVisualStyleBackColor = true;
            this.Calc_B.Click += new System.EventHandler(this.Calc_B_Click);
            // 
            // FormatStudents_L
            // 
            this.FormatStudents_L.AutoSize = true;
            this.FormatStudents_L.Location = new System.Drawing.Point(283, 64);
            this.FormatStudents_L.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FormatStudents_L.Name = "FormatStudents_L";
            this.FormatStudents_L.Size = new System.Drawing.Size(147, 13);
            this.FormatStudents_L.TabIndex = 12;
            this.FormatStudents_L.Text = "Список учеников по &оценке";
            // 
            // Open_FD
            // 
            this.Open_FD.DefaultExt = "txt";
            this.Open_FD.Filter = "(*.txt)|*.txt";
            this.Open_FD.InitialDirectory = ".";
            this.Open_FD.Title = "Загрузка списка";
            // 
            // Save_FD
            // 
            this.Save_FD.DefaultExt = "txt";
            this.Save_FD.FileName = "file";
            this.Save_FD.Filter = "(*.txt)|*.txt";
            this.Save_FD.InitialDirectory = ".";
            this.Save_FD.Title = "Сохранение списка";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 284);
            this.Controls.Add(this.FormatStudents_L);
            this.Controls.Add(this.Calc_B);
            this.Controls.Add(this.Save_B);
            this.Controls.Add(this.Load_B);
            this.Controls.Add(this.Main_TS);
            this.Controls.Add(this.FormatStudents_LB);
            this.Controls.Add(this.Main_SS);
            this.Controls.Add(this.Main_MS);
            this.Controls.Add(this.Del_B);
            this.Controls.Add(this.Edit_B);
            this.Controls.Add(this.Add_B);
            this.Controls.Add(this.Students_LB);
            this.Controls.Add(this.Students_L);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Main_MS;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Пример: списки";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Main_SS.ResumeLayout(false);
            this.Main_SS.PerformLayout();
            this.Main_MS.ResumeLayout(false);
            this.Main_MS.PerformLayout();
            this.Main_TS.ResumeLayout(false);
            this.Main_TS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Students_L;
        private System.Windows.Forms.ListBox Students_LB;
        private System.Windows.Forms.Button Add_B;
        private System.Windows.Forms.Button Edit_B;
        private System.Windows.Forms.Button Del_B;
        private System.Windows.Forms.StatusStrip Main_SS;
        private System.Windows.Forms.ToolStripStatusLabel FIO_TSSL;
        private System.Windows.Forms.ToolStripStatusLabel SchoolNum_TSSL;
        private System.Windows.Forms.ToolStripStatusLabel ClassNum_TSSL;
        private System.Windows.Forms.ToolStripStatusLabel TestMark_TSSL;
        private System.Windows.Forms.ListBox FormatStudents_LB;
        private System.Windows.Forms.MenuStrip Main_MS;
        private System.Windows.Forms.ToolStrip Main_TS;
        private System.Windows.Forms.ToolStripButton Add_TSB;
        private System.Windows.Forms.ToolStripButton Edit_TSB;
        private System.Windows.Forms.ToolStripButton Delete_TSB;
        private System.Windows.Forms.ToolStripButton Open_TSB;
        private System.Windows.Forms.ToolStripButton Save_TSB;
        private System.Windows.Forms.ToolStripButton Calc_TSB;
        private System.Windows.Forms.Button Load_B;
        private System.Windows.Forms.Button Save_B;
        private System.Windows.Forms.Button Calc_B;
        private System.Windows.Forms.Label FormatStudents_L;
        private System.Windows.Forms.ToolStripMenuItem Actions_MMS;
        private System.Windows.Forms.ToolStripMenuItem Add_TSMI;
        private System.Windows.Forms.ToolStripMenuItem Edit_TSMI;
        private System.Windows.Forms.ToolStripMenuItem Delete_TSMI;
        private System.Windows.Forms.ToolStripMenuItem Load_TSMI;
        private System.Windows.Forms.ToolStripMenuItem Save_TSMI;
        private System.Windows.Forms.ToolStripMenuItem Calc_TSMI;
        private System.Windows.Forms.OpenFileDialog Open_FD;
        private System.Windows.Forms.SaveFileDialog Save_FD;
    }
}

