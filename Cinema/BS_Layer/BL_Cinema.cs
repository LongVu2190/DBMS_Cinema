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
                default:
                    sql = "select * from ShowTime";
                    return db.LoadMovies(sql);
            }
        }
        public void BookMovie(string User_ID, string ShowTime_ID, int Seat)
        {
            string sql = $"exec Sp_AddReservation '{User_ID}', '{ShowTime_ID}', {Seat}";
            try
            {
                db.MyExecuteNonQuery(sql);
            }
            catch (Exception ex) 
            {
                MessageBox.Show("You don't have enough money!!!");
            }
            MessageBox.Show("Successfully");
        }
    }
}
