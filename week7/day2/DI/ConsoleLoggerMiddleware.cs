using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace DI
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class ConsoleLoggerMiddleware : IMiddleware
    {
        private Printer printer;
        private IColor color;
        public ConsoleLoggerMiddleware(Printer printer, IColor color)
        {
            this.printer = printer;
            this.color = color;
        }
        public Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            printer.Log("Hello");
            color.PrintColor();
            return next(context);
        }
    }
}
