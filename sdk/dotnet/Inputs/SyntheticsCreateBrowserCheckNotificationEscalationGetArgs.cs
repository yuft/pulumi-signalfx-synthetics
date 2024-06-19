// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Synthetics.Inputs
{

    public sealed class SyntheticsCreateBrowserCheckNotificationEscalationGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("afterMinutes")]
        public Input<int>? AfterMinutes { get; set; }

        [Input("call")]
        public Input<bool>? Call { get; set; }

        [Input("email")]
        public Input<bool>? Email { get; set; }

        [Input("isRepeat")]
        public Input<bool>? IsRepeat { get; set; }

        [Input("notificationWindows")]
        private InputList<Inputs.SyntheticsCreateBrowserCheckNotificationEscalationNotificationWindowGetArgs>? _notificationWindows;
        public InputList<Inputs.SyntheticsCreateBrowserCheckNotificationEscalationNotificationWindowGetArgs> NotificationWindows
        {
            get => _notificationWindows ?? (_notificationWindows = new InputList<Inputs.SyntheticsCreateBrowserCheckNotificationEscalationNotificationWindowGetArgs>());
            set => _notificationWindows = value;
        }

        [Input("notifyWhos")]
        private InputList<Inputs.SyntheticsCreateBrowserCheckNotificationEscalationNotifyWhoGetArgs>? _notifyWhos;
        public InputList<Inputs.SyntheticsCreateBrowserCheckNotificationEscalationNotifyWhoGetArgs> NotifyWhos
        {
            get => _notifyWhos ?? (_notifyWhos = new InputList<Inputs.SyntheticsCreateBrowserCheckNotificationEscalationNotifyWhoGetArgs>());
            set => _notifyWhos = value;
        }

        [Input("sms")]
        public Input<bool>? Sms { get; set; }

        public SyntheticsCreateBrowserCheckNotificationEscalationGetArgs()
        {
        }
        public static new SyntheticsCreateBrowserCheckNotificationEscalationGetArgs Empty => new SyntheticsCreateBrowserCheckNotificationEscalationGetArgs();
    }
}
