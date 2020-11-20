namespace DACB
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
            this.btnChuyen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.btnXN = new System.Windows.Forms.Button();
            this.grbMP = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSoBuoc = new System.Windows.Forms.Label();
            this.lbStep = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChuyen
            // 
            this.btnChuyen.Location = new System.Drawing.Point(364, 12);
            this.btnChuyen.Name = "btnChuyen";
            this.btnChuyen.Size = new System.Drawing.Size(75, 23);
            this.btnChuyen.TabIndex = 3;
            this.btnChuyen.Text = "Mô hỏng";
            this.btnChuyen.UseVisualStyleBackColor = true;
            this.btnChuyen.Click += new System.EventHandler(this.btnChuyen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhap so bi :";
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(104, 14);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(112, 20);
            this.txtNhap.TabIndex = 5;
            // 
            // btnXN
            // 
            this.btnXN.Location = new System.Drawing.Point(248, 13);
            this.btnXN.Name = "btnXN";
            this.btnXN.Size = new System.Drawing.Size(75, 23);
            this.btnXN.TabIndex = 6;
            this.btnXN.Text = "Xác nhận";
            this.btnXN.UseVisualStyleBackColor = true;
            this.btnXN.Click += new System.EventHandler(this.btnXN_Click);
            // 
            // grbMP
            // 
            this.grbMP.Location = new System.Drawing.Point(15, 65);
            this.grbMP.Name = "grbMP";
            this.grbMP.Size = new System.Drawing.Size(672, 181);
            this.grbMP.TabIndex = 7;
            this.grbMP.TabStop = false;
            this.grbMP.Text = "Mô phỏng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(470, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Số Bước : ";
            // 
            // lbSoBuoc
            // 
            this.lbSoBuoc.AutoSize = true;
            this.lbSoBuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSoBuoc.Location = new System.Drawing.Point(573, 23);
            this.lbSoBuoc.Name = "lbSoBuoc";
            this.lbSoBuoc.Size = new System.Drawing.Size(0, 24);
            this.lbSoBuoc.TabIndex = 9;
            // 
            // lbStep
            // 
            this.lbStep.AutoSize = true;
            this.lbStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbStep.Location = new System.Drawing.Point(573, 23);
            this.lbStep.Name = "lbStep";
            this.lbStep.Size = new System.Drawing.Size(0, 25);
            this.lbStep.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 262);
            this.Controls.Add(this.lbStep);
            this.Controls.Add(this.lbSoBuoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grbMP);
            this.Controls.Add(this.btnXN);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChuyen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChuyen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Button btnXN;
        private System.Windows.Forms.GroupBox grbMP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbSoBuoc;
        private System.Windows.Forms.Label lbStep;
    }
}

