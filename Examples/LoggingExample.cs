/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Oci.Common;
using Oci.Common.Auth;
using Oci.Common.Waiters;
using Oci.LoggingingestionService;
using Oci.LoggingingestionService.Models;
using Oci.LoggingingestionService.Responses;
using Oci.LoggingingestionService.Requests;
using Oci.LoggingsearchService;
using Oci.LoggingsearchService.Models;
using Oci.LoggingsearchService.Responses;
using Oci.LoggingsearchService.Requests;
using Oci.LoggingService;
using Oci.LoggingService.Models;
using Oci.LoggingService.Responses;
using Oci.LoggingService.Requests;

namespace Oci.Examples
{
    /**
    * This class demonstatrates how to use the Logging APIs to work with Logs in OCI
    * - Create a Log with the display Name provided under logDisplayName.
    * - List Logs under the Log Group with given logGroupId.
    * - Get details of the Log just created.
    * - Ingest a log entry in the Log just created.
    * - Search for the log entry in this log.
    * - Delete the log.
    */

    public class LoggingExample
    {
        const string OciConfigProfileName = "DEFAULT";
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public static async Task MainLogging()
        {
            string compartmentId = Environment.GetEnvironmentVariable("OCI_COMPARTMENT_ID");
            string logGroupId = Environment.GetEnvironmentVariable("OCI_LOG_GROUP");
            string logDisplayName = "oci-dotnet-sdk-example-log";
            // Accepts profile name and creates a auth provider based on config file
            var provider = new ConfigFileAuthenticationDetailsProvider(OciConfigProfileName);
            // Create clients for the service to enable using its APIs
            var logManagementClient = new LoggingManagementClient(provider, new ClientConfiguration());
            var logIngestionclient = new LoggingClient(provider, new ClientConfiguration());
            var logSearchClient = new LogSearchClient(provider, new ClientConfiguration());
            try
            {
                string logId = await CreateLog(logManagementClient, logGroupId, logDisplayName);
                //string logId = "ocid1.log.oc1.phx.amaaaaaaogrv47iah6om32dahq3g4p6sleadbnsyptckvirmilizekvjptza";
                await ListLogs(logManagementClient, logGroupId);
                await GetLog(logManagementClient, logGroupId, logId);

                // Wait for log to be accessible
                System.Threading.Thread.Sleep(50000);
                await PutLogDetails(logIngestionclient, logId);

                // Wait for PutLogs to ingest Logs
                System.Threading.Thread.Sleep(20000);
                await SearchLog(logSearchClient, compartmentId, logGroupId, logId);
                await DeleteLog(logManagementClient, logGroupId, logId);
            }
            catch (Exception e)
            {
                logger.Info($"Received exception due to {e.Message}");
            }
            finally
            {
                logManagementClient.Dispose();
                logIngestionclient.Dispose();
                logSearchClient.Dispose();
            }
        }

        private static async Task ListLogs(LoggingManagementClient client, string logGroup)
        {
            ListLogsRequest listLogsRequest = new ListLogsRequest
            {
                LogGroupId = logGroup
            };
            // Pass the log group whose logs you want to list
            ListLogsResponse response = await client.ListLogs(listLogsRequest);
            logger.Info("List Logs");
            logger.Info("=============");
            foreach (LogSummary logSummary in response.Items)
            {
                logger.Info($"Log Display Name: {logSummary.DisplayName}, Log Type:{logSummary.LogType}");
            }
        }

        private static async Task<string> CreateLog(LoggingManagementClient client, string logGroup, string logDisplayName)
        {
            CreateLogRequest createLogRequest = new CreateLogRequest
            {
                LogGroupId = logGroup,
                // Create a createLogDetails to pass to Create Log Request
                CreateLogDetails = new CreateLogDetails
                {
                    DisplayName = logDisplayName,
                    LogType = CreateLogDetails.LogTypeEnum.Custom
                }
            };
            // Pass createLogRequest to client to create the log
            logger.Info($"Creating Log {logDisplayName}");
            logger.Info("=============");
            CreateLogResponse createLogResponse = await client.CreateLog(createLogRequest);

            string workRequestId = createLogResponse.OpcWorkRequestId;
            logger.Info($"CreateLog work request ID is {workRequestId}");

            GetWorkRequestResponse workRequestResponse = WaitForWorkRequestFinished(client, workRequestId);
            string logId = GetLogId(workRequestResponse);
            logger.Info($"Created Log: {logDisplayName} under Log Group: {logGroup} with Log OCID:{logId}");
            return logId;
        }

        private static async Task PutLogDetails(LoggingClient loggingClient, string logId)
        {
            PutLogsRequest putLogsRequest = new PutLogsRequest
            {
                LogId = logId,
                PutLogsDetails = new PutLogsDetails
                {
                    Specversion = "1.0",
                    LogEntryBatches = new List<Oci.LoggingingestionService.Models.LogEntryBatch>
                    {
                        new Oci.LoggingingestionService.Models.LogEntryBatch
                        {
                            Entries = new List<Oci.LoggingingestionService.Models.LogEntry>
                            {
                                new Oci.LoggingingestionService.Models.LogEntry
                                {
                                    Data = "oci-dotnet-sdk-example-data-Value",
                                    Id = "c3964883-4bb9-45b0-b634-3e66eb119c43"
                                }
                            },
                            Source = "oci-dotnet-sdk-example-source",
                            Type = "oci-dotnet-sdk-example-type",
                            Subject = "oci-dotnet-sdk-example-subject-Value",
                            Defaultlogentrytime = DateTime.Parse("12/09/2020 20:49:14")
                        }
                    }
                }
            };
            PutLogsResponse putLogsResponse = await loggingClient.PutLogs(putLogsRequest);
            logger.Info($"PutLog OpcRequestId:{putLogsResponse.OpcRequestId}");
        }

        private static async Task SearchLog(LogSearchClient client, string compartmentId, string logGroupId, string logId)
        {
            DateTime timeStart = DateTime.Parse("12/09/2020 20:00:00");
            DateTime timeEnd = DateTime.Parse("12/09/2020 21:00:00");
            SearchLogsRequest searchLogsRequest = new SearchLogsRequest
            {
                SearchLogsDetails = new SearchLogsDetails
                {
                    SearchQuery = $"search \"{compartmentId}/{logGroupId}/{logId}\"",
                    TimeStart = timeStart,
                    TimeEnd = timeEnd
                },
                Limit = 5
            };
            logger.Info($"Searching log for entries between:{timeStart} to {timeEnd}");
            logger.Info("=============");
            SearchLogsResponse searchLogsResponse = await client.SearchLogs(searchLogsRequest);
            logger.Info($"Response OpcRequestId:{searchLogsResponse.OpcRequestId}");
            logger.Info($"Search Response count:{searchLogsResponse.SearchResponse.Results.Count}");
            foreach (var result in searchLogsResponse.SearchResponse.Results)
            {
                logger.Info($"data:{result.Data.ToString()}");
            }
        }
        private static async Task GetLog(LoggingManagementClient client, string logGroupId, string logId)
        {
            GetLogRequest getLogRequest = new GetLogRequest
            {
                LogGroupId = logGroupId,
                LogId = logId
            };
            logger.Info("Getting log Details for this Log");
            logger.Info("=============");
            GetLogResponse getLogResponse = await client.GetLog(getLogRequest);
            Log log = getLogResponse.Log;
            logger.Info($"Name:{log.DisplayName}");
            logger.Info($"Log ID:{log.Id}");
            logger.Info($"Log Group ID:{log.LogGroupId}");
            logger.Info($"Log Lifecycle State:{log.LifecycleState}");
            logger.Info($"Time Created:{log.TimeCreated}");
            logger.Info($"Time Last Modified:{log.TimeLastModified}");
            logger.Info($"Retention Duration:{log.RetentionDuration} days");
        }

        private static async Task DeleteLog(LoggingManagementClient client, string logGroupId, string logId)
        {
            DeleteLogRequest deleteLogRequest = new DeleteLogRequest
            {
                LogGroupId = logGroupId,
                LogId = logId
            };
            // Pass deleteLogRequest to client to delete the log
            logger.Info($"Deleting Log {logId}");
            logger.Info("=============");
            DeleteLogResponse response = await client.DeleteLog(deleteLogRequest);
            string workRequestId = response.OpcWorkRequestId;
            WaitForWorkRequestFinished(client, workRequestId);
            logger.Info("Log deleted");
        }

        /**
            * Wait for a work request to finish
            * @param LoggingManagementClient the service client to use to get work request
            * @param workRequestId the id of work request
            *
            * @return a work request response object
        */
        private static GetWorkRequestResponse WaitForWorkRequestFinished(LoggingManagementClient client, string workRequestId)
        {
            var waiterConfiguration = new WaiterConfiguration
            {
                MaxAttempts = 20,
                GetNextDelayInSeconds = DelayStrategy.GetExponentialDelayInSeconds
            };
            GetWorkRequestRequest getWorkRequest = new GetWorkRequestRequest
            {
                WorkRequestId = workRequestId
            };
            return client.Waiters.ForWorkRequest(getWorkRequest, waiterConfiguration, OperationStatus.Succeeded).Execute();
        }

        /**
            * Get log id from a finished WorkRequestResponse
            * @param Work Request response
            *
            * @return log OCID
        */
        private static string GetLogId(GetWorkRequestResponse getWorkRequestResponse)
        {
            string logId = null;
            List<WorkRequestResource> resources = getWorkRequestResponse.WorkRequest.Resources;
            foreach (WorkRequestResource resource in resources)
            {
                if (resource.EntityType.Equals("log"))
                {
                    logId = resource.Identifier;
                    break;
                }
            }
            return logId;
        }
    }
}
