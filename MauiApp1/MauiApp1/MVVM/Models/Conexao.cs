using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.MVVM.Models
{
    public class Conexao
    {
        public long _id { get; set; }
        public DateTime _dataCriacao { get; set; }
        public Monitor idMonitor {  get; set; }
    }
}
