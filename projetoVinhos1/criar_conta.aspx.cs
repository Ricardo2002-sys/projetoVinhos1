using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.Security;
using System.Web.UI.WebControls;

namespace projetoVinhos1
{
    public partial class criar_conta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                string data = DateTime.Now.AddYears(-18).ToShortDateString();
                ValidateBirthDate.ErrorMessage =
                "Defina data igual ou anterior a " + data;
                ValidateBirthDate.Type = ValidationDataType.Date;
                ValidateBirthDate.Operator = ValidationCompareOperator.LessThanEqual;
                ValidateBirthDate.ValueToCompare = data;
            }
        }

        protected void Btnconta_Click(object sender, EventArgs e)
        {
            //Criar conta - Membership
            Membership.CreateUser(Username.Text, Password.Text, Email.Text);
            
            //obter o UserID
            MembershipUser user = Membership.GetUser(Username.Text);
            object user_id = user.ProviderUserKey;
            
            //adicionar à role utilizador
            Roles.AddUserToRole(Username.Text, "utilizadores");
            
            //Criar Utilizador (vinhos)
            SqlConnection connection = new SqlConnection(
            ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "INSERT Utilizador VALUES(@user_id , @nome, @email, @data)";
            command.Parameters.AddWithValue("@nome", Name.Text);
            command.Parameters.AddWithValue("@email", Email.Text);
            command.Parameters.AddWithValue("@data", DateTime.Parse(BirthDate.Text));
            command.Parameters.AddWithValue("@user_id", user_id.ToString());
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            Response.Redirect("login.aspx");
        }
    }
}