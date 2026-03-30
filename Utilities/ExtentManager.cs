using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;

namespace ParabankAutomation.Utilities
{
    public class ExtentManager
    {
        private static ExtentReports extent;

        public static ExtentReports GetInstance()
        {
            if (extent == null)
            {
                string reportPath = AppDomain.CurrentDomain.BaseDirectory + "ExtentReport.html";

                var sparkReporter = new ExtentSparkReporter(reportPath);

                extent = new ExtentReports();
                extent.AttachReporter(sparkReporter);
            }
            return extent;
        }
    }
}