using CleanArq.Application.Common.Interfaces;
using System;

namespace CleanArq.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
