/*
 * Created by SharpDevelop.
 * User: AlunoSOS2
 * Date: 27/04/2022
 * Time: 10:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Cadastro_de_clientes
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnPessoaFisica;
		private System.Windows.Forms.Button btnPessoaJurídica;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Label lblNome;
		private System.Windows.Forms.Label lblEndereco;
		private System.Windows.Forms.Label lblRG;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.TextBox txtEndereço;
		private System.Windows.Forms.Label lblCPF;
		private System.Windows.Forms.TextBox txtRG;
		private System.Windows.Forms.TextBox txtCPF;
		private System.Windows.Forms.TextBox txtDados;
		
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
			this.btnPessoaFisica = new System.Windows.Forms.Button();
			this.btnPessoaJurídica = new System.Windows.Forms.Button();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.lblNome = new System.Windows.Forms.Label();
			this.lblEndereco = new System.Windows.Forms.Label();
			this.lblRG = new System.Windows.Forms.Label();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.txtEndereço = new System.Windows.Forms.TextBox();
			this.lblCPF = new System.Windows.Forms.Label();
			this.txtRG = new System.Windows.Forms.TextBox();
			this.txtCPF = new System.Windows.Forms.TextBox();
			this.txtDados = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnPessoaFisica
			// 
			this.btnPessoaFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPessoaFisica.Image = ((System.Drawing.Image)(resources.GetObject("btnPessoaFisica.Image")));
			this.btnPessoaFisica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnPessoaFisica.Location = new System.Drawing.Point(12, 13);
			this.btnPessoaFisica.Name = "btnPessoaFisica";
			this.btnPessoaFisica.Size = new System.Drawing.Size(128, 35);
			this.btnPessoaFisica.TabIndex = 0;
			this.btnPessoaFisica.Text = "Pessoa Física";
			this.btnPessoaFisica.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnPessoaFisica.UseVisualStyleBackColor = true;
			this.btnPessoaFisica.Click += new System.EventHandler(this.BtnPessoaFisicaClick);
			// 
			// btnPessoaJurídica
			// 
			this.btnPessoaJurídica.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPessoaJurídica.Image = ((System.Drawing.Image)(resources.GetObject("btnPessoaJurídica.Image")));
			this.btnPessoaJurídica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnPessoaJurídica.Location = new System.Drawing.Point(165, 12);
			this.btnPessoaJurídica.Name = "btnPessoaJurídica";
			this.btnPessoaJurídica.Size = new System.Drawing.Size(152, 34);
			this.btnPessoaJurídica.TabIndex = 1;
			this.btnPessoaJurídica.Text = "Pessoa Jurídica";
			this.btnPessoaJurídica.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnPessoaJurídica.UseVisualStyleBackColor = true;
			this.btnPessoaJurídica.Click += new System.EventHandler(this.BtnPessoaJurídicaClick);
			// 
			// btnSalvar
			// 
			this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
			this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.btnSalvar.Location = new System.Drawing.Point(349, 13);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(113, 36);
			this.btnSalvar.TabIndex = 2;
			this.btnSalvar.Text = " Salvar";
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.BtnSalvarClick);
			// 
			// lblNome
			// 
			this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNome.Location = new System.Drawing.Point(12, 85);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(100, 23);
			this.lblNome.TabIndex = 3;
			this.lblNome.Text = "Nome:";
			// 
			// lblEndereco
			// 
			this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEndereco.Location = new System.Drawing.Point(12, 108);
			this.lblEndereco.Name = "lblEndereco";
			this.lblEndereco.Size = new System.Drawing.Size(100, 23);
			this.lblEndereco.TabIndex = 4;
			this.lblEndereco.Text = "Endereço;";
			// 
			// lblRG
			// 
			this.lblRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRG.Location = new System.Drawing.Point(12, 137);
			this.lblRG.Name = "lblRG";
			this.lblRG.Size = new System.Drawing.Size(100, 23);
			this.lblRG.TabIndex = 5;
			this.lblRG.Text = "RG:";
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(87, 85);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(375, 20);
			this.txtNome.TabIndex = 6;
			// 
			// txtEndereço
			// 
			this.txtEndereço.Location = new System.Drawing.Point(87, 111);
			this.txtEndereço.Name = "txtEndereço";
			this.txtEndereço.Size = new System.Drawing.Size(375, 20);
			this.txtEndereço.TabIndex = 7;
			this.txtEndereço.TextChanged += new System.EventHandler(this.TxtEndereçoTextChanged);
			// 
			// lblCPF
			// 
			this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCPF.Location = new System.Drawing.Point(223, 140);
			this.lblCPF.Name = "lblCPF";
			this.lblCPF.Size = new System.Drawing.Size(45, 23);
			this.lblCPF.TabIndex = 8;
			this.lblCPF.Text = "CPF:";
			// 
			// txtRG
			// 
			this.txtRG.Location = new System.Drawing.Point(87, 137);
			this.txtRG.Name = "txtRG";
			this.txtRG.Size = new System.Drawing.Size(103, 20);
			this.txtRG.TabIndex = 9;
			// 
			// txtCPF
			// 
			this.txtCPF.Location = new System.Drawing.Point(280, 139);
			this.txtCPF.Name = "txtCPF";
			this.txtCPF.Size = new System.Drawing.Size(182, 20);
			this.txtCPF.TabIndex = 10;
			// 
			// txtDados
			// 
			this.txtDados.Location = new System.Drawing.Point(12, 173);
			this.txtDados.Multiline = true;
			this.txtDados.Name = "txtDados";
			this.txtDados.Size = new System.Drawing.Size(450, 141);
			this.txtDados.TabIndex = 11;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(475, 326);
			this.Controls.Add(this.btnPessoaFisica);
			this.Controls.Add(this.txtDados);
			this.Controls.Add(this.txtCPF);
			this.Controls.Add(this.txtRG);
			this.Controls.Add(this.lblCPF);
			this.Controls.Add(this.txtEndereço);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.lblRG);
			this.Controls.Add(this.lblEndereco);
			this.Controls.Add(this.lblNome);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.btnPessoaJurídica);
			this.Name = "MainForm";
			this.Text = "Cadastro de clientes";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
