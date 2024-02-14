using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AstroApi.Utils.Extends
{
    public static class RequestExtensions
    {
        public static async Task<string> ReadAsStringAsync(
            this Stream requestBody,
            bool leaveOpen = false
        )
        {
            using StreamReader reader = new(requestBody, leaveOpen: leaveOpen);
            var bodyAsString = await reader.ReadToEndAsync();
            return bodyAsString;
        }
    }
}
