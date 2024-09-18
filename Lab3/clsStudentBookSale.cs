using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class clsStudentBookSale : clsBookSale
    {
        bool blnStudentDiscount;
        const float sngSTUDENT_DISCOUNT_RATE = 0.15F;
        
        public clsStudentBookSale(string title, int quantity, decimal price, bool discount, bool student) : base(title, quantity, price, discount)
        {
            blnStudentDiscount = student;
        }
        
        public bool StudentDiscount
        {
            get { return blnStudentDiscount; }
            set { blnStudentDiscount = value; }
        }

        public override decimal DiscountAmount()
        {
            decimal decDiscountAmount;
            decDiscountAmount = base.DiscountAmount();
            if (StudentDiscount)
                decDiscountAmount += ExtendedPrice() * Convert.ToDecimal(sngSTUDENT_DISCOUNT_RATE);
            
            return decDiscountAmount;
        }

    }
}
