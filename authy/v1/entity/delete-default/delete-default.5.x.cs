// Install the C# / .NET helper library from twilio.com/docs/csharp/install

using System;
using Twilio;
using Twilio.Rest.Authy.V1.Service;


class Program 
{
    static void Main(string[] args)
    {
        // Find your Account Sid and Token at twilio.com/console
        // DANGER! This is insecure. See http://twil.io/secure
        const string accountSid = "ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
        const string authToken = "your_auth_token";

        TwilioClient.Init(accountSid, authToken);

        EntityResource.Delete(
            pathServiceSid: "ISXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
            pathIdentity: "pathIdentity"
        );
    }
}