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
using Amazon.AWSMarketplaceMetering;
using Amazon.AWSMarketplaceMetering.Model;

namespace Amazon.PowerShell.Cmdlets.MM
{
    /// <summary>
    /// BatchMeterUsage is called from a SaaS application listed on the AWS Marketplace to
    /// post metering records for a set of customers.
    /// 
    ///  
    /// <para>
    /// For identical requests, the API is idempotent; requests can be retried with the same
    /// records or a subset of the input records.
    /// </para><para>
    /// Every request to BatchMeterUsage is for one product. If you need to meter usage for
    /// multiple products, you must make multiple calls to BatchMeterUsage.
    /// </para><para>
    /// BatchMeterUsage can process up to 25 UsageRecords at a time.
    /// </para><para>
    /// A UsageRecord can optionally include multiple usage allocations, to provide customers
    /// with usagedata split into buckets by tags that you define (or allow the customer to
    /// define).
    /// </para><para>
    /// BatchMeterUsage requests must be less than 1MB in size.
    /// </para>
    /// </summary>
    [Cmdlet("Send", "MMMeteringDataBatch", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.AWSMarketplaceMetering.Model.BatchMeterUsageResponse")]
    [AWSCmdlet("Calls the AWS Marketplace Metering BatchMeterUsage API operation.", Operation = new[] {"BatchMeterUsage"}, SelectReturnType = typeof(Amazon.AWSMarketplaceMetering.Model.BatchMeterUsageResponse))]
    [AWSCmdletOutput("Amazon.AWSMarketplaceMetering.Model.BatchMeterUsageResponse",
        "This cmdlet returns an Amazon.AWSMarketplaceMetering.Model.BatchMeterUsageResponse object containing multiple properties. The object can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class SendMMMeteringDataBatchCmdlet : AmazonAWSMarketplaceMeteringClientCmdlet, IExecutor
    {
        
        #region Parameter ProductCode
        /// <summary>
        /// <para>
        /// <para>Product code is used to uniquely identify a product in AWS Marketplace. The product
        /// code should be the same as the one used during the publishing of a new product.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true)]
        #else
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyString]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.String ProductCode { get; set; }
        #endregion
        
        #region Parameter UsageRecord
        /// <summary>
        /// <para>
        /// <para>The set of UsageRecords to submit. BatchMeterUsage accepts up to 25 UsageRecords at
        /// a time.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyCollection]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        [Alias("UsageRecords")]
        public Amazon.AWSMarketplaceMetering.Model.UsageRecord[] UsageRecord { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is '*'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.AWSMarketplaceMetering.Model.BatchMeterUsageResponse).
        /// Specifying the name of a property of type Amazon.AWSMarketplaceMetering.Model.BatchMeterUsageResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "*";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the ProductCode parameter.
        /// The -PassThru parameter is deprecated, use -Select '^ProductCode' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^ProductCode' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.ProductCode), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Send-MMMeteringDataBatch (BatchMeterUsage)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.AWSMarketplaceMetering.Model.BatchMeterUsageResponse, SendMMMeteringDataBatchCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.ProductCode;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.ProductCode = this.ProductCode;
            #if MODULAR
            if (this.ProductCode == null && ParameterWasBound(nameof(this.ProductCode)))
            {
                WriteWarning("You are passing $null as a value for parameter ProductCode which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            if (this.UsageRecord != null)
            {
                context.UsageRecord = new List<Amazon.AWSMarketplaceMetering.Model.UsageRecord>(this.UsageRecord);
            }
            #if MODULAR
            if (this.UsageRecord == null && ParameterWasBound(nameof(this.UsageRecord)))
            {
                WriteWarning("You are passing $null as a value for parameter UsageRecord which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            
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
            var request = new Amazon.AWSMarketplaceMetering.Model.BatchMeterUsageRequest();
            
            if (cmdletContext.ProductCode != null)
            {
                request.ProductCode = cmdletContext.ProductCode;
            }
            if (cmdletContext.UsageRecord != null)
            {
                request.UsageRecords = cmdletContext.UsageRecord;
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
        
        private Amazon.AWSMarketplaceMetering.Model.BatchMeterUsageResponse CallAWSServiceOperation(IAmazonAWSMarketplaceMetering client, Amazon.AWSMarketplaceMetering.Model.BatchMeterUsageRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS Marketplace Metering", "BatchMeterUsage");
            try
            {
                #if DESKTOP
                return client.BatchMeterUsage(request);
                #elif CORECLR
                return client.BatchMeterUsageAsync(request).GetAwaiter().GetResult();
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
            public System.String ProductCode { get; set; }
            public List<Amazon.AWSMarketplaceMetering.Model.UsageRecord> UsageRecord { get; set; }
            public System.Func<Amazon.AWSMarketplaceMetering.Model.BatchMeterUsageResponse, SendMMMeteringDataBatchCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response;
        }
        
    }
}
