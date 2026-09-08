using System;
using System.Collections.Generic;
using System.Text;

namespace PilasArreglos
{
    internal class Pilas
    {
        string[] _pila;
        int _tope;

        public Pilas(int elementos)
        {
            _pila = new string[elementos];
            _tope = 0;
        }
    }
}
