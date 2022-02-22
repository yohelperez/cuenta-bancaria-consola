using System;

class Programa
{
    public static void Main()
    {
        Cuenta c1= new Cuenta();                            //creacion de objeto cuenta
        bool ban = true;                                    //bandera para dejar de hacer movimientos
        string linea;
        int nRetiros = 0;                                   //contabiliza los retiros
        int nDepositos = 0;                                 //contabiliza los depositos
        Console.Title= "Tarea 4";
        Console.WriteLine("\nAPLICACIÓN BANCARIA\n");

        Console.Write("Ingrese su nombre: ");
        c1.Nombre = Console.ReadLine();                     //asigna el nombre del usuario a la cuenta

        Console.Write("Ingrese su numero de identificación: "); 
        linea = Console.ReadLine();                         //recibe el numero de id
        c1.ID = double.Parse(linea);                        //convierte el numero id a double y lo asigna en la cuenta

        while (ban == true)                                 //mientras ban sea true seguirá haciendo movimientos
        {
            Console.WriteLine("\n=== Movimientos a la cuenta ===\n");                  //muestra opciones
            Console.WriteLine("1. Depósito \n2. Retiro \n3. Consulta de Saldo \n");
            Console.Write("Seleccione una operación <1,2,3>: ");
            linea = Console.ReadLine();

            switch (linea)
            {
                case "1": Console.Write("\nIngrese el valor del deposito: ");         //instrucciones para depositar
                    linea = Console.ReadLine();
                    c1.Saldo += double.Parse(linea);
                    Console.Write("\nTransacción realizada exitosamente!\n");
                    nDepositos += 1;
                    break;

                case "2": Console.Write("\nIngrese el valor del retiro: ");          //instrucciones para retirar
                    linea = Console.ReadLine();
                    if(c1.Saldo >= double.Parse(linea))                              //caso en que  tiene saldo suficiente
                    {
                        c1.Saldo -= double.Parse(linea);
                        Console.Write("\nTransaccion realizada exitosamente!\n");
                        nRetiros += 1;
                    }

                    else                                                            //caso en que no tiene saldo suficiente
                    {
                        Console.Write("\nSaldo insuficiente. No se pudo realizar el retiro\n");
                    }

                    break;

                case "3": Console.WriteLine("\nEl saldo es: " + c1.Saldo + "\n");    //informa del saldo 
                    break;
            }

            Console.Write("Desea realizar más movimientos? <S/N>: ");               //pregunta para seguir haciendo mtos
            linea = Console.ReadLine();
            if(linea == "N" || linea == "n")
            {
                ban = false;
            }

            Console.Clear();
        }

        Console.WriteLine("\n--- RESULTADOS FINALES ---\n");                       //informacion de la cuenta
        Console.WriteLine("Cliente: " + c1.Nombre + ", con número de identificación: " + c1.ID + "\n");
        Console.WriteLine("El saldo de la cuenta es: " + c1.Saldo);
        Console.WriteLine("La cantidad de depositos fue de: " + nDepositos);
        Console.WriteLine("La cantidad de retiros fue de: " + nRetiros);
        Console.ReadLine();
    }
}