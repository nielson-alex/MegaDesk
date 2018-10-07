namespace MegaDesk
{
    partial class AddQuote
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.tbDepth = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblWidthError = new System.Windows.Forms.Label();
            this.lblDepthError = new System.Windows.Forms.Label();
            this.lblSubmitError = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlMaterialOptions = new System.Windows.Forms.Panel();
            this.rbPine = new System.Windows.Forms.RadioButton();
            this.rbVeneer = new System.Windows.Forms.RadioButton();
            this.rbRosewood = new System.Windows.Forms.RadioButton();
            this.rbOak = new System.Windows.Forms.RadioButton();
            this.rbLaminate = new System.Windows.Forms.RadioButton();
            this.pnlRushOrderOptions = new System.Windows.Forms.Panel();
            this.rb7 = new System.Windows.Forms.RadioButton();
            this.rb5 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb0 = new System.Windows.Forms.RadioButton();
            this.pnlNoOfDrawers = new System.Windows.Forms.Panel();
            this.rbDrawers7 = new System.Windows.Forms.RadioButton();
            this.rbDrawers6 = new System.Windows.Forms.RadioButton();
            this.rbDrawers5 = new System.Windows.Forms.RadioButton();
            this.rbDrawers4 = new System.Windows.Forms.RadioButton();
            this.rbDrawers3 = new System.Windows.Forms.RadioButton();
            this.rbDrawers2 = new System.Windows.Forms.RadioButton();
            this.rbDrawers1 = new System.Windows.Forms.RadioButton();
            this.rbDrawers0 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlMaterialOptions.SuspendLayout();
            this.pnlRushOrderOptions.SuspendLayout();
            this.pnlNoOfDrawers.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(5, 376);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(194, 62);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Width (in Inches):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Depth (in Inches):";
            // 
            // tbWidth
            // 
            this.tbWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWidth.Location = new System.Drawing.Point(218, 9);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(250, 35);
            this.tbWidth.TabIndex = 4;
            this.tbWidth.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CheckIfChar);
            // 
            // tbDepth
            // 
            this.tbDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDepth.Location = new System.Drawing.Point(218, 88);
            this.tbDepth.Name = "tbDepth";
            this.tbDepth.Size = new System.Drawing.Size(250, 35);
            this.tbDepth.TabIndex = 5;
            this.tbDepth.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CheckIfChar);
            // 
            // btnSubmit
            // 
            this.btnSubmit.AutoSize = true;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(594, 376);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(194, 62);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "&Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblWidthError
            // 
            this.lblWidthError.AutoSize = true;
            this.lblWidthError.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidthError.ForeColor = System.Drawing.Color.Red;
            this.lblWidthError.Location = new System.Drawing.Point(213, 47);
            this.lblWidthError.Name = "lblWidthError";
            this.lblWidthError.Size = new System.Drawing.Size(0, 29);
            this.lblWidthError.TabIndex = 7;
            // 
            // lblDepthError
            // 
            this.lblDepthError.AutoSize = true;
            this.lblDepthError.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepthError.ForeColor = System.Drawing.Color.Red;
            this.lblDepthError.Location = new System.Drawing.Point(213, 126);
            this.lblDepthError.Name = "lblDepthError";
            this.lblDepthError.Size = new System.Drawing.Size(0, 29);
            this.lblDepthError.TabIndex = 8;
            // 
            // lblSubmitError
            // 
            this.lblSubmitError.AutoSize = true;
            this.lblSubmitError.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubmitError.ForeColor = System.Drawing.Color.Red;
            this.lblSubmitError.Location = new System.Drawing.Point(386, 276);
            this.lblSubmitError.Name = "lblSubmitError";
            this.lblSubmitError.Size = new System.Drawing.Size(0, 29);
            this.lblSubmitError.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(300, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Surface Material";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(592, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 29);
            this.label4.TabIndex = 17;
            this.label4.Text = "Rush Order Days";
            // 
            // pnlMaterialOptions
            // 
            this.pnlMaterialOptions.Controls.Add(this.rbPine);
            this.pnlMaterialOptions.Controls.Add(this.rbVeneer);
            this.pnlMaterialOptions.Controls.Add(this.rbRosewood);
            this.pnlMaterialOptions.Controls.Add(this.rbOak);
            this.pnlMaterialOptions.Controls.Add(this.rbLaminate);
            this.pnlMaterialOptions.Location = new System.Drawing.Point(316, 211);
            this.pnlMaterialOptions.Name = "pnlMaterialOptions";
            this.pnlMaterialOptions.Size = new System.Drawing.Size(160, 199);
            this.pnlMaterialOptions.TabIndex = 21;
            // 
            // rbPine
            // 
            this.rbPine.AutoSize = true;
            this.rbPine.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPine.Location = new System.Drawing.Point(3, 156);
            this.rbPine.Name = "rbPine";
            this.rbPine.Size = new System.Drawing.Size(80, 33);
            this.rbPine.TabIndex = 20;
            this.rbPine.TabStop = true;
            this.rbPine.Text = "Pine";
            this.rbPine.UseVisualStyleBackColor = true;
            // 
            // rbVeneer
            // 
            this.rbVeneer.AutoSize = true;
            this.rbVeneer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVeneer.Location = new System.Drawing.Point(3, 120);
            this.rbVeneer.Name = "rbVeneer";
            this.rbVeneer.Size = new System.Drawing.Size(109, 33);
            this.rbVeneer.TabIndex = 19;
            this.rbVeneer.TabStop = true;
            this.rbVeneer.Text = "Veneer";
            this.rbVeneer.UseVisualStyleBackColor = true;
            // 
            // rbRosewood
            // 
            this.rbRosewood.AutoSize = true;
            this.rbRosewood.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRosewood.Location = new System.Drawing.Point(3, 81);
            this.rbRosewood.Name = "rbRosewood";
            this.rbRosewood.Size = new System.Drawing.Size(148, 33);
            this.rbRosewood.TabIndex = 18;
            this.rbRosewood.TabStop = true;
            this.rbRosewood.Text = "Rosewood";
            this.rbRosewood.UseVisualStyleBackColor = true;
            // 
            // rbOak
            // 
            this.rbOak.AutoSize = true;
            this.rbOak.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOak.Location = new System.Drawing.Point(3, 42);
            this.rbOak.Name = "rbOak";
            this.rbOak.Size = new System.Drawing.Size(75, 33);
            this.rbOak.TabIndex = 17;
            this.rbOak.TabStop = true;
            this.rbOak.Text = "Oak";
            this.rbOak.UseVisualStyleBackColor = true;
            // 
            // rbLaminate
            // 
            this.rbLaminate.AutoSize = true;
            this.rbLaminate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLaminate.Location = new System.Drawing.Point(3, 3);
            this.rbLaminate.Name = "rbLaminate";
            this.rbLaminate.Size = new System.Drawing.Size(129, 33);
            this.rbLaminate.TabIndex = 16;
            this.rbLaminate.TabStop = true;
            this.rbLaminate.Text = "Laminate";
            this.rbLaminate.UseVisualStyleBackColor = true;
            // 
            // pnlRushOrderOptions
            // 
            this.pnlRushOrderOptions.Controls.Add(this.rb7);
            this.pnlRushOrderOptions.Controls.Add(this.rb5);
            this.pnlRushOrderOptions.Controls.Add(this.rb3);
            this.pnlRushOrderOptions.Controls.Add(this.rb0);
            this.pnlRushOrderOptions.Location = new System.Drawing.Point(597, 211);
            this.pnlRushOrderOptions.Name = "pnlRushOrderOptions";
            this.pnlRushOrderOptions.Size = new System.Drawing.Size(160, 153);
            this.pnlRushOrderOptions.TabIndex = 22;
            // 
            // rb7
            // 
            this.rb7.AutoSize = true;
            this.rb7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb7.Location = new System.Drawing.Point(3, 119);
            this.rb7.Name = "rb7";
            this.rb7.Size = new System.Drawing.Size(44, 33);
            this.rb7.TabIndex = 24;
            this.rb7.TabStop = true;
            this.rb7.Text = "7";
            this.rb7.UseVisualStyleBackColor = true;
            // 
            // rb5
            // 
            this.rb5.AutoSize = true;
            this.rb5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb5.Location = new System.Drawing.Point(3, 81);
            this.rb5.Name = "rb5";
            this.rb5.Size = new System.Drawing.Size(44, 33);
            this.rb5.TabIndex = 23;
            this.rb5.TabStop = true;
            this.rb5.Text = "5";
            this.rb5.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb3.Location = new System.Drawing.Point(3, 42);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(44, 33);
            this.rb3.TabIndex = 22;
            this.rb3.TabStop = true;
            this.rb3.Text = "3";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // rb0
            // 
            this.rb0.AutoSize = true;
            this.rb0.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb0.Location = new System.Drawing.Point(3, 3);
            this.rb0.Name = "rb0";
            this.rb0.Size = new System.Drawing.Size(44, 33);
            this.rb0.TabIndex = 21;
            this.rb0.TabStop = true;
            this.rb0.Text = "0";
            this.rb0.UseVisualStyleBackColor = true;
            // 
            // pnlNoOfDrawers
            // 
            this.pnlNoOfDrawers.Controls.Add(this.rbDrawers7);
            this.pnlNoOfDrawers.Controls.Add(this.rbDrawers6);
            this.pnlNoOfDrawers.Controls.Add(this.rbDrawers5);
            this.pnlNoOfDrawers.Controls.Add(this.rbDrawers4);
            this.pnlNoOfDrawers.Controls.Add(this.rbDrawers3);
            this.pnlNoOfDrawers.Controls.Add(this.rbDrawers2);
            this.pnlNoOfDrawers.Controls.Add(this.rbDrawers1);
            this.pnlNoOfDrawers.Controls.Add(this.rbDrawers0);
            this.pnlNoOfDrawers.Location = new System.Drawing.Point(21, 211);
            this.pnlNoOfDrawers.Name = "pnlNoOfDrawers";
            this.pnlNoOfDrawers.Size = new System.Drawing.Size(168, 153);
            this.pnlNoOfDrawers.TabIndex = 24;
            // 
            // rbDrawers7
            // 
            this.rbDrawers7.AutoSize = true;
            this.rbDrawers7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDrawers7.Location = new System.Drawing.Point(53, 81);
            this.rbDrawers7.Name = "rbDrawers7";
            this.rbDrawers7.Size = new System.Drawing.Size(44, 33);
            this.rbDrawers7.TabIndex = 28;
            this.rbDrawers7.TabStop = true;
            this.rbDrawers7.Text = "7";
            this.rbDrawers7.UseVisualStyleBackColor = true;
            // 
            // rbDrawers6
            // 
            this.rbDrawers6.AutoSize = true;
            this.rbDrawers6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDrawers6.Location = new System.Drawing.Point(3, 81);
            this.rbDrawers6.Name = "rbDrawers6";
            this.rbDrawers6.Size = new System.Drawing.Size(44, 33);
            this.rbDrawers6.TabIndex = 27;
            this.rbDrawers6.TabStop = true;
            this.rbDrawers6.Text = "6";
            this.rbDrawers6.UseVisualStyleBackColor = true;
            // 
            // rbDrawers5
            // 
            this.rbDrawers5.AutoSize = true;
            this.rbDrawers5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDrawers5.Location = new System.Drawing.Point(103, 42);
            this.rbDrawers5.Name = "rbDrawers5";
            this.rbDrawers5.Size = new System.Drawing.Size(44, 33);
            this.rbDrawers5.TabIndex = 26;
            this.rbDrawers5.TabStop = true;
            this.rbDrawers5.Text = "5";
            this.rbDrawers5.UseVisualStyleBackColor = true;
            // 
            // rbDrawers4
            // 
            this.rbDrawers4.AutoSize = true;
            this.rbDrawers4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDrawers4.Location = new System.Drawing.Point(53, 42);
            this.rbDrawers4.Name = "rbDrawers4";
            this.rbDrawers4.Size = new System.Drawing.Size(44, 33);
            this.rbDrawers4.TabIndex = 25;
            this.rbDrawers4.TabStop = true;
            this.rbDrawers4.Text = "4";
            this.rbDrawers4.UseVisualStyleBackColor = true;
            // 
            // rbDrawers3
            // 
            this.rbDrawers3.AutoSize = true;
            this.rbDrawers3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDrawers3.Location = new System.Drawing.Point(3, 42);
            this.rbDrawers3.Name = "rbDrawers3";
            this.rbDrawers3.Size = new System.Drawing.Size(44, 33);
            this.rbDrawers3.TabIndex = 24;
            this.rbDrawers3.TabStop = true;
            this.rbDrawers3.Text = "3";
            this.rbDrawers3.UseVisualStyleBackColor = true;
            // 
            // rbDrawers2
            // 
            this.rbDrawers2.AutoSize = true;
            this.rbDrawers2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDrawers2.Location = new System.Drawing.Point(103, 3);
            this.rbDrawers2.Name = "rbDrawers2";
            this.rbDrawers2.Size = new System.Drawing.Size(44, 33);
            this.rbDrawers2.TabIndex = 23;
            this.rbDrawers2.TabStop = true;
            this.rbDrawers2.Text = "2";
            this.rbDrawers2.UseVisualStyleBackColor = true;
            // 
            // rbDrawers1
            // 
            this.rbDrawers1.AutoSize = true;
            this.rbDrawers1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDrawers1.Location = new System.Drawing.Point(53, 3);
            this.rbDrawers1.Name = "rbDrawers1";
            this.rbDrawers1.Size = new System.Drawing.Size(44, 33);
            this.rbDrawers1.TabIndex = 22;
            this.rbDrawers1.TabStop = true;
            this.rbDrawers1.Text = "1";
            this.rbDrawers1.UseVisualStyleBackColor = true;
            // 
            // rbDrawers0
            // 
            this.rbDrawers0.AutoSize = true;
            this.rbDrawers0.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDrawers0.Location = new System.Drawing.Point(3, 3);
            this.rbDrawers0.Name = "rbDrawers0";
            this.rbDrawers0.Size = new System.Drawing.Size(44, 33);
            this.rbDrawers0.TabIndex = 21;
            this.rbDrawers0.TabStop = true;
            this.rbDrawers0.Text = "0";
            this.rbDrawers0.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 29);
            this.label5.TabIndex = 23;
            this.label5.Text = "No. of Drawers";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlNoOfDrawers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pnlRushOrderOptions);
            this.Controls.Add(this.pnlMaterialOptions);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSubmitError);
            this.Controls.Add(this.lblDepthError);
            this.Controls.Add(this.lblWidthError);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbDepth);
            this.Controls.Add(this.tbWidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Name = "AddQuote";
            this.Text = "Get Quote";
            this.pnlMaterialOptions.ResumeLayout(false);
            this.pnlMaterialOptions.PerformLayout();
            this.pnlRushOrderOptions.ResumeLayout(false);
            this.pnlRushOrderOptions.PerformLayout();
            this.pnlNoOfDrawers.ResumeLayout(false);
            this.pnlNoOfDrawers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.TextBox tbDepth;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblWidthError;
        private System.Windows.Forms.Label lblDepthError;
        private System.Windows.Forms.Label lblSubmitError;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlMaterialOptions;
        private System.Windows.Forms.RadioButton rbPine;
        private System.Windows.Forms.RadioButton rbVeneer;
        private System.Windows.Forms.RadioButton rbRosewood;
        private System.Windows.Forms.RadioButton rbOak;
        private System.Windows.Forms.RadioButton rbLaminate;
        private System.Windows.Forms.Panel pnlRushOrderOptions;
        private System.Windows.Forms.RadioButton rb7;
        private System.Windows.Forms.RadioButton rb5;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb0;
        private System.Windows.Forms.Panel pnlNoOfDrawers;
        private System.Windows.Forms.RadioButton rbDrawers7;
        private System.Windows.Forms.RadioButton rbDrawers6;
        private System.Windows.Forms.RadioButton rbDrawers5;
        private System.Windows.Forms.RadioButton rbDrawers4;
        private System.Windows.Forms.RadioButton rbDrawers3;
        private System.Windows.Forms.RadioButton rbDrawers2;
        private System.Windows.Forms.RadioButton rbDrawers1;
        private System.Windows.Forms.RadioButton rbDrawers0;
        private System.Windows.Forms.Label label5;
    }
}

