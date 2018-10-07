namespace MegaDesk
{
    partial class MainMenu
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
            this.btnAddQuote = new System.Windows.Forms.Button();
            this.btnViewQuotes = new System.Windows.Forms.Button();
            this.btnSearchQuotes = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddQuote
            // 
            this.btnAddQuote.AutoSize = true;
            this.btnAddQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddQuote.Location = new System.Drawing.Point(74, 60);
            this.btnAddQuote.Name = "btnAddQuote";
            this.btnAddQuote.Size = new System.Drawing.Size(194, 62);
            this.btnAddQuote.TabIndex = 0;
            this.btnAddQuote.Text = "&Add New Quote";
            this.btnAddQuote.UseVisualStyleBackColor = true;
            this.btnAddQuote.Click += new System.EventHandler(this.btnAddQuote_Click);
            // 
            // btnViewQuotes
            // 
            this.btnViewQuotes.AutoSize = true;
            this.btnViewQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewQuotes.Location = new System.Drawing.Point(74, 147);
            this.btnViewQuotes.Name = "btnViewQuotes";
            this.btnViewQuotes.Size = new System.Drawing.Size(194, 62);
            this.btnViewQuotes.TabIndex = 1;
            this.btnViewQuotes.Text = "&View Quotes";
            this.btnViewQuotes.UseVisualStyleBackColor = true;
            // 
            // btnSearchQuotes
            // 
            this.btnSearchQuotes.AutoSize = true;
            this.btnSearchQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchQuotes.Location = new System.Drawing.Point(74, 237);
            this.btnSearchQuotes.Name = "btnSearchQuotes";
            this.btnSearchQuotes.Size = new System.Drawing.Size(194, 62);
            this.btnSearchQuotes.TabIndex = 2;
            this.btnSearchQuotes.Text = "&Search Quotes";
            this.btnSearchQuotes.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(74, 323);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(194, 62);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearchQuotes);
            this.Controls.Add(this.btnViewQuotes);
            this.Controls.Add(this.btnAddQuote);
            this.Name = "MainMenu";
            this.Text = "MegaDesk1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddQuote;
        private System.Windows.Forms.Button btnViewQuotes;
        private System.Windows.Forms.Button btnSearchQuotes;
        private System.Windows.Forms.Button btnExit;
    }
}

