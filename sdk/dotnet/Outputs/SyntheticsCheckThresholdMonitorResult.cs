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
    public sealed class SyntheticsCheckThresholdMonitorResult
    {
        public readonly string? ComparisonType;
        public readonly string? Matcher;
        public readonly string? MetricName;
        public readonly int? Value;

        [OutputConstructor]
        private SyntheticsCheckThresholdMonitorResult(
            string? comparisonType,

            string? matcher,

            string? metricName,

            int? value)
        {
            ComparisonType = comparisonType;
            Matcher = matcher;
            MetricName = metricName;
            Value = value;
        }
    }
}
