using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;

namespace WCFServiceWebRole1
{
    [AspNetCompatibilityRequirements(RequirementsMode =
         AspNetCompatibilityRequirementsMode.Allowed)]
    public class ServiceRandomNumbers : IServiceRandomNumbers
    {
        public List<int> GetRandomNumbers()
        {
            List<int> numeros = new List<int>();
            Random random = new Random();
            for (int i = 1; i <= 10; i++)
            {
                int num = random.Next(1, 1000);
                numeros.Add(num);
            }
            return numeros;
        }
    }
}
