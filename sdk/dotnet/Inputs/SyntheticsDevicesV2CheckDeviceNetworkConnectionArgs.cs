// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Synthetics.Inputs
{

    public sealed class SyntheticsDevicesV2CheckDeviceNetworkConnectionInputArgs : global::Pulumi.ResourceArgs
    {
        [Input("description", required: true)]
        public Input<string> Description { get; set; } = null!;

        [Input("downloadBandwidth", required: true)]
        public Input<int> DownloadBandwidth { get; set; } = null!;

        [Input("latency", required: true)]
        public Input<int> Latency { get; set; } = null!;

        [Input("packetLoss", required: true)]
        public Input<int> PacketLoss { get; set; } = null!;

        [Input("uploadBandwidth")]
        public Input<int>? UploadBandwidth { get; set; }

        public SyntheticsDevicesV2CheckDeviceNetworkConnectionInputArgs()
        {
        }
        public static new SyntheticsDevicesV2CheckDeviceNetworkConnectionInputArgs Empty => new SyntheticsDevicesV2CheckDeviceNetworkConnectionInputArgs();
    }
}
