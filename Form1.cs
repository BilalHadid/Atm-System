
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



namespace atmsystem
{
	public partial class Login_frm
	{
		public Login_frm()
		{
			InitializeComponent();

		}
		
#region Default Instance
		
		private static Login_frm defaultInstance;
		

		public static Login_frm Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new Login_frm();
					defaultInstance.FormClosed += new FormClosedEventHandler(defaultInstance_FormClosed);
				}
				
				return defaultInstance;
			}
		}
		
		static void defaultInstance_FormClosed(object sender, FormClosedEventArgs e)
		{
			defaultInstance = null;
		}
		
#endregion
		System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand();
		System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter();
		DataSet ds = new DataSet();
		System.Data.OleDb.OleDbConnection con = new System.Data.OleDb.OleDbConnection();
		public void btnlogin_Click(System.Object sender, System.EventArgs e)
		{
			string sql = default(string);
			DataTable Log_in = new DataTable();
			try
			{
				if (txtpin.Text == "")
				{
					MessageBox.Show("Pls Enter both Fields");
					
				}
				else
				{
					con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\ATMsystem.accdb";
					sql = "SELECT * FROM tblinfo where pin_code = " + txtpin.Text + "";
					
					cmd.Connection = con;
					cmd.CommandText = sql;
					da.SelectCommand = cmd;
					da.Fill(Log_in);
					if (Log_in.Rows.Count > 0)
					{
						string Type;
						string Fullname = default(string);
						string accno = default(string);
						Type = (string) (Log_in.Rows[0]["type"]);
						Fullname = (string) (Log_in.Rows[0]["Firstname"]);
						accno =  Convert.ToString((Log_in.Rows[0]["account_no"]));
						if (Type == "admin")
						{
							MessageBox.Show("Welcome " + Fullname + " you login as Administrator ");
							AdminForm.Default.Show();
							this.Hide();
							
						}
						else if (Type == "Block")
						{
							MessageBox.Show("Your account is currently Block");
							MessageBox.Show("Contact the Administrator for Help");
							
						}
						else
						{
							MessageBox.Show("Welcome " + Fullname);
							
							Mainmenu.Default.lblname.Text = Fullname;
							Mainmenu.Default.lblaccno.Text = accno;
							Mainmenu.Default.Show();
							this.Hide();
							
						}
						
					}
					else
					{
						MessageBox.Show("Yuo are Not Registered!!!");
						MessageBox.Show("Pls Register if You are New!");
						
						
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
			txtpin.Text = "";
			
			
		}
		
		public void llblreg_LinkClicked(System.Object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			Regs_frm.Default.Show();
			
			
		}
		
		public void Login_frm_Load(System.Object sender, System.EventArgs e)
		{
			
		}
		
		public void GroupBox1_Enter(System.Object sender, System.EventArgs e)
		{
			
		}
	}
	
}
