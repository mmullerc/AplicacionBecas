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
    public class RolRepository : IRepository<Rol>
    {
        private static RolRepository instance;
        private List<IEntity> _insertItems;
        private List<IEntity> _deleteItems;
        private List<IEntity> _updateItems;

        public RolRepository()
        {
            _insertItems = new List<IEntity>();
            _deleteItems = new List<IEntity>();
            _updateItems = new List<IEntity>();
        }

        public static RolRepository Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new RolRepository() { };
                }
                return instance;
            }
        }

        public void Insert(Rol entity)
        {
            _insertItems.Add(entity);
        }

        public void Delete(Rol entity)
        {
            _deleteItems.Add(entity);
        }

        public void Update(Rol entity)
        {
            _updateItems.Add(entity);
        }

        public IEnumerable<Rol> GetAll()
        {


            List<Rol> pRol = null;

            SqlCommand cmd = new SqlCommand();
            DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_ConsultarRoles");

            if (ds.Tables[0].Rows.Count > 0)
            {
                pRol = new List<Rol>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    pRol.Add(new Rol
                    {
                        Nombre = dr["Nombre"].ToString()
                    });
                }
            }

            return pRol;
        }

        public Rol GetById(int id)
        {
            Rol objRol = null;
            /*var sqlQuery = "SELECT Id, Nombre, Precio FROM Producto WHERE id = @idProducto";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.Parameters.AddWithValue("@idProducto", id);

            var ds = DBAccess.ExecuteQuery(cmd);

            if (ds.Tables[0].Rows.Count > 0)
            {
                var dr = ds.Tables[0].Rows[0];

                objMusculo = new Musculo
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    nombre = dr["nombre"].ToString(),
                    ubicacion = dr["ubicacion"].ToString(),
                    origen = dr["Origen"].ToString(),
                    insercion = dr["insercion"].ToString()
                };
            }*/

            return objRol;
        }

        public Rol GetByNombre(String pnombre)
        {
            Rol objRol = null;
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@nombre", pnombre);

            DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_BuscarRol");

            if (ds.Tables[0].Rows.Count > 0)
            {
                var dr = ds.Tables[0].Rows[0];

                objRol = new Rol
                {
                    Id = Convert.ToInt32(dr["IdRol"]),
                    Nombre = dr["Nombre"].ToString(),
                };
            }
            return objRol;
        }

        public void Save()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    if (_insertItems.Count > 0)
                    {
                        foreach (Rol objRol in _insertItems)
                        {
                            InsertRol(objRol);
                        }
                    }

                    if (_updateItems.Count > 0)
                    {
                        foreach (Rol p in _updateItems)
                        {
                            UpdateRol(p);
                        }
                    }

                    if (_deleteItems.Count > 0)
                    {
                        foreach (Rol p in _deleteItems)
                        {
                            DeleteRol(p);
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

        private void InsertRol(Rol objRol)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@Nombre", objRol.Nombre));
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_agregarRol");

            }
            catch (Exception ex)
            {

            }

        }

        private void UpdateRol(Rol objRol)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@Nombre", objRol.Nombre));
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_ModificarRol");

            }
            catch (Exception ex)
            {

            }
        }

        private void DeleteRol(Rol objRol)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@nombre", objRol.Nombre));
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_EliminarRol");

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
