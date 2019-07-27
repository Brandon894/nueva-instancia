using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace instancias
{
    class Program
    {
        static void Main(string[] args)
        {

            cajas nueva_caja = new cajas("40","40","20");
            nueva_caja.caja();

            cajas segunda_caja = new cajas("40","30","10", " Azul ");
            segunda_caja.caja2();

            cajas tercera_caja = new cajas("50", "45", "20", "cafe"," ", "De solapas", "Sabritas", " Arriba ");
            Console.WriteLine();
            Console.Write("                        Tercera Caja           ");
            tercera_caja.caja3();
      
            cajas cuarta_caja = new cajas("80","80","50","cafe","carton ","Con Tapadera", "Paccsa", " ");
            Console.WriteLine();
            Console.Write("                        Cuarta Caja           ");
            cuarta_caja.caja3();          
        }
        public class cajas
        {
            public cajas(string altura, string ancho, string profundidad)
            {
                this.altura = altura;
                this.ancho = ancho;
                this.profundidad = profundidad;
            }

            public cajas(string altura, string ancho, string profunidad, string color)
            {
                this.altura = altura;
                this.ancho = ancho;
                this.profundidad = profundidad;
                this.color = color;
            }

            public cajas(string altura, string ancho, string profundidad, string color, string Tipo_de_material, string estructura, string empresa)
            {
                this.altura = altura;
                this.ancho = ancho;
                this.profundidad = profundidad;
                this.color = color;
                this.Tipo_de_material = Tipo_de_material;
                this.estructura = estructura;
                this.empresa = empresa;
                this.abertura = abertura;
                this.color = color;
                if (color == "cafe")
                {
                    this.Tipo_de_material = "carton";

                }
                else if (this.color == "rojo")
                {
                    this.Tipo_de_material = "metal";
                }
                if  (this.Tipo_de_material == "carton")
                {
                    this.abertura = " Arriba ";
                }
            }
          
            public string color { get; set; }  
            public string  altura { get; set; } 
            public string ancho { get; set; }
            public string profundidad { get; set; }
            public string Tipo_de_material { get; set; }
            public string estructura { get; set; }
            public string empresa { get; set; }
            public string abertura { get; set; }

            public void caja()
            {
                Console.WriteLine();
                Console.WriteLine("                       Primera Caja             ");
                Console.WriteLine(" Altura: "+ this.altura + " Ancho: "+ this.ancho + " Profunidad: "+ this.profundidad);
                Console.ReadKey();
            }
            public void caja2()
            {
                Console.WriteLine();
                Console.WriteLine("                       Segunda Caja            ");
                Console.WriteLine(" Altura: " + this.altura + " Ancho: " + this.ancho + " Profunidad: " + this.profundidad+ " Color: " +this.color );
                Console.ReadKey();
            }
            public void caja3()
            {
                Console.WriteLine();
                Console.WriteLine(" Altura: " + this.altura + " Ancho: " + this.ancho + " Profunidad: " + this.profundidad + " Color: " + this.color + " Tipo de Material: " + this.Tipo_de_material + " Estructura: " + this.estructura + " Empresa: " + this.empresa + " Se abre: " + this.abertura);
                Console.ReadKey();

            }
        }
    }
}
