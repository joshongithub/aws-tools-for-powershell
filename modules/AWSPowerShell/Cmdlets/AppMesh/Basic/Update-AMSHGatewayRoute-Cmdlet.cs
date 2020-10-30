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
using Amazon.AppMesh;
using Amazon.AppMesh.Model;

namespace Amazon.PowerShell.Cmdlets.AMSH
{
    /// <summary>
    /// Updates an existing gateway route that is associated to a specified virtual gateway
    /// in a service mesh.
    /// </summary>
    [Cmdlet("Update", "AMSHGatewayRoute", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.AppMesh.Model.GatewayRouteData")]
    [AWSCmdlet("Calls the AWS App Mesh UpdateGatewayRoute API operation.", Operation = new[] {"UpdateGatewayRoute"}, SelectReturnType = typeof(Amazon.AppMesh.Model.UpdateGatewayRouteResponse))]
    [AWSCmdletOutput("Amazon.AppMesh.Model.GatewayRouteData or Amazon.AppMesh.Model.UpdateGatewayRouteResponse",
        "This cmdlet returns an Amazon.AppMesh.Model.GatewayRouteData object.",
        "The service call response (type Amazon.AppMesh.Model.UpdateGatewayRouteResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class UpdateAMSHGatewayRouteCmdlet : AmazonAppMeshClientCmdlet, IExecutor
    {
        
        #region Parameter GatewayRouteName
        /// <summary>
        /// <para>
        /// <para>The name of the gateway route to update.</para>
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
        public System.String GatewayRouteName { get; set; }
        #endregion
        
        #region Parameter MeshName
        /// <summary>
        /// <para>
        /// <para>The name of the service mesh that the gateway route resides in.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyString]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.String MeshName { get; set; }
        #endregion
        
        #region Parameter MeshOwner
        /// <summary>
        /// <para>
        /// <para>The AWS IAM account ID of the service mesh owner. If the account ID is not your own,
        /// then it's the ID of the account that shared the mesh with your account. For more information
        /// about mesh sharing, see <a href="https://docs.aws.amazon.com/app-mesh/latest/userguide/sharing.html">Working
        /// with shared meshes</a>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String MeshOwner { get; set; }
        #endregion
        
        #region Parameter Spec_Http2Route_Match_Prefix
        /// <summary>
        /// <para>
        /// <para>Specifies the path to match requests with. This parameter must always start with <code>/</code>,
        /// which by itself matches all requests to the virtual service name. You can also match
        /// for path-based routing of requests. For example, if your virtual service name is <code>my-service.local</code>
        /// and you want the route to match requests to <code>my-service.local/metrics</code>,
        /// your prefix should be <code>/metrics</code>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String Spec_Http2Route_Match_Prefix { get; set; }
        #endregion
        
        #region Parameter Spec_HttpRoute_Match_Prefix
        /// <summary>
        /// <para>
        /// <para>Specifies the path to match requests with. This parameter must always start with <code>/</code>,
        /// which by itself matches all requests to the virtual service name. You can also match
        /// for path-based routing of requests. For example, if your virtual service name is <code>my-service.local</code>
        /// and you want the route to match requests to <code>my-service.local/metrics</code>,
        /// your prefix should be <code>/metrics</code>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String Spec_HttpRoute_Match_Prefix { get; set; }
        #endregion
        
        #region Parameter Spec_GrpcRoute_Match_ServiceName
        /// <summary>
        /// <para>
        /// <para>The fully qualified domain name for the service to match from the request.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String Spec_GrpcRoute_Match_ServiceName { get; set; }
        #endregion
        
        #region Parameter VirtualGatewayName
        /// <summary>
        /// <para>
        /// <para>The name of the virtual gateway that the gateway route is associated with.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyString]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.String VirtualGatewayName { get; set; }
        #endregion
        
        #region Parameter Spec_GrpcRoute_Action_Target_VirtualService
        /// <summary>
        /// <para>
        /// <para>The name of the virtual service that traffic is routed to.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Spec_GrpcRoute_Action_Target_VirtualService_VirtualServiceName")]
        public System.String Spec_GrpcRoute_Action_Target_VirtualService { get; set; }
        #endregion
        
        #region Parameter Spec_Http2Route_Action_Target_VirtualService
        /// <summary>
        /// <para>
        /// <para>The name of the virtual service that traffic is routed to.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Spec_Http2Route_Action_Target_VirtualService_VirtualServiceName")]
        public System.String Spec_Http2Route_Action_Target_VirtualService { get; set; }
        #endregion
        
        #region Parameter Spec_HttpRoute_Action_Target_VirtualService
        /// <summary>
        /// <para>
        /// <para>The name of the virtual service that traffic is routed to.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Spec_HttpRoute_Action_Target_VirtualService_VirtualServiceName")]
        public System.String Spec_HttpRoute_Action_Target_VirtualService { get; set; }
        #endregion
        
        #region Parameter ClientToken
        /// <summary>
        /// <para>
        /// <para>Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. Up to 36 letters, numbers, hyphens, and underscores are allowed.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ClientToken { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'GatewayRoute'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.AppMesh.Model.UpdateGatewayRouteResponse).
        /// Specifying the name of a property of type Amazon.AppMesh.Model.UpdateGatewayRouteResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "GatewayRoute";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the GatewayRouteName parameter.
        /// The -PassThru parameter is deprecated, use -Select '^GatewayRouteName' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^GatewayRouteName' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.GatewayRouteName), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Update-AMSHGatewayRoute (UpdateGatewayRoute)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.AppMesh.Model.UpdateGatewayRouteResponse, UpdateAMSHGatewayRouteCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.GatewayRouteName;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.ClientToken = this.ClientToken;
            context.GatewayRouteName = this.GatewayRouteName;
            #if MODULAR
            if (this.GatewayRouteName == null && ParameterWasBound(nameof(this.GatewayRouteName)))
            {
                WriteWarning("You are passing $null as a value for parameter GatewayRouteName which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.MeshName = this.MeshName;
            #if MODULAR
            if (this.MeshName == null && ParameterWasBound(nameof(this.MeshName)))
            {
                WriteWarning("You are passing $null as a value for parameter MeshName which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.MeshOwner = this.MeshOwner;
            context.Spec_GrpcRoute_Action_Target_VirtualService = this.Spec_GrpcRoute_Action_Target_VirtualService;
            context.Spec_GrpcRoute_Match_ServiceName = this.Spec_GrpcRoute_Match_ServiceName;
            context.Spec_Http2Route_Action_Target_VirtualService = this.Spec_Http2Route_Action_Target_VirtualService;
            context.Spec_Http2Route_Match_Prefix = this.Spec_Http2Route_Match_Prefix;
            context.Spec_HttpRoute_Action_Target_VirtualService = this.Spec_HttpRoute_Action_Target_VirtualService;
            context.Spec_HttpRoute_Match_Prefix = this.Spec_HttpRoute_Match_Prefix;
            context.VirtualGatewayName = this.VirtualGatewayName;
            #if MODULAR
            if (this.VirtualGatewayName == null && ParameterWasBound(nameof(this.VirtualGatewayName)))
            {
                WriteWarning("You are passing $null as a value for parameter VirtualGatewayName which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
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
            var request = new Amazon.AppMesh.Model.UpdateGatewayRouteRequest();
            
            if (cmdletContext.ClientToken != null)
            {
                request.ClientToken = cmdletContext.ClientToken;
            }
            if (cmdletContext.GatewayRouteName != null)
            {
                request.GatewayRouteName = cmdletContext.GatewayRouteName;
            }
            if (cmdletContext.MeshName != null)
            {
                request.MeshName = cmdletContext.MeshName;
            }
            if (cmdletContext.MeshOwner != null)
            {
                request.MeshOwner = cmdletContext.MeshOwner;
            }
            
             // populate Spec
            var requestSpecIsNull = true;
            request.Spec = new Amazon.AppMesh.Model.GatewayRouteSpec();
            Amazon.AppMesh.Model.GrpcGatewayRoute requestSpec_spec_GrpcRoute = null;
            
             // populate GrpcRoute
            var requestSpec_spec_GrpcRouteIsNull = true;
            requestSpec_spec_GrpcRoute = new Amazon.AppMesh.Model.GrpcGatewayRoute();
            Amazon.AppMesh.Model.GrpcGatewayRouteAction requestSpec_spec_GrpcRoute_spec_GrpcRoute_Action = null;
            
             // populate Action
            var requestSpec_spec_GrpcRoute_spec_GrpcRoute_ActionIsNull = true;
            requestSpec_spec_GrpcRoute_spec_GrpcRoute_Action = new Amazon.AppMesh.Model.GrpcGatewayRouteAction();
            Amazon.AppMesh.Model.GatewayRouteTarget requestSpec_spec_GrpcRoute_spec_GrpcRoute_Action_spec_GrpcRoute_Action_Target = null;
            
             // populate Target
            var requestSpec_spec_GrpcRoute_spec_GrpcRoute_Action_spec_GrpcRoute_Action_TargetIsNull = true;
            requestSpec_spec_GrpcRoute_spec_GrpcRoute_Action_spec_GrpcRoute_Action_Target = new Amazon.AppMesh.Model.GatewayRouteTarget();
            Amazon.AppMesh.Model.GatewayRouteVirtualService requestSpec_spec_GrpcRoute_spec_GrpcRoute_Action_spec_GrpcRoute_Action_Target_spec_GrpcRoute_Action_Target_VirtualService = null;
            
             // populate VirtualService
            var requestSpec_spec_GrpcRoute_spec_GrpcRoute_Action_spec_GrpcRoute_Action_Target_spec_GrpcRoute_Action_Target_VirtualServiceIsNull = true;
            requestSpec_spec_GrpcRoute_spec_GrpcRoute_Action_spec_GrpcRoute_Action_Target_spec_GrpcRoute_Action_Target_VirtualService = new Amazon.AppMesh.Model.GatewayRouteVirtualService();
            System.String requestSpec_spec_GrpcRoute_spec_GrpcRoute_Action_spec_GrpcRoute_Action_Target_spec_GrpcRoute_Action_Target_VirtualService_spec_GrpcRoute_Action_Target_VirtualService = null;
            if (cmdletContext.Spec_GrpcRoute_Action_Target_VirtualService != null)
            {
                requestSpec_spec_GrpcRoute_spec_GrpcRoute_Action_spec_GrpcRoute_Action_Target_spec_GrpcRoute_Action_Target_VirtualService_spec_GrpcRoute_Action_Target_VirtualService = cmdletContext.Spec_GrpcRoute_Action_Target_VirtualService;
            }
            if (requestSpec_spec_GrpcRoute_spec_GrpcRoute_Action_spec_GrpcRoute_Action_Target_spec_GrpcRoute_Action_Target_VirtualService_spec_GrpcRoute_Action_Target_VirtualService != null)
            {
                requestSpec_spec_GrpcRoute_spec_GrpcRoute_Action_spec_GrpcRoute_Action_Target_spec_GrpcRoute_Action_Target_VirtualService.VirtualServiceName = requestSpec_spec_GrpcRoute_spec_GrpcRoute_Action_spec_GrpcRoute_Action_Target_spec_GrpcRoute_Action_Target_VirtualService_spec_GrpcRoute_Action_Target_VirtualService;
                requestSpec_spec_GrpcRoute_spec_GrpcRoute_Action_spec_GrpcRoute_Action_Target_spec_GrpcRoute_Action_Target_VirtualServiceIsNull = false;
            }
             // determine if requestSpec_spec_GrpcRoute_spec_GrpcRoute_Action_spec_GrpcRoute_Action_Target_spec_GrpcRoute_Action_Target_VirtualService should be set to null
            if (requestSpec_spec_GrpcRoute_spec_GrpcRoute_Action_spec_GrpcRoute_Action_Target_spec_GrpcRoute_Action_Target_VirtualServiceIsNull)
            {
                requestSpec_spec_GrpcRoute_spec_GrpcRoute_Action_spec_GrpcRoute_Action_Target_spec_GrpcRoute_Action_Target_VirtualService = null;
            }
            if (requestSpec_spec_GrpcRoute_spec_GrpcRoute_Action_spec_GrpcRoute_Action_Target_spec_GrpcRoute_Action_Target_VirtualService != null)
            {
                requestSpec_spec_GrpcRoute_spec_GrpcRoute_Action_spec_GrpcRoute_Action_Target.VirtualService = requestSpec_spec_GrpcRoute_spec_GrpcRoute_Action_spec_GrpcRoute_Action_Target_spec_GrpcRoute_Action_Target_VirtualService;
                requestSpec_spec_GrpcRoute_spec_GrpcRoute_Action_spec_GrpcRoute_Action_TargetIsNull = false;
            }
             // determine if requestSpec_spec_GrpcRoute_spec_GrpcRoute_Action_spec_GrpcRoute_Action_Target should be set to null
            if (requestSpec_spec_GrpcRoute_spec_GrpcRoute_Action_spec_GrpcRoute_Action_TargetIsNull)
            {
                requestSpec_spec_GrpcRoute_spec_GrpcRoute_Action_spec_GrpcRoute_Action_Target = null;
            }
            if (requestSpec_spec_GrpcRoute_spec_GrpcRoute_Action_spec_GrpcRoute_Action_Target != null)
            {
                requestSpec_spec_GrpcRoute_spec_GrpcRoute_Action.Target = requestSpec_spec_GrpcRoute_spec_GrpcRoute_Action_spec_GrpcRoute_Action_Target;
                requestSpec_spec_GrpcRoute_spec_GrpcRoute_ActionIsNull = false;
            }
             // determine if requestSpec_spec_GrpcRoute_spec_GrpcRoute_Action should be set to null
            if (requestSpec_spec_GrpcRoute_spec_GrpcRoute_ActionIsNull)
            {
                requestSpec_spec_GrpcRoute_spec_GrpcRoute_Action = null;
            }
            if (requestSpec_spec_GrpcRoute_spec_GrpcRoute_Action != null)
            {
                requestSpec_spec_GrpcRoute.Action = requestSpec_spec_GrpcRoute_spec_GrpcRoute_Action;
                requestSpec_spec_GrpcRouteIsNull = false;
            }
            Amazon.AppMesh.Model.GrpcGatewayRouteMatch requestSpec_spec_GrpcRoute_spec_GrpcRoute_Match = null;
            
             // populate Match
            var requestSpec_spec_GrpcRoute_spec_GrpcRoute_MatchIsNull = true;
            requestSpec_spec_GrpcRoute_spec_GrpcRoute_Match = new Amazon.AppMesh.Model.GrpcGatewayRouteMatch();
            System.String requestSpec_spec_GrpcRoute_spec_GrpcRoute_Match_spec_GrpcRoute_Match_ServiceName = null;
            if (cmdletContext.Spec_GrpcRoute_Match_ServiceName != null)
            {
                requestSpec_spec_GrpcRoute_spec_GrpcRoute_Match_spec_GrpcRoute_Match_ServiceName = cmdletContext.Spec_GrpcRoute_Match_ServiceName;
            }
            if (requestSpec_spec_GrpcRoute_spec_GrpcRoute_Match_spec_GrpcRoute_Match_ServiceName != null)
            {
                requestSpec_spec_GrpcRoute_spec_GrpcRoute_Match.ServiceName = requestSpec_spec_GrpcRoute_spec_GrpcRoute_Match_spec_GrpcRoute_Match_ServiceName;
                requestSpec_spec_GrpcRoute_spec_GrpcRoute_MatchIsNull = false;
            }
             // determine if requestSpec_spec_GrpcRoute_spec_GrpcRoute_Match should be set to null
            if (requestSpec_spec_GrpcRoute_spec_GrpcRoute_MatchIsNull)
            {
                requestSpec_spec_GrpcRoute_spec_GrpcRoute_Match = null;
            }
            if (requestSpec_spec_GrpcRoute_spec_GrpcRoute_Match != null)
            {
                requestSpec_spec_GrpcRoute.Match = requestSpec_spec_GrpcRoute_spec_GrpcRoute_Match;
                requestSpec_spec_GrpcRouteIsNull = false;
            }
             // determine if requestSpec_spec_GrpcRoute should be set to null
            if (requestSpec_spec_GrpcRouteIsNull)
            {
                requestSpec_spec_GrpcRoute = null;
            }
            if (requestSpec_spec_GrpcRoute != null)
            {
                request.Spec.GrpcRoute = requestSpec_spec_GrpcRoute;
                requestSpecIsNull = false;
            }
            Amazon.AppMesh.Model.HttpGatewayRoute requestSpec_spec_Http2Route = null;
            
             // populate Http2Route
            var requestSpec_spec_Http2RouteIsNull = true;
            requestSpec_spec_Http2Route = new Amazon.AppMesh.Model.HttpGatewayRoute();
            Amazon.AppMesh.Model.HttpGatewayRouteAction requestSpec_spec_Http2Route_spec_Http2Route_Action = null;
            
             // populate Action
            var requestSpec_spec_Http2Route_spec_Http2Route_ActionIsNull = true;
            requestSpec_spec_Http2Route_spec_Http2Route_Action = new Amazon.AppMesh.Model.HttpGatewayRouteAction();
            Amazon.AppMesh.Model.GatewayRouteTarget requestSpec_spec_Http2Route_spec_Http2Route_Action_spec_Http2Route_Action_Target = null;
            
             // populate Target
            var requestSpec_spec_Http2Route_spec_Http2Route_Action_spec_Http2Route_Action_TargetIsNull = true;
            requestSpec_spec_Http2Route_spec_Http2Route_Action_spec_Http2Route_Action_Target = new Amazon.AppMesh.Model.GatewayRouteTarget();
            Amazon.AppMesh.Model.GatewayRouteVirtualService requestSpec_spec_Http2Route_spec_Http2Route_Action_spec_Http2Route_Action_Target_spec_Http2Route_Action_Target_VirtualService = null;
            
             // populate VirtualService
            var requestSpec_spec_Http2Route_spec_Http2Route_Action_spec_Http2Route_Action_Target_spec_Http2Route_Action_Target_VirtualServiceIsNull = true;
            requestSpec_spec_Http2Route_spec_Http2Route_Action_spec_Http2Route_Action_Target_spec_Http2Route_Action_Target_VirtualService = new Amazon.AppMesh.Model.GatewayRouteVirtualService();
            System.String requestSpec_spec_Http2Route_spec_Http2Route_Action_spec_Http2Route_Action_Target_spec_Http2Route_Action_Target_VirtualService_spec_Http2Route_Action_Target_VirtualService = null;
            if (cmdletContext.Spec_Http2Route_Action_Target_VirtualService != null)
            {
                requestSpec_spec_Http2Route_spec_Http2Route_Action_spec_Http2Route_Action_Target_spec_Http2Route_Action_Target_VirtualService_spec_Http2Route_Action_Target_VirtualService = cmdletContext.Spec_Http2Route_Action_Target_VirtualService;
            }
            if (requestSpec_spec_Http2Route_spec_Http2Route_Action_spec_Http2Route_Action_Target_spec_Http2Route_Action_Target_VirtualService_spec_Http2Route_Action_Target_VirtualService != null)
            {
                requestSpec_spec_Http2Route_spec_Http2Route_Action_spec_Http2Route_Action_Target_spec_Http2Route_Action_Target_VirtualService.VirtualServiceName = requestSpec_spec_Http2Route_spec_Http2Route_Action_spec_Http2Route_Action_Target_spec_Http2Route_Action_Target_VirtualService_spec_Http2Route_Action_Target_VirtualService;
                requestSpec_spec_Http2Route_spec_Http2Route_Action_spec_Http2Route_Action_Target_spec_Http2Route_Action_Target_VirtualServiceIsNull = false;
            }
             // determine if requestSpec_spec_Http2Route_spec_Http2Route_Action_spec_Http2Route_Action_Target_spec_Http2Route_Action_Target_VirtualService should be set to null
            if (requestSpec_spec_Http2Route_spec_Http2Route_Action_spec_Http2Route_Action_Target_spec_Http2Route_Action_Target_VirtualServiceIsNull)
            {
                requestSpec_spec_Http2Route_spec_Http2Route_Action_spec_Http2Route_Action_Target_spec_Http2Route_Action_Target_VirtualService = null;
            }
            if (requestSpec_spec_Http2Route_spec_Http2Route_Action_spec_Http2Route_Action_Target_spec_Http2Route_Action_Target_VirtualService != null)
            {
                requestSpec_spec_Http2Route_spec_Http2Route_Action_spec_Http2Route_Action_Target.VirtualService = requestSpec_spec_Http2Route_spec_Http2Route_Action_spec_Http2Route_Action_Target_spec_Http2Route_Action_Target_VirtualService;
                requestSpec_spec_Http2Route_spec_Http2Route_Action_spec_Http2Route_Action_TargetIsNull = false;
            }
             // determine if requestSpec_spec_Http2Route_spec_Http2Route_Action_spec_Http2Route_Action_Target should be set to null
            if (requestSpec_spec_Http2Route_spec_Http2Route_Action_spec_Http2Route_Action_TargetIsNull)
            {
                requestSpec_spec_Http2Route_spec_Http2Route_Action_spec_Http2Route_Action_Target = null;
            }
            if (requestSpec_spec_Http2Route_spec_Http2Route_Action_spec_Http2Route_Action_Target != null)
            {
                requestSpec_spec_Http2Route_spec_Http2Route_Action.Target = requestSpec_spec_Http2Route_spec_Http2Route_Action_spec_Http2Route_Action_Target;
                requestSpec_spec_Http2Route_spec_Http2Route_ActionIsNull = false;
            }
             // determine if requestSpec_spec_Http2Route_spec_Http2Route_Action should be set to null
            if (requestSpec_spec_Http2Route_spec_Http2Route_ActionIsNull)
            {
                requestSpec_spec_Http2Route_spec_Http2Route_Action = null;
            }
            if (requestSpec_spec_Http2Route_spec_Http2Route_Action != null)
            {
                requestSpec_spec_Http2Route.Action = requestSpec_spec_Http2Route_spec_Http2Route_Action;
                requestSpec_spec_Http2RouteIsNull = false;
            }
            Amazon.AppMesh.Model.HttpGatewayRouteMatch requestSpec_spec_Http2Route_spec_Http2Route_Match = null;
            
             // populate Match
            var requestSpec_spec_Http2Route_spec_Http2Route_MatchIsNull = true;
            requestSpec_spec_Http2Route_spec_Http2Route_Match = new Amazon.AppMesh.Model.HttpGatewayRouteMatch();
            System.String requestSpec_spec_Http2Route_spec_Http2Route_Match_spec_Http2Route_Match_Prefix = null;
            if (cmdletContext.Spec_Http2Route_Match_Prefix != null)
            {
                requestSpec_spec_Http2Route_spec_Http2Route_Match_spec_Http2Route_Match_Prefix = cmdletContext.Spec_Http2Route_Match_Prefix;
            }
            if (requestSpec_spec_Http2Route_spec_Http2Route_Match_spec_Http2Route_Match_Prefix != null)
            {
                requestSpec_spec_Http2Route_spec_Http2Route_Match.Prefix = requestSpec_spec_Http2Route_spec_Http2Route_Match_spec_Http2Route_Match_Prefix;
                requestSpec_spec_Http2Route_spec_Http2Route_MatchIsNull = false;
            }
             // determine if requestSpec_spec_Http2Route_spec_Http2Route_Match should be set to null
            if (requestSpec_spec_Http2Route_spec_Http2Route_MatchIsNull)
            {
                requestSpec_spec_Http2Route_spec_Http2Route_Match = null;
            }
            if (requestSpec_spec_Http2Route_spec_Http2Route_Match != null)
            {
                requestSpec_spec_Http2Route.Match = requestSpec_spec_Http2Route_spec_Http2Route_Match;
                requestSpec_spec_Http2RouteIsNull = false;
            }
             // determine if requestSpec_spec_Http2Route should be set to null
            if (requestSpec_spec_Http2RouteIsNull)
            {
                requestSpec_spec_Http2Route = null;
            }
            if (requestSpec_spec_Http2Route != null)
            {
                request.Spec.Http2Route = requestSpec_spec_Http2Route;
                requestSpecIsNull = false;
            }
            Amazon.AppMesh.Model.HttpGatewayRoute requestSpec_spec_HttpRoute = null;
            
             // populate HttpRoute
            var requestSpec_spec_HttpRouteIsNull = true;
            requestSpec_spec_HttpRoute = new Amazon.AppMesh.Model.HttpGatewayRoute();
            Amazon.AppMesh.Model.HttpGatewayRouteAction requestSpec_spec_HttpRoute_spec_HttpRoute_Action = null;
            
             // populate Action
            var requestSpec_spec_HttpRoute_spec_HttpRoute_ActionIsNull = true;
            requestSpec_spec_HttpRoute_spec_HttpRoute_Action = new Amazon.AppMesh.Model.HttpGatewayRouteAction();
            Amazon.AppMesh.Model.GatewayRouteTarget requestSpec_spec_HttpRoute_spec_HttpRoute_Action_spec_HttpRoute_Action_Target = null;
            
             // populate Target
            var requestSpec_spec_HttpRoute_spec_HttpRoute_Action_spec_HttpRoute_Action_TargetIsNull = true;
            requestSpec_spec_HttpRoute_spec_HttpRoute_Action_spec_HttpRoute_Action_Target = new Amazon.AppMesh.Model.GatewayRouteTarget();
            Amazon.AppMesh.Model.GatewayRouteVirtualService requestSpec_spec_HttpRoute_spec_HttpRoute_Action_spec_HttpRoute_Action_Target_spec_HttpRoute_Action_Target_VirtualService = null;
            
             // populate VirtualService
            var requestSpec_spec_HttpRoute_spec_HttpRoute_Action_spec_HttpRoute_Action_Target_spec_HttpRoute_Action_Target_VirtualServiceIsNull = true;
            requestSpec_spec_HttpRoute_spec_HttpRoute_Action_spec_HttpRoute_Action_Target_spec_HttpRoute_Action_Target_VirtualService = new Amazon.AppMesh.Model.GatewayRouteVirtualService();
            System.String requestSpec_spec_HttpRoute_spec_HttpRoute_Action_spec_HttpRoute_Action_Target_spec_HttpRoute_Action_Target_VirtualService_spec_HttpRoute_Action_Target_VirtualService = null;
            if (cmdletContext.Spec_HttpRoute_Action_Target_VirtualService != null)
            {
                requestSpec_spec_HttpRoute_spec_HttpRoute_Action_spec_HttpRoute_Action_Target_spec_HttpRoute_Action_Target_VirtualService_spec_HttpRoute_Action_Target_VirtualService = cmdletContext.Spec_HttpRoute_Action_Target_VirtualService;
            }
            if (requestSpec_spec_HttpRoute_spec_HttpRoute_Action_spec_HttpRoute_Action_Target_spec_HttpRoute_Action_Target_VirtualService_spec_HttpRoute_Action_Target_VirtualService != null)
            {
                requestSpec_spec_HttpRoute_spec_HttpRoute_Action_spec_HttpRoute_Action_Target_spec_HttpRoute_Action_Target_VirtualService.VirtualServiceName = requestSpec_spec_HttpRoute_spec_HttpRoute_Action_spec_HttpRoute_Action_Target_spec_HttpRoute_Action_Target_VirtualService_spec_HttpRoute_Action_Target_VirtualService;
                requestSpec_spec_HttpRoute_spec_HttpRoute_Action_spec_HttpRoute_Action_Target_spec_HttpRoute_Action_Target_VirtualServiceIsNull = false;
            }
             // determine if requestSpec_spec_HttpRoute_spec_HttpRoute_Action_spec_HttpRoute_Action_Target_spec_HttpRoute_Action_Target_VirtualService should be set to null
            if (requestSpec_spec_HttpRoute_spec_HttpRoute_Action_spec_HttpRoute_Action_Target_spec_HttpRoute_Action_Target_VirtualServiceIsNull)
            {
                requestSpec_spec_HttpRoute_spec_HttpRoute_Action_spec_HttpRoute_Action_Target_spec_HttpRoute_Action_Target_VirtualService = null;
            }
            if (requestSpec_spec_HttpRoute_spec_HttpRoute_Action_spec_HttpRoute_Action_Target_spec_HttpRoute_Action_Target_VirtualService != null)
            {
                requestSpec_spec_HttpRoute_spec_HttpRoute_Action_spec_HttpRoute_Action_Target.VirtualService = requestSpec_spec_HttpRoute_spec_HttpRoute_Action_spec_HttpRoute_Action_Target_spec_HttpRoute_Action_Target_VirtualService;
                requestSpec_spec_HttpRoute_spec_HttpRoute_Action_spec_HttpRoute_Action_TargetIsNull = false;
            }
             // determine if requestSpec_spec_HttpRoute_spec_HttpRoute_Action_spec_HttpRoute_Action_Target should be set to null
            if (requestSpec_spec_HttpRoute_spec_HttpRoute_Action_spec_HttpRoute_Action_TargetIsNull)
            {
                requestSpec_spec_HttpRoute_spec_HttpRoute_Action_spec_HttpRoute_Action_Target = null;
            }
            if (requestSpec_spec_HttpRoute_spec_HttpRoute_Action_spec_HttpRoute_Action_Target != null)
            {
                requestSpec_spec_HttpRoute_spec_HttpRoute_Action.Target = requestSpec_spec_HttpRoute_spec_HttpRoute_Action_spec_HttpRoute_Action_Target;
                requestSpec_spec_HttpRoute_spec_HttpRoute_ActionIsNull = false;
            }
             // determine if requestSpec_spec_HttpRoute_spec_HttpRoute_Action should be set to null
            if (requestSpec_spec_HttpRoute_spec_HttpRoute_ActionIsNull)
            {
                requestSpec_spec_HttpRoute_spec_HttpRoute_Action = null;
            }
            if (requestSpec_spec_HttpRoute_spec_HttpRoute_Action != null)
            {
                requestSpec_spec_HttpRoute.Action = requestSpec_spec_HttpRoute_spec_HttpRoute_Action;
                requestSpec_spec_HttpRouteIsNull = false;
            }
            Amazon.AppMesh.Model.HttpGatewayRouteMatch requestSpec_spec_HttpRoute_spec_HttpRoute_Match = null;
            
             // populate Match
            var requestSpec_spec_HttpRoute_spec_HttpRoute_MatchIsNull = true;
            requestSpec_spec_HttpRoute_spec_HttpRoute_Match = new Amazon.AppMesh.Model.HttpGatewayRouteMatch();
            System.String requestSpec_spec_HttpRoute_spec_HttpRoute_Match_spec_HttpRoute_Match_Prefix = null;
            if (cmdletContext.Spec_HttpRoute_Match_Prefix != null)
            {
                requestSpec_spec_HttpRoute_spec_HttpRoute_Match_spec_HttpRoute_Match_Prefix = cmdletContext.Spec_HttpRoute_Match_Prefix;
            }
            if (requestSpec_spec_HttpRoute_spec_HttpRoute_Match_spec_HttpRoute_Match_Prefix != null)
            {
                requestSpec_spec_HttpRoute_spec_HttpRoute_Match.Prefix = requestSpec_spec_HttpRoute_spec_HttpRoute_Match_spec_HttpRoute_Match_Prefix;
                requestSpec_spec_HttpRoute_spec_HttpRoute_MatchIsNull = false;
            }
             // determine if requestSpec_spec_HttpRoute_spec_HttpRoute_Match should be set to null
            if (requestSpec_spec_HttpRoute_spec_HttpRoute_MatchIsNull)
            {
                requestSpec_spec_HttpRoute_spec_HttpRoute_Match = null;
            }
            if (requestSpec_spec_HttpRoute_spec_HttpRoute_Match != null)
            {
                requestSpec_spec_HttpRoute.Match = requestSpec_spec_HttpRoute_spec_HttpRoute_Match;
                requestSpec_spec_HttpRouteIsNull = false;
            }
             // determine if requestSpec_spec_HttpRoute should be set to null
            if (requestSpec_spec_HttpRouteIsNull)
            {
                requestSpec_spec_HttpRoute = null;
            }
            if (requestSpec_spec_HttpRoute != null)
            {
                request.Spec.HttpRoute = requestSpec_spec_HttpRoute;
                requestSpecIsNull = false;
            }
             // determine if request.Spec should be set to null
            if (requestSpecIsNull)
            {
                request.Spec = null;
            }
            if (cmdletContext.VirtualGatewayName != null)
            {
                request.VirtualGatewayName = cmdletContext.VirtualGatewayName;
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
        
        private Amazon.AppMesh.Model.UpdateGatewayRouteResponse CallAWSServiceOperation(IAmazonAppMesh client, Amazon.AppMesh.Model.UpdateGatewayRouteRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS App Mesh", "UpdateGatewayRoute");
            try
            {
                #if DESKTOP
                return client.UpdateGatewayRoute(request);
                #elif CORECLR
                return client.UpdateGatewayRouteAsync(request).GetAwaiter().GetResult();
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
            public System.String ClientToken { get; set; }
            public System.String GatewayRouteName { get; set; }
            public System.String MeshName { get; set; }
            public System.String MeshOwner { get; set; }
            public System.String Spec_GrpcRoute_Action_Target_VirtualService { get; set; }
            public System.String Spec_GrpcRoute_Match_ServiceName { get; set; }
            public System.String Spec_Http2Route_Action_Target_VirtualService { get; set; }
            public System.String Spec_Http2Route_Match_Prefix { get; set; }
            public System.String Spec_HttpRoute_Action_Target_VirtualService { get; set; }
            public System.String Spec_HttpRoute_Match_Prefix { get; set; }
            public System.String VirtualGatewayName { get; set; }
            public System.Func<Amazon.AppMesh.Model.UpdateGatewayRouteResponse, UpdateAMSHGatewayRouteCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.GatewayRoute;
        }
        
    }
}
