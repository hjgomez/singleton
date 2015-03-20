using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton19mar
{
    class Configurador
    {
        private String url, baseDeDatos;
        private static Configurador miConfigurador;
        private static String msg="";

        private Configurador(String url, String baseDeDatos)
        {
            this.baseDeDatos = baseDeDatos;
            this.url = url;
        }

        public static Configurador instance(String url, String baseDeDatos) 
        {
            msg = "Instancia";
            if (miConfigurador == null)
            {
                
                msg = "Primer Instancia";
                miConfigurador = new Configurador(msg, baseDeDatos);
            }
            
            return miConfigurador;
        }

        public String darUrl()
        {
            return msg;
        }
    }
}
