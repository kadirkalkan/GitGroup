namespace GitGroup
{
    partial class Form1
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
            this.btnOguz = new System.Windows.Forms.Button();
            this.btnUgur = new System.Windows.Forms.Button();
            this.btnSinan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOguz
            // 
            this.btnOguz.Location = new System.Drawing.Point(78, 49);
            this.btnOguz.Name = "btnOguz";
            this.btnOguz.Size = new System.Drawing.Size(129, 120);
            this.btnOguz.TabIndex = 0;
            this.btnOguz.Tag = "oguz";
            this.btnOguz.Text = "Oğuz Form";
            this.btnOguz.UseVisualStyleBackColor = true;
            this.btnOguz.Click += new System.EventHandler(this.btnForm_Click);
            // 
            // btnUgur
            // 
            this.btnUgur.Location = new System.Drawing.Point(319, 49);
            this.btnUgur.Name = "btnUgur";
            this.btnUgur.Size = new System.Drawing.Size(129, 120);
            this.btnUgur.TabIndex = 1;
            this.btnUgur.Tag = "ugur";
            this.btnUgur.Text = "Uğur Form";
            this.btnUgur.UseVisualStyleBackColor = true;
            this.btnUgur.Click += new System.EventHandler(this.btnForm_Click);
            // 
            // btnSinan
            // 
            this.btnSinan.Location = new System.Drawing.Point(549, 49);
            this.btnSinan.Name = "btnSinan";
            this.btnSinan.Size = new System.Drawing.Size(129, 120);
            this.btnSinan.TabIndex = 2;
            this.btnSinan.Tag = "sinan";
            this.btnSinan.Text = "Sinan Form";
            this.btnSinan.UseVisualStyleBackColor = true;
            this.btnSinan.Click += new System.EventHandler(this.btnForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSinan);
            this.Controls.Add(this.btnUgur);
            this.Controls.Add(this.btnOguz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOguz;
        private System.Windows.Forms.Button btnUgur;
        private System.Windows.Forms.Button btnSinan;
    }
}

