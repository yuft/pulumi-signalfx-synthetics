// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Synthetics.Inputs
{

    public sealed class SyntheticsApiV2CheckTestArgs : global::Pulumi.InvokeArgs
    {
        [Input("active", required: true)]
        public bool Active { get; set; }

        [Input("createdAt", required: true)]
        public string CreatedAt { get; set; } = null!;

        [Input("devices", required: true)]
        private List<Inputs.SyntheticsApiV2CheckTestDeviceArgs>? _devices;
        public List<Inputs.SyntheticsApiV2CheckTestDeviceArgs> Devices
        {
            get => _devices ?? (_devices = new List<Inputs.SyntheticsApiV2CheckTestDeviceArgs>());
            set => _devices = value;
        }

        [Input("frequency", required: true)]
        public int Frequency { get; set; }

        /// <summary>
        /// The ID of this resource.
        /// </summary>
        [Input("id", required: true)]
        public int Id { get; set; }

        [Input("locationIds")]
        private List<string>? _locationIds;
        public List<string> LocationIds
        {
            get => _locationIds ?? (_locationIds = new List<string>());
            set => _locationIds = value;
        }

        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        [Input("requests", required: true)]
        private List<Inputs.SyntheticsApiV2CheckTestRequestArgs>? _requests;
        public List<Inputs.SyntheticsApiV2CheckTestRequestArgs> Requests
        {
            get => _requests ?? (_requests = new List<Inputs.SyntheticsApiV2CheckTestRequestArgs>());
            set => _requests = value;
        }

        [Input("schedulingStrategy", required: true)]
        public string SchedulingStrategy { get; set; } = null!;

        [Input("type", required: true)]
        public string Type { get; set; } = null!;

        [Input("updatedAt", required: true)]
        public string UpdatedAt { get; set; } = null!;

        public SyntheticsApiV2CheckTestArgs()
        {
        }
        public static new SyntheticsApiV2CheckTestArgs Empty => new SyntheticsApiV2CheckTestArgs();
    }
}