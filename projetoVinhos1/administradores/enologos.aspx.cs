﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projetoVinhos1.administradores
{
//    public partial class Enologos : System.Web.UI.Page
//    {
//        SqlConnection connection = new SqlConnection(
//                @"Data Source=.\SQLEXPRESS;Initial Catalog=Vinhos;Integrated Security=SSPI");

//        protected void Page_Load(object sender, EventArgs e)
//        {
//            if (!IsPostBack)
//            {
//                GetEnologos();
//            }
//        }

//        void GetEnologos()
//        {
//            SqlCommand command = new SqlCommand
//            ("SELECT Nome FROM Enologo ORDER BY Nome ASC", connection);
//            SqlDataReader reader;
//            DataTable table = new DataTable();
//            connection.Open();
//            reader = command.ExecuteReader();
//            table.Load(reader);
//            connection.Close();
//            gridEnologos.DataSource = table;
//            gridEnologos.DataBind();
//        }

//        protected void gridEnologos_RowDataBound(object sender, GridViewRowEventArgs e)
//        {
//            e.Row.Cells[0].Width = 125;
//            e.Row.Cells[0].HorizontalAlign = HorizontalAlign.Center;
//            e.Row.Cells[1].Visible = false;
//            e.Row.Cells[2].Width = 300;
//            e.Row.Cells[3].Visible = false;

//            if (e.Row.RowType == DataControlRowType.DataRow)
//            {
//                e.Row.Cells[2].Text = Server.HtmlDecode(e.Row.Cells[2].Text);
//                e.Row.Cells[3].Text = Server.HtmlDecode(e.Row.Cells[3].Text);
//            }
//        }
//        protected void linkAdicionar_Click(object sender, EventArgs e)
//        {
//            SqlCommand command = new SqlCommand(
//                "INSERT Enologo(Nome, Instagram) VALUES(@nome, @instagram)", connection);
//            command.Parameters.AddWithValue("@nome", textNome.Text);
//            command.Parameters.AddWithValue("@instagram", textInstagram.Text);
//            connection.Open();
//            command.ExecuteNonQuery();
//            connection.Close();

//            GetEnologos();
//        }

//        int ContarEnologosVinho(string idEnologo)
//        {
//            SqlCommand command = new SqlCommand
//                ("SELECT COUNT(*) FROM VinhoEnologo WHERE Enologo = @idEnologo", connection);
//            command.Parameters.AddWithValue("@idEnologo", idEnologo);
//            connection.Open();
//            int contador = (int)command.ExecuteScalar();
//            connection.Close();
//            return contador;
//        }

//        protected void linkELiminar_Click(object sender, EventArgs e)
//        {
//            if (gridEnologos.SelectedRow != null)
//            {
//                string id = gridEnologos.SelectedRow.Cells[1].Text;
//                int contador = ContarEnologosVinho(id);
//                if (contador == 0)
//                {
//                    SqlCommand command = new SqlCommand(
//                        "DELETE Enologo WHERE I = @id", connection);
//                    command.Parameters.AddWithValue("@id", id);
//                    connection.Open();
//                    command.ExecuteNonQuery();
//                    connection.Close();
//                }
//                else
//                    Response.Write("<script>alert('A Enologo " + gridEnologos.SelectedRow.Cells[2].Text + "" +
//                        " não pode ser elminada; tem " + contador + "vinhos associados.');</script>");
//            }
//            else
//                Response.Write("<script>alert('Selecione a linha a eliminar.');>/script>");
//        }

//        protected void gridEnologos_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            textNome.Text = gridEnologos.SelectedRow.Cells[2].Text;
//            textInstagram.Text = gridEnologos.SelectedRow.Cells[3].Text;
//        }

//        protected void linkAlterear_Click(object sender, EventArgs e)
//        {
//            SqlCommand command = new SqlCommand(
//                "UPDATE Enologo SET Nome = @nome, Instagram = @instagram" +
//                "WHERE Id = @id", connection);
//            command.Parameters.AddWithValue("@nome", textNome.Text);
//            command.Parameters.AddWithValue("@instagram", textInstagram.Text);
//            command.Parameters.AddWithValue("@id", gridEnologos.SelectedRow.Cells[1].Text);
//            connection.Open();
//            command.ExecuteNonQuery();
//            connection.Close();

//            GetEnologos();
//        }
//    }
//}