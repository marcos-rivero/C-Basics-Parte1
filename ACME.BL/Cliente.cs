using System.Collections.Generic;

namespace ACME.BL
{
    public class Cliente
    {
        public Cliente()
        {

        }
        public Cliente(int clienteID)
        {
            ClienteID = clienteID; 
        }
        #region Atributos
        private string _apellido;
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        public int ClienteID { get; private set; }
        public string Nombre { get; set; }
        public string DireccionDeMail { get; set; }
        public string NombreCompleto
        {
            //get {return Apellido + ", " + Nombre;}
            //get {
            //    string nombreCompleto = Nombre;
            //    if (!string.IsNullOrWhiteSpace(Apellido))
            //    {
            //        nombreCompleto += ", " + Apellido;
            //    }
            //    return nombreCompleto;
            //}
            get
            {
                string nombreCompleto = Apellido;
                if (!string.IsNullOrWhiteSpace(Nombre))
                {
                    if (!string.IsNullOrWhiteSpace(nombreCompleto))
                    {
                        nombreCompleto += ", ";
                    }
                    nombreCompleto += Nombre;
                }
                return nombreCompleto;
            }
        }
        public static int InstanceCount { get; set; }
        #endregion
        #region Metodos
        /// <summary>
        /// Valida el apellido y la direccion de mail no sean vacias, nulas.
        /// </summary>
        /// <returns>bool</returns>
        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(Apellido)) isValid = false;
            if (string.IsNullOrWhiteSpace(DireccionDeMail)) isValid = false;
            return isValid;
        }
        /// <summary>
        /// Retorna un cliente especifico
        /// </summary>
        /// <param name="CustomerId">Identificador de cliente</param>
        public Cliente Retrieve(int clienteId)
        {
            // codigo que retorna un cliente
            return new Cliente();
        }

        /// <summary>
        /// Retorna todos los clientes
        /// </summary>
        public List<Cliente> Retrieve()
        {
            // codigo que retorna un cliente
            return new List<Cliente>();
        }

        /// <summary>
        /// Guarda el cliente en la base de datos
        /// </summary>
        public bool Save(Cliente cliente)
        {
            // codigo que guarda el cliente en la BD
            return true;
        }
        #endregion
    }
}
