// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Synthetics.Inputs
{

    public sealed class SyntheticsCheckCheckConnectionArgs : global::Pulumi.InvokeArgs
    {
        [Input("downloadBandwidth", required: true)]
        public int DownloadBandwidth { get; set; }

        [Input("latency", required: true)]
        public int Latency { get; set; }

        [Input("packetLoss", required: true)]
        public int PacketLoss { get; set; }

        [Input("uploadBandwidth", required: true)]
        public int UploadBandwidth { get; set; }

        public SyntheticsCheckCheckConnectionArgs()
        {
        }
        public static new SyntheticsCheckCheckConnectionArgs Empty => new SyntheticsCheckCheckConnectionArgs();
    }
}