using Cinema.BS_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class Cinema : Form
    {
        Movie mov = new Movie();
        List<int> Booked_Seats = new List<int>();   
        Bussiness bs = new Bussiness();
        public Cinema()
        {
            InitializeComponent();          
        }
        private void Cinema_Load(object sender, EventArgs e)
        {
            Booked_Seats = bs.LoadData("M1");
            for (int i = 0; i <= 28; i++)
            {
                mov.SEATS.Add(0);
            }
            for (int i = 0; i < Booked_Seats.Count; i++)
            {
                mov.SEATS[Booked_Seats[i]] = 1;
            }
            CreateSeatsWidget();
        }
        public void CreateSeatsWidget()
        {
            int Count = 1;
            int Buttons = 28;
            int X = 0;
            int Y = 0;
            for (int i = 1; i <= Buttons; i++)
            {
                Button b = new Button();
                b.Text = Count.ToString();
                b.Name = Count.ToString();
                b.Size = new Size(50, 50);
                b.Font = new Font("Arial", 12, FontStyle.Bold);
                b.Location = new Point(60 * (X + 1) + 100, 150 + Y);
                switch (mov.SEATS[i])
                {
                    case -1:
                        b.BackColor = Color.DodgerBlue;
                        break;
                    case 0:
                        b.BackColor = Color.LightSlateGray;
                        break;
                    case 1:
                        b.BackColor = Color.IndianRed;
                        break;
                }
                b.ForeColor = Color.White;
                b.Padding = new Padding(0);
                b.Click += new EventHandler(this.SeatClick);
                if (i % 7 == 0)
                {
                    X = -1;
                    Y += 60;
                }
                X++;
                Controls.Add(b);
                Count++;
            }
        }
        public void SeatClick(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            if (bt.BackColor == Color.IndianRed)
            {
                MessageBox.Show("Chỗ ngồi " + bt.Name + " đã bị chọn", "Thông báo");
            }
            else if (bt.BackColor == Color.DodgerBlue)
            {
                bt.BackColor = Color.LightSlateGray;
            }
            else if (bt.BackColor == Color.ForestGreen)
            {
                bt.BackColor = Color.LightSlateGray;
            }
            else
            {
                bt.BackColor = Color.ForestGreen;
            }
        }

    }
}

