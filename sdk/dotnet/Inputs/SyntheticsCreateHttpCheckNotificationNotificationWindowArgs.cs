// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Synthetics.Inputs
{

    public sealed class SyntheticsCreateHttpCheckNotificationNotificationWindowArgs : global::Pulumi.ResourceArgs
    {
        [Input("durationInMinutes")]
        public Input<int>? DurationInMinutes { get; set; }

        [Input("endTime")]
        public Input<string>? EndTime { get; set; }

        [Input("startTime")]
        public Input<string>? StartTime { get; set; }

        [Input("timeZone")]
        public Input<string>? TimeZone { get; set; }

        public SyntheticsCreateHttpCheckNotificationNotificationWindowArgs()
        {
        }
        public static new SyntheticsCreateHttpCheckNotificationNotificationWindowArgs Empty => new SyntheticsCreateHttpCheckNotificationNotificationWindowArgs();
    }
}
