// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Synthetics.Inputs
{

    public sealed class SyntheticsCheckThresholdMonitorArgs : global::Pulumi.InvokeArgs
    {
        [Input("comparisonType")]
        public string? ComparisonType { get; set; }

        [Input("matcher")]
        public string? Matcher { get; set; }

        [Input("metricName")]
        public string? MetricName { get; set; }

        [Input("value")]
        public int? Value { get; set; }

        public SyntheticsCheckThresholdMonitorArgs()
        {
        }
        public static new SyntheticsCheckThresholdMonitorArgs Empty => new SyntheticsCheckThresholdMonitorArgs();
    }
}
