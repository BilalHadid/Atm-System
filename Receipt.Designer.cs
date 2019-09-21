// VBConversions Note: VB project level imports
using System.Diagnostics;
using System;
using System.Xml.Linq;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Data;
using System.Collections.Generic;
using System.Linq;
// End of VB project level imports


namespace atmsystem
{
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class Receipt : System.Windows.Forms.Form
	{
		
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}
		
		//Required by the Windows Form Designer
		private System.ComponentModel.Container components = null;
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            this.Button1 = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.lbldep = new System.Windows.Forms.Label();
            this.lblwith = new System.Windows.Forms.Label();
            this.lblbal = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.lblnewbal = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.Silver;
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(120, 207);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(88, 47);
            this.Button1.TabIndex = 1;
            this.Button1.Text = "Ok";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(12, 69);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(73, 18);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Balance:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(12, 101);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(145, 18);
            this.Label3.TabIndex = 3;
            this.Label3.Text = "Amount Withdraw:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(12, 138);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(133, 18);
            this.Label4.TabIndex = 4;
            this.Label4.Text = "Amount Deposit:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(120, 9);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(41, 15);
            this.Label5.TabIndex = 5;
            this.Label5.Text = "Date:";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(167, 9);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(41, 15);
            this.lbldate.TabIndex = 6;
            this.lbldate.Text = "Date:";
            // 
            // lbldep
            // 
            this.lbldep.AutoSize = true;
            this.lbldep.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldep.Location = new System.Drawing.Point(208, 138);
            this.lbldep.Name = "lbldep";
            this.lbldep.Size = new System.Drawing.Size(100, 18);
            this.lbldep.TabIndex = 10;
            this.lbldep.Text = "Amount Dep";
            // 
            // lblwith
            // 
            this.lblwith.AutoSize = true;
            this.lblwith.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwith.Location = new System.Drawing.Point(208, 101);
            this.lblwith.Name = "lblwith";
            this.lblwith.Size = new System.Drawing.Size(104, 18);
            this.lblwith.TabIndex = 9;
            this.lblwith.Text = "Amount With";
            // 
            // lblbal
            // 
            this.lblbal.AutoSize = true;
            this.lblbal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbal.Location = new System.Drawing.Point(208, 69);
            this.lblbal.Name = "lblbal";
            this.lblbal.Size = new System.Drawing.Size(73, 18);
            this.lblbal.TabIndex = 8;
            this.lblbal.Text = "Balance:";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(12, 170);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(174, 18);
            this.Label6.TabIndex = 11;
            this.Label6.Text = "New account balance:";
            // 
            // lblnewbal
            // 
            this.lblnewbal.AutoSize = true;
            this.lblnewbal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnewbal.Location = new System.Drawing.Point(208, 170);
            this.lblnewbal.Name = "lblnewbal";
            this.lblnewbal.Size = new System.Drawing.Size(0, 18);
            this.lblnewbal.TabIndex = 12;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(12, 39);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(57, 18);
            this.Label7.TabIndex = 13;
            this.Label7.Text = "Name:";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(88, 39);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(57, 18);
            this.lblname.TabIndex = 14;
            this.lblname.Text = "Name:";
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(328, 303);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.lblnewbal);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.lbldep);
            this.Controls.Add(this.lblwith);
            this.Controls.Add(this.lblbal);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Button1);
            this.Name = "Receipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receipt";
            this.Load += new System.EventHandler(this.Receipt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label lbldate;
		internal System.Windows.Forms.Label lbldep;
		internal System.Windows.Forms.Label lblwith;
		internal System.Windows.Forms.Label lblbal;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.Label lblnewbal;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.Label lblname;
	}
	
}
