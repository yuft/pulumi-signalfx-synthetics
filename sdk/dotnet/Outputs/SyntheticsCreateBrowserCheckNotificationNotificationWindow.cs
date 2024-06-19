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
    public sealed class SyntheticsCreateBrowserCheckNotificationNotificationWindow
    {
        public readonly int? DurationInMinutes;
        public readonly string? EndTime;
        public readonly string? StartTime;
        public readonly string? TimeZone;

        [OutputConstructor]
        private SyntheticsCreateBrowserCheckNotificationNotificationWindow(
            int? durationInMinutes,

            string? endTime,

            string? startTime,

            string? timeZone)
        {
            DurationInMinutes = durationInMinutes;
            EndTime = endTime;
            StartTime = startTime;
            TimeZone = timeZone;
        }
    }
}
