/* 
 * LocationIQ
 *
 * LocationIQ provides flexible enterprise-grade location based solutions. We work with developers, startups and enterprises worldwide serving billions of requests everyday. This page provides an overview of the technical aspects of our API and will help you get started.
 *
 * The version of the OpenAPI document: 1.1.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Org.OpenAPITools.Client;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Test
{
    /// <summary>
    ///  Class for testing AutocompleteApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AutocompleteApiTests
    {
        private AutocompleteApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AutocompleteApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AutocompleteApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' AutocompleteApi
            //Assert.IsInstanceOf(typeof(AutocompleteApi), instance);
        }

        
        /// <summary>
        /// Test Autocomplete
        /// </summary>
        [Test]
        public void AutocompleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string q = null;
            //int normalizecity = null;
            //int limit = null;
            //string viewbox = null;
            //int bounded = null;
            //string countrycodes = null;
            //string acceptLanguage = null;
            //string tag = null;
            //var response = instance.Autocomplete(q, normalizecity, limit, viewbox, bounded, countrycodes, acceptLanguage, tag);
            //Assert.IsInstanceOf(typeof(List<Object>), response, "response is List<Object>");
        }
        
    }

}