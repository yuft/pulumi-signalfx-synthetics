// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Synthetics.Inputs
{

    public sealed class SyntheticsCreateHttpCheckSuccessCriteriaArgs : global::Pulumi.ResourceArgs
    {
        [Input("actionType")]
        public Input<string>? ActionType { get; set; }

        [Input("comparisonString")]
        public Input<string>? ComparisonString { get; set; }

        [Input("createdAt")]
        public Input<string>? CreatedAt { get; set; }

        [Input("updatedAt")]
        public Input<string>? UpdatedAt { get; set; }

        public SyntheticsCreateHttpCheckSuccessCriteriaArgs()
        {
        }
        public static new SyntheticsCreateHttpCheckSuccessCriteriaArgs Empty => new SyntheticsCreateHttpCheckSuccessCriteriaArgs();
    }
}