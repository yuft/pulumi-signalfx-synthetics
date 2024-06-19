// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Synthetics.Inputs
{

    public sealed class SyntheticsCreateBrowserCheckNotificationArgs : global::Pulumi.ResourceArgs
    {
        [Input("call")]
        public Input<bool>? Call { get; set; }

        [Input("email")]
        public Input<bool>? Email { get; set; }

        [Input("escalations")]
        private InputList<Inputs.SyntheticsCreateBrowserCheckNotificationEscalationArgs>? _escalations;
        public InputList<Inputs.SyntheticsCreateBrowserCheckNotificationEscalationArgs> Escalations
        {
            get => _escalations ?? (_escalations = new InputList<Inputs.SyntheticsCreateBrowserCheckNotificationEscalationArgs>());
            set => _escalations = value;
        }

        [Input("muted")]
        public Input<bool>? Muted { get; set; }

        [Input("notificationWindows")]
        private InputList<Inputs.SyntheticsCreateBrowserCheckNotificationNotificationWindowArgs>? _notificationWindows;
        public InputList<Inputs.SyntheticsCreateBrowserCheckNotificationNotificationWindowArgs> NotificationWindows
        {
            get => _notificationWindows ?? (_notificationWindows = new InputList<Inputs.SyntheticsCreateBrowserCheckNotificationNotificationWindowArgs>());
            set => _notificationWindows = value;
        }

        [Input("notifyAfterFailureCount")]
        public Input<int>? NotifyAfterFailureCount { get; set; }

        [Input("notifyOnLocationFailure")]
        public Input<bool>? NotifyOnLocationFailure { get; set; }

        [Input("notifyWhos")]
        private InputList<Inputs.SyntheticsCreateBrowserCheckNotificationNotifyWhoArgs>? _notifyWhos;
        public InputList<Inputs.SyntheticsCreateBrowserCheckNotificationNotifyWhoArgs> NotifyWhos
        {
            get => _notifyWhos ?? (_notifyWhos = new InputList<Inputs.SyntheticsCreateBrowserCheckNotificationNotifyWhoArgs>());
            set => _notifyWhos = value;
        }

        [Input("sms")]
        public Input<bool>? Sms { get; set; }

        public SyntheticsCreateBrowserCheckNotificationArgs()
        {
        }
        public static new SyntheticsCreateBrowserCheckNotificationArgs Empty => new SyntheticsCreateBrowserCheckNotificationArgs();
    }
}
