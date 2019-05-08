/*
 * Created by SharpDevelop.
 * User: user
 * Date: 19/09/2018
 * Time: 21:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Numerics;
using System.Text;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace rsa_rc5
{
	/// <summary>
	/// Description of dekripsi.
	/// </summary>
	public partial class dekripsi : Form
	{
		static int w = 32;
		static int round = 12; 
	    static int b_kecil = 16; 
	    BigInteger Pw = hextodec("B7E15163");
		BigInteger Qw = hextodec("9E3779B9"); 
		static int u = w / 8;
	    static int c = b_kecil / u;
	    static int t = (2 * round) + 2;
	    BigInteger[] S = new BigInteger[t];
	    BigInteger[] L = new BigInteger[c];
		Stopwatch watch = new Stopwatch();
		string[] chipkuncis;
		char[] kunci;
		int[] chipkuncid;
		int n,d;
		public dekripsi()
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
		
		void HELPToolStripMenuItemClick(object sender, EventArgs e)
		{
			help fpindah = new help();
			this.Hide();
			fpindah.Show();
		}
		
		void Button12Click(object sender, EventArgs e)
		{
			string tipe;
			OpenFileDialog dialog;
			dialog = new OpenFileDialog();//inisial variabel penyimpan file
            dialog.Filter = "File RSA|*.rsa";//inisial ekstensi file yang akan dibuka
            dialog.Title = "Open File : ";
            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
            	textBox14.Text = Path.GetFullPath(dialog.FileName);
                tipe = dialog.FileName.Substring(dialog.FileName.Length - 3, 3);
                if (tipe == "rsa")
                {
                	richTextBox6.Text = File.ReadAllText(dialog.FileName);
                }
            }
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			textBox1.Text = null;
			textBox4.Text = null;
			try
			{
				OpenFileDialog open = new OpenFileDialog();//inisial variabel pembuka file
				open.Filter = "RC5 file( *.rc5)|*.rc5";//inisial variabel pembuka file
				if (open.ShowDialog() == DialogResult.OK)
				{
						textBox1.Text = Path.GetFullPath(open.FileName);
						string nama = open.FileName.Substring(0, open.FileName.Length);
						FileStream fstream = new FileStream(nama, FileMode.Open,FileAccess.ReadWrite);
						StreamReader sreader = new StreamReader(fstream);
						sreader.BaseStream.Seek(0, SeekOrigin.Begin);
						textBox4.Text = sreader.ReadToEnd();
						sreader.Close();					
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			textBox5.Text = null;
			textBox8.Text = null;
			try
			{
				OpenFileDialog open = new OpenFileDialog();//inisial variabel pembuka file
				open.Filter = "private key( *.private)|*.private";//inisial variabel pembuka file
				if (open.ShowDialog() == DialogResult.OK)
				{
					string[] lines = File.ReadAllLines(open.FileName);
					textBox5.Text = lines[0];
					textBox8.Text = lines[1];
				}
			}
				catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		
		public int modexp(int x, int y, int n)
		{
			int z = 1;
    		for (int i = 0; i < y ; i++){
          	z = (x * z)  % n;
    		}
			return z;
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			textBox7.Text = null;
			watch.Restart();
			chipkuncis = textBox4.Text.Split(' ');
			chipkuncid = new int[chipkuncis.Length-1];
			kunci = new char[chipkuncis.Length-1];
			n = Convert.ToInt32(textBox8.Text);
			d = Convert.ToInt32(textBox5.Text);
			for (int i = 0; i < chipkuncis.Length-1; i++) 
			{
				chipkuncid[i] = Convert.ToInt32(chipkuncis[i]);
				kunci[i] = Convert.ToChar(modexp(chipkuncid[i],d,n)%256);
				textBox7.Text += kunci[i].ToString();
			}
			watch.Stop();
			textBox6.Text = Math.Round(Convert.ToDecimal(watch.Elapsed.TotalMilliseconds),4).ToString();
			textBox13.Text = textBox7.Text;
		}
		
		void Button11Click(object sender, EventArgs e)
		{
			watch.Restart();
			//init
			S = new BigInteger[t];
	    	L = new BigInteger[c];
			richTextBox5.Text = "";
			string ciphertext = richTextBox6.Text;
			string pass = stringtohex(textBox13.Text);
			int x;
			
			//array S
			S[0] = Pw;
            for(int i = 1; i < t; i++)
				S[i] = (S[i-1] + Qw) & 4294967295;
			
            //padding
            if (pass.Length % 32 != 0)
			{
				int sisa = 32 - pass.Length;
				for (x = 0; x < sisa; x++)
					pass = pass + "0";
            }
            
			//array L
		    for(int i = 0; i <= 3; i++) 
		    {
			    string backward = "";
			    for (int j = 0; j <= 3; j++)
			    	backward += pass.Substring((i * 8) + (6 - (j * 2)), 2);
			    L[i] = hextodec(backward);
			}
            
            //pencampuran S dan L
            int l = 0;
            int k = 0;
            BigInteger A = 0;
            BigInteger B = 0;
            for(int y = 1; y <= (3 * Math.Max(t, c)); y++) 
            {
            	S[k] = rotasikiri((long)((S[k] + A + B) & 4294967295), 3, 32);
            	A = S[k];
            	L[l] = rotasikiri((long)((L[l] + A + B) & 4294967295), (int)((A + B) % 32), 32);
			    B = L[l];
			    k = (k + 1) % t;
			    l = (l + 1) % c;
			}
            
			//dekripsi
			string plaintext = "";
			B = hextodec(ciphertext.Substring(ciphertext.Length - 8, 8));
			A = hextodec(ciphertext.Substring(ciphertext.Length - 16, 8));
			
			for (int i = round; i >= 1; i--)
			{
				B = rotasikanan((long)((B - S[(2 * i) + 1]) & 4294967295), (int)(A % 32), 32) ^ A;
				A = rotasikanan((long)((A - S[2 * i]) & 4294967295), (int)(B % 32), 32) ^ B;
			}
			B = (B - S[1]) & 4294967295;
			A = (A - S[0]) & 4294967295;
			plaintext += dectohex((long)B);
			
			// jika ciphertext > 16 
			if ((ciphertext.Length > 16)) 
			{
			    int z = 24;
			    for (int y = 1; y <= (ciphertext.Length / 8 - 2); y++)
			    {
			        B = A;
			        A = hextodec(ciphertext.Substring((ciphertext.Length - z), 8));
			        for (int i = round; i >= 1; i--)
			        {
			        	B = rotasikanan((long)((B - S[(2 * i) + 1]) & 4294967295), (int)(A % 32), 32) ^ A;
			    		A = rotasikanan((long)((A - S[2 * i]) & 4294967295), (int)(B % 32), 32) ^ B;
			        }
			        B = (B - S[1]) & 4294967295;
			 		A = (A - S[0]) & 4294967295;
			        z += 8;
			        plaintext = dectohex((long)B) + plaintext;
			    }
			}
			plaintext = dectohex((long)A) + plaintext;
			richTextBox5.Text += hextostring(plaintext);
			watch.Stop();
			textBox12.Text = Math.Round(Convert.ToDecimal(watch.Elapsed.TotalMilliseconds),4).ToString();
		}
		
		public static String bit_to_string(string a) 
		{
	        StringBuilder sb = new StringBuilder();
	        StringBuilder sb1 = new StringBuilder();
	        string temp = "";
	        for (int i = 0; i < a.Length; i++)
	        {
	        	sb.Append(a.Substring(i, 1));
	            if ((sb.ToString().Length == 8))
	            {
	            	temp += Bin_To_Dec(sb.ToString());
			    	sb.Clear();
				}
	        }
	        return temp;
	    }
	    
		//ok
	    public static String string_to_bit(string input) 
	    {
	        string Result = "";
	        foreach (char C in input)
	        {
	        	string s = Convert.ToString((int)(C), 2).PadLeft(8,'0');
	            Result += s;
	        }
	        return Result;
	    }
	    
	    //ok
	    public static  String desimal2biner(long input, int bit) 
	    {
	        string biner_1 = "";
	        long tempbits = (long)Math.Pow(2, (bit - 1));
	        long inputcopy = input;
	        for (int i = 0; i <= bit - 1; i++)
	        {
	            if (inputcopy >= tempbits)
	            {
	                inputcopy = (inputcopy - tempbits);
	                biner_1 += "1";
	            }
	            else
	            	biner_1 += "0";
	            if (tempbits > 1)
	            {
	                tempbits = (tempbits / 2);
	            }
	        }
	        
	        return biner_1;
	    }
	    
	    //ok
	    public static  int biner2desimal(string input, int bit) {
	        return Convert.ToInt16(input, 2);
	    }
	    
	    //ok
	    public static  long rotasikiri(long input, int count, int bit) {
	        string biner = desimal2biner(input, bit);
	        string binerrotasikiri = (biner.Substring(count, (biner.Length - count)) + biner.Substring(0, count));
			return (long)Convert.ToUInt64(binerrotasikiri, 2);
	    }
	    
	    //ok
	    public static  long rotasikanan(long input, int count, int bit) {
	        string biner = desimal2biner(input, bit);
	        string binerrotasikanan = (biner.Substring((biner.Length - count), count) + biner.Substring(0, (biner.Length - count)));
			return (long)Convert.ToUInt64(binerrotasikanan, 2);
	    }
	    
	    //ok
	    public static  String dectohex(long dec) {
	        string sHexValue = String.Format("{0:X}", dec);
	        if (sHexValue.Length < 8)
	        {
	            for (int i = 0; i < 8 - sHexValue.Length; i++)
	                sHexValue = ("0" + sHexValue);
	        }
	        return sHexValue;
	    }
	    
	    //ok
	    public static  BigInteger hextodec(string hex) {
	    	long hexx = Convert.ToInt64(hex, 16);
	    	string hes = Convert.ToString(hexx);
	    	return BigInteger.Parse(hes);
	    }

        //ok
		public static  String hextostring(string hex) {
        	StringBuilder sb = new StringBuilder();
        		for (int x = 0; x < hex.Length; x = x+2) 
        		{
        			string k = hex.Substring(x, 2);
	            	sb.Append(System.Convert.ToChar(System.Convert.ToUInt32(k, 16)));
				}
        	return sb.ToString();
		}
        
		//ok
        public static  String stringtohex(string input){
	    	string a = input;
			string temp = "" ;
			char temp2;
			StringBuilder sb = new StringBuilder();
	        string hex_string = "";
	        for (int x=0; x < a.Length; x++)
	        {
	        	temp = a.Substring(x, 1);
	        	temp2 = Convert.ToChar(temp);
	        	hex_string = String.Format("{0:X}", Convert.ToInt32(temp2));
	        	if (hex_string.Length < 2) 
	        		hex_string = "0" + hex_string;
	        	sb.Append(hex_string);
			}
	        return sb.ToString();
		}
		
	    //ok
		public static  String Bin_To_Dec(string Bin) {
	        // function to convert a binary Number to decimal
	        double dec = 0;
	        int length = Bin.Length;
	        double temp = 0;
	        int x = 0;
	        for (x = 0; x < length; x++) {
	            temp = double.Parse(Bin.Substring((length - 1), 1));
	            length = (length - 1);
	            if (temp != 0) {
	                dec = dec + (2 ^ x);
	            }
	        }
	        
	        return dec.ToString();
	    }
		
		//ok
		public static  BigInteger index2x(BigInteger index, BigInteger width){
			return (index % width);
		}
			
		//ok		
		public static  BigInteger index2y(BigInteger index, BigInteger width) {
	    	return (index - (index % width)) / width ;
		}
		
		//ok
		public static  String dec_to_bin(int dec){
			string temp = Convert.ToString(dec, 2);
        	if (temp.Length < 8)
        	{
			 	while (temp.Length < 8)
			 		temp = "0" + temp;
			} 
		 	return temp;
    	}
		void Button10Click(object sender, EventArgs e)
		{
			SaveFileDialog simpan = new SaveFileDialog();
            simpan.Filter = "Document (MsWord)|*.doc";
            simpan.FileName = "*.doc";
            if (simpan.ShowDialog() == DialogResult.OK)
            {
                //StreamWriter write = new StreamWriter(File.Create(simpan.FileName));

                //write.Write(tb_dekzig);
                //write.Dispose();
                //System.IO.File.WriteAllText(simpan.FileName, tb_dekzig.Text);

                File.WriteAllText(simpan.FileName, richTextBox5.Text.ToString());
            }
		}
	}
}
