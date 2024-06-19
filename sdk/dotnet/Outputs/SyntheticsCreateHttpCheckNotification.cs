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
    public sealed class SyntheticsCreateHttpCheckNotification
    {
        public readonly bool? Call;
        public readonly bool? Email;
        public readonly ImmutableArray<Outputs.SyntheticsCreateHttpCheckNotificationEscalation> Escalations;
        public readonly bool? Muted;
        public readonly ImmutableArray<Outputs.SyntheticsCreateHttpCheckNotificationNotificationWindow> NotificationWindows;
        public readonly int? NotifyAfterFailureCount;
        public readonly bool? NotifyOnLocationFailure;
        public readonly ImmutableArray<Outputs.SyntheticsCreateHttpCheckNotificationNotifyWho> NotifyWhos;
        public readonly bool? Sms;

        [OutputConstructor]
        private SyntheticsCreateHttpCheckNotification(
            bool? call,

            bool? email,

            ImmutableArray<Outputs.SyntheticsCreateHttpCheckNotificationEscalation> escalations,

            bool? muted,

            ImmutableArray<Outputs.SyntheticsCreateHttpCheckNotificationNotificationWindow> notificationWindows,

            int? notifyAfterFailureCount,

            bool? notifyOnLocationFailure,

            ImmutableArray<Outputs.SyntheticsCreateHttpCheckNotificationNotifyWho> notifyWhos,

            bool? sms)
        {
            Call = call;
            Email = email;
            Escalations = escalations;
            Muted = muted;
            NotificationWindows = notificationWindows;
            NotifyAfterFailureCount = notifyAfterFailureCount;
            NotifyOnLocationFailure = notifyOnLocationFailure;
            NotifyWhos = notifyWhos;
            Sms = sms;
        }
    }
}
