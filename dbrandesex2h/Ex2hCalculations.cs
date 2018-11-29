using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dbrandesex2h
{
    public class Ex2hCalculations
    {
        public static string DateCalc06(string strYear, string strMonth, string strDay)
        {
            string result = "Invalid input";
            DateTime date;
            try
            {
                int year = Int32.Parse(strYear);
                int month = Int32.Parse(strMonth);
                int day = Int32.Parse(strDay);
                date = new DateTime(year, month, day);
                result = date.ToShortDateString();
            }
            catch { }

            return result;
        }
        public static string DateCalc07(string strDate)
        {
            string result = "Invalid input";
            DateTime date;
            try
            {
                date = DateTime.Parse(strDate);
                result = date.ToShortDateString();
            }
            catch { }

            return result;
        }
        public static string DateCalc08(string strDate)
        {
            string result = "Invalid input";
            DateTime date;
            DateTime.TryParse(strDate, out date);
            result = date.ToShortDateString();
   
            return result;
        }
        public static string DateCalc09(string strDateA, string strDateB)
        {
            string result = "Invalid input";
            DateTime dateA;
            DateTime dateB;
            try
            {
                dateA = DateTime.Parse(strDateA);
                dateB = DateTime.Parse(strDateB);
                TimeSpan timeBetween = dateA.Subtract(dateB);
                int daysBetween = timeBetween.Days;
                result = timeBetween.ToString() + "days";
            }
            catch { }

            return result;
        }
        public static string DateCalc10(string strDateA, string strDateB)
        {
            string result = "Invalid input";
            DateTime dateA;
            DateTime dateB;
            try
            {
                bool pastDue = false;
                dateA = DateTime.Parse(strDateA);
                dateB = DateTime.Parse(strDateB);
                if (dateB > dateA)
                    pastDue = true;

                TimeSpan timeBetween = dateA.Subtract(dateB);
                int daysBetween = timeBetween.Days;
                result = timeBetween.ToString() + "days past due";
                        

            }
            catch {  }

            try
            {
                else if (dateB <= dateA)
                    result = "On time";
            }

            catch { }

            return result;
        }
        public static string StringCalc01(string s)
        {
            string result = "Invalid Input";
            int index1 = s.IndexOf(" ");

            try
            {
                s = s.Remove(0, index1 + 1);
                s = s.Insert(s.Length, "cr");
              
            }

            catch { }

                return result;
        }
        public static string StringCalc02(string s)
        {
            string result = "Invalid Input";
            int index1 = s.IndexOf(" ");

            try
            {
                s = s.Remove(0, index1 + 1);
                s = s.Insert(s.Length, "cr");

            }

            catch { }

            return result;
        }
        public static string StringCalc03(string s)
        {
            string result = "Invalid Input";
            int index1 = s.IndexOf(" ");

            try
            {
                s = s.Remove(0, index1 + 1);
                s = s.Insert(s.Length, "cr");

            }

            catch { }

            return result;
        }
        public static string StringCalc04(string s)
        {
            string result = "Invalid Input";
            int index1 = s.IndexOf(" ");

            try
            {
                s = s.Remove(0, index1 + 1);
                s = s.Insert(s.Length, "cr");

            }

            catch { }

            return result;
        }
        public static string StringCalc05(string s)
        {
            string result = "Invalid Input";
            int index1 = s.IndexOf(" ");

            try
            {
                s = s.Remove(0, index1 + 1);
                s = s.Insert(s.Length, "cr");

            }

            catch { }

            return result;
        }
        public static string StringCalc06(string s)
        {
            string result = "Invalid Input";
            int index1 = s.IndexOf(" ");

            try
            {
                s = s.Remove(0, index1 + 1);
                s = s.Insert(s.Length, "cr");

            }

            catch { }

            return result;
        }
        public static string StringCalc07(string s)
        {
            string result = "Invalid Input";
            int index1 = s.IndexOf(" ");

            try
            {
                s = s.Remove(0, index1 + 1);
                s = s.Insert(s.Length, "cr");

            }

            catch { }

            return result;
        }
        public static string StringCalc08(string s)
        {
            string result = "Invalid Input";
            int index1 = s.IndexOf(" ");

            try
            {
                s = s.Remove(0, index1 + 1);
                s = s.Insert(s.Length, "cr");

            }

            catch { }

            return result;
        }
        public static string StringCalc09(string s)
        {
            string result = "Invalid Input";
            int index1 = s.IndexOf(" ");

            try
            {
                s = s.Remove(0, index1 + 1);
                s = s.Insert(s.Length, "cr");

            }

            catch { }

            return result;
        }
        public static string StringCalc10(string s1 string s2 string s3)
        {
            string result = "Invalid Input";
            int index1 = s1.IndexOf(" ");

            try
            {
                s1 = s1.Remove(0, index1 + 1);
                s1 = s1.Insert(s1.Length, "cr");

            }

            catch { }

            return result;
        }
    }
}