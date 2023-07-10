using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    internal class Punto
    {
        int x, y;
        static int contadorInstancias = 0;


        public Punto()
        {
            this.x=0; 
            this.y=0;
            contadorInstancias++;

        }

       public Punto(int x, int y)
        {
            this.x = x; 
            this.y = y;
            contadorInstancias++;

        }

        public int getContadorInstancias()
        {
            //int ci = contadorInstancias;
            return contadorInstancias;
        }
    
    }//Class Punto

    
}
