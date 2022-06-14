// See https://aka.ms/new-console-template for more information
using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

TwilioClient.Init(
    "AC027f1041d6cecff11ee9d9d2a2d8ce33",
    "8a59009e1bf5948354eaf0fa02472b3f"
);

// var message = MessageResource.Create(
//     from: new PhoneNumber("whatsapp:+14155238886"),
//     to: new PhoneNumber("whatsapp:+919762387966"),
//     body: "Liverpool sucks!"
// );
var number = "+919527132745";
var message = "Helloooo";
var value = "http://api.whatsapp.com/send?phone=" + number + "&text=" + message;
// System.Diagnostics.Process.Start(value);
var result = new System.Net.WebClient().DownloadString(value);

// Console.WriteLine("Message SID:" + message.Sid);
