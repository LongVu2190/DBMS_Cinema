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
    internal class BL_Cinema
    {
        DBMain db = new DBMain();
        public BL_Cinema() { }

        public List<int> LoadSeats(string ShowTime_ID)
        {
            string sql = $"select * from Fn_BookedSeats('{ShowTime_ID}')";
            return db.LoadSeats(sql);
        }
        public DataTable LoadMovies(int flag, string ID)
        {
            string sql = "";
            switch (flag)
            {
                case 0:
                    sql = "select * from ShowTime";
                    return db.LoadMovies(sql);
                case 1:
                    sql = $"select * from Fn_ShowTime_by_Screen('{ID}')";
                    return db.LoadMovies(sql);
                case 2:
                    sql = $"select * from Fn_ShowTime_by_Company('{ID}')";
                    return db.LoadMovies(sql);
                case 3:
                    sql = $"select * from Fn_ShowTime_by_Actor('{ID}')";
                    return db.LoadMovies(sql);
                case 4:
                    sql = $"select * from Fn_User_Booked('{ID}')";
                    return db.LoadMovies(sql);
                default:
                    sql = "select * from ShowTime";
                    return db.LoadMovies(sql);
            }
        }
        public void LoadUserInformation(string User_ID, ref User cus)
        {
            string sql = $"select Balance, Point, isVip\r\nfrom Customer\r\nwhere Customer.User_ID = '{User_ID}'";
            db.GetUserInformation(sql, ref cus);
        }
        public void GetCost(string ShowTime_ID, ref int cost)
        {
            string sql = $"select Total_Cost from ShowTime where ShowTime_ID = '{ShowTime_ID}'";
            db.GetCost(sql, ref cost);
        }
        public void BookMovie(string User_ID, string ShowTime_ID, int Seat)
        {
            string sql = $"exec Sp_AddReservation '{User_ID}', '{ShowTime_ID}', {Seat}";
            db.MyExecuteNonQuery(sql);
        }
    }
}
