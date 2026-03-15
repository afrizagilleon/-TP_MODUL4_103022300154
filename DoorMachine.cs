using System;
using System.Collections.Generic;
using System.Text;

namespace TP_MODUL4_103022300154
{
    internal class DoorMachine
    {
        private enum State
        {
            Terkunci,
            Terbuka
        }

        private State currentState;

        public DoorMachine()
        {
            currentState = State.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }

        public void KunciPintu()
        {
            currentState = State.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }

        public void BukaPintu()
        {
            currentState = State.Terbuka;
            Console.WriteLine("Pintu tidak terkunci");
        }
    }
}
