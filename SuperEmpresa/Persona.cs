using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperEmpresa
{
    /* 
        Consigna:
        ---------------------
        Modelar la clase Persona con las siguientes condiciones:
            - Atributos: nombre, e-mail, sueldo, sexo, peso y altura. 
            * Pensar qué modificador de visibilidad es el más adecuado junto 
            con el tipo de cada uno ya que no se debe acceder a sus atributos 
            directamente.

            - Implementar un constructor que defina todos los atributos por 
            parámetro salvo el e-mail que se especifica luego.
               
            - Implementar los siguientes métodos:
                + Todos los métodos Getters, No implementar Setters.
                + CrearEmail():  Crea el e-mail de la persona a partir del 
                nombre + @superempresa.com. Este método es privado y se llama 
                por medio del constructor.
    */

    class Persona
    {
        private string _nombre;
        private string _email;
        private float _sueldo;
        private string _sexo;
        private float _peso;
        private float _altura;

        public Persona(string nombre, float sueldo, string sexo, float peso, float altura)
        {
            _nombre = nombre;
            _sueldo = sueldo;
            _sexo = sexo;
            _peso = peso;
            _altura = altura;

            CrearEmail();
        }

        public string GetNombre() { return _nombre; }
        public string GetEmail() { return _email; }
        public float GetSueldo() { return _sueldo; }
        public string GetSexo() { return _sexo; }
        public float GetPeso() { return _peso; }
        public float GetAltura() { return _altura; }

        private void CrearEmail()
        {
            _email = _nombre + "@superempresa.com";
        }
    }
}
