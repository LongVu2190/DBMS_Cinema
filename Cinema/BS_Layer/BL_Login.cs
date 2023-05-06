using Cinema.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema.BS_Layer
{
    internal class BL_Login
    {
        DBMain db = new DBMain();

        public BL_Login() { }

        public void Login(string User_ID, string Password, ref Customer cus, ref bool result)
        {
            string sql = $"select * from Fn_CustomerLogin('{User_ID}', '{Password}')";
            db.Login(sql, ref cus, ref result);
        }
    }
}
