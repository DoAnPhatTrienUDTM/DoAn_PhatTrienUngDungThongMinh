﻿
namespace GUI
{
    partial class frmManHinh
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
            this.control_ManHinh1 = new BLL_DAL.Control_ManHinh();
            this.SuspendLayout();
            // 
            // control_ManHinh1
            // 
            this.control_ManHinh1.Location = new System.Drawing.Point(4, 1);
            this.control_ManHinh1.Name = "control_ManHinh1";
            this.control_ManHinh1.Size = new System.Drawing.Size(1036, 707);
            this.control_ManHinh1.TabIndex = 0;
            // 
            // frmManHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 717);
            this.Controls.Add(this.control_ManHinh1);
            this.Name = "frmManHinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Màn hình sử dụng";
            this.ResumeLayout(false);

        }

        #endregion

        private BLL_DAL.Control_ManHinh control_ManHinh1;
    }
}