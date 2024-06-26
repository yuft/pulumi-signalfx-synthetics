// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Synthetics.Inputs
{

    public sealed class SyntheticsApiV2CheckTestDeviceArgs : global::Pulumi.InvokeArgs
    {
        [Input("id", required: true)]
        public int Id { get; set; }

        [Input("label", required: true)]
        public string Label { get; set; } = null!;

        [Input("networkConnections", required: true)]
        private List<Inputs.SyntheticsApiV2CheckTestDeviceNetworkConnectionArgs>? _networkConnections;
        public List<Inputs.SyntheticsApiV2CheckTestDeviceNetworkConnectionArgs> NetworkConnections
        {
            get => _networkConnections ?? (_networkConnections = new List<Inputs.SyntheticsApiV2CheckTestDeviceNetworkConnectionArgs>());
            set => _networkConnections = value;
        }

        [Input("userAgent", required: true)]
        public string UserAgent { get; set; } = null!;

        [Input("viewportHeight")]
        public int? ViewportHeight { get; set; }

        [Input("viewportWidth")]
        public int? ViewportWidth { get; set; }

        public SyntheticsApiV2CheckTestDeviceArgs()
        {
        }
        public static new SyntheticsApiV2CheckTestDeviceArgs Empty => new SyntheticsApiV2CheckTestDeviceArgs();
    }
}
