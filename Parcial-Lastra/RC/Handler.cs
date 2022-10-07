using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial_Lastra.RC
{
    public abstract class Handler
    {
        protected Handler successor;
        public void SetSuccessor(Handler successor)
        {
            this.successor = successor;
        }
        public abstract void HandleRequest(double montoARetornar, Dictionary<int, int> cantidadPorBillete);
    }
}
