﻿using Dapper;
using Cassandra;
using Cassandra.Mapping;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAVD
{
    class TipoServicio
    {
        public string nombre { get; set; }
        public float cuotaDrenaje { get; set; }
        public float rango1 { get; set; }
        public float rango2 { get; set; }
        public float rango3 { get; set; }

        public TipoServicio()
        {

        }
        public TipoServicio(string nombre, float cuotaDrenaje, float rango1, float rango2, float rango3)
        {
            this.nombre = nombre;
            this.cuotaDrenaje = cuotaDrenaje;
            this.rango1 = rango1;
            this.rango2 = rango2;
            this.rango3 = rango3;
        }

        //BD QUERY
        public static TipoServicio Buscar(string nombre)
        {
            TipoServicio temp = null;
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();
                var data = ConexionDB_MAD.db.Query<TipoServicio>("sp_BuscarTipoServicio", new { @nombre = nombre }, commandType: CommandType.StoredProcedure);
                if (data.Count() > 0)
                {
                    temp = data.ToList()[0];
                }
                ConexionDB_MAD.desconectar();
            }
            else
            {
                string query = string.Format(
                "SELECT nombre, cuotaDrenaje, rango1, rango2, rango3 " +
                "FROM TipoServicio WHERE nombre = '{0}' allow filtering;",
                nombre);

                IMapper mapper = ConexionDB_AAVD.conexion();
                IEnumerable<TipoServicio> data = mapper.Fetch<TipoServicio>(query);
                List<TipoServicio> lista = data.ToList();
                if (lista.Count() > 0)
                {
                    temp = lista.ToList()[0];
                }
            }
            return temp;
        }
        public static void Modificar(TipoServicio servicio)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                ConexionDB_MAD.db.Query<TipoServicio>("sp_ModificarTipoServicio",
                    new
                    {
                        @nombre = servicio.nombre,
                        @cuotaDrenaje = servicio.cuotaDrenaje,
                        @rango1 = servicio.rango1,
                        @rango2 = servicio.rango2,
                        @rango3 = servicio.rango3
                    },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();
            }
            else
            {
                string query = string.Format(
                    "UPDATE TipoServicio SET cuotaDrenaje = {1}, rango1 = {2}, rango2 = {3}, rango3 = {4} " +
                    "WHERE nombre = '{0}' if exists;",
                    servicio.nombre, servicio.cuotaDrenaje, servicio.rango1, servicio.rango2, servicio.rango3
                );
                ConexionDB_AAVD.executeQuery(query);
            }
        }

        //FORM METODOS
        public static void LlenarDG(DataGridView dg)
        {
            try
            {
                if (Program.MAD_AAVD)
                {
                    ConexionDB_MAD.conectar();

                    var data = ConexionDB_MAD.db.Query<TipoServicio>("sp_ConsultarTipoServicios", new { }, commandType: CommandType.StoredProcedure);

                    ConexionDB_MAD.desconectar();

                    dg.DataSource = data.ToList();
                }
                else
                {
                    string query = string.Format(
                        "SELECT nombre, cuotaDrenaje, rango1, rango2, rango3 " +
                        "FROM TipoServicio allow filtering;"
                        );

                    IMapper mapper = ConexionDB_AAVD.conexion();
                    IEnumerable<TipoServicio> data = mapper.Fetch<TipoServicio>(query);
                    dg.DataSource = data.ToList();
                }
            }
            catch (Exception except)
            {
                MessageBox.Show("Error:" + except);
            }
        }

        public static void LlenarCB(ComboBox cb)
        {
            try
            {
                if (Program.MAD_AAVD)
                {
                    ConexionDB_MAD.conectar();

                    var data = ConexionDB_MAD.db.Query<string>("sp_ConsultarTipoServiciosPorNombre", new { }, commandType: CommandType.StoredProcedure);

                    ConexionDB_MAD.desconectar();

                    cb.DataSource = data.ToList();
                }
                else
                {
                    string query = string.Format(
                        "SELECT nombre " +
                        "FROM TipoServicio allow filtering;"
                        );

                    IMapper mapper = ConexionDB_AAVD.conexion();
                    IEnumerable<TipoServicio> data = mapper.Fetch<TipoServicio>(query);
                    List<TipoServicio> servicios = data.ToList();
                    cb.Items.Clear();
                    foreach (TipoServicio servicio in servicios)
                    {
                        cb.Items.Add(servicio.nombre);
                    }
                }
            }
            catch (Exception except)
            {
                MessageBox.Show("Error:" + except);
            }
        }
    }
}
