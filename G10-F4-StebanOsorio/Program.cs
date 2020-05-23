using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace G10_F4_StebanOsorio
{
    class Program
    {
        static void Main(string[] args)
        {
            string salir = "N";
            List<Participantes> listParticipantes = new List<Participantes>();
            List<Categoria> listCategoria = new List<Categoria>();
            while (salir != "S")
            {
                Participantes participantes = new Participantes();
                Categoria categoria = new Categoria();
                Informacion info = new Informacion();
                Console.WriteLine(info.nombreDelPrograma);
                Console.WriteLine(info.autor);
                Console.WriteLine(info.usoDeLaAplicacion);
                Console.WriteLine(info.menu);
                int menu = Convert.ToInt32(Console.ReadLine());
                if (menu == 1)
                {
                    Console.WriteLine(info.usoDeLaAplicacion);
                    Console.WriteLine(info.menuRegitrar);
                    int opcion = Convert.ToInt32(Console.ReadLine());
                    if (opcion == 1)
                    {
                        Console.WriteLine(info.mensajeParticipantes);
                        int indentificacion = Convert.ToInt32(Console.ReadLine());
                        string nombre = Console.ReadLine();
                        int validate = 0;
                        for (int i = 0; i < listParticipantes.Count; i++)
                        {
                            if (listParticipantes[i].identificacion == indentificacion)
                            {
                                Console.WriteLine(info.errorBuscarParticipante);
                                validate++;
                                break;
                            }
                        }
                        int categoriaParticipante = Convert.ToInt32(Console.ReadLine());
                        participantes.setIdentificacion(indentificacion);
                        participantes.setNombre(nombre);
                        participantes.setCategoria(categoriaParticipante);
                        if (validate == 0)
                        {
                            listParticipantes.Add(participantes);
                        }
                    }
                    else if (opcion == 2)
                    {
                        Console.WriteLine(info.mensajeCategoria);
                        string nombreCategoria = Console.ReadLine();
                        double valorPremio = Convert.ToDouble(Console.ReadLine());
                        categoria.setNombreCategoria(nombreCategoria);
                        categoria.setValorPremio(valorPremio);
                        listCategoria.Add(categoria);
                    }
                    else
                    {
                        Console.WriteLine(info.mensajeError);
                    }
                } else if (menu == 2){
                    Console.WriteLine(info.usoDeLaAplicacion);
                    Console.WriteLine(info.menuImprimir);
                    int opcion = Convert.ToInt32(Console.ReadLine());
                    if (opcion == 1)
                    {
                        Console.WriteLine(info.tituloParticipantes);
                        for (int i = 0; i < listParticipantes.Count; i++)
                        {
                            Console.WriteLine(listParticipantes[i].identificacion + " "
                                + listParticipantes[i].nombre + " "
                                + listParticipantes[i].categoria);
                        }
                    } else if (opcion == 2){
                        Console.WriteLine(info.tituloCategoria);
                        for (int i = 0; i < listCategoria.Count; i++)
                        {
                            Console.WriteLine(listCategoria[i].nombreCategoria + " "
                                + listCategoria[i].valorPremio);
                        }

                    } else {
                        Console.WriteLine(info.mensajeError);
                    }
                }else if (menu == 3){
                    Console.WriteLine(info.formaDeUsoConsulta);
                    Console.WriteLine(info.menuConsulta);
                    string nombreCategoria = Console.ReadLine();
                    int numeroCategoriasEncontradas = 0;
                    for (int i = 0; i < listCategoria.Count; i++)
                    {
                        if (nombreCategoria == listCategoria[i].nombreCategoria)
                        {
                            Console.WriteLine(info.exitoConsulta);
                            Console.WriteLine(listCategoria[i].nombreCategoria + " "
                           + listCategoria[i].valorPremio);
                            Console.WriteLine(info.menuModificacion);
                            string opcionModificacion = Console.ReadLine();
                            if (opcionModificacion == "S")
                            {
                                Console.WriteLine(info.mensajeMonto);
                                double valorPremio = Convert.ToDouble(Console.ReadLine());
                                listCategoria[i].valorPremio = valorPremio;
                            }
                            numeroCategoriasEncontradas++;
                            break;
                        }
                    }
                    if (numeroCategoriasEncontradas == 0)
                    {
                        Console.WriteLine(info.errorConsulta);
                    }
                } else {
                    Console.WriteLine(info.mensajeError);
                }
                
                Console.WriteLine(info.mensajeSalir);
                salir = Convert.ToString(Console.ReadLine());
            }
        }
    }
}
