using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT_Project
{
    public class CompteSMS
    {
        public IServiceSMS Service { get; set; } = new ServiceSMSTwilio();
        public List<SMS> SMSEnvoyés { get; set; } = new List<SMS>();
        public List<SMS> SMSRejetés { get; set; } = new List<SMS>();

        public void ajouterSMSEnvoyé(SMS monSMS)
        {
            if (!String.IsNullOrEmpty(monSMS.Destinataire) && !String.IsNullOrEmpty(monSMS.Message))
            {
                int resultat = Service.EnvoyerSMS(monSMS);

                if (resultat == 1)
                {
                    SMSEnvoyés.Add(monSMS);
                }
                else if(resultat == -1)
                {
                    SMSRejetés.Add(monSMS);
                }
            }
            else
            {
                SMSRejetés.Add(monSMS);
            }
        }
    }
}
