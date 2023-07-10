using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Punto
    {
        int x,y;
        public Punto() { 
            this.x=0; 
            this.y=0;
            Console.WriteLine($"Coordenada X: {x}\nCoordenada Y: {y}");
            Console.WriteLine("-------------------------------------------------------------------");
        }
        public Punto(int x, int y)
        {
            this.x=x;
            this.y=y;
            Console.WriteLine($"Coordenada X: {x}\nCoordenada Y: {y}");
            Console.WriteLine("-------------------------------------------------------------------");
        }

    }
}
