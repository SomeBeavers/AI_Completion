using CoreLibe;
using NUnit.Framework;
using System;
using System.IO;

namespace TestCore
{
    [TestFixture]
    [TestOf(typeof(SystemInfoPrinter))]
    public class SystemInfoPrinterTest
    {
        private SystemInfoPrinter _systemInfoPrinter;
        private StringWriter _stringWriter;

        [SetUp]
        public void SetUp()
        {
            _systemInfoPrinter = new SystemInfoPrinter();
            _stringWriter = new StringWriter();
            Console.SetOut(_stringWriter);
        }

        [TearDown]
        public void TearDown()
        {
            _stringWriter.Dispose();
        }
        [Test]
        public void PrintInfo_ShouldPrintOperatingSystem()
        {
            _systemInfoPrinter.PrintInfo();
            StringAssert.Contains("Operating System: " + Environment.OSVersion, _stringWriter.ToString());
        }

        [Test]
        public void PrintInfo_ShouldPrintProcessorCount()
        {
            _systemInfoPrinter.PrintInfo();
            StringAssert.Contains("Processor Count: " + Environment.ProcessorCount, _stringWriter.ToString());
        }

        [Test]
        public void PrintInfo_ShouldPrintSystemDirectory()
        {
            _systemInfoPrinter.PrintInfo();
            StringAssert.Contains("System Directory: " + Environment.SystemDirectory, _stringWriter.ToString());
        }

        [Test]
        public void PrintInfo_ShouldPrintUserDomainName()
        {
            _systemInfoPrinter.PrintInfo();
            StringAssert.Contains("User Domain Name: " + Environment.UserDomainName, _stringWriter.ToString());
        }

        [Test]
        public void PrintInfo_ShouldPrintUserName()
        {
            _systemInfoPrinter.PrintInfo();
            StringAssert.Contains("User Name: " + Environment.UserName, _stringWriter.ToString());
        }
        [Test]
        public void PrintInfo_ShouldPrintMachineName()
        {
            _systemInfoPrinter.PrintInfo();
            StringAssert.Contains("Machine Name: " + Environment.MachineName, _stringWriter.ToString());
        }
    }
}