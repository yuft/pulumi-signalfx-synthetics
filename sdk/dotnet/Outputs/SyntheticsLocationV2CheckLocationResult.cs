// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Synthetics.Outputs
{

    [OutputType]
    public sealed class SyntheticsLocationV2CheckLocationResult
    {
        public readonly string Country;
        public readonly bool Default;
        /// <summary>
        /// The ID of this resource.
        /// </summary>
        public readonly string Id;
        public readonly string Label;
        public readonly string Type;

        [OutputConstructor]
        private SyntheticsLocationV2CheckLocationResult(
            string country,

            bool @default,

            string id,

            string label,

            string type)
        {
            Country = country;
            Default = @default;
            Id = id;
            Label = label;
            Type = type;
        }
    }
}
