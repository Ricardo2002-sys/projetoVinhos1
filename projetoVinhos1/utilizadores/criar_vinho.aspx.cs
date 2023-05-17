using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace projetoVinhos1.utilizadores
{
    public partial class criar_vinho : System.Web.UI.Page
    {
        List<string> castas = new List<string>();
        DataTable dtCastas = new DataTable();
        SqlConnection connection = new SqlConnection(
        @"data source=.\sqlexpress; initial catalog=Vinhos; integrated security = true;");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        void GetCastas()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT Id, Nome FROM CASTA ORDER BY Nome ASC";
            SqlDataReader reader;
            DataTable table = new DataTable();
            connection.Open();
            reader = command.ExecuteReader();
            table.Load(reader);
            connection.Close();
            //guardar dados obtidos (objecto table) em ViewState
            ViewState["dtCastas"] = table;
        }
    }
}