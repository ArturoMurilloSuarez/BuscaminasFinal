using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuscaminasFinal;

namespace BuscaminasFinalGráfico
{
    class CellButton : Button
    {
        public CellNode celdagrafica;

        public int x;
        public int y;

        public CellButton(CellNode cell)
        {
            this.Dock = DockStyle.Fill;
            this.MouseClick += new MouseEventHandler(ClickBoton);
            this.celdagrafica = cell;
            
        }

        public void ClickBoton(object sender, MouseEventArgs e)
        {
            if (celdagrafica != null)
            {
                if (e.Button == MouseButtons.Left)
                {
                    this.Text = "HOLA";
                    celdagrafica.cell.LeftClick();
                }
                else if (e.Button == MouseButtons.Right)
                {
                    celdagrafica.cell.RightClick();
                }
                ((WindowsFormsGame)Game<Celda>.currentGame).UpdateGrid(); //VEr que onda
            }
            
        }

    }
}
