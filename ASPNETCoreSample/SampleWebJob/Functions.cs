using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;

namespace SampleWebJob
{
    public class Functions
    {
        // This function will get triggered/executed when a new message is written 
        // on an Azure Queue called queue.
        public static void ProcessQueueMessage([TimerTrigger("0 0 */24 * * *", RunOnStartup = true)] TimerInfo timerInfo, TextWriter log)
        {
            log.WriteLine("processing...");
        }
    }
}
