using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.MVVM.Models
{
    public class Disponibilidade
    {
        public long _id {  get; set; }
        public string _diasemana { get; set; }
        public DateTime dtinicial { get; set; }
        public DateTime dtfinal { get; set; }

    }
}
