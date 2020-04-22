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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.Ancho_ValueChanged(this, null);
        }

        private void ClickDificultad(object sender, EventArgs e)
        {
            Nivel nivel = new Nivel();
            switch (((Button)sender).Text)
            {
                case "Fácil":
                    nivel.game = new Game<Celda>(6, 7, 10);
                    break;
                case "Normal":
                    nivel.game = new Game<Celda>(9, 10, 15);
                    break;
                case "Difícil":
                    nivel.game = new Game<Celda>(14, 15, 40);
                    break;
                case "Personalizado":
                    nivel.game = new Game<Celda>((int)Ancho.Value, (int)Alto.Value, (int)Minas.Value);
                    break;
            }
            nivel.Show();
            this.Hide();
        }

        private void Ancho_ValueChanged(object sender, EventArgs e)
        {
            this.Minas.Maximum = (this.Ancho.Value * this.Alto.Value) - 5;
        }
    }
}
