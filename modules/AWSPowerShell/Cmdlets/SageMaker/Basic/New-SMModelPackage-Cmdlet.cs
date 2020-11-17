/*******************************************************************************
 *  Copyright 2012-2019 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *
 *  AWS Tools for Windows (TM) PowerShell (TM)
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using Amazon.PowerShell.Common;
using Amazon.Runtime;
using Amazon.SageMaker;
using Amazon.SageMaker.Model;

namespace Amazon.PowerShell.Cmdlets.SM
{
    /// <summary>
    /// Creates a model package that you can use to create Amazon SageMaker models or list
    /// on AWS Marketplace, or a versioned model that is part of a model group. Buyers can
    /// subscribe to model packages listed on AWS Marketplace to create models in Amazon SageMaker.
    /// 
    ///  
    /// <para>
    /// To create a model package by specifying a Docker container that contains your inference
    /// code and the Amazon S3 location of your model artifacts, provide values for <code>InferenceSpecification</code>.
    /// To create a model from an algorithm resource that you created or subscribed to in
    /// AWS Marketplace, provide a value for <code>SourceAlgorithmSpecification</code>.
    /// </para><note><para>
    /// There are two types of model packages:
    /// </para><ul><li><para>
    /// Versioned - a model that is part of a model group in the model registry.
    /// </para></li><li><para>
    /// Unversioned - a model package that is not part of a model group.
    /// </para></li></ul></note>
    /// </summary>
    [Cmdlet("New", "SMModelPackage", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("System.String")]
    [AWSCmdlet("Calls the Amazon SageMaker Service CreateModelPackage API operation.", Operation = new[] {"CreateModelPackage"}, SelectReturnType = typeof(Amazon.SageMaker.Model.CreateModelPackageResponse))]
    [AWSCmdletOutput("System.String or Amazon.SageMaker.Model.CreateModelPackageResponse",
        "This cmdlet returns a System.String object.",
        "The service call response (type Amazon.SageMaker.Model.CreateModelPackageResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class NewSMModelPackageCmdlet : AmazonSageMakerClientCmdlet, IExecutor
    {
        
        #region Parameter CertifyForMarketplace
        /// <summary>
        /// <para>
        /// <para>Whether to certify the model package for listing on AWS Marketplace.</para><para>This parameter is optional for unversioned models, and does not apply to versioned
        /// models.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? CertifyForMarketplace { get; set; }
        #endregion
        
        #region Parameter MetadataProperties_CommitId
        /// <summary>
        /// <para>
        /// <para>The commit ID.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String MetadataProperties_CommitId { get; set; }
        #endregion
        
        #region Parameter InferenceSpecification_Container
        /// <summary>
        /// <para>
        /// <para>The Amazon ECR registry path of the Docker image that contains the inference code.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("InferenceSpecification_Containers")]
        public Amazon.SageMaker.Model.ModelPackageContainerDefinition[] InferenceSpecification_Container { get; set; }
        #endregion
        
        #region Parameter ModelMetrics_Bias_Report_ContentDigest
        /// <summary>
        /// <para>
        /// The service has not provided documentation for this parameter; please refer to the service's API reference documentation for the latest available information.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Bias_Report_ContentDigest")]
        public System.String ModelMetrics_Bias_Report_ContentDigest { get; set; }
        #endregion
        
        #region Parameter ModelMetrics_Explainability_Report_ContentDigest
        /// <summary>
        /// <para>
        /// The service has not provided documentation for this parameter; please refer to the service's API reference documentation for the latest available information.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ModelMetrics_Explainability_Report_ContentDigest { get; set; }
        #endregion
        
        #region Parameter ModelMetrics_ModelDataQuality_Constraints_ContentDigest
        /// <summary>
        /// <para>
        /// The service has not provided documentation for this parameter; please refer to the service's API reference documentation for the latest available information.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("ModelDataQuality_Constraints_ContentDigest")]
        public System.String ModelMetrics_ModelDataQuality_Constraints_ContentDigest { get; set; }
        #endregion
        
        #region Parameter ModelMetrics_ModelDataQuality_Statistics_ContentDigest
        /// <summary>
        /// <para>
        /// The service has not provided documentation for this parameter; please refer to the service's API reference documentation for the latest available information.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("ModelDataQuality_Statistics_ContentDigest")]
        public System.String ModelMetrics_ModelDataQuality_Statistics_ContentDigest { get; set; }
        #endregion
        
        #region Parameter ModelMetrics_ModelQuality_Constraints_ContentDigest
        /// <summary>
        /// <para>
        /// The service has not provided documentation for this parameter; please refer to the service's API reference documentation for the latest available information.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ModelMetrics_ModelQuality_Constraints_ContentDigest { get; set; }
        #endregion
        
        #region Parameter ModelMetrics_ModelQuality_Statistics_ContentDigest
        /// <summary>
        /// <para>
        /// The service has not provided documentation for this parameter; please refer to the service's API reference documentation for the latest available information.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ModelMetrics_ModelQuality_Statistics_ContentDigest { get; set; }
        #endregion
        
        #region Parameter ModelMetrics_Bias_Report_ContentType
        /// <summary>
        /// <para>
        /// The service has not provided documentation for this parameter; please refer to the service's API reference documentation for the latest available information.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Bias_Report_ContentType")]
        public System.String ModelMetrics_Bias_Report_ContentType { get; set; }
        #endregion
        
        #region Parameter ModelMetrics_Explainability_Report_ContentType
        /// <summary>
        /// <para>
        /// The service has not provided documentation for this parameter; please refer to the service's API reference documentation for the latest available information.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ModelMetrics_Explainability_Report_ContentType { get; set; }
        #endregion
        
        #region Parameter ModelMetrics_ModelDataQuality_Constraints_ContentType
        /// <summary>
        /// <para>
        /// The service has not provided documentation for this parameter; please refer to the service's API reference documentation for the latest available information.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("ModelDataQuality_Constraints_ContentType")]
        public System.String ModelMetrics_ModelDataQuality_Constraints_ContentType { get; set; }
        #endregion
        
        #region Parameter ModelMetrics_ModelDataQuality_Statistics_ContentType
        /// <summary>
        /// <para>
        /// The service has not provided documentation for this parameter; please refer to the service's API reference documentation for the latest available information.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("ModelDataQuality_Statistics_ContentType")]
        public System.String ModelMetrics_ModelDataQuality_Statistics_ContentType { get; set; }
        #endregion
        
        #region Parameter ModelMetrics_ModelQuality_Constraints_ContentType
        /// <summary>
        /// <para>
        /// The service has not provided documentation for this parameter; please refer to the service's API reference documentation for the latest available information.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ModelMetrics_ModelQuality_Constraints_ContentType { get; set; }
        #endregion
        
        #region Parameter ModelMetrics_ModelQuality_Statistics_ContentType
        /// <summary>
        /// <para>
        /// The service has not provided documentation for this parameter; please refer to the service's API reference documentation for the latest available information.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ModelMetrics_ModelQuality_Statistics_ContentType { get; set; }
        #endregion
        
        #region Parameter MetadataProperties_GeneratedBy
        /// <summary>
        /// <para>
        /// <para>The entity this entity was generated by.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String MetadataProperties_GeneratedBy { get; set; }
        #endregion
        
        #region Parameter ModelApprovalStatus
        /// <summary>
        /// <para>
        /// <para>Whether the model is approved for deployment.</para><para>This parameter is optional for versioned models, and does not apply to unversioned
        /// models.</para><para>For versioned models, the value of this parameter must be set to <code>Approved</code>
        /// to deploy the model.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.SageMaker.ModelApprovalStatus")]
        public Amazon.SageMaker.ModelApprovalStatus ModelApprovalStatus { get; set; }
        #endregion
        
        #region Parameter ModelPackageDescription
        /// <summary>
        /// <para>
        /// <para>A description of the model package.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ModelPackageDescription { get; set; }
        #endregion
        
        #region Parameter ModelPackageGroupName
        /// <summary>
        /// <para>
        /// <para>The name of the model group that this model version belongs to.</para><para>This parameter is required for versioned models, and does not apply to unversioned
        /// models.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ModelPackageGroupName { get; set; }
        #endregion
        
        #region Parameter ModelPackageName
        /// <summary>
        /// <para>
        /// <para>The name of the model package. The name must have 1 to 63 characters. Valid characters
        /// are a-z, A-Z, 0-9, and - (hyphen).</para><para>This parameter is required for unversioned models. It is not applicable to versioned
        /// models.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true)]
        public System.String ModelPackageName { get; set; }
        #endregion
        
        #region Parameter MetadataProperties_ProjectId
        /// <summary>
        /// <para>
        /// <para>The project ID.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String MetadataProperties_ProjectId { get; set; }
        #endregion
        
        #region Parameter MetadataProperties_Repository
        /// <summary>
        /// <para>
        /// <para>The repository.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String MetadataProperties_Repository { get; set; }
        #endregion
        
        #region Parameter ModelMetrics_Bias_Report_S3Uri
        /// <summary>
        /// <para>
        /// The service has not provided documentation for this parameter; please refer to the service's API reference documentation for the latest available information.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Bias_Report_S3Uri")]
        public System.String ModelMetrics_Bias_Report_S3Uri { get; set; }
        #endregion
        
        #region Parameter ModelMetrics_Explainability_Report_S3Uri
        /// <summary>
        /// <para>
        /// The service has not provided documentation for this parameter; please refer to the service's API reference documentation for the latest available information.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ModelMetrics_Explainability_Report_S3Uri { get; set; }
        #endregion
        
        #region Parameter ModelMetrics_ModelDataQuality_Constraints_S3Uri
        /// <summary>
        /// <para>
        /// The service has not provided documentation for this parameter; please refer to the service's API reference documentation for the latest available information.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("ModelDataQuality_Constraints_S3Uri")]
        public System.String ModelMetrics_ModelDataQuality_Constraints_S3Uri { get; set; }
        #endregion
        
        #region Parameter ModelMetrics_ModelDataQuality_Statistics_S3Uri
        /// <summary>
        /// <para>
        /// The service has not provided documentation for this parameter; please refer to the service's API reference documentation for the latest available information.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("ModelDataQuality_Statistics_S3Uri")]
        public System.String ModelMetrics_ModelDataQuality_Statistics_S3Uri { get; set; }
        #endregion
        
        #region Parameter ModelMetrics_ModelQuality_Constraints_S3Uri
        /// <summary>
        /// <para>
        /// The service has not provided documentation for this parameter; please refer to the service's API reference documentation for the latest available information.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ModelMetrics_ModelQuality_Constraints_S3Uri { get; set; }
        #endregion
        
        #region Parameter ModelMetrics_ModelQuality_Statistics_S3Uri
        /// <summary>
        /// <para>
        /// The service has not provided documentation for this parameter; please refer to the service's API reference documentation for the latest available information.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ModelMetrics_ModelQuality_Statistics_S3Uri { get; set; }
        #endregion
        
        #region Parameter SourceAlgorithmSpecification_SourceAlgorithm
        /// <summary>
        /// <para>
        /// <para>A list of the algorithms that were used to create a model package.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("SourceAlgorithmSpecification_SourceAlgorithms")]
        public Amazon.SageMaker.Model.SourceAlgorithm[] SourceAlgorithmSpecification_SourceAlgorithm { get; set; }
        #endregion
        
        #region Parameter InferenceSpecification_SupportedContentType
        /// <summary>
        /// <para>
        /// <para>The supported MIME types for the input data.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("InferenceSpecification_SupportedContentTypes")]
        public System.String[] InferenceSpecification_SupportedContentType { get; set; }
        #endregion
        
        #region Parameter InferenceSpecification_SupportedRealtimeInferenceInstanceType
        /// <summary>
        /// <para>
        /// <para>A list of the instance types that are used to generate inferences in real-time.</para><para>This parameter is required for unversioned models, and optional for versioned models.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("InferenceSpecification_SupportedRealtimeInferenceInstanceTypes")]
        public System.String[] InferenceSpecification_SupportedRealtimeInferenceInstanceType { get; set; }
        #endregion
        
        #region Parameter InferenceSpecification_SupportedResponseMIMEType
        /// <summary>
        /// <para>
        /// <para>The supported MIME types for the output data.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("InferenceSpecification_SupportedResponseMIMETypes")]
        public System.String[] InferenceSpecification_SupportedResponseMIMEType { get; set; }
        #endregion
        
        #region Parameter InferenceSpecification_SupportedTransformInstanceType
        /// <summary>
        /// <para>
        /// <para>A list of the instance types on which a transformation job can be run or on which
        /// an endpoint can be deployed.</para><para>This parameter is required for unversioned models, and optional for versioned models.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("InferenceSpecification_SupportedTransformInstanceTypes")]
        public System.String[] InferenceSpecification_SupportedTransformInstanceType { get; set; }
        #endregion
        
        #region Parameter Tag
        /// <summary>
        /// <para>
        /// <para>A list of key value pairs associated with the model. For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging AWS
        /// resources</a> in the <i>AWS General Reference Guide</i>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Tags")]
        public Amazon.SageMaker.Model.Tag[] Tag { get; set; }
        #endregion
        
        #region Parameter ValidationSpecification_ValidationProfile
        /// <summary>
        /// <para>
        /// <para>An array of <code>ModelPackageValidationProfile</code> objects, each of which specifies
        /// a batch transform job that Amazon SageMaker runs to validate your model package.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("ValidationSpecification_ValidationProfiles")]
        public Amazon.SageMaker.Model.ModelPackageValidationProfile[] ValidationSpecification_ValidationProfile { get; set; }
        #endregion
        
        #region Parameter ValidationSpecification_ValidationRole
        /// <summary>
        /// <para>
        /// <para>The IAM roles to be used for the validation of the model package.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ValidationSpecification_ValidationRole { get; set; }
        #endregion
        
        #region Parameter ClientToken
        /// <summary>
        /// <para>
        /// <para>A unique token that guarantees that the call to this API is idempotent.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ClientToken { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'ModelPackageArn'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.SageMaker.Model.CreateModelPackageResponse).
        /// Specifying the name of a property of type Amazon.SageMaker.Model.CreateModelPackageResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "ModelPackageArn";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the ModelPackageName parameter.
        /// The -PassThru parameter is deprecated, use -Select '^ModelPackageName' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^ModelPackageName' instead. This parameter will be removed in a future version.")]
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter PassThru { get; set; }
        #endregion
        
        #region Parameter Force
        /// <summary>
        /// This parameter overrides confirmation prompts to force 
        /// the cmdlet to continue its operation. This parameter should always
        /// be used with caution.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter Force { get; set; }
        #endregion
        
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.ModelPackageName), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "New-SMModelPackage (CreateModelPackage)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.SageMaker.Model.CreateModelPackageResponse, NewSMModelPackageCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.ModelPackageName;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.CertifyForMarketplace = this.CertifyForMarketplace;
            context.ClientToken = this.ClientToken;
            if (this.InferenceSpecification_Container != null)
            {
                context.InferenceSpecification_Container = new List<Amazon.SageMaker.Model.ModelPackageContainerDefinition>(this.InferenceSpecification_Container);
            }
            if (this.InferenceSpecification_SupportedContentType != null)
            {
                context.InferenceSpecification_SupportedContentType = new List<System.String>(this.InferenceSpecification_SupportedContentType);
            }
            if (this.InferenceSpecification_SupportedRealtimeInferenceInstanceType != null)
            {
                context.InferenceSpecification_SupportedRealtimeInferenceInstanceType = new List<System.String>(this.InferenceSpecification_SupportedRealtimeInferenceInstanceType);
            }
            if (this.InferenceSpecification_SupportedResponseMIMEType != null)
            {
                context.InferenceSpecification_SupportedResponseMIMEType = new List<System.String>(this.InferenceSpecification_SupportedResponseMIMEType);
            }
            if (this.InferenceSpecification_SupportedTransformInstanceType != null)
            {
                context.InferenceSpecification_SupportedTransformInstanceType = new List<System.String>(this.InferenceSpecification_SupportedTransformInstanceType);
            }
            context.MetadataProperties_CommitId = this.MetadataProperties_CommitId;
            context.MetadataProperties_GeneratedBy = this.MetadataProperties_GeneratedBy;
            context.MetadataProperties_ProjectId = this.MetadataProperties_ProjectId;
            context.MetadataProperties_Repository = this.MetadataProperties_Repository;
            context.ModelApprovalStatus = this.ModelApprovalStatus;
            context.ModelMetrics_Bias_Report_ContentDigest = this.ModelMetrics_Bias_Report_ContentDigest;
            context.ModelMetrics_Bias_Report_ContentType = this.ModelMetrics_Bias_Report_ContentType;
            context.ModelMetrics_Bias_Report_S3Uri = this.ModelMetrics_Bias_Report_S3Uri;
            context.ModelMetrics_Explainability_Report_ContentDigest = this.ModelMetrics_Explainability_Report_ContentDigest;
            context.ModelMetrics_Explainability_Report_ContentType = this.ModelMetrics_Explainability_Report_ContentType;
            context.ModelMetrics_Explainability_Report_S3Uri = this.ModelMetrics_Explainability_Report_S3Uri;
            context.ModelMetrics_ModelDataQuality_Constraints_ContentDigest = this.ModelMetrics_ModelDataQuality_Constraints_ContentDigest;
            context.ModelMetrics_ModelDataQuality_Constraints_ContentType = this.ModelMetrics_ModelDataQuality_Constraints_ContentType;
            context.ModelMetrics_ModelDataQuality_Constraints_S3Uri = this.ModelMetrics_ModelDataQuality_Constraints_S3Uri;
            context.ModelMetrics_ModelDataQuality_Statistics_ContentDigest = this.ModelMetrics_ModelDataQuality_Statistics_ContentDigest;
            context.ModelMetrics_ModelDataQuality_Statistics_ContentType = this.ModelMetrics_ModelDataQuality_Statistics_ContentType;
            context.ModelMetrics_ModelDataQuality_Statistics_S3Uri = this.ModelMetrics_ModelDataQuality_Statistics_S3Uri;
            context.ModelMetrics_ModelQuality_Constraints_ContentDigest = this.ModelMetrics_ModelQuality_Constraints_ContentDigest;
            context.ModelMetrics_ModelQuality_Constraints_ContentType = this.ModelMetrics_ModelQuality_Constraints_ContentType;
            context.ModelMetrics_ModelQuality_Constraints_S3Uri = this.ModelMetrics_ModelQuality_Constraints_S3Uri;
            context.ModelMetrics_ModelQuality_Statistics_ContentDigest = this.ModelMetrics_ModelQuality_Statistics_ContentDigest;
            context.ModelMetrics_ModelQuality_Statistics_ContentType = this.ModelMetrics_ModelQuality_Statistics_ContentType;
            context.ModelMetrics_ModelQuality_Statistics_S3Uri = this.ModelMetrics_ModelQuality_Statistics_S3Uri;
            context.ModelPackageDescription = this.ModelPackageDescription;
            context.ModelPackageGroupName = this.ModelPackageGroupName;
            context.ModelPackageName = this.ModelPackageName;
            if (this.SourceAlgorithmSpecification_SourceAlgorithm != null)
            {
                context.SourceAlgorithmSpecification_SourceAlgorithm = new List<Amazon.SageMaker.Model.SourceAlgorithm>(this.SourceAlgorithmSpecification_SourceAlgorithm);
            }
            if (this.Tag != null)
            {
                context.Tag = new List<Amazon.SageMaker.Model.Tag>(this.Tag);
            }
            if (this.ValidationSpecification_ValidationProfile != null)
            {
                context.ValidationSpecification_ValidationProfile = new List<Amazon.SageMaker.Model.ModelPackageValidationProfile>(this.ValidationSpecification_ValidationProfile);
            }
            context.ValidationSpecification_ValidationRole = this.ValidationSpecification_ValidationRole;
            
            // allow further manipulation of loaded context prior to processing
            PostExecutionContextLoad(context);
            
            var output = Execute(context) as CmdletOutput;
            ProcessOutput(output);
        }
        
        #region IExecutor Members
        
        public object Execute(ExecutorContext context)
        {
            var cmdletContext = context as CmdletContext;
            // create request
            var request = new Amazon.SageMaker.Model.CreateModelPackageRequest();
            
            if (cmdletContext.CertifyForMarketplace != null)
            {
                request.CertifyForMarketplace = cmdletContext.CertifyForMarketplace.Value;
            }
            if (cmdletContext.ClientToken != null)
            {
                request.ClientToken = cmdletContext.ClientToken;
            }
            
             // populate InferenceSpecification
            var requestInferenceSpecificationIsNull = true;
            request.InferenceSpecification = new Amazon.SageMaker.Model.InferenceSpecification();
            List<Amazon.SageMaker.Model.ModelPackageContainerDefinition> requestInferenceSpecification_inferenceSpecification_Container = null;
            if (cmdletContext.InferenceSpecification_Container != null)
            {
                requestInferenceSpecification_inferenceSpecification_Container = cmdletContext.InferenceSpecification_Container;
            }
            if (requestInferenceSpecification_inferenceSpecification_Container != null)
            {
                request.InferenceSpecification.Containers = requestInferenceSpecification_inferenceSpecification_Container;
                requestInferenceSpecificationIsNull = false;
            }
            List<System.String> requestInferenceSpecification_inferenceSpecification_SupportedContentType = null;
            if (cmdletContext.InferenceSpecification_SupportedContentType != null)
            {
                requestInferenceSpecification_inferenceSpecification_SupportedContentType = cmdletContext.InferenceSpecification_SupportedContentType;
            }
            if (requestInferenceSpecification_inferenceSpecification_SupportedContentType != null)
            {
                request.InferenceSpecification.SupportedContentTypes = requestInferenceSpecification_inferenceSpecification_SupportedContentType;
                requestInferenceSpecificationIsNull = false;
            }
            List<System.String> requestInferenceSpecification_inferenceSpecification_SupportedRealtimeInferenceInstanceType = null;
            if (cmdletContext.InferenceSpecification_SupportedRealtimeInferenceInstanceType != null)
            {
                requestInferenceSpecification_inferenceSpecification_SupportedRealtimeInferenceInstanceType = cmdletContext.InferenceSpecification_SupportedRealtimeInferenceInstanceType;
            }
            if (requestInferenceSpecification_inferenceSpecification_SupportedRealtimeInferenceInstanceType != null)
            {
                request.InferenceSpecification.SupportedRealtimeInferenceInstanceTypes = requestInferenceSpecification_inferenceSpecification_SupportedRealtimeInferenceInstanceType;
                requestInferenceSpecificationIsNull = false;
            }
            List<System.String> requestInferenceSpecification_inferenceSpecification_SupportedResponseMIMEType = null;
            if (cmdletContext.InferenceSpecification_SupportedResponseMIMEType != null)
            {
                requestInferenceSpecification_inferenceSpecification_SupportedResponseMIMEType = cmdletContext.InferenceSpecification_SupportedResponseMIMEType;
            }
            if (requestInferenceSpecification_inferenceSpecification_SupportedResponseMIMEType != null)
            {
                request.InferenceSpecification.SupportedResponseMIMETypes = requestInferenceSpecification_inferenceSpecification_SupportedResponseMIMEType;
                requestInferenceSpecificationIsNull = false;
            }
            List<System.String> requestInferenceSpecification_inferenceSpecification_SupportedTransformInstanceType = null;
            if (cmdletContext.InferenceSpecification_SupportedTransformInstanceType != null)
            {
                requestInferenceSpecification_inferenceSpecification_SupportedTransformInstanceType = cmdletContext.InferenceSpecification_SupportedTransformInstanceType;
            }
            if (requestInferenceSpecification_inferenceSpecification_SupportedTransformInstanceType != null)
            {
                request.InferenceSpecification.SupportedTransformInstanceTypes = requestInferenceSpecification_inferenceSpecification_SupportedTransformInstanceType;
                requestInferenceSpecificationIsNull = false;
            }
             // determine if request.InferenceSpecification should be set to null
            if (requestInferenceSpecificationIsNull)
            {
                request.InferenceSpecification = null;
            }
            
             // populate MetadataProperties
            var requestMetadataPropertiesIsNull = true;
            request.MetadataProperties = new Amazon.SageMaker.Model.MetadataProperties();
            System.String requestMetadataProperties_metadataProperties_CommitId = null;
            if (cmdletContext.MetadataProperties_CommitId != null)
            {
                requestMetadataProperties_metadataProperties_CommitId = cmdletContext.MetadataProperties_CommitId;
            }
            if (requestMetadataProperties_metadataProperties_CommitId != null)
            {
                request.MetadataProperties.CommitId = requestMetadataProperties_metadataProperties_CommitId;
                requestMetadataPropertiesIsNull = false;
            }
            System.String requestMetadataProperties_metadataProperties_GeneratedBy = null;
            if (cmdletContext.MetadataProperties_GeneratedBy != null)
            {
                requestMetadataProperties_metadataProperties_GeneratedBy = cmdletContext.MetadataProperties_GeneratedBy;
            }
            if (requestMetadataProperties_metadataProperties_GeneratedBy != null)
            {
                request.MetadataProperties.GeneratedBy = requestMetadataProperties_metadataProperties_GeneratedBy;
                requestMetadataPropertiesIsNull = false;
            }
            System.String requestMetadataProperties_metadataProperties_ProjectId = null;
            if (cmdletContext.MetadataProperties_ProjectId != null)
            {
                requestMetadataProperties_metadataProperties_ProjectId = cmdletContext.MetadataProperties_ProjectId;
            }
            if (requestMetadataProperties_metadataProperties_ProjectId != null)
            {
                request.MetadataProperties.ProjectId = requestMetadataProperties_metadataProperties_ProjectId;
                requestMetadataPropertiesIsNull = false;
            }
            System.String requestMetadataProperties_metadataProperties_Repository = null;
            if (cmdletContext.MetadataProperties_Repository != null)
            {
                requestMetadataProperties_metadataProperties_Repository = cmdletContext.MetadataProperties_Repository;
            }
            if (requestMetadataProperties_metadataProperties_Repository != null)
            {
                request.MetadataProperties.Repository = requestMetadataProperties_metadataProperties_Repository;
                requestMetadataPropertiesIsNull = false;
            }
             // determine if request.MetadataProperties should be set to null
            if (requestMetadataPropertiesIsNull)
            {
                request.MetadataProperties = null;
            }
            if (cmdletContext.ModelApprovalStatus != null)
            {
                request.ModelApprovalStatus = cmdletContext.ModelApprovalStatus;
            }
            
             // populate ModelMetrics
            var requestModelMetricsIsNull = true;
            request.ModelMetrics = new Amazon.SageMaker.Model.ModelMetrics();
            Amazon.SageMaker.Model.Bias requestModelMetrics_modelMetrics_Bias = null;
            
             // populate Bias
            var requestModelMetrics_modelMetrics_BiasIsNull = true;
            requestModelMetrics_modelMetrics_Bias = new Amazon.SageMaker.Model.Bias();
            Amazon.SageMaker.Model.MetricsSource requestModelMetrics_modelMetrics_Bias_modelMetrics_Bias_Report = null;
            
             // populate Report
            var requestModelMetrics_modelMetrics_Bias_modelMetrics_Bias_ReportIsNull = true;
            requestModelMetrics_modelMetrics_Bias_modelMetrics_Bias_Report = new Amazon.SageMaker.Model.MetricsSource();
            System.String requestModelMetrics_modelMetrics_Bias_modelMetrics_Bias_Report_modelMetrics_Bias_Report_ContentDigest = null;
            if (cmdletContext.ModelMetrics_Bias_Report_ContentDigest != null)
            {
                requestModelMetrics_modelMetrics_Bias_modelMetrics_Bias_Report_modelMetrics_Bias_Report_ContentDigest = cmdletContext.ModelMetrics_Bias_Report_ContentDigest;
            }
            if (requestModelMetrics_modelMetrics_Bias_modelMetrics_Bias_Report_modelMetrics_Bias_Report_ContentDigest != null)
            {
                requestModelMetrics_modelMetrics_Bias_modelMetrics_Bias_Report.ContentDigest = requestModelMetrics_modelMetrics_Bias_modelMetrics_Bias_Report_modelMetrics_Bias_Report_ContentDigest;
                requestModelMetrics_modelMetrics_Bias_modelMetrics_Bias_ReportIsNull = false;
            }
            System.String requestModelMetrics_modelMetrics_Bias_modelMetrics_Bias_Report_modelMetrics_Bias_Report_ContentType = null;
            if (cmdletContext.ModelMetrics_Bias_Report_ContentType != null)
            {
                requestModelMetrics_modelMetrics_Bias_modelMetrics_Bias_Report_modelMetrics_Bias_Report_ContentType = cmdletContext.ModelMetrics_Bias_Report_ContentType;
            }
            if (requestModelMetrics_modelMetrics_Bias_modelMetrics_Bias_Report_modelMetrics_Bias_Report_ContentType != null)
            {
                requestModelMetrics_modelMetrics_Bias_modelMetrics_Bias_Report.ContentType = requestModelMetrics_modelMetrics_Bias_modelMetrics_Bias_Report_modelMetrics_Bias_Report_ContentType;
                requestModelMetrics_modelMetrics_Bias_modelMetrics_Bias_ReportIsNull = false;
            }
            System.String requestModelMetrics_modelMetrics_Bias_modelMetrics_Bias_Report_modelMetrics_Bias_Report_S3Uri = null;
            if (cmdletContext.ModelMetrics_Bias_Report_S3Uri != null)
            {
                requestModelMetrics_modelMetrics_Bias_modelMetrics_Bias_Report_modelMetrics_Bias_Report_S3Uri = cmdletContext.ModelMetrics_Bias_Report_S3Uri;
            }
            if (requestModelMetrics_modelMetrics_Bias_modelMetrics_Bias_Report_modelMetrics_Bias_Report_S3Uri != null)
            {
                requestModelMetrics_modelMetrics_Bias_modelMetrics_Bias_Report.S3Uri = requestModelMetrics_modelMetrics_Bias_modelMetrics_Bias_Report_modelMetrics_Bias_Report_S3Uri;
                requestModelMetrics_modelMetrics_Bias_modelMetrics_Bias_ReportIsNull = false;
            }
             // determine if requestModelMetrics_modelMetrics_Bias_modelMetrics_Bias_Report should be set to null
            if (requestModelMetrics_modelMetrics_Bias_modelMetrics_Bias_ReportIsNull)
            {
                requestModelMetrics_modelMetrics_Bias_modelMetrics_Bias_Report = null;
            }
            if (requestModelMetrics_modelMetrics_Bias_modelMetrics_Bias_Report != null)
            {
                requestModelMetrics_modelMetrics_Bias.Report = requestModelMetrics_modelMetrics_Bias_modelMetrics_Bias_Report;
                requestModelMetrics_modelMetrics_BiasIsNull = false;
            }
             // determine if requestModelMetrics_modelMetrics_Bias should be set to null
            if (requestModelMetrics_modelMetrics_BiasIsNull)
            {
                requestModelMetrics_modelMetrics_Bias = null;
            }
            if (requestModelMetrics_modelMetrics_Bias != null)
            {
                request.ModelMetrics.Bias = requestModelMetrics_modelMetrics_Bias;
                requestModelMetricsIsNull = false;
            }
            Amazon.SageMaker.Model.Explainability requestModelMetrics_modelMetrics_Explainability = null;
            
             // populate Explainability
            var requestModelMetrics_modelMetrics_ExplainabilityIsNull = true;
            requestModelMetrics_modelMetrics_Explainability = new Amazon.SageMaker.Model.Explainability();
            Amazon.SageMaker.Model.MetricsSource requestModelMetrics_modelMetrics_Explainability_modelMetrics_Explainability_Report = null;
            
             // populate Report
            var requestModelMetrics_modelMetrics_Explainability_modelMetrics_Explainability_ReportIsNull = true;
            requestModelMetrics_modelMetrics_Explainability_modelMetrics_Explainability_Report = new Amazon.SageMaker.Model.MetricsSource();
            System.String requestModelMetrics_modelMetrics_Explainability_modelMetrics_Explainability_Report_modelMetrics_Explainability_Report_ContentDigest = null;
            if (cmdletContext.ModelMetrics_Explainability_Report_ContentDigest != null)
            {
                requestModelMetrics_modelMetrics_Explainability_modelMetrics_Explainability_Report_modelMetrics_Explainability_Report_ContentDigest = cmdletContext.ModelMetrics_Explainability_Report_ContentDigest;
            }
            if (requestModelMetrics_modelMetrics_Explainability_modelMetrics_Explainability_Report_modelMetrics_Explainability_Report_ContentDigest != null)
            {
                requestModelMetrics_modelMetrics_Explainability_modelMetrics_Explainability_Report.ContentDigest = requestModelMetrics_modelMetrics_Explainability_modelMetrics_Explainability_Report_modelMetrics_Explainability_Report_ContentDigest;
                requestModelMetrics_modelMetrics_Explainability_modelMetrics_Explainability_ReportIsNull = false;
            }
            System.String requestModelMetrics_modelMetrics_Explainability_modelMetrics_Explainability_Report_modelMetrics_Explainability_Report_ContentType = null;
            if (cmdletContext.ModelMetrics_Explainability_Report_ContentType != null)
            {
                requestModelMetrics_modelMetrics_Explainability_modelMetrics_Explainability_Report_modelMetrics_Explainability_Report_ContentType = cmdletContext.ModelMetrics_Explainability_Report_ContentType;
            }
            if (requestModelMetrics_modelMetrics_Explainability_modelMetrics_Explainability_Report_modelMetrics_Explainability_Report_ContentType != null)
            {
                requestModelMetrics_modelMetrics_Explainability_modelMetrics_Explainability_Report.ContentType = requestModelMetrics_modelMetrics_Explainability_modelMetrics_Explainability_Report_modelMetrics_Explainability_Report_ContentType;
                requestModelMetrics_modelMetrics_Explainability_modelMetrics_Explainability_ReportIsNull = false;
            }
            System.String requestModelMetrics_modelMetrics_Explainability_modelMetrics_Explainability_Report_modelMetrics_Explainability_Report_S3Uri = null;
            if (cmdletContext.ModelMetrics_Explainability_Report_S3Uri != null)
            {
                requestModelMetrics_modelMetrics_Explainability_modelMetrics_Explainability_Report_modelMetrics_Explainability_Report_S3Uri = cmdletContext.ModelMetrics_Explainability_Report_S3Uri;
            }
            if (requestModelMetrics_modelMetrics_Explainability_modelMetrics_Explainability_Report_modelMetrics_Explainability_Report_S3Uri != null)
            {
                requestModelMetrics_modelMetrics_Explainability_modelMetrics_Explainability_Report.S3Uri = requestModelMetrics_modelMetrics_Explainability_modelMetrics_Explainability_Report_modelMetrics_Explainability_Report_S3Uri;
                requestModelMetrics_modelMetrics_Explainability_modelMetrics_Explainability_ReportIsNull = false;
            }
             // determine if requestModelMetrics_modelMetrics_Explainability_modelMetrics_Explainability_Report should be set to null
            if (requestModelMetrics_modelMetrics_Explainability_modelMetrics_Explainability_ReportIsNull)
            {
                requestModelMetrics_modelMetrics_Explainability_modelMetrics_Explainability_Report = null;
            }
            if (requestModelMetrics_modelMetrics_Explainability_modelMetrics_Explainability_Report != null)
            {
                requestModelMetrics_modelMetrics_Explainability.Report = requestModelMetrics_modelMetrics_Explainability_modelMetrics_Explainability_Report;
                requestModelMetrics_modelMetrics_ExplainabilityIsNull = false;
            }
             // determine if requestModelMetrics_modelMetrics_Explainability should be set to null
            if (requestModelMetrics_modelMetrics_ExplainabilityIsNull)
            {
                requestModelMetrics_modelMetrics_Explainability = null;
            }
            if (requestModelMetrics_modelMetrics_Explainability != null)
            {
                request.ModelMetrics.Explainability = requestModelMetrics_modelMetrics_Explainability;
                requestModelMetricsIsNull = false;
            }
            Amazon.SageMaker.Model.ModelDataQuality requestModelMetrics_modelMetrics_ModelDataQuality = null;
            
             // populate ModelDataQuality
            var requestModelMetrics_modelMetrics_ModelDataQualityIsNull = true;
            requestModelMetrics_modelMetrics_ModelDataQuality = new Amazon.SageMaker.Model.ModelDataQuality();
            Amazon.SageMaker.Model.MetricsSource requestModelMetrics_modelMetrics_ModelDataQuality_modelMetrics_ModelDataQuality_Constraints = null;
            
             // populate Constraints
            var requestModelMetrics_modelMetrics_ModelDataQuality_modelMetrics_ModelDataQuality_ConstraintsIsNull = true;
            requestModelMetrics_modelMetrics_ModelDataQuality_modelMetrics_ModelDataQuality_Constraints = new Amazon.SageMaker.Model.MetricsSource();
            System.String requestModelMetrics_modelMetrics_ModelDataQuality_modelMetrics_ModelDataQuality_Constraints_modelMetrics_ModelDataQuality_Constraints_ContentDigest = null;
            if (cmdletContext.ModelMetrics_ModelDataQuality_Constraints_ContentDigest != null)
            {
                requestModelMetrics_modelMetrics_ModelDataQuality_modelMetrics_ModelDataQuality_Constraints_modelMetrics_ModelDataQuality_Constraints_ContentDigest = cmdletContext.ModelMetrics_ModelDataQuality_Constraints_ContentDigest;
            }
            if (requestModelMetrics_modelMetrics_ModelDataQuality_modelMetrics_ModelDataQuality_Constraints_modelMetrics_ModelDataQuality_Constraints_ContentDigest != null)
            {
                requestModelMetrics_modelMetrics_ModelDataQuality_modelMetrics_ModelDataQuality_Constraints.ContentDigest = requestModelMetrics_modelMetrics_ModelDataQuality_modelMetrics_ModelDataQuality_Constraints_modelMetrics_ModelDataQuality_Constraints_ContentDigest;
                requestModelMetrics_modelMetrics_ModelDataQuality_modelMetrics_ModelDataQuality_ConstraintsIsNull = false;
            }
            System.String requestModelMetrics_modelMetrics_ModelDataQuality_modelMetrics_ModelDataQuality_Constraints_modelMetrics_ModelDataQuality_Constraints_ContentType = null;
            if (cmdletContext.ModelMetrics_ModelDataQuality_Constraints_ContentType != null)
            {
                requestModelMetrics_modelMetrics_ModelDataQuality_modelMetrics_ModelDataQuality_Constraints_modelMetrics_ModelDataQuality_Constraints_ContentType = cmdletContext.ModelMetrics_ModelDataQuality_Constraints_ContentType;
            }
            if (requestModelMetrics_modelMetrics_ModelDataQuality_modelMetrics_ModelDataQuality_Constraints_modelMetrics_ModelDataQuality_Constraints_ContentType != null)
            {
                requestModelMetrics_modelMetrics_ModelDataQuality_modelMetrics_ModelDataQuality_Constraints.ContentType = requestModelMetrics_modelMetrics_ModelDataQuality_modelMetrics_ModelDataQuality_Constraints_modelMetrics_ModelDataQuality_Constraints_ContentType;
                requestModelMetrics_modelMetrics_ModelDataQuality_modelMetrics_ModelDataQuality_ConstraintsIsNull = false;
            }
            System.String requestModelMetrics_modelMetrics_ModelDataQuality_modelMetrics_ModelDataQuality_Constraints_modelMetrics_ModelDataQuality_Constraints_S3Uri = null;
            if (cmdletContext.ModelMetrics_ModelDataQuality_Constraints_S3Uri != null)
            {
                requestModelMetrics_modelMetrics_ModelDataQuality_modelMetrics_ModelDataQuality_Constraints_modelMetrics_ModelDataQuality_Constraints_S3Uri = cmdletContext.ModelMetrics_ModelDataQuality_Constraints_S3Uri;
            }
            if (requestModelMetrics_modelMetrics_ModelDataQuality_modelMetrics_ModelDataQuality_Constraints_modelMetrics_ModelDataQuality_Constraints_S3Uri != null)
            {
                requestModelMetrics_modelMetrics_ModelDataQuality_modelMetrics_ModelDataQuality_Constraints.S3Uri = requestModelMetrics_modelMetrics_ModelDataQuality_modelMetrics_ModelDataQuality_Constraints_modelMetrics_ModelDataQuality_Constraints_S3Uri;
                requestModelMetrics_modelMetrics_ModelDataQuality_modelMetrics_ModelDataQuality_ConstraintsIsNull = false;
            }
             // determine if requestModelMetrics_modelMetrics_ModelDataQuality_modelMetrics_ModelDataQuality_Constraints should be set to null
            if (requestModelMetrics_modelMetrics_ModelDataQuality_modelMetrics_ModelDataQuality_ConstraintsIsNull)
            {
                requestModelMetrics_modelMetrics_ModelDataQuality_modelMetrics_ModelDataQuality_Constraints = null;
            }
            if (requestModelMetrics_modelMetrics_ModelDataQuality_modelMetrics_ModelDataQuality_Constraints != null)
            {
                requestModelMetrics_modelMetrics_ModelDataQuality.Constraints = requestModelMetrics_modelMetrics_ModelDataQuality_modelMetrics_ModelDataQuality_Constraints;
                requestModelMetrics_modelMetrics_ModelDataQualityIsNull = false;
            }
            Amazon.SageMaker.Model.MetricsSource requestModelMetrics_modelMetrics_ModelDataQuality_modelMetrics_ModelDataQuality_Statistics = null;
            
             // populate Statistics
            var requestModelMetrics_modelMetrics_ModelDataQuality_modelMetrics_ModelDataQuality_StatisticsIsNull = true;
            requestModelMetrics_modelMetrics_ModelDataQuality_modelMetrics_ModelDataQuality_Statistics = new Amazon.SageMaker.Model.MetricsSource();
            System.String requestModelMetrics_modelMetrics_ModelDataQuality_modelMetrics_ModelDataQuality_Statistics_modelMetrics_ModelDataQuality_Statistics_ContentDigest = null;
            if (cmdletContext.ModelMetrics_ModelDataQuality_Statistics_ContentDigest != null)
            {
                requestModelMetrics_modelMetrics_ModelDataQuality_modelMetrics_ModelDataQuality_Statistics_modelMetrics_ModelDataQuality_Statistics_ContentDigest = cmdletContext.ModelMetrics_ModelDataQuality_Statistics_ContentDigest;
            }
            if (requestModelMetrics_modelMetrics_ModelDataQuality_modelMetrics_ModelDataQuality_Statistics_modelMetrics_ModelDataQuality_Statistics_ContentDigest != null)
            {
                requestModelMetrics_modelMetrics_ModelDataQuality_modelMetrics_ModelDataQuality_Statistics.ContentDigest = requestModelMetrics_modelMetrics_ModelDataQuality_modelMetrics_ModelDataQuality_Statistics_modelMetrics_ModelDataQuality_Statistics_ContentDigest;
                requestModelMetrics_modelMetrics_ModelDataQuality_modelMetrics_ModelDataQuality_StatisticsIsNull = false;
            }
            System.String requestModelMetrics_modelMetrics_ModelDataQuality_modelMetrics_ModelDataQuality_Statistics_modelMetrics_ModelDataQuality_Statistics_ContentType = null;
            if (cmdletContext.ModelMetrics_ModelDataQuality_Statistics_ContentType != null)
            {
                requestModelMetrics_modelMetrics_ModelDataQuality_modelMetrics_ModelDataQuality_Statistics_modelMetrics_ModelDataQuality_Statistics_ContentType = cmdletContext.ModelMetrics_ModelDataQuality_Statistics_ContentType;
            }
            if (requestModelMetrics_modelMetrics_ModelDataQuality_modelMetrics_ModelDataQuality_Statistics_modelMetrics_ModelDataQuality_Statistics_ContentType != null)
            {
                requestModelMetrics_modelMetrics_ModelDataQuality_modelMetrics_ModelDataQuality_Statistics.ContentType = requestModelMetrics_modelMetrics_ModelDataQuality_modelMetrics_ModelDataQuality_Statistics_modelMetrics_ModelDataQuality_Statistics_ContentType;
                requestModelMetrics_modelMetrics_ModelDataQuality_modelMetrics_ModelDataQuality_StatisticsIsNull = false;
            }
            System.String requestModelMetrics_modelMetrics_ModelDataQuality_modelMetrics_ModelDataQuality_Statistics_modelMetrics_ModelDataQuality_Statistics_S3Uri = null;
            if (cmdletContext.ModelMetrics_ModelDataQuality_Statistics_S3Uri != null)
            {
                requestModelMetrics_modelMetrics_ModelDataQuality_modelMetrics_ModelDataQuality_Statistics_modelMetrics_ModelDataQuality_Statistics_S3Uri = cmdletContext.ModelMetrics_ModelDataQuality_Statistics_S3Uri;
            }
            if (requestModelMetrics_modelMetrics_ModelDataQuality_modelMetrics_ModelDataQuality_Statistics_modelMetrics_ModelDataQuality_Statistics_S3Uri != null)
            {
                requestModelMetrics_modelMetrics_ModelDataQuality_modelMetrics_ModelDataQuality_Statistics.S3Uri = requestModelMetrics_modelMetrics_ModelDataQuality_modelMetrics_ModelDataQuality_Statistics_modelMetrics_ModelDataQuality_Statistics_S3Uri;
                requestModelMetrics_modelMetrics_ModelDataQuality_modelMetrics_ModelDataQuality_StatisticsIsNull = false;
            }
             // determine if requestModelMetrics_modelMetrics_ModelDataQuality_modelMetrics_ModelDataQuality_Statistics should be set to null
            if (requestModelMetrics_modelMetrics_ModelDataQuality_modelMetrics_ModelDataQuality_StatisticsIsNull)
            {
                requestModelMetrics_modelMetrics_ModelDataQuality_modelMetrics_ModelDataQuality_Statistics = null;
            }
            if (requestModelMetrics_modelMetrics_ModelDataQuality_modelMetrics_ModelDataQuality_Statistics != null)
            {
                requestModelMetrics_modelMetrics_ModelDataQuality.Statistics = requestModelMetrics_modelMetrics_ModelDataQuality_modelMetrics_ModelDataQuality_Statistics;
                requestModelMetrics_modelMetrics_ModelDataQualityIsNull = false;
            }
             // determine if requestModelMetrics_modelMetrics_ModelDataQuality should be set to null
            if (requestModelMetrics_modelMetrics_ModelDataQualityIsNull)
            {
                requestModelMetrics_modelMetrics_ModelDataQuality = null;
            }
            if (requestModelMetrics_modelMetrics_ModelDataQuality != null)
            {
                request.ModelMetrics.ModelDataQuality = requestModelMetrics_modelMetrics_ModelDataQuality;
                requestModelMetricsIsNull = false;
            }
            Amazon.SageMaker.Model.ModelQuality requestModelMetrics_modelMetrics_ModelQuality = null;
            
             // populate ModelQuality
            var requestModelMetrics_modelMetrics_ModelQualityIsNull = true;
            requestModelMetrics_modelMetrics_ModelQuality = new Amazon.SageMaker.Model.ModelQuality();
            Amazon.SageMaker.Model.MetricsSource requestModelMetrics_modelMetrics_ModelQuality_modelMetrics_ModelQuality_Constraints = null;
            
             // populate Constraints
            var requestModelMetrics_modelMetrics_ModelQuality_modelMetrics_ModelQuality_ConstraintsIsNull = true;
            requestModelMetrics_modelMetrics_ModelQuality_modelMetrics_ModelQuality_Constraints = new Amazon.SageMaker.Model.MetricsSource();
            System.String requestModelMetrics_modelMetrics_ModelQuality_modelMetrics_ModelQuality_Constraints_modelMetrics_ModelQuality_Constraints_ContentDigest = null;
            if (cmdletContext.ModelMetrics_ModelQuality_Constraints_ContentDigest != null)
            {
                requestModelMetrics_modelMetrics_ModelQuality_modelMetrics_ModelQuality_Constraints_modelMetrics_ModelQuality_Constraints_ContentDigest = cmdletContext.ModelMetrics_ModelQuality_Constraints_ContentDigest;
            }
            if (requestModelMetrics_modelMetrics_ModelQuality_modelMetrics_ModelQuality_Constraints_modelMetrics_ModelQuality_Constraints_ContentDigest != null)
            {
                requestModelMetrics_modelMetrics_ModelQuality_modelMetrics_ModelQuality_Constraints.ContentDigest = requestModelMetrics_modelMetrics_ModelQuality_modelMetrics_ModelQuality_Constraints_modelMetrics_ModelQuality_Constraints_ContentDigest;
                requestModelMetrics_modelMetrics_ModelQuality_modelMetrics_ModelQuality_ConstraintsIsNull = false;
            }
            System.String requestModelMetrics_modelMetrics_ModelQuality_modelMetrics_ModelQuality_Constraints_modelMetrics_ModelQuality_Constraints_ContentType = null;
            if (cmdletContext.ModelMetrics_ModelQuality_Constraints_ContentType != null)
            {
                requestModelMetrics_modelMetrics_ModelQuality_modelMetrics_ModelQuality_Constraints_modelMetrics_ModelQuality_Constraints_ContentType = cmdletContext.ModelMetrics_ModelQuality_Constraints_ContentType;
            }
            if (requestModelMetrics_modelMetrics_ModelQuality_modelMetrics_ModelQuality_Constraints_modelMetrics_ModelQuality_Constraints_ContentType != null)
            {
                requestModelMetrics_modelMetrics_ModelQuality_modelMetrics_ModelQuality_Constraints.ContentType = requestModelMetrics_modelMetrics_ModelQuality_modelMetrics_ModelQuality_Constraints_modelMetrics_ModelQuality_Constraints_ContentType;
                requestModelMetrics_modelMetrics_ModelQuality_modelMetrics_ModelQuality_ConstraintsIsNull = false;
            }
            System.String requestModelMetrics_modelMetrics_ModelQuality_modelMetrics_ModelQuality_Constraints_modelMetrics_ModelQuality_Constraints_S3Uri = null;
            if (cmdletContext.ModelMetrics_ModelQuality_Constraints_S3Uri != null)
            {
                requestModelMetrics_modelMetrics_ModelQuality_modelMetrics_ModelQuality_Constraints_modelMetrics_ModelQuality_Constraints_S3Uri = cmdletContext.ModelMetrics_ModelQuality_Constraints_S3Uri;
            }
            if (requestModelMetrics_modelMetrics_ModelQuality_modelMetrics_ModelQuality_Constraints_modelMetrics_ModelQuality_Constraints_S3Uri != null)
            {
                requestModelMetrics_modelMetrics_ModelQuality_modelMetrics_ModelQuality_Constraints.S3Uri = requestModelMetrics_modelMetrics_ModelQuality_modelMetrics_ModelQuality_Constraints_modelMetrics_ModelQuality_Constraints_S3Uri;
                requestModelMetrics_modelMetrics_ModelQuality_modelMetrics_ModelQuality_ConstraintsIsNull = false;
            }
             // determine if requestModelMetrics_modelMetrics_ModelQuality_modelMetrics_ModelQuality_Constraints should be set to null
            if (requestModelMetrics_modelMetrics_ModelQuality_modelMetrics_ModelQuality_ConstraintsIsNull)
            {
                requestModelMetrics_modelMetrics_ModelQuality_modelMetrics_ModelQuality_Constraints = null;
            }
            if (requestModelMetrics_modelMetrics_ModelQuality_modelMetrics_ModelQuality_Constraints != null)
            {
                requestModelMetrics_modelMetrics_ModelQuality.Constraints = requestModelMetrics_modelMetrics_ModelQuality_modelMetrics_ModelQuality_Constraints;
                requestModelMetrics_modelMetrics_ModelQualityIsNull = false;
            }
            Amazon.SageMaker.Model.MetricsSource requestModelMetrics_modelMetrics_ModelQuality_modelMetrics_ModelQuality_Statistics = null;
            
             // populate Statistics
            var requestModelMetrics_modelMetrics_ModelQuality_modelMetrics_ModelQuality_StatisticsIsNull = true;
            requestModelMetrics_modelMetrics_ModelQuality_modelMetrics_ModelQuality_Statistics = new Amazon.SageMaker.Model.MetricsSource();
            System.String requestModelMetrics_modelMetrics_ModelQuality_modelMetrics_ModelQuality_Statistics_modelMetrics_ModelQuality_Statistics_ContentDigest = null;
            if (cmdletContext.ModelMetrics_ModelQuality_Statistics_ContentDigest != null)
            {
                requestModelMetrics_modelMetrics_ModelQuality_modelMetrics_ModelQuality_Statistics_modelMetrics_ModelQuality_Statistics_ContentDigest = cmdletContext.ModelMetrics_ModelQuality_Statistics_ContentDigest;
            }
            if (requestModelMetrics_modelMetrics_ModelQuality_modelMetrics_ModelQuality_Statistics_modelMetrics_ModelQuality_Statistics_ContentDigest != null)
            {
                requestModelMetrics_modelMetrics_ModelQuality_modelMetrics_ModelQuality_Statistics.ContentDigest = requestModelMetrics_modelMetrics_ModelQuality_modelMetrics_ModelQuality_Statistics_modelMetrics_ModelQuality_Statistics_ContentDigest;
                requestModelMetrics_modelMetrics_ModelQuality_modelMetrics_ModelQuality_StatisticsIsNull = false;
            }
            System.String requestModelMetrics_modelMetrics_ModelQuality_modelMetrics_ModelQuality_Statistics_modelMetrics_ModelQuality_Statistics_ContentType = null;
            if (cmdletContext.ModelMetrics_ModelQuality_Statistics_ContentType != null)
            {
                requestModelMetrics_modelMetrics_ModelQuality_modelMetrics_ModelQuality_Statistics_modelMetrics_ModelQuality_Statistics_ContentType = cmdletContext.ModelMetrics_ModelQuality_Statistics_ContentType;
            }
            if (requestModelMetrics_modelMetrics_ModelQuality_modelMetrics_ModelQuality_Statistics_modelMetrics_ModelQuality_Statistics_ContentType != null)
            {
                requestModelMetrics_modelMetrics_ModelQuality_modelMetrics_ModelQuality_Statistics.ContentType = requestModelMetrics_modelMetrics_ModelQuality_modelMetrics_ModelQuality_Statistics_modelMetrics_ModelQuality_Statistics_ContentType;
                requestModelMetrics_modelMetrics_ModelQuality_modelMetrics_ModelQuality_StatisticsIsNull = false;
            }
            System.String requestModelMetrics_modelMetrics_ModelQuality_modelMetrics_ModelQuality_Statistics_modelMetrics_ModelQuality_Statistics_S3Uri = null;
            if (cmdletContext.ModelMetrics_ModelQuality_Statistics_S3Uri != null)
            {
                requestModelMetrics_modelMetrics_ModelQuality_modelMetrics_ModelQuality_Statistics_modelMetrics_ModelQuality_Statistics_S3Uri = cmdletContext.ModelMetrics_ModelQuality_Statistics_S3Uri;
            }
            if (requestModelMetrics_modelMetrics_ModelQuality_modelMetrics_ModelQuality_Statistics_modelMetrics_ModelQuality_Statistics_S3Uri != null)
            {
                requestModelMetrics_modelMetrics_ModelQuality_modelMetrics_ModelQuality_Statistics.S3Uri = requestModelMetrics_modelMetrics_ModelQuality_modelMetrics_ModelQuality_Statistics_modelMetrics_ModelQuality_Statistics_S3Uri;
                requestModelMetrics_modelMetrics_ModelQuality_modelMetrics_ModelQuality_StatisticsIsNull = false;
            }
             // determine if requestModelMetrics_modelMetrics_ModelQuality_modelMetrics_ModelQuality_Statistics should be set to null
            if (requestModelMetrics_modelMetrics_ModelQuality_modelMetrics_ModelQuality_StatisticsIsNull)
            {
                requestModelMetrics_modelMetrics_ModelQuality_modelMetrics_ModelQuality_Statistics = null;
            }
            if (requestModelMetrics_modelMetrics_ModelQuality_modelMetrics_ModelQuality_Statistics != null)
            {
                requestModelMetrics_modelMetrics_ModelQuality.Statistics = requestModelMetrics_modelMetrics_ModelQuality_modelMetrics_ModelQuality_Statistics;
                requestModelMetrics_modelMetrics_ModelQualityIsNull = false;
            }
             // determine if requestModelMetrics_modelMetrics_ModelQuality should be set to null
            if (requestModelMetrics_modelMetrics_ModelQualityIsNull)
            {
                requestModelMetrics_modelMetrics_ModelQuality = null;
            }
            if (requestModelMetrics_modelMetrics_ModelQuality != null)
            {
                request.ModelMetrics.ModelQuality = requestModelMetrics_modelMetrics_ModelQuality;
                requestModelMetricsIsNull = false;
            }
             // determine if request.ModelMetrics should be set to null
            if (requestModelMetricsIsNull)
            {
                request.ModelMetrics = null;
            }
            if (cmdletContext.ModelPackageDescription != null)
            {
                request.ModelPackageDescription = cmdletContext.ModelPackageDescription;
            }
            if (cmdletContext.ModelPackageGroupName != null)
            {
                request.ModelPackageGroupName = cmdletContext.ModelPackageGroupName;
            }
            if (cmdletContext.ModelPackageName != null)
            {
                request.ModelPackageName = cmdletContext.ModelPackageName;
            }
            
             // populate SourceAlgorithmSpecification
            var requestSourceAlgorithmSpecificationIsNull = true;
            request.SourceAlgorithmSpecification = new Amazon.SageMaker.Model.SourceAlgorithmSpecification();
            List<Amazon.SageMaker.Model.SourceAlgorithm> requestSourceAlgorithmSpecification_sourceAlgorithmSpecification_SourceAlgorithm = null;
            if (cmdletContext.SourceAlgorithmSpecification_SourceAlgorithm != null)
            {
                requestSourceAlgorithmSpecification_sourceAlgorithmSpecification_SourceAlgorithm = cmdletContext.SourceAlgorithmSpecification_SourceAlgorithm;
            }
            if (requestSourceAlgorithmSpecification_sourceAlgorithmSpecification_SourceAlgorithm != null)
            {
                request.SourceAlgorithmSpecification.SourceAlgorithms = requestSourceAlgorithmSpecification_sourceAlgorithmSpecification_SourceAlgorithm;
                requestSourceAlgorithmSpecificationIsNull = false;
            }
             // determine if request.SourceAlgorithmSpecification should be set to null
            if (requestSourceAlgorithmSpecificationIsNull)
            {
                request.SourceAlgorithmSpecification = null;
            }
            if (cmdletContext.Tag != null)
            {
                request.Tags = cmdletContext.Tag;
            }
            
             // populate ValidationSpecification
            var requestValidationSpecificationIsNull = true;
            request.ValidationSpecification = new Amazon.SageMaker.Model.ModelPackageValidationSpecification();
            List<Amazon.SageMaker.Model.ModelPackageValidationProfile> requestValidationSpecification_validationSpecification_ValidationProfile = null;
            if (cmdletContext.ValidationSpecification_ValidationProfile != null)
            {
                requestValidationSpecification_validationSpecification_ValidationProfile = cmdletContext.ValidationSpecification_ValidationProfile;
            }
            if (requestValidationSpecification_validationSpecification_ValidationProfile != null)
            {
                request.ValidationSpecification.ValidationProfiles = requestValidationSpecification_validationSpecification_ValidationProfile;
                requestValidationSpecificationIsNull = false;
            }
            System.String requestValidationSpecification_validationSpecification_ValidationRole = null;
            if (cmdletContext.ValidationSpecification_ValidationRole != null)
            {
                requestValidationSpecification_validationSpecification_ValidationRole = cmdletContext.ValidationSpecification_ValidationRole;
            }
            if (requestValidationSpecification_validationSpecification_ValidationRole != null)
            {
                request.ValidationSpecification.ValidationRole = requestValidationSpecification_validationSpecification_ValidationRole;
                requestValidationSpecificationIsNull = false;
            }
             // determine if request.ValidationSpecification should be set to null
            if (requestValidationSpecificationIsNull)
            {
                request.ValidationSpecification = null;
            }
            
            CmdletOutput output;
            
            // issue call
            var client = Client ?? CreateClient(_CurrentCredentials, _RegionEndpoint);
            try
            {
                var response = CallAWSServiceOperation(client, request);
                object pipelineOutput = null;
                pipelineOutput = cmdletContext.Select(response, this);
                output = new CmdletOutput
                {
                    PipelineOutput = pipelineOutput,
                    ServiceResponse = response
                };
            }
            catch (Exception e)
            {
                output = new CmdletOutput { ErrorResponse = e };
            }
            
            return output;
        }
        
        public ExecutorContext CreateContext()
        {
            return new CmdletContext();
        }
        
        #endregion
        
        #region AWS Service Operation Call
        
        private Amazon.SageMaker.Model.CreateModelPackageResponse CallAWSServiceOperation(IAmazonSageMaker client, Amazon.SageMaker.Model.CreateModelPackageRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon SageMaker Service", "CreateModelPackage");
            try
            {
                #if DESKTOP
                return client.CreateModelPackage(request);
                #elif CORECLR
                return client.CreateModelPackageAsync(request).GetAwaiter().GetResult();
                #else
                        #error "Unknown build edition"
                #endif
            }
            catch (AmazonServiceException exc)
            {
                var webException = exc.InnerException as System.Net.WebException;
                if (webException != null)
                {
                    throw new Exception(Utils.Common.FormatNameResolutionFailureMessage(client.Config, webException.Message), webException);
                }
                throw;
            }
        }
        
        #endregion
        
        internal partial class CmdletContext : ExecutorContext
        {
            public System.Boolean? CertifyForMarketplace { get; set; }
            public System.String ClientToken { get; set; }
            public List<Amazon.SageMaker.Model.ModelPackageContainerDefinition> InferenceSpecification_Container { get; set; }
            public List<System.String> InferenceSpecification_SupportedContentType { get; set; }
            public List<System.String> InferenceSpecification_SupportedRealtimeInferenceInstanceType { get; set; }
            public List<System.String> InferenceSpecification_SupportedResponseMIMEType { get; set; }
            public List<System.String> InferenceSpecification_SupportedTransformInstanceType { get; set; }
            public System.String MetadataProperties_CommitId { get; set; }
            public System.String MetadataProperties_GeneratedBy { get; set; }
            public System.String MetadataProperties_ProjectId { get; set; }
            public System.String MetadataProperties_Repository { get; set; }
            public Amazon.SageMaker.ModelApprovalStatus ModelApprovalStatus { get; set; }
            public System.String ModelMetrics_Bias_Report_ContentDigest { get; set; }
            public System.String ModelMetrics_Bias_Report_ContentType { get; set; }
            public System.String ModelMetrics_Bias_Report_S3Uri { get; set; }
            public System.String ModelMetrics_Explainability_Report_ContentDigest { get; set; }
            public System.String ModelMetrics_Explainability_Report_ContentType { get; set; }
            public System.String ModelMetrics_Explainability_Report_S3Uri { get; set; }
            public System.String ModelMetrics_ModelDataQuality_Constraints_ContentDigest { get; set; }
            public System.String ModelMetrics_ModelDataQuality_Constraints_ContentType { get; set; }
            public System.String ModelMetrics_ModelDataQuality_Constraints_S3Uri { get; set; }
            public System.String ModelMetrics_ModelDataQuality_Statistics_ContentDigest { get; set; }
            public System.String ModelMetrics_ModelDataQuality_Statistics_ContentType { get; set; }
            public System.String ModelMetrics_ModelDataQuality_Statistics_S3Uri { get; set; }
            public System.String ModelMetrics_ModelQuality_Constraints_ContentDigest { get; set; }
            public System.String ModelMetrics_ModelQuality_Constraints_ContentType { get; set; }
            public System.String ModelMetrics_ModelQuality_Constraints_S3Uri { get; set; }
            public System.String ModelMetrics_ModelQuality_Statistics_ContentDigest { get; set; }
            public System.String ModelMetrics_ModelQuality_Statistics_ContentType { get; set; }
            public System.String ModelMetrics_ModelQuality_Statistics_S3Uri { get; set; }
            public System.String ModelPackageDescription { get; set; }
            public System.String ModelPackageGroupName { get; set; }
            public System.String ModelPackageName { get; set; }
            public List<Amazon.SageMaker.Model.SourceAlgorithm> SourceAlgorithmSpecification_SourceAlgorithm { get; set; }
            public List<Amazon.SageMaker.Model.Tag> Tag { get; set; }
            public List<Amazon.SageMaker.Model.ModelPackageValidationProfile> ValidationSpecification_ValidationProfile { get; set; }
            public System.String ValidationSpecification_ValidationRole { get; set; }
            public System.Func<Amazon.SageMaker.Model.CreateModelPackageResponse, NewSMModelPackageCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.ModelPackageArn;
        }
        
    }
}
