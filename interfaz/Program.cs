using System;

namespace interfaz
{
    class Program
    {
        public interface IBebida
        {
            int Cantidad {get; set;}
            
        }

        public interface IBebidaAlcoholica:IBebida{
            int Alcohol {get; set;} 
            string Presentacion {get; set;} 
            string Marca {get; set;} 

            void Llenar( int Cantidad);
        }

        public class Cerveza : IBebidaAlcoholica
        {
            public int Cantidad { get; set; }
            public int Alcohol { get; set; }
            public string Presentacion { get; set; }
            public string Marca { get; set; }

            public void Llenar(int Cantidad)
            {
                Cantidad -=10;
            }
        }

        public class Tepache : IBebidaAlcoholica{
            public int Cantidad { get; set; }
            public int Alcohol { get; set; }
            public string Presentacion { get; set; }
            public string Marca { get; set; }

            public void Llenar(int Cantidad)
            {
                Cantidad -=10*2;
            }
        }






        static void Main(string[] args)
        {
            IBebidaAlcoholica Tecate = new Cerveza();
            IBebidaAlcoholica Juguito = new Tepache();


        }
    }
}
