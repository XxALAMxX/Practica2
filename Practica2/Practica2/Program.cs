using System;

namespace Practica2
{
    class Practica2
    {
        public void Reloj(){
                //Opcion 1 Solo la Hora:
                //Console.WriteLine(DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second);
                //Opcion 2 Fecha y Hora:
                Console.WriteLine(DateTime.Now);
                System.Threading.Thread.Sleep(3000);
                Console.Clear();
        }
        
        public void Cronometro() {
            int m=0, s=0, ms=0;
            ConsoleKeyInfo x;
            bool bandera = true;
            x = Console.ReadKey();
            while(bandera != false)
            {     
                if (m < 10)
                    Console.Write("0" + m + ":");
                else
                    Console.Write(m + ":");
                if (s < 10)
                    Console.Write("0" + s + ":");
                else
                    Console.Write(s + ":");
                if (ms < 10)
                    Console.Write("0" + ms);
                else
                    Console.Write(ms);
                System.Threading.Thread.Sleep(10);
                Console.Clear();
                    ms++;
                if (ms > 99)
                {
                    ms = 0;
                    s++;
                }
                if (s > 59)
                {
                    s = 0;
                    m++;
                }
                if (m > 59)
                {
                    break;
                }
            }
        }

        static void Main(string[] args)
        {
            int opc;
            Practica2 reloj = new Practica2();
            Console.WriteLine("***Menu*** \n1.- Reloj \n2.- Cronometro");
            opc = int.Parse(Console.ReadLine());
            System.Console.Clear();
            switch (opc){
                case 1:
                    reloj.Reloj();
                    break;
                case 2:
                    reloj.Cronometro();
                    break;
            }
            Console.ReadLine();
        }
    }
}
