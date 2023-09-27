using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashProject.EntityLayer.Concrete
{
    public class CustomerAccount
    {
        public int CustomerAccountID { get; set; } //hesap id
        public string CustomerAccountNumber { get; set; } //hesap numarası
        public string CustomerAccountCurrency { get; set; } //döviz bilgisi
        public decimal CustomerAccountBalance { get; set; } //hesap bakiyesi
        public string BankBranch { get; set; } //banka şubesi
    }
}
