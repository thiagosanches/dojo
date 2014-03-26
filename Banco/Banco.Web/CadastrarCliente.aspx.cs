using Banco.Business;
using Banco.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Banco.Web
{
    public partial class CadastrarCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Idade = txtIdade.Text;
            cliente.Nome = txtNome.Text;
            cliente.RG = txtRg.Text;
            cliente.Sobrenome = txtSobrenome.Text;
            cliente.Cpf = txtCpf.Text;

            BancoBusiness banco = new BancoBusiness();
            banco.InserirCorrentista(cliente);
           

            
           

           
            


            
        }
    }
}