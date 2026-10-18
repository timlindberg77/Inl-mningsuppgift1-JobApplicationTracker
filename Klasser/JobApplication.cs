using System;
using System.Collections.Generic;
using System.Text;

namespace Inlämningsuppgift1_JobApplicationTracker.Klasser
{
    public class JobApplication
    {

        //🔹 Klass: JobApplication

        //Attributer :
        //CompanyName | string
        //PositionTitle | string
        //Status | enum - (Applied, Interview, Offer, Rejected)
        //ApplicationDate | DateTime - Datum när ansökan skickades
        //ResponseDate | DateTime? - Datum när svar mottogs
        //SalaryExpectation | int - Önskad lön i kronor

        //Metoder:
        //GetDaysSinceApplied() – returnerar antal dagar sedan ansökan skickades.
        //GetSummary() – returnerar en kort sammanfattning av ansökan.
    }
}
