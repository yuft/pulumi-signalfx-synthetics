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
    public sealed class SyntheticsCreateApiCheckV2TestRequestValidation
    {
        public readonly string? Actual;
        public readonly string? Comparator;
        public readonly string? Expected;
        public readonly string? Name;
        public readonly string? Type;

        [OutputConstructor]
        private SyntheticsCreateApiCheckV2TestRequestValidation(
            string? actual,

            string? comparator,

            string? expected,

            string? name,

            string? type)
        {
            Actual = actual;
            Comparator = comparator;
            Expected = expected;
            Name = name;
            Type = type;
        }
    }
}
