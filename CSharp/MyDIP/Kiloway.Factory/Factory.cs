using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Kiloway.IBLL;
using Kiloway.IDAL;

namespace Kiloway.Factory
{
    public class Factory
    {
        public static AbstractPhone GetAbstractPhone(PhoneType phoneType)
        {
            string dllName = System.Configuration.ConfigurationManager.AppSettings[phoneType.ToString()];
            Assembly assembly = Assembly.Load(dllName.Split(',')[1]);
            Type type = assembly.GetType(dllName.Split(',')[0]);
            AbstractPhone phone = (AbstractPhone)Activator.CreateInstance(type);
            return phone;
      }

        public static IPersonService GetPersonService(string objName)
        {
            string dllName = System.Configuration.ConfigurationManager.AppSettings[objName];
            Assembly assembly = Assembly.Load(dllName.Split(',')[1]);
            Type type = assembly.GetType(dllName.Split(',')[0]);
            IPersonService service = (IPersonService) Activator.CreateInstance(type);
            return service;
        }
    }
    public enum PhoneType
    {
        Apple,
        Vivo,
        Luima
    }
}
