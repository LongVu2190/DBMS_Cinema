using Cinema.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.BS_Layer
{
    internal class Bussiness
    {
        DBMain db = new DBMain();

        public Bussiness() { }

        public List<int> LoadSeats(string Movie_ID)
        {
            //string sql = $"select Seat from Reservation A inner join ShowTime B on A.ShowTime_ID = B.ShowTime_ID where Movie_ID = '{Movie_ID}'";
            string sql = $"select * from Fn_VeNguoiDungDat('{Movie_ID}')";
            return db.LoadSeats(sql);
        }
        public DataTable LoadMovies()
        {
            string sql = "select * from ShowTime";
            return db.LoadMovies(sql);
        }
    }
}
