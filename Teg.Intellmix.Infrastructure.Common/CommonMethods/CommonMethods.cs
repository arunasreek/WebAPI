using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esmart.Infrastructure.Common.ExtensionMethods;

namespace Esmart.Infrastructure.Common.CommonMethods
{
	public class CommonMethods
	{
		public static long GetQuartersBetweenDates(DateTime StartDate, DateTime EndDate)
		{
			double quarterDifference = EndDate.GetQuarter() - StartDate.GetQuarter();
			double yearlyQuarterDifference = (4 * (EndDate.Year - StartDate.Year));
			return Round(quarterDifference + yearlyQuarterDifference);
		}




        #region utilityMethods
        private static long Round(double dVal)
		{
			if (dVal >= 0)
				return (long)Math.Floor(dVal);
			return (long)Math.Ceiling(dVal);
		}

		#endregion
	}
}
