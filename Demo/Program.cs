using locationiq.Api;
using locationiq.Client;
using locationiq.Model;
using System;
using System.Diagnostics;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Configuration.Default.BasePath = "https://eu1.locationiq.com/v1";
            // Configure API key authorization: key
            Configuration.Default.AddApiKey("key", "pk.6de890e15841641179879513eb37ae96");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("key", "Bearer");

            var apiInstance = new ReverseApi(Configuration.Default);
            decimal lat = 40.7487727M;  // decimal | Latitude of the location to generate an address for.
            decimal lon = -73.9849336M;  // decimal | Longitude of the location to generate an address for.
            var format = "json";  // string | Format to geocode. Only JSON supported for SDKs
            var normalizecity = 1;  // int | Normalizes village to city level data to city
            var addressdetails = 1;  // int | Include a breakdown of the address into elements. Defaults to 1. (optional)  (default to 1)
            var acceptLanguage = "en";  // string | Preferred language order for showing search results, overrides the value specified in the Accept-Language HTTP header. Defaults to en. To use native language for the response when available, use accept-language=native (optional) 
            var namedetails = 0;  // int | Include a list of alternative names in the results. These may include language variants, references, operator and brand. (optional) 
            var extratags = 0;  // int | Include additional information in the result if available, e.g. wikipedia link, opening hours. (optional) 
            var statecode = 0;  // int | Adds state or province code when available to the statecode key inside the address element. Currently supported for addresses in the USA, Canada and Australia. Defaults to 0 (optional) 
            var showdistance = 0;  // int | Returns the straight line distance (meters) between the input location and the result's location. Value is set in the distance key of the response. Defaults to 0 [0,1] (optional) 
            var postaladdress = 0;  // int | Returns address inside the postaladdress key, that is specifically formatted for each country. Currently supported for addresses in Germany. Defaults to 0 [0,1] (optional) 

            try
            {
                // Reverse Geocoding
                Location result = apiInstance.Reverse(lat, lon, format, normalizecity, addressdetails, acceptLanguage, namedetails, extratags, statecode, showdistance, postaladdress);
                Debug.WriteLine(result);
              //  return result.DisplayName;
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ReverseApi.Reverse: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
              //  return e.Message;
            }
        }
    }
}
