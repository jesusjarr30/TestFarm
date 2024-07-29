using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Litsa_doble_ligada
{
    internal class Nodo
    {
        private Nodo before { get; set; }
        private Nodo next { get; set; }
        private int number {  get; set; }

        public Nodo(Nodo before, Nodo next, int number) {

            this.number = number;
            this.next = next;
            this.before = before;
        
        }

        public Nodo GetBefore()
        {
            return before;
        }

        public void SetBefore(Nodo nodo)
        {
            before = nodo;
        }

        public Nodo GetNext()
        {
            return next;
        }

        public void SetNext(Nodo nodo)
        {
            next = nodo;
        }

        public int GetNumber()
        {
            return number;
        }

        public void SetNumber(int value)
        {
            number = value;
        }
        public void Imprimir()
        {
            Console.WriteLine("El numero es " + number);
        }
    }
}
