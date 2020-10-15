using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;


namespace FutbolApp.Modelos
{
    public class JugadorEquipo
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [ForeignKey(typeof(Jugador))]
        public int IdJUgador { get; set; }

        [ForeignKey(typeof(Equipo))]
        public int IdEquipo { get; set; }

        public int Goles { get; set; }
        public int Numero { get; set; }
    }
}
