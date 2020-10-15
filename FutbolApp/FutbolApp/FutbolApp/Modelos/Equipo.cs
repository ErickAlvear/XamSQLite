using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace FutbolApp.Modelos
{
    public class Equipo
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Escudo { get; set; }

        [ManyToMany(typeof(JugadorEquipo))]
        public List<Jugador> Jugadores { get; set; }
    }
}
