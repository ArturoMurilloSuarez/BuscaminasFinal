using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuscaminasFinal;
using System.Windows.Forms;

namespace BuscaminasFinalGráfico
{
    public class WindowsFormsGame : Game<Celda>
    {
        public Game<Celda> game;
        public TableLayoutPanel cellGrid;

        public Nivel currentLevel;
        public WindowsFormsGame(int Widht, int Height, int minas, TableLayoutPanel grid) : base(Widht, Height, minas)
        {
            //atributos imagenes de la mina celda vacia y celda con banderita
            this.cellGrid = grid;

        }

        public void UpdateGrid()
        {
            int maxJ = cellGrid.RowCount - 1;
            for (int i = cellGrid.ColumnCount - 1; i >= 0; i--)
            {
                for (int j = cellGrid.RowCount; j >= 0; j--)
                {
                    CellButton tempButton = (CellButton)cellGrid.GetControlFromPosition(i, j);
                    ICell tempCell = tempButton.celdagrafica.cell;
                    switch (tempCell.GetStatus())
                    {
                        case Celda.Status.HIDDEN:
                            break;
                        case Celda.Status.SHOWN:
                            if(tempCell is Mina)
                            {
                                tempButton.Text = "*";
                            }
                            else
                            {

                            }
                            break;
                        case Celda.Status.FLAG:
                            break;
                        default:
                            break;
                    };
                }
            }
            if (Game<Celda>.currentGame.Gameover)
            {
                MessageBox.Show("Has perdido!", "Fin del juego", MessageBoxButtons.OK);

            }
        }
    }
}
