﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ImportExcelSql.Models
{
    public partial class Bancocliente
    {
        public Bancocliente()
        {
            Gravacos = new HashSet<Gravaco>();
        }

        public int Id { get; set; }
        public int? Codigo { get; set; }
        public string Entrevistador { get; set; }
        public DateTime DataStatus { get; set; }
        public TimeSpan HoraStatus { get; set; }
        public string TelFeito { get; set; }
        public bool NumTratado { get; set; }
        public string Gravacao { get; set; }
        public string Ddd1 { get; set; }
        public string Fone1 { get; set; }
        public string Ddd2 { get; set; }
        public string Fone2 { get; set; }
        public string Ddd3 { get; set; }
        public string Fone3 { get; set; }
        public string Ddd4 { get; set; }
        public string Fone4 { get; set; }

        public virtual ICollection<Gravaco> Gravacos { get; set; }
    }
}
