// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Synthetics.Inputs
{

    public sealed class SyntheticsCreateApiCheckV2TestArgs : global::Pulumi.ResourceArgs
    {
        [Input("active", required: true)]
        public Input<bool> Active { get; set; } = null!;

        [Input("deviceId", required: true)]
        public Input<int> DeviceId { get; set; } = null!;

        [Input("frequency", required: true)]
        public Input<int> Frequency { get; set; } = null!;

        [Input("locationIds", required: true)]
        private InputList<string>? _locationIds;
        public InputList<string> LocationIds
        {
            get => _locationIds ?? (_locationIds = new InputList<string>());
            set => _locationIds = value;
        }

        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("requests")]
        private InputList<Inputs.SyntheticsCreateApiCheckV2TestRequestArgs>? _requests;
        public InputList<Inputs.SyntheticsCreateApiCheckV2TestRequestArgs> Requests
        {
            get => _requests ?? (_requests = new InputList<Inputs.SyntheticsCreateApiCheckV2TestRequestArgs>());
            set => _requests = value;
        }

        [Input("schedulingStrategy")]
        public Input<string>? SchedulingStrategy { get; set; }

        public SyntheticsCreateApiCheckV2TestArgs()
        {
        }
        public static new SyntheticsCreateApiCheckV2TestArgs Empty => new SyntheticsCreateApiCheckV2TestArgs();
    }
}