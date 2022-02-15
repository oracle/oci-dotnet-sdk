# Change Log

All notable changes to this project will be documented in this file.

The format is based on Keep a [Changelog](http://keepachangelog.com/).

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
