using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControlAppMVC.Models
{
    public class SingletonDB
    {
        private static SingletonDB instance;

        private List<Cliente> listaClientes = null;

        private SingletonDB()
        {
            if (listaClientes == null)
            {
                listaClientes = new List<Cliente>();
            }
        }

        public static SingletonDB Instance()
        {
            if (instance == null)
            {
                instance = new SingletonDB();
            }
            return instance;
        }

        public void AddCustumer(Cliente cliente)
        {
            listaClientes.Add(cliente);
        }

        public List<Cliente> listReturn()
        {
            return listaClientes;
        }
    }
}