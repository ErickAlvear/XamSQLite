using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace FutbolApp.Modelos
{
    public class Jugador
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string FechaNacimiento { get; set; } = DateTime.MinValue.ToString();

        public string Foto { get; set; }

        [ManyToMany(typeof(JugadorEquipo))]
        public List<Equipo> Equipos { get; set; }
    }
}
