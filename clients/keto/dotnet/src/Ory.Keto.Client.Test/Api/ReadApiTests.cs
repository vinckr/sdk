/*
 * ORY Keto
 *
 * Ory Keto is a cloud native access control server providing best-practice patterns (RBAC, ABAC, ACL, AWS IAM Policies, Kubernetes Roles, ...) via REST APIs.
 *
 * The version of the OpenAPI document: v0.7.0-alpha.1
 * Contact: hi@ory.sh
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Ory.Keto.Client.Client;
using Ory.Keto.Client.Api;
// uncomment below to import models
//using Ory.Keto.Client.Model;

namespace Ory.Keto.Client.Test.Api
{
    /// <summary>
    ///  Class for testing ReadApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ReadApiTests : IDisposable
    {
        private ReadApi instance;

        public ReadApiTests()
        {
            instance = new ReadApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ReadApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ReadApi
            //Assert.IsType<ReadApi>(instance);
        }

        /// <summary>
        /// Test GetCheck
        /// </summary>
        [Fact]
        public void GetCheckTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string _namespace = null;
            //string _object = null;
            //string relation = null;
            //string subjectId = null;
            //string subjectSetNamespace = null;
            //string subjectSetObject = null;
            //string subjectSetRelation = null;
            //var response = instance.GetCheck(_namespace, _object, relation, subjectId, subjectSetNamespace, subjectSetObject, subjectSetRelation);
            //Assert.IsType<KetoGetCheckResponse>(response);
        }

        /// <summary>
        /// Test GetExpand
        /// </summary>
        [Fact]
        public void GetExpandTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string _namespace = null;
            //string _object = null;
            //string relation = null;
            //long maxDepth = null;
            //var response = instance.GetExpand(_namespace, _object, relation, maxDepth);
            //Assert.IsType<KetoExpandTree>(response);
        }

        /// <summary>
        /// Test GetRelationTuples
        /// </summary>
        [Fact]
        public void GetRelationTuplesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string _namespace = null;
            //string pageToken = null;
            //long? pageSize = null;
            //string _object = null;
            //string relation = null;
            //string subjectId = null;
            //string subjectSetNamespace = null;
            //string subjectSetObject = null;
            //string subjectSetRelation = null;
            //var response = instance.GetRelationTuples(_namespace, pageToken, pageSize, _object, relation, subjectId, subjectSetNamespace, subjectSetObject, subjectSetRelation);
            //Assert.IsType<KetoGetRelationTuplesResponse>(response);
        }

        /// <summary>
        /// Test PostCheck
        /// </summary>
        [Fact]
        public void PostCheckTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //KetoRelationQuery payload = null;
            //var response = instance.PostCheck(payload);
            //Assert.IsType<KetoGetCheckResponse>(response);
        }
    }
}
