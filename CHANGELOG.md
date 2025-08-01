# Change Log

All notable changes to this project will be documented in this file.

The format is based on Keep a [Changelog](http://keepachangelog.com/).

## 116.0.0 - 2025-07-29
### Added
 - Support for the APIP Platform service
 - Support for resource locking for all resources in the API Gateway service
 - Support for optional parameters in the import and export dashboard APIs in the Management Dashboard service
 - Support for agent configurations and MACS extension configurations in the Application Performance Monitoring service
 - Support for specifying replication configuration when creating or updating a secret in the Vault service
 - Support for CPU architecture agnostic configurations in the PostgreSQL service
 - Support for creating, deploying, cloning, getting, listing, activating and deactivating model groups in the Data Science service
 - Support for creating, updating, getting, listing and deleting model group version history in the Data Science service
 - Support for uploading and downloading model group artifacts in the Data Science service
 - Support for listing the state of the deployed models associated with a model group in the Data Science service
 - Support for updating model group deployments in the Data Science service
 - Support for burstable shapes in data science notebooks, machine learning jobs and machine learning pipelines in the Data Science service
 - Support for multilingual text to speech for 8 more languages in the AI Speech service    

### Breaking Changes
 - The return type of property `LanguageCode` was changed to `string` in `VoiceSummary` model in the AI Speech service

## 115.0.0 - 2025-07-22
### Added
 - Support for calling Oracle Cloud Infrastructure services in the `ap-batam-1` region
 - Support for updating autonomous databases with schedule DB version upgrade in the Database service
 - Support for new OKV Endpoint group parameter for Autonomous Container Database operations in the Database service
 - Support for specifying tags in backup databases and standby databases in the Database service
 - Support for cloud database systems and improved system monitoring in the Database Management service
 - Support for stack, image, lead generation, and service listing types in the Marketplace service
 - Support for adding custom metric-based policies in the Autoscaling service
 - Support for Named Credentials in the Management Agent service
 - Support for multilingual capability, user configured Agent-As-A-Tool, data ingestion of documents, and sequentially executed steps in the Generative AI Agent service
 - Support for IAM authentication in the Cache service    

### Breaking Changes
 - The AI Anomaly Detection service has reached End-of-life
 - The models `HttpEndpointDelegatedBearerAuthConfig`, `HttpEndpointOciResourcePrincipalAuthConfig`, and `HttpEndpointIdcsAuthConfig` were removed in the Generative AI Agent service
 - The enum model `HttpEndpointAuthConfigTypeEnum` was removed in the Generative AI Agent service
 - The models `AttachmentSummary`, `Attachment`, `BuyerInformation`, `CreateAttachmentDetails`, `CreateOfferDetails`, `CreateOfferRequest`, `DeleteOfferRequest`, `ListAttachmentsRequest`, `ListOffersRequest`, `AttachmentClient`, `OfferClient`, `OfferCollection`, `OfferInternalDetail`, `OfferSummary`, `Offer`, `Pricing`, `ResourceBundle`, `SellerInformation`, and `UpdateOfferDetails` were removed in the Marketplace service

## 114.2.0 - 2025-07-15
### Added
 - Support for calling Oracle Cloud Infrastructure services in the ap-delhi-1 region

## 114.1.0 - 2025-07-08
### Added
 - Support for insight of Autonomous Database on Exadata Cloud@Customer (ADB on ExaC@C) in the Operations Insights service
 - Support for Spanish and Portuguese language recognition with Azure-backed Optical Character Recognition (OCR) in the AI Document service
 - Support for UK, Australian, and Canadian address and tax form recognition in the AI Document service
 - Support for Personal-to-Corporate conversation check in the OSP Gateway service

## 114.0.0 - 2025-07-01
### Added
 - Support for calling Oracle Cloud Infrastructure services in the us-ashburn-2 region
 - Support for the Database MultiCloud service
 - Support for System Tags in the Database service
 - Support for PKCS11 Library Integration for Azure Key Store in the Database service
 - Support for changing subscription ID and the opc-dry-run parameter in the Database service
 - Support for listing all members of an Elastic Resource Pool for a provided Elastic Resource Pool leader in the Database service
 - Support for managing scheduled queries in the Application Performance Monitoring service
 - Support for Bring Your Own Key (BYOK) in the MySQL Heatwave service
 - Support for customer-initiated collection of diagnostic information in the Database Migration service   

### Breaking Changes
 - The type of field `state` has been changed from String to enum `StateEnum` in the models `AutoActivateToggleStatus` and `AutoActivateStatus` in the Application Performance Monitoring service

## 113.3.0 - 2025-06-24
### Added
 - Support for database backups to Amazon S3 as default option for all databases running on Exa@AWS in the Database service
 - Support for customer-managed encryption keys in hosted environments in the NoSQL Database service
 - Support for upgrading a fleet of Grid Infrastructure and Databases to 23ai for ExaCS and ExaCC in the Exadata Fleet Update service
 - Support for Bring Your Own IPv6 (BYOIPv6) in the Load Balancer service

## 113.2.0 - 2025-06-17
### Added
 - Support for node cycling (reboot/replaceBootVolume) for worker nodes in the Kubernetes Engine service
 - Support for the WebLogic Management service
 - Support for the Privileged API Access Control service
 - Support for Role Based Access Control List in the OCI Cache service
 - Support for integrating native Redis authentication with OCI Identity/IAM in the OCI Cache service
 - Support for Command String in Runcommand API in the Instance Agent service
 - Support for new fields capacitySummary and computeBareMetalHostId in the API response when fetching Dedicated Virtual Machine Hosts in the Compute service

## 113.1.0 - 2025-06-10
### Added
 - Support for performing an explicit Data Guard pre-check by setting new optional dry-run parameter when creating a database in the Database service

## 113.0.0 - 2025-06-03
### Added
 - Support for creating auto Autonomous Container Database backups in a remote region in the Database service
 - Support for creating new Autonomous Container Databases from a backup in the remote region in the Database service
 - Support for input/output token usage information in the Generative AI Agent service
 - Support for standby connection in the Database Management service
 - Support for additional metrics, including replication metrics, in the Database Management service
 - Support for replication dashboard in the Database Management service
 - Support for soft-deleting backups in the HeatWave service
 - Support for additional connections types for Oracle Rest Data Services (ORDS), Apache Iceberg, and IBM Db2 for i in the Golden Gate service    

### Breaking Changes
 - The properties `CustomerContacts`, `DisplayName`, `DbUniqueName`, `DbName`, `ServiceLevelAgreementType`, `AutonomousExadataInfrastructureId`, `DbVersion`, `DatabaseSoftwareImageId`, `PeerAutonomousExadataInfrastructureId`, `PeerAutonomousContainerDatabaseDisplayName`, `ProtectionMode`, `FastStartFailOverLagLimitInSeconds`, `IsAutomaticFailoverEnabled`, `PeerCloudAutonomousVmClusterId`, `PeerAutonomousVmClusterId`, `PeerAutonomousContainerDatabaseCompartmentId`, `PeerAutonomousContainerDatabaseBackupConfig`, `PeerDbUniqueName`, `AutonomousVmClusterId`, `CloudAutonomousVmClusterId`, `CompartmentId`, `PatchModel`, `MaintenanceWindowDetails`, `StandbyMaintenanceBufferInDays`, `VersionPreference`, `IsDstFileUpdateEnabled`, `FreeformTags`, `DefinedTags`, `BackupConfig`, `KmsKeyId`, `KmsKeyVersionId`, `VaultId`, `KeyStoreId`, `DbSplitThreshold`, `VmFailoverReservation`, `DistributionAffinity`, `NetServicesArchitecture` and `Source` were moved from model CreateAutonomousContainerDatabaseDetails into the model CreateAutonomousContainerDatabaseBase in the Database service
 - The enums `ServiceLevelAgreementTypeEnum`, `ProtectionModeEnum`, `PatchModelEnum`, `VersionPreferenceEnum`, `DistributionAffinityEnum` and `NetServicesArchitectureEnum` were moved from model CreateAutonomousContainerDatabaseDetails into CreateAutonomousContainerDatabaseBase in the Database service
 - The property `UserId` was made required in the model `OracleNosqlConnectionSummary`  in the Golden Gate service

## 112.0.0 - 2025-05-27
### Added
 - Support for List and Get APIs for out-of-box management dashboard resources in the Management Dashboard service
 - Support for REST option in the HeatWave MySQL service
 - Support for warnings in list-application-dependency-vulnerability response for vulnerability audits in the Adm service
 - Support for HostGroups in the Compute service
 - Support for ENTERPRISE_EDITION_DEVELOPER enum in Db System Launch and Create DB external backup commands in the Database service
 - Support for databaseEditionQueryParam in dbSystemInitialStorageSizes, dbSystemStoragePerformance, quotaDefinitions, and internalQuotaDefinitions in the Database service
 - Support for EmissionType parameter in UsageCarbonEmissionSummary and EmissionCalculationMethod, EmissionType, Granularity parameters in UsageCarbonEmissionsReportQuery in the Usage Api service
 - Support for querying capacity report under BDSs tenancy in the Big Data service
 - Support for installing Dataplane Software and python packages updates in the Big Data service
 - Support for triggering a dry run with OS patch in the Big Data service
 - Support for NAT on firewall feature in the Network Firewall service
 - Support for Predictable OIDC Discovery in the OKE service
 - Support for SQL and FTP monitoring, creating and updating in the Application Performance Monitoring Synthetic service
 - Support for Demand signal feature in the Capacity Management service
 - Support for Targeted Launch in the Launch Instance API service   

### Breaking Changes
 - The values for `ATTACHING` and `DETACHING` were removed from the enum models `LifecycleStateEnum`, `ListNetworkFirewallPoliciesLifecycleStateEnum`, and `ListNetworkFirewallsLifecycleStateEnum` in the Network Firewall service

## 111.1.0 - 2025-05-20
### Added
 - Support for the Globally Distributed Database service
 - Support for listing the available upgrades (OS & GI) for VirtualMachine DB systems in the Database service
 - Support for running dry-run operations in the Database service
 - Support for Network Security Groups in MySQL HeatWave service

## 111.0.0 - 2025-05-13
### Added
- Support for the Model Deployment service
- Support for enabling and monitoring Pluggable Databases(PDB) in the Database Management service
- Support for additional unit shapes in AI clusters in the Generative AI service
- Support for node search details and node shape details on create and update cluster operations in the OpenSearch service
 
### Breaking Changes
- The operations `DisableExternalMysqlAssociatedService` and `EnableExternalMysqlAssociatedService` were removed from the `ManagedMySqlDatabasesClient` in the Database Management service
- The property `LifecycleState` and its enum `LifecycleStateEnum` were removed from the model `ExadataInfrastructureLifecycleStateValues` in the Database Management service
- The models `DisableExternalMysqlAssociatedServiceDetails`, `EnableExternalMysqlAssociatedServiceDetails`, `DisableExternalMysqlAssociatedServiceRequest`, `EnableExternalMysqlAssociatedServiceRequest`, `DisableExternalMysqlAssociatedServiceResponse`, `EnableExternalMysqlAssociatedServiceResponse`,  and `ExternalMysqlAssociatedServiceName` were removed in the Database Management service

## 110.0.0 - 2025-05-06
### Added
 - Support for dry run while creating cloud exadata Infrastructure and VM clusters in the Database service
 - Support for filters to get latest versions on list system versions API in the Database service
 - Support for generic fleets without fleet type in the Fleet Application Management service
 - Support for creating resources and changing compartment in the Fleet Application Management service
 - Support for infrastructure management via provisioning with terraform based catalog items and deployments in the Fleet Application Management service
 - Support for platform configuration metadata management in the Fleet Application Management service
 - Support for managing runbook versions in the Fleet Application Management service
 - Support for provisioning runbooks in the Fleet Application Management service
 - Support for resource inventory in the Fleet Application Management service
 - Support for changing compartment for fleets, platforms configurations, properties, patches, runbooks and task resources in the Fleet Application Management service
 - Support for new migration phase in the Database migration service   

### Breaking Changes
 - The operations `GetWorkRequest`, `ListWorkRequestErrors`, `ListWorkRequestLogs`, `ListWorkRequests` were removed from the `FleetAppsManagementClient` in the  Fleet Application Management service
 - The operations `ListWorkRequestErrorsResponseEnumerator`, `ListWorkRequestErrorsRecordEnumerator`, `ListWorkRequestLogsResponseEnumerator`, `ListWorkRequestsResponseEnumerator`, `ListWorkRequestsRecordEnumerator` were removed from `FleetAppsManagementPaginators` in the Fleet Application Management service
 - The operation `ForWorkRequest` was removed from `FleetAppsManagementWaiters` in the Fleet Application Management service
 - The properties `ResourceId`, `Type`, `ApplicationType`, `Product`, `LifecycleOperation`, `RunbookId`, `TargetId`, `Subjects` were removed from the model `ActionGroup` in the Fleet Application Management service
 - The properties `ResourceId`, `Type`, `Name`, `ApplicationType`, `RunbookId` were removed from the model `ActionGroupDetails` in the Fleet Application Management service
 - The property `TenancyId` was removed from the models `ListFleetResourcesRequest` and `AssociatedSchedulerDefinition` in the Fleet Application Management service
 - The property `PatchType`  was removed from the models `CompliancePolicyRule`, `CompliancePolicyRuleSummary` and `UpdateCompliancePolicyRuleDetails` in the Fleet Application Management service
 - The property `Condition` was removed from the model `ComponentProperties` in the Fleet Application Management service
 - The type of property `RunOn` was changed from `string` to `RunOnDetails` in the Fleet Application Management service
 - The properties `PatchType` and `CompartmentId` were removed from the model `CreateCompliancePolicyRuleDetails` in the Fleet Application Management service
 - The property `CompartmentId` was removed from the models `CreateFleetCredentialDetails`, `CreateFleetPropertyDetails`, `ListFleetPropertiesRequest`, `ListFleetCredentialsRequest`, `ListScheduledFleetsRequest` and `UpdatePatchDetails` in the Fleet Application Management service
 - The properties `FleetType`, `ApplicationType`, `GroupType`, `ResourceSelectionType`, and `RuleSelectionCriteria` were removed from the model `CreateFleetDetails` in the Fleet Application Management service
 - The type of property `NotificationPreferences` was changed from `NotificationPreferences` to a List of `NotificationPreference` in the models `Fleet`, `CreateFleetDetails` and `UpdateFleetDetails` in the Fleet Application Management service
 - The properties `RunbookRelevance` and `Associations` were removed from the models `CreateRunbookDetails` and `UpdateRunbookDetails` in the Fleet Application Management service
 - The properties `ActivityInitiationCutOff` were removed from the model `CreateSchedulerDefinitionDetails` in the Fleet Application Management service
 - The enums `FleetTypeEnum`, `ResourceSelectionTypeEnum`, and `GroupTypeEnum` were removed from the model `Fleet` in the Fleet Application Management service
 - The properties `FleetType`, `ApplicationType`, `GroupType`, `ResourceSelectionType`, and `RuleSelectionCriteria` were removed from the model `Fleet` in the Fleet Application Management service
 - The property `ApplicationType` was removed from the models `FleetResource` and `FleetResourceSummary` in the Fleet Application Management service
 - The property `FleetType` was removed from the model `FleetSummary` in the Fleet Application Management service
 - The properties `MaintenanceWindowType` and `TaskInitiationCutoff` were removed from the models `MaintenanceWindow`, `MaintenanceWindowSummary`, `CreateMaintenanceWindowDetails` and `UpdateMaintenanceWindowDetails` in the Fleet Application Management service
 - The property `Id` was removed from the model `OperationRunbook` in the Fleet Application Management service
 - The type of property `Content` was changed from `ContentDetails` to `PatchFileContentDetails` in the models `GenericArtifact` and `PlatformSpecificArtifact` in the Fleet Application Management service
 - The property `OnUpcomingSchedule` was removed from the model `Preferences` in the Fleet Application Management service
 - The enum `RunbookRelevanceEnum`, and properties `RunbookRelevance` and `Associations` were removed from the model `Runbook` in the Fleet Application Management service
 - The property `RunbookRelevance` was removed from the models `RunbookSummary` and `ListRunbooksRequest` in the Fleet Application Management service
 - The properties `Type`, `MaintenanceWindowId`, `Recurrences`, and `Duration` were removed from the model `Schedule` in the Fleet Application Management service
 - The properties `TenancyId`, `ActionGroupTypes`, and `ApplicationTypes`  were removed from the model `ScheduledFleetSummary` in the Fleet Application Management service
 - The properties `ActivityInitiationCutOff`, `ActionGroupTypes` and `ApplicationTypes` were removed from the model `SchedulerDefinition` in the Fleet Application Management service
 - The properties `ActionGroupTypes` and `ApplicationTypes` were removed from the model `SchedulerDefinitionSummary` in the Fleet Application Management service
 - The enum members `Active` and `Deleted` were removed from the enum `LifecycleStateEnum` in the model `SchedulerJob` in the Fleet Application Management service
 - The properties `ActionGroupTypes`, `ApplicationTypes` and `AssociatedScheduleDefinition` were removed from the models `SchedulerJob` and `SchedulerJobSummary` in the Fleet Application Management service
 - The enum `AssociationTypeEnum` and the property `AssociationType` were removed from the model `Task` in the Fleet Application Management service
 - The property `Value` was removed in the model `TaskArgument` in the Fleet Application Management service
 - The property `RuleSelectionCriteria` was removed from the model `UpdateFleetDetails` in the Fleet Application Management service
 - The property `ActivityInitiationCutOff` was removed from the model `UpdateSchedulerDefinitionDetails` in the Fleet Application Management service
 - The enum `SortByEnum` was removed and the type of property `SortBy` was changed from `SortByEnum` to `CompliancePolicyRuleSortBy` in the model `ListCompliancePolicyRulesRequest` in the Fleet Application Management service
 - The enum `SortByEnum` was removed and the type of property `SortBy` was changed from `SortByEnum` to `CompliancePolicySortBy` in the model `ListCompliancePoliciesRequest` in the Fleet Application Management service
 - The enum `SortByEnum` was removed and the type of property `SortBy` was changed from `SortByEnum` to `ComplianceRecordSortBy` in the model `ListComplianceRecordsRequest` in the Fleet Application Management service
 - The enum `SortByEnum` was removed and the type of property `SortBy` was changed from `SortByEnum` to `FleetCredentialSortBy` in the model `ListFleetCredentialsRequest` in the Fleet Application Management service
 - The enum `SortByEnum` was removed and the type of property `SortBy` was changed from `SortByEnum` to `ProductSortBy` in the model `ListFleetProductsRequest` in the Fleet Application Management service
 - The enum `SortByEnum` was removed and the type of property `SortBy` was changed from `SortByEnum` to `FleetPropertySortBy` in the model `ListFleetPropertiesRequest` in the Fleet Application Management service
 - The enum `SortByEnum` was removed and the type of property `SortBy` was changed from `SortByEnum` to `FleetResourceSortBy` in the model `ListFleetResourcesRequest` in the Fleet Application Management service
 - The enum `SortByEnum` was removed and the type of property `SortBy` was changed from `SortByEnum` to `FleetSortBy` in the model `ListFleetsRequest` in the Fleet Application Management service
 - The type of property `FleetType` from `Fleet.FleetTypeEnum` to `FleetDetails.FleetTypeEnum` in the model `ListFleetsRequest` in the Fleet Application Management service
 - The enum `SortByEnum` was removed and the type of property `SortBy` was changed from `SortByEnum` to `TargetSortBy` in the model `ListFleetTargetsRequest` in the Fleet Application Management service
 - The enum `SortByEnum` was removed and the type of property `SortBy` was changed from `SortByEnum` to `InventoryResourceSortBy` in the model `ListInventoryResourcesRequest` in the Fleet Application Management service
 - The enum `SortByEnum` was removed and the type of property `SortBy` was changed from `SortByEnum` to `MaintenanceWindowSortBy` in the model `ListMaintenanceWindowsRequest` in the Fleet Application Management service
 - The enum `SortByEnum` was removed and the type of property `SortBy` was changed from `SortByEnum` to `SortBy` in the model `ListOnboardingsRequest` in the Fleet Application Management service
 - The enum `SortByEnum` was removed and the type of property `SortBy` was changed from `SortByEnum` to `PatchSortBy` in the model `ListPatchesRequest` in the Fleet Application Management service
 - The enum `SortByEnum` was removed and the type of property `SortBy` was changed from `SortByEnum` to `PlatformConfigurationSortBy` in the model `ListPlatformConfigurationsRequest` in the Fleet Application Management service
 - The enum `SortByEnum` was removed and the type of property `SortBy` was changed from `SortByEnum` to `PropertySortBy` in the model `ListPropertiesRequest` in the Fleet Application Management service
 - The enum `SortByEnum` was removed and the type of property `SortBy` was changed from `SortByEnum` to `RunbookSortBy` in the model `ListRunbooksRequest` in the Fleet Application Management service
 - The properties `SubState` and `DefintionId` were removed from the model `ListSchedulerJobsRequest` in the Fleet Application Management service
 - The enum `SortByEnum` was removed and the type of property `SortBy` was changed from `SortByEnum` to `SortBy` in the model `ListTargetsRequest` in the Fleet Application Management service
 - The enum `SortByEnum` was removed and the type of property `SortBy` was changed from `SortByEnum` to `TaskRecordSortBy` in the model `ListTaskRecordsRequest` in the Fleet Application Management service
 - The models `Associations`, `LifeCycleActionGroupType`, `MaintenanceWindowType`, and `NotificationPreferences`, were removed from the Fleet Application Management service

## 109.3.0 - 2025-04-29
### Added
 - Support for custom headers for model retirement in the Generative AI service
 - Support for usage statistics in the responses of Cohere chat and embed APIs in the Generative AI service
 - Support for custom prechecks in disaster recovery plans in the Disaster Recovery service
 - Support for retention of automatic backups in the database system deletion policy in the HeatWave service
 - Support for updating compartment of schedules in the Resource Scheduler service
 - Support for listing schedules by resource identifier in the Resource Scheduler service
 - Support for custom parameters when creating schedules in the Resource Scheduler service

## 109.2.0 - 2025-04-22
### Added
 - Support for patch management in the Database Lifecycle Management service
 - Support for restricting public network access to service instances in the Visual Builder service
 - Support for iSCSI-3 persistent reservations on block volume in the Core services (Networking, Compute, Block Volume)

## 109.1.0 - 2025-04-15
### Added
 - Support for applying guardrails, enabling content moderation and detection of Prompt Injection and Personally Identifiable Information (PII) in the Generative AI Inference service
 - Support for providing customer contacts for operational notifications in the Database service

## 109.0.0 - 2025-04-08
### Added
 - Support for connector source and targets with private endpoints in the Resource Scheduler service
 - Support for Cross Region Replication(XRR) for external key managers in the Key Management service
 - Support for dry run of function invocation in the Functions service
 - Support for collecting diagnostics for ZeroETL pipelines in the GoldenGate service
 - Support for adding, removing and switchover to local peers of deployment in different availability and fault domains within in the same region in the GoldenGate service
 - Support for creating standby deployments in the GoldenGate service   

### Breaking Changes
 - The type of properties `Tasks`, `Target`, and `Source` were changed to `TaskDetailsResponse`, `TargetDetailsResponse`, and `SourceDetailsResponse` respectively in the model `ServiceConnector` in the Resource Scheduler service

## 108.1.0 - 2025-04-02
### Added
 - Support for the Lustre File service
 - Support for machine learning applications in the Data Science service
 - Support for action endpoints to export and import configurations in the Application Performance Monitoring service
 - Support for ECPU (Elastic Compute Unit) compute model based warehouses in the Operations insights service
 - Support for setting ClientCertificateOptions and ClientCertificates for the underlying HttpClient in the ClientConfiguration

## 108.0.0 - 2025-03-25
### Added
 - Support for agent platforms and Retrieval Augmented Generation (RAG) agents in the Generative AI Agent service
 - Support for knowledge based metadata summaries in the Generative AI Agent service
 - Support for create and update operations on onboard configurations in the Stack Monitoring service
 - Support for automatic activation of the management agents on compute instance launch in the Stack Monitoring service
 - Support for importing collectd resources in the Stack Monitoring service
 - Support for updating the handler configurations for collected resources in Stack Monitoring service
 - Support for monitored resource types based on source type and resource category in the Stack Monitoring service
 - Support for adding tags in maintenance windows in the Stack Monitoring service
 - Support for host API feature in the Compute service   

### Breaking Changes
 - The type of property `SizeInBytes` was changed from `int` to `long` in the model `KnowledgeBaseStatistics` in the Generative AI Agent service

## 107.0.0 - 2025-03-18
### Added
 - Support for Managed Services for Mac service
 - Support for scheduling customer-initiated backups in the GoldenGate service
 - Support for GPU memory clusters and fabrics in the Compute service   

### Breaking Changes
 - The properties `IpAnycastId` and `MonitorIp` were removed from the models `CreateByoipRangeDetails` and `UpdateByoipRangeDetails` in the Compute service

## 106.0.0 - 2025-03-11
### Added
 - Support for pipelines in the OpenSearch service
 - Support for uploading and downloading the model metadata artifacts in the Data Science service
 - Support for model references via native API in the Data Science service
 - Support for scheduling cross-region database backups in the HeatWave service
 - Support for specifying backup retention days for manual cross-region backups in the HeatWave service
 - Support for IPv6 addresses for dedicated infrastructure in the Database service
 - Support for NewDev edition for the development community in the Database service
 - Support for grouping sensitive types across the tenancies and reuse of groups in the discovery workflow in the Data Safe service
 - Support for generating custom assessment reports in the Data Safe service     

### Breaking Changes
 - The properties `MaxMemoryGB`, `MaxOcpuCount`, `MinMemoryGB`, `MinOcpuCount` were removed from the models `CreateOpensearchClusterPipelineDetails`, `OpensearchClusterPipeline`, `OpensearchClusterPipelineSummary`, and `UpdateOpensearchClusterPipelineDetails` in the OpenSearch service
 - The property `SystemTags` was removed from the model `CreateOpensearchClusterPipelineDetails` in the OpenSearch service
 - The models `OpensearchPipelineValidationResponse`, `ValidateOpensearchPipelineDetails`, and `PipelineValidationErrorDetails` were removed in the OpenSearch service

## 105.0.0 - 2025-03-04
### Added
 - Support for user quotas on file system resources in the File Storage service
 - Support for long term retention backups in the Autonomous Recovery service
 - Support for Cross Region Replication(CRR) in the PostgreSQL service
 - Support for subscriptions and cluster placement groups on exascale infrastructure in the Database service
 - Support for multiple standby databases for autonomous dataguard associations in the Database service
 - Support for major version upgrade of clusters in the OpenSearch service
 - Support for Customer Service Identifier(CSI) number in list assigned subscriptions response in the Organizations service    

### Breaking Changes
 - The property `OpcWorkRequestId` was removed from the model `CreateSubscriptionMappingResponse` in the Organizations service

## 104.0.0 - 2025-02-25
### Added
 - Support for Database Lifecycle Management service
 - Support for Valkey cluster creation and Valkey migration in the OCI Cache service
 - Support for Dataflow Steps and Storage Mounts in Pipelines in the Data Science service
 - Support for Bring Your Own DKIM Keys in the Email Delivery service
 - Support for OpenId Connect Multi Authentication command in the OCI Kubernetes Engine service
 - Support for security attributes for Load Balancer resource in the Load Balancer service
 - Support for reservation of private IP addresses in the Networking service
 - Support for additional configuration parameters in the HeatWave service
 - Support for private and 3rd party software repositories, and rebooting of instances in the OS Management service   

### Breaking Changes
 - The property `ZprTags` was removed from models `UpdateLoadBalancerDetails`, `CreateLoadBalancerDetails` and `LoadBalancer` in the Load Balancer service
 - The models `CreateContainerCommandHealthCheckDetails` and `ContainerCommandHealthCheck` were removed in the Container Instances service
 - The enum member `Command` was removed from the enum `ContainerHealthCheckType` in the Container Instances service

## 103.2.0 - 2025-02-18
### Added
 - Support for Customer Onboarding Success(COS) in the Java Management service
 - Support for filtering performance tuning analysis results in the Java Management service
 - Support for improved plugin filtering in the Java Management service
 - Support for operating system distribution information in the Java Management service

## 103.1.0 - 2025-02-11
### Added
 - Support for backups and recovery enhancements in autonomous databases in the Database service
 - Support for IPv6 addresses on system launch in the Database service
 - Support for enterprise edition GPU infrastructure in the Stack Monitoring service
 - Support for monitoring templates in the Stack Monitoring service
 - Support for IPv6 cluster creation in the Kubernetes Engine service
 - Support for automatic and spoken punctuations in realtime in the AI Speech service
 - Support for additional connection types for Databricks, Google PubSub and Microsoft Fabric in the GoldenGate service

## 103.0.0 - 2025-02-04
### Added
 - Support for Cohere Embed v3 in the Generative AI Inference service
 - Support for Llama 3.2 tools in the Generative AI Inference service
 - Support for nginx discovery and monitoring in the Stack Monitoring service
 - Support for Oracle JVM runtime discovery and monitoring in the Stack Monitoring service
 - Support for JBoss discovery and monitoring in the Stack Monitoring service
 - Support for Service Managed Container(SMC) endpoints on list service operation in the Data Science service
 - Support for schedulers in the Data Science service
 - Support for DB system database and access modes in the HeatWave service
 - Support for DB system read endpoints in the HeatWave service
 - Support for sensitive types for data discovery in the Data Safe service
 - Support for referential relation APIs in the Data Safe service   

### Breaking Changes
 - The models `CreateAuditPolicyDetails` and `CreateAuditProfileDetails` were removed in the Data Safe service

## 102.0.0 - 2025-01-28
### Added
 - Support for external MySQL database management in the Database Management service
 - Support for fetching highly available metrics for managed databases in the Database Management service
 - Support for Exadata Infrastructure on Exadata Cloud@Customer in the Database service
 - Support for disaster recovery for cloud native applications running on OKE clusters in the Disaster Recovery service
 - Support for subscription assignment at creation of the child tenancies in the Organizations service
 - Support for additional actionable insights content-types for news reports in the Operations Insights service
 - Support for MySQL Heatwave database systems in the Operations Insights service   

### Breaking Changes
 - The enum ClassicSubscriptionEnvironmentName was removed from the Organizations service

## 101.3.0 - 2025-01-21
### Added
 - Support for Bring Your Own ASN (BYOASN) in the Networking service
 - Support for Data Guard transaction processing in the Database service
 - Support for permanently disconnecting peer autonomous databases from its primary database in the Database service
 - Support for databases with external Hardware Security Module (HSM) in the Database service
 - Support for active and standby purist modes in the Network Load Balancer service
 - Support for configurable TCP reset in the Network Load Balancer service

## 101.2.0 - 2025-01-14
### Added
 - Support for attaching route tables to VNICs and private IPs in the Networking service
 - Support for Cross Cluster Search(CCS) for an opensearch cluster in the OpenSearch service
 - Support for patch-level updates of the autonomous databases after provisioning in the Database service

## 101.1.0 - 2024-12-17
### Added
 - Support for backup retention locks on autonomous database create and update operations in the Database service
 - Support for multi-modality flags in data source in the Generative AI service
 - Support for knowledge base statistics in the Generative AI service
 - Support for document id, title and page numbers in citations in the Generative AI service
 - Support for creating and updating Amazon Web Services (AWS) asset-sources, EC2 and Elastic Block Store (EBS) assets in the Cloud Bridge service
 - Support for listing Amazon Web Services (AWS) regions available for discovery and migrations in the Cloud Bridge service
 - Support for stored video analysis in the AI Vision service
 - Support for HTTP or REST endpoint-based metric extensions in the OCI Monitoring service
 - Support for metric extension filter in the list metric extensions operation in the OCI Monitoring service
 - Support for creating and updating private endpoints for model deployments in the Data Science service
 - Support for OCI Identity user integration in the Big Data service
 - Support for user principal session tokens in the Big Data service
 - Support for historical cluster versions in the Big Data service
 - Support for new SKUs for digital assets editions in the Blockchain Platform service
 - Support for Zero ETL pipelines in the GoldenGate service

## 101.0.0 - 2024-12-10
### Added
 - Support for Bring Your Own Key (BYOK) in the Database service
 - Support for refreshing disaster recovery plans in the Disaster Recovery service
 - Support for private access to service instances in the Visual Builder service
 - Support for exadata fleet update and rollback maintenance cycle in the Fleet Application Management service
 - Support for Bring Your Own License (BYOL) for windows virtual machines in the Compute service
 - Support for cascading deletion of applications and runs in the Data Flow service
 - Support for on-demand translation and auto language detection during file translation in the AI Language service
 - Support for alias for endpoints in custom model flow and custom anonymization in the AI Language service    

### Breaking Changes
 - The properties `IdcsInfo` and `Attachments` were removed from the model `VbInstance` in the Visual Builder service
 - The models `AttachmentDetails` and `IdcsInfoDetails` were deleted from the Visual Builder service

## 100.0.0 - 2024-11-19
### Added
 - Support for optional parameters for unified auditing in the Database service
 - Support for user groups for creating technical requests in the Support Management service
 - Support for additional checksum algorithms (SHA-256, SHA-384, CRC32C) in the Object Storage service
 - Support for single Read Only (RO) endpoint for the read replicas in the PostgreSQL service
 - Support for exascale database vaults in the Database service
 - Support for virtual machine clusters with database vaults in the Database service
 - Support for N3-Gi version in the Database service    

### Breaking Changes
 - The model `ServiceCategories` was removed in the Customer Incident Management Service
 - The property `SubComponents` was removed from the `SubCategories` model in the Customer Incident Management Service
 - The property `LimitStatus` and the enum `LimitStatusEnum` were removed from the model `CreateLimitItemDetails` in the Customer Incident Management Service
 - The type of property `Services` was changed to list of `Services` from a list of `ServiceCategories` in the Customer Incident Management Service

## 99.1.0 - 2024-11-12
### Added
 - Support for calling Oracle Cloud Infrastructure services in the `me-alain-1` region
 - Support for connection refresh in the GoldenGate service
 - Support for secret compartment id in import and export operations of deployment wallet in the GoldenGate service
 - Support for creating metadata only backups in the GoldenGate service
 - Support for Llama 3.2 unit shape in Generative AI service
 - Support for Llama 3.2 vision in Generative AI Inference service
 - Support for Cohere CommandR response format in Generative AI Inference service

## 99.0.0 - 2024-11-05
### Added
 - Support for calling Oracle Cloud Infrastructure services in the `ap-seoul-2` region
 - Support for calling Oracle Cloud Infrastructure services in the `ap-suwon-1` region
 - Support for calling Oracle Cloud Infrastructure services in the `ap-chuncheon-2` region
 - Support for MFA Enablement v2 in the Identity Domains service
 - Support for starting, stopping and updating min/max executor count for SQL Endpoints in the Data Flow service
 - Support for customer message in the Customer Incident Management Service
 - Support for REJECTED limitStatus in the Customer Incident Management Service   

### Breaking Changes
 - The operations `GetCsiNumber` and `GetStatus` were removed from the `IncidentClient` in the Customer Incident Management Service
 - The property `ServiceCategories` was removed from the model `IncidentResourceType` in the Customer Incident Management Service
 - The properties `ServiceCategory` and `IssueType` were removed from the model `ServiceCategories` in the Customer Incident Management Service

## 98.1.0 - 2024-10-29
### Added
 - Support for L3IP (Layer 3 IP) listeners in the Network Load Balancing service
 - Support for overriding an existing add-on installation in the Kubernetes Engine service

## 98.0.0 - 2024-10-22
### Added
 - Support for resource locking in the File storage service
 - Support for customer managed keys via Azure key vault and Amazon Web Services key vault in the Database service
 - Support for generated tokens on create secret operations in the Identity Domains service
 - Support for creating and updating Amazon Web Services asset-sources, EC2 and EBS assets in the Cloud Bridge service
 - Support for listing Amazon Web Services regions which are available for discovery and migration in the Cloud Bridge service
 - Support for model backup retention and restore in the Datascience service
 - Support for host capacity planning for host IO metrics in the Operations Insight service
 - Support for FastConnect redundancy in the Compute service
 - Support for create, publish, clone and delete operations on runbooks in the Fleet Application Management service
 - Support for platform configurations and metadata management in the Fleet Application Management service
 - Support for management of compliance policy rules in the Fleet Application Management service
 - Support for compliance report details based on compliance policy in the Fleet Application Management service
 - Support for administrative settings like auto discovery frequency in the Fleet Application Management service   

### Breaking Changes
 - The property `DiscoveryScheduleId` was removed from the model `UpdateVmWareAssetSourceDetails` in the Cloud Bridge service
 - The operation `UpdatePlugin` was removed from the `OcbAgentSvcClient` client in the Cloud Bridge service
 - The enum `HOST_CONTAINERS` was removed from the enum `MetricNameEnum` in the model `HostPerformanceMetricGroup` in the Operations Insight service
 - The parent class of model `HostContainers` was changed from `HostPerformanceMetricGroup` to `HostConfigurationMetricGroup` in the Operations Insight service

## 97.0.0 - 2024-10-15
### Added
 - Support for open id connect discovery in the Oracle Kubernetes Engine service
 - Support for DNS security extensions (DNSSEC) in the DNS service
 - Support for restoring delta between backups to a new volume in the Block Volume service
 - Support for cross region backup copy and replication for volumes encrypted with customer keys in the Block Volume service
 - Support for list operation on deployment environments in the GoldenGate service
 - Support for defining environment types for deployments in the GoldenGate service   

### Breaking Changes
 - The type of property `Category` was changed from `CategoryEnum` to `DeploymentCategory` in the model `DeploymentTypeSummary` in the GoldenGate service
 - The enum `CategoryEnum` was removed from the model `DeploymentTypeSummary` in the GoldenGate service

## 96.2.0 - 2024-10-08
### Added
 - Support for OCI Secure Desktops service
 - Support for window preferences on cloud automation tooling updates on ExaCC and ExaCS VM clusters in the Database service
 - Support for maintenance windows in the Stack Monitoring service
 - Renamed service OCI Container Engine to OCI Kubernetes Engine
 - Support for password as an optional parameter on creating admin users in the Fusion Apps as a Service
 - Support for IAM credentials for autonomous databases in the Operations Insights service

## 96.1.0 - 2024-10-01
### Added
 - Support for calling Oracle Cloud Infrastructure services in the us-somerset-1 region
 - Support for calling Oracle Cloud Infrastructure services in the us-thames-1 region
 - Support for Security Attribute service
 - Support for Zero Trust Packet Routing service
 - Support for zero trust packet routing security attributes in the Database service
 - Support for zero trust packet routing security attributes in the Networking service
 - Support for zero trust packet routing security attributes in the Network Load Balancer service
 - Support for disaster recovery failover in the Integration Cloud service   

### Fixed
 - WorkRequest responses with the `Metadata` field no longer fail while parsing

## 96.0.0 - 2024-09-24
### Added
 - Support for Generative AI Agent service
 - Support for undeleting autonomous databases in the Database service
 - Support for assigning key versions for the pluggable databases in the Database service
 - Support for lifecycle states on list autonomous database operation in the Database service
 - Support for data masking parameter on list refresh activity operation in the Fusion Application as a Service
 - Support for configuring custom endpoints on an instance in the Integration Cloud service
 - Support for updating channel schedules on instance create operation in the Analytics service
 - Support for ExaCC via management agents in the Operations Insights service
 - Support for appending and deleting allowed SQLs from SQL firewall policies in the Data Safe service
 - Support for alarm suppressions with compartment targets and recurring schedules in the Monitoring service   

### Breaking Changes
 - The enum value `Standby` has been removed from the enum `LifecycleStateEnum` in the models `IntegrationInstance` and `IntegrationInstanceSummary` in the Integration Cloud service
 - The enum value `Standby` has been removed from the enum `LifecycleStateEnum` in the request `ListIntegrationInstancesRequest` in the Integration Cloud service

## 95.0.0 - 2024-09-17
### Added
 - Support for calling Oracle Cloud Infrastructure services in the eu-crissier-1 region
 - Support for dedicated AI cluster unit shapes in the Generative AI service
 - Support for ticket numbers when creating access requests in the Managed Access service
 - Support for 23ai database, cloud VM clusters and VM cluster patching in the Exadata Fleet Update service
 - Support for text to speech feature in the AI Speech service
 - Support for notifications and transfer of capacity requests in the OCI Control Center service    

### Breaking Changes
 - The field `OccCustomerGroupId` was made mandatory in the models `ListInternalNamespaceOccOverviewsRequest`, `ListOccAvailabilityCatalogsInternalRequest`, and `ListOccCapacityRequestsInternalRequest` in the OCI Control Center service

## 94.0.0 - 2024-08-27
### Added
 - Support for Delegate Access Control service
 - Support for upgrade and downgrade of shapes of high performance mount targets in the File Storage service
 - Support for private endpoints in the Object Storage service
 - Support for create, update, list and delete operations on scheduling policies and scheduling windows in the Database service
 - Support for specifying domains while creating data guard associations in the Database service
 - Support for provision of developer autonomous databases in the Database service
 - Support for upgrade of developer autonomous databases to paid autonomous databases in the Database service
 - Support for scheduling plans, actions, execution windows and execution actions for maintenance scheduling in the Database service
 - Support for cross-region replication of virtual vaults in the Key Management service
 - Support for listing all active service summaries in the Announcements service
 - Support for VMware major and minor version upgrades in VMware Solution service
 - Support for updating protected database subscriptions in the Autonomous Recovery service
 - Support for health insurance id as an allowed document type in the Document Understanding service
 - Support for advanced database management features for autonomous databases in the Database Management service
 - Support for propagating request ids to load balancer servers in the Load balancer service
 - Support for automatic update orders in Fusion Application as a Service   

### Breaking Changes
 - The property `TenancyId` was removed from `DocumentKeyValueExtractionFeature` and `DocumentClassificationFeature` models in the Document Understanding service
 - The property `DocumentId` was removed from `DetectedDocumentType` in the Document Understanding service
 - The enum member `INSURANCE_CLAIM` was removed from the enum `DocumentType` in the Document Understanding service

## 93.0.0 - 2024-08-20
### Added
 - Support for Fleet Application Management service
 - Support for creating maintenance runs using autonomous database software images in the Database service
 - Support for Object Storage buckets, Oracle databases, Oracle databases on exascale Infrastructure, autonomous container databases, and autonomous container databases on Cloud at Customer in the Disaster Recovery service
 - Support for multiple sharing modes in the OCI Cache service
 - Support for extended data retention periods for instances in the Integration Cloud service
 - Support for SQL watch and lifecycle management in the Database management service
 - Support for identity domains and feature sets in the Analytics Cloud service
 - Support for automatically extending the storage space for MySQL DB systems in pre-defined increments in the MySQL Database service    

### Breaking Changes
 - The property `DrPlanExecutionType` has been removed from the model `ListDrPlanExecutionsRequest` in the Disaster Recovery service

## 92.1.0 - 2024-08-13
### Added
 - Support for calling Oracle Cloud Infrastructure services in the `me-abudhabi-4` region
 - Support for viewing subscription limits in the Limits service
 - Support for TCP idle timeout on network load balancer create and update operations in the Network Load Balancing service
 - Support for creating integration instances of type Healthcare in the Integration Cloud service

## 92.0.0 - 2024-08-06
### Added
 - Support for calling Oracle Cloud Infrastructure services in the `me-riyadh-1` region
 - Support for vertically scaling a Database system in the PostgreSQL service
 - Support for flex shapes in the PostgreSQL service
 - Support for new fork repository feature in the Source Code Management service
 - Support for Developer Charts in the Source Code Management service
 - Support for pull requests and merge in Source Code Management service
 - Support for limiting custom and versioned custom software source content to the latest package versions in the OS Management service
 - Support for Open Data Hub (ODH) patching in a staged manner in the Big Data service
 - Support for Autoscale Memory Utilization in the Big Data service
 - Support for Resource Principal configuration feature in the Big Data service
 - Support for a new optional parameter compartment ID in the Java Management service
 - Support for Agent Installer in the Java Management service
 - Support for Java migration analysis request of deployed applications in the Java Management service
 - Support for JmsPlugin in the Java Management service
 - Support for improved cryptographic analysis result listing in the Java Management service
 - Support for improved fleet agent configuration setting in the Java Management service
 - Support for improved Java migration analysis result listing in the Java Management service
 - Support for improved library usage summary in the Java Management service
 - Support for improved performance tuning analysis result listing in the Java Management service
 - Support for improved work request listing in the Java Management service    

### Breaking Changes
 - The property `Credentials` was made required in the model `CreateDbSystemDetails` in the PostgreSQL service

## 91.0.0 - 2024-07-30
### Added 
- Support for cluster placement groups on get operations in the Database service 
- Support for baseline metric for imported resources and metric extensions in the Stack Monitoring service 
- Support for implicit JIT and group membership provisioning during OpenID connect flow in the Identity Domains service 
- Support for realtime speech and customizations in the AI Speech service 
- Support for self
-service instance maintenance API in the Compute service 
- Support for GoldenGate suspend phase in the Database Migration service 
- Support for creating custom alert policies in the Data Safe service 
- Support for tunnel inspection in the Network firewall service 
- Support for diagnostics collection preferences and custom GI images in the Exadata Fleet Update service    

### Breaking Changes 
- The property `ServicePrincipals` was removed from the model `IdentityPropagationTrust` in the Identity Domains service

## 90.4.0 - 2024-07-23
### Added
- Support for subscription id attribute in Cloud Exadata Infrastructure and Cloud VM Clusters in the Database service
- Support for SQL and FTP monitors on create and update operations in the Application Performance Monitoring service
- Support for MySQL Heatwave database systems in the Operations Insights service
- Support for creating and updating schedules for user assessments and security assessments in the Data Safe service
- Support for creating and updating sensitive data models of the tables for discovery in the Data Safe service
- Support for additional optional parameters on autonomous database create and update operations in the Database service
  
### Fixed
- The path parameter values and query parameter names are now url encoded

## 90.3.0 - 2024-07-16
### Added
- Support for calling Oracle Cloud Infrastructure services in the `me-abudhabi-2` region
  
### Fixed
- Fixed incorrect escaping of URL parameters

## 90.2.0 - 2024-07-09
### Added
- Support for cost management of shared resources in the Usage service
- Support for creating new databases with oracle key vault on Exadata Cloud at Customer in the Database service
- Support for confirming key store details on Exadata Cloud at Customer in the Database service

## 90.1.0 - 2024-07-02
### Added
- Support for calling Oracle Cloud Infrastructure services in the `ap-singapore-2` region
- Support for additional parameters in list and delete operations in the File Storage service
- Support for host capacity planning to analyze disabled and deleted resources in the Operations Insights service
- Support for title and description updates in the Capacity Management service
- Support for listing parameters for migrations in the Database Migration service
- Support for Oracle exadata database service on exascale Infrastructure (ExaDB-XS) in the Database service

## 90.0.0 - 2024-06-25
### Added
- Support for MySQL to MySQL homogeneous migrations in the Database Migration service
- Support for manual cross-region backups in the MySQL Heatwave service
  
### Breaking Changes
- The models AdvisorSettings, Agent, AgentCollection, AgentImageCollection, AgentImageSummary, AgentSummary, AwsS3DataTransferMediumDetails, AwsS3Details, ChangeAgentCompartmentDetails, ConnectDescriptor, CreateAdvisorSettings, CreateAwsS3Details, CreateConnectDescriptor, CreateDataPumpSettings, CreateDataTransferMediumDetails, CreateDatabaseLinkDetails, CreateDumpTransferDetails, CreateGoldenGateDetails, CreateGoldenGateHub, CreateGoldenGateServiceDetails, CreateGoldenGateServiceDetails, CreatePrivateEndpoint, CreateSshDetails, CreateVaultDetails, DataPumpJobMode, DataPumpSettings, DataTransferMediumDetails, DataTransferMediumDetailsV2, DatabaseConnectionTypes, DatabaseCredentials, DatabaseLinkDetails, DatabaseManualConnectionSubTypes, DatabaseObject, DbLinkDataTransferMediumDetails, DumpTransferDetails, GoldenGateDetails, GoldenGateHub, GoldenGateServiceDetails, GoldenGateSettings, MigrationObjectSummary, NfsDataTransferMediumDetails, ObjectStorageDataTransferMediumDetails, PrivateEndpointDetails, SshDetails, UpdateAdvisorSettings, UpdateAgentDetails, UpdateAwsS3Details, UpdateConnectDescriptor, UpdateDataPumpSettings, UpdateDataTransferMediumDetails, UpdateDatabaseLinkDetails, UpdateDumpTransferDetails, UpdateGoldenGateDetails, UpdateGoldenGateHub, UpdateGoldenGateServiceDetails, UpdateGoldenGateSettings, UpdatePrivateEndpoint, UpdateSshDetails, UpdateVaultDetails, VaultDetails, ChangeAgentCompartmentRequest, DeleteAgentRequest, GetAgentRequest, ListAgentImagesRequest, ListAgentsRequest, UpdateAgentRequest, ChangeAgentCompartmentResponse, DeleteAgentResponse, GetAgentResponse, ListAgentImagesResponse, ListAgentsResponse, and UpdateAgentResponse were removed in the Database Migration service
- The operations ChangeAgentCompartment, DeleteAgent, GetAgent, ListAgentImages, ListAgents, and UpdateAgent were removed in the Database Migration service
- The waiters ForAgent were removed in the Database Migration service
- The type of parameter targetStates was changed from an array of LifecycleStates to an array of Connection.LifecycleStateEnum in the waiters ForConnection in the Database Migration service
- The properties AgentId, SourceContainerDatabaseConnectionId, ExcludeObjects, IncludeObjects and VaultDetails were removed from the model CloneMigrationDetails in the Database Migration service
- The properties AdminCredentials, ConnectDescriptor, CertificateTdn, CredentialsSecretId, DatabaseId, DatabaseType, IsDedicated, ManualDatabaseSubType, PrivateEndpoint, ReplicationCredentials, SshDetails, and VaultDetails were removed in the model Connection in the Database Migration service
- The properties DatabaseId, DatabaseType, IsDedicated, and ManualDatabaseSubType were removed in the model ConnectionSummary in the Database Migration service
- The properties AdminCredentials, CertificateTdn, ConnectDescriptor, DatabaseId, DatabaseType, ManualDatabaseSubType, PrivateEndpoint, ReplicationCredential, SshDetails, TlsKeystore, TlsWallet, and VaultDetails were removed from the model CreateConnectionDetails in the Database Migration service
- The properties AdvisorSettings, AgentId, CsvText, DataTransferMediumDetails, DataTransferMediumDetailsV2, DatapumpSettings, DumpTransferDetails, ExcludeObjects, GoldenGateDetails, GoldenGateServiceDetails, IncludeObjects, SourceContainerDatabaseConnectionId, and VaultDetails were removed in the model CreateMigrationDetails in the Database Migration service
- The properties MapParallelism, MaxApplyParallelism, and MinApplyParallelism were removed in the models Replicat, UpdateReplicat, and CreateReplicat in the Database Migration service
- The properties AdvisorSettings, AgentId, CredentialsSecretId, DataTransferMediumDetails, DataTransferMediumDetailsV2, DatapumpSettings, DumpTransferDetails, ExcludeObjects, GoldenGateDetails, GoldenGateServiceDetails, IncludeObjects, SourceContainerDatabaseConnectionId, and VaultDetails were removed in the model Migration in the Database Migration service
- The properties CsvText and Items were removed in the model MigrationObjectCollection in the Database Migration service
- The properties AgentId, SourceContainerDatabaseConnectionId, and VaultDetails were removed in the model MigrationSummary in the Database Migration service
- The properties AdminCredentials, CertificateTdn, ConnectDescriptor, DatabaseId, PrivateEndpoint, ReplicationCredential, SshDetails, TlsKeystore, TlsWallet, and VaultDetails were removed from the model UpdateConnectionDetails in the Database Migration service
- The properties AdvisorSettings, AgentId, DataTransferMediumDetails, DataTransferMediumDetailsV2, DatapumpSettings, DumpTransferDetails, ExcludeObjects, GoldenGateDetails, GoldenGateServiceDetails, IncludeObjects, SourceContainerDatabaseConnectionId, and VaultDetails were removed in the model UpdateMigrationDetails in the Database Migration service
- The EnumMember UnknownEnumValue was removed in the enum LifecycleStates in the model LifecycleStates in the Database Migration service
- The EnumMembers OdmsInitializeGgs and OdmsValidateGgService were removed in the enum OdmsJobPhases in the model OdmsJobPhases in the Database Migration service
- The type of property LifecycleState was changed from LifecycleStates to LifecycleStateEnum in the models ConnectionS and ConnectionSummary in the Database Migration service

## 89.2.0 - 2024-06-18
### Added
- Support for public connection urls and public endpoints for autonomous databases in the Database service
- Support for insurance claim document type in the AI Document service
- Support for Microsoft IIS discovery and monitoring in the Stack Monitoring service

## 89.1.0 - 2024-06-11
### Added
- Support for 23ai based databases in Globally Distributed Database service
- Support for testing span enrichment groups in Application Performance Monitoring service
- Support for subscription suspension and termination orders in Fusion Apps as a Service
- Support for time first occurred and time last occurred for resource sightings in Cloud Guard service
- Support for alarm summary, notification title, and slack duration on create and update operations in Monitoring service
- Support for message creation timestamp in Queue service

## 89.0.0 - 2024-06-04
### Added
- Support for creating cross-region autonomous data guards in the Database service
- Support for listing autonomous database peers in the Database service
- Support for dedicated AI clusters in the Generative AI service
- Support for Llama chat and Lora Fine-Tuning method in the Generative AI service
- Support for adding and removing locks for connections, deployments, and deployment backups in the GoldenGate service
- Support for additional connection types for deployments and connections in the GoldenGate service
 
### Breaking Changes
- The property `Role` was removed in the `Message` model in the Generative AI service
- The properties `Role` and `Message` were removed in the `CohereMessage` model in the Generative AI service
- The enum members `OPENAI` and `DALLE3` were removed in the `RuntimeTypeEnum` in the model `LlmInferenceResponse` in the Generative AI service

## 88.0.0 - 2024-05-28
### Added
- Support for Demand Signal service
- Support for external database connectors in the Database service
- Support for monitoring standby databases in the Database Management service
- Support for resource overviews in the Capacity Management service
- Support for optional parameters in the download API in the Java Management Service Downloads service
  
### Breaking Changes
- The return type of property `ResourceType` and `WorkloadType` was change to `string` in `ListOccAvailabilitiesRequest`, `OccCapacityRequestBaseDetails`, and `OccAvailabilitySummary` models in the OCI Control Center service
- The model `OccCapacityRequestComputeDetails` has been removed in the OCI Control Center service

## 87.3.0 - 2024-05-21
### Added
- Support for the Resource Scheduler service
- Support for Bring Your Own Container (BYOC), custom networking and graceful termination of pipelines in the Data Science service
- Support for backup and replacement of master, utility, and edge nodes in the Big Data service
- Support for nested resource principal in the Data Science service
- Support for OKE Workload Authentication Provider

## 87.2.0 - 2024-05-14
### Added
- Support for the Marketplace Private Offer service
- Support for resizing local file systems in the Database service
- Support for PPv2 (Proxy Protocol version 2) in the Load Balancer service
- Support for custom return path for sent emails in the Email Delivery service
- Support for session resumption in the Load Balancer service

## 87.1.0 - 2024-05-07
### Added
- Support for resizing of local file systems in the Database service
- Support for adding user defined pause group in disaster recovery plan in the Disaster Recovery service
- Support for OS patching configs in the Big Data service
- Support for IP inventory and notification feature in the Networking service
- Support for accidental delete protection for load balancers, load balancer listeners, and load balancer backends in the Load Balancer service
- Support for backend max connections for load balancers in the Load Balancer service
- Support for listener max connections for load balancers in the Load Balancer service

## 87.0.0 - 2024-04-30
### Added
- Support for enabling unified auditing for DBHome in the Database service
- Support for listing minor Grid Infrastructure (GI) versions available for custom GI software image creation in the Database service
- Support for network security groups in the Recovery Cloud service 
- Support for lineage metadata import in the Data Catalog service
- Support for workspace properties in workspace create and update operations in the Data Integration service
- Support for monitoring ExaCC databases in the Database Management service
- Support for validations on target and policy before the masking process in the Data Safe service
 
### Breaking Changes
- The type of property `Enabled` was changed from string to `EnabledEnum` in the models `SqlPlanBaseline` and `SqlPlanBaselineSummary` in the Database Management service
- The type of property `Accepted` was changed from string to `AcceptedEnum` in the models `SqlPlanBaseline` and `SqlPlanBaselineSummary` in the Database Management service
- The type of property `Fixed` was changed from string to `FixedEnum` in the models `SqlPlanBaseline` and `SqlPlanBaselineSummary` in the Database Management service
- The type of property `Reproduced` was changed from string to `ReproducedEnum` in the models `SqlPlanBaseline` and `SqlPlanBaselineSummary` in the Database Management service
- The type of property `AutoPurge` was changed from string to `AutoPurgeEnum` in the models `SqlPlanBaseline` and `SqlPlanBaselineSummary` in the Database Management service
- The type of property `Adaptive` was changed from string to `AdaptiveEnum` in the models `SqlPlanBaseline` and `SqlPlanBaselineSummary` in the Database Management service
- The type of property `AllSqlStatementsFetched` was changed from string to `AllSqlStatementsFetchedEnum` in the model `SqlTuningSet` in the Database Management service

## 86.0.0 - 2024-04-23
### Added
- Support for the Cluster Placement Groups service
- Support for new optional parameter for managing approval template in the Managed Access service
- Support for cluster placement groups in the Compute service
- Support for replacing boot volume for virtual machines in the Compute service
- Support for assigning a cluster placement group to boot and block volumes in the Block Storage service
- Support for container workload integration in the Cloud Guard service
- Support for instances in OCI and 3rd party clouds in the OS Management service

### Breaking Changes
- The property `InstanceLocation` was removed from the models `SummarizeManagedInstanceAnalyticsRequest` and `GetManagedInstanceAnalyticContentRequest` in the OS Management service
- The property `AdvisoryType` was removed from the models `ListManagedInstanceErrataRequest` and `GetManagedInstanceContentRequest` in the OS Management service
- The type of property `Architecture` was changed from `string` to `SoftwarePackageArchitecture` in the models `SoftwarePackage` and `SoftwarePackageSummary` in the OS Management service

## 85.1.0 - 2024-04-16
### Added
- Support for calling Oracle Cloud Infrastructure services in the me-abudhabi-3 region
- Support for new Image resource for an Autonomous Database in the Database service
- Support for creating Autonomous Container Database using Autonomous Database Software Image in the Database service
- Support for new dedicated AI cluster unit shape in the Generative AI service
- Support for Chat API for LLM models in the Generative AI service
- Support for network security groups (NSGs) in the Redis service
- Support for custom public egress on model deployments in the Data Science service
- Support for a new data transfer parameter for AWS S3 bucket in the Database Migration service
- Support for Oracle Process Automation instance start and stop operations in the Process Automation service
- Support for healthcare Natural Language Processing (NLP) in the AI Language service
- Support for identification and de-identification of Private Health Information (PHI) service in the AI Language service
- Support for multilingual content for using machine learning models in the AI Language service
- Support for usage statements in cost management in the Usage service

## 85.0.0 - 2024-04-09
### Added
- Support for calling Oracle Cloud Infrastructure services in the ap-dcc-gazipur-1 region
- Support for the DNS-based backend health check in the Network Load Balancer service
- Support for Fail Open in the Network Load Balancer service
- Support for adding and updating Instant failover in the Network Load Balancer service
- Support for adding and updating source type and resource category for resource types in the Stack Monitoring service
- Support for searching resources based on resource category,  source type, multiple compartments, multiple lifecycle states in the Stack Monitoring service
- Support for filtering listed resources based on lifecycle status in the Stack Monitoring service
- Support for creating tasks with new config parameters in the Stack Monitoring service
- Support for Composite Resource Principal integration in the Data Flow service

### Changed
- The `TargetFramework` of projects `Objectstoragetests`, `Commontests` and `Examples` was changed from `netcoreapp3.1` to `net6.0`

### Breaking Changes
- The Application Migration service was decommissioned and removed

## 84.0.0 - 2024-04-02
### Added
- Support for assigned private IP and single stack IPV6 feature for Network Load Balancer Service
- Support for Configuration API in Email Delivery Service
- Support for the status field in creating data source resource for Cloud Guard Service
- Support for TLSv1.3 in Load Balancer Service
- Support for sending mails via HTTPS for Email Delivery Service
- Support for getting original HttpResponseMessage from the response models, which can be leveraged to consume `text/event-stream` events. Refer the [GenAIInferenceExample](https://github.com/oracle/oci-dotnet-sdk/blob/master/Examples/GenAIInferenceExample.cs) to learn more
 
### Changed
- All Response models are now derived from the abstract base class `OciResponse` which implements the interface `IOciResponse` instead of implementing the `IOciResponse` interface directly
 
### Breaking Changes
- The type of property `Reason` was changed from `ReasonEnum` to `SuppressionReason` in the model `SuppressionSummary` in the Email Delivery Service

## 83.0.0 - 2024-03-26
### Added
- Support for creating and updating a refreshable clone with auto-refresh for an Autonomous Database in the Database service
- Support for symmetric hashing in the Network Load Balancer service
- Support for creating and deploying helm command specifications in the DevOps Service
- Support for uninstalling helm chart when deleting an Oracle Kubernetes Stage through the DevOps Service
- Support for collecting metrics and filter plugin with Unified Monitoring Agent (UMA) in the Logging service
- Support for reading logs from head position after agent restart in the Logging service
- Support for monitoring MySQL HeatWave clusters in Database Management Service
- Support for multiple severities in an alarm in the Monitoring service
 
### Breaking Changes
- The properties `DisplayName` and `Description` were made required in the model `CreateUnifiedAgentConfigurationDetails` in the Logging service
- The property `RecordInput` was made required in the model `OperationalMetricsSource` in the Logging service

## 82.2.0 - 2024-03-19
### Added
- Support for standalone Oracle HTTP server discovery and monitoring in the Stack Monitoring service
- Support for attribute management for traces in the Application Performance Monitoring service
- Support for async jobs and document translations in the AI language service

## 82.1.0 - 2024-03-12
### Added
- Support for new development license type on dedicated infrastructure in the Database service
- Support for placement parameters on Autonomous Container Database create operation in the Database service
- Support for autoscaling on model deployment in the Data Science service

## 82.0.0 - 2024-03-05
### Added
- Support for Linux capabilities configuration for the containers in the Container Instances service
- Support for service platforms in the Oracle Store Platform Gateway service
- Support for whisper models and delete job operation in the Speech service
- Support for new SQL insight content types in news reports in the Operations Insights service
- Support for launching virtual machines with multiple volumes in the Compute service
 
### Changed
- The 3P library `System.IdentityModel.Tokens.Jwt` was upgraded from version `6.7.1` to `6.35.0` to address CVE-2024-21319 and Microsoft Identity Denial of service vulnerability
  
### Breaking Changes
- The property `CapacityPlanningResources` was made optional in the model `NewsContentTypes` in the Operations Insights service

## 81.0.0 - 2024-02-27
### Added
- Support for specifying dialog version when creating skills entities in the Digital Assistant service
- Support for bulk creation of skill entities in the Digital Assistant service
- Support for training skill query entities in the Digital Assistant service
- Support for cascading delete of skill custom entities in the Digital Assistant service
- Support for creating autonomous dataguard associations in the Database service
- Support for auto generation of secrets in the Secret Management service
- Support for cluster placement groups in Cloud Exadata Infrastructure in the Database service
- Support for retrieving previous logs of the container in the Container Instances service
- Support for queue sources in the Connector Hub service
- Support for automatic key rotation in the Key Management Service
- Support for downloading operator activity reports and assignment healthchecks in the Operator Access Control service
- Support for operator requesting access in the future time in the Operator Access Control service
- Support for forwarding hypervisor logs in the Operator Access Control service
- Support for asynchronous data asset export in the Data Catalog service
- Support for launch with multiple volumes for virtual machines in the Compute Service
- Support for tagging in Database Management service
  
### Breaking Changes
- The property `MaxCpuCoreCount` was removed from the models `AutonomousDatabase`, `AutonomousDatabaseSummary`, `CreateAutonomousDatabaseBase`, and `UpdateAutonomousDatabaseDetails` in the Database service
- The property `PeerCloudAutonomousVmClusterId` was renamed to `PeerAutonomousVmClusterId` in the model `CreateAutonomousContainerDatabaseDataguardAssociationDetails` in the Database service
- The model `DatabaseConnectionCredentailsByName` was renamed to `DatabaseConnectionCredentialsByName` in the Database service

## 80.0.0 - 2024-02-20
### Added
- Support for calling Oracle Cloud Infrastructure services in the me-dcc-doha-1 region
- Support for Secure Desktops service
- Support for enabling and disabling Simultaneous Multithreading (SMT) for virtual machines in the Compute service
- Support for Bring Your Own Container Jobs (BYOC v2) in the Data Science service
- Support for expanded language translation in the AI Language service
- Support for additional flags for ignoring transliteration and text length to be considered for determining dominant language in the AI Language service
  
### Breaking Changes
- The model `Oci.AilanguageService.Models.PreTrainedPhiModelDetails` was removed in the AI Language service
- The field `SystemTags` has changed type from `Dictionary<string, Object>` to `Dictionary<string, Dictionary<string, Object>>` in the models `Endpoint`, `EndpointSummary`, `Model`, `ModelSummary`, `Project`, and `ProjectSummary` in the AI Language service

## 79.1.0 - 2024-02-13
### Added
- Support for adding automatic backups during cross region operations and disaster recovery in the Autonomous Database service
- Support for overlapping CIDR in network path analyzer in the Virtual Network Monitoring service
- Support for additional attributes in entity and topology in the Log Analytics service
- Support for historic collection and log type while creating object collection rules in the Log Analytics service
- Support for position aware parsers in the Log Analytics service
- Support for filtering log sources, detection rules and scheduled tasks based on target service in the Log Analytics service
- Support for additional recall and release attributes in the Log Analytics service
- Support for opc-meta-properties header while uploading log events in the Log Analytics service

## 79.0.0 - 2024-02-06
### Added
- Support for the Globally Distributed Database service
- Support for secret auto-rotation in the Secret Management service
- Support for dedicated key management in the Key Management service
- Support for resource locking operations in the Digital Media service
- Support for data sources, including prometheus emitter, in the Management Agent service
- Support for Bring Your Own Certificates (BYOC) in the MySQL HeatWave Database service
 
### Breaking Changes
- The operations `GetMediaWorkflowJobFact` and `ListMediaWorkflowJobFacts` were removed in the Digital Media service
- The models `MediaWorkflowJobFact` and `MediaWorkflowJobFactSummary` were removed in the Digital Media service
- The property `OpcWorkRequestId` was removed from the `ChangeMediaWorkflowCompartmentResponse`, `ChangeMediaWorkflowConfigurationCompartmentResponse`, `ChangeMediaWorkflowJobCompartmentResponse`, `ChangeStreamDistributionChannelCompartmentResponse`, `DeleteMediaWorkflowConfigurationResponse`, `DeleteMediaWorkflowJobResponse`, and `UpdateStreamPackagingConfigResponse` responses in the Digital Media service

## 78.2.0 - 2024-01-30
### Added
Support for OCI Control Center service
Support for giro value set for address rules in the Oracle Store Platform service
Support for giro in tax information for subscriptions in the Oracle Store Platform service
Support for REST connectivity with Oath2 in the Data Integration service
Support for resolver rules limit increase in the DNS service
Support for named credentials in the Database Management service

## 78.1.0 - 2024-01-23
### Added
- Support for the Generative AI service
- Support for additional currencies and countries for paid listings in the Marketplace service
- Support for process sets in the Stack Monitoring service

## 78.0.0 - 2024-01-16
### Added
- Support for resource id filter on the service work requests in the Container Instances service
- Support for polyglot vulnerability audit in the Application Dependency Management service
- Support for create, read, and update operations on peer databases in the Data Safe service
- Support for dimension specific alarm suppressions in the Monitoring service
- Support for calculating audit volume in the Data Safe service
- Support for viewing schema accesses in data safe user assessments in the Data Safe service
- Support for security feature usage in the Data Safe service
- Support for viewing the top security findings in data safe security assessments in the Data Safe service
- Support for additional filters in list findings operation in the Data Safe service
- Support for updating risk level of the specified finding in the Data Safe service
 
### Breaking Changes
- The property `OpcWorkRequestId` was removed from the response model `CreateVulnerabilityAuditResponse.cs` in the Application Dependency Management service

## 77.1.0 - 2024-01-09
### Added
- Support for calling Oracle Cloud Infrastructure services in the sa-valparaiso-1 region
- Support for creation of up to 60 containers per container instance in the Container Instances service
- Support for Oracle GoldenGate discovery and monitoring in the Stack Monitoring service
- Support for GoldenGate stream analytics in the GoldenGate service
- Support for backup work requests in MySQL Heatwave service
- Support for create, update, delete and list operations on premise vantage points in the Application Performance Monitoring service
- Support for create, update, delete and list operations on workers in the Application Performance Monitoring service
- Support for host capacity planning for compute instances and host unallocated metrics in the Operations Insights service

## 77.0.0 - 2023-12-12
### Added
- Support for changing compartments of configurations in the PostgreSQL service
- Support for granular policies including compartments, resource types, and recommendations in the Optimizer service
- Support for token exchanges in the Identity Domains service
- Support for Apache HTTP server discovery and monitoring in the Stack Monitoring service
- Support for resource locking in the Data Catalog service
- Support for concurrency throttling in the Data Integration service
- Support for reboot migrations for VMs on dedicated hosts in the Compute service
- Support for connection routing method settings and subnet update in the GoldenGate service
- Support for data discovery of commonly used sensitive types in the Data Safe service
- Support for incremental extraction and updates to the workflows in the Data Integration service
  
### Breaking Changes
- The properties `Etag` and `Configuration` were removed from the model `ChangeConfigurationCompartmentResponse` in the PostgreSQL service

## 76.0.0 - 2023-12-04
### Added
- Support for calling Oracle Cloud Infrastructure services in the eu-dcc-zurich-1 and the sa-bogota-1 region
- Support for managing certificates of target Servers in the Golden Gate service
- Support for AWR Hub Snapshot ingest endpoints in the Operations Insights service
- Support for reducing false positives in the Application Dependency Management service
- Support for ARM shapes in the Data Science service
- Support for new optional parameters in the upload discovery data API in the Usage service
- Support for multiple clusters in a Software-Defined Data Centers (SDDCs) in the VMWare Solution service
- Support for No/Zero days backup in Autonomous Container Database in the Database service
- Support for provisioning a VM Cluster with a choice of Exadata image version in the Database service
- Support for updating ocpu/ecpu count, local storage, ACD count and Exadata storage on Cloud Autonomous VM Cluster and Autonomous VM Cluster in the Database service
- Support for serial console history in the Database service
- Support for Oracle Linux 8 version database system in the Database service
 
### Breaking Changes
- The properties `ComputeAvailabilityDomain`, `InstanceDisplayNamePrefix`, `EsxiHostsCount`, `InitialSku`, `VcenterInitialPassword`, `NsxManagerInitialPassword`, `WorkloadNetworkCidr`, `NsxOverlaySegmentName`, `ProvisioningSubnetId`, `VsphereVlanId`, `VmotionVlanId`, `VsanVlanId`, `NsxVTepVlanId`, `NsxEdgeVTepVlanId`, `NsxEdgeUplink1VlanId`, `NsxEdgeUplink2VlanId`, `ReplicationVlanId`, `ProvisioningVlanId`, `HcxInitialPassword`, `HcxVlanId`, `IsHcxEnabled`, `HcxOnPremKey`, `IsHcxEnterpriseEnabled`, `UpgradeLicenses`, `VsphereUpgradeGuide`, `VsphereUpgradeObjects`, `InitialHostShapeName`, `InitialHostOcpuCount`, `IsShieldedInstanceEnabled`, `CapacityReservationId`, `Datastores` were removed from the model `Sddc` in the VMWare Solution service
- The properties `ComputeAvailabilityDomain`, `EsxiHostsCount` and `IsHcxEnabled` were removed from the model `SddcSummary` in the VMWare Solution service
- The properties `SddcId`, `CurrentSku`, `NextSku`, `FailedEsxiHostId` and `NonUpgradedEsxiHostId` were removed from the model `CreateEsxiHostDetails` in the VMWare Solution service
- The properties `ComputeAvailabilityDomain`, `EsxiHostsCount`, `InitialSku`, `IsHcxEnabled`, `HcxVlanId`, `IsHcxEnterpriseEnabled`, `WorkloadNetworkCidr`, `ProvisioningSubnetId`, `VsphereVlanId`, `VmotionVlanId`, `VsanVlanId`, `NsxVTepVlanId`, `NsxEdgeVTepVlanId`, `NsxEdgeUplink1VlanId`, `NsxEdgeUplink2VlanId`, `ReplicationVlanId`, `ProvisioningVlanId`, `InitialHostShapeName`, `InitialHostOcpuCount`, `IsShieldedInstanceEnabled`, `CapacityReservationId`, `InstanceDisplayNamePrefix`, and `Datastores` were removed from the model `CreateSddcDetails` in the VMWare Solution service
- The properties `VsphereVlanId`, `VmotionVlanId`, `VsanVlanId`, `NsxVTepVlanId`, `NsxEdgeVTepVlanId`, `NsxEdgeUplink1VlanId`, `NsxEdgeUplink2VlanId`, `ReplicationVlanId`, `ProvisioningVlanId`, `and HcxVlanId` were removed from the model `UpdateSddcDetails` in the VMWare Solution service
- The properties `SupportedSddcTypes` and `IsSupportMonthlySku` were removed from the model `SupportedHostShapeSummary` in the VMWare Solution service
- The property `NextSku` was removed from the model `UpdateEsxiHostDetails` in the VMWare Solution service
- The properties `CurrentSku` and `NextSku` were removed from the models `EsxiHost` and `EsxiHostSummary` in the VMWare Solution service
- The models `SupportedSkuSummary`, `SupportedSkuSummaryCollection`, `SddcTypes`, `DatastoreSummary`, `ListSupportedSkusRequest`, and `ListSupportedSkusResponse` were removed from the VMWare Solution service
- The operations `ListSupportedHostShapesResponseEnumerator`, `ListSupportedHostShapesRecordEnumerator`, `ListSupportedSkusResponseEnumerator`, `ListSupportedSkusRecordEnumerator` were removed from `SddcPaginators` in the VMWare Solution service

## 75.0.0 - 2023-11-14
### Added
- Support for the PostgreSQL service
- Support for new operations in the Identity Domains service
- Support for enabling, disabling, and renewing SSL/TLS in the Big Data service
- Support for diarization in the AI Speech service
- Support for Capacity Topology API in the Compute service
 
### Breaking Changes
- The type of property `Status` was changed from `string` to `StatusEnum` in the `MyRequest` model in the Identity Domains service

## 74.1.0 - 2023-11-07
### Added
- Support for Java Management Service Downloads
- Support for creating autonomous dataguard associations in the Database service
- Support for SaaS administrative user configurations for autonomous database in the Database service
- Support for macOS in the the Java Management service
- Support for distribution and management of deployment rule sets in the Java Management service
- Support for new download location of Oracle Java runtime binaries in the Java Management service
- Support for exporting data across regions in the Java Management service

## 74.0.0 - 2023-10-31
### Added
- Support for calling Oracle Cloud Infrastructure services in the us-saltlake-2 region
- Support for disaster recovery of load balancers, network load balancers and file systems in the Disaster Recovery service
- Support for performing disaster recovery drills in the Disaster Recovery service
- Support for enterprise SKUs and extensibility in the Stack Monitoring service
- Support for metric extensions in the Stack Monitoring service
- Support for baseline and anomaly detection in the Stack Monitoring service
- Support for integration with Database Management service in the MySQL HeatWave service
- Support for MySQL database management in the Database Management service
- Support for database firewalls in the Data Safe service
 
### Breaking Changes
- The properties `CompartmentId` and `UserAssessmentId` were removed from the `ProfileAggregation` model in the Data Safe service
- Alloy feature was renamed to DeveloperToolConfiguration

## 73.0.0 - 2023-10-24
### Added
- Support for optional parameters for autonomous container database create and update operations in the Database service
- Support for maintenance runs for autonomous container database resources in the Database service
- Support for runtime unsupported connections for Oracle Database and MySQL database types in the Database Tools service
- Support for PostgreSQL, Generic JDBC connections with runtime unsupported in the Database Tools service
- Support for resource locking in the Database Tools service
- Support for proxy sessions for Oracle database connections in the Database Tools service
- Support for global active tables in the NoSQL Database service
- Support for application dependency management (ADM) remediation features in the Application Dependency Management service
- Support for additional connections types for Amazon Kinesis, Amazon Redshift, Elasticsearch, Generic, Google BigQuery, Google Cloud Storage and Redis Database resources in the Golden Gate service
- Support for optional parameters for the list alarms status operation in the Monitoring Service
 
### Breaking Changes
- The property `OpcRetryToken` was removed from `ChangeDatabaseToolsPrivateEndpointCompartmentRequest` and `ChangeDatabaseToolsConnectionCompartmentRequest` models in the Database Tools service

## 72.0.0 - 2023-10-17
### Added
- Support for the Caching Service
- Support for the Marketplace Publisher service
- Support for higher limits for network firewalls in the Network Firewall service
- Support for exporting access request reports in the Lockbox service
- Support for storage mounts for jobs and notebooks in the Data Science service
- Support for unified agent operational metrics for the service configurations in the Logging Management service

### Breaking Changes
- The properties `DisplayName` and `RqsType` were removed in the `Parameter` model in the Logging Management service
- The enum members `EnumString` and `RqsFilter` were remoeved from the enum `TypeEnum` in the `Parameter` model in the Logging Management service
- The property `ServiceStage` was removed in the `ListServicesRequest` model in the Logging Management service
- The models `TcpApplication` and `UdpApplication` were removed in the Network Firewall service
- The enum `TypeEnum` was removed in the model `DecryptionProfile` in the Network Firewall service
- The properties `MappedSecrets`, `ApplicationLists`, `UrlLists`, `IpAddressLists`, `SecurityRules`, `DecryptionRules` and `DecryptionProfiles` were removed in the model `CreateNetworkFirewallPolicyDetails` in the Network Firewall service
- The enum `ActionEnum` was removed in the model `DecryptionRule` in the Network Firewall service
- The type of property `Action` was changed to `DecryptionActionType` in the model `DecryptionRule` in the Network Firewall service
- The property `Sources` has been replaced by `SourceAddress` in the models `SecurityRuleMatchCriteria` and `DecryptionRuleMatchCriteria` in the Network Firewall service
- The property `Destinations` has been replaced by `DestinationAddress` in the models `SecurityRuleMatchCriteria` and `DecryptionRuleMatchCriteria` in the Network Firewall service
- The enum `TypeEnum` was removed in the model `MappedSecret` in the Network Firewall service
- The type of property `Type` was changed to `InspectionType` in the model `MappedSecret` in the Network Firewall service
- The properties `ApplicationLists`, `UrlLists`, `IpAddressLists`, `SecurityRules`, `DecryptionRules`, `DecryptionProfiles`, `MappedSecrets` and `IsFirewallAttached` were removed in the model `NetworkFirewallPolicy` in the Network Firewall service
- The enums `ActionEnum` and `InspectionEnum` were removed in the model `SecurityRule` in the Network Firewall service
- The type of property `Action` was changed to `TrafficActionType` in the model `SecurityRule` in the Network Firewall service
- The type of property `Inspection` was changed to `TrafficInspectionType` in the model `SecurityRule` in the Network Firewall service
- The property `Applications` has been replaced by `Application` in the model `SecurityRuleMatchCriteria` in the Network Firewall service
- The property `Urls` has been replaced by `Url` in the model `SecurityRuleMatchCriteria` in the Network Firewall service
- The properties `MappedSecrets`, `ApplicationLists`, `UrlLists`, `IpAddressLists`, `SecurityRules`, `DecryptionRules` and `DecryptionProfiles` were removed in the model `UpdateNetworkFirewallPolicyDetails` in the Network Firewall service

## 71.4.0 - 2023-10-10
### Added
- Support for creating flow log type capture filters in the Virtual Cloud Network service
- Support for importing and exporting metadata in Data Integration service
- Support for displaying resource usage information on autonomous vm cluster get operations in the Database service
- Support for displaying resource usage information for the list of autonomous container databases on autonomous vm cluster get operations in the Database service
- Support for pluggable database with enhanced features in the Database service
- Support for exporting container and kubernetes app listings in the Marketplace service
- Support for work request statuses for export container and kubernetes app listings in the Marketplace service

## 71.3.0 - 2023-10-03
### Added
- Support for elastic resource pools in the Database service
- Support for private endpoints in the Data Science service
- Support for File System Service (FSS) as transfer medium for data export and import in the Database Migration service
- Support for new optional parameters on replica create, update and list operations in the MySQL Heatwave service

## 71.2.0 - 2023-09-26
### Added
- Support for listing compute performances and storage performances in Database service
- Support for private endpoints for external key managers in Key Management service
- Support for additional parameters in vaults and keys for external key managers in Key Management service
- Support for domains while creating integration instances in Oracle Integration Cloud service

## 71.1.0 - 2023-09-12
### Added
- Support for SQL tuning sets in Database Management service
- Support for announcement chaining in Announcements service
- Support for automatic promotion of hosts in Stack Monitoring service
- Support for face detection in AI Vision service
- Support for change parameters on list character sets operation in Database Management service
- Support for displaying software sources attached to a managed instance group in OS Management service

## 71.0.0 - 2023-09-05
### Added
- Support for queue channels in the Queue Service
- Support for entity lineage retrieval and asynchronous glossary export in the Data Catalog service
- Support for filtering and sorting while listing work requests in the Container Instances service
- Support for the ability to create support requests for various support ticket types (TECH, LIMIT, ACCOUNT) in the Customer Incident Management Service
- Endpoint changed from https://incidentmanagement.{region}.{domainAndTopLevelDomain} to https://incidentmanagement.{region}.oci.{domainAndTopLevelDomain} (e.g. https://incidentmanagement.us-phoenix-1.oraclecloud.com to https://incidentmanagement.us-phoenix-1.oci.oraclecloud.com) in the Customer Incident Management Service
 
### Breaking Changes
- The models `AvailabilityDomain`, `Region`, `CreateUserRequest`, and `UserClient` were removed from the Customer Incident Management Service
- The type of property `ProblemType` was changed from `string` to `ProblemType` in the `ValidateUserRequest` model in the Customer Incident Management Service
- The property `Source` was removed from the model `GetStatusRequest` in the Customer Incident Management Service
- The property `ProblemType` was renamed to `Problemtype` in the model `GetIncidentRequest` in the Customer Incident Management Service
- The property `AvailabilityDomain` was removed from the models `Resource` and `CreateResourceDetails` in the Customer Incident Management Service
- The type of property `Region` was changed from `Region` to `string` in the models `Resource` and `CreateResourceDetails` in the Customer Incident Management Service
- The property `Country` was removed from the model `CreateUserDetails` in the Customer Incident Management Service

## 70.0.0 - 2023-08-29
### Added
- Support for creating and updating network monitors in the Application Performance Monitoring Synthetics service
- Support for integration of GoldenGate service for replication in the Database Migration Service
- Support for displaying resource usage information on autonomous container database and cloud autonomous vm cluster get operations in the Database service
- Support for FastConnect Media Access Control Security (MACSec) fail open option in the Network Monitoring service
- Support for generic bare metal types and configuration maps in compute instance platform configuration in the Compute service
- Support for encrypted FastConnect in the Network Monitoring service
- Support for new parameters on customer premises equipment and virtual circuit create operations in the Network Monitoring service
- Support for virtual circuit associated tunnels in the Network Monitoring service
- Support for additional parameters on dynamic routing gateway create and update operations in the Network Monitoring service
- Support for assigning an IPv6 address to a compute instance during instance launch or secondary VNIC attach in the Compute service
 
### Breaking Changes
- The models `AnalyticsCluster`, `AnalyticsClusterMemoryEstimate`, `AnalyticsClusterMemoryEstimateStatus`, `AnalyticsClusterNode`, `AnalyticsClusterSchemaMemoryEstimate`, `AnalyticsClusterSummary`, `AnalyticsClusterTableMemoryEstimate`, `UpdateAnalyticsClusterDetails`, `AddAnalyticsClusterRequest`, `DeleteAnalyticsClusterRequest`, `GenerateAnalyticsClusterMemoryEstimateRequest`, `GetAnalyticsClusterRequest`, `RestartAnalyticsClusterRequest`, `StartAnalyticsClusterRequest`, `StopAnalyticsClusterRequest`, `UpdateAnalyticsClusterRequest`, `DeleteAnalyticsClusterResponse`, `GetAnalyticsClusterMemoryEstimateResponse`, `RestartAnalyticsClusterResponse`, `StartAnalyticsClusterResponse`, `StopAnalyticsClusterResponse`, `UpdateAnalyticsClusterResponse` were removed in the MySQL Database service
- The properties `IsAnalyticsClusterAttached` and `AnalyticsCluster` were removed from `DbSystem` and `DbSystemSummary` models in the MySQL Database service
- The enum member `ANALYTICSCLUSTER` was removed from the enum `IsSupportedForEnum` in the models `ShapeSummary` and `ListShapesRequest` in the MySQL Database service
- The enum members `ADD_ANALYTICS_CLUSTER`, `UPDATE_ANALYTICS_CLUSTER`, `DELETE_ANALYTICS_CLUSTER`, `START_ANALYTICS_CLUSTER`, `STOP_ANALYTICS_CLUSTER`, `RESTART_ANALYTICS_CLUSTER`, `GENERATE_ANALYTICS_CLUSTER_MEMORY_ESTIMATE` were removed from the enum `WorkRequestOperationType` in the MySQL Database service
- The property `IsAnalyticsClusterAttached` was removed from the model `ListDbSystemsRequest` in the MySQL Database service
- The operations `AddAnalyticsCluster`, `DeleteAnalyticsCluster`, `GenerateAnalyticsClusterMemoryEstimate`, `GetAnalyticsCluster`, `GetAnalyticsClusterMemoryEstimate`, `RestartAnalyticsCluster`, `StartAnalyticsCluster`, `StopAnalyticsCluster`, `UpdateAnalyticsCluster` were removed from the `DbSystemClient` in the MySQL Database service
- The waiters `ForAnalyticsCluster` were removed from `DbSystemWaiters` in the MySQL Database service

## 69.2.0 - 2023-08-22
### Added
- Support for Compute Cloud at Customer service
- Support for warehouse data objects in the Operations Insights service
- Support for standard queries on operations insights data objects in the Operations Insights service
- Support for database in memory on autonomous database create operations in the Database service

## 69.1.0 - 2023-08-15
### Added
- Support for credential stores, including Single Sign-On support, for deployments in the GoldenGate service
- Support for container security contexts in the Container Instances service
- Support for placement constraints and cluster configurations on cluster networks in the Compute service

## 69.0.0 - 2023-08-08
### Added
- Support for backup retention on autonomous database create operations in the Database service
- Support for exclude tables for replication in the Database Migration service
- Support for adding and updating auto failover maximum data loss limits for local autonomous data guards in the Database service
- Support for limiting networking diagram ingestion in the Networking Monitoring service
- Support for new operations for deployment upgrades in the GoldenGate service
- Support for getting model type information and base model versions while creating language custom models in the AI Language service
- Support for support field in class metric in the AI Language service
- Support for Compute Cloud at Customer resource type in the Operator Access Control service
- Support for managing account management info, account recovery settings, app roles, apps, app status changers, grants, identity propagation trusts and settings, request-able groups, requests, security questions, OAuth tokens, and user attribute settings in the Identity Domains service

### Breaking Changes
- The property `IsInternetAccessAllowed` has been removed from the `CreateIpv6Details`, `Ipv6` and `UpdateIpv6Details` models in the Networking Monitoring service
- The property `PublicIpAddress` has been removed from the `Ipv6` model in the Networking Monitoring service
- The property `Ipv6CidrBlock` has been removed from the `Vcn` and `CreateVcnDetails` models in the Networking Monitoring service
- The property `Ipv6PublicCidrBlock` has been removed from the `Vcn` and `Subnet` models in the Networking Monitoring service

## 68.0.0 - 2023-08-01
### Added
- Support for the Exadata Fleet Update service
- Support for REST-based log collection, multi-conditional labels, and collection properties in the Logging Analytics service
- Support for Kubernetes cluster credential rotation in the Container Engine for Kubernetes service
- Support for zero-downtime features in the Fusion Apps as a Service service
- Support for news reports in the Operations Insights service
  
### Breaking Changes
- The EnumMember `AccelerationMaintenance` was removed from the enum `TaskType` in the `TaskType` model in the Logging Analytics service

## 67.0.0 - 2023-07-25
### Added
- Support for composing multiple document service custom key value models into one single model in Document Understanding Service
- Support for custom hostname in the Compute service
- Support for cloud subscription in the Organizations service
- Support for automatic backup download in the GoldenGate service
- Support for creating single use (non-recurring) budgets in the Budgets service
 
### Breaking Changes
- The properties `ClassicSubscriptionId`, `IsClassicSubscription`, `RegionAssignment`, `LifecycleState`, `StartDate` and `EndDate` were removed from the models `AssignedSubscription`, `AssignedSubscriptionSummary`, `Subscription` and `SubscriptionSummary` in the Organizations service
- The property `PaymentModel` has been removed from `Subscription` and `SubscriptionSummary` models in the Organizations service
- The properties `SubscriptionTier`, `IsGovernmentSubscription`, `Promotion`, `PurchaseEntitlementId`, `Skus`, `CsiNumber`, `CloudAmountCurrency`, `CustomerCountryCode, and `ProgramType` have been removed from `AssignedSubscription` and `Subscription` models in the Organizations service
- The property `OrderIds` has been removed from `AssignedSubscription` model in the Organizations service
- The EnumMembers `UPDATING`, `DELETING` and `DELETED` were removed from the enum `SubscriptionLifecycleState` in the Organizations service
- The waiters `ForAssignedSubscription` and `ForSubscription` were removed from the `SubscriptionWaiters` in the Organizations service

## 66.0.0 - 2023-07-18
### Added
- Support for calling Oracle Cloud Infrastructure services in the mx-monterrey-1 region
- Support for Kerberos and LDAP with NFSv3 in the File Storage service
- Support for capacity reservation checks for movable compute instances in the Disaster Recovery service
- Support for Oracle MFT monitoring in the Stack Monitoring service
- Support for OS patching in the Big Data service
- Support for master and utility nodes in the Big Data service
- Support for connectivity testing in the GoldenGate service
 
### Breaking Changes
- The type of property `SizeInBytes` was changed from `decimal` to `long` for the `DeploymentBackup`, `DeploymentBackupSummary`, `TrailFileSummary`, and `TrailSequenceSummary` in the GoldenGate service
- The enum type `UnknownEnumValue` was removed from the enum `ContainerCapability` in the Container Instances service
- The property `AdditionalCapabilities` was removed from the models `Container` and `CreateContainerDetails` in the Container Instances service
- The property `FunctionId` was made required in the model `UpdateInvokeFunctionUserDefinedStepDetails` in the Disaster Recovery service
- The properties `RunOnInstanceId` and `ScriptCommand` were made required in the model `UpdateRunLocalScriptUserDefinedStepDetails` in the Disaster Recovery service
- The properties `RunOnInstanceId` and `ObjectStorageScriptLocation` were made required in the model `UpdateRunObjectStoreScriptUserDefinedStepDetails` in the Disaster Recovery service
- The properties `FunctionId` and `FunctionRegion` were made required in the model `InvokeFunctionStep` in the Disaster Recovery service

## 65.0.0 - 2023-07-11
### Added
- Support for specifying default snapshot enablement, verified response codes, client certificate details, and request authentication schemes when creating or updating synthetic monitors in the Application Performance Monitoring service
- Support for address rules, address verification, and requesting addresses in the OSP Gateway service
- Support for synchronous operations in the Document Understanding service
- Support for migration without SSH to database hosts (DMS) in the Database Migration service
- Support for processing workload mappings in the Container Engine for Kubernetes service
- Support for Salesforce, MySQL HeatWave, and Oracle EBS, Sieble, and PeopleSoft connectors in the Data Integration service
- Support for updating the envelope key of a volume backup in the Block Volume service
 
### Breaking Changes
- The model `BillingAddress` was removed from the OSP Gateway service
- The type of property `BillingAddress` was changed from `BillingAddress` to `Address` in the `Subscription` and `SubscriptionSummary` models in the OSP Gateway service

## 64.2.0 - 2023-06-27
### Added
- Support for calling Oracle Cloud Infrastructure services in the eu-frankfurt-2 region
- Support for the OS Management Hub service
- Support for changing the key store type, and rotating keys, on Exadata Cloud at Customer in the Database service
- Support for launching VM database systems using Ampere A1 shapes in the Database service
- Support for additional currencies and countries on paid listings in the Marketplace service
- Support for ECPU integration in the License Manager service
- Support for freeform and defined tags on resources in the Generic Artifacts service
- Support for SQL endpoints in the Data Flow service
- Support for setting replication delays on channels in the MySQL Database service
- Support for setting how channels handle replicated tables with no primary key in the MySQL Database service
- Support for SQL Plan Management (SPM) in Database Management service

## 64.1.0 - 2023-06-20
### Added
- Support for serial console access in the Database service
- Support for an increased storage size limit of up to 384 TBs in the Database service
- Support for network security group (NSG) support for private database registrations / private endpoints in the Database Migration service
- Support for document classification on documents of more than one page in the Data Labeling service
- Support for importing datasets in the Data Labeling service
- Support for specifying a shape when creating applications in the Functions service
- Support for creating and managing pools in the Data Flow service
- Support for specifying certificate parameters when creating or updating a node in the Roving Edge Infrastructure service
- Support for certificate management in the Roving Edge Infrastructure service
- Support for upgrade bundle management in the Roving Edge Infrastructure service

## 64.0.0 - 2023-06-13
### Added
- Support for the OCI Control Center service
- Support for resource quotas and limits in the Usage service
- Support for allowing users to select the billing interval of deleted ESXi hosts while adding new ESXi hosts in the VMWare Solution service
- Support for custom key/value pairs and custom document classification in the AI Document service
- Support for namespace-prefixed domains in the Object Storage service
- Support for getting the full path to a pre-authenticated request in the Object Storage service
- Support for Java migration analysis, performance tuning recommendations, and JDK LCM customization in the Java Management service
- Support for the TCPS protocol for cloud databases in the Operations Insights service
- Support for AIX hosts that are monitored via Enterprise Manager in the Operations Insights service
 
### Breaking Changes
- The return type of property `Capacity` was changed from `decimal` to `Double` in `DatastoreSummary` model in the VMWare Solution service
 
### Fixed
- Fixed a performance regression issue in `InstancePrincipalsAuthenticationDetailsProvider` present since version `47.0.0`

## 63.1.0 - 2023-06-06
### Added
- Support for calling Oracle Cloud Infrastructure services in the `eu-madrid-2` region
- Support for bulk include/exclude of migration objects in the Database Migration service
- Support for Kafka cluster profiles, including dedicated Kafka broker nodes, in the Big Data service
- Support for MySQL HeatWave Lakehouse in the MySQL Database service
- Support for capacity reports in the Compute service
- Support for Alloy configuration

## 63.0.0 - 2023-05-30
### Added
- Support for policy-based snapshots in the File Storage service
- Support for creating and updating a VM cluster network with disaster recovery network support in the Database service
- Support for setting a management dashboard or saved search to be shared across OCI Observability & Management services in the Management Dashboard service
 
### Breaking Changes
- The property `Port` was deprecated and made optional in the `ScanDetails` model in the Database service

## 62.0.0 - 2023-05-23
### Added
- Support for CRI-O parsing in the Logging service
- Support for retrieving the resource availability domain when getting Exadata infrastructure or VM clusters in the Database service
- Support for specifying database servers when creating dedicated autonomous databases in the Database service
- Support for secondary egress zones in the DNS service
 
### Breaking Changes
- The models `LogIncludedSearch`, `LogIncludedSearchSummaryCollection`, `ListLogIncludedSearchesRequest` and `ListLogIncludedSearchesResponse` were removed in the Logging service
- The property `Keys` was made required in the `UnifiedAgentCsvParser` and `UnifiedAgentTsvParser` models in the Logging service
- The property `Patterns` was made required in the `UnifiedAgentGrokParser` and `UnifiedAgentMultilineGrokParser` models in the Logging service
- The properties `Sources` and `Destination` were made required in the `UnifiedAgentLoggingConfiguration` model in the Logging service
- The property `Format` was made required in the `UnifiedAgentMultilineParser` model in the Logging service
- The property `Expression` was made required in the `UnifiedAgentRegexParser` model in the Logging service
- The property `Paths` was made required in the `UnifiedAgentTailLogSource` model in the Logging service
- The property `Channels` was made required in the `UnifiedAgentWindowsEventSource` model in the Logging service
- The operations `GetLogIncludedSearch` and `ListLogIncludedSearches` were removed from the `LoggingManagementClient` in the Logging service
- The operations `ListLogIncludedSearchesResponseEnumerator` and `ListLogIncludedSearchesRecordEnumerator` were removed from the `LoggingManagementPaginators` in the Logging service
- A new required property `ExternalDownstreams` was added in the `Zone` model in the DNS service

## 61.0.0 - 2023-05-16
### Added
- Support for self-service integration in the Fusion Apps as a Service service  
 
### Breaking Changes
- The models `AttachExistingInstanceDetails`, `CreateNewInstanceDetails`, `CreateOicServiceInstanceDetails`, `CreateServiceInstanceDetails`, `FawAdminInfoDetails` and `CreateOaxServiceInstanceDetails` were removed from the Fusion Apps as a Service service
- The enum `ActionEnum` was removed from the `CreateServiceAttachmentDetails` model in the Fusion Apps as a Service service
- The property `Action` was removed from the `ServiceAttachment` model in the Fusion Apps as a Service service

## 60.1.0 - 2023-05-09
### Added
- Support for the Access Governance service
- Support for creating, updating, listing and downloading one-off patches in the Database service
- Support for changing disaster recovery configurations of remote autonomous databases in the Database service
- Support for scheduling automatic backups in the Database service
- Support for provisioning Software-Defined Data Centers (SDDCs) using standard bare metal shapes, with Block Storage as the datastore, in the VMWare Solution service
- Support for parity with the configuration options of the Compute service in the Compute Autoscaling service

## 60.0.0 - 2023-05-02
### Added
- Support for calling Oracle Cloud Infrastructure services in the `eu-jovanovac-1` region
- Support for bring-your-own-license TLS and ORDS certificates in the Database service
- Support for tags in the Stack Monitoring service
- Support for GPU shapes for model deployments in the Data Science service
- Support for returning networking details of instances in the Visual Builder service
- Support for high-memory VMs in the Compute service
- Support for integrating with the Integration Cloud service in the Process Automation service
- Support for managing on-demand node upgrades in node pools in the Container Engine for Kubernetes service
 
### Breaking Changes
- The model `UpdateVirtualNodeDetails` was removed from the Container Engine for Kubernetes service

## 59.1.0 - 2023-04-25
### Added
- Support for enabling mTLS authentication with Listener and for providing custom value for TLS port and Non-TLS Port during AVM Cluster Creation in Database service
- Support for usedDataStorageSizeInGbs property for autonomous database in the Database service
- Support for csiNumber organization in Tenant Manager Control Plane service
- Support for creating and updating an infrastructure with LACP support in Database service
- Support for changePrivateEndpointOutboundConnection operation in Integration Cloud service
- Support for Enable Process in Integration Cloud service
- Support for Disaster Recovery, DR enablement, switchover, and failover feature in Fusion Apps service
- Support for discovery and monitoring of External Exadata infrastructure in Database Management Service

## 59.0.0 - 2023-04-18
### Added
- Support for private endpoints in the Digital Assistant service
- Support for canceling backups in the Database service
- Support for improved labeling of key/value pairs in the Data Labeling service
 
### Breaking Changes
- The property `OpcRetryToken` was removed from the models `ConfigureDigitalAssistantParametersRequest`, `RotateChannelKeysRequest`, `StartChannelRequest`, `StopChannelRequest` in the Data Labeling service
- The property `LifetimeLogicalClock` was removed from the models `Record`, `Dataset` and `Annotation` in the Data Labeling service
- The property `DigitalAssistantId` was renamed to `Id` in the `ListDigitalAssistantsRequest` model in the Data Labeling service
- The property `IsLatestSkillOnly` was renamed to `IsLatestVersionOnly` in the `ListPackagesRequest` model in the Data Labeling service
- The property `SkillId` was renamed to `Id` in the `ListSkillsRequest` model in the Data Labeling service
- The properties `AuthorizationEndpointUrl` and `SubjectClaim` were made optional in the `AuthenticationProvider` model in the Data Labeling service

## 58.0.0 - 2023-04-11
### Added
- Support for rotation of certificates on autonomous VM clusters on Exadata Cloud at Customer in the Database service
- Support for ACD and OKV wallet naming for autonomous databases and dedicated autonomous databases on Exadata Cloud at Customer in the Database service
- Support for Exadata cloud service application virtual IPs (VIPs) in the Database service
- Support for additional manageability features for large sensitive data models and masking policies in the Data Safe service
- Support for getting user profile details and assignments for databases and fleets in the Data Safe service
- Support for enabling ADDM spotlight for databases in the Operations Insights service
 
### Breaking Changes
- The property `AdditionalDatabaseStatus` was removed from the models `AutonomousDatabase`, `AutonomousDatabaseSummary`, `AutonomousDataWarehouse`and `AutonomousDataWarehouseSummary` in the Database service
- While not to be used directly by customers, there are breaking changes in the internal classes. The type for property `FederationSigner` was changed to `IFederationRequestSigner` in `X509FederationClient` class. The `FederationRequestSigner` class now implements the interface `IFederationRequestSigner` and the `SignRequest` method in the class now accepts two additional required parameters `privateKey` and `keyId`
 
### Fixed
- An issue with cert rotation and concurrent request with the InstancePrincipalsAuthenticationDetailsProvider was fixed.

## 57.0.0 - 2023-04-04
### Added
- Support for pre-emptible worker nodes in the Container Engine for Kubernetes service
- Support for larger data storage (now up to 128TB) in the MySQL Database service
- Support for HTTP health checks for HTTPS backend sets in the Load Balancer service
 
### Breaking Changes
- The property `BackendSetName` was made required in the `ForwardToBackendSet` model in the Load Balancer service

## 56.1.0 - 2023-03-28
### Added
- Support for ACD and OKV wallet naming for autonomous databases and dedicated autonomous databases on Exadata Cloud at Customer in the Database service
- Support for validating the credentials of a connection in the DevOps service
- Support for GoldenGate Replicat performance profiles when creating a migration in the Database Migration service
- Support for connection diagnostics on registered databases in the Database Migration service
- Support for launching bare metal instances in an RDMA network in the Compute service
 
### Fixed
- Fixed an issue which prevented SessionTokenAuthenticationDetailsProvider to work with non-OC1 Regions

## 56.0.0 - 2023-03-21
### Added
- Support for backup automation integration with the Database Recovery service in the Database service
- Support for changing the disaster recovery configuration of an autonomous database in remote regions of its disaster recovery association in the Database service
- Support for creating a remote disaster recovery association clone of an autonomous database in the Database service
- Support for managed build stages to be configured to use custom shape build runners in the DevOps service
- Support for listing pre-built functions and creating functions from pre-built functions in the Functions service
- Support for connections types for database resources of type Amazon S3, HDFS, SQL Server, Java Messaging service, Mongo DB, Oracle NoSQL, and Snowflake in the GoldenGate service

### Breaking Changes
- The enum value `LAKE_HOUSE_CONNECTION` was renamed to `LAKE_CONNECTION` in the enum ModelTypeEnum in the Connection, ConnectionDetails, ConnectionSummary, CreateConnectionDetails and UpdateConnectionDetails models in the Data Integration Service
- The enum value `LAKE_HOUSE_DATA_ASSET` was renamed to `LAKE_DATA_ASSET` in the enum ModelTypeEnum in the DataAsset, CreateDataAssetDetails, DataAssetSummary, and UpdateDataAssetDetails models in the Data Integration Service

## 55.0.0 - 2023-03-14
### Added
- Support for the Identity Domains service
- Support for long-term backups for autonomous databases on Exadata Cloud at Customer in the Database service
- Support for database OS patching in the Database service
- Support for managing enhanced clusters, cluster add-ons, and serverless virtual node pools in the Container Engine for Kubernetes service
- Support for templates and copy object requests in the Data Integration service
- Support for maintenance features in the GoldenGate service
- Support for `AMD_MILAN_BM_GPU` configuration type on instances in the Compute service
- Support for host storage metrics and network metrics as part of host capacity planning in the Operations Insights service
 
### Breaking Changes
- Support for the Data Connectivity Management service was removed
- The `TemplateSummary` response model in the Data Integration service would contain `UnknownEnumValue` enum with value `null` for `LifecycleState` if the Service returns a `LifecycleState` enum value not present in the version of the SDK being used

## 54.0.0 - 2023-03-07
### Added
- Support for creating and updating autonomous database long-term backup schedules in the Database service
- Support for creating, updating, and deleting autonomous database long-term backups in the Database service
- Support for model deployment resources to use customized container images containing runtime dependencies of ML models and custom web servers to handle inference requests in the Data Science service
- Support for using the compartmentIdInSubtree parameter when summarizing management agent counts in the Management Agent Cloud service
- Support for getting agent property details in the Management Agent Cloud service
- Support for filtering by gateway ID when listing agents in the Management Agent Cloud service
- Support for the Hebrew and Greek languages during AI language text translation in the AI Language service
- Support for auto-detection when analyzing text with pre-trained models in the AI Language service
- Support for specifying update operation constraints when updating an instance in the Compute Service
- Support for disaster recovery in the Content Management service
- Support for advanced autonomous databases insights in the Operations Insights service
 
### Breaking Changes
- The OCI Dotnet SDK now returns a successful response for `304/NotModified` status code instead of raising an OCIException for it.
- The enum member `ACTIVE` was removed from the enum `LifecycleDetails` in the `LifecycleDetails` model in the Content Management service

## 53.1.0 - 2023-02-28
### Added
- Support for calling Oracle Cloud Infrastructure services in the eu-dcc-rating-1, eu-dcc-rating-2, eu-dcc-dublin-1, eu-dcc-dublin-2, and eu-dcc-milan-2 regions
- Support for on-demand bootstrap script execution in the Big Data Service

## 53.0.0 - 2023-02-21
### Added
- Support for async jobs in the AI Anomaly Detection service
- Support for specifying algorithm hints and windows sizes during model training in the AI Anomaly Detection service
- Support for specifying a sensitivity value during model detection in the AI Anomaly Detection service
- Support for discovery and monitoring of external Oracle database infrastructure components in the Database Management service
 
### Breaking Changes
- The type for property `SystemTags` was changed from a dictionary of string to another dictionary to a dictionary of a string to object for `ProjectSummary`, `Project`, `ModelSummary`, `Model`, `DataAssetSummary`, `DataAsset`, `AiPrivateEndpointSummary`, `AiPrivateEndpoint` models in the AI Anomaly Detection service

## 52.1.0 - 2023-02-14
### Added
- Support for the Visual Builder Studio service
- Support for the Autonomous Recovery service
- Support for retries by default on operations of the Compute service
- Support for selecting specific database servers when creating autonomous VM clusters in the Database service
- Support for creating autonomous VMs during the creation of autonomous VM clusters in the Database service

## 52.0.0 - 2023-02-07
### Added
- Support for changing Data Guard role of a database instance within the Database service
- Support for listing autonomous container database versions in the Database service
- Support for specifying a database version when creating or updating an autonomous container database in the Database service
- Support for specifying an eCPU count when creating or updating autonomous shared databases in the Database service
- Support for Helm attestation and Helm arguments on deploy operations in the DevOps service
- Support for uploading master key wallets for deployments in the GoldenGate service
- Support for custom configurations in the Operations Insights service
- Support for refreshing the session token in SessionTokenAuthenticationDetailsProvider
 
### Breaking Changes
- The property `CpuCoreCount` was made optional in `AutonomousDatabase` and `AutonomousDatabaseSummary` model in the Database service

## 51.3.0 - 2023-01-31
### Added
- Support for ECPU billing for autonomous databases and dedicated autonomous databases on Exadata Cloud at Customer in the Database service
- Support for providing a vault secret ID when creating or updating autonomous shared databases in the Database service
- Support for including ORDS and database transform URLs as autonomous database connections in the Database service
- Support for role-based access control on OpenSearch clusters in the Search service
- Support for managed shell stages on deployments in the DevOps service
- Support for memory encryption on confidential VMs in the Compute service
- Support for configuration items, and reporting ownership of configuration items, in the Application Performance Monitoring service

## 51.2.0 - 2023-01-24
### Added
- Support for the Cloud Migrations service
- Support for setting up custom private IPs while creating private endpoints in the Database service
- Support for machine learning pipelines in the Data Science service
- Support for personally identifiable information detection in the AI Language service

## 51.1.0 - 2023-01-17
### Added
- Support for calling Oracle Cloud Infrastructure services in the us-chicago-1 region
- Support for cross-region replication in the File Storage service
- Support for setting up private DNS on ExaCS systems during provisioning in the Database service
- Support for elastic storage expansion on infrastructure resources for Exadata Cloud at Customer in the Database service
- Support for target versions during infrastructure patching on Cloud Exadata infrastructure in the Database service
- Support for creating model version sets in the model catalog in the Data Science service
- Support for associating a model with a model version set in the Data Science service
- Support for custom key/value annotations on documents in the Data Labeling service
- Support for configurable timeouts in the Service Mesh service

## 51.0.0 - 2022-12-13
### Added
- Support for the Queue service
- Support for Intel X9 shapes when launching VM database systems in the Database service
- Support for enabling, disabling, and editing Database Management service connections on pluggable databases in the Database service
- Support for availability configurations and maintenance window schedules on synthetic monitors in the Application Performance Monitoring service
- Support for scheduling cascading deletes on a project in the DevOps service
- Support for cancelling a scheduled cascading delete on a project in the DevOps service
- Support for issue and action fields on job phases of validation and migration processes in the Database Migration service
- Support for cluster profiles in the Big Data service
- Support for egress-only services in the Service Mesh service
- Support for optional listeners and service discovery metadata on virtual deployments in the Service Mesh service
- Support for canceling work requests in the accepted state in the Service Mesh service
- Support for filtering work requests on associated resource id and operation status in the Service Mesh service
- Support for sorting while listing work requests, listing work request logs, and listing work request errors in the Service Mesh service
- Support for Oracle Managed Access integration in the Fusion Apps as a Service service
- Support for refresh scheduling in the Fusion Apps as a Service service
- Support for additional connections types on database resources in the GoldenGate service
 
### Breaking Changes
- The type for property `RouteRules` was changed from a List of `VirtualServiceTrafficRouteRule` to a List of `VirtualServiceTrafficRouteRuleDetails` in the models `UpdateVirtualServiceRouteTableDetails` and `CreateVirtualServiceRouteTableDetails` in the Service Mesh service
- The type for property `Mtls` was changed from `CreateMutualTransportLayerSecurityDetails` to `VirtualServiceMutualTransportLayerSecurityDetails` in the models `UpdateVirtualServiceDetails` and `CreateVirtualServiceDetails` in the Service Mesh service
- The type for property `RouteRules` was changed from a List of `IngressGatewayTrafficRouteRule` to a List of `IngressGatewayTrafficRouteRuleDetails` in the models `UpdateIngressGatewayRouteTableDetails` and `CreateIngressGatewayRouteTableDetails` in the Service Mesh service
- The type for property `Mtls` was changed from `CreateIngressGatewayMutualTransportLayerSecurityDetails` to `IngressGatewayMutualTransportLayerSecurityDetails` in the models `UpdateIngressGatewayDetails` and `CreateIngressGatewayDetails` in the Service Mesh service
- The type for property `Rules` was changed from a List of `AccessPolicyRule` to a List of `AccessPolicyRuleDetails` in the models `UpdateAccessPolicyDetails` and `CreateAccessPolicyDetails` in the Service Mesh service

## 50.0.0 - 2022-12-06
### Added
- Support for the Container Instances service
- Support for the Document Understanding service
- Support for creating stacks from OCI DevOps service and Bitbucket Cloud/Server as source control management in the Resource Manager service
- Support for deployment stage level parameters in the DevOps service
- Support for PeopleSoft discovery in the Stack Monitoring service
- Support for Apache Tomcat discovery in the Stack Monitoring service
- Support for SQL Server discovery in the Stack Monitoring service
- Support for OpenId Connect in the API Gateway service
- Support for returning compartment ids when listing backups in the MySQL Database service
- Support for adding a load balancer endpoint to a DB system in the MySQL Database service
- Support for managed read replicas in the MySQL Database service
- Support for setting replication filters on channels in the MySQL Database service
- Support for replicating from a source configured without global transaction identifiers into a channel in the MySQL Database service
- Support for time zone and language preferences in the Announcements service
- Support for adding report schedules for activity auditing and alerts reports in the Data Safe service
- Support for bulk operations on alerts in the Data Safe service
- Support for Java server usage reporting in the Java Management service
- Support for Java library usage reporting in the Java Management service
- Support for cryptographic roadmap impact analysis in the Java Management service
- Support for Java Flight Recorder recordings in the Java Management service
- Support for post-installation steps in the Java Management service
- Support for restricting management of advanced functionality in the Java Management service
- Support for plugin improvements in the Java Management service
- Support for collecting diagnostics on deployments in the GoldenGate service
- Support for onboarding Exadata Public Cloud (ExaCS) targets to the Operations Insights service
  
### Breaking Changes
- A required property `CompartmentId` was added to `PatchAlertsDetails` model in the Data Safe service
- The properties `ListenerPort` and `ServiceName` were made required in `InstalledDatabaseDetails` model in the Data Safe service
- The property `AutonomousDatabaseId` was made required in `AutonomousDatabaseDetails` model in the Data Safe service

## 49.1.0 - 2022-11-15

### Added
- Support for mTLS authentication with listeners during Autonomous VM Cluster creation on Exadata Cloud at Customer in the Database service
- Support for providing custom values for TLS and non-TLS ports during Autonomous VM Cluster creation on Exadata Cloud at Customer in the Database service
- Support for creating multiple Autonomous VM Clusters in the same Exadata infrastructure in the Database service
- Support for listing resources associated with a job in the Resource Manager service
- Support for listing resources associated with a stack in the Resource Manager service
- Support for listing outputs associated with a job in the Resource Manager service
- Support for the Oracle distribution of Apache Hadoop 2.0 in the Big Data service

## 49.0.0 - 2022-11-08
### Added
- Support for listing local and cross-region refreshable clones in the Database service
- Support for adding multiple cloud VM clusters in the Database service
- Support for creating rollback jobs in the Resource Manager service
- Support for edge nodes in the Big Data service
- Support for Single Client Access Name (SCAN) in the Data Flow service
- Support for additional filters when listing application dependencies in the Application Dependency Management service
- Support for additional properties when reading Vulnerability Audit resources in the Application Dependency Management service
- Support for optionally passing compartment IDs when creating Vulnerability Audit resources in the Application Dependency Management service
 
### Breaking Changes
- The property `CertificateId` was made required in `PrivateServerConfigDetails` model in the Resource Manager service

## 48.0.0 - 2022-11-01
### Added
- Support for cloning from a backup from the last available timestamp in the Database service
- Support for third-party scanning using Qualys in the Vulnerability Scanning service
- Support for customer-provided encryption keys in the Logging Analytics service
- Support for connections for database resources in the GoldenGate service
  
### Breaking Changes
- The enum `VendorEnum` was removed from the HostScanAgentConfiguration model in the Vulnerability Scanning service

## 47.0.0 - 2022-10-24
### Added
- Support for the Disaster Recovery service
- Support for running code interactively with session applications using statements in the Data Flow service
- Support for language custom models and language translation in the AI Language service
 
### Breaking Changes
- The type of property `Documents` was changed from a List of `TextClassificationDocument` to a List of `TextDocument` in `BatchDetectLanguageTextClassificationDetails` model in the AI Language service
- The type of property `Documents` was changed from a List of `SentimentsDocument` to a List of `TextDocument` in `BatchDetectLanguageSentimentsDetails` model in the AI Language service
- The type of property `Documents` was changed from a List of `KeyPhraseDocument` to a List of `TextDocument` in `BatchDetectLanguageKeyPhrasesDetails` model in the AI Language service
- The type of property `Documents` was changed from a List of `EntityDocument` to a List of `TextDocument` in `BatchDetectLanguageEntitiesDetails` model in the AI Language service
 
### Fixed
- Fixed a race condition in DefaultRequestSigner, due to BlockUpdate in BouncyCastle not being thread safe, when a single client was used to make multiple API calls asynchronously

## 46.0.0 - 2022-10-04
### Added
- Support for calling Oracle Cloud Infrastructure services in the `eu-dcc-milan-1` region
- Support for target host identification and SOCKS support on dynamic port forwarding sessions in the Bastion service
- Support for viewing top processes running at a particular point of time in the Operations Insights service
- Support for filtering top processes by a single process to view that process's trend over time in the Operations Insights service
- Support for creating Enterprise Manager-based Windows host targets in the Operations Insights service
- Support for creating Management Agent Cloud-based Windows and Solaris host targets in the Operations Insights service

### Breaking Changes
- The property `TargetResourcePort` was removed from the models `TargetResourceDetails` and `CreateSessionTargetResourceDetails` in the Bastion service

## 45.1.0 - 2022-09-27
### Added
- Support for search capabilities for monitored resources in the Stack Monitoring service
- Support for deleting monitored resources with their members in the Stack Monitoring service
- Support for creating host-type monitored resources in the Stack Monitoring service
- Support for associating external resources during creation of monitored resources in the Stack Monitoring service
- Support for uploading bulk data in the NoSQL Database Cloud service
- Support for examining query execution plans in the NoSQL Database Cloud service
- Support for starting and stopping clusters in the Big Data service
- Support for additional compute shapes in the Big Data service
- Support for backwards pagination in the Search service
- Support for elastic compute for Exadata Cloud at Customer in the Database service

## 45.0.0 - 2022-09-20
### Added
- Support for the Cloud Bridge service
- Support for the Cloud Migrations service
- Support for display banners, trails, and sizes in the GoldenGate service
- Support for generic REST data assets, flattening of data in Data Flow, and runtime information on pipelines in the Data Integration service
- Support for expanded search functionality in the Threat Intelligence service
- Support for ingest-time rules and specifying logsets and query strings during recalls in the Logging Analytics service
- Support for repository mirroring from Visual Builder Studio in the DevOps service
- Support for running a managed build stage with the source code hosted in a Visual Builder Studio repository in the DevOps service
- Support for triggering a build run based on an event in a Visual Builder Studio repository in the DevOps service
- Support for additional parameters during cost management scheduling in the Usage service
 
### Breaking Changes
- The properties `FlattenProjectionPreferences`, `FlattenAttributeRoot`, `FlattenAttributePath`, `FlattenColumns` were made optional in `FlattenDetails` model in the Data Integration service
- Required properties `Attributes`, `TimeLastSeen` and `Geodata` were added to IndicatorSummary model in the Threat Intelligence service
- The property `QueryProperties` was made optional in `CreateScheduleDetails` and `Schedule` models in the Usage service
- The property `PreviousDeploymentId` was made a required parameter in the `CreateDeployPipelineRedeploymentDetails` model in the DevOps service
- The property `DeployStageId` was made a required parameter in `CreateSingleDeployStageDeploymentDetails` and `CreateSingleDeployStageRedeploymentDetails` model in the DevOps service

## 44.1.0 - 2022-09-13
### Added
- Support for calling Oracle Cloud Infrastructure services in the eu-madrid-1 region
- Support for exporting and importing larger model artifacts in the model catalog in the Data Science service
- Support for Request Based Authorization in the API Gateway service
- Support for Dynamic Authentication in the API Gateway service
- Support for Dynamic Routing Backend in the API Gateway service

## 44.0.0 - 2022-09-06
### Added
- Support for generic REST, OCI Streaming service, and Lake House connectors in the Data Connectivity Management service
- Support for connecting to the Data Catalog service in the Data Connectivity Management service
- Support for Kerberos and SSL for HDFS operations in the Data Connectivity Management service
- Support for excel-formatted data and default columns in the Data Connectivity Management service
- Support for reporting connector usage in the Data Connectivity Management service
- Support for preferred credentials for performing privileged operations in the Database Management service
- Support for passing a content encoding when posting metrics in the Monitoring service
- Support for Session Token authentication
 
### Breaking Changes
- The operations `DeleteConnectionValidation` and `ListConnectionValidations` were removed from `DataConnectivityManagementClient` in the Data Connectivity Management service
- The operation `ListConnectionValidationsResponseEnumerator` was removed from `DataConnectivityManagementPaginators` in the Data Connectivity Management service
- The models `ListConnectionValidationsResponse`, `ListConnectionValidationsRequest` and `DeleteConnectionValidationRequest` were removed in the Data Connectivity Management service
- The return type of property `LifecycleState` was changed to `LifecycleStateEnum` from `Registry.LifecycleStateEnum` in `ListRegistriesRequest` model in the Data Connectivity Management service

### Fixed
- Reverted the fix introduced in version `43.1.0` for removing the race condition in `DefaultRequestSigner` as it introduced an issue in Instance Principals Authentication using Delegation Token

## 43.1.0 - 2022-08-30
### Added    
- Support for opting out of guest VM event collection, health metrics, diagnostics logs, and traces in the Database service
- Support for in-place upgrades for software-defined data centers in the VMWare Solution service
- Support for single-client access name protocol as a data source for private access channels in the Analytics Cloud service
- Support for network security groups, egress control on public datasources, and GitHub access in the Analytics Cloud service
- Support for performance-based autotuning of block and boot volumes in the Block Storage service

### Fixed
- Fixed a race condition in `DefaultRequestSigner`, due to `BlockUpdate` in BouncyCastle not being thread safe, when a single client was used to make multiple API calls asynchronously

## 43.0.0 - 2022-08-23
### Added
- Support for the Enterprise Manager Warehouse service
- Support for additional configuration variables in the MySQL Database service
- Support for file filters in the DevOps service
- Support for support rewards redemption summaries in the Usage service
- Support for the parent tenancy of an organization to view child tenancy categories, recommendations, and resource actions in the Optimizer service
- Support for choosing prior versions during infrastructure maintenance on Exadata Cloud at Customer in the Database service

### Breaking Changes
- `EmDataLakeClient` was renamed to `EmWarehouseClient` in the Enterprise Manager Warehouse service
- `EmDataLakePaginators` was renamed to `EmWarehousePaginators` in the Enterprise Manager Warehouse service
- `EmDataLakeWaiters` was renamed to `EmWarehouseWaiters` in the Enterprise Manager Warehouse service

## 42.1.0 - 2022-08-16
### Added
- Support for Logging Analytics as a streaming source target in the Service Connector Hub service
- Support for data sources for logging query registration in the Cloud Guard service
- Support for custom detector rules on insight detector recipes in the Cloud Guard service
- Support for fetching data source events and problem entities in the Cloud Guard service
- Support for E3, E4, Standard3, and Optimized3 flexible compute shapes on notebooks, model deployment, and jobs in the Data Science service
- Support for streaming application logs to the Logging service in the Data Flow service

## 42.0.0 - 2022-08-09
### Added
- Support for single-host software-defined data centers in the VMWare Solution service
- Support for Java download and installation in the Java Management service
- Support for lifecycle management for Windows in the Java Management service
- Support for installation scripts in the Java Management service
- Support for unlimited-installation keys in the Java Management service
- Support for configuring automatic usage tracking in the Java Management service
- Support for STANDARDX and ENTERPRISEX instance types in Integration service
- Support for additional languages and multimedia formats in transcription jobs in the AI Speech service
- Support for maintenance run history for Exadata Cloud at Customer in the Database service
- Support for Optimizer statistics monitoring and management on various database administration operations in the Database Management service
- Support for OCI Compute instances in the Operations Insights service
- Support for moving resources in the Console Dashboard service
- Support for round-robin alerting in the Application Performance Monitoring service
- Support for aggregated network data of synthetic monitors in the Application Performance Monitoring service
- Support for etags on operations in the Load Balancing service
 
### Breaking Changes
- The enum `UsageUnit` was replaced by `UsageUnitEnum` in the Operations Insights service

## 41.1.0 - 2022-08-02
### Added
- Support for OpenSearch in the Search service
- Support for child tables in the NoSQL Database Cloud service
- Support for private repositories in the DevOps service

## 41.0.0 - 2022-07-27
### Added
- Support for the Fusion Apps as a Service service
- Support for the Digital Media service
- Support for accessing all Terraform providers from Hashicorp Registry, as well as bringing your own providers, in the Resource Manager service
- Support for runtime configurations in notebook sessions in the Data Science service
- Support for compartmentIdInSubtree and accessLevel filters when listing management agents in the Management Agent Cloud service
- Support for filtering by type when listing work requests in the Management Agent Cloud service
- Support for filtering by agent id when listing management agent plugins in the Management Agent Cloud service
- Support for specifying size preference when requesting a data transfer appliance in the Data Transfer service
- Support for encryption of boot and block volumes associated with a cluster using customer-specified KMS keys in the Big Data service
- Support for the VM.Standard.E4.Flex shape for Cloud SQL (CSQL) nodes in the Big Data service
- Support for listing block and boot volumes, as well as block and boot volume replicas, within a volume group in the Block Volume service
- Support for dedicated autonomous databases in the Operator Access Control service
- Support for viewing automatic workload repository (AWR) data for databases added to AWRHub in the Operations Insights service
- Support for ports, protocols, roles, and SSL secrets when enabling or modifying database management in the Database service
- Support for monthly security maintenance runs in the Database service
- Support for monthly infrastructure patching for Exadata Cloud at Customer resources in the Database service
 
### Breaking Changes
- `DataMaskingActivityClient`,`FusionEnvironmentClient`, `FusionEnvironmentFamilyClient`, `RefreshActivityClient`,`ScheduledActivityClient`, and `ServiceAttachmentClient` clients were merged into a single client `FusionApplicationsClient` for the Fusion Apps as a Service service
- `DataMaskingActivityPaginators`, `FusionEnvironmentPaginators`,`FusionEnvironmentFamilyPaginators`,`RefreshActivityPaginators`,`ScheduledActivityPaginators`, and `ServiceAttachmentPaginators` paginators were merged into a single paginator `FusionApplicationsPaginators` for the Fusion Apps as a Service service
- `DataMaskingActivityWaiters`, `FusionEnvironmentWaiters`,`FusionEnvironmentFamilyWaiters`,`RefreshActivityWaiters`,`ScheduledActivityWaiters`, and `ServiceAttachmentWaiters` waiters were merged into a single waiter `FusionApplicationsWaiters` for the Fusion Apps as a Service service

## 40.1.0 - 2022-07-19
### Added
- Support for calling Oracle Cloud Infrastructure services in the `mx-queretaro-1` region
- Support for the Process Automation service
- Support for the Managed Access service
- Support for extending maintenance reboot due dates on virtual machines in the Compute service
- Support for ingress routing tables on NAT gateways and internet gateways in the Networking service
- Support for container database and pluggable database discovery in the Stack Monitoring service
- Support for displaying rack serial numbers for Exadata infrastructure resources in the Database service
- Support for grace periods for wallet rotation on autonomous databases in the Database service
- Support for hosting models on flexible compute shapes with customizable OCPUs and memory in the Data Science service

## 40.0.0 - 2022-07-12
### Added
- Support for DBCS databases in the Operations Insights service
- Support for point-in-time recovery for non-highly-available database systems in the MySQL Database service
- Support for triggering reboot migration on instances with pending maintenance in the Compute service
- Support for native pod networking in the Container Engine for Kubernetes service
- Support for creating Data Guard associations with new database systems in the Database service
 
### Breaking Changes
- The data type of the property `HostType` was changed from a List of `string` to a List of `HostTypeEnum` in ListHostInsightsRequest in the Operations Insights service
- The property `PreserveDataVolumes` was removed from the TerminateInstanceRequest in the Compute service

## 39.3.0 - 2022-07-05
### Added
- Support for backup policies returned as part of the database system list operation in the MySQL Database service
 
### Changed
- Instead of throwing an exception when the API returns an Unknown enum, the OCI Dotnet SDK will now return a UKNOWN_ENUM_VALUE (null) instead to support Forward Enum Compatibility

## 39.2.0 - 2022-06-27
### Added
- Support for the Network Monitoring service
- Support for specifying application scan settings when creating or updating host scan recipes in the Vulnerability Scanning service
- Support for moving data into an autonomous data warehouse in the Operations Insights service
- Support for shared infrastructure autonomous database character sets in the Database service
- Support for data collection logging events on Exadata instances in the Database service
- Support for specifying boot volume VPUs when launching instances from images in the Compute service
- Support for safe-deleting nodes in the Container Engine for Kubernetes service

## 39.1.0 - 2022-06-21
### Added
- Support for the Network Firewall service
- Support for smaller and larger HeatWave cluster nodes in the MySQL Database service
- Support for CSV file type datasets for text labeling and JSONL in the Data Labeling service
- Support for diagnostics in the Database Management service

## 39.0.0 - 2022-06-14
### Added
- Support for the Web Application Acceleration (WAA) service
- Support for the Governance Rules service
- Support for the OneSubscription service
- Support for resource locking in the Identity service
- Support for quota resource locking in the Limits service
- Support for returning the backup with the requested changes in the MySQL Database service
- Support for time zone in Cloud Autonomous VM (CAVM) clusters in the Database service
- Support for configuration options in the Application Performance Monitoring service
- Support for MySQL connections in the Database Tools service
 
### Breaking Changes
- The models `DatabaseToolsAllowedNetworkSources`, `DatabaseToolsVirtualSource`, and `ServiceCapability` were removed from the Database Tools service
- The property `SecretId` was made a required property in the `DatabaseToolsUserPasswordSecretIdDetails` model in the Database Tools service

## 38.4.0 - 2022-06-07
### Added
- Support for calling Oracle Cloud Infrastructure services in the eu-paris-1 region
- Support for private endpoints in Resource Manager service
- Support downloading generated Terraform plan output in JSON or binary format in Resource Manager service
- Support for querying OPSI Data Objects in the Operations Insights service

### Changed
- Network security groups (NSGs) are now optional for autonomous databases on private endpoints in the Database service

## 38.3.0 - 2022-05-31
### Added
- Support for in-depth monitoring, diagnostics capabilities, and advanced management functionality for on-premise Oracle databases in the Database Management service
- Support for using Oracle Cloud Agent to perform iSCSI login and logout for non-multipath-enabled iSCSI attachments in the Container Engine for Kubernetes service
- Support for Fault Domain placement in the Container Engine for Kubernetes service
- Support for worker node images in the Container Engine for Kubernetes service
- Support for flexible shapes using the driverShapeConfig and executorShapeConfig properties in the Data Flow service

## 38.2.0 - 2022-05-24
### Added
- Support for the License Manager service
- Support for usage plans in the API Gateway service
- Support for packaged skill and instance metadata management, role-based access options on instance creation, and assigned ownership in the Digital Assistant service
- Support for compute capacity reservations in the VMWare Solution service
- Support for Oracle Linux 8 application streams in the OS Management service
 
### Fixed
- Service Error message was fixed to log correct Service name

## 38.1.0 - 2022-05-17
### Added
- Support for information requests in the Operator Access Control service
- Support for Helm charts and repositories on deployments in the DevOps service
- Support for Application Dependency Management service scan results on builds in the DevOps service
- Support for build resources to use Bitbucket Cloud repositories for source code in the DevOps service
- Support for character set selection on autonomous dedicated databases in the Database service
- Support for listing autonomous dedicated database supported character sets in the Database service
- Support for AMD E4 flex shapes on virtual machine database systems in the Database service
- Support for terraform and improvements for cross-region ADGs in the Database service

### Changed
- Improved error message for service error, auth provider error, upload manager and other miscellaneous error

## 38.0.0 - 2022-05-10
### Added
- Support for getting usage information for autonomous databases and Cloud at Customer autonomous databases in the Database service
- Support for the "standby" lifecycle state on autonomous databases in the Database service
- Support for BIP connections and dataflow operators in the Data Integration service
 
### Breaking Changes
- The data type of property `DefaultConnection` was changed from `ConnectionSummaryFromBICC` to `ConnectionSummary` in the DataAssetSummaryFromFusionApp model in the Data Integration service
- The data type of property `DefaultConnection` was changed from `ConnectionFromBICCDetails` to `ConnectionDetails` in the DataAssetFromFusionApp model in the Data Integration service
- The data type of property `DefaultConnection` was changed from `CreateConnectionFromBICC` to `CreateConnectionDetails` in the CreateDataAssetFromFusionApp model in the Data Integration service

## 37.1.0 - 2022-05-03
### Added
- Support for the Application Dependency Management service
- Support for platform configuration options on some bare metal shapes in the Compute service
- Support for shielded instances for BM.Standard.E4.128 and BM.Standard3.64 shapes in the Compute service
- Support for E4 dense VMs on launch and update instance operations in the Compute service
- Support for reboot migration on DenseIO shapes in the Compute service
- Support for an increased database name maximum length, from 14 to 30 characters, in the Database service
- Support for provisioned concurrency in the Functions service

## 37.0.0 - 2022-04-26
### Added
- Support for the Service Mesh service
- Support for security zones in the Cloud Guard service
- Support for virtual test access points (VTAPs) in the Networking service
- Support for monitoring as a source in the Service Connector Hub service
- Support for creating budgets that target subscriptions and child tenancies in the Budgets service
- Support for listing shapes and specifying a shape during creation of a node in the Roving Edge Infrastructure service
- Support for bringing your own key in the Roving Edge Infrastructure service
- Support for enabling inspection of HTTP request bodies in the Web Application Acceleration and Security
- Support for cost management schedules in the Usage service
- Support for TCPS on external containers as well as non-container and pluggable databases in the Database service
- Support for autoscaling on Open Data Hub (ODH) clusters in the Big Data service
- Support for creating Open Data Hub (ODH) 0.9 clusters in the Big Data service
- Support for Open Data Hub (ODH) patch management in the Big Data service
- Support for customizable Kerberos realm names in the Big Data service
- Support for dedicated vantage points in the Application Performance Monitoring service
- Support for reactivating child tenancies in the Organizations service
- Support for punctuation and the SRT transcription format in the AI Speech service

### Breaking Changes
- The deprecated property `RiskScore` was removed from Sighting model in in the Cloud Guard service.
- The property `SubscriptionId` was made a required parameter for `ListSubscriptionMappingsRequest` in the Tenant Manager Control Plane service

## 36.0.0 - 2022-04-19
### Added
- Support for the Stack Monitoring service
- Support for stack monitoring on external databases in the Database service
- Support for upgrading VM database systems in place in the Database service
- Support for viewing supported VMWare software versions when listing host shapes in the VMWare Solution service
- Support for choosing compute shapes when creating SDDCs and ESXi hosts in the VMWare Solution service
- Support for work requests on delete operations in the Vulnerability Scanning service
- Support for additional scan metadata in reports, including CVE descriptions, in the Vulnerability Scanning service
- Support for redemption codes in the Usage service
- Support for Resource Principals Authentication Provider v2.2
 
### Breaking Changes
- The property `Etag` was removed from ListRedeemableUsersResponse model in the Usage service

## 35.1.0 - 2022-04-12
### Added
- Support for bringing your own IPv6 addresses in the Networking service
- Support for specifying database edition and maximum CPU core count when creating or updating an autonomous database in the Database service
- Support for enabling and disabling data collection options when creating or updating Exadata Cloud at Customer VM clusters in the Database service

## 35.0.0 - 2022-04-05
### Added
- Support for content length and content type response headers when downloading PDFs in the Account Management service
- Support for creating Enterprise Manager-based zLinux host targets, creating alarms, and viewing top process analytics in the Operations Insights service
- Support for diagnostic reboots on VM instances in the Compute service

### Breaking Changes
- The return type of property LifecycleState was changed from `LifecycleState` to `TargetDatabaseLifecycleState` for TargetDatabase and TargetDatabaseSummary model in the Data Safe service

## 34.2.0 - 2022-03-29
### Added
- Support for returning the number of network ports as part of listing shapes in the Compute service
- Support for Java runtime removal and custom logs in the Java Management service
- Support for new parameters for BGP admin state and enabling/disabling BFD in the Networking service
- Support for private OKE clusters and blue-green deployments in the DevOps service
- Support for international customers to consume and launch third-party paid listings in the Marketplace service
- Support for additional fields on entities, attributes, and folders in the Data Catalog service

## 34.1.0 - 2022-03-22
### Added
- Support for getting the storage utilization of a deployment on deployment list and get operations in the GoldenGate service
- Support for virtual machines, bare metal machines, and Exadata databases with private endpoints in the Operations Insights service
- Support for setting deletion policies on database systems in the MySQL Database service

## 34.0.0 - 2022-03-15
### Added
- Support for Ubuntu platforms and unlimited installation keys in the Management Agent Cloud service
- Support for shielded instances in the VMWare Solution service
- Support for application resources in the Data Integration service
- Support for multi-AVM on Exadata Cloud at Customer infrastructure in the Database service
- Support for heterogeneous (VM and AVM) clusters on Exadata Cloud at Customer infrastructure in the Database service
- Support for custom maintenance schedules for AVM clusters on Exadata Cloud at Customer infrastructure in the Database service
- Support for listing vulnerabilities, vulnerability-impacted containers, and vulnerability-impacted hosts in the Vulnerability Scanning service
- Support for specifying an image count when creating or updating container scan recipes in the Vulnerability Scanning service

### Changed
- Portable.BouncyCastle version was upgraded to `1.9.0`

### Breaking Changes
- The type of property `LifecycleState` was changed from `Workspace.LifecycleStateEnum` to `LifecycleStateEnum` for the WorkspaceSummary model in the Data Integration service

## 33.0.0 - 2022-03-08
### Added
- Support for the Sales Accelerator license option in the Content Management service
- Support for VCN hostname cluster endpoints in the Container Engine for Kubernetes service
- Support for optionally specifying an admin username and password when creating a database system during a restore operation in the MySQL Database service
- Support for automatic tablespace creation on non-autonomous and autonomous database dedicated targets in the Database Migration service
- Support for reporting excluded objects based on static exclusion rules and dynamic exclusion settings in the Database Migration service
- Support for removing, listing, and adding database objects reported by the Cloud Premigration Advisor Tool (CPAT) in the Database Migration service
- Support for migrating Oracle databases from the AWS RDS service to OCI as autonomous databases, using the AWS S3 service and DBLINK for data transfer, in the Database Migration service
- Support for querying additional fields of a resource using return clauses in the Search service
- Support for clusters and station clusters in the Roving Edge Infrastructure service
- Support for creating database systems and database homes using customer-managed keys in the Database service
 
### Breaking Changes
- The type of Property LifecycleState was changed from `LifecycleStateEnum` to `LifecycleState` in the ListOceInstancesRequest model in Content Management service
- The type of the parameter targetStates was changed from `OceInstance.LifecycleStateEnum[]` to `LifecycleState[]` in OceInstanceWaiters call for ForOceInstance in Content Management service
- The property `LifecycleState` was replaced by `LifecycleDetails` in the OceInstanceSummary and OceInstance model in Content Management service

## 32.2.0 - 2022-03-01
### Added
- Support for DRG route distribution statements to be specified with a new match type 'MATCH_ALL' for matching criteria in the Networking service
- Support for VCN route types on DRG attachments for deciding whether to import VCN CIDRs or subnet CIDRs into route rules in the Networking service
- Support for CPS offline reports in the Database service
- Support for infrastructure patching v2 features in the Database service
- Support for auto-scaling the storage of an autonomous database, as well as shrinking an autonomous database, in the Database service
- Support for managed egress via a default networking option on jobs and notebooks in the Data Science service
- Support for more types of saved search enums in the Management Dashboard service

## 32.1.0 - 2022-02-22
### Added

- Support for the Data Connectivity Management service
- Support for the AI Speech service
- Support for disabling crash recovery in the MySQL Database service
- Support for detector recipes of type `threat`, new detector rule of type `rogue user`, and sightings operations in the Cloud Guard service
- Support for more VM shape configurations when listing shapes in the Compute service
- Support for customer-managed encryption keys in the Analytics Cloud service
- Support for FastConnect device information in the Networking service

## 32.0.0 - 2022-02-15
### Added
- Support for the AI Vision service
- Support for the Threat Intelligence service
- Support for creation of NoSQL database tables with on-demand throughput capacity in the NoSQL Database Cloud service
- Support for tagging features in the Oracle Container Engine for Kubernetes (OKE) service
- Support for trace snapshots in the Application Performance Monitoring service
- Support for auditing and alerts in the Data Safe service
- Support for data discovery and data masking in the Data Safe service
- Support for customized subscriptions and delivery of announcements by email and SMS in the Announcements service
 
### Breaking Changes
- The deprecated API `QueryOld` from `QueryClient` and its request model `QueryOldRequest` were removed in the Application Performance Monitoring service

## 31.0.0 - 2022-02-08
### Added

- Support for managing tablespaces in the Database Management service
- Support for upgrading and managing payment for subscriptions in the Account Management service
- Support for listing fast launch job configurations in the Data Science service

### Breaking Changes
- The data type of the property BillToAddress was changed from `Address` to `BillToAddress` for the Invoice model of the Account Management service

## 30.3.0 - 2022-02-01
### Added
- Support for calling Oracle Cloud Infrastructure services in the `ap-dcc-canberra-1` region
- Support for the Console Dashboard service
- Support for capacity reservation in the Container Engine for Kubernetes service
- Support for tagging in the Container Engine for Kubernetes service
- Support for fetching listings by image OCID in the Marketplace service
- Support for underscores and hyphens in project resource names in the DevOps service
- Support for cross-region cloning in the Database service

### Fixed
- Fixed an error where Streaming Content in Requests was being disposed during retries.

## 30.2.0 - 2022-01-25
### Added
- Support for OneSubscription services
- Support for specifying if a run or application is streaming or batch in the Data Flow service
- Support for updating the Instance Configuration of an Instance Pool within a Cluster Network in the Compute Management service
- Updated documentation for Cross Region ADG feature for Autonomous Database in the Database service

## 30.1.0 - 2022-01-18
### Added
- Support for calling Oracle Cloud Infrastructure services in the `me-dcc-muscat-1` region
- Support for the Visual Builder service
- Support for cross-region replication of volume groups in the Block Storage service
- Support for boot volume encryption in the Container Engine for Kubernetes service
- Support for adding metadata to records when creating and updating records in the Data Labeling service
- Support for global export formats in snapshot datasets in the Data Labeling service
- Support for adding labeling instructions to datasets in the Data Labeling service
- Support for updating autonomous dataguard associations for autonomous container databases in the Database service
- Support for setting up automatic failover when creating autonomous container databases in the Database service
- Support for setting the RECO storage size when updating a database system in the Database service
- Support for reconnecting refreshable clones to source for autonomous databases on shared infrastructure in the Database service
- Support for checking if an autonomous database on shared infrastructure can be reconnected to source, in the Database service

## 30.0.0 - 2022-01-11
### Added
- Support for calling Oracle Cloud Infrastructure services in the `af-johannesburg-1` and `eu-stockholm-1` regions
- Support for multiple protocols on the same listener in the Network Load Balancing service
- IPv6 support in the Network Load Balancing service
- Support for creating Enterprise Manager-based Solaris and SunOS host targets in the Operations Insights service
- Support for choosing Data Guard type (Active Data Guard or regular) on databases in the Database service
- Support for Optional `HttpCompletionOption` parameter that can be provided for Head requests in all service clients for API requests
 
### Breaking
- The data type of property `Action` was changed from `System.Nullable<ActionEnum>` to `string` in InstanceActionRequest in Compute service
- The data type of property `Action` was changed from `System.Nullable<ActionEnum>` to `string` in DbNodeActionRequest in Database service
- The data type of property `Protocol` was changed from `System.Nullable<ProtocolEnum>` to `string` in ListIdentityProvidersRequest in Identity service
- The data type of property `Fields` was changed from `System.Nullable<FieldsEnum>` to `string` in ListObjectsRequest in Object Storage service
- The data type of property `Fields` was changed from `System.Nullable<FieldsEnum>` to `string` in ListObjectVersionsRequest in Object Storage service

## 29.4.0 - 2021-12-14
### Added
- Support for node replacement in the VMWare Solution service
- Support for ingestion of SQL stats metrics in the Operations Insights service
- Support for AWR hub integration in the Operations Insights service
- Support for automatically generating logical entities from filename patterns and relationships between business terms across glossaries in the Data Catalog service
- Support for automatic start/stop at scheduled times in the Database service
- Support for cloud VM cluster resources on autonomous dedicated databases in the Database service
- Support for external Hive metastores in the Big Data service
- Support for batch detection/inference in the AI Language service
- Support for dimensions on monitoring targets in the Service Connector Hub service
- Support for invoice operations in the Account Management service
- Support for custom CA trust stores in the API Gateway service
- Support for generating scoped database tokens in the Identity service
- Support for database passwords for users, for logging into database accounts, in the Identity service

## 29.3.0 - 2021-12-07
### Added
- Support for the Application Management service
- Support for getting the inventory of JMS resources and listing Java runtime usage in a specified host in the Java Management service
- Support for categories, entity topology, and verifying scheduled tasks in the Logging Analytics service
- Support for RAC databases in the GoldenGate service
- Support for querying additional fields of a resource using return clauses in the Search service
- Support for key versions and key version OCIDs in the Key Management service

## 29.2.0 - 2021-11-30
### Added

- Support for SQL Tuning Advisor in the Database Management service
- Support for listing users and getting user details in the Database Management service
- Support for autonomous databases in the Database Management service
- Support for enabling and disabling Database Management features on autonomous databases in the Database service
- Support for the Solaris platform in the Management Agent Cloud service
- Support for cross-compartment operations in the Operations Insights service
- Support for listing deployment backups in the GoldenGate service
- Support for standard tags in the Identity service
- Support for viewing problems for deleted targets in the Cloud Guard service
- Support for choosing a platform version while creating a platform instance in the Blockchain Platform service
- Support for custom IPSec connection tunnel internet key exchange phase 1 and phase 2 encryption algorithms in the Networking service
- Support for pagination when listing work requests corresponding to an APM domain in the Application Performance Monitoring service
- Support for the "deleted" lifecycle state on APM domains in the Application Performance Monitoring service
- Support for calling Oracle Cloud Infrastructure services in the eu-milan-1 and me-abudhabi-1 regions

## 29.1.0 - 2021-11-17
### Added

- Support for getting subnet topology in the Networking service
- Support for encrypted FastConnect resources in the Networking service
- Support for performance and high availability, as well as recommendation metrics, in the Optimizer service
- Support for optional TDE wallet passwords in the Database service
- Support for Object Storage service integration in the Big Data service

## 29.0.0 - 2021-11-09
### Added
 - Support for drill down metadata in the Management Dashboard service
 - Support for operator access control on dedicated autonomous databases in the Operator Access Control service

### Breaking Changes
 - The `ResourceType`, and `IsEnforcedAlways` fields changed from optional to required in the CreateOperatorControlAssignmentDetails model in the Operatoraccesscontrol service
 - The `ApproverGroupsList` field changed from optional to required in the CreateOperatorControlDetails model in the Operatoraccesscontrol service
 - The `IsFullyPreApproved`, and `requiredIsEnforcedAlways` fields changed from optional to required in the UpdateOperatorControlAssignmentDetails model in the Operatoraccesscontrol service
 - The `OperatorControlName`, `ApproverGroupsList`, and `IsFullyPreApproved` fields changed from optional to required in the UpdateOperatorControlDetails model in the Operatoraccesscontrol service
 - The `ResourceType` type changed from `string` to `System.Nullable<ResourceTypes>` in the OperatorControlAssignmentSummary model in the Operatoraccesscontrol service

### Fixed
 - Refreshing Instance Principals tokens after they expire

## 28.1.0 - 2021-11-02
### Added
- Support for the Database Tools service
- Support for scan listener port TCP and TCP SSL on cloud VM clusters in the Database service
- Support for domains in the Identity service
- Support for redeemable users and support rewards in the Usage service
- Support for calling Oracle Cloud Infrastructure services in the ap-singapore-1 and eu-marseille-1 regions

### Changed
- Endpoint for Identity service changed to include `.oci` subdomain

## 28.0.0 - 2021-10-26
### Added
- Support for the Source Code Management service
- Support for the Build service
- Support for the Certificates service
- Support to create child tenancies in an organization and manage subscriptions in the Organizations service
- Support for Certificates service integration in the Load Balancing service
- Support for creating hosts in specific availability domains in the VMWare Solution service
- Support for user-defined functions and libraries, as well as scheduling and orchestration, in the Data Integration service
- Support for EM-managed Exadatas and EM-managed hosts in the Operations Insights service
- Support for custom Second Level Domain via OCI_DEFAULT_REALM environment variable for unknown regions

### Breaking Changes
- The cases `COMPUTE_INSTANCE_GROUP_BLUE_GREEN_TRAFFIC_SHIFT`, `COMPUTE_INSTANCE_GROUP_CANARY_DEPLOYMENT`, `COMPUTE_INSTANCE_GROUP_ROLLING_DEPLOYMENT`, `LOAD_BALANCER_TRAFFIC_SHIFT`, `WAIT`, `COMPUTE_INSTANCE_GROUP_CANARY_TRAFFIC_SHIFT`, `RUN_VALIDATION_TEST_ON_COMPUTE_INSTANCE`, `RUN_DEPLOYMENT_PIPELINE`, and `COMPUTE_INSTANCE_GROUP_BLUE_GREEN_DEPLOYMENT` were removed in the DeployStageExecutionProgress model's ReadJson method in the DevOps service.

## 27.2.0 - 2021-10-19
### Added
- Support for creating database systems from backups with database software images in the Database service
- Support for optionally providing a SID prefix during Exadata database creation in the Database service
- Support for node subsetting on VM clusters in the Database service
- Support for non-CDB to PDB conversion in the Database service
- Support for default homepages, unprocessed data buckets, and parsing geostats in the Logging Analytics service

## 27.1.0 - 2021-10-12
### Added
- Support for the Data Labeling Service
- Support for querying and setting Application Performance Monitoring configurations in the Application Performance Monitoring service
- Support for the run-once monitor feature and network data collection in the Application Performance Monitoring service
- Support for Oracle Enterprise Manager bridges, source auto-association, source event types mapping, and partitioning and searching data by LogSet in the Logging Analytics service
- Support for Log events APIs used by plugins like fluentd, fluentbit, etc. to upload data in the Logging Analytics service
- Support for a new ActionType: FAILED in work requests in the VMware Provisioning service
- Support for calling Oracle Cloud Infrastructure services in the il-jerusalem-1 region

## 27.0.0 - 2021-10-05
### Added
- Support for configuring Binlog variables in the MySQL Database service.
- Support new response value "OPERATOR" for backup creationType in list and get MDS backup API in the MySQL Database service.
- Support for SetAutoUpgradableConfig and GetAutoUpgradableConfig operations in Management Agent Cloud service.
- Support for additional installType filter for List Management Agents, Images and Count API operations in Management Agent Cloud service.
- Support for list and read DeploymentUpgrade, cancel and restore DeploymentBackup in the Golden Gate service.
- Support for non-autonomous databases targets, executing Pre-Migration advisor, uploading Datapump logs into Object Storage bucket, and filtering Database Objects in the Database Migration service.
- Support for calling Oracle Cloud Infrastructure services in the ap-ibaraki-1 region.

### Breaking Changes
- `IsAgentAutoUpgradable` property was removed from UpdateManagementAgentDetails model in Management Agent Cloud service.
- The data type for `targetStates` was changed from `LifecycleStates` to `MigrationLifecycleStates` in DatabaseMigrationWaiters in the Database Migration service.
- The property `DisplayName` was removed from ListWorkRequestsRequest, ListWorkRequestLogsRequest & ListWorkRequestErrorsRequest in the Database Migration service.
- The `SortByEnum` enum's members `TimeCreated` and `DisplayName` were replaced by `TimeAccepted` in ListWorkRequestsRequest in the Database Migration service.
- The `SortByEnum` enum's members `TimeCreated` and `DisplayName` were replaced by `Timestamp` in ListWorkRequestLogsRequest & ListWorkRequestErrorsRequest in the Database Migration service.
- The type for property `LifecycleState` was changed from `LifecycleStates` to `MigrationLifecycleStates` in ListMigrationsRequest in the Database Migration service.
- The property `TimeStamp` was renamed to `Timestamp` in WorkRequestLogEntry & WorkRequestError in the Database Migration service.
- The property `CompartmentId` was removed from UpdateAgentDetails in the Database Migration service.

### Fixed
- Fixed `ContentType` and `ContentLength` properties not being used in `PutObject` API in Object Storage Service.

## 26.0.0 - 2021-09-28
### Added
- Support for autonomous databases and clones on shared infrastructure not requiring mTLS in the Database service
- Support for server-side encryption using object-specific KMS keys in the Object Storage service
- Support for Windows in the Java Management service
- Support for using network security groups in the API Gateway service
- Support for network security groups in the Functions service
- Support for signed container images in the Functions service
- Support for setting message format when creating and updating alarms in the Monitoring service
- Support for user and security assessment features in the Data Safe service

### Breaking Changes
- The `RequestSummarizedApplicationUsage`, `RequestSummarizedInstallationUsage`, `RequestSummarizedJreUsage`, `RequestSummarizedManagedInstanceUsage` were removed from the `JavaManagementServiceClient` in the Java Management service
- The `RequestSummarizedApplicationUsageDetails`, `RequestSummarizedInstallationUsageDetails`, `RequestSummarizedJreUsageDetails` and `RequestSummarizedManagedInstanceUsageDetails` models were removed in the Java Management service
- The `RequestSummarizedInstallationUsageRequest` and `RequestSummarizedManagedInstanceUsageRequest` requests were removed in the Java Management service

## 25.1.0 - 2021-09-14
### Added
- Support for `ServiceHostKeyFingerprint` property for InstanceConsoleConnection in Core service
- Support for Shielded Instances in Core service
- Support for ML Jobs in the Data Science service

## 25.0.0 - 2021-09-07
### Added
- Support for terraform advanced options (detailed log level, refresh, and parallelism) on jobs in the Resource Manager service
- Support for forced cancellation when cancelling jobs in the Resource Manager service
- Support for getting the detailed log content of a job in the Resource Manager service
- Support for provider information in the responses of list operations in the Management Dashboard service
- Support for scheduled jobs in Database Management service
- Support for monitoring and management of OCI virtual machine, bare metal, and ExaCS databases in the Database Management service
- Support for a unified way of managing both external and cloud databases in the Database Management service
- Support for metrics and Performance Hub on virtual machine, bare metal, and ExaCS databases in the Database Management service

### Breaking Changes
- The property `OciSplatGeneratedOcids` was removed from `CreateTemplateRequest` in the Resource Manager service

## 24.2.0 - 2021-08-31
### Added
- Support for Oracle Analytics Cloud and OCI Vault integration on connections in the Data Catalog service
- Support for critical event monitoring in the OS Management service

## 24.1.0 - 2021-08-24
### Added
- Support for generating recommended VM cluster networks in the Database service
- Support for creating VM cluster networks with a specified listener port in the Database service

## 24.0.0 - 2021-08-17
### Added
- Support for getting management agent hosts which are eligible to create Operations Insights host resources on, in the Operations Insights service
- Support for getting summarized agent counts and summarized plugin counts in the Management Agent Cloud service

### Breaking Changes
- The `PluginName` property's return type was changed from `string` to `List<string>` in `ListManagementAgentsRequest` in the Management Agent Cloud service
- The `Version` property's return type was changed from `string` to `List<string>` in `ListManagementAgentsRequest` in the Management Agent Cloud service
- The `PlatformType` property's return type was changed from `PlatformTypes` to `List<PlatformTypes>` in `ListManagementAgentsRequest` in the Management Agent Cloud service

## 23.2.0 - 2021-08-03
### Added
- Support for manually copying volume group backups across regions in the Block Volume service
- Support for work requests for the copy volume backup and copy boot volume backup operations in the Block Volume service
- Support for specifying external Hive metastores during application creation in the Data Flow service
- Support for changing the compartment of a backup in the MySQL Database service
- Support for model catalog features including provenance, metadata, schemas, and artifact introspection in the Data Science service
- Support for Exadata system network bonding in the Database service
- Support for creating autonomous databases with early patching enabled in the Database service

## 23.1.0 - 2021-07-27
### Added
- Support for filtering by tag on capacity planning and SQL warehouse list operations in the Operations Insights service
- Support for creating cross-region autonomous data guards in the Database service
- Support for the customer contacts feature on cloud exadata infrastructure in the Database service
- Support for cost analysis custom tables in the Usage service

## 23.0.0 - 2021-07-20
### Added
- Support for schedules, schedule tasks, REST tasks, operators, S3, and Fusion Apps in the Data Integration service
- Support for getting available updates and update histories for VM clusters in the Database service
- Support for downloading network validation reports for Exadata network resources in the Database service
- Support for patch and upgrade of Grid Infrastructure (GI), and update of DomU OS software for VM clusters in the Database service
- Support for updating data guard associations in the Database service
- Limit Expect 100-continue to be enabled for only for Object Storage and Log Analytics service

### Breaking Changes
- The property `BucketName` was replaced by `BucketSchema` in the models OracleAdwcWriteAttributes and OracleAtpWriteAttributes under the Data Integration service
- The type for property `Type` was changed from `BaseType` to `System.Object` for Parameter model under the Data Integration service
- The type for property `Type` was changed from `string` to `System.Object` for ShapeField and NativeShapeField models under the Data Integration service

## 22.0.0 - 2021-07-13
### Added
- Support for the AI Anomaly Detection service
- Support for retrieving a DNS zone as a zone file in the DNS service
- Support for querying manual adjustments in the Usage service
- Support for searching Marketplace listings in the Marketplace service
- Support for new cluster type 'ODH' in the Big Data service
- Support for availability domain as an optional parameter when creating VLANs in the Networking service
- Support for search domain type on DHCP options, to support multi-level domain search in the Networking service

### Breaking Changes
- The property `TSIG` was removed from ExternalMaster model in the DNS service.
- The models SavedScheduleReport, ScheduleReport, ScheduleReportSummary, UpdateCustomTableDetail and UpdateScheduleReportDetails were removed from the Usage Service.

## 21.1.0 - 2021-07-06
### Added
- Support for order activation in the Organizations service
- Support for resource principal authorization on Enterprise Manager bridge resources in the Operations Insights service
- Support for the starter edition license type in the Content and Experience service
- Support for the Generic Artifacts service's new domain name
- Support for more collection formats in query parameters in addition to csv

## 21.0.0 - 2021-06-29
### Added
- Support for the DevOps service
- Support for configuring network security groups for node pools in the Container Engine for Kubernetes service
- Support for optionally specifying CPU core count and data storage size when creating autonomous databases in the Database service
- Support for metastore and initial data asset import/export in the Data Catalog service
- Support for associating domain names to emails and managing email domain names / DKIM in the Email Delivery service
- Support for email domain names on senders and suppressions in the Email Delivery service

### Breaking Changes
- `DISPLAYNAME` enum was removed from the SortBy property in ListJobExecutionsRequest under the Data Catalog service
- SortOrder type was changed to `SortOrderEnum` to `SortOrder` in ListSuppressionsRequest under the Email Delivery service
- SortOrder type was changed to `SortOrderEnum` to `SortOrder` in ListSendersRequest under the Email Delivery service
- The property `CpuCoreCount` was made optional in CreateAutonomousDatabaseBase in the Database service

## 20.1.0 - 2021-06-22
### Added
- Support for virtual machine and bare metal pluggable databases in the Database service

## 20.0.0 - 2021-06-15
### Added
- Support for elastic storage on Exadata Infrastructure resources for Cloud at Customer in the Database service
- Support for registration and management of target databases in the Data Safe service
- Support for config on metadata in the Management Dashboard service
- Support for a new work request operation type for node pool reconciliation events in the Container Engine for Kubernetes service
- Support for migrating clusters with a public Kubernetes API endpoint which are not integrated with a customer's VCN to a VCN-native cluster in the Container Engine for Kubernetes service
- Support for getting the spark version of applications, and filtering applications by spark version, in the Data Flow service

### Breaking Changes
- The properties `FreeformTags` and `DefinedTags` were removed from the ManagementDashboardExportDetails model in the Management Dashboard service

## 19.2.0 - 2021-06-08
### Added
- Support for Java Management service.
- Support for resource principals for the Enterprise Manager bridge resource in Operations Insights service.
- Support for encryptionInTransitType in BootVolumeAttachment and IScsiVolumeAttachment in Core service.
- Support for updating iscsiLoginState for VolumeAttachment in Core service.
- Support for a new type of Source called Import for use with the Export tool in Application Migration service.

## 19.1.0 - 2021-05-27
### Added
- Support for configuration of autonomous database KMS keys in the Database service.
- Support for creating database software images with any supported RUs in the Database service.
- Support for creating database software images from an existing database home in the Database service.
- Support for listing all NSGs associated with a given VLAN in the Networking service.
- Support for a duration windows, task failure reasons, and next execution times on scheduled tasks in the Logging Analytics service.
- Support for calling Oracle Cloud Infrastructure services in the sa-vinhedo-1 region.

## 19.0.0 - 2021-05-25
### Added
- Support for the Generic Artifacts service.
- Support for the Bastion service.
- Support for reading secrets by name in the Vault service.
- Support for the isDynamic field when listing definitions in the Limits service.
- Support for getting billable image sizes in the Compute service.
- Support for getting Automatic Workload Repository (AWR) data on external databases in the Database Management service.
- Support for the VM.Standard.E3.Flex flexible compute shape with customizable OCPUs and memory on notebooks in the Data Science service.
- Support for container images and generic artifacts billing in the Registry service.
- Support for the HCX Enterprise add-on in the VMware Solution service.

### Breaking Changes
- The type for `Name` property in `SupportedSkuSummary` model was changed from `NameEnum` to `Sku` in the VMware Solution service.
- The property `InitialSku` in `Sddc` and `CreateSddcDetails` models was made optional in the VMware Solution service.
- The property `CurrentSku` in `CreateEsxiHostDetails` model was made optional in the VMware Solution service.
- A required property `BillableSizeInGBs` was added to model `ContainerRepository` and `ContainerRepositorySummary` in the Artifacts service.

## 18.5.0 - 2021-05-18
### Added
- Support for spark-submit compatible options in the Data Flow service.
- Support for Object Storage as a configuration source in the Resource Manager service.

## 18.4.0 - 2021-05-11
### Added
- Support for creating notebook sessions with larger block volumes in the Data Science service.
- Support for database maintenance run patch modes in the Database service.

## 18.3.0 - 2021-05-04
### Added
- Support for the Operator Access Control service.
- Support for the Service Catalog service.
- Support for the AI Language service.
- Support for autonomous database on Exadata Cloud at Customer infrastructure patching in the Database service.

## 18.2.0 - 2021-04-27
### Added
- VCN id parameters were moved from being required to being optional on all list operations in the Networking service.
- Support for RACs (real application clusters) for external container, non-container, and pluggable databases in the Database service.
- Support for data masking in the Cloud Guard service.
- Support for opting out of DNS records during instance launch, as well as attaching secondary VNICs, in the Compute service.
- Support for mutable sizes on cluster networks in the Autoscaling service.
- Support for auto-tiering on buckets in the Object Storage service.

## 18.1.0 - 2021-04-20
### Added
- Support for opting in/out of live migration on instances in the Compute service.
- Support for enabling/disabling Operations Insights on external non-container and external pluggable databases in the Database service.
- Support for a GraphStudio URL as a connection URL on databases in the Database service.
- Support for adding customer contacts on autonomous databases in the Database service.
- Support for name annotations on harvested objects in the Data Catalog service.

## 18.0.0 - 2021-04-13
### Added
- Support for the Database Migration service.
- Support for the Networking Topology service.
- Support for getting the id of peered VCNs on local peering gateways in the Networking service.
- Support for burstable instances in the Compute service.
- Support for preemptible instances in the Compute service.
- Support for fractional resource usage and availability in the Limits service.
- Support for streaming analytics in the Service Connector Hub service.
- Support for flexible routing inside DRGs to enable packet flow between any two attachments in the Networking service. 
- Support for routing policy to customize dynamic import/export of routes in the Networking service.
- Support for IPv6, including on FastConnect and IPsec resources, in the Networking service.
- Support for request validation policies in the API Gateway service.
- Support for RESP-compliant (e.g. REDIS) response caches, and for configuring response caching per-route in the API Gateway service.
- Support for flexible billing in the VMWare Solution service.
- Support for new DNS format for the Web Application Acceleration and Security service.
- Support for configuring APM tracing on applications and functions in the Functions service.
- Support for Enterprise Manager external databases and Management Agent Service managed external databases and hosts in the Operations Insights service.
- Support for getting cluster cache metrics for RAC CDB managed databases in the Database Management service.

### Breaking Changes
- `VcnId` was made optional in CreateDrgAttachmentDetails model under Core services.
- The property `IsInternetAccessAllowed` was removed from CreateIpv6Details model under Core services.
- The property `Ipv6CidrBlock` was removed from CreateVcnDetails model under Core services.
- The property `PublicIpAddress` and `IsInternetAccessAllowed` were removed from Ipv6 model under Core services.
- Required property `PeerId` was added to LocalPeeringGateway model under Core services.
- The property `Ipv6PublicCidrBlock` was removed from Subnet model under Core services.
- The property `Ipv6PublicCidrBlock` was replaced by `Ipv6CidrBlocks` in Vcn model in Core services.
- Required property `CurrentSku` was added under CreateEsxiHostDetails under Ocvp service.
- Required property `InitialSku` was added under CreateSddcDetails under Ocvp service.
- Required properties `BillingContractEndDate`, `NextSku` & `CurrentSku` were added under EsxiHost under Ocvp service.
- Required properties `BillingContractEndDate`, `NextSku` & `CurrentSku` were added under EsxiHostSummary under Ocvp service.
- Required property `InitialSku` was added under Sddc under Ocvp service.
- Required property `Id` was added under DatabaseDetails under Opsi service.
- The property `CompartmentId` was made optional in ListDatabaseInsightsRequest under Opsi service.
- Properties `CompartmentId` and `DatabaseId` were made optional in IngestSqlTextRequest under Opsi service.
- Properties `CompartmentId` and `DatabaseId` were made optional in IngestSqlPlanLinesRequest under Opsi service.

## 17.1.0 - 2021-04-06
### Added
- Support for scheduling the suspension and resumption of compute instance pools based on predefined schedules in the Autoscaling service.
- Support for database software images for Cloud@Customer in the Database service.
- Support for OCIC IDCS authorization details in the Application Migration service.
- Support for cross-region asynchronous volume replication in the Block Storage service.
- Support for SDK generation in the API Gateway service.
- Support for container image signing in the Registry service.
- Support for cluster features as a part of the Container Engine for Kubernetes service.
- Support for filtering dedicated virtual machine hosts by remaining memory and OCPUs in the Compute service.
- Support for read/write-any object from buckets using pre-authenticated requests in the Object Storage service.
- Support for restricting pre-authenticated requests by prefix in the Object Storage service.
- Support for route filtering on public virtual circuits in the Virtual Networking service.

## 17.0.0 - 2021-03-30
### Added
- Support for the Vulnerability Scanning service.
- Support for vSphere 7.0 in the VMware Solution service.
- Support for forecasting in the Usage service.
- Support for viewing, searching, and modifying parameters for on-premise Oracle databases in the Database Management service.
- Support for listing tablespaces of managed databases in the Database Management service.
- Support for cross-regional replication of keys in the Key Management service.
- Support for highly-available database systems in the MySQL Database service.
- Support for Oracle Enterprise Manager bridges, source auto-association, source event type mappings, and plugins to upload data in the Logging Analytics service.

### Breaking Changes
- StatusEnum EnumMember `SUCCESFUL` was renamed to `SUCCESSFUL` in ListLookupsRequest in Loganalytics service.
- `TimeForecastStarted` property was made optional in Forecast model in Usageapi service.
- `ForcastType` property was renamed to `ForecastType` in Forecast model in Usageapi service.

## 16.0.0 - 2021-03-23
### Added
- Support for the Network Load Balancing service.
- Support for maintenance runs on autonomous databases in the Database service.
- Support for announcement preferences in the Announcements service.
- Support for domain claiming in the Organizations service.
- Support for saved reports in the Usage service.
- Support for the HeatWave in-memory analytics accelerator in the MySQL Database service.
- Support for community applications in the Marketplace service.
- Support for capacity reservations in the Compute service.

### Breaking Changes
- `VnicId` was marked as a required property for `Ipv6` under `Core` service.
- `VnicId` was marked as a required property for `CreateIpv6Details` under `Core` service.
- `CompartmentId` property was removed from `ListWorkRequestLogsRequest` under the `Tenantmanagercontrolplane` service. 

## 15.2.0 - 2021-03-16
### Added
- Support for routing policies and HTTP2 listener protocols in the Load Balancing service.
- Support for model deployments in the Data Science service.
- Support for private clusters in the Container Engine for Kubernetes service.
- Support for updating an instance's usage type in the Content and Experience service.

## 15.1.0 - 2021-03-09
### Added
- Support for the Application Performance Monitoring service.
- Support for the Golden Gate service.
- Support for SMS subscriptions in the Notifications service.
- Support for friendly-formatted messages in the Service Connector Hub service.
- Support for attaching and detaching instances to instance pools in the Autoscaling service.

## 15.0.0 - 2021-03-02
### Added
- Support for pipelines, pipeline tasks, and favorites in the Data Integration service.
- Support for publishing tasks to OCI Data Flow in the Data Integration service.
- Support for clones in the File Storage service.

### Breaking changes
- Changed model `UniqueKey` in the Dataintegration service to not inherit from Key.
- Changed model `PrimaryKey` in the Dataintegration service to inherit from `UniqueKey`.
- Removed KeyModelTypeEnum enum type `PRIMARY_KEY` and `UNIQUE_KEY` from model `key` in the Dataintegration service.

## 14.2.0 - 2021-02-23
### Added
- Support for the OCI Registry service
- Support for exporting an existing running VM, or a copy of VM, into a VMDK, QCOW2, VDI, VHD, or OCI formatted image in the Compute service
- Support for platform configurations on instances in the Compute service
- Support for providing target tags and target compartments on profiles in the Optimizer service
- Support for the 'Fix it' feature in the Optimizer service
- Enable Expect 100-continue for all services

## 14.1.0 - 2021-02-16
### Added
- Support for scan DNS names and zone ids on database system, cloud VM cluster, and autonomous Exadata infrastructure responses in the Database service
- Support for specifying ACL rules to limit ingress into public load balancers in the Integration service
- Support for Cloud at Customer as a source type in the Application Migration service
- Support for selective migration of specific resources in the Application Migration service

## 14.0.0 - 2021-02-09
### Added
- Support for the Database Management service
- Support for setting an offset for budget processing in the Budgets service
- Support for enabling and disabling Oracle Cloud Agent plugins in the Compute service
- Support for listing available plugins and for getting the status of plugins in the Oracle Cloud Agent service
- Support for one-off patching in autonomous transaction processing - dedicated databases in the Database service
- Support for additional database upgrade options in the Database service
- Support for glossary term recommendations in the Data Catalog service
- Support for listing errata in the OS Management service

### Breaking changes
- `InstanceAgentCommandContentInfo` was removed from Computeinstanceagent service.
- `InstallationRequirements` was replaced by `InstallationRequirementsEnum` in WindowUpdate model in Osmanagement service.

## 13.0.0 - 2021-02-02
### Added
- Support for checking if a contact for Exadata infrastructure is valid in My Oracle Support in the Database service
- Support for checking if Exadata infrastructure is in a degraded state in the Database service
- Support for updating the operating system on a VM cluster in the Database service
- Support for external databases in the Database service
- Support for uploading objects to the infrequent access storage tier in the Object Storage service
- Support for changing the storage tier of existing objects in the Object Storage service
- Support for private templates in the Resource Manager service
- Support for multiple encryption domains on IPSec tunnels in the Networking service

### Breaking Changes
- Header Parameter `Etag` in Operation `ListAppCatalogListingResourceVersions` response was removed from the Core service.
- Property `vnicId` in model `Ipv6` was removed as required parameter from from the Core service.
- `ArchivalStateEnum` enum was replaced by `ArchivalState` in `GetObjectResponse` in Object Storage Service.

## 12.0.0 - 2021-01-26
### Added
- Support for creating, managing, and using asymmetric keys in the Key Management service.
- Support for peer ACD unique names in Exadata Cloud at Customer in the Database service.
- Support for ACLs on autonomous databases in Exadata Cloud at Customer Data Guard in the Database service.
- Support for drift detection on individual resources of a stack in the Resource Manager service.
- Support for private access channels and vanity URLs in the Analytics Cloud service.
- Support for updating load balancer shapes in the Blockchain Platform service.
- Support for assigning volume backup policies to volume groups in the Block Volume service.

### Breaking Changes
- CreateBlockchainPlatformDetails now has IdcsAccessToken as required property in the BlockChain service.

## 11.0.0 - 2021-01-19
### Added
- Support for Logging Analytics as a target in the Service Connector Hub service.
- Support for lookups, agent collection warnings, task commands, and data archive/recall in the Logging Analytics service.

### Fixed
- Fixed a bug in the endpoint used for the Management Dashboard service.

### Breaking Changes
- Parameter `SortBy` type in request `ListMetaSourceTypesRequest` changed from `string` to `System.Nullable<SortByEnum>` in the Loganalytics service.
- Parameter `SortBy` type in request `ListParserFunctionsRequest` changed from `string` to `System.Nullable<SortByEnum>` in the Loganalytics service.
- Parameter `SortBy` type in request `ListParserMetaPluginsRequest` changed from `string` to `System.Nullable<SortByEnum>` in the Loganalytics service.
- Parameter `SortBy` type in request `ListSourceLabelOperatorsRequest` changed from `string` to `System.Nullable<SortByEnum>` in the Loganalytics service.
- Parameter `SortBy` type in request `ListSourceMetaFunctionsRequest` changed from `string` to `System.Nullable<SortByEnum>` in the Loganalytics service.

## 10.0.0 - 2021-01-12
### Added
- Support for auto-scaling in the Big Data service
- Documentation fixes for the Logging Search service

### Breaking Changes
- Removed `STARTING` and `STOPPING` values from enum LifecycleStateEnum of model `Node` in the Bds
- Removed `UPDATING_INFRA` value from enum LifecycleStateEnum of model `BdsInstance` in the Bds

## 9.0.0 - 2020-12-15
### Added

- Support for filtering listKeys based on KeyShape in KeyManagement service
- Support for the Oracle Roving Edge Infrastructure service
- Support for flexible ShapeDetails in Load Balancer service
- Support for listing of harvested Rules, additional filtering for Logical Entity list calls in Data Catalog service
- Support second level domain for audit SDK
- Support for listing flex components in Database service
- Support for APEX service for ADBS on OCI console for Database service
- Support for Customer-Managed Key features as a part of the Database service
- Support for Github configuration source provider as part of the Resource Manager service

### Breaking Changes
- Removing deprecated CreateAutonomousDataWarehouse API from Database service
- Removing deprecated CreateAutonomousDataWarehouseBackup API from Database service
- Removing deprecated DeleteAutonomousDataWarehouse API from Database service
- Removing deprecated GenerateAutonomousDataWarehouseWallet API from Database service
- Removing deprecated GetAutonomousDataWarehouse API from Database service
- Removing deprecated GetAutonomousDataWarehouseBackup API from Database service
- Removing deprecated ListAutonomousDataWarehouseBackups API from Database service
- Removing deprecated ListAutonomousDataWarehouses API from Database service
- Removing deprecated RestoreAutonomousDataWarehouse API from Database service
- Removing deprecated StartAutonomousDataWarehouse API from Database service
- Removing deprecated StopAutonomousDataWarehouse API from Database service
- Removing deprecated UpdateAutonomousDataWarehouse API from Database service

## 8.1.0 - 2020-12-08
### Added

- Support for Integration Service custom endpoint feature
- Support for metadata field in IdentityProvider Get and List response
- Support for fine-grained data analysis and improved SQL insights
- Support for ADB Dedicated - ORDS and SSL cert rotation at AEI
- Support for Maintenance Schedule feature for Exadata Infrastructure resources for ExaCC

## 8.0.0 - 2020-12-01
### Added
- Support for calling Oracle Cloud Infrastructure services in the sa-santiago-1 region
- Support for peer and OSN resources, as well as retry tokens, in the Blockchain Platform service
- Support for getting the availability status of management agents in the Management Agent service
- Support for the on-prem-connector resource type in the Data Safe service
- Support for service channels in the MySQL Database service
- Support for getting the creation type of backups, and for filtering backups by creation type in the MySQL Database service
- Fixed Delete request issue when used in .NET Framework applications
- Send DateTime values in request body in RFC3339 format
- Add link to sample code for each API method and request class

### Breaking Changes
- DefinedTags and FreeformTags properties are removed from EnableDataSafeConfigurationDetails model in the Datasafe service
- CompartmentId parameter is changed from optional to required in ListDataSafePrivateEndpointsRequest in the Datasafe service
- IsEnabled property is changed from optional to required in EnableDataSafeConfigurationDetails model in the Datasafe service

## 7.0.0 - 2020-11-17
### Added

- Support for specifying memory for AMD E3 shapes during node pool creation and update in the Container Engine for Kubernetes service
- Support for upgrading a database on a VM database system in the Database service
- Support for listing autonomous database clones in the Database service
- Support for Data Guard with autonomous container databases on Exadata Cloud at Customer in the Database service
- Support for getting the last login time of a user in the Identity service
- Support to bulk editing tags on resources in the Identity service
- Property Id in CreateManagementSavedSearchDetails model is changed from required to optional in the Management Dashboard service

### Breaking Changes
- The base type of parameter Status in ListWorkRequests request is changed from WorkRequestStatus enum to string in the Container Engine for Kubernetes service
- Some models are removed from the Log Analytics service: AgentUpload, Attribute, CreateNamespaceDetails, FieldMap, GenerateAgentObjectNameDetails, LogAnalytics, LogAnalyticsCollectionWarning, LogAnalyticsSummary, OutOfBoxEntityTypeDetails, Query, QueryWorkRequestResource, RegisterEntityTypesDetails, ServiceTenancy, SortOrders, StringListDetails
- The property ErrorDetails is removed from DeleteAssociationsResponse in the Log Analytics service
- Enum value is changed from CuslterSplit to ClusterSplit in the Log Analytics service
- The type of property Id in LogAnalyticsParserFilter model is changed from Object to string in the Log Analytics service

## 6.2.0 - 2020-11-10
### Added
- Support for uploading large objects using UploadManager.
- Support for the 21C autonomous database version in the Database service
- Support for creating a Data Guard association with a standby database from a database software image in the Database service
- Support for specifying a TDE wallet password when creating a database or database system in the Database service
- Support for enabling access control lists for autonomous databases on Exadata Cloud At Customer in the Database service
- Support for private DNS resolvers, resolver endpoints, and views in the DNS service
- Support for getting a VCN and resolver association in the Networking service
- Support for additional parameters when updating subnets and VLANs in the Networking service
- Support for analytics clusters (database accelerators) in the MySQL Database service
- Support for migrations to Java Cloud Service and Oracle Weblogic Server instances that use existing databases in the Application Migration service
- Support for specifying reserved IPs when creating load balancers in the Load Balancing service

## 6.1.0 - 2020-11-03
### Added
- Support for calling Oracle Cloud Infrastructure services in the uk-cardiff-1 region
- Support for the Organizations service
- Support for the Optimizer service
- Support for tenancy ID and name on responses in the Usage service
- Support for object versioning in object lifecycle management in the Object Storage service
- Support for specifying a syslog URL for applications in the Functions service
- Support for creation of always-free NoSQL database tables in the NoSQL Database service

## 6.0.0 - 2020-10-27
### Added
- Support for the Compute Instance Agent service
- Support for key store resources and operations in the Database service
- Support for specifying a key store when creating autonomous container databases in the Database service

### Breaking Changes
- ConfigFileAuthenticationDetailsProvider will no longer support setting user details but only populates user information from the given OCI configuration file. Users can instead use SimpleAuthenticationDetailsProvider.

## 5.1.0 - 2020-10-20
### Added
- Support for the Operations Insights service
- Support for updating autonomous databases to enable/disable Operations Insights service integration, in the Database service
- Support for the NEEDS_ATTENTION lifecycle state on database systems in the Database service
- Support for HCX in the VMware Solutions service

## 5.0.1 - 2020-10-13
### Added
- Fix duplicate API's in Database client

## 5.0.0 - 2020-10-13
### Added
- Support for API definitions in the API Gateway service
- Support for pattern-based logical entities, namespace-bound custom properties, and faceted search in the Data Catalog service
- Support for autonomous Data Guard on autonomous infrastructure in the Database service
- Support for creating a Data Guard association on an existing standby database home in the Database service
- Support for upgrading cloud VM cluster grid infrastructure in the Database service

### Breaking Changes
- Property `isQuickStart` in models `CreateLogSavedSearchDetails`, `LogSavedSearchSummary`,`UpdateLogSavedSearchDetails` and `LogSavedSearch` is removed from the Logging Management service
- Lifecycle State `DELETED` is removed from `LogSavedSearchLifecycleState` in the Logging Management service

## 4.7.0 - 2020-10-06
### Added

- Support for calling Oracle Cloud Infrastructure services in the me-dubai-1 region
- Support for rotating keys on autonomous container databases and autonomous databases in the Database service
- Support for cloud Exadata infrastructure and cloud VM clusters in the Database service
- Support for controlling the display of tax banners in the Marketplace service
- Support for application references, patch changes, generic JDBC and MySQL data asset types, and publishing tasks to OCI Dataflow in the Data Integration service
- Support for disabling the legacy Instance Metadata endpoints v1 in the Compute service
- Support for instance configurations specifying instance options in the Compute Management service

## 4.6.0 - 2020-09-29
### Added

- Support for specifying custom content dispositions when downloading objects in the Object Storage service
- Support for the “bring your own IP address” feature in the Virtual Networking service
- Support for updating the tags of instance console connections in the Compute service
- Support for custom SSL certificates on gateways in the API Gateway service

## 4.5.0 - 2020-09-22
### Added

- Support for software keys in the Key Management service
- Support for customer contacts on Exadata Cloud at Customer in the Database service
- Support for updating open modes and permission levels of autonomous databases in the Database service
- Support for flexible memory on VM instances in the Compute and Compute Management services

## 4.4.0 - 2020-09-15
### Added

- Support for the Cloud Guard service
- Support for specifying desired consumption models when creating instances in the Integration service
- Support for dynamic shapes in the Load Balancing service
- Fix issue retrieving region from regionCode

## 4.3.0 - 2020-09-08
### Added
- Support for Logging Service
- Support for Logging Analytics Service
- Support for Logging Search Service
- Support for Logging Ingestion Service
- Support for Management Agent Cloud Service
- Support for Management Dashboard Service
- Support for Service Connector Hub service
- Support for Policy based Request/Response transformation in the API Gateway Service
- Support for sending diagnostic interrupt to a VM instance in the Compute Service
- Support for custom Database Software Images in the Database Service
- Support for getting and listing container database patches for Autonomous Container Database resources in the Database Service
- Support for updating patch id on maintenance run for Autonomous Container Database resources in the Database Service
- Support for searching Oracle Cloud resources across tenancies in the Search Service
- Documentation update for Logging Policies in the API Gateway service
- Support for Instance Principal Authentication

## 4.2.0 - 2020-09-01
### Added
- Support for calling Oracle Cloud Infrastructure services in the ap-chiyoda-1 region
- Support for VM database cloning in the Database service
- Support for the MAINTENANCE_IN_PROGRESS lifecycle state on database systems, VM clusters, and Cloud Exadata in the Database service
- Support for provisioning refreshable clones in the Database service
- Support for new options on listeners and backend sets for specifying SSL protocols, SSL cipher suites, and server ordering preferences in the Load Balancing service
- Support for AMD flexible shapes with configurable CPU in the Container Engine for Kubernetes service
- Support for network sources in authentication policies in the Identity service

## 4.1.0 - 2020-08-18
### Added
- Support for custom boot volume size and other node pool updates in the Container Engine for Kubernetes service
- Support for Data Guard on Exadata Cloud at Customer VM clusters in the Database service
- Support for stopping VM instances after scheduled maintenance or hypervisor reboots in the Compute service
- Support for creating and managing private endpoints in the Data Flow service

## 4.0.0 - 2020-08-11
### Added
- Support for autonomous json databases in the Database service
- Support for cleaning up uncommitted multipart uploads in the Object Storage service
- Support for additional list API filters in the Data Catalog service
- Updated default list of retryable errors

### Breaking Changes
- Some unusable region enums were removed from the Support Management service
- Updated default retry delay strategy from fixed delay to exponential delay.

## 3.0.0 - 2020-08-03
### Added
- Support for calling Oracle Cloud Infrastructure services in the uk-gov-cardiff-1 region
- Support for creating and managing private endpoints in the Data Flow service
- Support for changing instance shapes and restarting nodes in the Big Data service
- Support for additional versions (for example CSQL) in the Big Data service
- Support for creating stacks from compartments in the Resource Manager service

### Breaking Changes
- Renamed the property of `LifeCycleDetails` to `LifecycleDetails` from the model of `BlockchainPlatformSummary` and `BlockchainPlatformByHostname` in the Blockchain service

## 2.0.0 - 2020-07-28

### Added

- Support for calling Oracle Cloud Infrastructure services in the us-sanjose-1 region
- Support for updating the fault domain and launch options of VM instances in the Compute service
- Support for image capability schemas and schema versions in the Compute service
- Support for 'Patch Now' maintenance runs for autonomous Exadata infrastructure and autonomous container database resources in the Database service
- Support for automatic performance and cost tuning on volumes in the Block Storage service

### Breaking changes

- Removed the accessToken field from the GitlabAccessTokenConfigurationSourceProvider model in the Resource Manager service

## 1.2.0 - 2020-07-21

### Added

- Support for license types on instances in the Content and Experience service.

## 1.1.0 - 2020-07-14

### Added

- Support for the Blockchain service
- Support for failing over an autonomous database that has Data Guard enabled in the Database service
- Support for switching over an autonomous database that has Data Guard enabled in the Database service
- Support for git configuration sources in the Resource Manager service
- Support for optionally specifying a VCN id on list operations of DHCP options, subnets, security lists, route tables, internet gateways, and local peering gateways in the Networking service

## 1.0.0 - 2020-07-07

### Added

- Initial Release
- Ability to use .NET SDK in multi-threaded environment
- Config-based authentication
- Supports waiters
- Supports paginators
- Supports non-regional clients
- Supports raw requests
