using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Litsa_doble_ligada
{
    internal class ListaD
    {
        private Nodo inicio { get; set;}


        public ListaD()
        {
            inicio = null;

        }

        public void Agregar(int numero)
        {
            if (inicio == null)
            {
                //Agregar si la lista esta vacia
                inicio = new Nodo(null, null, numero);
            }
            else
            {
                Nodo aux = inicio;
                inicio = new Nodo(null, aux, numero);
                aux.SetBefore(inicio);
            }

        }
        public void Eliminar(int number)
        {
            //se ingresa el numero que se quiere eliminar 

            Nodo aux = inicio;

            while (aux != null)
            {
                if (aux.GetNumber() == number)
                {
                    //eliminar el nodo que se encontro
                    Nodo anterior = aux.GetBefore();
                    Nodo sigueinte = aux.GetNext();
                    break;
                }
            }
        }

        public void Imprimir()
        {
            Nodo aux = inicio;

            //hacer el ciclo que permite acceder a los datos
            while (aux != null)
            {
                aux.Imprimir();
                aux = aux.GetNext();

            }
            Console.ReadKey();

        }

    }
}
