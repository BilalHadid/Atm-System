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
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class transreceipt : System.Windows.Forms.Form
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
            this.lblname = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.lblnewbal = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.lbldep = new System.Windows.Forms.Label();
            this.lblwith = new System.Windows.Forms.Label();
            this.lblbal = new System.Windows.Forms.Label();
            this.lblaccno = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(93, 57);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(57, 18);
            this.lblname.TabIndex = 29;
            this.lblname.Text = "Name:";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(17, 57);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(57, 18);
            this.Label7.TabIndex = 28;
            this.Label7.Text = "Name:";
            // 
            // lblnewbal
            // 
            this.lblnewbal.AutoSize = true;
            this.lblnewbal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnewbal.Location = new System.Drawing.Point(213, 279);
            this.lblnewbal.Name = "lblnewbal";
            this.lblnewbal.Size = new System.Drawing.Size(0, 18);
            this.lblnewbal.TabIndex = 27;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(17, 279);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(174, 18);
            this.Label6.TabIndex = 26;
            this.Label6.Text = "New account balance:";
            // 
            // lbldep
            // 
            this.lbldep.AutoSize = true;
            this.lbldep.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldep.Location = new System.Drawing.Point(213, 197);
            this.lbldep.Name = "lbldep";
            this.lbldep.Size = new System.Drawing.Size(100, 18);
            this.lbldep.TabIndex = 25;
            this.lbldep.Text = "Amount Dep";
            // 
            // lblwith
            // 
            this.lblwith.AutoSize = true;
            this.lblwith.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwith.Location = new System.Drawing.Point(213, 160);
            this.lblwith.Name = "lblwith";
            this.lblwith.Size = new System.Drawing.Size(104, 18);
            this.lblwith.TabIndex = 24;
            this.lblwith.Text = "Amount With";
            // 
            // lblbal
            // 
            this.lblbal.AutoSize = true;
            this.lblbal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbal.Location = new System.Drawing.Point(213, 128);
            this.lblbal.Name = "lblbal";
            this.lblbal.Size = new System.Drawing.Size(73, 18);
            this.lblbal.TabIndex = 23;
            this.lblbal.Text = "Balance:";
            // 
            // lblaccno
            // 
            this.lblaccno.AutoSize = true;
            this.lblaccno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaccno.Location = new System.Drawing.Point(213, 94);
            this.lblaccno.Name = "lblaccno";
            this.lblaccno.Size = new System.Drawing.Size(101, 18);
            this.lblaccno.TabIndex = 22;
            this.lblaccno.Text = "Accoun No.:";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(172, 27);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(41, 15);
            this.lbldate.TabIndex = 21;
            this.lbldate.Text = "Date:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(125, 27);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(41, 15);
            this.Label5.TabIndex = 20;
            this.Label5.Text = "Date:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(17, 197);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(133, 18);
            this.Label4.TabIndex = 19;
            this.Label4.Text = "Amount Deposit:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(17, 160);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(145, 18);
            this.Label3.TabIndex = 18;
            this.Label3.Text = "Amount Withdraw:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(17, 128);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(73, 18);
            this.Label2.TabIndex = 17;
            this.Label2.Text = "Balance:";
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(128, 312);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(88, 47);
            this.Button1.TabIndex = 16;
            this.Button1.Text = "Ok";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(17, 94);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(101, 18);
            this.Label1.TabIndex = 15;
            this.Label1.Text = "Accoun No.:";
            // 
            // transreceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(361, 388);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.lblnewbal);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.lbldep);
            this.Controls.Add(this.lblwith);
            this.Controls.Add(this.lblbal);
            this.Controls.Add(this.lblaccno);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Label1);
            this.Name = "transreceipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "transreceipt";
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.Label lblname;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.Label lblnewbal;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.Label lbldep;
		internal System.Windows.Forms.Label lblwith;
		internal System.Windows.Forms.Label lblbal;
		internal System.Windows.Forms.Label lblaccno;
		internal System.Windows.Forms.Label lbldate;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Label Label1;
	}
	
}
