
namespace Custom_Control
{
    partial class todo_item
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(todo_item));
            this.del = new Bunifu.Framework.UI.BunifuImageButton();
            this.label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.check = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.del)).BeginInit();
            this.SuspendLayout();
            // 
            // del
            // 
            this.del.BackColor = System.Drawing.Color.Transparent;
            this.del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.del.Image = ((System.Drawing.Image)(resources.GetObject("del.Image")));
            this.del.ImageActive = null;
            this.del.Location = new System.Drawing.Point(415, 14);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(35, 35);
            this.del.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.del.TabIndex = 5;
            this.del.TabStop = false;
            this.del.Zoom = 10;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(56, 23);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(71, 17);
            this.label.TabIndex = 4;
            this.label.Text = "To do item";
            // 
            // check
            // 
            this.check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.check.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.check.Checked = false;
            this.check.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check.ForeColor = System.Drawing.Color.White;
            this.check.Location = new System.Drawing.Point(17, 23);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(20, 20);
            this.check.TabIndex = 3;
            this.check.OnChange += new System.EventHandler(this.check_OnChange);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // todo_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.del);
            this.Controls.Add(this.label);
            this.Controls.Add(this.check);
            this.Name = "todo_item";
            this.Size = new System.Drawing.Size(466, 62);
            ((System.ComponentModel.ISupportInitialize)(this.del)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton del;
        private Bunifu.Framework.UI.BunifuCustomLabel label;
        public Bunifu.Framework.UI.BunifuCheckbox check;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}
