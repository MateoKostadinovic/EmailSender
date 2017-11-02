using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailSender;

namespace EmailSenderConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MailClient oMailClient = new MailClient();
            oMailClient.SendEmail("mateo.kostadinovic@vsmti.hr","Naslov","Pozdrav");
        }
    }
}
