// See https://aka.ms/new-console-template for more information
using Litsa_doble_ligada;
using System;

Console.WriteLine("Hello, World!");

//parece que aqui es nuesto programa principal

int opc = 0;
int number = 0;

ListaD l = new ListaD();

do
{
    Console.Clear();
    Console.WriteLine("Lista doble ligada");
    Console.WriteLine("1. Agregar a la lista");
    Console.WriteLine("2. Eliminar listas");
    Console.WriteLine("3. Imprimir la lista");
    opc= Convert.ToInt32(Console.ReadLine()); //lectura de la consola.

    switch (opc)
    {
        case 1:
            Console.WriteLine("Digite el numero que quiere ingresar");
            number = Convert.ToInt32(Console.ReadLine());
            l.Agregar(number);
            break;
        case 2:
            l.Eliminar();
            break;
        case 3:
            l.Imprimir();
            break;
    }

} while (opc != 4);





