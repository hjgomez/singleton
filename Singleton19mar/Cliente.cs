using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton19mar
{
    class Cliente
    {
        public Cliente() {
            Configurador c = Configurador.instance("miUrl", "miDB");
             c = Configurador.instance("miUrl", "miDB");
             c = Configurador.instance("miUrl", "miDB");
        }
    }
}
