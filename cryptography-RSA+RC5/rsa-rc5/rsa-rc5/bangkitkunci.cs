/*
 * Created by SharpDevelop.
 * User: user
 * Date: 19/09/2018
 * Time: 21:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace rsa_rc5
{
	/// <summary>
	/// Description of bangkitkunci.
	/// </summary>
	public partial class bangkitkunci : Form
	{
		int p,q,n,totien,dp,dq,d1,d2,d,ee;//deklarasi variabel
		List<int> d22 = new List<int>();//deklarasi variabel list int
		List<int> d11 = new List<int>();
		Random r = new Random();//inisialisasi r untuk class random
		public bangkitkunci()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public int agrawal(int n)
        {
			int z;
			z = r.Next(4,n-2);//inisial random dari 4 sampai n-2
			
			if( (Convert.ToInt32(modexp((1+z),n,n)) == ((1 + Convert.ToInt32(modexp(z,n,n))) % n)) &&  (n%2!=0 && n%5!=0))
				return n;
           	else         		
          		return agrawal(r.Next(101,200));//inisial rekursif random r
        }
		
		public int modexp(int x, int y, int n)//menghitung mod Eksponen 
		{
			int z = 1;//inisial variabel z = 1
    		for (int i = 0; i < y ; i++){
          	z = (x * z)  % n;
    		}
			return z;
		}
		
		public int modInverse(int a, int n)//fungsi modinverse
		{
			int i = n, v = 0, d = 1;
		 	while (a>0) 
		 	{
				int t = i/a, x = a;
				a = i % x;
				i = x;
				x = d;
				d = v - t*x;
				v = x;
			}
			v %= n;
			if (v<0)
				v = (v+n)%n;
			return v;
		}
		
		
		public int GCD(int a, int b)//inisial fungsi GCD utk menghitung FPB
    	{
        	int Remainder;
            while( b != 0 )
        	{
            	Remainder = a % b;
            	a = b;
            	b = Remainder;
        	}
            return a;
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
		
		void HELPToolStripMenuItemClick(object sender, EventArgs e)
		{
			help fpindah = new help();
			this.Hide();
			fpindah.Show();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			textBox1.Text = null;
			tb_alpa.Text = null;
			tb_beta.Text = null;
			tb_d.Text = null;
			tb_prima.Text = null;
			p=0;q=0;n=0;totien=0;dp=0;dq=0;d1=0;d2=0;d=0;ee=0;
			d22 = new List<int>();
			d11 = new List<int>();
		}
		
		void Button_generateClick(object sender, EventArgs e)
		{
			p=0;q=0;n=0;totien=0;dp=0;dq=0;d1=0;d2=0;d=0;ee=0;
			d22 = new List<int>();
			d11 = new List<int>();
			cari :
			p = agrawal(r.Next(101,200));
			q = agrawal(r.Next(101,200));
			if (p != q)
			{
			tb_prima.Text = p.ToString();
			tb_alpa.Text = q.ToString();
			n = p*q;
			totien = (p-1)*(q-1);
			carid :
			dp = agrawal(r.Next(101,200));
			dq = agrawal(r.Next(101,200));
			if (GCD(dp,p) != 1 && GCD(dq,q) != 1)
				goto carid;
			d1 = dp % (p-1);
			d2 = dq % (q-1);
			for (int i = d1; i <= n;) 
			{
				d11.Add(i);
				i+=(p-1);
			}
			for (int i = d2; i <= n;) 
			{
				d22.Add(i);
				i+=(q-1);
			}
			for (int i = d11.Count-1; i >= 0; i--)
			{
				for (int j = d22.Count-1; j >= 0; j--)
				{
					if (d11[i] == d22[j]) 
					{
						d = d11[i];
						break;
					}
				}
			}
			ee = modInverse(d,totien);
			if (d == 0 || ee == 0)
				goto carid;
			tb_d.Text = n.ToString();
			tb_beta.Text = ee.ToString();
			textBox1.Text = d.ToString();
			}
			else
			{
				goto cari;
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			SaveFileDialog simpan = new SaveFileDialog();//inisial variabel penyimpan file
			simpan.Filter = "Public Key( *.public)|*.public";//inisial ekstensi file yang akan disimpan
			simpan.FileName = "*.public";
			if (simpan.ShowDialog() == DialogResult.OK)
			{
				FileStream fstream=new FileStream(simpan.FileName,FileMode.Create);
				StreamWriter sw = new StreamWriter(fstream);
				SeekOrigin seekorigin = new SeekOrigin();
				sw.BaseStream.Seek(0, seekorigin);
				sw.WriteLine(tb_beta.Text);
				sw.WriteLine(tb_d.Text);
				sw.Flush();
				sw.Close();
			}
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			SaveFileDialog simpan = new SaveFileDialog();//inisial variabel penyimpan file
			simpan.Filter = "Private Key( *.private)|*.private";//inisial ekstensi file yang akan disimpan
			simpan.FileName = "*.private";
			if (simpan.ShowDialog() == DialogResult.OK)
			{
				FileStream fstream=new FileStream(simpan.FileName,FileMode.Create);
				StreamWriter sw = new StreamWriter(fstream);
				SeekOrigin seekorigin = new SeekOrigin();
				sw.BaseStream.Seek(0, seekorigin);
				sw.WriteLine(textBox1.Text);
				sw.WriteLine(tb_d.Text);
				sw.Flush();
				sw.Close();
			}
		}
	}
}
