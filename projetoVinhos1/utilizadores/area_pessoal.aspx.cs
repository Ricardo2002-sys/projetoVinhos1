using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projetoVinhos1.utilizadores
{
    public partial class area_pessoal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id_utilizador"] != null)
            {
                GetVinhos();
            }
        }

        protected void gridVinhos_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[0].Width = 125;
            e.Row.Cells[0].HorizontalAlign = HorizontalAlign.Center;
            e.Row.Cells[1].Visible = false;
            e.Row.Cells[2].Width = 300;
            e.Row.Cells[3].Visible = true;
            e.Row.Cells[3].Width = 300;
            e.Row.Cells[4].Visible = true;
            e.Row.Cells[4].Width = 1200;
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Cells[2].Text = Server.HtmlDecode(e.Row.Cells[2].Text);
                e.Row.Cells[3].Text = Server.HtmlDecode(e.Row.Cells[3].Text);
                e.Row.Cells[4].Text = Server.HtmlDecode(e.Row.Cells[4].Text);
            }
        }

        void GetVinhos()
        {
            SqlConnection connection = new SqlConnection(
            @"Data Source=.\sqlexpress;Initial Catalog=Vinhos;Integrated Security=SSPI");
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText =
            "SELECT Vinho.Id, Vinho.Nome, Tipo.Nome AS Tipo, Regiao.Nome AS Região " +
            "FROM Vinho INNER JOIN Regiao ON Vinho.Regiao = Regiao.Id " +
            "INNER JOIN Tipo ON Vinho.Tipo = Tipo.Id " +
            "WHERE(Vinho.Utilizador = @utilizador) " +
            "ORDER BY Vinho.Nome";
            command.Parameters.AddWithValue("@utilizador", Session["id_utilizador"].ToString());
            SqlDataReader reader;
            DataTable table = new DataTable();
            connection.Open();
            reader = command.ExecuteReader();
            table.Load(reader);
            connection.Close();
            gridVinhos.DataSource = table;
            gridVinhos.DataBind();
        }

        protected void buttonCriarVinho_Click(object sender, EventArgs e)
        {
            Response.Redirect("criar_vinho.aspx");
        }

        protected void buttonEditarVinho_Click(object sender, EventArgs e)
        {
            if (gridVinhos.SelectedRow != null)
            {
                Session["vinho"] = gridVinhos.SelectedRow.Cells[1].Text;
                Response.Redirect("editar_vinho.aspx");
            }
        }
    }
}