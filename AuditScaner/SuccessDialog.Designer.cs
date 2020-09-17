namespace AuditScaner
{
    partial class SuccessDialog
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
            this.Dialog = new FontAwesome.Sharp.IconButton();
            this.DialogLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Dialog
            // 
            this.Dialog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.Dialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dialog.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Dialog.ForeColor = System.Drawing.Color.Gainsboro;
            this.Dialog.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Dialog.IconColor = System.Drawing.Color.Gainsboro;
            this.Dialog.IconSize = 32;
            this.Dialog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dialog.Location = new System.Drawing.Point(244, 257);
            this.Dialog.Name = "Dialog";
            this.Dialog.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Dialog.Rotation = 0D;
            this.Dialog.Size = new System.Drawing.Size(438, 30);
            this.Dialog.TabIndex = 19;
            this.Dialog.Text = "OK";
            this.Dialog.UseVisualStyleBackColor = false;
            this.Dialog.Click += new System.EventHandler(this.Dialog_Click);
            // 
            // DialogLabel
            // 
            this.DialogLabel.AutoSize = true;
            this.DialogLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DialogLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.DialogLabel.Location = new System.Drawing.Point(247, 201);
            this.DialogLabel.Name = "DialogLabel";
            this.DialogLabel.Size = new System.Drawing.Size(435, 37);
            this.DialogLabel.TabIndex = 18;
            this.DialogLabel.Text = "Task Completed Successfully";
            // 
            // SuccessDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(908, 582);
            this.Controls.Add(this.Dialog);
            this.Controls.Add(this.DialogLabel);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SuccessDialog";
            this.Text = "SuccessDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton Dialog;
        private System.Windows.Forms.Label DialogLabel;
    }
}