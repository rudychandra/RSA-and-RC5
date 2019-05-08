/*
 * Created by SharpDevelop.
 * User: user
 * Date: 19/09/2018
 * Time: 21:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace rsa_rc5
{
	partial class bangkitkunci
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
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.button3 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tb_beta = new System.Windows.Forms.TextBox();
			this.tb_d = new System.Windows.Forms.TextBox();
			this.button_generate = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.tb_alpa = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tb_prima = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.groupBox4.SuspendLayout();
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
			this.menuStrip1.Size = new System.Drawing.Size(450, 24);
			this.menuStrip1.TabIndex = 35;
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
			this.rECIPIENTToolStripMenuItem.Click += new System.EventHandler(this.RECIPIENTToolStripMenuItemClick);
			// 
			// hELPToolStripMenuItem
			// 
			this.hELPToolStripMenuItem.Name = "hELPToolStripMenuItem";
			this.hELPToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
			this.hELPToolStripMenuItem.Text = "HELP";
			this.hELPToolStripMenuItem.Click += new System.EventHandler(this.HELPToolStripMenuItemClick);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(314, 84);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(91, 40);
			this.button2.TabIndex = 43;
			this.button2.Text = "Save Private Key";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(314, 38);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(91, 40);
			this.button1.TabIndex = 42;
			this.button1.Text = "Save Public Key";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// groupBox4
			// 
			this.groupBox4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.groupBox4.Controls.Add(this.button3);
			this.groupBox4.Controls.Add(this.textBox1);
			this.groupBox4.Controls.Add(this.label5);
			this.groupBox4.Controls.Add(this.tb_beta);
			this.groupBox4.Controls.Add(this.tb_d);
			this.groupBox4.Controls.Add(this.button_generate);
			this.groupBox4.Controls.Add(this.label3);
			this.groupBox4.Controls.Add(this.tb_alpa);
			this.groupBox4.Controls.Add(this.label4);
			this.groupBox4.Controls.Add(this.tb_prima);
			this.groupBox4.Controls.Add(this.label2);
			this.groupBox4.Controls.Add(this.label1);
			this.groupBox4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox4.Location = new System.Drawing.Point(32, 38);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(276, 239);
			this.groupBox4.TabIndex = 41;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "KEY GENERATOR";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(158, 196);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(91, 37);
			this.button3.TabIndex = 41;
			this.button3.Text = "Reset";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(74, 154);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(175, 26);
			this.textBox1.TabIndex = 40;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(5, 157);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 39;
			this.label5.Text = "D";
			// 
			// tb_beta
			// 
			this.tb_beta.Location = new System.Drawing.Point(74, 125);
			this.tb_beta.Name = "tb_beta";
			this.tb_beta.Size = new System.Drawing.Size(175, 26);
			this.tb_beta.TabIndex = 36;
			// 
			// tb_d
			// 
			this.tb_d.Location = new System.Drawing.Point(74, 96);
			this.tb_d.Name = "tb_d";
			this.tb_d.Size = new System.Drawing.Size(174, 26);
			this.tb_d.TabIndex = 38;
			// 
			// button_generate
			// 
			this.button_generate.Location = new System.Drawing.Point(7, 196);
			this.button_generate.Name = "button_generate";
			this.button_generate.Size = new System.Drawing.Size(91, 37);
			this.button_generate.TabIndex = 6;
			this.button_generate.Text = "Generate";
			this.button_generate.UseVisualStyleBackColor = true;
			this.button_generate.Click += new System.EventHandler(this.Button_generateClick);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(5, 128);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 35;
			this.label3.Text = "E";
			// 
			// tb_alpa
			// 
			this.tb_alpa.Location = new System.Drawing.Point(73, 67);
			this.tb_alpa.Name = "tb_alpa";
			this.tb_alpa.Size = new System.Drawing.Size(175, 26);
			this.tb_alpa.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(7, 99);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 37;
			this.label4.Text = "N";
			// 
			// tb_prima
			// 
			this.tb_prima.Location = new System.Drawing.Point(74, 38);
			this.tb_prima.Name = "tb_prima";
			this.tb_prima.Size = new System.Drawing.Size(175, 26);
			this.tb_prima.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(7, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Q";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(6, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "P";
			// 
			// bangkitkunci
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(450, 289);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.menuStrip1);
			this.Name = "bangkitkunci";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bangkit Kunci";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tb_prima;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tb_alpa;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button_generate;
		private System.Windows.Forms.TextBox tb_d;
		private System.Windows.Forms.TextBox tb_beta;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ToolStripMenuItem hELPToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem rECIPIENTToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sENDERToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem gENERATEKEYToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem hOMEToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}
