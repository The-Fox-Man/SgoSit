﻿namespace FoxManPr
{
    partial class AddClassesAndSub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddClassesAndSub));
            this.pan1 = new System.Windows.Forms.Panel();
            this.pan2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.t1 = new System.Windows.Forms.TextBox();
            this.t2 = new System.Windows.Forms.TextBox();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pan1
            // 
            this.pan1.AutoScroll = true;
            this.pan1.BackgroundImage = global::FoxManPr.Properties.Resources.Line;
            this.pan1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan1.Location = new System.Drawing.Point(16, 60);
            this.pan1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pan1.Name = "pan1";
            this.pan1.Size = new System.Drawing.Size(570, 614);
            this.pan1.TabIndex = 0;
            // 
            // pan2
            // 
            this.pan2.AutoScroll = true;
            this.pan2.BackgroundImage = global::FoxManPr.Properties.Resources.Line;
            this.pan2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan2.Location = new System.Drawing.Point(595, 60);
            this.pan2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pan2.Name = "pan2";
            this.pan2.Size = new System.Drawing.Size(550, 614);
            this.pan2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Добаавить предмет";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(595, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Добавить класс";
            // 
            // t1
            // 
            this.t1.Location = new System.Drawing.Point(171, 22);
            this.t1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(241, 22);
            this.t1.TabIndex = 3;
            // 
            // t2
            // 
            this.t2.Location = new System.Drawing.Point(729, 22);
            this.t2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(239, 22);
            this.t2.TabIndex = 4;
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(421, 20);
            this.bt1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(165, 28);
            this.bt1.TabIndex = 5;
            this.bt1.Text = "Добавить";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(980, 21);
            this.bt2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(165, 28);
            this.bt2.TabIndex = 6;
            this.bt2.Text = "Добавить";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // AddClassesAndSub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FoxManPr.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1161, 689);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pan2);
            this.Controls.Add(this.pan1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1177, 728);
            this.Name = "AddClassesAndSub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить класс или предмет";
            this.Load += new System.EventHandler(this.AddClassesAndSub_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pan1;
        private System.Windows.Forms.Panel pan2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.TextBox t2;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
    }
}