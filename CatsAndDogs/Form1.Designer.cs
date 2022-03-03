namespace CatsAndDogs
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
            this.label1 = new System.Windows.Forms.Label();
            this.ListPets = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ListPetNames = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pets";
            // 
            // ListPets
            // 
            this.ListPets.FormattingEnabled = true;
            this.ListPets.Location = new System.Drawing.Point(163, 153);
            this.ListPets.Name = "ListPets";
            this.ListPets.Size = new System.Drawing.Size(120, 95);
            this.ListPets.TabIndex = 1;
            this.ListPets.SelectedIndexChanged += new System.EventHandler(this.ListPets_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(463, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pet Names";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ListPetNames
            // 
            this.ListPetNames.FormattingEnabled = true;
            this.ListPetNames.Location = new System.Drawing.Point(466, 153);
            this.ListPetNames.Name = "ListPetNames";
            this.ListPetNames.Size = new System.Drawing.Size(120, 95);
            this.ListPetNames.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListPetNames);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListPets);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ListPets;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ListPetNames;
    }
}

