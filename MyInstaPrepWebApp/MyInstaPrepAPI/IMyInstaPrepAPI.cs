// Code generated by Microsoft (R) AutoRest Code Generator 0.9.6.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using Microsoft.Rest;
using MyInstaPrepWebApp;

namespace MyInstaPrepWebApp
{
    public partial interface IMyInstaPrepAPI : IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        Uri BaseUri
        {
            get; set; 
        }
        
        /// <summary>
        /// Credentials for authenticating with the service.
        /// </summary>
        ServiceClientCredentials Credentials
        {
            get; set; 
        }
        
        IDefault Default
        {
            get; 
        }
        
        IUsers Users
        {
            get; 
        }
    }
}
