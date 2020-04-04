using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea2_Richard_Viquez.Modelos;

namespace Tarea2_Richard_Viquez.Controllers
{

    /// <summary>
    /// Se encarga de todas las operaciones con base de datos
    /// </summary>
    public class SQLController
    {
        private string insertConductor = $"insert into [dbo].[Conductor] " +
            $"([Identificacion]" +
            $",[Nombre]" +
            $",[PrimerApeliido]" +
            $",[SegundoApellido]" +
            $",[RutaAsignada]) values(@id,@nombre,@pApellido,@sApellido,@ruta)";

        private string insertCamion = $"insert into [dbo].[Camion] " +
            $"([Placa] " +
            $",[AnnoModelo]" +
            $",[Marca]" +
            $",[CapacidadKG]" +
            $",[CapacidadVl]) values(@placa,@modelo,@marca,@kg,@vol)";

        private string insertCamionConductor = $"insert into [dbo].[ConductorCamion] " +
            $"(Identificacion,Placa) values(@identificacion,@placa)";


        private string selectConductor = $"SELECT [Identificacion]" +
            $",[Nombre]" +
            $" ,[PrimerApeliido]" +
            $",[SegundoApellido]" +
            $",[RutaAsignada]" +
            $"  FROM [TransportesCR].[dbo].[Conductor]";

        private string selectCamion = $"SELECT [Placa]" +
            $" ,[AnnoModelo]" +
            $",[Marca]" +
            $",[CapacidadKG]" +
            $",[CapacidadVl]" +
            $" FROM [TransportesCR].[dbo].[Camion]";

        private string selectCamionXConductor = $"SELECT [Identificacion],[Placa] " +
            $"FROM [TransportesCR].[dbo].[ConductorCamion]";


        /// <summary>
        /// Inserta los registros  a la base de datos dependiendo de el objeto recibido por parametro
        /// </summary>
        /// <param name="tipo"></param>
        /// <returns></returns>
        public async Task<bool> insertarRegistro(object tipo)
        {
            bool proceso = false;

            string sql = "";

			try
			{
                /////se determina el tipo de objeto recibido
                ////se define la consulta en la variable sql 
                ///se realiza la conexión a base de datos , se definen los parámetros y ejecuta en insert
                switch (tipo.GetType().Name)
                {
                    case "Conductor":
                        
                        sql = insertConductor;

                        Conductor conductor = tipo as Conductor;

                        using (var conection = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString))
                        {
                            await conection.OpenAsync();

                            using (var command = new SqlCommand(sql, conection))
                            {


                                command.Parameters.AddWithValue("@id", conductor.Identificacion);
                                command.Parameters.AddWithValue("@nombre", conductor.Nombre);
                                command.Parameters.AddWithValue("@pApellido", conductor.PrimerApellido);
                                command.Parameters.AddWithValue("@sApellido", conductor.SegundoApellido);
                                command.Parameters.AddWithValue("@ruta", conductor.RutaAsignada);

                                using (var reader = await command.ExecuteReaderAsync())
                                {
                                    proceso = true;
                                }
                            }

                        }
                        break;
                    case "Camion":
                        
                        sql = insertCamion;

                        Camion camion = tipo as Camion;

                        using (var conection = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString))
                        {
                            await conection.OpenAsync();

                            using (var command = new SqlCommand(sql, conection))
                            {


                                command.Parameters.AddWithValue("@placa", camion.Placa);
                                command.Parameters.AddWithValue("@modelo", camion.Modelo);
                                command.Parameters.AddWithValue("@marca", camion.Marca);
                                command.Parameters.AddWithValue("@kg", camion.CapacidadKilogramos);
                                command.Parameters.AddWithValue("@vol", camion.CapacidadVolumen);

                                using (var reader = await command.ExecuteReaderAsync())
                                {
                                    proceso = true;
                                }
                            }

                        }
                        break;
                    case "CamionConductor":

                        sql = insertCamionConductor;

                        CamionConductor camionConductor = tipo as CamionConductor;

                        using (var conection = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString))
                        {
                            await conection.OpenAsync();

                            using (var command = new SqlCommand(sql, conection))
                            {

                                command.Parameters.AddWithValue("@identificacion",camionConductor.Identificacion);
                                command.Parameters.AddWithValue("@placa", camionConductor.Placa);

                                using (var reader = await command.ExecuteReaderAsync())
                                {
                                    proceso = true;
                                }
                            }

                        }
                        break;
                    default:
                        break;
                }
            
			}
            catch (FormatException f)
            {
                ExcepcionesController.mostrarError(f);
                proceso = false;
            }
            catch (IndexOutOfRangeException i)
            {
                proceso = false;
                ExcepcionesController.mostrarError(i);
            }
            catch (ArgumentException a)
            {
                proceso = false;
                ExcepcionesController.mostrarError(a);
            }
            catch (NullReferenceException n)
            {
                proceso = false;
                ExcepcionesController.mostrarError(n);
            }
            catch (SqlException s)
            {
                proceso = false;
                ExcepcionesController.mostrarError(s);

            }
            catch (Exception eb)
            {
                proceso = false;
                ExcepcionesController.mostrarError(eb);

            }

            return proceso;
        }



        /// <summary>
        /// Método que devuelve el resultado de cualquier consulta sql en una lista de listas de un objeto genérico llamado
        /// Respuesta el cual se compone de un campo Columna y uno Valor para poder guardar las celdas de la tabla consultada en una lista
        /// </summary>
        /// <param name="tipo"></param>
        /// <returns></returns>
        public async Task<List<List<Respuesta>>> selectRegistro(object tipo)
        {
            List<List<Respuesta>> resultados = new List<List<Respuesta>>();

            string sql = "";

            try
            {

                switch (tipo.GetType().Name)
                {
                    case "Conductor":

                        sql = selectConductor;

                      
                        break;
                    case "Camion":

                        sql = selectCamion;

                       
                        break;

                    case "CamionConductor":

                        sql = selectCamionXConductor;


                        break;
                    default:
                        break;
                }


                using (var conection = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString))
                {
                    await conection.OpenAsync();

                    using (var command = new SqlCommand(sql, conection))
                    {

                        using (var reader = await command.ExecuteReaderAsync())
                        {

                            //se convierte el sqldatareader devuelto por sqldataclient en un dbdatarecord
                            //https://docs.microsoft.com/en-us/dotnet/api/system.data.common.dbdatarecord?view=netframework-4.8
                            //para acceder a las celdas de los registros devueltos de forma dinámica
                            foreach (var item in reader.Cast<DbDataRecord>())
                            {
                                List<Respuesta> registro = new List<Respuesta>();

                                for (int i = 0; i < item.FieldCount; i++)
                                {
                                    if (item.GetValue(i)!=null)
                                    {
                                        //se crea el registro agregando las celdas a el list registro
                                        Respuesta response = new Respuesta
                                        {
                                            Columna=item.GetName(i),
                                            Valor=item.GetValue(i)
                                        };

                                        // se agrega el registro a la lista de resultados
                                        registro.Add(response);
                                    }
                                }

                                resultados.Add(registro);
                            }
                            
                        }
                    }

                }

            }
            catch (FormatException f)
            {
                ExcepcionesController.mostrarError(f);
          
            }
            catch (IndexOutOfRangeException i)
            {
               
                ExcepcionesController.mostrarError(i);
            }
            catch (ArgumentException a)
            {
               
                ExcepcionesController.mostrarError(a);
            }
            catch (NullReferenceException n)
            {
              
                ExcepcionesController.mostrarError(n);
            }
            catch (SqlException s)
            {
               
                ExcepcionesController.mostrarError(s);

            }
            catch (Exception eb)
            {
               
                ExcepcionesController.mostrarError(eb);

            }


            return resultados;

        }








    }
}
