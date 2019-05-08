/*
 * Created by SharpDevelop.
 * User: user
 * Date: 19/09/2018
 * Time: 21:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace rsa_rc5
{
	/// <summary>
	/// Description of help.
	/// </summary>
	public partial class help : Form
	{
		public help()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void GENERATEKEYToolStripMenuItemClick(object sender, EventArgs e)
		{
			bangkitkunci fpindah = new bangkitkunci();
			this.Hide();
			fpindah.Show();
		}
		
		void HOMEToolStripMenuItemClick(object sender, EventArgs e)
		{
			MainForm fpindah = new MainForm();
			this.Hide();
			fpindah.Show();
		}
		
		void SENDERToolStripMenuItemClick(object sender, EventArgs e)
		{
			enkripsi fpindah = new enkripsi();
			this.Hide();
			fpindah.Show();
		}
		
		void RECIPIENTToolStripMenuItemClick(object sender, EventArgs e)
		{
			dekripsi fpindah = new dekripsi();
			this.Hide();
			fpindah.Show();
		}
	}
}
