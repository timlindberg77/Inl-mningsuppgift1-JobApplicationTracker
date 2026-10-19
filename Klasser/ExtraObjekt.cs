using System;
using System.Collections.Generic;
using System.Text;
using static Inlämningsuppgift1_JobApplicationTracker.Klasser.JobApplication;

namespace Inlämningsuppgift1_JobApplicationTracker.Klasser
{
    public static class TestData
    {
        // Fyller JobManager med exempelansökningar
        public static void AddSampleApplications(JobManager manage)
        {
            manage.Applications.Add(new JobApplication
            {
                CompanyName = "Volvo",
                PositionTitle = "Systemutvecklare",
                Status = ApplicationStatus.Applied,
                ApplicationDate = DateTime.Today.AddDays(-20),
                ResponseDate = null,
                SalaryExpectation = 42000
            });

            manage.Applications.Add(new JobApplication
            {
                CompanyName = "Spotify",
                PositionTitle = "Backend-utvecklare",
                Status = ApplicationStatus.Interview,
                ApplicationDate = DateTime.Today.AddDays(-12),
                ResponseDate = DateTime.Today.AddDays(-6),
                SalaryExpectation = 55000
            });

            manage.Applications.Add(new JobApplication
            {
                CompanyName = "IKEA",
                PositionTitle = "Junior .NET-utvecklare",
                Status = ApplicationStatus.Offer,
                ApplicationDate = DateTime.Today.AddDays(-30),
                ResponseDate = DateTime.Today.AddDays(-22),
                SalaryExpectation = 38000
            });

            manage.Applications.Add(new JobApplication
            {
                CompanyName = "Ericsson",
                PositionTitle = "Mjukvaruutvecklare",
                Status = ApplicationStatus.Rejected,
                ApplicationDate = DateTime.Today.AddDays(-25),
                ResponseDate = DateTime.Today.AddDays(-15),
                SalaryExpectation = 45000
            });

            manage.Applications.Add(new JobApplication
            {
                CompanyName = "Klarna",
                PositionTitle = "Fullstack-utvecklare",
                Status = ApplicationStatus.Applied,
                ApplicationDate = DateTime.Today.AddDays(-3),
                ResponseDate = null,
                SalaryExpectation = 48000
            });

            manage.Applications.Add(new JobApplication
            {
                CompanyName = "H&M",
                PositionTitle = "Applikationsutvecklare",
                Status = ApplicationStatus.Interview,
                ApplicationDate = DateTime.Today.AddDays(-9),
                ResponseDate = DateTime.Today.AddDays(-4),
                SalaryExpectation = 40000
            });
        }
    }
}
