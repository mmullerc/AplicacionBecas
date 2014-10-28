using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer;

namespace EntitiesLayer
{
    public class Rol : IEntity
    {

        private int idRol;
        private List<Permiso> listaPermisos = new List<Permiso>();
        public int Id
        {
            get { return idRol; }
            set { idRol = value; }
        }

        public String Nombre { get; set; }

        public Rol()
        {

            Nombre = "";

        }

        public Rol(String pNombre)
        {
            Nombre = pNombre;
        }

        public List<Permiso> getListaPermisos()
        {

            return listaPermisos;

        }

        public void setListaPermisos(List<Permiso> plistaPermisos)
        {

            listaPermisos = plistaPermisos;
        }


    }
}



