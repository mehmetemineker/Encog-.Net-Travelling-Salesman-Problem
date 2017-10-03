using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GA.GSP
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        Solve solve;

        private void FormMain_Load(object sender, EventArgs e)
        {
            solve = new Solve((int)numericUpDownCityCount.Value, panelBoard.Height, panelBoard.Width);
        }

        private void ButtonRandomGenerate_Click(object sender, EventArgs e)
        {
            solve.CityCount = (int)numericUpDownCityCount.Value;
            solve.RandomFirstCities();

            DrawBoard(solve.cities);

        }

        private void DrawBoard(City[] cities)
        {
            Brush aBrush = Brushes.GreenYellow;
            Graphics g = panelBoard.CreateGraphics();
            g.Clear(Color.Black);

            for (int i = 0; i < cities.Length - 1; i++)
            {
                g.DrawLine(new Pen(Color.Maroon), cities[i].X, cities[i].Y, cities[i + 1].X, cities[i + 1].Y);
            }

            for (int i = 0; i < cities.Length; i++)
            {
                g.FillEllipse(aBrush, cities[i].X, cities[i].Y, 5, 5);
            }
        }

        private void ButtonSolve_Click(object sender, EventArgs e)
        {

            int[] best = solve.Run();
            List<City> bestOrderByCities = new List<City>();

            foreach (var item in best)
            {
                bestOrderByCities.Add(solve.cities[item]);
            }

            DrawBoard(bestOrderByCities.ToArray());
        }
    }
}
