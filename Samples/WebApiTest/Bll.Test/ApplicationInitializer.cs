using Cicada.Boot;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BllTest
{
    [TestClass]
    public class ApplicationInitializer
    { 
        [AssemblyInitialize]
        public static void Run(TestContext context)
        {
            CicadaApplication.Run();
        }
    }
}
