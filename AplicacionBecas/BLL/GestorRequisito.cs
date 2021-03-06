﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer;
using DAL.Repositories;

namespace BLL
{
    public class GestorRequisito
    {
      
        //<summary> Método que se encarga de un nuevo Requisito</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param name = "ppNombre"> variable de tipo String que almacena el nombre del requisito  </param>
        //<param name= "pdescripcion" > variable de tipo String que almacena la descripción del requisito  </param>
        //<returns>No retorna valor</returns> 

        public IEnumerable<Requisito> consultarRequisitos()
        {

            return RequisitoRepository.Instance.GetAll();

        }

        public void crearRequisito(String pnombre, String pdescripcion)
        {

            Requisito objRequisito = ContenedorMantenimiento.Instance.crearRequisito(pnombre, pdescripcion);

            try
            {
                //Requisito objRequisito = contenedor.crearRequisito(pnombre, pdescripcion);
                if (objRequisito.IsValid)
                {
                    RequisitoRepository.Instance.Insert(objRequisito);
                    //UoW.RequisitoRepository.Insert(objRequisito);
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (RuleViolation rv in objRequisito.GetRuleViolations())
                    {
                        sb.Append(rv.ErrorMessage);
                    }
                    throw new ApplicationException(sb.ToString());
                }
            }

            catch (Exception)
            {
                throw;
            }
        }

        //<summary> Método que se encarga de guardar los cambios de un requisito</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param> No recibe parametros  </param>
        //<returns> No retorna valor </returns> 
        public void guardarCambios()
        {
            RequisitoRepository.Instance.Save();
            // UoW.RequisitoRepository.Save();
        }
    }
}
