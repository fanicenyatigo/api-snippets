// Download the twilio-csharp library from
// https://www.twilio.com/docs/libraries/csharp#installation
using Newtonsoft.Json.Linq;
using System;
using Twilio;
using Twilio.Rest.Taskrouter.V1.Workspace.Worker;

class Example
{
    static void Main(string[] args)
    {
        // Find your Account Sid and Auth Token at twilio.com/console
        const string accountSid = "ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
        const string authToken = "your_auth_token";
        const string workspaceSid = "WSXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
        const string workerSid = "WKXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";

        TwilioClient.Init(accountSid, authToken);

        var stats = WorkerStatisticsResource.Fetch(workspaceSid, workerSid);
        var cumulativeStats = JObject.FromObject(stats.Cumulative);

        Console.WriteLine(cumulativeStats["reservations_accepted"]);
    }
}
