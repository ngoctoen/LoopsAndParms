namespace LoopsAndParms
{
    partial class frmLoopsAndParms
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
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnTriples = new System.Windows.Forms.Button();
            this.btnByVal = new System.Windows.Forms.Button();
            this.btnByRef = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(12, 12);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(288, 209);
            this.txtOutput.TabIndex = 0;
            // 
            // btnTriples
            // 
            this.btnTriples.Location = new System.Drawing.Point(12, 227);
            this.btnTriples.Name = "btnTriples";
            this.btnTriples.Size = new System.Drawing.Size(68, 23);
            this.btnTriples.TabIndex = 1;
            this.btnTriples.Text = "Triples";
            this.btnTriples.UseVisualStyleBackColor = true;
            this.btnTriples.Click += new System.EventHandler(this.btnTriples_Click);
            // 
            // btnByVal
            // 
            this.btnByVal.Location = new System.Drawing.Point(83, 227);
            this.btnByVal.Name = "btnByVal";
            this.btnByVal.Size = new System.Drawing.Size(68, 23);
            this.btnByVal.TabIndex = 2;
            this.btnByVal.Text = "By Val";
            this.btnByVal.UseVisualStyleBackColor = true;
            this.btnByVal.Click += new System.EventHandler(this.btnByVal_Click);
            // 
            // btnByRef
            // 
            this.btnByRef.Location = new System.Drawing.Point(158, 227);
            this.btnByRef.Name = "btnByRef";
            this.btnByRef.Size = new System.Drawing.Size(68, 23);
            this.btnByRef.TabIndex = 3;
            this.btnByRef.Text = "By Ref";
            this.btnByRef.UseVisualStyleBackColor = true;
            this.btnByRef.Click += new System.EventHandler(this.btnByRef_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(232, 227);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(68, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmLoopsAndParms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 262);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnByRef);
            this.Controls.Add(this.btnByVal);
            this.Controls.Add(this.btnTriples);
            this.Controls.Add(this.txtOutput);
            this.Name = "frmLoopsAndParms";
            this.Text = "Loops and Passing Parameters";
            this.Load += new System.EventHandler(this.frmLoopsAndParms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnTriples;
        private System.Windows.Forms.Button btnByVal;
        private System.Windows.Forms.Button btnByRef;
        private System.Windows.Forms.Button btnExit;
    }
}

