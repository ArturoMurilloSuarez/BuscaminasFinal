using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuscaminasFinal;

namespace BuscaminasFinalGráfico
{
    public partial class Nivel : Form
    {
        public Game<Celda> game;
        
        public Nivel()
        {
            InitializeComponent();
        }

        public void GetStats()
        {
            this.MinasRestantesText.Text = game.FlagCount + "";
        }

        public void CreateGrid()
        {
            for (uint i = 0; i < this.game.WidthGetter; i++)
            {
                this.GridCeldas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            }
            for (uint i = 0; i < this.game.HeightGetter; i++)
            {
                this.GridCeldas.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            }
            this.GridCeldas.ColumnCount = this.game.WidthGetter;
            this.GridCeldas.RowCount = this.game.HeightGetter;
            for (int i = 0; i < this.game.WidthGetter; i++)
            {
                for (int j = 0; j < this.game.HeightGetter; j++)
                {
                    this.GridCeldas.Controls.Add(new CellButton(this.game.celdas[i,j]), i, j);
                }
            }

        }

        private void Nivel_Load(object sender, EventArgs e)
        {
            if (game != null)
            {
                this.GetStats();
                this.CreateGrid();
            }
        }


    }
}
