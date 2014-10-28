using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntitiesLayer;
using System.Collections;
using System.Transactions;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class PermisoRepository : IRepository<Permiso>
    {

        private List<IEntity> _insertItems;
        private List<IEntity> _deleteItems;
        private List<IEntity> _updateItems;
        private static PermisoRepository instance;
        public PermisoRepository()
        {

            _insertItems = new List<IEntity>();
            _deleteItems = new List<IEntity>();
            _updateItems = new List<IEntity>();
        }
        public static PermisoRepository Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new PermisoRepository() { };
                }
                return instance;
            }
        }

        public void Insert(Permiso entity)
        {
            _insertItems.Add(entity);
        }

        public void Delete(Permiso entity)
        {
            _deleteItems.Add(entity);
        }

        public void Update(Permiso entity)
        {
            _updateItems.Add(entity);
        }

        public IEnumerable<Permiso> GetAll()
        {


            List<Permiso> pPermiso = null;

            SqlCommand cmd = new SqlCommand();
            DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_ConsultarPermisos");



            if (ds.Tables[0].Rows.Count > 0)
            {
                pPermiso = new List<Permiso>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    pPermiso.Add(new Permiso
                    {
                        //Id = Convert.ToInt32(dr["idPermiso"]),
                        Nombre = dr["Nombre"].ToString()
                    });
                }
            }

            return pPermiso;
        }

        public Permiso GetById(int id)
        {
            Permiso objPermiso = null;

            return objPermiso;
        }


        public Permiso GetByNombre(String pnombre)
        {
            Permiso objPermiso = null;
            var sqlQuery = "";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.Parameters.AddWithValue("@idPermiso", pnombre);

            var ds = DBAccess.ExecuteQuery(cmd);

            if (ds.Tables[0].Rows.Count > 0)
            {
                var dr = ds.Tables[0].Rows[0];

                objPermiso = new Permiso
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    Nombre = dr["Nombre"].ToString()
                };
            }



            return objPermiso;
        }

        public void Save()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    if (_insertItems.Count > 0)
                    {
                        foreach (Permiso objPermiso in _insertItems)
                        {
                            InsertPermiso(objPermiso);
                        }
                    }

                    if (_updateItems.Count > 0)
                    {
                        foreach (Permiso p in _updateItems)
                        {
                            UpdatePermiso(p);
                        }
                    }

                    if (_deleteItems.Count > 0)
                    {
                        foreach (Permiso p in _deleteItems)
                        {
                            DeletePermiso(p);
                        }
                    }

                    scope.Complete();
                }
                catch (TransactionAbortedException ex)
                {

                }
                catch (ApplicationException ex)
                {

                }
                finally
                {
                    Clear();
                }

            }
        }

        public void Clear()
        {
            _insertItems.Clear();
            _deleteItems.Clear();
            _updateItems.Clear();
        }

        private void InsertPermiso(Permiso objHueso)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@nomb", objHueso.Nombre));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_agregarPermiso");

            }
            catch (Exception ex)
            {

            }

        }

        private void UpdatePermiso(Permiso objPermiso)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@nomb", objPermiso.Nombre));


                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_modificarPermiso");

            }
            catch (Exception ex)
            {
                //throw new DataAccessException("No se pudó modificar el Permiso", ex);
            }
        }

        private void DeletePermiso(Permiso objPermiso)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@", objPermiso.Id));
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_borrarPermiso");

            }
            catch (SqlException ex)
            {
                //logear la excepcion a la bd con un Exception
                //throw new DataAccessException("Ha ocurrido un error al eliminar un usuario", ex);

            }
            catch (Exception ex)
            {
                //logear la excepcion a la bd con un Exception
                //throw new DataAccessException("Ha ocurrido un error al eliminar un usuario", ex);
            }
        }

    }
}
