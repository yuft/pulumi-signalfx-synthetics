// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Synthetics.Inputs
{

    public sealed class SyntheticsDevicesV2CheckDeviceArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// The ID of this resource.
        /// </summary>
        [Input("id", required: true)]
        public int Id { get; set; }

        [Input("label", required: true)]
        public string Label { get; set; } = null!;

        [Input("networkConnections", required: true)]
        private List<Inputs.SyntheticsDevicesV2CheckDeviceNetworkConnectionArgs>? _networkConnections;
        public List<Inputs.SyntheticsDevicesV2CheckDeviceNetworkConnectionArgs> NetworkConnections
        {
            get => _networkConnections ?? (_networkConnections = new List<Inputs.SyntheticsDevicesV2CheckDeviceNetworkConnectionArgs>());
            set => _networkConnections = value;
        }

        [Input("userAgent", required: true)]
        public string UserAgent { get; set; } = null!;

        [Input("viewportHeight", required: true)]
        public int ViewportHeight { get; set; }

        [Input("viewportWidth", required: true)]
        public int ViewportWidth { get; set; }

        public SyntheticsDevicesV2CheckDeviceArgs()
        {
        }
        public static new SyntheticsDevicesV2CheckDeviceArgs Empty => new SyntheticsDevicesV2CheckDeviceArgs();
    }
}