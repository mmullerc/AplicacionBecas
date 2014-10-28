using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer;
using DAL.Repositories;
using System.Security.Cryptography;
using DAL;
namespace BLL
{


    public class GestorUsuario
    {
       
        public String key = "MiLLave";

        //<summary> Método que se encarga de crear un nuevo usuario</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param name = "ppNombre"> variable de tipo String que almacena el primer nombre del usuario  </param>
        //<param name= "psNombre" > variable de tipo String que almacena el segundo nombre del usuario  </param>
        //<param name = "ppApellido"> variable de tipo String que almacena el primer apellido del usuario  </param>
        //<param name = " psApellido"> variable de tipo String que almacena el segundo apellido del usuario  </param>
        //<param name = "pidentificacion"> variable de tipo String que almacena la identificación del usuario  </param>
        //<param name = " ptelefono"> variable de tipo String que almacena el número de teléfono del usuario  </param>
        //<param name = "pfechaNacimiento">  variable de tipo Date que almacena la fecha de nacimiento del usuario  </param>
        //<param name = "prol "> variable de tipo String que almacena el nombre del rol del usuario  </param>
        //<param name = "pgenero"> variable de tipo int que almacena el género del usuario  </param>
        //<param name = "pcorreoElectronico"> variable de tipo String que almacena el correo electrónico del usuario  </param>
        //<param name = "pcontraseña"> variable de tipo String que almacena la contraseña del usuario  </param>
        //<param name = "pconfirmación "> variable de tipo String que almacena la confirmación de la contraseña del usuario  </param>
        //<returns> No retorna valor.</returns> 

        public void crearUsuario(string ppNombre, String psNombre, String ppApellido, String psApellido, String pidentificacion, String ptelefono, DateTime pfechaNacimiento, String prol, int pgenero, String pcorreoElectronico, String pcontraseña, String pconfirmacion)
        {
            try
            {
                DateTime fecha = pfechaNacimiento.Date;
                Rol objRol = RolRepository.Instance.GetByNombre(prol);
                Boolean sonIguales = validarContraseñasIdenticas(pcontraseña, pconfirmacion);
                if (sonIguales == true)
                {
                    String contraseñaEncriptada = encriptar(pcontraseña);
                    Usuario objetoUsuario = ContenedorMantenimiento.Instance.crearUsuario(ppNombre, psNombre, ppApellido, psApellido, pidentificacion, ptelefono, fecha, objRol, pgenero, pcorreoElectronico, contraseñaEncriptada);
                    if (objetoUsuario.IsValid)
                    {
                        UsuarioRepository.Instance.Insert(objetoUsuario);
                    }
                    else
                    {
                        StringBuilder sb = new StringBuilder();
                        foreach (RuleViolation rv in objetoUsuario.GetRuleViolations())
                        {
                            sb.Append(rv.ErrorMessage);
                        }
                        throw new ApplicationException(sb.ToString());
                    }
                }
                else
                {
                    throw new ApplicationException("Las contraseñas ingresadas no son idénticas");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //<summary> Método que se encarga de validar si las contraseñas ingresadas por el usuario son idénticas</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param name = "pcontraseña ">  variable de tipo String que almacena la contraseña ingresada por el usuario  </param>
        //<param name = " pconfirmacion ">variable de tipo String que almacena la confirmación de la contraseña ingresada por el usuario  </param>
        //<returns> Retorna una variable booleana llamada sonIdenticas</returns> 
        public Boolean validarContraseñasIdenticas(String pcontraseña, String pconfirmacion)
        {
            Boolean sonIdenticas = true;

            if (pcontraseña.Equals(pconfirmacion))
            {
                sonIdenticas = true;
            }
            else
            {
                sonIdenticas = false;
            }

            return sonIdenticas;
        }

        //<summary> Método que se encarga de encriptar la contraseña del usuario</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param name = "texto"> variable que contiene la contraseña que se desea encriptar   </param>
        //<returns> Retorna un String con la contraseña ya encriptada</returns> 
        public string encriptar(string texto)
        {
            //arreglo de bytes donde guardaremos la llave
            byte[] keyArray;

            //arreglo de bytes donde guardaremos el texto
            //que vamos a encriptar
            byte[] Arreglo_a_Cifrar = UTF8Encoding.UTF8.GetBytes(texto);

            //se utilizan las clases de encriptación
            //provistas por el Framework
            //Algoritmo MD5
            MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
            //se guarda la llave para que se le realice
            //hashing
            keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));

            hashmd5.Clear();

            //Algoritmo 3DAS
            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();

            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            //se empieza con la transformación de la cadena
            ICryptoTransform cTransform = tdes.CreateEncryptor();

            //arreglo de bytes donde se guarda la
            //cadena cifrada
            byte[] ArrayResultado = cTransform.TransformFinalBlock(Arreglo_a_Cifrar, 0, Arreglo_a_Cifrar.Length);

            tdes.Clear();

            //se regresa el resultado en forma de una cadena
            return Convert.ToBase64String(ArrayResultado, 0, ArrayResultado.Length);
        }



        //<summary> Método que se encarga de desencriptar la contraseña del usuario</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param name = "texto">  variable que contiene la contraseña que se desea desencriptar  </param>
        //<returns> Retorna un String con la contraseña ya desencriptada</returns> 
        public string Desencriptar(string textoEncriptado)
        {
            byte[] keyArray;
            //convierte el texto en una secuencia de bytes
            byte[] Array_a_Descifrar = Convert.FromBase64String(textoEncriptado);

            //se llama a las clases que tienen los algoritmos
            //de encriptación se le aplica hashing
            //algoritmo MD5
            MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();

            keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));

            hashmd5.Clear();

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();

            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateDecryptor();

            byte[] resultArray = cTransform.TransformFinalBlock(Array_a_Descifrar, 0, Array_a_Descifrar.Length);

            tdes.Clear();
            //se regresa en forma de cadena
            return UTF8Encoding.UTF8.GetString(resultArray);
        }


        //<summary> Método que se encarga de guardar los cambios de un usuario</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param> No recibe parametros  </param>
        //<returns> No retorna valor </returns> 
        public void guardarCambios()
        {
            UsuarioRepository.Instance.Save();
            // UoW.RequisitoRepository.Save();
        }

        //<summary> Método que se encarga de buscar todos los usuarios registrados</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param > No recibe parámetros  </param>
        //<returns> Retorna una lista con los usuarios registrados</returns> 

        public IEnumerable<Usuario> buscarUsuarios()
        {
            return UsuarioRepository.Instance.GetAll();
        }

        //<summary> Método que se encarga de buscar un usuario determinado</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param name = "parametro">variable de tipo String que almacena el Nombre o la identificación del usuario deseado </param>
        //<returns> Retorna el usuario buscado</returns> 
        public Usuario buscarUnUsuario(String pparametro)
        {
            return UsuarioRepository.Instance.GetByNombre(pparametro);
        }

        //<summary> Método que se encarga de eliminar un usuario determinado</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param name = "parametro">variable de tipo String que almacena la identificación del usuario deseado </param>
        //<returns> Retorna el usuario buscado</returns>
        public void eliminarUsuario(String pparametro)
        {
            Usuario objUsuario = ContenedorMantenimiento.Instance.crearUsuario(pparametro);
            UsuarioRepository.Instance.Delete(objUsuario);

        }

        //<summary> Método que se encarga de modificar la información de un usuario</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param name = "ppNombre"> variable de tipo String que almacena el primer nombre del usuario  </param>
        //<param name= "psNombre" > variable de tipo String que almacena el segundo nombre del usuario  </param>
        //<param name = "ppApellido"> variable de tipo String que almacena el primer apellido del usuario  </param>
        //<param name = " psApellido"> variable de tipo String que almacena el segundo apellido del usuario  </param>
        //<param name = "pidentificacion"> variable de tipo String que almacena la identificación del usuario  </param>
        //<param name = " ptelefono"> variable de tipo String que almacena el número de teléfono del usuario  </param>
        //<param name = "pfechaNacimiento">  variable de tipo Date que almacena la fecha de nacimiento del usuario  </param>
        //<param name = "prol "> variable de tipo String que almacena el nombre del rol del usuario  </param>
        //<param name = "pgenero"> variable de tipo int que almacena el género del usuario  </param>
        //<param name = "pcorreoElectronico"> variable de tipo String que almacena el correo electrónico del usuario  </param>
        //<param name = "pcontraseña"> variable de tipo String que almacena la contraseña del usuario  </param>
        //<param name = "pconfirmación "> variable de tipo String que almacena la confirmación de la contraseña del usuario  </param>
        //<returns> No retorna valor.</returns> 

        public void modificarUsuario(string ppNombre, String psNombre, String ppApellido, String psApellido, String pidentificacion, String ptelefono, DateTime pfechaNacimiento, String prol, int pgenero, String pcorreoElectronico, String pcontraseña, String pconfirmacion, String pparametro)
        {
            try
            {
                DateTime fecha = pfechaNacimiento.Date;
                Rol objRol = RolRepository.Instance.GetByNombre(prol);
                Boolean sonIguales = validarContraseñasIdenticas(pcontraseña, pconfirmacion);
                if (sonIguales == true)
                {
                    String contraseñaEncriptada = encriptar(pcontraseña);
                    Usuario objetoUsuario = ContenedorMantenimiento.Instance.crearUsuario(ppNombre, psNombre, ppApellido, psApellido, pidentificacion, ptelefono, fecha, objRol, pgenero, pcorreoElectronico, contraseñaEncriptada);
                    if (objetoUsuario.IsValid)
                    {
                        UsuarioRepository.Instance.UpdateUsuario(objetoUsuario);
                    }
                    else
                    {
                        StringBuilder sb = new StringBuilder();
                        foreach (RuleViolation rv in objetoUsuario.GetRuleViolations())
                        {
                            sb.Append(rv.ErrorMessage);
                        }
                        throw new ApplicationException(sb.ToString());
                    }
                }
                else
                {
                    throw new ApplicationException("Las contraseñas ingresadas no son idénticas");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
