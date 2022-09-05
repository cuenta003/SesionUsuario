using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SesionUsuario
{
    public partial class SesionUsuarioDos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Se puede usar con cookies o sin cookies
            Response.Write($"Cantidad de apss instanciadas: {Application["Aplicaciones"]} <br/>");
            Response.Write($"Cantidad de sesiones de usuario: {Application["SesionUsuario"]}");

            // Si no se usan cookies se debe agregar en el WebConfig un parametro
            //<sessionState mode="InProc" cookieless="true" ></sessionState>
        }
    }
}