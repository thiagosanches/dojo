using Banco.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Banco.Web
{
    public partial class ConsultarCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ClienteBusiness clienteBusiness = new ClienteBusiness();
            grdCliente.DataSource = clienteBusiness.BuscarTodos();
            grdCliente.DataBind();
        }
    }
}