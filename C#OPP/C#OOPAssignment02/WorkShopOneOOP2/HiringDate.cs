using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShopOneOOP2;

	public class HiringDate
	{
		private int day;
		private int month;
		private int year;

    public HiringDate()
    {
        
    }
    public HiringDate(int day , int month , int year)
    {
        this.day = day;
        this.month = month;
        this.year = year;
    }

    public int Year
    {
        get { return year; }
        set { year = value >= 2000 && value <= 2024 ? value : 2020; }
    }
    public int Month
    {
        get { return month; }
        set { month = value >= 1 && value <= 12 ? value : 5;  }
    }
    public int Day
    {
        get { return day; }
        set { day = value >= 1 && value <= 31 ? value : 3; }
    }
		public override string ToString()
		{
        return $"Day = {Day} , Month = {Month} , Year = {Year}";
		}
	}
