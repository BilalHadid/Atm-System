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
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class Mainmenu : System.Windows.Forms.Form
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Button2 = new System.Windows.Forms.Button();
            this.btndep = new System.Windows.Forms.Button();
            this.btnwith = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.lbldate = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblaccno = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Button2);
            this.GroupBox1.Controls.Add(this.btndep);
            this.GroupBox1.Controls.Add(this.btnwith);
            this.GroupBox1.Controls.Add(this.Button1);
            this.GroupBox1.ForeColor = System.Drawing.Color.White;
            this.GroupBox1.Location = new System.Drawing.Point(23, 125);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(402, 205);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Transaction";
            this.GroupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.Maroon;
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Location = new System.Drawing.Point(240, 129);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(133, 58);
            this.Button2.TabIndex = 12;
            this.Button2.Text = "Transfer";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btndep
            // 
            this.btndep.BackColor = System.Drawing.Color.Maroon;
            this.btndep.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndep.Location = new System.Drawing.Point(240, 30);
            this.btndep.Name = "btndep";
            this.btndep.Size = new System.Drawing.Size(133, 58);
            this.btndep.TabIndex = 2;
            this.btndep.Text = "Deposit";
            this.btndep.UseVisualStyleBackColor = false;
            this.btndep.Click += new System.EventHandler(this.btndep_Click);
            // 
            // btnwith
            // 
            this.btnwith.BackColor = System.Drawing.Color.Maroon;
            this.btnwith.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnwith.Location = new System.Drawing.Point(26, 129);
            this.btnwith.Name = "btnwith";
            this.btnwith.Size = new System.Drawing.Size(133, 58);
            this.btnwith.TabIndex = 1;
            this.btnwith.Text = "Withdraw";
            this.btnwith.UseVisualStyleBackColor = false;
            this.btnwith.Click += new System.EventHandler(this.btnwith_Click);
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.Maroon;
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(26, 30);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(133, 58);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "Balance Inq.";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.White;
            this.btnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Location = new System.Drawing.Point(263, 83);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(133, 27);
            this.btnlogout.TabIndex = 3;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.Button4_Click);
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.ForeColor = System.Drawing.Color.White;
            this.lbldate.Location = new System.Drawing.Point(270, 9);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(37, 15);
            this.lbldate.TabIndex = 7;
            this.lbldate.Text = "Date";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(20, 47);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(65, 20);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "Hello!! ";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(20, 86);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(112, 20);
            this.Label2.TabIndex = 9;
            this.Label2.Text = "Account No.:";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.White;
            this.lblname.Location = new System.Drawing.Point(83, 49);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(49, 18);
            this.lblname.TabIndex = 10;
            this.lblname.Text = "name";
            this.lblname.Click += new System.EventHandler(this.lblname_Click);
            // 
            // lblaccno
            // 
            this.lblaccno.AutoSize = true;
            this.lblaccno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaccno.ForeColor = System.Drawing.Color.White;
            this.lblaccno.Location = new System.Drawing.Point(132, 87);
            this.lblaccno.Name = "lblaccno";
            this.lblaccno.Size = new System.Drawing.Size(32, 18);
            this.lblaccno.TabIndex = 11;
            this.lblaccno.Text = "no.";
            this.lblaccno.Click += new System.EventHandler(this.Label4_Click);
            // 
            // Mainmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(437, 351);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.lblaccno);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.GroupBox1);
            this.Name = "Mainmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mainmenu";
            this.Load += new System.EventHandler(this.Mainmenu_Load);
            this.GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.Button btnlogout;
		internal System.Windows.Forms.Button btndep;
		internal System.Windows.Forms.Button btnwith;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Label lbldate;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label lblname;
		internal System.Windows.Forms.Label lblaccno;
		internal System.Windows.Forms.Button Button2;
	}
	
}
