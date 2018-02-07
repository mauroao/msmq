namespace MsmqProject
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
            this.txtLabelSend = new System.Windows.Forms.TextBox();
            this.txtBodySend = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnReceive = new System.Windows.Forms.Button();
            this.txtBodyReceive = new System.Windows.Forms.TextBox();
            this.txtLabelReceive = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtLabelSend
            // 
            this.txtLabelSend.Location = new System.Drawing.Point(41, 38);
            this.txtLabelSend.Name = "txtLabelSend";
            this.txtLabelSend.Size = new System.Drawing.Size(339, 20);
            this.txtLabelSend.TabIndex = 0;
            // 
            // txtBodySend
            // 
            this.txtBodySend.Location = new System.Drawing.Point(41, 76);
            this.txtBodySend.Name = "txtBodySend";
            this.txtBodySend.Size = new System.Drawing.Size(339, 20);
            this.txtBodySend.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.SystemColors.Control;
            this.btnSend.Location = new System.Drawing.Point(305, 114);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnReceive
            // 
            this.btnReceive.Location = new System.Drawing.Point(305, 260);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(75, 23);
            this.btnReceive.TabIndex = 5;
            this.btnReceive.Text = "Receive";
            this.btnReceive.UseVisualStyleBackColor = true;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // txtBodyReceive
            // 
            this.txtBodyReceive.Location = new System.Drawing.Point(41, 222);
            this.txtBodyReceive.Name = "txtBodyReceive";
            this.txtBodyReceive.Size = new System.Drawing.Size(339, 20);
            this.txtBodyReceive.TabIndex = 4;
            // 
            // txtLabelReceive
            // 
            this.txtLabelReceive.Location = new System.Drawing.Point(41, 184);
            this.txtLabelReceive.Name = "txtLabelReceive";
            this.txtLabelReceive.Size = new System.Drawing.Size(339, 20);
            this.txtLabelReceive.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 312);
            this.Controls.Add(this.btnReceive);
            this.Controls.Add(this.txtBodyReceive);
            this.Controls.Add(this.txtLabelReceive);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtBodySend);
            this.Controls.Add(this.txtLabelSend);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLabelSend;
        private System.Windows.Forms.TextBox txtBodySend;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.TextBox txtBodyReceive;
        private System.Windows.Forms.TextBox txtLabelReceive;
    }
}

