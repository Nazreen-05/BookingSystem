using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Business
{
    public class RoomRates
    { 
    #region fields
        public decimal lowSeason; // december seasonal rates
        public decimal midSeason;
        public decimal highSeason;
        public decimal outOfSeason; // rates from jan-nov
    #endregion

    #region Properties
    public decimal LowSeason
    {
       get { return lowSeason; }
    }

    public decimal MidSeason
    {
       get { return midSeason; }
    }

    public decimal HighSeason
    {
        get { return highSeason; }
    }

    public decimal OutOfSeason
    {
        get { return outOfSeason; }
    }

    #endregion

    #region Constructor 
    public RoomRates(decimal lowSeasonRate = 550, decimal midSeasonRate = 750, decimal highSeasonRate = 995, decimal outOfSeasonRate = 450)
    {
        lowSeason = lowSeasonRate;
        midSeason = midSeasonRate;
        highSeason = highSeasonRate;
        outOfSeason = outOfSeasonRate;
    }
    #endregion

    #region Methods
    public decimal getRate(DateTime date)
    {
        if (date >= new DateTime(2024, 12, 1) && date <= new DateTime(2024, 12, 7))
            return LowSeason;
        if (date >= new DateTime(2024, 12, 8) && date <= new DateTime(2024, 12, 15))
            return MidSeason;
        if (date >= new DateTime(2024, 12, 16) && date <= new DateTime(2024, 12, 31))
            return HighSeason;

        //outside of seasonal month (december)
        return OutOfSeason;
    }

    #endregion

    }
}
