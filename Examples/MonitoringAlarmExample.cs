/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Oci.Common.Auth;
using Oci.MonitoringService;
using Oci.MonitoringService.Models;
using Oci.MonitoringService.Requests;
using Oci.MonitoringService.Responses;

namespace Oci.Examples
{
    /**
    * This class demonstrates how to use the Monitoring api in the .NET SDK. This will cover:
    *
    * <ul>
    *   <li>Creating, updating, retrieving, listing and deleting alarms</li>
    *   <li>Retrieving alarm state history</li>
    *   <li>Listing status of alarms</li>
    * </ul>
    *
    * This class makes the following assumptions:
    * <ul>
    *   <li>
    *      The configuration file used by service clients will be sourced from the default
    *      location (~/.oci/config) and the DEFAULT profile will be used
    *   </li>
    *   <li>Resources will be created in us-phoenix-1</li>
    *   <li>
    *      Alarms will be created in the compartment specified by the user.
    *   </li>
    *   <li>
    *      The user has the appropriate permissions to create alarms in the compartment specified by user,
    *      read metrics in the metric compartment specified by user, and publish message in the destination
    *      specified by user.
    *   </li>
    * <ul>
    */

    public class MonitoringAlarmExample
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        private static string displayName = "Alarm for .NET SDK example";
        private static string ociNamespace = "oci_compartment";
        private static string metricQuery = "CpuUtilization[1m].max() > 75";
        private static string resolution = "1m";
        private static string pendingDuration = "PT10M";
        private static Alarm.SeverityEnum alertSeverity = Alarm.SeverityEnum.Error;
        private static string body = "notification body";
        private static string repeatDuration = "PT4H";
        // Suppress from now.
        private static DateTime suppressFrom = DateTime.Now;
        // Suppress for one day.
        private static DateTime suppressUntil = DateTime.Now.AddDays(1);

        public static async Task MainMonitoring()
        {
            logger.Info("Starting example");

            var provider = new ConfigFileAuthenticationDetailsProvider("DEFAULT");

            var compartmentId = Environment.GetEnvironmentVariable("OCI_COMPARTMENT_ID");
            var metricCompartmentId = Environment.GetEnvironmentVariable("METRIC_COMPARTMENT_ID");
            var destinations = Environment.GetEnvironmentVariable("DESTINATION");

            var monitoringClient = new MonitoringClient(provider);

            string alarmId = null;
            var alarmDestinations = new List<string>(destinations.Split(','));

            try
            {
                // Create a new alarm
                var createAlarmDetails = new CreateAlarmDetails
                {
                    DisplayName = displayName,
                    CompartmentId = compartmentId,
                    MetricCompartmentId = metricCompartmentId,
                    Namespace = ociNamespace,
                    Query = metricQuery,
                    Resolution = resolution,
                    PendingDuration = pendingDuration,
                    Severity = alertSeverity,
                    Body = body,
                    Destinations = alarmDestinations,
                    RepeatNotificationDuration = repeatDuration,
                    IsEnabled = true
                };

                CreateAlarmRequest createAlarmRequest = new CreateAlarmRequest
                {
                    CreateAlarmDetails = createAlarmDetails
                };
                var createAlarmResponse = await monitoringClient.CreateAlarm(createAlarmRequest);
                logger.Info($"Created alarm: {displayName}");

                alarmId = createAlarmResponse.Alarm.Id;

                Suppression suppression = new Suppression
                {
                    Description = "suppress the alarm",
                    TimeSuppressFrom = suppressFrom,
                    TimeSuppressUntil = suppressUntil
                };

                // Update the new alarm.
                UpdateAlarmDetails updateAlarmDetails = new UpdateAlarmDetails
                {
                    Suppression = suppression
                };
                UpdateAlarmRequest updateAlarmRequest = new UpdateAlarmRequest
                {
                    AlarmId = alarmId,
                    UpdateAlarmDetails = updateAlarmDetails
                };
                UpdateAlarmResponse updateAlarmResponse = await monitoringClient.UpdateAlarm(updateAlarmRequest);
                logger.Info("Updated alarm");

                RemoveAlarmSuppressionRequest removeAlarmSuppressionRequest = new RemoveAlarmSuppressionRequest
                {
                    AlarmId = alarmId
                };
                RemoveAlarmSuppressionResponse removeAlarmSuppressionResponse = await monitoringClient.RemoveAlarmSuppression(removeAlarmSuppressionRequest);
                logger.Info("removed suppression for the alarm");

                // Get the new alarm
                GetAlarmRequest getAlarmRequest = new GetAlarmRequest
                {
                    AlarmId = alarmId
                };
                GetAlarmResponse getAlarmResponse = await monitoringClient.GetAlarm(getAlarmRequest);
                logger.Info($"Retrieved alarm for id: {getAlarmResponse.Alarm.Id}");

                // Get alarm history
                GetAlarmHistoryRequest getAlarmHistoryRequest = new GetAlarmHistoryRequest
                {
                    AlarmId = alarmId
                };
                GetAlarmHistoryResponse getAlarmHistoryResponse = await monitoringClient.GetAlarmHistory(getAlarmHistoryRequest);
                logger.Info($"Alarm history for id: {alarmId}");
                foreach (var alarmHistoryEntry in getAlarmHistoryResponse.AlarmHistoryCollection.Entries)
                {
                    logger.Info($"summary: {alarmHistoryEntry.Summary}");
                }

                // List alarms
                ListAlarmsRequest listAlarmsRequest = new ListAlarmsRequest
                {
                    CompartmentId = compartmentId,
                    DisplayName = displayName
                };
                ListAlarmsResponse listAlarmsResponse = await monitoringClient.ListAlarms(listAlarmsRequest);
                logger.Info("Retrieved alarms");
                logger.Info("=================");
                foreach (var alarmSummary in listAlarmsResponse.Items)
                {
                    logger.Info($"Alarm: {alarmSummary.DisplayName}");
                }

                // List alarm status
                ListAlarmsStatusRequest listAlarmsStatusRequest = new ListAlarmsStatusRequest
                {
                    DisplayName = displayName,
                    CompartmentId = compartmentId
                };
                ListAlarmsStatusResponse listAlarmsStatusResponse = await monitoringClient.ListAlarmsStatus(listAlarmsStatusRequest);
                logger.Info("Retrieved alarms status");
                logger.Info("=======================");
                foreach (var alarmsStatus in listAlarmsStatusResponse.Items)
                {
                    logger.Info($"Status of the alarm: {alarmsStatus.DisplayName} is {alarmsStatus.Status}");
                }

            }
            catch (Exception e)
            {
                logger.Error($"Exception: {e}");
            }
            finally
            {

                if (alarmId != null)
                {
                    DeleteAlarmRequest deleteAlarmRequest = new DeleteAlarmRequest
                    {
                        AlarmId = alarmId
                    };
                    DeleteAlarmResponse deleteAlarmResponse = await monitoringClient.DeleteAlarm(deleteAlarmRequest);
                    logger.Info($"Deleted alam: {displayName}");
                }
                monitoringClient.Dispose();

            }

            logger.Info("End example");
        }
    }
}
