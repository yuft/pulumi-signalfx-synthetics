// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Synthetics.Inputs
{

    public sealed class SyntheticsHttpV2CheckTestArgs : global::Pulumi.InvokeArgs
    {
        [Input("active", required: true)]
        public bool Active { get; set; }

        [Input("body", required: true)]
        public string Body { get; set; } = null!;

        [Input("createdAt", required: true)]
        public string CreatedAt { get; set; } = null!;

        [Input("frequency", required: true)]
        public int Frequency { get; set; }

        [Input("headers", required: true)]
        private List<Inputs.SyntheticsHttpV2CheckTestHeaderArgs>? _headers;
        public List<Inputs.SyntheticsHttpV2CheckTestHeaderArgs> Headers
        {
            get => _headers ?? (_headers = new List<Inputs.SyntheticsHttpV2CheckTestHeaderArgs>());
            set => _headers = value;
        }

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

        [Input("requestMethod", required: true)]
        public string RequestMethod { get; set; } = null!;

        [Input("schedulingStrategy", required: true)]
        public string SchedulingStrategy { get; set; } = null!;

        [Input("type", required: true)]
        public string Type { get; set; } = null!;

        [Input("updatedAt", required: true)]
        public string UpdatedAt { get; set; } = null!;

        [Input("url", required: true)]
        public string Url { get; set; } = null!;

        public SyntheticsHttpV2CheckTestArgs()
        {
        }
        public static new SyntheticsHttpV2CheckTestArgs Empty => new SyntheticsHttpV2CheckTestArgs();
    }
}
