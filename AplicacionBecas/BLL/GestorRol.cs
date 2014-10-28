using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntitiesLayer;
using DAL;
using System.Collections;


namespace BLL
{
    public class GestorRol
    {
        public void agregarRol(string pnombre)
        {
            try
            {

                Rol objRol = ContenedorMantenimiento.Instance.crearObjetoRol(pnombre);
                //if (objRol.IsValid)
                //{
                RolRepository.Instance.Insert(objRol);
                //    }
                //    else
                //    {
                //        StringBuilder sb = new StringBuilder();
                //        foreach (RuleViolation rv in objMusculo.GetRuleViolations())
                //        {
                //            sb.AppendLine(rv.ErrorMessage);
                //        }
                //        throw new ApplicationException(sb.ToString());
                //    }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void modificarRol(string pnombre)
        {

            Rol objRol = ContenedorMantenimiento.Instance.crearObjetoRol(pnombre);
            RolRepository.Instance.Update(objRol);

        }

        public void eliminarRol(String pnombre)
        {
            /////////////////////////////////////
            Rol objRol = ContenedorMantenimiento.Instance.crearObjetoRol(pnombre);
            //Rol objRol = new Rol { Id = idRol };
            RolRepository.Instance.Delete(objRol);
        }

        public IEnumerable<Rol> consultarRoles()
        {
            return RolRepository.Instance.GetAll();
        }

        public IEnumerable<Permiso> consultarPermisos()
        {
            return PermisoRepository.Instance.GetAll();
        }

        public Rol consultarRolPorNombre(String pnombre)
        {
            return RolRepository.Instance.GetByNombre(pnombre);
        }



        public void guardarCambios()
        {
            //try
            //{
            RolRepository.Instance.Save();
            //    }
            //    catch (DataAccessException ex)
            //    {
            //        throw ex;
            //    }
            //    catch (Exception ex)
            //    {
            //        //logear a la bd
            //        throw new BusinessLogicException("Ha ocurrido un error al eliminar un usuario", ex);
            //    }
        }



    }
}
