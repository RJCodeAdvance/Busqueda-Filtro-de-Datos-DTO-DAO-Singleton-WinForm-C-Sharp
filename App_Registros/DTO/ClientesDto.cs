using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Registros.DTO
{
    class ClientesDto
    {
        //ATRIBUTOS 
        int  _ID;
        string _Nombre;
        string _Apellido;
        string _Direccion;
        string _Ciudad;
        string _Email;
        string _Telefono;
        string _Ocupacion;
        //PROPIEDADES GETTERS AND SETTERS
        public int ID
        {
            get
            {
                return _ID;
            }

            set
            {
                _ID = value;
            }
        }

        public string Nombre
        {
            get
            {
                return _Nombre;
            }

            set
            {
                _Nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return _Apellido;
            }

            set
            {
                _Apellido = value;
            }
        }

        public string Direccion
        {
            get
            {
                return _Direccion;
            }

            set
            {
                _Direccion = value;
            }
        }

        public string Ciudad
        {
            get
            {
                return _Ciudad;
            }

            set
            {
                _Ciudad = value;
            }
        }

        public string Email
        {
            get
            {
                return _Email;
            }

            set
            {
                _Email = value;
            }
        }

        public string Telefono
        {
            get
            {
                return _Telefono;
            }

            set
            {
                _Telefono = value;
            }
        }

        public string Ocupacion
        {
            get
            {
                return _Ocupacion;
            }

            set
            {
                _Ocupacion = value;
            }
        }
        
    }
}
