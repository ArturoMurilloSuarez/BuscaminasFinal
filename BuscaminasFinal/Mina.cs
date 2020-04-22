﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BuscaminasFinal
{
    public class Mina : ICell
    {
        private int posX;
        private int posY;
        private Celda.Status estado;


        public Mina()
        {
            this.estado = Celda.Status.SHOWN; //Para el principio
        }

        public int GetValue()
        {
            return 0;
        }

        public bool IsHidden()
        {
            return false;
        }

        public void LeftClick()
        {
            //Console.Clear();
            Console.WriteLine("Perdiste :(");
            Console.ReadKey();
            //this.estado = Celda.Status.SHOWN;
        }

        public void RightClick()
        {
            this.estado = Celda.Status.FLAG;

        }
        public Celda.Status GetStatus()
        {
            return this.estado;
        }
        public void Endgame()
        {
            this.estado = Celda.Status.SHOWN;
        }


    }
}