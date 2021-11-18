using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingBAL;

namespace ShoppingDAL
{
  public  class CustomerDAL
  {
        public string AddCustomer(CustomerBAL ba)
        {
            SqlConnection cn = new SqlConnection("server=DESKTOP-K1I5LU7\\SQLEXPRESS;Integrated Security=true;database=OnlineShopping");
            string s = "[dbo].[sp_InsertCustomer]";
            SqlCommand cmd = new SqlCommand(s, cn);
            cmd.Parameters.AddWithValue("@p_firstName", ba.FirstName);
            cmd.Parameters.AddWithValue("@p_lastname", ba.LastName);
            cmd.Parameters.AddWithValue("@p_emailId", ba.EmailId);
            cmd.Parameters.AddWithValue("@p_password", ba.Password);
            cmd.Parameters.AddWithValue("@p_MobileNo", ba.MobileNo);
            cmd.Parameters.AddWithValue("@p_city", ba.City);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cn.Open();
            string s1 = "u are welcome";

            cmd.ExecuteNonQuery();
            cn.Close();
            cn.Dispose();
            return s1;
        }

        public string AddToCart(CartBAL bal)
        {
            SqlConnection cn = new SqlConnection("server=DESKTOP-K1I5LU7\\SQLEXPRESS;Integrated Security=true;database=OnlineShopping");
            string s = "[dbo].[p_InsertCart]";
            SqlCommand cmd = new SqlCommand(s, cn);
            cmd.Parameters.AddWithValue("@quantity", bal.Quantity);
            cmd.Parameters.AddWithValue("@productId", bal.ProductId);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cn.Open();
            string s1 = "Items have been added to the string";
            cmd.ExecuteNonQuery();
            cn.Close();
            cn.Dispose();
            return s1;
        }


        public string UpdateCart(CartBAL bal)
        {
            SqlConnection cn = new SqlConnection("server=DESKTOP-K1I5LU7\\SQLEXPRESS;Integrated Security=true;database=OnlineShopping");
            string s = "[dbo].[p_UpdateCart]";
            SqlCommand cmd = new SqlCommand(s, cn);
            cmd.Parameters.AddWithValue("@quantity", bal.Quantity);
            cmd.Parameters.AddWithValue("@productId", bal.ProductId);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cn.Open();
            string s1 = "Items have been updated";

            cmd.ExecuteNonQuery();
            cn.Close();
            cn.Dispose();
            return s1;
        }



        public string DeleteCart(CartBAL bal)
        {
            SqlConnection cn = new SqlConnection("server=DESKTOP-K1I5LU7\\SQLEXPRESS;Integrated Security=true;database=OnlineShopping");
            string s = "[dbo].[sp_DeleteCartItem] ";
            SqlCommand cmd = new SqlCommand(s, cn);
            
            cmd.Parameters.AddWithValue("@productId", bal.ProductId);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cn.Open();
            string s1 = "Item has been deleted";

            cmd.ExecuteNonQuery();
            cn.Close();
            cn.Dispose();
            return s1;
        }
  }
}
