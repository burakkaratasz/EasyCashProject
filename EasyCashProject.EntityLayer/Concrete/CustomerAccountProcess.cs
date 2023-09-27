using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashProject.EntityLayer.Concrete
{
    public class CustomerAccountProcess
    {
        public int CustomerAccountProcessID { get; set; } //hesap hareketleri id
        public string ProcessType { get; set; } //işlem türü
        public decimal Amount { get; set; } //tutar
        public DateTime ProcessDate { get; set; } //tarih


    }
}
