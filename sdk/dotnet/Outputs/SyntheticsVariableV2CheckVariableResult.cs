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
    public sealed class SyntheticsVariableV2CheckVariableResult
    {
        public readonly string CreatedAt;
        public readonly string Description;
        /// <summary>
        /// The ID of this resource.
        /// </summary>
        public readonly int Id;
        public readonly string Name;
        public readonly bool Secret;
        public readonly string UpdatedAt;
        public readonly string Value;

        [OutputConstructor]
        private SyntheticsVariableV2CheckVariableResult(
            string createdAt,

            string description,

            int id,

            string name,

            bool secret,

            string updatedAt,

            string value)
        {
            CreatedAt = createdAt;
            Description = description;
            Id = id;
            Name = name;
            Secret = secret;
            UpdatedAt = updatedAt;
            Value = value;
        }
    }
}
