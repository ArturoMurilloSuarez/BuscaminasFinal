using System;
using System.Collections.Generic;
using System.Text;

namespace BuscaminasFinal
{
    public class Game<T> where T : ICell, new()
    {
        protected int TotalMinas;

        public int FlagCounter; // = 10
        public int MineCounter;

        protected int Width;
        protected int Height;
        public CellNode[,] celdas; //arreglo sin iniciar tamaño, ojo.

        public List<int> minaspos = new List<int>();

        public bool gameover = false;
        public bool wingame = false;

        public bool firstMove = true;

        public bool isPlaying = true;

        static public Game<Celda> currentGame;

        public Game(int Widht, int Height, int minas) //Agregar primer movimiento
        {
            this.Width = Widht;
            this.Height = Height;
            this.TotalMinas = minas;
            this.FlagCounter = minas;
            this.MineCounter = minas;

            this.celdas = new CellNode[Widht, Height]; //matriz que contiene nuestras celdas y nuestras minas CON ESTA TRABAJAR LAS COORDENADAS
            for (uint i = 0; i < this.Width; i++)
            {
                for (int j = 0; j < this.Height; j++)
                {
                    this.celdas[i, j] = new CellNode(new T()); //llama al constructor de NodeCell, pasandole newT
                } //crea objetos tipo CellNode
            }
            //this.GetNeighbors

            //this.GenerateMines(); //Agregar primer movimiento

        }

        public int FlagCount
        {
            get { return this.FlagCounter; }
        }

        public int HeightGetter
        {
            get { return this.Height; }
        }

        public int WidthGetter
        {
            get { return this.Width; }
        }

        public void AddFlag()
        {
            this.FlagCounter--;
        }

        public void RemoveFlag()
        {
            this.FlagCounter++;
        }

        public void AddMineCount() //añade bandera, solo en minas
        {
            if (--this.MineCounter == 0)
            {
                this.isPlaying = false;
            }
        }

        public void RemoveMIneCount()
        {
            this.MineCounter++;
        }

        public bool GameOver
        {
            get { return this.gameover; }
            set
            {
                this.gameover = true;
                this.isPlaying = false;
            }
        }

        private void Format()
        {

        }

        public string Tiempo()
        {
            get { return }

        }

        public void GenerateMines(int initPosX, int initPosY)
        {
            Random random = new Random();
            List<CellNode> list = new List<CellNode>(); //Guarda todas las posiciones celdas que ya se generaron en una lista
            for (uint i = 0; i < this.Width; i++) //Aqui solo las va agregando
            {
                for (uint j = 0; j < this.Height; j++)
                {
                    if (i == initPosX && j == initPosY)
                    {
                        continue;
                    }
                    list.Add(this.celdas[i, j]);
                }
            } //YA tiene una lista del tamaño de la cantidad de posiciones que hay
            int pos;
            for (uint i = 0; i < this.TotalMinas; i++)
            {
                pos = random.Next(0, list.Count); //Genera un numero aleatorio teniendo limite el tamaño de la lista
                list[pos].cell = new Mina(); //en esa posicion crea/pone una mina
                list.RemoveAt(pos); //quita esa posicion de la lista para que no se vuelva a elegir
                this.minaspos.Add(pos); //No puedo trabajar con esa lista porque su numeracion cambia con cada iteracion
            }
        }

        public void Accion(int x, int y)
        {
            if (this.celdas[x, y].cell is Mina)
            {
                for (uint i = 0; i < this.Width; i++)
                {
                    for (uint j = 0; j < this.Height; j++) //POner en leftclick
                    {
                        celdas[i, j].cell.Endgame();
                    }
                }
                gameover = true;
                //this.celdas[x, y].cell.LeftClick();
            }
            if (this.celdas[x, y].cell is Celda)
            {
                this.celdas[x, y].cell.LeftClick(); //Falta programar eso
            }
        }

        public void Accion2(int x, int y)
        {
            if (this.celdas[x, y].cell is Mina)
            {
                this.celdas[x, y].cell.RightClick();
                this.MineCounter = this.MineCounter - 1;
                if (this.MineCounter == 0)
                {
                    wingame = true;
                    for (uint i = 0; i < this.Width; i++)
                    {
                        for (uint j = 0; j < this.Height; j++) //POner en rightclick
                        {
                            celdas[i, j].cell.Endgame();
                        }
                    }

                }

            }
            if (this.celdas[x, y].cell is Celda)
            {
                this.celdas[x, y].cell.RightClick();
            }
        }

        public void MostarLosDeLado()
        {
        //    class Enteros
        //{
        //    int valor;
        //    public Enteros(int val)
        //{
        
        //}
        //}
            
        // class Program   
            
            int[,] mat = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9, } };
            Console.Write("x: ");
            int posX = int.Parse(Console.ReadLine());
            Console.Write("y: ");
            int posY = int.Parse(Console.ReadLine());

            List<int> lista = new List<int>();

        }





    }
}