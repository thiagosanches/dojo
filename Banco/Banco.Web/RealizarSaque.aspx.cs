using Banco.Business;
using Banco.Business.Exceptions;
using Banco.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Banco.Web
{
    public partial class RealizarSaque : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Maquina maquina = new Maquina();
                maquina.Saldo = 1000;

                ClienteBusiness clienteBusiness = new ClienteBusiness();
                Cliente clienteFiltro = new Cliente();
                clienteFiltro.Id = Convert.ToInt32(txtCodigoCliente.Text);

                Cliente cliente = clienteBusiness.Buscar(clienteFiltro);

                MaquinaBusiness maquinaBusiness = new MaquinaBusiness();
                maquinaBusiness.Sacar(maquina, cliente, Convert.ToDecimal(txtValor.Text));
            }
            catch (CartaoInvalidoException)
            {
                lblMensagem.Text = "Seu cartao está inválido.";
            }
        }
    }
}