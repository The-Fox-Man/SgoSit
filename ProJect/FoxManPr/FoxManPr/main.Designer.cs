﻿namespace FoxManPr
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.pan = new System.Windows.Forms.Panel();
            this.admin = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.exit = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.loginlbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pic = new System.Windows.Forms.PictureBox();
            this.teachers = new System.Windows.Forms.Button();
            this.about = new System.Windows.Forms.Button();
            this.spravk = new System.Windows.Forms.Button();
            this.sgo = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.menu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan
            // 
            resources.ApplyResources(this.pan, "pan");
            this.pan.Controls.Add(this.richTextBox1);
            this.pan.Controls.Add(this.label1);
            this.pan.Controls.Add(this.pic);
            this.pan.Name = "pan";
            this.pan.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // admin
            // 
            resources.ApplyResources(this.admin, "admin");
            this.admin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.admin.Name = "admin";
            this.admin.UseVisualStyleBackColor = false;
            this.admin.Click += new System.EventHandler(this.admin_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.richTextBox1, "richTextBox1");
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            // 
            // exit
            // 
            resources.ApplyResources(this.exit, "exit");
            this.exit.Name = "exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.button3_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.button6, "button6");
            this.button6.Name = "button6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.button5, "button5");
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // loginlbl
            // 
            resources.ApplyResources(this.loginlbl, "loginlbl");
            this.loginlbl.Name = "loginlbl";
            this.loginlbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // pic
            // 
            resources.ApplyResources(this.pic, "pic");
            this.pic.Image = global::FoxManPr.Properties.Resources.gymn13;
            this.pic.Name = "pic";
            this.pic.TabStop = false;
            // 
            // teachers
            // 
            this.teachers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.teachers, "teachers");
            this.teachers.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.teachers.Name = "teachers";
            this.teachers.UseVisualStyleBackColor = false;
            this.teachers.Click += new System.EventHandler(this.teachers_Click);
            // 
            // about
            // 
            this.about.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.about, "about");
            this.about.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.about.Name = "about";
            this.about.UseVisualStyleBackColor = false;
            this.about.Click += new System.EventHandler(this.button2_Click);
            // 
            // spravk
            // 
            this.spravk.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.spravk, "spravk");
            this.spravk.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.spravk.Name = "spravk";
            this.spravk.UseVisualStyleBackColor = false;
            this.spravk.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // sgo
            // 
            this.sgo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sgo.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.sgo, "sgo");
            this.sgo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sgo.Name = "sgo";
            this.sgo.UseVisualStyleBackColor = false;
            this.sgo.Click += new System.EventHandler(this.filtr_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menu.Controls.Add(this.admin);
            this.menu.Controls.Add(this.teachers);
            this.menu.Controls.Add(this.sgo);
            this.menu.Controls.Add(this.button6);
            this.menu.Controls.Add(this.exit);
            this.menu.Controls.Add(this.loginlbl);
            this.menu.Controls.Add(this.button5);
            this.menu.Controls.Add(this.about);
            this.menu.Controls.Add(this.spravk);
            resources.ApplyResources(this.menu, "menu");
            this.menu.Name = "menu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.pan);
            this.Name = "main";
            this.Load += new System.EventHandler(this.main_Load);
            this.pan.ResumeLayout(false);
            this.pan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label loginlbl;
        private System.Windows.Forms.Button teachers;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.Button spravk;
        private System.Windows.Forms.Button sgo;
        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button admin;
        private System.Windows.Forms.Label label2;
    }
}

