using InternshipApp.Core.Common.Interfaces;
using System;

namespace InternshipApp.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
