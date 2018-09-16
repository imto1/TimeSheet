using System;

namespace timesheet
{
    public class PersianCalendar
    {
        public PersianCalendar() {}

        public String Today()
        {
            return toPersian(DateTime.Now.ToString("yyyy-MM-dd"));
        }

        public int Year()
        {
            String[] year = SplitDate(toPersian(DateTime.Now.ToString("yyyy-MM-dd")));
            return int.Parse(year[0]);
        }

        public int Month()
        {
            String[] month = SplitDate(toPersian(DateTime.Now.ToString("yyyy-MM-dd")));
            return int.Parse(month[1]);
        }

        public int Day()
        {
            String[] day = SplitDate(toPersian(DateTime.Now.ToString("yyyy-MM-dd")));
            return int.Parse(day[2]);
        }

        public int getYearOf(int Year, int Month, int Day)
        {
            String date = toPersian(Year, Month, Day);
            String[] year = SplitDate(date);
            return int.Parse(year[0]);
        }

        public int getMonthOf(int Year, int Month, int Day)
        {
            String date = toPersian(Year, Month, Day);
            String[] month = SplitDate(date);
            return int.Parse(month[1]);
        }

        public int getDayOf(int Year, int Month, int Day)
        {
            String date = toPersian(Year, Month, Day);
            String[] day = SplitDate(date);
            return int.Parse(day[2]);
        }

        public int extractYear(String FullDate)
        {
            String[] year = SplitDate(FullDate);
            return int.Parse(year[0]);
        }

        public int extractMonth(String FullDate)
        {
            String[] month = SplitDate(FullDate);
            return int.Parse(month[1]);
        }

        public int extractDay(String FullDate)
        {
            String[] day = SplitDate(FullDate);
            return int.Parse(day[2]);
        }

        public int getMaxDay(int year, int month)
        {
            int maxday;

            if (month >= 1 && month <= 6)
                maxday = 31;
            else if (month >= 7 && month <= 11)
                maxday = 30;
            else
                maxday = (PersianLeapYear(year)) ? 30 : 29;

            return maxday;
        }

        public int getDayOfWeek(String fullDate)
        {
            DateTime calendar = DateTime.Parse(toGregorian(fullDate));
            DayOfWeek weekday = calendar.DayOfWeek;
            switch (weekday)
            {
                case DayOfWeek.Sunday:
                    return 0;
                case DayOfWeek.Saturday:
                    return 6;
                case DayOfWeek.Monday:
                    return 1;
                case DayOfWeek.Tuesday:
                    return 2;
                case DayOfWeek.Wednesday:
                    return 3;
                case DayOfWeek.Thursday:
                    return 4;
                case DayOfWeek.Friday:
                    return 5;
                default:
                    return -1;
            }
        }
        
        public String getWeekChar(int weekDay)
        {
            switch (weekDay)
            {
                case 0:
                    return "ی";
                case 6:
                    return "ش";
                case 1:
                    return "د";
                case 2:
                    return "س";
                case 3:
                    return "چ";
                case 4:
                    return "پ";
                case 5:
                    return "ج";
                default:
                    return "";
            }
        }
        public String getMonthName(int month)
        {
            switch (month)
            {
                case 1:
                    return "فروردین";
                case 2:
                    return "اردیبهشت";
                case 3:
                    return "خرداد";
                case 4:
                    return "تیر";
                case 5:
                    return "امرداد";
                case 6:
                    return "شهریور";
                case 7:
                    return "مهر";
                case 8:
                    return "آبان";
                case 9:
                    return "آذر";
                case 10:
                    return "دی";
                case 11:
                    return "بهمن";
                case 12:
                    return "اسپند";
                default:
                    return "";
            }
        }

        public bool GregorianLeapYear(int Year)
        {
            if (Year % 4 == 0)
            {
                if (Year % 100 != 0)
                    return true;
                else
                    return (Year % 400 == 0);
            }
            return false;
        }

        public bool PersianLeapYear(int Year)
        {
            int tens, ones;
            tens = Year % 100;
            ones = Year % 10;
            tens -= ones;
            tens /= 10;
            if ((tens == 1 || tens % 2 == 1) && (ones == 1 || ones % 4 == 1))
                return true;
            else
                return ((tens == 0 || tens % 2 == 0) && (ones == 3 || ones == 7));
        }

        public String[] SplitDate(String FullDate)
        {
            String[] date = FullDate.Split('/');
            if (date.Length < 2)
                date = FullDate.Split('-');
            return date;
        }

        public String toPersian(int Year, int Month, int Day)
        {
            if (GregorianLeapYear(Year))
                return ConvertPersianDate_Leap(Year, Month, Day);
            else
                return ConvertPersianDate_NotLeap(Year, Month, Day, GregorianLeapYear(Year - 1));
        }

        public String toPersian(String FullDate)
        {
            String[] date = SplitDate(FullDate);
            return toPersian(int.Parse(date[0]), int.Parse(date[1]), int.Parse(date[2]));
        }

        public String toGregorian(int Year, int Month, int Day)
        {
            bool L = false;
            if ((Month >= 1) && (Month <= 9))
                L = GregorianLeapYear(Year + 621);
            else if (Month == 10)
            {
                if (PersianLeapYear(Year))
                {
                    if ((Day >= 1) && (Day <= 11))
                        L = GregorianLeapYear(Year + 621);
                }
                else
                {
                    if ((Day >= 1) && (Day <= 10))
                        L = GregorianLeapYear(Year + 621);
                }
            }
            else
                L = GregorianLeapYear(Year + 622);
            if (L)
                return ConvertGregorianDate_Leap(Year, Month, Day);
            else
                return ConvertGregorianDate_NotLeap(Year, Month, Day, PersianLeapYear(Year));
        }

        public String toGregorian(String FullDate)
        {
            String[] date = SplitDate(FullDate);
            return toGregorian(int.Parse(date[0]), int.Parse(date[1]), int.Parse(date[2]));
        }

        private String ConvertPersianDate_NotLeap(int Year, int Month, int Day, bool AL)
        {
            String datestr;
            switch (Month)
            {
                case 1:
                    if (AL)
                    {
                        if ((Day >= 1) && (Day <= 19))
                        {
                            Day += 11;
                            Month += 9;
                        }
                        else if ((Day >= 20) && (Day <= 31))
                        {
                            Day -= 19;
                            Month += 10;
                        }
                    }
                    else
                    {
                        if ((Day >= 1) && (Day <= 20))
                        {
                            Day += 10;
                            Month += 9;
                        }
                        else if ((Day >= 21) && (Day <= 31))
                        {
                            Day -= 20;
                            Month += 10;
                        }
                    }
                    Year -= 622;
                    break;
                case 2:
                    if (AL)
                    {
                        if ((Day >= 1) && (Day <= 18))
                        {
                            Day += 12;
                            Month += 9;
                        }
                        else if ((Day >= 19) && (Day <= 28))
                        {
                            Day -= 18;
                            Month += 10;
                        }
                    }
                    else
                    {
                        if ((Day >= 1) && (Day <= 19))
                        {
                            Day += 11;
                            Month += 9;
                        }
                        else if ((Day >= 20) && (Day <= 28))
                        {
                            Day -= 19;
                            Month += 10;
                        }
                    }
                    Year -= 622;
                    break;
                case 3:
                    if ((Day >= 1) && (Day <= 20))
                    {
                        if (AL)
                        {
                            Day += 10;
                            Month += 9;
                        }
                        else
                        {
                            Day += 9;
                            Month += 9;
                        }
                        Year -= 622;
                    }
                    else if ((Day >= 21) && (Day <= 31))
                    {
                        Day -= 20;
                        Month -= 2;
                        Year -= 621;
                    }
                    break;
                case 4:
                    if ((Day >= 1) && (Day <= 20))
                    {
                        Day += 11;
                        Month -= 3;
                    }
                    else if ((Day >= 21) && (Day <= 30))
                    {
                        Day -= 20;
                        Month -= 2;
                    }
                    Year -= 621;
                    break;
                case 5:
                    if ((Day >= 1) && (Day <= 21))
                    {
                        Day += 10;
                        Month -= 3;
                    }
                    else if ((Day >= 22) && (Day <= 31))
                    {
                        Day -= 21;
                        Month -= 2;
                    }
                    Year -= 621;
                    break;
                case 6:
                    if ((Day >= 1) && (Day <= 21))
                    {
                        Day += 10;
                        Month -= 3;
                    }
                    else if ((Day >= 22) && (Day <= 30))
                    {
                        Day -= 21;
                        Month -= 2;
                    }
                    Year -= 621;
                    break;
                case 7:
                    if ((Day >= 1) && (Day <= 22))
                    {
                        Day += 9;
                        Month -= 3;
                    }
                    else if ((Day >= 23) && (Day <= 31))
                    {
                        Day -= 22;
                        Month -= 2;
                    }
                    Year -= 621;
                    break;
                case 8:
                    if ((Day >= 1) && (Day <= 22))
                    {
                        Day += 9;
                        Month -= 3;
                    }
                    else if ((Day >= 23) && (Day <= 31))
                    {
                        Day -= 22;
                        Month -= 2;
                    }
                    Year -= 621;
                    break;
                case 9:
                    if ((Day >= 1) && (Day <= 22))
                    {
                        Day += 9;
                        Month -= 3;
                    }
                    else if ((Day >= 23) && (Day <= 30))
                    {
                        Day -= 22;
                        Month -= 2;
                    }
                    Year -= 621;
                    break;
                case 10:
                    if ((Day >= 1) && (Day <= 22))
                    {
                        Day += 8;
                        Month -= 3;
                    }
                    else if ((Day >= 23) && (Day <= 31))
                    {
                        Day -= 22;
                        Month -= 2;
                    }
                    Year -= 621;
                    break;
                case 11:
                    if ((Day >= 1) && (Day <= 21))
                    {
                        Day += 9;
                        Month -= 3;
                    }
                    else if ((Day >= 22) && (Day <= 30))
                    {
                        Day -= 21;
                        Month -= 2;
                    }
                    Year -= 621;
                    break;
                case 12:
                    if ((Day >= 1) && (Day <= 21))
                    {
                        Day += 9;
                        Month -= 3;
                    }
                    else if ((Day >= 22) && (Day <= 31))
                    {
                        Day -= 21;
                        Month -= 2;
                    }
                    Year -= 621;
                    break;
            }

            datestr = Year.ToString();
            datestr = datestr + "/";
            if (Month < 10)
                datestr = datestr + "0" + Month;
            else
                datestr = datestr + Month;

            datestr = datestr + "/";
            if (Day < 10)
                datestr = datestr + "0" + Day;
            else
                datestr = datestr + Day;

            return datestr;
        }

        private String ConvertPersianDate_Leap(int Year, int Month, int Day)
        {
            String datestr;
            switch (Month)
            {
                case 1:
                    if ((Day >= 1) && (Day <= 20))
                    {
                        Day += 10;
                        Month += 9;
                    }
                    else if ((Day >= 21) && (Day <= 31))
                    {
                        Day -= 20;
                        Month += 10;
                    }
                    Year -= 622;
                    break;
                case 2:
                    if ((Day >= 1) && (Day <= 19))
                    {
                        Day += 11;
                        Month += 9;
                    }
                    else if ((Day >= 20) && (Day <= 29))
                    {
                        Day -= 19;
                        Month += 10;
                    }
                    Year -= 622;
                    break;
                case 3:
                    if ((Day >= 1) && (Day <= 19))
                    {
                        Day += 10;
                        Month += 9;
                        Year -= 622;
                    }
                    else if ((Day >= 20) && (Day <= 31))
                    {
                        Day -= 19;
                        Month -= 2;
                        Year -= 621;
                    }
                    break;
                case 4:
                    if ((Day >= 1) && (Day <= 19))
                    {
                        Day += 12;
                        Month -= 3;
                    }
                    else if ((Day >= 20) && (Day <= 30))
                    {
                        Day -= 19;
                        Month -= 2;
                    }
                    Year -= 621;
                    break;
                case 5:
                    if ((Day >= 1) && (Day <= 20))
                    {
                        Day += 11;
                        Month -= 3;
                    }
                    else if ((Day >= 21) && (Day <= 31))
                    {
                        Day -= 20;
                        Month -= 2;
                    }
                    Year -= 621;
                    break;
                case 6:
                    if ((Day >= 1) && (Day <= 20))
                    {
                        Day += 11;
                        Month -= 3;
                    }
                    else if ((Day >= 21) && (Day <= 30))
                    {
                        Day -= 20;
                        Month -= 2;
                    }
                    Year -= 621;
                    break;
                case 7:
                    if ((Day >= 1) && (Day <= 21))
                    {
                        Day += 10;
                        Month -= 3;
                    }
                    else if ((Day >= 22) && (Day <= 31))
                    {
                        Day -= 21;
                        Month -= 2;
                    }
                    Year -= 621;
                    break;
                case 8:
                    if ((Day >= 1) && (Day <= 21))
                    {
                        Day += 10;
                        Month -= 3;
                    }
                    else if ((Day >= 22) && (Day <= 31))
                    {
                        Day -= 21;
                        Month -= 2;
                    }
                    Year -= 621;
                    break;
                case 9:
                    if ((Day >= 1) && (Day <= 21))
                    {
                        Day += 10;
                        Month -= 3;
                    }
                    else if ((Day >= 22) && (Day <= 30))
                    {
                        Day -= 21;
                        Month -= 2;
                    }
                    Year -= 621;
                    break;
                case 10:
                    if ((Day >= 1) && (Day <= 21))
                    {
                        Day += 9;
                        Month -= 3;
                    }
                    else if ((Day >= 22) && (Day <= 31))
                    {
                        Day -= 21;
                        Month -= 2;
                    }
                    Year -= 621;
                    break;
                case 11:
                    if ((Day >= 1) && (Day <= 20))
                    {
                        Day += 10;
                        Month -= 3;
                    }
                    else if ((Day >= 21) && (Day <= 30))
                    {
                        Day -= 20;
                        Month -= 2;
                    }
                    Year -= 621;
                    break;
                case 12:
                    if ((Day >= 1) && (Day <= 20))
                    {
                        Day += 10;
                        Month -= 3;
                    }
                    else if ((Day >= 21) && (Day <= 31))
                    {
                        Day -= 20;
                        Month -= 2;
                    }
                    Year -= 621;
                    break;
            }


            datestr = Year.ToString();
            datestr = datestr + "/";
            if (Month < 10)
                datestr = datestr + "0" + Month;
            else
                datestr = datestr + Month;

            datestr = datestr + "/";
            if (Day < 10)
                datestr = datestr + "0" + Day;
            else
                datestr = datestr + Day;

            return datestr;
        }

        private String ConvertGregorianDate_NotLeap(int Year, int Month, int Day, bool L)
        {
            String datestr;
            switch (Month)
            {
                case 1:
                    if ((Day >= 1) && (Day <= 11))
                    {
                        Day += 20;
                        Month += 2;
                    }
                    else if ((Day >= 12) && (Day <= 31))
                    {
                        Day -= 11;
                        Month += 3;
                    }
                    Year += 621;
                    break;
                case 2:
                    if ((Day >= 1) && (Day <= 10))
                    {
                        Day += 20;
                        Month += 2;
                    }
                    else if ((Day >= 11) && (Day <= 31))
                    {
                        Day -= 10;
                        Month += 3;
                    }
                    Year += 621;
                    break;
                case 3:
                    if ((Day >= 1) && (Day <= 10))
                    {
                        Day += 21;
                        Month += 2;
                    }
                    else if ((Day >= 11) && (Day <= 31))
                    {
                        Day -= 10;
                        Month += 3;
                    }
                    Year += 621;
                    break;
                case 4:
                    if ((Day >= 1) && (Day <= 9))
                    {
                        Day += 21;
                        Month += 2;
                    }
                    else if ((Day >= 10) && (Day <= 31))
                    {
                        Day -= 9;
                        Month += 3;
                    }
                    Year += 621;
                    break;
                case 5:
                    if ((Day >= 1) && (Day <= 9))
                    {
                        Day += 22;
                        Month += 2;
                    }
                    else if ((Day >= 10) && (Day <= 31))
                    {
                        Day -= 9;
                        Month += 3;
                    }
                    Year += 621;
                    break;
                case 6:
                    if ((Day >= 1) && (Day <= 9))
                    {
                        Day += 22;
                        Month += 2;
                    }
                    else if ((Day >= 10) && (Day <= 31))
                    {
                        Day -= 9;
                        Month += 3;
                    }
                    Year += 621;
                    break;
                case 7:
                    if ((Day >= 1) && (Day <= 8))
                    {
                        Day += 22;
                        Month += 2;
                    }
                    else if ((Day >= 9) && (Day <= 30))
                    {
                        Day -= 8;
                        Month += 3;
                    }
                    Year += 621;
                    break;
                case 8:
                    if ((Day >= 1) && (Day <= 9))
                    {
                        Day += 22;
                        Month += 2;
                    }
                    else if ((Day >= 10) && (Day <= 30))
                    {
                        Day -= 9;
                        Month += 3;
                    }
                    Year += 621;
                    break;
                case 9:
                    if ((Day >= 1) && (Day <= 9))
                    {
                        Day += 21;
                        Month += 2;
                    }
                    else if ((Day >= 10) && (Day <= 30))
                    {
                        Day -= 9;
                        Month += 3;
                    }
                    Year += 621;
                    break;
                case 10:
                    if (L)
                    {
                        if ((Day >= 12) && (Day <= 30))
                        {
                            Day -= 11;
                            Month -= 9;
                            Year += 622;
                        }
                    }
                    else
                    {
                        if ((Day >= 1) && (Day <= 10))
                        {
                            Day += 21;
                            Month += 2;
                            Year += 621;
                        }
                        else if ((Day >= 11) && (Day <= 30))
                        {
                            Day -= 10;
                            Month -= 9;
                            Year += 622;
                        }
                    }
                    break;
                case 11:
                    if (L)
                    {
                        if ((Day >= 1) && (Day <= 12))
                        {
                            Day += 19;
                            Month -= 10;
                        }
                        else if ((Day >= 13) && (Day <= 30))
                        {
                            Day -= 12;
                            Month -= 9;
                        }
                    }
                    else
                    {
                        if ((Day >= 1) && (Day <= 11))
                        {
                            Day += 20;
                            Month -= 10;
                        }
                        else if ((Day >= 12) && (Day <= 30))
                        {
                            Day -= 11;
                            Month -= 9;
                        }
                    }
                    Year += 622;
                    break;
                case 12:
                    if (L)
                    {
                        if ((Day >= 1) && (Day <= 10))
                        {
                            Day += 18;
                            Month -= 10;
                        }
                        else if ((Day >= 11) && (Day <= 30))
                        {
                            Day -= 10;
                            Month -= 9;
                        }
                    }
                    else
                    {
                        if ((Day >= 1) && (Day <= 9))
                        {
                            Day += 19;
                            Month -= 10;
                        }
                        else if ((Day >= 10) && (Day <= 29))
                        {
                            Day -= 9;
                            Month -= 9;
                        }
                    }
                    Year += 622;
                    break;
            }

            if (Month < 10)
                datestr = "0" + Month.ToString();
            else
                datestr = Month.ToString();

            datestr = datestr + "/";
            if (Day < 10)
                datestr = datestr + "0" + Day;
            else
                datestr = datestr + Day;

            datestr = datestr + "/";
            datestr = datestr + Year;

            return datestr;
        }

        private String ConvertGregorianDate_Leap(int Year, int Month, int Day)
        {
            String datestr;
            switch (Month)
            {
                case 1:
                    if ((Day >= 1) && (Day <= 12))
                    {
                        Day += 19;
                        Month += 2;
                    }
                    else if ((Day >= 13) && (Day <= 31))
                    {
                        Day -= 12;
                        Month += 3;
                    }
                    Year += 621;
                    break;
                case 2:
                    if ((Day >= 1) && (Day <= 11))
                    {
                        Day += 19;
                        Month += 2;
                    }
                    else if ((Day >= 12) && (Day <= 31))
                    {
                        Day -= 11;
                        Month += 3;
                    }
                    Year += 621;
                    break;
                case 3:
                    if ((Day >= 1) && (Day <= 11))
                    {
                        Day += 20;
                        Month += 2;
                    }
                    else if ((Day >= 12) && (Day <= 31))
                    {
                        Day -= 11;
                        Month += 3;
                    }
                    Year += 621;
                    break;
                case 4:
                    if ((Day >= 1) && (Day <= 10))
                    {
                        Day += 20;
                        Month += 2;
                    }
                    else if ((Day >= 11) && (Day <= 31))
                    {
                        Day -= 10;
                        Month += 3;
                    }
                    Year += 621;
                    break;
                case 5:
                    if ((Day >= 1) && (Day <= 10))
                    {
                        Day += 21;
                        Month += 2;
                    }
                    else if ((Day >= 11) && (Day <= 31))
                    {
                        Day -= 10;
                        Month += 3;
                    }
                    Year += 621;
                    break;
                case 6:
                    if ((Day >= 1) && (Day <= 10))
                    {
                        Day += 21;
                        Month += 2;
                    }
                    else if ((Day >= 11) && (Day <= 31))
                    {
                        Day -= 10;
                        Month += 3;
                    }
                    Year += 621;
                    break;
                case 7:
                    if ((Day >= 1) && (Day <= 9))
                    {
                        Day += 21;
                        Month += 2;
                    }
                    else if ((Day >= 10) && (Day <= 30))
                    {
                        Day -= 9;
                        Month += 3;
                    }
                    Year += 621;
                    break;
                case 8:
                    if ((Day >= 1) && (Day <= 10))
                    {
                        Day += 21;
                        Month += 2;
                    }
                    else if ((Day >= 11) && (Day <= 30))
                    {
                        Day -= 10;
                        Month += 3;
                    }
                    Year += 621;
                    break;
                case 9:
                    if ((Day >= 1) && (Day <= 10))
                    {
                        Day += 20;
                        Month += 2;
                    }
                    else if ((Day >= 11) && (Day <= 30))
                    {
                        Day -= 10;
                        Month += 3;
                    }
                    Year += 621;
                    break;
                case 10:
                    if ((Day >= 1) && (Day <= 11) && (PersianLeapYear(Year)))
                    {
                        Day += 20;
                        Month += 2;
                        Year += 621;
                    }
                    else if ((Day >= 11) && (Day <= 30) && (!PersianLeapYear(Year)))
                    {
                        Day -= 10;
                        Month -= 9;
                        Year += 622;
                    }
                    break;
                case 11:
                    if ((Day >= 1) && (Day <= 11))
                    {
                        Day += 20;
                        Month -= 10;
                    }
                    else if ((Day >= 12) && (Day <= 30))
                    {
                        Day -= 11;
                        Month -= 9;
                    }
                    Year += 622;
                    break;
                case 12:
                    if ((Day >= 1) && (Day <= 10))
                    {
                        Day += 19;
                        Month -= 10;
                    }
                    else if ((Day >= 11) && (Day <= 29))
                    {
                        Day -= 10;
                        Month -= 9;
                    }
                    Year += 622;
                    break;
            }

            if (Month < 10)
                datestr = "0" + Month.ToString();
            else
                datestr = Month.ToString();

            datestr = datestr + "/";
            if (Day < 10)
                datestr = datestr + "0" + Day;
            else
                datestr = datestr + Day;

            datestr = datestr + "/";
            datestr = datestr + Year;

            return datestr;
        }
    }
}
