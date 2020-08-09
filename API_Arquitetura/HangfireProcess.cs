using Hangfire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Arquitetura
{
    public class HangfireProcess
    {
        public static void Start()
        {
            //var division = new TesteHangfire();
            //RecurringJob.AddOrUpdate(() => division.DivisionRandom(), "*/5 * * * *"); // A cada 5 minutos
        }
    }
}
