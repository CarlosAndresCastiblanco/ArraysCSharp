using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace G10_F4_StebanOsorio
{
    class Informacion
    {
        public string nombreDelPrograma = "Problema 4";
        public string autor = "Autor: Jhonny Steban Osorio";
        public string usoDeLaAplicacion = "seleccione la opción";
        public string menu = "1. Registrar   2. Imprimir   3. Consultar y Modificar";
        public string menuRegitrar = "1. Participantes   2. Categorias"; 
        public string menuImprimir = "1. Imprimir Lista Participantes  2. Imprimir Lista Categorias";
        public string mensajeSalir = "Desea Salir? S/N";
        public string mensajeParticipantes = "Por favor digite Identificación, Nombre y Categoria";
        public string mensajeCategoria = "Por favor digite nombre Categoria y Valor Premio";
        public string mensajeError = "Esta Opción no esta disponible";
        public string tituloParticipantes = "La lista de participantes es:";
        public string tituloCategoria = "La lista de Categorias es:";
        public string errorBuscarParticipante = "Error: El participante ya existe -- Registro Ejecutado";
        public string formaDeUsoConsulta = "Esta opción consulta la categoria por el nombre";
        public string menuConsulta = "Por favor digite el nombre de la categoria a consultar";
        public string exitoConsulta = "La categoria consultada es:";
        public string errorConsulta = "No se encontro la categoria consultada";
        public string menuModificacion = "¿Desea cambiar el monto del premio para esta categoria? S/N";
        public string mensajeMonto = "Por favor digite el nuevo monto de la categoria";

    }
}
