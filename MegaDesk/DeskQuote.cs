using System;

namespace MegaDesk
{
    public class DeskQuote
    {
        // DeskQuote attributes
        public string CustomerName { get; set; }
        public DateTime QuoteDate { get; set; }
        public int RushDays { get; set; }
        public Desk Desk = new Desk();
        public int QuoteAmount { get; set; }

        // Local working variables
        private int SurfaceArea = 0;

        // Constants
        private const int PRICE_BASE = 200;
        private const int SIZE_THRESHOLD = 1000;
        private const int PRICE_PER_DRAWER = 50;
        private const int PRICE_PER_SURFACEAREA = 1;
        private const int RUSH1 = 3;
        private const int RUSH2 = 5;
        private const int RUSH3 = 7;
        private const int RUSH_THRESHOLD = 2000;


        public DeskQuote(string customerName, DateTime quoteDate, int width, int depth, int drawers, DesktopMaterial material, int rushDays)
        {
            CustomerName = customerName;
            QuoteDate = quoteDate;
            Desk.Width = width;
            Desk.Depth = depth;
            Desk.NumberOfDrawers = drawers;
            Desk.DesktopMaterial = material;
            RushDays = rushDays;

            // Calculated SurfaceArea 
            SurfaceArea = Desk.Width * Desk.Depth;
        }

        public int CalculateQuoteTotal()
        {
            QuoteAmount = PRICE_BASE + SurfaceAreaCost() + DrawerCost();
            return QuoteAmount;
        }

        private int SurfaceAreaCost()
        {
            if (SurfaceArea > SIZE_THRESHOLD)
            {
                return (SurfaceArea - SIZE_THRESHOLD) * PRICE_PER_SURFACEAREA;
            }
            else
            {
                return 0;
            }
        }

        private int DrawerCost()
        {
            return Desk.NumberOfDrawers * PRICE_PER_DRAWER;
        }

        //private int RushOrderCost()
        //{
            //RushDayPrices = GetRushOrderPrices();

            
        //}

        //private int[,] GetRushOrderPrices()
        //{

            

            //try
            //{
                //string[] prices = File.ReadAllLines("@rushorderprices.txt");
                //foreach (var price in prices)
                //{
                //    rushPrices[,]
                //}
            //}
            //catch (Exception)
            //{

            //    throw;
            //}

            //return rushPrices;
        //}


    }

}
