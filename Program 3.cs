using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {

            string dato = "";
            int tamaño = 0;
            int actividad = 0;
            int tipo = 0;
            int opcion = 0;
            int tamaño = 0;
            int meses = 0;
            double peso = 0.0;

            do
            {

                Console.WriteLine("¡Hola, buen dia amo. Te habla Pinky el ayudante de la empresa dog.ve");
                Console.WriteLine("En esta ocasion te ayudare a saber que cantidad de comida le debes dar a tu amigo peludo");

                Console.WriteLine("Si su perro es un adulto escriba 1 y su su perro es un cachorro escriba 2");
                dato = Console.ReadLine();
                tipo = Convert.ToInt32(dato);

                if (tipo == 1) ;
                {
                    Console.WriteLine("Ingrese el peso de su perro");
                    dato = Console.ReadLine();
                    peso = Convert.ToDouble(dato);

                    Console.WriteLine("Si considera la actividad de su perro alta seleccione 1, si es normal 2 y si es baja 3");
                    dato = Console.ReadLine();
                    actividad = Convert.ToInt32(dato);




                    if (peso <= 5 && peso >= 2) ;
                    {
                        Console.WriteLine("Su perro es tamaño miniatura");
                        switch (actividad)
                        {
                            case 1:
                                Console.WriteLine("Su perro debe comer entre 60-115 gramos de alimento");
                                break;
                            case 2:
                                Console.WriteLine("Su perro debe comer entre 55-100 gramos de alimento");
                                break;
                            case 3:
                                Console.WriteLine("Su perro debe comer entre 55-100 gramos de alimento");
                                break;
                        }
                    }




                    if (peso <= 10 && peso >= 5) ;
                    {
                        Console.WriteLine("Su perro es tamaño pequeño");
                        switch (actividad)
                        {
                            case 1:
                                Console.WriteLine("Su perro debe comer entre 115-190 gramos de alimento");
                                break;
                            case 2:
                                Console.WriteLine("Su perro debe comer entre 100-170 gramos de alimento");
                                break;
                            case 3:
                                Console.WriteLine("Su perro debe comer entre 85-145 gramos de alimento");
                                break;
                        }
                    }



                    if (peso <= 15 && peso >= 10) ;
                    {
                        Console.WriteLine("Su perro es tamaño mediano");
                        switch (actividad)
                        {
                            case 1:
                                Console.WriteLine("Su perro debe comer entre 190-255 gramos de alimento");
                                break;
                            case 2:
                                Console.WriteLine("Su perro debe comer entre 170-225 gramos de alimento");
                                break;
                            case 3:
                                Console.WriteLine("Su perro debe comer entre 145-195 gramos de alimento");
                                break;
                        }
                    }


                    if (peso <= 25 && peso >= 15) ;
                    {
                        Console.WriteLine("Su perro es tamaño grande");
                        switch (actividad)
                        {
                            case 1:
                                Console.WriteLine("Su perro debe comer entre 255-380 gramos de alimento");
                                break;
                            case 2:
                                Console.WriteLine("Su perro debe comer entre 225-330 gramos de alimento");
                                break;
                            case 3:
                                Console.WriteLine("Su perro debe comer entre 195-285 gramos de alimento");
                                break;
                        }
                    }


                    if (peso <= 40 && peso >= 25) ;
                    {
                        Console.WriteLine("Su perro es tamaño grande");
                        switch (actividad)
                        {
                            case 1:
                                Console.WriteLine("Su perro debe comer entre 380-535 gramos de alimento");
                                break;
                            case 2:
                                Console.WriteLine("Su perro debe comer entre 330-475 gramos de alimento");
                                break;
                            case 3:
                                Console.WriteLine("Su perro debe comer entre 285-410 gramos de alimento");
                                break;
                        }
                    }


                    if (peso <= 55 && peso >= 40) ;
                    {
                        Console.WriteLine("Su perro es tamaño grande");
                        switch (actividad)
                        {
                            case 1:
                                Console.WriteLine("Su perro debe comer entre 535-680 gramos de alimento");
                                break;
                            case 2:
                                Console.WriteLine("Su perro debe comer entre 475-600 gramos de alimento");
                                break;
                            case 3:
                                Console.WriteLine("Su perro debe comer entre 410-520 gramos de alimento");
                                break;
                        }
                    }



                    if (peso <= 70 && peso >= 55) ;
                    {
                        Console.WriteLine("Su perro es tamaño grande");
                        switch (actividad)
                        {
                            case 1:
                                Console.WriteLine("Su perro debe comer entre 680-820 gramos de alimento");
                                break;
                            case 2:
                                Console.WriteLine("Su perro debe comer entre 600-720 gramos de alimento");
                                break;
                            case 3:
                                Console.WriteLine("Su perro debe comer entre 620-750 gramos de alimento");
                                break;
                        }
                    }

                    if (peso <= 90 && peso >= 70) ;
                    {
                        Console.WriteLine("Su perro es tamaño grande");
                        switch (actividad)
                        {
                            case 1:
                                Console.WriteLine("Su perro debe comer entre 820-985 gramos de alimento");
                                break;
                            case 2:
                                Console.WriteLine("Su perro debe comer entre 720-870 gramos de alimento");
                                break;
                            case 3:
                                Console.WriteLine("Su perro debe comer entre 620-750 gramos de alimento");
                                break;
                        }
                    }
                }
            }

                else
                {
                    Console.WriteLine("Ingrese el tamaño de su perro");
                    Console.WriteLine("Si es miniatura escriba 1");
                    Console.WriteLine("Si es pequeño escriba 2");
                    Console.WriteLine("Si es mediano escriba 3");
                    Console.WriteLine("Si es grande escriba 4");
                    dato = Console.ReadLine();
                    tamaño = Convert.ToInt32(dato);

                    Console.WriteLine("Ingrese los meses de su perro");
                    Console.WriteLine("Si es 2 escriba 1");
                    Console.WriteLine("Si es 3 escriba 2");
                    Console.WriteLine("Si es 4 escriba 3");
                    Console.WriteLine("Si es 5 escriba 4");
                    Console.WriteLine("Si es 6-12 escriba 5");
                    dato = Console.ReadLine();
                    meses = Convert.ToInt32(dato);

                    if (tamaño==1) ;
                    {
                        Console.WriteLine("El peso ideal de su perro debe ser 2 kg");
                        switch (meses)
                        {
                            case 1:
                                Console.WriteLine("Su perro debe comer 50 gramos de alimento");
                                break;
                            case 2:
                                Console.WriteLine("Su perro debe comer 60 gramos de alimento");
                                break;
                            case 3:
                                Console.WriteLine("Su perro debe comer 60 gramos de alimento");
                                break;
                            case 4:
                                Console.WriteLine("Su perro debe comer 60 gramos de alimento");
                                break;
                            case 5:
                                Console.WriteLine("Su perro debe comer 55 gramos de alimento");
                                break;
                        }
                    }
                    if (tamaño == 2) ;
                    {
                        Console.WriteLine("El peso ideal de su perro debe ser 5-10 kg");
                        switch (meses)
                        {
                            case 1:
                                Console.WriteLine("Su perro debe comer entre 95-155 gramos de alimento dependiendo de su peso ideal");
                                break;
                            case 2:
                                Console.WriteLine("Su perro debe comer entre 110-185 gramos de alimento dependiendo de su peso ideal");
                                break;
                            case 3:
                                Console.WriteLine("Su perro debe comer entre 115-195 gramos de alimento dependiendo de su peso ideal");
                                break;
                            case 4:
                                Console.WriteLine("Su perro debe comer entre 115-190 gramos de alimento dependiendo de su peso ideal");
                                break;
                            case 5:
                                Console.WriteLine("Su perro debe comer entre 110-185 gramos de alimento dependiendo de su peso ideal");
                                break;
                        }
                    }
                    if (tamaño == 3) ;
                    {
                        Console.WriteLine("El peso ideal de su perro debe ser 17-25-32-40 kg");
                        switch (meses)
                        {
                            case 1:
                                Console.WriteLine("Su perro debe comer entre 215-270-300-355 gramos de alimento dependiendo de su peso ideal");
                                break;
                            case 2:
                                Console.WriteLine("Su perro debe comer entre 265-350-400-475 gramos de alimento dependiendo de su peso ideal");
                                break;
                            case 3:
                                Console.WriteLine("Su perro debe comer entre 285-375-445-525 gramos de alimento dependiendo de su peso ideal");
                                break;
                            case 4:
                                Console.WriteLine("Su perro debe comer entre 285-375-450-530 gramos de alimento dependiendo de su peso ideal");
                                break;
                            case 5:
                                Console.WriteLine("Su perro debe comer entre 280-370-450-530 gramos de alimento dependiendo de su peso ideal");
                                break;
                        }
                    }
                    if (tamaño == 4) ;
                    {
                        Console.WriteLine("El peso ideal de su perro debe ser 50-60-70-90 kg");
                        switch (meses)
                        {
                            case 1:
                                Console.WriteLine("Su perro debe comer entre 405-450-485-560 gramos de alimento dependiendo de su peso ideal");
                                break;
                            case 2:
                                Console.WriteLine("Su perro debe comer entre 545-605-670 gramos de alimento dependiendo de su peso ideal");
                                break;
                            case 3:
                                Console.WriteLine("Su perro debe comer entre 610-685 gramos de alimento dependiendo de su peso ideal");
                                break;
                            case 4:
                                Console.WriteLine("Su perro debe comer entre 625 gramos de alimento");
                                break;
                            case 5:
                                Console.WriteLine("");
                                break;
                        }
                    }







                }
                }




                Console.WriteLine("Si desea continuar escriba 1 de lo contrario escriba 5");
                dato = Console.ReadLine();
                opcion = Convert.ToInt32(dato);

                Console.Clear();


            } while (opcion != 5);
            
        }
    }
}
