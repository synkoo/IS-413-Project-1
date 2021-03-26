using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;

//Populate the database with timeslots

namespace TempleTourScheduler.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            TempleTourDbContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<TempleTourDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.TimeBlocks.Any())
            {
                context.TimeBlocks.AddRange(

                    new TimeBlock
                    {
                        DayOfWeek = "Monday",
                        HourBlock = "08:00",
                        IsBooked = false
                    },
                    new TimeBlock
                    {
                        DayOfWeek = "Monday",
                        HourBlock = "09:00",
                        IsBooked = false
                    },
                    new TimeBlock
                    {
                        DayOfWeek = "Monday",
                        HourBlock = "10:00",
                        IsBooked = false
                    },
                    new TimeBlock
                    {
                        DayOfWeek = "Monday",
                        HourBlock = "11:00",
                        IsBooked = false
                    },
                    new TimeBlock
                    {
                        DayOfWeek = "Monday",
                        HourBlock = "12:00",
                        IsBooked = false
                    },
                    new TimeBlock
                    {
                        DayOfWeek = "Monday",
                        HourBlock = "13:00",
                        IsBooked = false
                    },
                    new TimeBlock
                    {
                        DayOfWeek = "Monday",
                        HourBlock = "14:00",
                        IsBooked = false
                    },
                    new TimeBlock
                    {
                        DayOfWeek = "Monday",
                        HourBlock = "15:00",
                        IsBooked = false
                    },
                    new TimeBlock
                    {
                        DayOfWeek = "Monday",
                        HourBlock = "16:00",
                        IsBooked = false
                    },
                    new TimeBlock
                    {
                        DayOfWeek = "Monday",
                        HourBlock = "17:00",
                        IsBooked = false
                    },
                    new TimeBlock
                    {
                        DayOfWeek = "Monday",
                        HourBlock = "18:00",
                        IsBooked = false
                    },
                    new TimeBlock
                    {
                        DayOfWeek = "Monday",
                        HourBlock = "19:00",
                        IsBooked = false
                    },
                    new TimeBlock
                    {
                        DayOfWeek = "Monday",
                        HourBlock = "20:00",
                        IsBooked = false
                    },
                    new TimeBlock
                    { DayOfWeek = "Tuesday", HourBlock = "08:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Tuesday", HourBlock = "09:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Tuesday", HourBlock = "10:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Tuesday", HourBlock = "11:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Tuesday", HourBlock = "12:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Tuesday", HourBlock = "13:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Tuesday", HourBlock = "14:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Tuesday", HourBlock = "15:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Tuesday", HourBlock = "16:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Tuesday", HourBlock = "17:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Tuesday", HourBlock = "18:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Tuesday", HourBlock = "19:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Tuesday", HourBlock = "20:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Wednesday", HourBlock = "08:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Wednesday", HourBlock = "09:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Wednesday", HourBlock = "10:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Wednesday", HourBlock = "11:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Wednesday", HourBlock = "12:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Wednesday", HourBlock = "13:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Wednesday", HourBlock = "14:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Wednesday", HourBlock = "15:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Wednesday", HourBlock = "16:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Wednesday", HourBlock = "17:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Wednesday", HourBlock = "18:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Wednesday", HourBlock = "19:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Wednesday", HourBlock = "20:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Thursday", HourBlock = "08:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Thursday", HourBlock = "09:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Thursday", HourBlock = "10:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Thursday", HourBlock = "11:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Thursday", HourBlock = "12:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Thursday", HourBlock = "13:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Thursday", HourBlock = "14:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Thursday", HourBlock = "15:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Thursday", HourBlock = "16:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Thursday", HourBlock = "17:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Thursday", HourBlock = "18:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Thursday", HourBlock = "19:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Thursday", HourBlock = "20:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Friday", HourBlock = "08:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Friday", HourBlock = "09:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Friday", HourBlock = "10:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Friday", HourBlock = "11:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Friday", HourBlock = "12:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Friday", HourBlock = "13:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Friday", HourBlock = "14:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Friday", HourBlock = "15:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Friday", HourBlock = "16:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Friday", HourBlock = "17:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Friday", HourBlock = "18:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Friday", HourBlock = "19:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Friday", HourBlock = "20:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Saturday", HourBlock = "08:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Saturday", HourBlock = "09:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Saturday", HourBlock = "10:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Saturday", HourBlock = "11:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Saturday", HourBlock = "12:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Saturday", HourBlock = "13:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Saturday", HourBlock = "14:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Saturday", HourBlock = "15:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Saturday", HourBlock = "16:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Saturday", HourBlock = "17:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Saturday", HourBlock = "18:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Saturday", HourBlock = "19:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Saturday", HourBlock = "20:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Sunday", HourBlock = "08:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Sunday", HourBlock = "09:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Sunday", HourBlock = "10:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Sunday", HourBlock = "11:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Sunday", HourBlock = "12:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Sunday", HourBlock = "13:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Sunday", HourBlock = "14:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Sunday", HourBlock = "15:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Sunday", HourBlock = "16:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Sunday", HourBlock = "17:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Sunday", HourBlock = "18:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Sunday", HourBlock = "19:00", IsBooked = false },
                    new TimeBlock
                    { DayOfWeek = "Sunday", HourBlock = "20:00", IsBooked = false }
                );

                context.SaveChanges();
            }
        }
    }
}
