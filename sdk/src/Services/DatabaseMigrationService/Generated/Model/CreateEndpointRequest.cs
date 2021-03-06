/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Container for the parameters to the CreateEndpoint operation.
    /// Creates an endpoint using the provided settings.
    /// </summary>
    public partial class CreateEndpointRequest : AmazonDatabaseMigrationServiceRequest
    {
        private string _certificateArn;
        private string _databaseName;
        private DmsTransferSettings _dmsTransferSettings;
        private DynamoDbSettings _dynamoDbSettings;
        private ElasticsearchSettings _elasticsearchSettings;
        private string _endpointIdentifier;
        private ReplicationEndpointTypeValue _endpointType;
        private string _engineName;
        private string _externalTableDefinition;
        private string _extraConnectionAttributes;
        private KinesisSettings _kinesisSettings;
        private string _kmsKeyId;
        private MongoDbSettings _mongoDbSettings;
        private string _password;
        private int? _port;
        private S3Settings _s3Settings;
        private string _serverName;
        private string _serviceAccessRoleArn;
        private DmsSslModeValue _sslMode;
        private List<Tag> _tags = new List<Tag>();
        private string _username;

        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the certificate.
        /// </para>
        /// </summary>
        public string CertificateArn
        {
            get { return this._certificateArn; }
            set { this._certificateArn = value; }
        }

        // Check to see if CertificateArn property is set
        internal bool IsSetCertificateArn()
        {
            return this._certificateArn != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name of the endpoint database.
        /// </para>
        /// </summary>
        public string DatabaseName
        {
            get { return this._databaseName; }
            set { this._databaseName = value; }
        }

        // Check to see if DatabaseName property is set
        internal bool IsSetDatabaseName()
        {
            return this._databaseName != null;
        }

        /// <summary>
        /// Gets and sets the property DmsTransferSettings. 
        /// <para>
        /// The settings in JSON format for the DMS transfer type of source endpoint. 
        /// </para>
        ///  
        /// <para>
        /// Possible attributes include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>serviceAccessRoleArn</code> - The IAM role that has permission to access the
        /// Amazon S3 bucket.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>bucketName</code> - The name of the S3 bucket to use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>compressionType</code> - An optional parameter to use GZIP to compress the
        /// target files. To use GZIP, set this value to <code>NONE</code> (the default). To keep
        /// the files uncompressed, don't use this value. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Shorthand syntax for these attributes is as follows: <code>ServiceAccessRoleArn=string,BucketName=string,CompressionType=string</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// JSON syntax for these attributes is as follows: <code>{ "ServiceAccessRoleArn": "string",
        /// "BucketName": "string", "CompressionType": "none"|"gzip" } </code> 
        /// </para>
        /// </summary>
        public DmsTransferSettings DmsTransferSettings
        {
            get { return this._dmsTransferSettings; }
            set { this._dmsTransferSettings = value; }
        }

        // Check to see if DmsTransferSettings property is set
        internal bool IsSetDmsTransferSettings()
        {
            return this._dmsTransferSettings != null;
        }

        /// <summary>
        /// Gets and sets the property DynamoDbSettings. 
        /// <para>
        /// Settings in JSON format for the target Amazon DynamoDB endpoint. For more information
        /// about the available settings, see <a href="http://docs.aws.amazon.com/dms/latest/userguide/CHAP_Target.DynamoDB.html">Using
        /// Object Mapping to Migrate Data to DynamoDB</a> in the <i>AWS Database Migration Service
        /// User Guide.</i> 
        /// </para>
        /// </summary>
        public DynamoDbSettings DynamoDbSettings
        {
            get { return this._dynamoDbSettings; }
            set { this._dynamoDbSettings = value; }
        }

        // Check to see if DynamoDbSettings property is set
        internal bool IsSetDynamoDbSettings()
        {
            return this._dynamoDbSettings != null;
        }

        /// <summary>
        /// Gets and sets the property ElasticsearchSettings. 
        /// <para>
        /// Settings in JSON format for the target Elasticsearch endpoint. For more information
        /// about the available settings, see <a href="http://docs.aws.amazon.com/dms/latest/userguide/CHAP_Target.Elasticsearch.html#CHAP_Target.Elasticsearch.Configuration">Extra
        /// Connection Attributes When Using Elasticsearch as a Target for AWS DMS</a> in the
        /// <i>AWS Database Migration User Guide.</i> 
        /// </para>
        /// </summary>
        public ElasticsearchSettings ElasticsearchSettings
        {
            get { return this._elasticsearchSettings; }
            set { this._elasticsearchSettings = value; }
        }

        // Check to see if ElasticsearchSettings property is set
        internal bool IsSetElasticsearchSettings()
        {
            return this._elasticsearchSettings != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointIdentifier. 
        /// <para>
        /// The database endpoint identifier. Identifiers must begin with a letter; must contain
        /// only ASCII letters, digits, and hyphens; and must not end with a hyphen or contain
        /// two consecutive hyphens.
        /// </para>
        /// </summary>
        public string EndpointIdentifier
        {
            get { return this._endpointIdentifier; }
            set { this._endpointIdentifier = value; }
        }

        // Check to see if EndpointIdentifier property is set
        internal bool IsSetEndpointIdentifier()
        {
            return this._endpointIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointType. 
        /// <para>
        /// The type of endpoint.
        /// </para>
        /// </summary>
        public ReplicationEndpointTypeValue EndpointType
        {
            get { return this._endpointType; }
            set { this._endpointType = value; }
        }

        // Check to see if EndpointType property is set
        internal bool IsSetEndpointType()
        {
            return this._endpointType != null;
        }

        /// <summary>
        /// Gets and sets the property EngineName. 
        /// <para>
        /// The type of engine for the endpoint. Valid values, depending on the <code>EndPointType</code>
        /// value, include <code>mysql</code>, <code>oracle</code>, <code>postgres</code>, <code>mariadb</code>,
        /// <code>aurora</code>, <code>aurora-postgresql</code>, <code>redshift</code>, <code>s3</code>,
        /// <code>db2</code>, <code>azuredb</code>, <code>sybase</code>, <code>dynamodb</code>,
        /// <code>mongodb</code>, and <code>sqlserver</code>.
        /// </para>
        /// </summary>
        public string EngineName
        {
            get { return this._engineName; }
            set { this._engineName = value; }
        }

        // Check to see if EngineName property is set
        internal bool IsSetEngineName()
        {
            return this._engineName != null;
        }

        /// <summary>
        /// Gets and sets the property ExternalTableDefinition. 
        /// <para>
        /// The external table definition. 
        /// </para>
        /// </summary>
        public string ExternalTableDefinition
        {
            get { return this._externalTableDefinition; }
            set { this._externalTableDefinition = value; }
        }

        // Check to see if ExternalTableDefinition property is set
        internal bool IsSetExternalTableDefinition()
        {
            return this._externalTableDefinition != null;
        }

        /// <summary>
        /// Gets and sets the property ExtraConnectionAttributes. 
        /// <para>
        /// Additional attributes associated with the connection.
        /// </para>
        /// </summary>
        public string ExtraConnectionAttributes
        {
            get { return this._extraConnectionAttributes; }
            set { this._extraConnectionAttributes = value; }
        }

        // Check to see if ExtraConnectionAttributes property is set
        internal bool IsSetExtraConnectionAttributes()
        {
            return this._extraConnectionAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property KinesisSettings. 
        /// <para>
        /// Settings in JSON format for the target Amazon Kinesis Data Streams endpoint. For more
        /// information about the available settings, see <a href="http://docs.aws.amazon.com/dms/latest/userguide/CHAP_Target.Kinesis.html#CHAP_Target.Kinesis.ObjectMapping
        /// ">Using Object Mapping to Migrate Data to a Kinesis Data Stream</a> in the <i>AWS
        /// Database Migration User Guide.</i> 
        /// </para>
        /// </summary>
        public KinesisSettings KinesisSettings
        {
            get { return this._kinesisSettings; }
            set { this._kinesisSettings = value; }
        }

        // Check to see if KinesisSettings property is set
        internal bool IsSetKinesisSettings()
        {
            return this._kinesisSettings != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The AWS KMS key identifier to use to encrypt the connection parameters. If you don't
        /// specify a value for the <code>KmsKeyId</code> parameter, then AWS DMS uses your default
        /// encryption key. AWS KMS creates the default encryption key for your AWS account. Your
        /// AWS account has a different default encryption key for each AWS Region.
        /// </para>
        /// </summary>
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property MongoDbSettings. 
        /// <para>
        /// Settings in JSON format for the source MongoDB endpoint. For more information about
        /// the available settings, see the configuration properties section in <a href="http://docs.aws.amazon.com/dms/latest/userguide/CHAP_Source.MongoDB.html">
        /// Using MongoDB as a Target for AWS Database Migration Service</a> in the <i>AWS Database
        /// Migration Service User Guide.</i> 
        /// </para>
        /// </summary>
        public MongoDbSettings MongoDbSettings
        {
            get { return this._mongoDbSettings; }
            set { this._mongoDbSettings = value; }
        }

        // Check to see if MongoDbSettings property is set
        internal bool IsSetMongoDbSettings()
        {
            return this._mongoDbSettings != null;
        }

        /// <summary>
        /// Gets and sets the property Password. 
        /// <para>
        /// The password to be used to log in to the endpoint database.
        /// </para>
        /// </summary>
        public string Password
        {
            get { return this._password; }
            set { this._password = value; }
        }

        // Check to see if Password property is set
        internal bool IsSetPassword()
        {
            return this._password != null;
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port used by the endpoint database.
        /// </para>
        /// </summary>
        public int Port
        {
            get { return this._port.GetValueOrDefault(); }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property S3Settings. 
        /// <para>
        /// Settings in JSON format for the target Amazon S3 endpoint. For more information about
        /// the available settings, see <a href="http://docs.aws.amazon.com/dms/latest/userguide/CHAP_Target.S3.html#CHAP_Target.S3.Configuring">Extra
        /// Connection Attributes When Using Amazon S3 as a Target for AWS DMS</a> in the <i>AWS
        /// Database Migration Service User Guide.</i> 
        /// </para>
        /// </summary>
        public S3Settings S3Settings
        {
            get { return this._s3Settings; }
            set { this._s3Settings = value; }
        }

        // Check to see if S3Settings property is set
        internal bool IsSetS3Settings()
        {
            return this._s3Settings != null;
        }

        /// <summary>
        /// Gets and sets the property ServerName. 
        /// <para>
        /// The name of the server where the endpoint database resides.
        /// </para>
        /// </summary>
        public string ServerName
        {
            get { return this._serverName; }
            set { this._serverName = value; }
        }

        // Check to see if ServerName property is set
        internal bool IsSetServerName()
        {
            return this._serverName != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceAccessRoleArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) for the service access role that you want to use to
        /// create the endpoint. 
        /// </para>
        /// </summary>
        public string ServiceAccessRoleArn
        {
            get { return this._serviceAccessRoleArn; }
            set { this._serviceAccessRoleArn = value; }
        }

        // Check to see if ServiceAccessRoleArn property is set
        internal bool IsSetServiceAccessRoleArn()
        {
            return this._serviceAccessRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property SslMode. 
        /// <para>
        /// The Secure Sockets Layer (SSL) mode to use for the SSL connection. The SSL mode can
        /// be one of four values: <code>none</code>, <code>require</code>, <code>verify-ca</code>,
        /// <code>verify-full</code>. The default value is <code>none</code>.
        /// </para>
        /// </summary>
        public DmsSslModeValue SslMode
        {
            get { return this._sslMode; }
            set { this._sslMode = value; }
        }

        // Check to see if SslMode property is set
        internal bool IsSetSslMode()
        {
            return this._sslMode != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to be added to the endpoint.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// The user name to be used to log in to the endpoint database.
        /// </para>
        /// </summary>
        public string Username
        {
            get { return this._username; }
            set { this._username = value; }
        }

        // Check to see if Username property is set
        internal bool IsSetUsername()
        {
            return this._username != null;
        }

    }
}