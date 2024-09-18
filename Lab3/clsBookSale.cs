using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class clsBookSale
    {
        string strTitle;
        int intQuantity;
        decimal decPrice;

        public clsBookSale(string title, int quantity, decimal price, bool discount)
        {
            this.Title = title;
            this.Quantity = quantity;
            this.Price = price;
            this.Discount = discount;
        }

        public string Title
        {
            get { return strTitle; }
            set { strTitle = value; }
        }
        public int Quantity
        {
            get { return intQuantity; }
            set { intQuantity = value; }
        }
        public decimal Price
        {
            get { return decPrice; }
            set { decPrice = value; }
        }
        
        public decimal ExtendedPrice()
        {
            decimal decExtendedPrice = intQuantity * decPrice;
            decSalesTotal += decExtendedPrice;
            intSalesCount += 1;
            return decExtendedPrice;
        }

        static decimal decSalesTotal = 0;
        static int intSalesCount = 0;

        public static decimal SalesTotal
        {
            get { return decSalesTotal; }
        }
        public static int SalesCount
        {
            get { return intSalesCount; }
        }

        const float sngDISCOUNT_RATE = 0.1F;
        bool blnDiscount;
        public bool Discount
        {
            get { return blnDiscount; }

            set { blnDiscount = value; }
        }

        public virtual decimal DiscountAmount()
        {
            decimal decDiscountAmount;
            if (blnDiscount)
            {
                decDiscountAmount = intQuantity * decPrice * Convert.ToDecimal(sngDISCOUNT_RATE);
            }
            else
            {
                decDiscountAmount = 0M;
            }
            return decDiscountAmount;
        }

        public decimal NetDue()
        {
            decimal decNetDue = ExtendedPrice() - DiscountAmount();
            decSalesTotal += decNetDue;
            intSalesCount += 1;
            return decNetDue;
        }
    }
}
