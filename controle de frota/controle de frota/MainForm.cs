/*
 * Created by SharpDevelop.
 * User: AlunoSOS4
 * Date: 04/04/2022
 * Time: 09:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace controle_de_frota
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
		void TextBox4TextChanged(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
		
			txtmodelo.Text = "Carro";
			
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
			
			
		}
		void BtnCaminhõesClick(object sender, EventArgs e)
		{
	
			txtPlaca. Text = "caminhões";
			
		}
		void BtnSalvarClick(object sender, EventArgs e)
		{
	
			
			txtKm. Text = "Salvar";
		}
	}
}
