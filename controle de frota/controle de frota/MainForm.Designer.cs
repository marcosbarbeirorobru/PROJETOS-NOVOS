/*
 * Created by SharpDevelop.
 * User: AlunoSOS4
 * Date: 04/04/2022
 * Time: 09:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace controle_de_frota
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnCarro;
		private System.Windows.Forms.Button btnCaminhões;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtmodelo;
		private System.Windows.Forms.TextBox txtPlaca;
		private System.Windows.Forms.TextBox txtKm;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.btnCarro = new System.Windows.Forms.Button();
			this.btnCaminhões = new System.Windows.Forms.Button();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtmodelo = new System.Windows.Forms.TextBox();
			this.txtPlaca = new System.Windows.Forms.TextBox();
			this.txtKm = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// btnCarro
			// 
			this.btnCarro.Image = ((System.Drawing.Image)(resources.GetObject("btnCarro.Image")));
			this.btnCarro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCarro.Location = new System.Drawing.Point(59, 12);
			this.btnCarro.Name = "btnCarro";
			this.btnCarro.Size = new System.Drawing.Size(122, 23);
			this.btnCarro.TabIndex = 0;
			this.btnCarro.Text = "Carros";
			this.btnCarro.UseVisualStyleBackColor = true;
			this.btnCarro.Click += new System.EventHandler(this.Button1Click);
			// 
			// btnCaminhões
			// 
			this.btnCaminhões.Image = ((System.Drawing.Image)(resources.GetObject("btnCaminhões.Image")));
			this.btnCaminhões.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCaminhões.Location = new System.Drawing.Point(211, 12);
			this.btnCaminhões.Name = "btnCaminhões";
			this.btnCaminhões.Size = new System.Drawing.Size(129, 23);
			this.btnCaminhões.TabIndex = 1;
			this.btnCaminhões.Text = "Caminhões";
			this.btnCaminhões.UseVisualStyleBackColor = true;
			this.btnCaminhões.Click += new System.EventHandler(this.BtnCaminhõesClick);
			// 
			// btnSalvar
			// 
			this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
			this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSalvar.Location = new System.Drawing.Point(367, 12);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(126, 23);
			this.btnSalvar.TabIndex = 2;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.BtnSalvarClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 66);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "Modelo";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 100);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Placa";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 135);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Km";
			// 
			// txtmodelo
			// 
			this.txtmodelo.Location = new System.Drawing.Point(59, 63);
			this.txtmodelo.Name = "txtmodelo";
			this.txtmodelo.Size = new System.Drawing.Size(447, 20);
			this.txtmodelo.TabIndex = 6;
			this.txtmodelo.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// txtPlaca
			// 
			this.txtPlaca.Location = new System.Drawing.Point(59, 97);
			this.txtPlaca.Name = "txtPlaca";
			this.txtPlaca.Size = new System.Drawing.Size(447, 20);
			this.txtPlaca.TabIndex = 7;
			// 
			// txtKm
			// 
			this.txtKm.Location = new System.Drawing.Point(59, 132);
			this.txtKm.Name = "txtKm";
			this.txtKm.Size = new System.Drawing.Size(100, 20);
			this.txtKm.TabIndex = 8;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(49, 275);
			this.textBox4.Multiline = true;
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(238, 178);
			this.textBox4.TabIndex = 9;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(334, 275);
			this.textBox5.Multiline = true;
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(238, 178);
			this.textBox5.TabIndex = 10;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(49, 202);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 67);
			this.pictureBox1.TabIndex = 11;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(334, 193);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(129, 76);
			this.pictureBox2.TabIndex = 12;
			this.pictureBox2.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(602, 465);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.txtKm);
			this.Controls.Add(this.txtPlaca);
			this.Controls.Add(this.txtmodelo);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.btnCaminhões);
			this.Controls.Add(this.btnCarro);
			this.Name = "MainForm";
			this.Text = "controle de frota";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
