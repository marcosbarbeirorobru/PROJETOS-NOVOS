/*
 * Created by SharpDevelop.
 * User: AlunoSOS2
 * Date: 27/04/2022
 * Time: 10:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Cadastro_de_clientes
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnSalvarClick(object sender, EventArgs e)
		{
	
		
			if(txtNome.Text == ""){
				
				MessageBox.Show("Digite Nome");
				
			}
			
			if(txtEndereço.Text == ""){
				
				MessageBox.Show("Digite Endereço");
			}
			
			
			if(txtRG.Text == ""){
				
				MessageBox.Show("Digite RG");
			}
			
			if(txtCPF.Text == ""){
				
				MessageBox.Show("Digite CPF ou CNPJ");
				
			}
			
			
			
			
			
			
			
			txtDados.Text += txtNome.Text + "\t";
			
			
			txtDados.Text += txtEndereço.Text + "\t";
			
			
			txtDados.Text += txtRG.Text + "\t";
			
			
			txtDados.Text += txtCPF.Text + "\r\n";
			
			//chamando metodo limpar
			Limpar();
			
		} //fim do botão salvar
		
		private void Limpar()
		{
		
			txtNome.Clear();
			txtEndereço.Clear();
			txtCPF.Clear();
			txtRG.Clear();
			
		}//fim do metodo Limpar
		
		void TxtEndereçoTextChanged(object sender, EventArgs e)
		{
	
			
		}
		void BtnPessoaJurídicaClick(object sender, EventArgs e)
		{
	
			lblCPF.Text = "CNPJ:";
			
		}
		void BtnPessoaFisicaClick(object sender, EventArgs e)
		{
	
			lblCPF.Text = "CPF:";
			
		}
	}
}
