namespace KayraCelikel230715025MidTerm
{
    partial class frmMain
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
            this.lblTextEditor = new System.Windows.Forms.Label();
            this.btnNext1 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTextEditor
            // 
            this.lblTextEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTextEditor.Location = new System.Drawing.Point(12, 77);
            this.lblTextEditor.Name = "lblTextEditor";
            this.lblTextEditor.Size = new System.Drawing.Size(761, 46);
            this.lblTextEditor.TabIndex = 4;
            this.lblTextEditor.Text = "Welcome to Main Page";
            this.lblTextEditor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNext1
            // 
            this.btnNext1.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnNext1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNext1.ForeColor = System.Drawing.Color.White;
            this.btnNext1.Location = new System.Drawing.Point(623, 382);
            this.btnNext1.Name = "btnNext1";
            this.btnNext1.Size = new System.Drawing.Size(150, 40);
            this.btnNext1.TabIndex = 7;
            this.btnNext1.Text = "Next";
            this.btnNext1.UseVisualStyleBackColor = false;
            this.btnNext1.Click += new System.EventHandler(this.btnNext1_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(623, 34);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 40);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNext1);
            this.Controls.Add(this.lblTextEditor);
            this.Name = "frmMain";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTextEditor;
        private System.Windows.Forms.Button btnNext1;
        private System.Windows.Forms.Button btnExit;
    }
}