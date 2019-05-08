/*
 * Created by SharpDevelop.
 * User: user
 * Date: 19/09/2018
 * Time: 21:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace rsa_rc5
{
	partial class dekripsi
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.hOMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gENERATEKEYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sENDERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rECIPIENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hELPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label24 = new System.Windows.Forms.Label();
			this.button12 = new System.Windows.Forms.Button();
			this.textBox14 = new System.Windows.Forms.TextBox();
			this.richTextBox6 = new System.Windows.Forms.RichTextBox();
			this.label23 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.richTextBox5 = new System.Windows.Forms.RichTextBox();
			this.label21 = new System.Windows.Forms.Label();
			this.textBox13 = new System.Windows.Forms.TextBox();
			this.button11 = new System.Windows.Forms.Button();
			this.label20 = new System.Windows.Forms.Label();
			this.textBox12 = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.button10 = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.button5 = new System.Windows.Forms.Button();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.hOMEToolStripMenuItem,
			this.gENERATEKEYToolStripMenuItem,
			this.sENDERToolStripMenuItem,
			this.rECIPIENTToolStripMenuItem,
			this.hELPToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(984, 24);
			this.menuStrip1.TabIndex = 37;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// hOMEToolStripMenuItem
			// 
			this.hOMEToolStripMenuItem.Name = "hOMEToolStripMenuItem";
			this.hOMEToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
			this.hOMEToolStripMenuItem.Text = "HOME";
			this.hOMEToolStripMenuItem.Click += new System.EventHandler(this.HOMEToolStripMenuItemClick);
			// 
			// gENERATEKEYToolStripMenuItem
			// 
			this.gENERATEKEYToolStripMenuItem.Name = "gENERATEKEYToolStripMenuItem";
			this.gENERATEKEYToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
			this.gENERATEKEYToolStripMenuItem.Text = "Bangkit Kunci";
			this.gENERATEKEYToolStripMenuItem.Click += new System.EventHandler(this.GENERATEKEYToolStripMenuItemClick);
			// 
			// sENDERToolStripMenuItem
			// 
			this.sENDERToolStripMenuItem.Name = "sENDERToolStripMenuItem";
			this.sENDERToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
			this.sENDERToolStripMenuItem.Text = "Enkripsi";
			this.sENDERToolStripMenuItem.Click += new System.EventHandler(this.SENDERToolStripMenuItemClick);
			// 
			// rECIPIENTToolStripMenuItem
			// 
			this.rECIPIENTToolStripMenuItem.Name = "rECIPIENTToolStripMenuItem";
			this.rECIPIENTToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.rECIPIENTToolStripMenuItem.Text = "Dekripsi";
			// 
			// hELPToolStripMenuItem
			// 
			this.hELPToolStripMenuItem.Name = "hELPToolStripMenuItem";
			this.hELPToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
			this.hELPToolStripMenuItem.Text = "HELP";
			this.hELPToolStripMenuItem.Click += new System.EventHandler(this.HELPToolStripMenuItemClick);
			// 
			// label24
			// 
			this.label24.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label24.Location = new System.Drawing.Point(16, 33);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(168, 23);
			this.label24.TabIndex = 0;
			this.label24.Text = "INPUT CIPHERTEXT";
			this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// button12
			// 
			this.button12.Location = new System.Drawing.Point(374, 31);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(98, 27);
			this.button12.TabIndex = 1;
			this.button12.Text = "BROWSE";
			this.button12.UseVisualStyleBackColor = true;
			this.button12.Click += new System.EventHandler(this.Button12Click);
			// 
			// textBox14
			// 
			this.textBox14.Enabled = false;
			this.textBox14.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox14.Location = new System.Drawing.Point(190, 32);
			this.textBox14.Multiline = true;
			this.textBox14.Name = "textBox14";
			this.textBox14.Size = new System.Drawing.Size(178, 26);
			this.textBox14.TabIndex = 2;
			// 
			// richTextBox6
			// 
			this.richTextBox6.Location = new System.Drawing.Point(19, 101);
			this.richTextBox6.Name = "richTextBox6";
			this.richTextBox6.Size = new System.Drawing.Size(301, 251);
			this.richTextBox6.TabIndex = 4;
			this.richTextBox6.Text = "";
			// 
			// label23
			// 
			this.label23.Location = new System.Drawing.Point(16, 75);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(110, 23);
			this.label23.TabIndex = 5;
			this.label23.Text = "CIPHERTEXT";
			this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label22
			// 
			this.label22.Location = new System.Drawing.Point(499, 74);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(111, 23);
			this.label22.TabIndex = 6;
			this.label22.Text = "PLAINTEXT";
			this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// richTextBox5
			// 
			this.richTextBox5.Location = new System.Drawing.Point(499, 100);
			this.richTextBox5.Name = "richTextBox5";
			this.richTextBox5.Size = new System.Drawing.Size(304, 252);
			this.richTextBox5.TabIndex = 7;
			this.richTextBox5.Text = "";
			// 
			// label21
			// 
			this.label21.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label21.Location = new System.Drawing.Point(326, 101);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(167, 23);
			this.label21.TabIndex = 8;
			this.label21.Text = "KUNCI RC5";
			this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBox13
			// 
			this.textBox13.Location = new System.Drawing.Point(326, 127);
			this.textBox13.Name = "textBox13";
			this.textBox13.Size = new System.Drawing.Size(167, 26);
			this.textBox13.TabIndex = 9;
			// 
			// button11
			// 
			this.button11.Location = new System.Drawing.Point(326, 159);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(167, 35);
			this.button11.TabIndex = 10;
			this.button11.Text = "DEKRIP FILE";
			this.button11.UseVisualStyleBackColor = true;
			this.button11.Click += new System.EventHandler(this.Button11Click);
			// 
			// label20
			// 
			this.label20.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label20.Location = new System.Drawing.Point(809, 100);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(138, 23);
			this.label20.TabIndex = 11;
			this.label20.Text = "RUNNING TIME\r\n";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBox12
			// 
			this.textBox12.Enabled = false;
			this.textBox12.Location = new System.Drawing.Point(809, 126);
			this.textBox12.Name = "textBox12";
			this.textBox12.Size = new System.Drawing.Size(100, 26);
			this.textBox12.TabIndex = 12;
			// 
			// label19
			// 
			this.label19.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.Location = new System.Drawing.Point(915, 127);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(32, 23);
			this.label19.TabIndex = 13;
			this.label19.Text = "Ms";
			this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// button10
			// 
			this.button10.Location = new System.Drawing.Point(809, 159);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(138, 35);
			this.button10.TabIndex = 14;
			this.button10.Text = "SAVE";
			this.button10.UseVisualStyleBackColor = true;
			this.button10.Click += new System.EventHandler(this.Button10Click);
			// 
			// groupBox4
			// 
			this.groupBox4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.groupBox4.Controls.Add(this.button10);
			this.groupBox4.Controls.Add(this.label19);
			this.groupBox4.Controls.Add(this.textBox12);
			this.groupBox4.Controls.Add(this.label20);
			this.groupBox4.Controls.Add(this.button11);
			this.groupBox4.Controls.Add(this.textBox13);
			this.groupBox4.Controls.Add(this.label21);
			this.groupBox4.Controls.Add(this.richTextBox5);
			this.groupBox4.Controls.Add(this.label22);
			this.groupBox4.Controls.Add(this.label23);
			this.groupBox4.Controls.Add(this.richTextBox6);
			this.groupBox4.Controls.Add(this.textBox14);
			this.groupBox4.Controls.Add(this.button12);
			this.groupBox4.Controls.Add(this.label24);
			this.groupBox4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox4.Location = new System.Drawing.Point(12, 248);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(960, 358);
			this.groupBox4.TabIndex = 39;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "DEKRIPSI PESAN";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.groupBox2.Controls.Add(this.button1);
			this.groupBox2.Controls.Add(this.textBox1);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.textBox8);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.textBox7);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.textBox6);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.button5);
			this.groupBox2.Controls.Add(this.textBox5);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.button4);
			this.groupBox2.Controls.Add(this.textBox4);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(12, 27);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(960, 215);
			this.groupBox2.TabIndex = 41;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "DEKRIPSI KUNCI";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(325, 25);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(93, 26);
			this.button1.TabIndex = 23;
			this.button1.Text = "BROWSE";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// textBox1
			// 
			this.textBox1.Enabled = false;
			this.textBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(180, 25);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(140, 26);
			this.textBox1.TabIndex = 22;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(10, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(166, 23);
			this.label1.TabIndex = 21;
			this.label1.Text = "INPUT CIPHERKEY";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(153, 133);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(167, 26);
			this.textBox8.TabIndex = 20;
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(16, 132);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(132, 23);
			this.label12.TabIndex = 19;
			this.label12.Text = "PRIVATE KEY (N)";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBox7
			// 
			this.textBox7.Enabled = false;
			this.textBox7.Location = new System.Drawing.Point(645, 98);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(302, 26);
			this.textBox7.TabIndex = 18;
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(645, 72);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(138, 23);
			this.label11.TabIndex = 17;
			this.label11.Text = "KUNCI RC5";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(914, 131);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(33, 23);
			this.label10.TabIndex = 14;
			this.label10.Text = "Ms";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBox6
			// 
			this.textBox6.Enabled = false;
			this.textBox6.Location = new System.Drawing.Point(808, 130);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(100, 26);
			this.textBox6.TabIndex = 13;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(665, 131);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(138, 23);
			this.label9.TabIndex = 12;
			this.label9.Text = "RUNNING TIME\r\n";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(342, 165);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(167, 36);
			this.button5.TabIndex = 5;
			this.button5.Text = "DEKRIP KUNCI RC5";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(153, 98);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(167, 26);
			this.textBox5.TabIndex = 4;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(16, 97);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(132, 23);
			this.label8.TabIndex = 3;
			this.label8.Text = "PRIVATE KEY (d)";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(16, 165);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(184, 36);
			this.button4.TabIndex = 2;
			this.button4.Text = "IMPORT PRIVATE KEY";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(342, 98);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(297, 26);
			this.textBox4.TabIndex = 1;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(342, 72);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(151, 23);
			this.label7.TabIndex = 0;
			this.label7.Text = "CIPHERKEY RC5";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dekripsi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(984, 618);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.menuStrip1);
			this.Name = "dekripsi";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Dekripsi";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.TextBox textBox12;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.TextBox textBox13;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.RichTextBox richTextBox5;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.RichTextBox richTextBox6;
		private System.Windows.Forms.TextBox textBox14;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.ToolStripMenuItem hELPToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem rECIPIENTToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sENDERToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem gENERATEKEYToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem hOMEToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}
