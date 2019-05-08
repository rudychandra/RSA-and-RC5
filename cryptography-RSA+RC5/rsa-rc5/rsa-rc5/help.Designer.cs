/*
 * Created by SharpDevelop.
 * User: user
 * Date: 19/09/2018
 * Time: 21:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace rsa_rc5
{
	partial class help
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(help));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.hOMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gENERATEKEYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sENDERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rECIPIENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hELPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.richTextBox2 = new System.Windows.Forms.RichTextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.richTextBox3 = new System.Windows.Forms.RichTextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox1.SuspendLayout();
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
			this.menuStrip1.Size = new System.Drawing.Size(712, 24);
			this.menuStrip1.TabIndex = 4;
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
			this.rECIPIENTToolStripMenuItem.Click += new System.EventHandler(this.RECIPIENTToolStripMenuItemClick);
			// 
			// hELPToolStripMenuItem
			// 
			this.hELPToolStripMenuItem.Name = "hELPToolStripMenuItem";
			this.hELPToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
			this.hELPToolStripMenuItem.Text = "HELP";
			// 
			// richTextBox1
			// 
			this.richTextBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.richTextBox1.Location = new System.Drawing.Point(6, 29);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(613, 130);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.groupBox2.Controls.Add(this.richTextBox2);
			this.groupBox2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(11, 214);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(625, 186);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "MENU ENKRIPSI";
			// 
			// richTextBox2
			// 
			this.richTextBox2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.richTextBox2.Location = new System.Drawing.Point(6, 29);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.Size = new System.Drawing.Size(613, 151);
			this.richTextBox2.TabIndex = 1;
			this.richTextBox2.Text = resources.GetString("richTextBox2.Text");
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.panel1.Controls.Add(this.groupBox3);
			this.panel1.Controls.Add(this.groupBox2);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(32, 27);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(649, 579);
			this.panel1.TabIndex = 5;
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.groupBox3.Controls.Add(this.richTextBox3);
			this.groupBox3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(10, 407);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(625, 158);
			this.groupBox3.TabIndex = 3;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "MENU DEKRIPSI";
			// 
			// richTextBox3
			// 
			this.richTextBox3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.richTextBox3.Location = new System.Drawing.Point(6, 25);
			this.richTextBox3.Name = "richTextBox3";
			this.richTextBox3.Size = new System.Drawing.Size(613, 127);
			this.richTextBox3.TabIndex = 2;
			this.richTextBox3.Text = resources.GetString("richTextBox3.Text");
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.groupBox1.Controls.Add(this.richTextBox1);
			this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(11, 43);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(625, 165);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "MENU BANGKIT KUNCI";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(11, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(625, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "HELP";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// help
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(712, 618);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuStrip1);
			this.Name = "help";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Help";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RichTextBox richTextBox3;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RichTextBox richTextBox2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.ToolStripMenuItem hELPToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem rECIPIENTToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sENDERToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem gENERATEKEYToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem hOMEToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}
