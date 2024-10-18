namespace MangInasal
{
    partial class gmm1
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
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.quantity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.BackgroundImage = global::MangInasal.Properties.Resources.btncancel;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(572, 356);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 50);
            this.button4.TabIndex = 1;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.BackgroundImage = global::MangInasal.Properties.Resources.btndone;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(764, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 50);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.plus.BackgroundImage = global::MangInasal.Properties.Resources.plus;
            this.plus.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.plus.FlatAppearance.BorderSize = 0;
            this.plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plus.Location = new System.Drawing.Point(764, 228);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(75, 45);
            this.plus.TabIndex = 12;
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.button5_Click);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.minus.BackgroundImage = global::MangInasal.Properties.Resources.minus;
            this.minus.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.minus.FlatAppearance.BorderSize = 0;
            this.minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minus.Location = new System.Drawing.Point(860, 228);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(75, 45);
            this.minus.TabIndex = 13;
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // quantity
            // 
            this.quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.Location = new System.Drawing.Point(644, 228);
            this.quantity.Multiline = true;
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(114, 45);
            this.quantity.TabIndex = 14;
            // 
            // gmm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MangInasal.Properties.Resources.cat1meal1;
            this.ClientSize = new System.Drawing.Size(984, 436);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "gmm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "gmm1";
            this.Load += new System.EventHandler(this.gmm1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        public System.Windows.Forms.TextBox quantity;
    }
}