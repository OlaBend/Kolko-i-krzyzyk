﻿
namespace Kolko_i_krzyzyk
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.a1 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.c1 = new System.Windows.Forms.Button();
            this.a2 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.c2 = new System.Windows.Forms.Button();
            this.a3 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.c3 = new System.Windows.Forms.Button();
            this.wyczysc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kółko i krzyżyk";
            // 
            // a1
            // 
            this.a1.Location = new System.Drawing.Point(28, 66);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(127, 111);
            this.a1.TabIndex = 1;
            this.a1.UseVisualStyleBackColor = true;
            this.a1.Click += new System.EventHandler(this.a1_Click);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(161, 65);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(127, 111);
            this.b1.TabIndex = 2;
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // c1
            // 
            this.c1.Location = new System.Drawing.Point(294, 67);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(127, 109);
            this.c1.TabIndex = 3;
            this.c1.UseVisualStyleBackColor = true;
            this.c1.Click += new System.EventHandler(this.c1_Click);
            // 
            // a2
            // 
            this.a2.Location = new System.Drawing.Point(27, 183);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(128, 109);
            this.a2.TabIndex = 4;
            this.a2.UseVisualStyleBackColor = true;
            this.a2.Click += new System.EventHandler(this.a2_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(161, 183);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(127, 109);
            this.b2.TabIndex = 5;
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // c2
            // 
            this.c2.Location = new System.Drawing.Point(294, 183);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(127, 109);
            this.c2.TabIndex = 6;
            this.c2.UseVisualStyleBackColor = true;
            this.c2.Click += new System.EventHandler(this.c2_Click);
            // 
            // a3
            // 
            this.a3.Location = new System.Drawing.Point(27, 298);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(127, 109);
            this.a3.TabIndex = 7;
            this.a3.UseVisualStyleBackColor = true;
            this.a3.Click += new System.EventHandler(this.a3_Click);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(161, 298);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(127, 109);
            this.b3.TabIndex = 8;
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // c3
            // 
            this.c3.Location = new System.Drawing.Point(294, 298);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(127, 109);
            this.c3.TabIndex = 9;
            this.c3.UseVisualStyleBackColor = true;
            this.c3.Click += new System.EventHandler(this.c3_Click);
            // 
            // wyczysc
            // 
            this.wyczysc.Location = new System.Drawing.Point(28, 413);
            this.wyczysc.Name = "wyczysc";
            this.wyczysc.Size = new System.Drawing.Size(393, 44);
            this.wyczysc.TabIndex = 10;
            this.wyczysc.Text = "wyczysc";
            this.wyczysc.UseVisualStyleBackColor = true;
            this.wyczysc.Click += new System.EventHandler(this.wyczysc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.wyczysc);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.a3);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Kółko i krzyżyk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button a1;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button c1;
        private System.Windows.Forms.Button a2;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button c2;
        private System.Windows.Forms.Button a3;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button c3;
        private System.Windows.Forms.Button wyczysc;
    }
}

