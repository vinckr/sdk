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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Ory.Keto.Client.Client;
using Ory.Keto.Client.Model;

namespace Ory.Keto.Client.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IHealthApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Check alive status
        /// </summary>
        /// <remarks>
        /// This endpoint returns a 200 status code when the HTTP server is up running. This status does currently not include checks whether the database connection is working.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the health status will never refer to the cluster state, only to a single instance.
        /// </remarks>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>KetoHealthStatus</returns>
        KetoHealthStatus IsInstanceAlive();

        /// <summary>
        /// Check alive status
        /// </summary>
        /// <remarks>
        /// This endpoint returns a 200 status code when the HTTP server is up running. This status does currently not include checks whether the database connection is working.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the health status will never refer to the cluster state, only to a single instance.
        /// </remarks>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of KetoHealthStatus</returns>
        ApiResponse<KetoHealthStatus> IsInstanceAliveWithHttpInfo();
        /// <summary>
        /// Check readiness status
        /// </summary>
        /// <remarks>
        /// This endpoint returns a 200 status code when the HTTP server is up running and the environment dependencies (e.g. the database) are responsive as well.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the health status will never refer to the cluster state, only to a single instance.
        /// </remarks>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>KetoHealthStatus</returns>
        KetoHealthStatus IsInstanceReady();

        /// <summary>
        /// Check readiness status
        /// </summary>
        /// <remarks>
        /// This endpoint returns a 200 status code when the HTTP server is up running and the environment dependencies (e.g. the database) are responsive as well.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the health status will never refer to the cluster state, only to a single instance.
        /// </remarks>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of KetoHealthStatus</returns>
        ApiResponse<KetoHealthStatus> IsInstanceReadyWithHttpInfo();
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IHealthApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Check alive status
        /// </summary>
        /// <remarks>
        /// This endpoint returns a 200 status code when the HTTP server is up running. This status does currently not include checks whether the database connection is working.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the health status will never refer to the cluster state, only to a single instance.
        /// </remarks>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of KetoHealthStatus</returns>
        System.Threading.Tasks.Task<KetoHealthStatus> IsInstanceAliveAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Check alive status
        /// </summary>
        /// <remarks>
        /// This endpoint returns a 200 status code when the HTTP server is up running. This status does currently not include checks whether the database connection is working.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the health status will never refer to the cluster state, only to a single instance.
        /// </remarks>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (KetoHealthStatus)</returns>
        System.Threading.Tasks.Task<ApiResponse<KetoHealthStatus>> IsInstanceAliveWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Check readiness status
        /// </summary>
        /// <remarks>
        /// This endpoint returns a 200 status code when the HTTP server is up running and the environment dependencies (e.g. the database) are responsive as well.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the health status will never refer to the cluster state, only to a single instance.
        /// </remarks>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of KetoHealthStatus</returns>
        System.Threading.Tasks.Task<KetoHealthStatus> IsInstanceReadyAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Check readiness status
        /// </summary>
        /// <remarks>
        /// This endpoint returns a 200 status code when the HTTP server is up running and the environment dependencies (e.g. the database) are responsive as well.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the health status will never refer to the cluster state, only to a single instance.
        /// </remarks>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (KetoHealthStatus)</returns>
        System.Threading.Tasks.Task<ApiResponse<KetoHealthStatus>> IsInstanceReadyWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IHealthApi : IHealthApiSync, IHealthApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class HealthApi : IHealthApi
    {
        private Ory.Keto.Client.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="HealthApi"/> class.
        /// </summary>
        /// <returns></returns>
        public HealthApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HealthApi"/> class.
        /// </summary>
        /// <returns></returns>
        public HealthApi(string basePath)
        {
            this.Configuration = Ory.Keto.Client.Client.Configuration.MergeConfigurations(
                Ory.Keto.Client.Client.GlobalConfiguration.Instance,
                new Ory.Keto.Client.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Ory.Keto.Client.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Ory.Keto.Client.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Ory.Keto.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HealthApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public HealthApi(Ory.Keto.Client.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Ory.Keto.Client.Client.Configuration.MergeConfigurations(
                Ory.Keto.Client.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Ory.Keto.Client.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Ory.Keto.Client.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Ory.Keto.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HealthApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public HealthApi(Ory.Keto.Client.Client.ISynchronousClient client, Ory.Keto.Client.Client.IAsynchronousClient asyncClient, Ory.Keto.Client.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Ory.Keto.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Ory.Keto.Client.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Ory.Keto.Client.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Ory.Keto.Client.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Ory.Keto.Client.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Check alive status This endpoint returns a 200 status code when the HTTP server is up running. This status does currently not include checks whether the database connection is working.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the health status will never refer to the cluster state, only to a single instance.
        /// </summary>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>KetoHealthStatus</returns>
        public KetoHealthStatus IsInstanceAlive()
        {
            Ory.Keto.Client.Client.ApiResponse<KetoHealthStatus> localVarResponse = IsInstanceAliveWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Check alive status This endpoint returns a 200 status code when the HTTP server is up running. This status does currently not include checks whether the database connection is working.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the health status will never refer to the cluster state, only to a single instance.
        /// </summary>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of KetoHealthStatus</returns>
        public Ory.Keto.Client.Client.ApiResponse<KetoHealthStatus> IsInstanceAliveWithHttpInfo()
        {
            Ory.Keto.Client.Client.RequestOptions localVarRequestOptions = new Ory.Keto.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Ory.Keto.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Ory.Keto.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request
            var localVarResponse = this.Client.Get<KetoHealthStatus>("/health/alive", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("IsInstanceAlive", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Check alive status This endpoint returns a 200 status code when the HTTP server is up running. This status does currently not include checks whether the database connection is working.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the health status will never refer to the cluster state, only to a single instance.
        /// </summary>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of KetoHealthStatus</returns>
        public async System.Threading.Tasks.Task<KetoHealthStatus> IsInstanceAliveAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Ory.Keto.Client.Client.ApiResponse<KetoHealthStatus> localVarResponse = await IsInstanceAliveWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Check alive status This endpoint returns a 200 status code when the HTTP server is up running. This status does currently not include checks whether the database connection is working.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the health status will never refer to the cluster state, only to a single instance.
        /// </summary>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (KetoHealthStatus)</returns>
        public async System.Threading.Tasks.Task<Ory.Keto.Client.Client.ApiResponse<KetoHealthStatus>> IsInstanceAliveWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Ory.Keto.Client.Client.RequestOptions localVarRequestOptions = new Ory.Keto.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Ory.Keto.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Ory.Keto.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<KetoHealthStatus>("/health/alive", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("IsInstanceAlive", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Check readiness status This endpoint returns a 200 status code when the HTTP server is up running and the environment dependencies (e.g. the database) are responsive as well.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the health status will never refer to the cluster state, only to a single instance.
        /// </summary>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>KetoHealthStatus</returns>
        public KetoHealthStatus IsInstanceReady()
        {
            Ory.Keto.Client.Client.ApiResponse<KetoHealthStatus> localVarResponse = IsInstanceReadyWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Check readiness status This endpoint returns a 200 status code when the HTTP server is up running and the environment dependencies (e.g. the database) are responsive as well.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the health status will never refer to the cluster state, only to a single instance.
        /// </summary>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of KetoHealthStatus</returns>
        public Ory.Keto.Client.Client.ApiResponse<KetoHealthStatus> IsInstanceReadyWithHttpInfo()
        {
            Ory.Keto.Client.Client.RequestOptions localVarRequestOptions = new Ory.Keto.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Ory.Keto.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Ory.Keto.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request
            var localVarResponse = this.Client.Get<KetoHealthStatus>("/health/ready", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("IsInstanceReady", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Check readiness status This endpoint returns a 200 status code when the HTTP server is up running and the environment dependencies (e.g. the database) are responsive as well.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the health status will never refer to the cluster state, only to a single instance.
        /// </summary>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of KetoHealthStatus</returns>
        public async System.Threading.Tasks.Task<KetoHealthStatus> IsInstanceReadyAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Ory.Keto.Client.Client.ApiResponse<KetoHealthStatus> localVarResponse = await IsInstanceReadyWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Check readiness status This endpoint returns a 200 status code when the HTTP server is up running and the environment dependencies (e.g. the database) are responsive as well.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the health status will never refer to the cluster state, only to a single instance.
        /// </summary>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (KetoHealthStatus)</returns>
        public async System.Threading.Tasks.Task<Ory.Keto.Client.Client.ApiResponse<KetoHealthStatus>> IsInstanceReadyWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Ory.Keto.Client.Client.RequestOptions localVarRequestOptions = new Ory.Keto.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Ory.Keto.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Ory.Keto.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<KetoHealthStatus>("/health/ready", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("IsInstanceReady", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
