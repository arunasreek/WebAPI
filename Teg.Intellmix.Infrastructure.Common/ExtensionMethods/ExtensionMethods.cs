using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Esmart.Infrastructure.Common.Enums;

namespace Esmart.Infrastructure.Common.ExtensionMethods
{
	public static class ExtensionMethods
	{
		public static int GetQuarter(this DateTime dt)
		{
			return Convert.ToInt16(((dt.Month - 1) / 3) + 1);
		}

        public static T Cast<T>(this Object myobj)
        {
            Type objectType = myobj.GetType();
            Type target = typeof(T);
            var x = Activator.CreateInstance(target, false);
            var z = from source in objectType.GetMembers().ToList()
                    where source.MemberType == MemberTypes.Property
                    select source;
            var d = from source in target.GetMembers().ToList()
                    where source.MemberType == MemberTypes.Property
                    select source;
            List<MemberInfo> members = d.Where(memberInfo => d.Select(c => c.Name)
               .ToList().Contains(memberInfo.Name)).ToList();
            PropertyInfo propertyInfo;
            object value;
            foreach (var memberInfo in members)
            {
                propertyInfo = typeof(T).GetProperty(memberInfo.Name);
                value = myobj.GetType().GetProperty(memberInfo.Name).GetValue(myobj, null);

                propertyInfo.SetValue(x, value, null);
            }
            return (T)x;
        }


        public static IEnumerable<DateTime> GetAllDatesInMonth(int year, int monthNo)
        {
            int days = DateTime.DaysInMonth(year, monthNo);
            for (int day = 1; day <= days; day++)
            {
                yield return new DateTime(year, monthNo, day);
            }
        }

        public static int GetMonthNo(string monthOftheCycle)
        {
            int monthNo = 0;

            switch (monthOftheCycle)
            {
                case "First": //First
                    {
                        monthNo = DateTimeFormatInfo.CurrentInfo.MonthNames.ToList().IndexOf(CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(1).ToString()) + 1;
                        break;
                    }

                case "Second": //Second
                    {
                        monthNo = DateTimeFormatInfo.CurrentInfo.MonthNames.ToList().IndexOf(CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(2).ToString()) + 1;
                        break;
                    }

                case "Third": //Third
                    {
                        monthNo = DateTimeFormatInfo.CurrentInfo.MonthNames.ToList().IndexOf(CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(3).ToString()) + 1;
                        break;
                    }

                case "Fourth": //Fourth
                    {
                        monthNo = DateTimeFormatInfo.CurrentInfo.MonthNames.ToList().IndexOf(CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(4).ToString()) + 1;
                        break;
                    }

                case "Fifth": //Fifth
                    {
                        monthNo = DateTimeFormatInfo.CurrentInfo.MonthNames.ToList().IndexOf(CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(5).ToString()) + 1;
                        break;
                    }

                case "Sixth": //Sixth
                    {
                        monthNo = DateTimeFormatInfo.CurrentInfo.MonthNames.ToList().IndexOf(CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(6).ToString()) + 1;
                        break;
                    }

                case "Seventh": //Seventh
                    {
                        monthNo = DateTimeFormatInfo.CurrentInfo.MonthNames.ToList().IndexOf(CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(7).ToString()) + 1;

                        break;
                    }

                case "Eighth": //Eighth
                    {
                        monthNo = DateTimeFormatInfo.CurrentInfo.MonthNames.ToList().IndexOf(CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(8).ToString()) + 1;
                        break;
                    }

                case "Nineth": //Nineth
                    {
                        monthNo = DateTimeFormatInfo.CurrentInfo.MonthNames.ToList().IndexOf(CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(9).ToString()) + 1;
                        break;
                    }

                case "Tenth": //Tenth
                    {
                        monthNo = DateTimeFormatInfo.CurrentInfo.MonthNames.ToList().IndexOf(CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(10).ToString()) + 1;
                        break;
                    }

                case "Elventh": //Elventh
                    {
                        monthNo = DateTimeFormatInfo.CurrentInfo.MonthNames.ToList().IndexOf(CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(11).ToString()) + 1;
                        break;
                    }

                case "Twelfth": //Twelfth
                    {
                        monthNo = DateTimeFormatInfo.CurrentInfo.MonthNames.ToList().IndexOf(CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(12).ToString()) + 1;
                        break;
                    }
            }
            return monthNo;
        }

        public static string[] FormatDueDate(DateTime dtDueDate)
        {
            string[] dueDateDetails = new string[2];
            DateTime dtNow = DateTime.UtcNow;

            if (dtDueDate > dtNow)
            {
                TimeSpan timeSpan = dtDueDate - dtNow;
                DateTime actualDate = DateTime.MinValue + timeSpan;
                int years = actualDate.Year - 1;
                int months = actualDate.Month - 1;
                int days = actualDate.Day - 1;

                dueDateDetails[0] = months.ToString() + " months, " + days.ToString() + " days.";

                if ((int)timeSpan.TotalDays < 9)
                {
                    dueDateDetails[1] = ((int)ProcessUpdateStatus.DueDateApproaching).ToString();
                }
            }
            else
            {
                dueDateDetails[0] = "0 days";
                dueDateDetails[1] = ((int)ProcessUpdateStatus.DueDateCrossed).ToString();
            }

            return dueDateDetails;
        }

        public static dynamic GetDueDate(int cycleTypeId, dynamic fileDueDate, string cycleInfo, bool returnDateTime)
        {
            string[] dueDateDetails = new string[2];
            DateTime? dueDateDtT = null;
            // dueDateDetails[0] - dueDate
            // dueDateDetails[1] - Status

            switch (cycleTypeId)
            {
                case 1: // Quarterly    

                    int sourceMonthOftheCycleQuarter = ExtensionMethods.GetMonthNo(fileDueDate.MonthOftheCycle);

                    int monthOftheCycleQuarter = 3 * (Convert.ToInt32(cycleInfo.Split('-')[1].Substring(cycleInfo.Split('-')[1].ToString().Length - 1)) - 1) + sourceMonthOftheCycleQuarter;

                    var actualDueDateQuarter = ExtensionMethods.GetAllDatesInMonth(Convert.ToInt32(cycleInfo.Split('-')[0]), monthOftheCycleQuarter).Where(i => i.DayOfWeek.ToString() == fileDueDate.DayOfTheWeek);

                    if (actualDueDateQuarter != null)
                    {
                        switch (fileDueDate.WeekOfTheMonth)
                        {
                            case "First": //First
                                {
                                    if (returnDateTime)
                                    {
                                        dueDateDtT = actualDueDateQuarter.First();
                                    }
                                    else
                                    {
                                        string[] dueDate = ExtensionMethods.FormatDueDate(actualDueDateQuarter.First());
                                        if (!string.IsNullOrEmpty(dueDate[1]))
                                        {
                                            dueDateDetails[1] = dueDate[1].ToString();
                                        }
                                        dueDateDetails[0] = dueDate[0].ToString();
                                    }
                                    break;
                                }

                            case "Second": //Second
                                {
                                    if (returnDateTime)
                                    {
                                        dueDateDtT = actualDueDateQuarter.Skip(1).First();
                                    }
                                    else
                                    {
                                        string[] dueDate = ExtensionMethods.FormatDueDate(actualDueDateQuarter.Skip(1).First());
                                        if (!string.IsNullOrEmpty(dueDate[1]))
                                        {
                                            dueDateDetails[1] = dueDate[1].ToString();
                                        }
                                        dueDateDetails[0] = dueDate[0].ToString();
                                    }
                                    break;
                                }

                            case "Third": //Third
                                {
                                    if (returnDateTime)
                                    {
                                        dueDateDtT = actualDueDateQuarter.Skip(2).First();
                                    }
                                    else
                                    {
                                        string[] dueDate = ExtensionMethods.FormatDueDate(actualDueDateQuarter.Skip(2).First());
                                        if (!string.IsNullOrEmpty(dueDate[1]))
                                        {
                                            dueDateDetails[1] = dueDate[1].ToString();
                                        }
                                        dueDateDetails[0] = dueDate[0].ToString();
                                    }
                                    break;
                                }

                            case "Fourth": //Fourth
                                {
                                    if (returnDateTime)
                                    {
                                        dueDateDtT = actualDueDateQuarter.Skip(3).First();
                                    }
                                    else
                                    {
                                        string[] dueDate = ExtensionMethods.FormatDueDate(actualDueDateQuarter.Skip(3).First());
                                        if (!string.IsNullOrEmpty(dueDate[1]))
                                        {
                                            dueDateDetails[1] = dueDate[1].ToString();
                                        }
                                        dueDateDetails[0] = dueDate[0].ToString();
                                    }
                                    break;
                                }

                            case "Last": //Last
                                {
                                    if (returnDateTime)
                                    {
                                        dueDateDtT = actualDueDateQuarter.Last();
                                    }
                                    else
                                    {
                                        string[] dueDate = ExtensionMethods.FormatDueDate(actualDueDateQuarter.Last());
                                        if (!string.IsNullOrEmpty(dueDate[1]))
                                        {
                                            dueDateDetails[1] = dueDate[1].ToString();
                                        }
                                        dueDateDetails[0] = dueDate[0].ToString();
                                    }
                                    break;
                                }
                        }
                    }

                    break;
                case 2: // Half yearly

                    int sourceMonthOftheCycleHalfYearly = ExtensionMethods.GetMonthNo(fileDueDate.MonthOftheCycle);

                    int monthOftheCycleHalfYearly = 3 * (Convert.ToInt32(cycleInfo.Split('-')[1].Substring(cycleInfo.Split('-')[1].ToString().Length - 1)) - 1) + sourceMonthOftheCycleHalfYearly;

                    var actualDueDateHalfYearly = ExtensionMethods.GetAllDatesInMonth(Convert.ToInt32(cycleInfo.Split('-')[0]), monthOftheCycleHalfYearly).Where(i => i.DayOfWeek.ToString() == fileDueDate.DayOfTheWeek);

                    if (actualDueDateHalfYearly != null)
                    {
                        switch (fileDueDate.WeekOfTheMonth)
                        {
                            case "First": //First
                                {
                                    if (returnDateTime)
                                    {
                                        dueDateDtT = actualDueDateHalfYearly.First();
                                    }
                                    else
                                    {
                                        string[] dueDate = ExtensionMethods.FormatDueDate(actualDueDateHalfYearly.First());
                                        if (!string.IsNullOrEmpty(dueDate[1]))
                                        {
                                            dueDateDetails[1] = dueDate[1].ToString();
                                        }
                                        dueDateDetails[0] = dueDate[0].ToString();
                                    }
                                    break;
                                }

                            case "Second": //Second
                                {
                                    if (returnDateTime)
                                    {
                                        dueDateDtT = actualDueDateHalfYearly.Skip(1).First();
                                    }
                                    else
                                    {
                                        string[] dueDate = ExtensionMethods.FormatDueDate(actualDueDateHalfYearly.Skip(1).First());
                                        if (!string.IsNullOrEmpty(dueDate[1]))
                                        {
                                            dueDateDetails[1] = dueDate[1].ToString();
                                        }
                                        dueDateDetails[0] = dueDate[0].ToString();
                                    }
                                    break;
                                }

                            case "Third": //Third
                                {
                                    if (returnDateTime)
                                    {
                                        dueDateDtT = actualDueDateHalfYearly.Skip(2).First();
                                    }
                                    else
                                    {
                                        string[] dueDate = ExtensionMethods.FormatDueDate(actualDueDateHalfYearly.Skip(2).First());
                                        if (!string.IsNullOrEmpty(dueDate[1]))
                                        {
                                            dueDateDetails[1] = dueDate[1].ToString();
                                        }
                                        dueDateDetails[0] = dueDate[0].ToString();
                                    }
                                    break;
                                }

                            case "Fourth": //Fourth
                                {
                                    if (returnDateTime)
                                    {
                                        dueDateDtT = actualDueDateHalfYearly.Skip(3).First();
                                    }
                                    else
                                    {
                                        string[] dueDate = ExtensionMethods.FormatDueDate(actualDueDateHalfYearly.Skip(3).First());
                                        if (!string.IsNullOrEmpty(dueDate[1]))
                                        {
                                            dueDateDetails[1] = dueDate[1].ToString();
                                        }
                                        dueDateDetails[0] = dueDate[0].ToString();
                                    }
                                    break;
                                }

                            case "Last": //Last
                                {
                                    if (returnDateTime)
                                    {
                                        dueDateDtT = actualDueDateHalfYearly.Last();
                                    }
                                    else
                                    {
                                        string[] dueDate = ExtensionMethods.FormatDueDate(actualDueDateHalfYearly.Last());
                                        if (!string.IsNullOrEmpty(dueDate[1]))
                                        {
                                            dueDateDetails[1] = dueDate[1].ToString();
                                        }
                                        dueDateDetails[0] = dueDate[0].ToString();
                                    }
                                    break;
                                }
                        }
                    }

                    break;
                case 3: //yearly

                    int sourceMonthOftheCycleYearly = ExtensionMethods.GetMonthNo(fileDueDate.MonthOftheCycle);
                   
                    var actualDueDate = ExtensionMethods.GetAllDatesInMonth(Convert.ToInt32(cycleInfo.Split('-')[0]), sourceMonthOftheCycleYearly).Where(i => i.DayOfWeek.ToString() == fileDueDate.DayOfTheWeek);

                    if (actualDueDate != null)
                    {
                        switch (fileDueDate.WeekOfTheMonth)
                        {
                            case "First": //First
                                {
                                    if (returnDateTime)
                                    {
                                        dueDateDtT = actualDueDate.First();
                                    }
                                    else
                                    {
                                        string[] dueDate = ExtensionMethods.FormatDueDate(actualDueDate.First());
                                        if (!string.IsNullOrEmpty(dueDate[1]))
                                        {
                                            dueDateDetails[1] = dueDate[1].ToString();
                                        }
                                        dueDateDetails[0] = dueDate[0].ToString();
                                    }
                                    break;
                                }

                            case "Second": //Second
                                {
                                    if (returnDateTime)
                                    {
                                        dueDateDtT = actualDueDate.Skip(1).First();
                                    }
                                    else
                                    {
                                        string[] dueDate = ExtensionMethods.FormatDueDate(actualDueDate.Skip(1).First());
                                        if (!string.IsNullOrEmpty(dueDate[1]))
                                        {
                                            dueDateDetails[1] = dueDate[1].ToString();
                                        }
                                        dueDateDetails[0] = dueDate[0].ToString();
                                    }
                                    break;
                                }

                            case "Third": //Third
                                {
                                    if (returnDateTime)
                                    {
                                        dueDateDtT = actualDueDate.Skip(2).First();
                                    }
                                    else
                                    {
                                        string[] dueDate = ExtensionMethods.FormatDueDate(actualDueDate.Skip(2).First());
                                        if (!string.IsNullOrEmpty(dueDate[1]))
                                        {
                                            dueDateDetails[1] = dueDate[1].ToString();
                                        }
                                        dueDateDetails[0] = dueDate[0].ToString();
                                    }
                                    break;
                                }

                            case "Fourth": //Fourth
                                {
                                    if (returnDateTime)
                                    {
                                        dueDateDtT = actualDueDate.Skip(3).First();
                                    }
                                    else
                                    {
                                        string[] dueDate = ExtensionMethods.FormatDueDate(actualDueDate.Skip(3).First());
                                        if (!string.IsNullOrEmpty(dueDate[1]))
                                        {
                                            dueDateDetails[1] = dueDate[1].ToString();
                                        }
                                        dueDateDetails[0] = dueDate[0].ToString();
                                    }
                                    break;
                                }

                            case "Last": //Last
                                {
                                    if (returnDateTime)
                                    {
                                        dueDateDtT = actualDueDate.Last();
                                    }
                                    else
                                    {
                                        string[] dueDate = ExtensionMethods.FormatDueDate(actualDueDate.Last());
                                        if (!string.IsNullOrEmpty(dueDate[1]))
                                        {
                                            dueDateDetails[1] = dueDate[1].ToString();
                                        }
                                        dueDateDetails[0] = dueDate[0].ToString();
                                    }
                                    break;
                                }
                        }
                    }

                    break;
                default:
                    throw new NotImplementedException();
            }

            if (returnDateTime)
            {
                return dueDateDtT;
            }
            else
            {
                return dueDateDetails;
            }            
        }

        public static dynamic CheckWeekOfTheMonth(string WeekOfTheMonth, dynamic actualDueDateQuarter, bool returnDateTime)
        {
            string[] dueDateDetails = new string[2];
            DateTime? dueDateDtT = null;

            switch (WeekOfTheMonth)
            {
                case "First": //First
                    {
                        if (returnDateTime)
                        {
                            dueDateDtT = actualDueDateQuarter.First();
                        }
                        else
                        {
                            string[] dueDate = ExtensionMethods.FormatDueDate(actualDueDateQuarter.First());
                            if (!string.IsNullOrEmpty(dueDateDetails[1]))
                            {
                                dueDateDetails[1] = dueDate[1].ToString();
                            }
                            dueDateDetails[0] = dueDate[0].ToString();
                        }
                        break;
                    }

                case "Second": //Second
                    {
                        if (returnDateTime)
                        {
                            dueDateDtT = actualDueDateQuarter.Skip(1).First();
                        }
                        else
                        {
                            string[] dueDate = ExtensionMethods.FormatDueDate(actualDueDateQuarter.Skip(1).First());
                            if (!string.IsNullOrEmpty(dueDateDetails[1]))
                            {
                                dueDateDetails[1] = dueDate[1].ToString();
                            }
                            dueDateDetails[0] = dueDate[0].ToString();
                        }
                        break;
                    }

                case "Third": //Third
                    {
                        if (returnDateTime)
                        {
                            dueDateDtT = actualDueDateQuarter.Skip(2).First();
                        }
                        else
                        {
                            string[] dueDate = ExtensionMethods.FormatDueDate(actualDueDateQuarter.Skip(2).First());
                            if (!string.IsNullOrEmpty(dueDateDetails[1]))
                            {
                                dueDateDetails[1] = dueDate[1].ToString();
                            }
                            dueDateDetails[0] = dueDate[0].ToString();
                        }
                        break;
                    }

                case "Fourth": //Fourth
                    {
                        if (returnDateTime)
                        {
                            dueDateDtT = actualDueDateQuarter.Skip(3).First();
                        }
                        else
                        {
                            string[] dueDate = ExtensionMethods.FormatDueDate(actualDueDateQuarter.Skip(3).First());
                            if (!string.IsNullOrEmpty(dueDateDetails[1]))
                            {
                                dueDateDetails[1] = dueDate[1].ToString();
                            }
                            dueDateDetails[0] = dueDate[0].ToString();
                        }
                        break;
                    }

                case "Last": //Last
                    {
                        if (returnDateTime)
                        {
                            dueDateDtT = actualDueDateQuarter.Last();
                        }
                        else
                        {
                            string[] dueDate = ExtensionMethods.FormatDueDate(actualDueDateQuarter.Last());
                            if (!string.IsNullOrEmpty(dueDateDetails[1]))
                            {
                                dueDateDetails[1] = dueDate[1].ToString();
                            }
                            dueDateDetails[0] = dueDate[0].ToString();
                        }
                        break;
                    }
            }
            if (returnDateTime)
            {
                return dueDateDtT;
            }
            else
            {
                return dueDateDetails;
            }  
        }
    }
}
