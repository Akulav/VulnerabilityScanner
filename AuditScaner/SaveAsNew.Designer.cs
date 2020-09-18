namespace AuditScaner
{
    partial class SaveAsNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveAsNew));
            this.NewName = new System.Windows.Forms.TextBox();
            this.Save = new FontAwesome.Sharp.IconButton();
            this.backToEditPolicies = new FontAwesome.Sharp.IconButton();
            this.Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewName
            // 
            resources.ApplyResources(this.NewName, "NewName");
            this.NewName.Name = "NewName";
            // 
            // Save
            // 
            resources.ApplyResources(this.Save, "Save");
            this.Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.Save.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Save.ForeColor = System.Drawing.Color.Gainsboro;
            this.Save.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Save.IconColor = System.Drawing.Color.Gainsboro;
            this.Save.IconSize = 32;
            this.Save.Name = "Save";
            this.Save.Rotation = 0D;
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // backToEditPolicies
            // 
            resources.ApplyResources(this.backToEditPolicies, "backToEditPolicies");
            this.backToEditPolicies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.backToEditPolicies.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.backToEditPolicies.ForeColor = System.Drawing.Color.Gainsboro;
            this.backToEditPolicies.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.backToEditPolicies.IconColor = System.Drawing.Color.Gainsboro;
            this.backToEditPolicies.IconSize = 32;
            this.backToEditPolicies.Name = "backToEditPolicies";
            this.backToEditPolicies.Rotation = 0D;
            this.backToEditPolicies.UseVisualStyleBackColor = false;
            this.backToEditPolicies.Click += new System.EventHandler(this.backToEditPolicies_Click);
            // 
            // Label
            // 
            resources.ApplyResources(this.Label, "Label");
            this.Label.ForeColor = System.Drawing.Color.Gainsboro;
            this.Label.Name = "Label";
            // 
            // SaveAsNew
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.Controls.Add(this.Label);
            this.Controls.Add(this.backToEditPolicies);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.NewName);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SaveAsNew";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NewName;
        private FontAwesome.Sharp.IconButton Save;
        private FontAwesome.Sharp.IconButton backToEditPolicies;
        private System.Windows.Forms.Label Label;
    }
}