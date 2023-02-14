using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperEmpresa
{
    class Program
    {
        /* 
            Consigna:
            ---------------------
            1. Pedir por teclado nombre, sueldo, sexo, peso y altura y crear 1 objeto persona.
            2. Mostrar la información completa de la persona en este formato:
                -Nombre: Juan
                -Email: Juan@superempresa.com
                -sueldo: 30000 ARS
                -sexo: Masculino
                -peso:  70 kg(B)
                -altura: 1,7 m
        */

        static void Main(string[] args)
        {
            string nombre = MostrarMensaje("Por favor, introduce tu nombre.");
            float sueldo = ValidarFloat(MostrarMensaje("Introduce tu sueldo (ARS)."));
            string sexo = MostrarMensaje("Introduce to sexo. (Masculino/Femenino)");
            float peso = ValidarFloat(MostrarMensaje("Introduce tu peso (kg)."));
            float altura = ValidarFloat(MostrarMensaje("Introduce tu altura (m)."));

            Persona persona = new Persona(nombre, sueldo, sexo, peso, altura);

            MostrarMensaje("Presiona enter para ver los datos introducidos.");

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("-------------------------");
            Console.WriteLine("- Nombre: " + persona.GetNombre());
            Console.WriteLine("- Email: " + persona.GetEmail());
            Console.WriteLine("- Sueldo: " + persona.GetSueldo() + " ARS");
            Console.WriteLine("- Sexo: " + persona.GetSexo());
            Console.WriteLine("- Peso: " + persona.GetPeso() + " kg(B)");
            Console.WriteLine("- Altura: " + persona.GetAltura() + " m");
            Console.WriteLine("-------------------------");
            Console.WriteLine();

            Console.WriteLine("Listo.");
            Console.ReadKey();
        }

        static string MostrarMensaje(string mensaje)
        {
            Console.Clear();

            Console.WriteLine("/////////////// TP3 - Ejercicio: SuperEmpresa - Julián B. Ortega ///////////////");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(mensaje);
            Console.WriteLine();
            Console.WriteLine("------------------------- ");

            return Console.ReadLine();
        }

        static float ValidarFloat(string input)
        {
            bool exito = false;

            if (!float.TryParse(input, out float resultado))
            {
                do
                {
                    input = MostrarMensaje("Entrada inválida. Por favor, introduzca un número.");
                    exito = float.TryParse(input, out resultado);
                } while (!exito);
            }

            return resultado;
        }
    }
}
