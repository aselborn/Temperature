using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Temperature
{
    public interface IBootstrap
    {
        ApplicationConfig Setup();
    }

    public class BootStrap : IBootstrap
    {
        private readonly ApplicationConfig _applicationConfig;
        public BootStrap(ApplicationConfig config)
        {
            _applicationConfig = config;
        }


        public ApplicationConfig Setup()
        {
            return _applicationConfig;
        }
    }
}
