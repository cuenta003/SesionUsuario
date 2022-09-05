using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SesionUsuario
{
    public partial class SesionUsuarioTres : System.Web.UI.Page
    {
        //Antes de que inicialize la plagina
        protected void Page_PreInit(object sender, EventArgs e) {
            Response.Write($"1- Evento PreInit <br/>");
        }

        //Evento que sucede despues de inicializarse los controles
        protected void Page_Init(object sender, EventArgs e) {
            Response.Write($"2- Evento Init <br/>");
        }

        //Evento que sucede despues de que se inicializo la pagina
        protected void Page_InitComplete(object sender, EventArgs e)
        {
            Response.Write($"3- Evento InitComplete <br/>");
        }

        //Usarlo para conexion a db
        protected void Page_PreLoad(object sender, EventArgs e)
        {
            Response.Write($"4- Evento PreLoad <br/>");
        }

        //Usarlo para conexion a db
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write($"5- Evento Load <br/>");
        }

        //Cargar propiedades a todosl los controles sucede despues de los eventos de control
        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            Response.Write($"6- Evento LoadComplete <br/>");
        }

        //Sucede antes de representar de forma virtual todos los controls y de debe ejecutar desdes de cargado los controles
        protected void Page_PreRender(object sender, EventArgs e)
        {
            Response.Write($"7- Evento PreRender <br/>");
        }

        //Despues de que cada control se haya enlazadoasociado con el datasource id y datavalue
        protected void Page_PreRenderComplete(object sender, EventArgs e)
        {
            Response.Write($"8- Evento Page_PreRenderComplete <br/>");
        }
    }
}