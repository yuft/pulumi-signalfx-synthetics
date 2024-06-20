// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Synthetics.Inputs
{

    public sealed class SyntheticsBrowserV2CheckTestAdvancedSettingInputArgs : global::Pulumi.ResourceArgs
    {
        [Input("authentications", required: true)]
        private InputList<Inputs.SyntheticsBrowserV2CheckTestAdvancedSettingAuthenticationInputArgs>? _authentications;
        public InputList<Inputs.SyntheticsBrowserV2CheckTestAdvancedSettingAuthenticationInputArgs> Authentications
        {
            get => _authentications ?? (_authentications = new InputList<Inputs.SyntheticsBrowserV2CheckTestAdvancedSettingAuthenticationInputArgs>());
            set => _authentications = value;
        }

        [Input("cookies", required: true)]
        private InputList<Inputs.SyntheticsBrowserV2CheckTestAdvancedSettingCookieInputArgs>? _cookies;
        public InputList<Inputs.SyntheticsBrowserV2CheckTestAdvancedSettingCookieInputArgs> Cookies
        {
            get => _cookies ?? (_cookies = new InputList<Inputs.SyntheticsBrowserV2CheckTestAdvancedSettingCookieInputArgs>());
            set => _cookies = value;
        }

        [Input("headers", required: true)]
        private InputList<Inputs.SyntheticsBrowserV2CheckTestAdvancedSettingHeaderInputArgs>? _headers;
        public InputList<Inputs.SyntheticsBrowserV2CheckTestAdvancedSettingHeaderInputArgs> Headers
        {
            get => _headers ?? (_headers = new InputList<Inputs.SyntheticsBrowserV2CheckTestAdvancedSettingHeaderInputArgs>());
            set => _headers = value;
        }

        [Input("hostOverrides", required: true)]
        private InputList<Inputs.SyntheticsBrowserV2CheckTestAdvancedSettingHostOverrideInputArgs>? _hostOverrides;
        public InputList<Inputs.SyntheticsBrowserV2CheckTestAdvancedSettingHostOverrideInputArgs> HostOverrides
        {
            get => _hostOverrides ?? (_hostOverrides = new InputList<Inputs.SyntheticsBrowserV2CheckTestAdvancedSettingHostOverrideInputArgs>());
            set => _hostOverrides = value;
        }

        [Input("userAgent", required: true)]
        public Input<string> UserAgent { get; set; } = null!;

        [Input("verifyCertificates", required: true)]
        public Input<bool> VerifyCertificates { get; set; } = null!;

        public SyntheticsBrowserV2CheckTestAdvancedSettingInputArgs()
        {
        }
        public static new SyntheticsBrowserV2CheckTestAdvancedSettingInputArgs Empty => new SyntheticsBrowserV2CheckTestAdvancedSettingInputArgs();
    }
}