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
using iTextSharp.text.pdf.parser;
using iTextSharp.text.pdf;
using System.IO;
using System.Windows.Forms;

namespace rsa_rc5
{
	/// <summary>
	/// Description of enkripsi.
	/// </summary>
	public partial class enkripsi : Form
	{
		static int w = 32;//inisial w
		static int round = 12;//inisial round 
	    static int b_kecil = 16; //inisial b_kecil
	    BigInteger Pw = hextodec("B7E15163");//inisial Pw
		BigInteger Qw = hextodec("9E3779B9");//inisial Qw 
		static int u = w / 8;//inisial u
	    static int c = b_kecil / u;//inisial c
	    static int t = (2 * round) + 2;//inisial t
	    BigInteger[] S = new BigInteger[t];//inisial S
	    BigInteger[] L = new BigInteger[c];//inisial L
		Stopwatch watch = new Stopwatch();
		public string metode;
		string kunci;
		int[] chiperkey;
		int n,ee;
        OpenFileDialog dialogg;
        public enkripsi()
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
		
		void Button4Click(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog open = new OpenFileDialog();//inisial variabel penyimpan file
				open.Filter = "public key( *.public)|*.public";//inisial ekstensi file yang akan disimpan
				if (open.ShowDialog() == DialogResult.OK)
				{
					string[] lines = File.ReadAllLines(open.FileName);
					textBox5.Text = lines[0];//textbox5 mengambil line pertama
					textBox8.Text = lines[1];//textbox8 mengambil line kedua
				}
			}
				catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		
		void Button6Click(object sender, EventArgs e)
		{
				SaveFileDialog simpan = new SaveFileDialog();//inisial variabel penyimpan file
				simpan.Filter = "RC5 file( *.rc5)|*.rc5";//inisial ekstensi file yang akan disimpan
				simpan.FileName = "*.rc5";
				if (simpan.ShowDialog() == DialogResult.OK)
				{
					FileStream fstream=new FileStream(simpan.FileName,FileMode.OpenOrCreate);
					StreamWriter sw = new StreamWriter(fstream);
					SeekOrigin seekorigin = new SeekOrigin();
					sw.BaseStream.Seek(0, seekorigin);
					sw.Write(textBox7.Text);
					sw.Flush();
					sw.Close();
				}			
		}
		
		void Button10Click(object sender, EventArgs e)
		{
				SaveFileDialog simpan = new SaveFileDialog();//inisial variabel penyimpan file
				simpan.Filter = "RSA file( *.rsa)|*.rsa";//inisial ekstensi file yang akan disimpan
				simpan.FileName = "*.rsa";
				if (simpan.ShowDialog() == DialogResult.OK)
				{
					FileStream fstream=new FileStream(simpan.FileName,FileMode.OpenOrCreate);
					StreamWriter sw = new StreamWriter(fstream);
					SeekOrigin seekorigin = new SeekOrigin();
					sw.BaseStream.Seek(0, seekorigin);
					sw.Write(richTextBox5.Text);
					sw.Flush();
					sw.Close();
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
			watch.Restart();//mengulang timer waktu
			kunci = textBox4.Text.ToString();
			chiperkey = new int[kunci.Length];
			n = Convert.ToInt32(textBox8.Text);
			ee = Convert.ToInt32(textBox5.Text);
			for (int i = 0; i < kunci.Length; i++)
			{
				chiperkey[i] = modexp(kunci[i],ee,n);
				textBox7.Text += chiperkey[i].ToString() + " ";
			}
			watch.Stop();
			textBox6.Text = Math.Round(Convert.ToDecimal(watch.Elapsed.TotalMilliseconds),4).ToString();//menampilkan running time milisecond
		}
		
		void Button11Click(object sender, EventArgs e)
		{
			//init
			textBox4.Text = textBox13.Text;
			watch.Restart();
			S = new BigInteger[t];
	    	L = new BigInteger[c];
			string plaintext = stringtohex(richTextBox6.Text) ;// konversi input richTextBox6.Text ke hexadesimal
			string pass = stringtohex(textBox13.Text) ;// konversi input textBox13.Text ke hexadesimal
			int x ;
 
			//padding
			if (pass.Length % 32 != 0)
			{
				int sisa = 32 - pass.Length;
				for (x = 0; x < sisa; x++)
					pass = pass + "0";
            }
			
			if (plaintext.Length < 16)
			{
				int sisa = 16 - plaintext.Length ;
				for (x = 0 ; x < sisa; x++)
					plaintext = plaintext + "0" ;
            }
			
			else
			{
				if ((plaintext.Length % 8) != 0)
            	{
            		int sisa = 8 - (plaintext.Length % 8);
            		for( x = 0; x <= sisa - 1; x++)
            			plaintext = plaintext + "0";
	            }
			}
 			
			//array S
			S[0] = Pw;
            for(int i = 1; i < t; i++)
				S[i] = (S[i-1] + Qw) & 4294967295;
			
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
						
			//enkripsi
			string ciphertext = "";
			A = (hextodec(plaintext.Substring(0, 8)) + S[0]) & 4294967295;//menghitung hexa ke desimal dan di simpan di A
			B = (hextodec(plaintext.Substring(8, 8)) + S[1]) & 4294967295;//menghitung hexa ke desimal dan di simpan di B
			for(int i = 1; i <= round; i++) 
			{
				A = (rotasikiri((long)(A ^ B), (int)(B % 32), 32) + S[2 * i]) & 4294967295;
				B = (rotasikiri((long)(B ^ A), (int)(A % 32), 32) + S[(2 * i) + 1]) & 4294967295;
			}
			ciphertext += dectohex((long)A);
			
			// jika lebih dari 32 bit 
			if(plaintext.Length > 16) 
			{
			    for (int y = 1; y <= ((plaintext.Length / 8) -2); y++)
			    {
					A = (B + S[0]) & 4294967295;
					B = (hextodec(plaintext.Substring(16 + (8 * (y  -  1)),8)) + S[1]) & 4294967295;
			        for (int i = 1; i <= round; i++)
			        {
						A = (rotasikiri((long)(A ^ B), (int)(B % 32), 32) + S[2 * i]) & 4294967295;
			    		B = (rotasikiri((long)(B ^ A), (int)(A % 32), 32) + S[2 * i+ 1]) & 4294967295;
			        }
			        ciphertext += dectohex((long)A);
			    }
			}
			ciphertext += dectohex((long)B);
			richTextBox5.Text = ciphertext;
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
	    public static  String desimal2biner(long input, int bit) //fungsi konversi desimal ke biner
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
	    
	    //fungsi biner ke desimal
	    public static  int biner2desimal(string input, int bit) {
	        return Convert.ToInt16(input, 2);
	    }
	    
	    //fungsi rotasi kiri
	    public static  long rotasikiri(long input, int count, int bit) {
	        string biner = desimal2biner(input, bit);
	        string binerrotasikiri = (biner.Substring(count, (biner.Length - count)) + biner.Substring(0, count));
			return (long)Convert.ToUInt64(binerrotasikiri, 2);
	    }
	    
	    //fungsi rotasi kanan
	    public static  long rotasikanan(long input, int count, int bit) {
	        string biner = desimal2biner(input, bit);
	        string binerrotasikanan = (biner.Substring((biner.Length - count), count) + biner.Substring(0, (biner.Length - count)));
			return (long)Convert.ToUInt64(binerrotasikanan, 2);
	    }
	    
	    //fungsi dec ke hexa
	    public static  String dectohex(long dec) {
	        string sHexValue = String.Format("{0:X}", dec);
	        if (sHexValue.Length < 8)
	        {
	            for (int i = 0; i < 8 - sHexValue.Length; i++)
	                sHexValue = ("0" + sHexValue);
	        }
	        return sHexValue;
	    }
	    
	    //fungsi hexa ke desimal
	    public static  BigInteger hextodec(string hex) {
	    	long hexx = Convert.ToInt64(hex, 16);
	    	string hes = Convert.ToString(hexx);
	    	return BigInteger.Parse(hes);
	    }

        //fungsi hexa ke string
		public static  String hextostring(string hex) {
        	StringBuilder sb = new StringBuilder();
        		for (int x = 0; x < hex.Length; x = x+2) 
        		{
        			string k = hex.Substring(x, 2);
	            	sb.Append(System.Convert.ToChar(System.Convert.ToUInt32(k, 16)));
				}
        	return sb.ToString();
		}
        
		//fungsi string ke hexa
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
		
		
		public static  BigInteger index2x(BigInteger index, BigInteger width){
			return (index % width);
		}
			
				
		public static  BigInteger index2y(BigInteger index, BigInteger width) {
	    	return (index - (index % width)) / width ;
		}
		
		//fungsi desimal ke biner
		public static  String dec_to_bin(int dec){
			string temp = Convert.ToString(dec, 2);
        	if (temp.Length < 8)
        	{
			 	while (temp.Length < 8)
			 		temp = "0" + temp;
			} 
		 	return temp;
    	}
		//fungsi untukmengambil tipe dokumen
        private void loadText()
        {
            if (tipe2 == "docx")
            {
                Microsoft.Office.Interop.Word.Application wordApp = new
                Microsoft.Office.Interop.Word.ApplicationClass();
                object filenameO = dialogg.FileName;
                object objFalse = false;
                object objTrue = true;
                object missing = System.Reflection.Missing.Value;
                object emptyData = string.Empty;


                Microsoft.Office.Interop.Word.Document aDoc = wordApp.Documents.Open(ref filenameO, ref objFalse, ref objTrue, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref objTrue, ref missing, ref missing, ref missing, ref missing);

                aDoc.ActiveWindow.Selection.WholeStory();
                aDoc.ActiveWindow.Selection.Copy();

                IDataObject data = System.Windows.Forms.Clipboard.GetDataObject();
                String fileText = data.GetData(System.Windows.Forms.DataFormats.Text).ToString();
                System.Windows.Forms.Clipboard.SetDataObject(string.Empty);

                richTextBox1.Text = fileText;

            }
            if (tipe == "doc")
            {
                Microsoft.Office.Interop.Word.Application wordApp = new
                Microsoft.Office.Interop.Word.ApplicationClass();
                object filenameO = dialogg.FileName;
                object objFalse = false;
                object objTrue = true;
                object missing = System.Reflection.Missing.Value;
                object emptyData = string.Empty;


                Microsoft.Office.Interop.Word.Document aDoc = wordApp.Documents.Open(ref filenameO, ref objFalse, ref objTrue, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref objTrue, ref missing, ref missing, ref missing, ref missing);

                aDoc.ActiveWindow.Selection.WholeStory();
                aDoc.ActiveWindow.Selection.Copy();

                IDataObject data = System.Windows.Forms.Clipboard.GetDataObject();
                String fileText = data.GetData(System.Windows.Forms.DataFormats.Text).ToString();
                System.Windows.Forms.Clipboard.SetDataObject(string.Empty);

                richTextBox1.Text = fileText;

            }
        }

        PdfReader baca;
		string tipe,tipe2;
		void Button12Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();//inisial variabel pembuka file
            dialog.Filter = "Document PDF|*.pdf|File Word|*.docx";//inisial ekstensi file yang akan dibuka
            dialog.Title = "Open File : ";
            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                tipe2 = dialog.FileName.Substring(dialog.FileName.Length - 4, 4);
                tipe = dialog.FileName.Substring(dialog.FileName.Length - 3, 3);
                if (tipe == "pdf") {
                    baca = new PdfReader(dialog.FileName);
                    textBox14.Text = dialog.FileName;
                    tipe = dialog.FileName.Substring(dialog.FileName.Length - 3, 3);
                    int intPageNum = baca.NumberOfPages;
                    string[] words;
                    string line, text;
                    string temp = "";
                    for (int i = 1; i <= intPageNum; i++)
                    {
                        text = PdfTextExtractor.GetTextFromPage(baca, i, new LocationTextExtractionStrategy());
                        words = text.Split('\n');
                        for (int j = 0, len = words.Length; j < len; j++)
                        {
                            line = Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(words[j]));
                            temp += line + Environment.NewLine;
                        }
                    }
                    richTextBox6.Text = temp;
                }
                else if (tipe2 == "docx")
                {
                    Microsoft.Office.Interop.Word.Application wordApp = new
                    Microsoft.Office.Interop.Word.ApplicationClass();
                    object filenameO = dialog.FileName;
                    object objFalse = false;
                    object objTrue = true;
                    object missing = System.Reflection.Missing.Value;
                    object emptyData = string.Empty;


                    Microsoft.Office.Interop.Word.Document aDoc = wordApp.Documents.Open(ref filenameO, ref objFalse, ref objTrue, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref objTrue, ref missing, ref missing, ref missing, ref missing);

                    aDoc.ActiveWindow.Selection.WholeStory();
                    aDoc.ActiveWindow.Selection.Copy();

                    IDataObject data = System.Windows.Forms.Clipboard.GetDataObject();
                    String fileText = data.GetData(System.Windows.Forms.DataFormats.Text).ToString();
                    System.Windows.Forms.Clipboard.SetDataObject(string.Empty);

                    richTextBox6.Text = fileText;
                }
                
            }
		}
	}
}
			