using System;

class TimeZoneDemo1
{
    static void Main()
    {
        //get current UTC time
        DateTimeOffset utcNow=DateTimeOffset.UtcNow;

        //GMT
        TimeZoneInfo gmtZone=TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
        DateTimeOffset gmtTime=TimeZoneInfo.ConvertTime(utcNow,gmtZone);
        Console.WriteLine("GMT Time: "+gmtTime);

        //IST
        TimeZoneInfo istZone=TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
        DateTimeOffset istTime=TimeZoneInfo.ConvertTime(utcNow,istZone);
        Console.WriteLine("IST Time: "+istTime);

        //PST
        TimeZoneInfo pstZone=TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
        DateTimeOffset pstTime=TimeZoneInfo.ConvertTime(utcNow,pstZone);
        Console.WriteLine("PST Time: "+pstTime);
    }
}
