﻿using Microsoft.EntityFrameworkCore.Migrations;
using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Threading.Tasks;

namespace Agenda_Pim.Models
{
    public class Agendamento : Entity
    {
        [Key]
        public int IdAgendamento { get; set; }
        public DateTime HorarioInicial { get; set; }
        public DateTime HorarioFinal { get; set; }
       // [ForeignKey("IdAuditorio")]
        public Auditorios IdAuditorio { get; set; }
        public string DescricaoEvento { get; set; }
        public bool SttsTrigger { get; set; }
        public int Proprietario { get; set; }
        //[ForeignKey("IdUsuario")]
        public Usuario IdUsuario { get; set; }
        public string ObservacaoAgendamento { get; set; }

        
    }
}
