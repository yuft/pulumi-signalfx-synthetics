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
    public sealed class SyntheticsCheckStatusResult
    {
        public readonly bool HasFailure;
        public readonly bool HasLocationFailure;
        public readonly string LastAlertAt;
        public readonly int LastCode;
        public readonly string LastFailureAt;
        public readonly string LastMessage;
        public readonly int LastResponseTime;
        public readonly string LastRunAt;

        [OutputConstructor]
        private SyntheticsCheckStatusResult(
            bool hasFailure,

            bool hasLocationFailure,

            string lastAlertAt,

            int lastCode,

            string lastFailureAt,

            string lastMessage,

            int lastResponseTime,

            string lastRunAt)
        {
            HasFailure = hasFailure;
            HasLocationFailure = hasLocationFailure;
            LastAlertAt = lastAlertAt;
            LastCode = lastCode;
            LastFailureAt = lastFailureAt;
            LastMessage = lastMessage;
            LastResponseTime = lastResponseTime;
            LastRunAt = lastRunAt;
        }
    }
}
