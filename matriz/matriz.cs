using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace puzzle
{
    class matriz
    {
       
       private Random rnd = new Random();
       public Compuesto[,] resultado= new Compuesto[4, 4];


        public matriz()
        {
             
            int ff = 16;  //numeros aleatorios
            int k = ff;  //auxiliar;
            int[] numeros = new int[ff]; 
            int res;
            for (int i = 0; i < ff; i++)
            {
                
                    numeros[i] = i + 1;
               

            }

            for (int i = 0; i < 4; i++)
            {

                for (int j = 0; j < 4; j++)
                {
                    resultado[i, j] = new Compuesto();
                    res = rnd.Next(k);
                    resultado[i,j].Numer = numeros[res];
                    numeros[res] = numeros[k - 1];
                    if (resultado[i, j].Numer==1) resultado[i, j].xi = 0; resultado[i, j].yi = 0;
                    if (resultado[i, j].Numer == 2) resultado[i, j].xi = 1; resultado[i, j].yi = 0;
                    if (resultado[i, j].Numer == 3) resultado[i, j].xi = 2; resultado[i, j].yi = 0;
                    if (resultado[i, j].Numer == 4) resultado[i, j].xi = 3; resultado[i, j].yi = 0;
                    if (resultado[i, j].Numer == 5) resultado[i, j].xi = 0; resultado[i, j].yi = 1;
                    if (resultado[i, j].Numer == 6) resultado[i, j].xi = 1; resultado[i, j].yi = 1;
                    if (resultado[i, j].Numer == 7) resultado[i, j].xi = 2; resultado[i, j].yi = 1;
                    if (resultado[i, j].Numer == 8) resultado[i, j].xi = 3; resultado[i, j].yi = 1;
                    if (resultado[i, j].Numer == 9) resultado[i, j].xi = 0; resultado[i, j].yi = 2;
                    if (resultado[i, j].Numer == 10) resultado[i, j].xi = 1; resultado[i, j].yi =2;
                    if (resultado[i, j].Numer == 11) resultado[i, j].xi = 2; resultado[i, j].yi = 2;
                    if (resultado[i, j].Numer == 12) resultado[i, j].xi = 3; resultado[i, j].yi = 2;
                    if (resultado[i, j].Numer == 13) resultado[i, j].xi = 0; resultado[i, j].yi = 3;
                    if (resultado[i, j].Numer == 14) resultado[i, j].xi = 1; resultado[i, j].yi = 3;
                    if (resultado[i, j].Numer == 15) resultado[i, j].xi = 2; resultado[i, j].yi = 3;
                    if (resultado[i, j].Numer == 16) resultado[i, j].xi = 3; resultado[i, j].yi = 3;


                    resultado[i, j].xf = j;
                    resultado[i, j].yf = i;



                    k--;
                }
            }


        }

        public Compuesto[,] mymatriz()

        {
            return resultado; }


        public Compuesto Buscar(int a)
        {
            Compuesto d=null;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {

                    if (a == resultado[i, j].Numer)
                    {
                        d= resultado[i, j];
                        
                    }
                   
                }

            }
            return d;
        }
                   
        public void Intercambiar(Compuesto a, Compuesto b)
        {
            int posax=0;
            int posay=0;
            int posbx=0;
            int posby=0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {

                    if (a.Numer == resultado[i, j].Numer)
                    {
                        posax = i;
                        posay = j;
                    }
                    if (b.Numer== resultado[i, j].Numer)
                    {
                         posbx = i;
                         posby = j;
                    }

                }

            }
            b.xf = posay;
            b.yf = posax;
            a.xf = posby;
            a.yf = posbx;
            resultado[posax, posay] = b;
            resultado[posbx, posby] = a;

        }
       

        public bool Ganador()
        {

            int contador = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {


                    if(resultado[i,j].xf== resultado[i, j].xi && resultado[i, j].yf== resultado[i, j].yi)
                    {
                        contador += 1;

                    }
                }

            }


                   if (contador == 16)
            {
                return true;
            }
            else
            {
                return false;
            }
        }







    }
}
