using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace Inlämningsuppgift1_JobApplicationTracker.Klasser
{
    public class JobApplication
    {
        public string CompanyName { get; set; }
        public string PositionTitle { get; set; }
        public enum ApplicationStatus
        {
            Applied,
            Interview,
            Offer,
            Rejected
        }
        public ApplicationStatus Status { get; set; }
        public DateTime ApplicationDate { get; set; }
        public DateTime? ResponseDate { get; set; }
        public int SalaryExpectation { get; set; }
        public int GetDaysSinceApplied() //returnerar antal dagar sedan ansökan skickades.
        {
            return (DateTime.Today - ApplicationDate.Date).Days;
        }
        public string GetSummary() //returnerar en kort sammanfattning av ansökan.
        {
           return $"{CompanyName} - {PositionTitle} | {Status} | " +
           $"Skickad: {ApplicationDate:yyyy-MM-dd} " +
           $"({GetDaysSinceApplied()} dagar sedan) | " +
           $"Önskad lön: {SalaryExpectation} kr";
        }
    }
}
