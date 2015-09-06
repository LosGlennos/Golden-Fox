﻿using System;

namespace GoldenFox.New
{
    public static class DateTimeExtensions
    {
        public static DateTime At(this DateTime @this, Clock clock)
        {
            return @this.Date.AddHours(clock.Hour).AddMinutes(clock.Minute).AddSeconds(clock.Seconds);
        }
    }
}