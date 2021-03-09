# Change Log

All notable changes to this project will be documented in this file.

The format is based on Keep a [Changelog](http://keepachangelog.com/).

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
