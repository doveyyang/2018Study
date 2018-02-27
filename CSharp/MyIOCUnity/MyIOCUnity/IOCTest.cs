using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kiloway.Interface;
//using Kiloway.Service;
using Microsoft.Practices.Unity.Configuration;
using Unity;

namespace MyIOCUnity
{
    public class IOCTest
    {
        public void Show()
        {
            //{
            //    IPhone phone = new ApplePhone();
            //    phone.Call();
            //    phone.System();
            //}

            //{
            //    IUnityContainer container = new UnityContainer();
            //    container.RegisterType<IPhone, ApplePhone>();
            //    container.RegisterType<IHead, Head>();
            //    container.RegisterType<IMicro, Micro>();

            //    IPhone phone = container.Resolve<IPhone>();
            //    phone.Call();
            //    phone.System();
            //}
            {

                IUnityContainer container = new UnityContainer();
                ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap();
                fileMap.ExeConfigFilename = Path.Combine(AppDomain.CurrentDomain.BaseDirectory+"Unity.config.xml");

                Configuration configuration = ConfigurationManager.OpenMappedExeConfiguration(fileMap,ConfigurationUserLevel.None);
                UnityConfigurationSection section = (UnityConfigurationSection)configuration.GetSection(UnityConfigurationSection.SectionName);
                section.Configure(container, "testContainer");

                IPhone phone = container.Resolve<IPhone>();
                phone.Call();
                phone.System();

            }
        }
    }
}
