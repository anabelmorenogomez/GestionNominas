using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNominasV1
{
    public class Nomina
    {
        // Miembros privados de la clase 
        private string _nombre;
        private string _apellidos;
        private string _puesto;
        private int _horasTrabajadas;
        private float _salariohora;

        // Propiedades
        /// <summary>
        /// Nombre del Empleado 
        /// </summary>
        public string NombreEmpelado
        {
            get {
                // Control de contenido 
                if (string.IsNullOrEmpty(_nombre)) throw new Exception("Nombre del trabajador no establecido");
                // Devolucion del valor 
            return _nombre;
            }
            set {
                // Validación de los datos a establecer 
                if (string.IsNullOrEmpty(value)) throw new Exception("El nombre del trabjador no puede ser null o la cadena vacía");
                {
                    
                }
                // Establecimiento del valor al miembro privado 
                _nombre = value;
            }
        }
    }
}
