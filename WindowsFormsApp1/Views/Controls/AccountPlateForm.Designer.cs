
namespace WindowsFormsApp1.Views.Controls
{
    partial class AccountPlateForm
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
            this.Status = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.Occupy = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Username = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.picture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Status
            // 
            this.Status.BackColor = System.Drawing.Color.Transparent;
            this.Status.CheckedState.Parent = this.Status;
            this.Status.CustomImages.Parent = this.Status;
            this.Status.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Status.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Status.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Status.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Status.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Status.DisabledState.Parent = this.Status;
            this.Status.FillColor = System.Drawing.Color.Green;
            this.Status.FillColor2 = System.Drawing.Color.Green;
            this.Status.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Status.ForeColor = System.Drawing.Color.White;
            this.Status.HoverState.Parent = this.Status;
            this.Status.Location = new System.Drawing.Point(63, 59);
            this.Status.Name = "Status";
            this.Status.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Status.ShadowDecoration.Parent = this.Status;
            this.Status.Size = new System.Drawing.Size(15, 15);
            this.Status.TabIndex = 8;
            // 
            // Occupy
            // 
            this.Occupy.BackColor = System.Drawing.Color.Transparent;
            this.Occupy.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Occupy.ForeColor = System.Drawing.Color.Black;
            this.Occupy.Location = new System.Drawing.Point(91, 51);
            this.Occupy.Name = "Occupy";
            this.Occupy.Size = new System.Drawing.Size(45, 16);
            this.Occupy.TabIndex = 7;
            this.Occupy.Text = "Student";
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.Color.Transparent;
            this.Username.Font = new System.Drawing.Font("Roboto Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(90, 18);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(90, 20);
            this.Username.TabIndex = 6;
            this.Username.Text = "Jame Randal";
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.Color.Gray;
            this.picture.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.picture.Image = global::WindowsFormsApp1.Properties.Resources.a901df9ac69b00f650e9942d37fa6658;
            this.picture.ImageRotate = 0F;
            this.picture.Location = new System.Drawing.Point(14, 12);
            this.picture.Name = "picture";
            this.picture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picture.ShadowDecoration.Parent = this.picture;
            this.picture.Size = new System.Drawing.Size(64, 64);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 5;
            this.picture.TabStop = false;
            // 
            // AccountPlateForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Occupy);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.picture);
            this.Name = "AccountPlateForm";
            this.Size = new System.Drawing.Size(370, 95);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientCircleButton Status;
        private Guna.UI2.WinForms.Guna2HtmlLabel Occupy;
        private Guna.UI2.WinForms.Guna2HtmlLabel Username;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picture;
    }
}
