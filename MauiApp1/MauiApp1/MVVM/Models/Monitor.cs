using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiApp1.MVVM.Models;

namespace MauiApp1.MVVM.Models
{
    public class Monitor
    {
        public long _id { get; set; }
        public string _name { get; set; }
        public string _foto { get; set; }
        public string _whatsapp { get; set; }
        public string _email { get; set; }
        public string _conteudo { get; set; }
        public Disciplina idDisciplina { get; set; }
        public List<Disponibilidade> disponibilidades { get; set; }
    }
}
