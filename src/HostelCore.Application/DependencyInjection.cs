using HostelCore.Application.Interfaces;
using HostelCore.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelCore.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IBookingService, BookingService>();
            services.AddScoped<IGuestService, GuestService>();
            services.AddScoped<IRoomService, RoomService>();

            return services;
        }
    }
}
