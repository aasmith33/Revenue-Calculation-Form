
namespace AbigailSmith_CPT_185_Chapter_3
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtClassC = new System.Windows.Forms.TextBox();
            this.lblClassC = new System.Windows.Forms.Label();
            this.txtClassB = new System.Windows.Forms.TextBox();
            this.lblClassB = new System.Windows.Forms.Label();
            this.txtClassA = new System.Windows.Forms.TextBox();
            this.lblClassA = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtRevC = new System.Windows.Forms.TextBox();
            this.lblRevC = new System.Windows.Forms.Label();
            this.txtRevB = new System.Windows.Forms.TextBox();
            this.lblRevB = new System.Windows.Forms.Label();
            this.txtRevA = new System.Windows.Forms.TextBox();
            this.lblRevA = new System.Windows.Forms.Label();
            this.btnCalcRev = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtClassC);
            this.groupBox1.Controls.Add(this.lblClassC);
            this.groupBox1.Controls.Add(this.txtClassB);
            this.groupBox1.Controls.Add(this.lblClassB);
            this.groupBox1.Controls.Add(this.txtClassA);
            this.groupBox1.Controls.Add(this.lblClassA);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 205);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tickets Sold";
            // 
            // txtClassC
            // 
            this.txtClassC.Location = new System.Drawing.Point(101, 151);
            this.txtClassC.Name = "txtClassC";
            this.txtClassC.Size = new System.Drawing.Size(133, 27);
            this.txtClassC.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtClassC, "Enter number of class C tickets sold");
            // 
            // lblClassC
            // 
            this.lblClassC.AutoSize = true;
            this.lblClassC.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassC.Location = new System.Drawing.Point(22, 159);
            this.lblClassC.Name = "lblClassC";
            this.lblClassC.Size = new System.Drawing.Size(71, 19);
            this.lblClassC.TabIndex = 4;
            this.lblClassC.Text = "Class C:";
            // 
            // txtClassB
            // 
            this.txtClassB.Location = new System.Drawing.Point(101, 113);
            this.txtClassB.Name = "txtClassB";
            this.txtClassB.Size = new System.Drawing.Size(133, 27);
            this.txtClassB.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtClassB, "Enter number of class B tickets sold");
            // 
            // lblClassB
            // 
            this.lblClassB.AutoSize = true;
            this.lblClassB.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassB.Location = new System.Drawing.Point(22, 121);
            this.lblClassB.Name = "lblClassB";
            this.lblClassB.Size = new System.Drawing.Size(71, 19);
            this.lblClassB.TabIndex = 5;
            this.lblClassB.Text = "Class B:";
            // 
            // txtClassA
            // 
            this.txtClassA.Location = new System.Drawing.Point(101, 75);
            this.txtClassA.Name = "txtClassA";
            this.txtClassA.Size = new System.Drawing.Size(133, 27);
            this.txtClassA.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtClassA, "Enter number of class A tickets sold");
            // 
            // lblClassA
            // 
            this.lblClassA.AutoSize = true;
            this.lblClassA.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassA.Location = new System.Drawing.Point(24, 83);
            this.lblClassA.Name = "lblClassA";
            this.lblClassA.Size = new System.Drawing.Size(69, 19);
            this.lblClassA.TabIndex = 4;
            this.lblClassA.Text = "Class A:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 49);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter the number of tickets sold for each class of seats.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Controls.Add(this.txtRevC);
            this.groupBox2.Controls.Add(this.lblRevC);
            this.groupBox2.Controls.Add(this.txtRevB);
            this.groupBox2.Controls.Add(this.lblRevB);
            this.groupBox2.Controls.Add(this.txtRevA);
            this.groupBox2.Controls.Add(this.lblRevA);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(371, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 205);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Revenue Generated";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(102, 151);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(135, 27);
            this.txtTotal.TabIndex = 16;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(44, 157);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(52, 19);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "Total:";
            // 
            // txtRevC
            // 
            this.txtRevC.Enabled = false;
            this.txtRevC.Location = new System.Drawing.Point(102, 111);
            this.txtRevC.Name = "txtRevC";
            this.txtRevC.Size = new System.Drawing.Size(135, 27);
            this.txtRevC.TabIndex = 12;
            // 
            // lblRevC
            // 
            this.lblRevC.AutoSize = true;
            this.lblRevC.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevC.Location = new System.Drawing.Point(25, 116);
            this.lblRevC.Name = "lblRevC";
            this.lblRevC.Size = new System.Drawing.Size(71, 19);
            this.lblRevC.TabIndex = 11;
            this.lblRevC.Text = "Class C:";
            // 
            // txtRevB
            // 
            this.txtRevB.Enabled = false;
            this.txtRevB.Location = new System.Drawing.Point(102, 71);
            this.txtRevB.Name = "txtRevB";
            this.txtRevB.Size = new System.Drawing.Size(135, 27);
            this.txtRevB.TabIndex = 10;
            // 
            // lblRevB
            // 
            this.lblRevB.AutoSize = true;
            this.lblRevB.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevB.Location = new System.Drawing.Point(25, 75);
            this.lblRevB.Name = "lblRevB";
            this.lblRevB.Size = new System.Drawing.Size(71, 19);
            this.lblRevB.TabIndex = 9;
            this.lblRevB.Text = "Class B:";
            // 
            // txtRevA
            // 
            this.txtRevA.Enabled = false;
            this.txtRevA.Location = new System.Drawing.Point(102, 31);
            this.txtRevA.Name = "txtRevA";
            this.txtRevA.Size = new System.Drawing.Size(135, 27);
            this.txtRevA.TabIndex = 20;
            // 
            // lblRevA
            // 
            this.lblRevA.AutoSize = true;
            this.lblRevA.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevA.Location = new System.Drawing.Point(27, 34);
            this.lblRevA.Name = "lblRevA";
            this.lblRevA.Size = new System.Drawing.Size(69, 19);
            this.lblRevA.TabIndex = 0;
            this.lblRevA.Text = "Class A:";
            // 
            // btnCalcRev
            // 
            this.btnCalcRev.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcRev.Location = new System.Drawing.Point(162, 300);
            this.btnCalcRev.Name = "btnCalcRev";
            this.btnCalcRev.Size = new System.Drawing.Size(110, 57);
            this.btnCalcRev.TabIndex = 30;
            this.btnCalcRev.Text = "Calculate Revenue";
            this.toolTip1.SetToolTip(this.btnCalcRev, "Click to calculate revenue");
            this.btnCalcRev.UseVisualStyleBackColor = true;
            this.btnCalcRev.Click += new System.EventHandler(this.btnCalcRev_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(278, 300);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 57);
            this.btnClear.TabIndex = 40;
            this.btnClear.Text = "Clear";
            this.toolTip1.SetToolTip(this.btnClear, "Click to clear form fields");
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(394, 300);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 57);
            this.btnExit.TabIndex = 50;
            this.btnExit.Text = "Exit";
            this.toolTip1.SetToolTip(this.btnExit, "Click to exit");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalcRev;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(672, 407);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalcRev);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stadium Seating ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtClassA;
        private System.Windows.Forms.Label lblClassA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClassC;
        private System.Windows.Forms.Label lblClassC;
        private System.Windows.Forms.TextBox txtClassB;
        private System.Windows.Forms.Label lblClassB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtRevC;
        private System.Windows.Forms.Label lblRevC;
        private System.Windows.Forms.TextBox txtRevB;
        private System.Windows.Forms.Label lblRevB;
        private System.Windows.Forms.TextBox txtRevA;
        private System.Windows.Forms.Label lblRevA;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCalcRev;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

