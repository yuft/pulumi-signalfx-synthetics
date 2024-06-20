// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Synthetics
{
    public static class SyntheticsCheck
    {
        /// <summary>
        /// **Note**: This is a Rigor (Legacy) data source
        /// </summary>
        public static Task<SyntheticsCheckResult> InvokeAsync(SyntheticsCheckArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<SyntheticsCheckResult>("synthetics:index/syntheticsCheck:syntheticsCheck", args ?? new SyntheticsCheckArgs(), options.WithDefaults());

        /// <summary>
        /// **Note**: This is a Rigor (Legacy) data source
        /// </summary>
        public static Output<SyntheticsCheckResult> Invoke(SyntheticsCheckInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<SyntheticsCheckResult>("synthetics:index/syntheticsCheck:syntheticsCheck", args ?? new SyntheticsCheckInvokeArgs(), options.WithDefaults());
    }


    public sealed class SyntheticsCheckArgs : global::Pulumi.InvokeArgs
    {
        [Input("browsers")]
        private List<Inputs.SyntheticsCheckBrowserArgs>? _browsers;
        public List<Inputs.SyntheticsCheckBrowserArgs> Browsers
        {
            get => _browsers ?? (_browsers = new List<Inputs.SyntheticsCheckBrowserArgs>());
            set => _browsers = value;
        }

        [Input("checkConnections")]
        private List<Inputs.SyntheticsCheckCheckConnectionArgs>? _checkConnections;
        public List<Inputs.SyntheticsCheckCheckConnectionArgs> CheckConnections
        {
            get => _checkConnections ?? (_checkConnections = new List<Inputs.SyntheticsCheckCheckConnectionArgs>());
            set => _checkConnections = value;
        }

        [Input("cookies")]
        private List<Inputs.SyntheticsCheckCookieArgs>? _cookies;
        public List<Inputs.SyntheticsCheckCookieArgs> Cookies
        {
            get => _cookies ?? (_cookies = new List<Inputs.SyntheticsCheckCookieArgs>());
            set => _cookies = value;
        }

        [Input("createdAt")]
        public string? CreatedAt { get; set; }

        [Input("dnsOverrides")]
        private List<Inputs.SyntheticsCheckDnsOverrideArgs>? _dnsOverrides;
        public List<Inputs.SyntheticsCheckDnsOverrideArgs> DnsOverrides
        {
            get => _dnsOverrides ?? (_dnsOverrides = new List<Inputs.SyntheticsCheckDnsOverrideArgs>());
            set => _dnsOverrides = value;
        }

        [Input("excludedFiles")]
        private List<Inputs.SyntheticsCheckExcludedFileArgs>? _excludedFiles;
        public List<Inputs.SyntheticsCheckExcludedFileArgs> ExcludedFiles
        {
            get => _excludedFiles ?? (_excludedFiles = new List<Inputs.SyntheticsCheckExcludedFileArgs>());
            set => _excludedFiles = value;
        }

        [Input("frequency")]
        public int? Frequency { get; set; }

        [Input("id", required: true)]
        public int Id { get; set; }

        [Input("javascriptFiles")]
        private List<Inputs.SyntheticsCheckJavascriptFileArgs>? _javascriptFiles;
        public List<Inputs.SyntheticsCheckJavascriptFileArgs> JavascriptFiles
        {
            get => _javascriptFiles ?? (_javascriptFiles = new List<Inputs.SyntheticsCheckJavascriptFileArgs>());
            set => _javascriptFiles = value;
        }

        [Input("links")]
        private List<Inputs.SyntheticsCheckLinkArgs>? _links;
        public List<Inputs.SyntheticsCheckLinkArgs> Links
        {
            get => _links ?? (_links = new List<Inputs.SyntheticsCheckLinkArgs>());
            set => _links = value;
        }

        [Input("muted")]
        public bool? Muted { get; set; }

        [Input("paused")]
        public bool? Paused { get; set; }

        [Input("responseTimeMonitorMilliseconds")]
        public int? ResponseTimeMonitorMilliseconds { get; set; }

        [Input("steps")]
        private List<Inputs.SyntheticsCheckStepArgs>? _steps;
        public List<Inputs.SyntheticsCheckStepArgs> Steps
        {
            get => _steps ?? (_steps = new List<Inputs.SyntheticsCheckStepArgs>());
            set => _steps = value;
        }

        [Input("thresholdMonitors")]
        private List<Inputs.SyntheticsCheckThresholdMonitorArgs>? _thresholdMonitors;
        public List<Inputs.SyntheticsCheckThresholdMonitorArgs> ThresholdMonitors
        {
            get => _thresholdMonitors ?? (_thresholdMonitors = new List<Inputs.SyntheticsCheckThresholdMonitorArgs>());
            set => _thresholdMonitors = value;
        }

        [Input("type")]
        public string? Type { get; set; }

        [Input("updatedAt")]
        public string? UpdatedAt { get; set; }

        [Input("viewports")]
        private List<Inputs.SyntheticsCheckViewportArgs>? _viewports;
        public List<Inputs.SyntheticsCheckViewportArgs> Viewports
        {
            get => _viewports ?? (_viewports = new List<Inputs.SyntheticsCheckViewportArgs>());
            set => _viewports = value;
        }

        public SyntheticsCheckArgs()
        {
        }
        public static new SyntheticsCheckArgs Empty => new SyntheticsCheckArgs();
    }

    public sealed class SyntheticsCheckInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("browsers")]
        private InputList<Inputs.SyntheticsCheckBrowserInputArgs>? _browsers;
        public InputList<Inputs.SyntheticsCheckBrowserInputArgs> Browsers
        {
            get => _browsers ?? (_browsers = new InputList<Inputs.SyntheticsCheckBrowserInputArgs>());
            set => _browsers = value;
        }

        [Input("checkConnections")]
        private InputList<Inputs.SyntheticsCheckCheckConnectionInputArgs>? _checkConnections;
        public InputList<Inputs.SyntheticsCheckCheckConnectionInputArgs> CheckConnections
        {
            get => _checkConnections ?? (_checkConnections = new InputList<Inputs.SyntheticsCheckCheckConnectionInputArgs>());
            set => _checkConnections = value;
        }

        [Input("cookies")]
        private InputList<Inputs.SyntheticsCheckCookieInputArgs>? _cookies;
        public InputList<Inputs.SyntheticsCheckCookieInputArgs> Cookies
        {
            get => _cookies ?? (_cookies = new InputList<Inputs.SyntheticsCheckCookieInputArgs>());
            set => _cookies = value;
        }

        [Input("createdAt")]
        public Input<string>? CreatedAt { get; set; }

        [Input("dnsOverrides")]
        private InputList<Inputs.SyntheticsCheckDnsOverrideInputArgs>? _dnsOverrides;
        public InputList<Inputs.SyntheticsCheckDnsOverrideInputArgs> DnsOverrides
        {
            get => _dnsOverrides ?? (_dnsOverrides = new InputList<Inputs.SyntheticsCheckDnsOverrideInputArgs>());
            set => _dnsOverrides = value;
        }

        [Input("excludedFiles")]
        private InputList<Inputs.SyntheticsCheckExcludedFileInputArgs>? _excludedFiles;
        public InputList<Inputs.SyntheticsCheckExcludedFileInputArgs> ExcludedFiles
        {
            get => _excludedFiles ?? (_excludedFiles = new InputList<Inputs.SyntheticsCheckExcludedFileInputArgs>());
            set => _excludedFiles = value;
        }

        [Input("frequency")]
        public Input<int>? Frequency { get; set; }

        [Input("id", required: true)]
        public Input<int> Id { get; set; } = null!;

        [Input("javascriptFiles")]
        private InputList<Inputs.SyntheticsCheckJavascriptFileInputArgs>? _javascriptFiles;
        public InputList<Inputs.SyntheticsCheckJavascriptFileInputArgs> JavascriptFiles
        {
            get => _javascriptFiles ?? (_javascriptFiles = new InputList<Inputs.SyntheticsCheckJavascriptFileInputArgs>());
            set => _javascriptFiles = value;
        }

        [Input("links")]
        private InputList<Inputs.SyntheticsCheckLinkInputArgs>? _links;
        public InputList<Inputs.SyntheticsCheckLinkInputArgs> Links
        {
            get => _links ?? (_links = new InputList<Inputs.SyntheticsCheckLinkInputArgs>());
            set => _links = value;
        }

        [Input("muted")]
        public Input<bool>? Muted { get; set; }

        [Input("paused")]
        public Input<bool>? Paused { get; set; }

        [Input("responseTimeMonitorMilliseconds")]
        public Input<int>? ResponseTimeMonitorMilliseconds { get; set; }

        [Input("steps")]
        private InputList<Inputs.SyntheticsCheckStepInputArgs>? _steps;
        public InputList<Inputs.SyntheticsCheckStepInputArgs> Steps
        {
            get => _steps ?? (_steps = new InputList<Inputs.SyntheticsCheckStepInputArgs>());
            set => _steps = value;
        }

        [Input("thresholdMonitors")]
        private InputList<Inputs.SyntheticsCheckThresholdMonitorInputArgs>? _thresholdMonitors;
        public InputList<Inputs.SyntheticsCheckThresholdMonitorInputArgs> ThresholdMonitors
        {
            get => _thresholdMonitors ?? (_thresholdMonitors = new InputList<Inputs.SyntheticsCheckThresholdMonitorInputArgs>());
            set => _thresholdMonitors = value;
        }

        [Input("type")]
        public Input<string>? Type { get; set; }

        [Input("updatedAt")]
        public Input<string>? UpdatedAt { get; set; }

        [Input("viewports")]
        private InputList<Inputs.SyntheticsCheckViewportInputArgs>? _viewports;
        public InputList<Inputs.SyntheticsCheckViewportInputArgs> Viewports
        {
            get => _viewports ?? (_viewports = new InputList<Inputs.SyntheticsCheckViewportInputArgs>());
            set => _viewports = value;
        }

        public SyntheticsCheckInvokeArgs()
        {
        }
        public static new SyntheticsCheckInvokeArgs Empty => new SyntheticsCheckInvokeArgs();
    }


    [OutputType]
    public sealed class SyntheticsCheckResult
    {
        public readonly bool AutoRetry;
        public readonly ImmutableArray<Outputs.SyntheticsCheckBlackoutPeriodResult> BlackoutPeriods;
        public readonly ImmutableArray<Outputs.SyntheticsCheckBrowserResult> Browsers;
        public readonly ImmutableArray<Outputs.SyntheticsCheckCheckConnectionResult> CheckConnections;
        public readonly ImmutableArray<Outputs.SyntheticsCheckCookieResult> Cookies;
        public readonly string CreatedAt;
        public readonly ImmutableArray<Outputs.SyntheticsCheckDnsOverrideResult> DnsOverrides;
        public readonly bool Enabled;
        public readonly ImmutableArray<Outputs.SyntheticsCheckExcludedFileResult> ExcludedFiles;
        public readonly int Frequency;
        public readonly string HttpMethod;
        public readonly string HttpRequestBody;
        public readonly ImmutableArray<Outputs.SyntheticsCheckHttpRequestHeaderResult> HttpRequestHeaders;
        /// <summary>
        /// The ID of this resource.
        /// </summary>
        public readonly int Id;
        public readonly ImmutableArray<Outputs.SyntheticsCheckIntegrationResult> Integrations;
        public readonly ImmutableArray<Outputs.SyntheticsCheckJavascriptFileResult> JavascriptFiles;
        public readonly ImmutableArray<Outputs.SyntheticsCheckLinkResult> Links;
        public readonly ImmutableArray<Outputs.SyntheticsCheckLocationResult> Locations;
        public readonly bool Muted;
        public readonly string Name;
        public readonly ImmutableArray<Outputs.SyntheticsCheckNotificationResult> Notifications;
        public readonly bool Paused;
        public readonly int ResponseTimeMonitorMilliseconds;
        public readonly bool RoundRobin;
        public readonly ImmutableArray<Outputs.SyntheticsCheckStatusResult> Statuses;
        public readonly ImmutableArray<Outputs.SyntheticsCheckStepResult> Steps;
        public readonly ImmutableArray<Outputs.SyntheticsCheckSuccessCriteriaResult> SuccessCriterias;
        public readonly ImmutableArray<Outputs.SyntheticsCheckTagResult> Tags;
        public readonly ImmutableArray<Outputs.SyntheticsCheckThresholdMonitorResult> ThresholdMonitors;
        public readonly string Type;
        public readonly string UpdatedAt;
        public readonly string Url;
        public readonly ImmutableArray<Outputs.SyntheticsCheckViewportResult> Viewports;

        [OutputConstructor]
        private SyntheticsCheckResult(
            bool autoRetry,

            ImmutableArray<Outputs.SyntheticsCheckBlackoutPeriodResult> blackoutPeriods,

            ImmutableArray<Outputs.SyntheticsCheckBrowserResult> browsers,

            ImmutableArray<Outputs.SyntheticsCheckCheckConnectionResult> checkConnections,

            ImmutableArray<Outputs.SyntheticsCheckCookieResult> cookies,

            string createdAt,

            ImmutableArray<Outputs.SyntheticsCheckDnsOverrideResult> dnsOverrides,

            bool enabled,

            ImmutableArray<Outputs.SyntheticsCheckExcludedFileResult> excludedFiles,

            int frequency,

            string httpMethod,

            string httpRequestBody,

            ImmutableArray<Outputs.SyntheticsCheckHttpRequestHeaderResult> httpRequestHeaders,

            int id,

            ImmutableArray<Outputs.SyntheticsCheckIntegrationResult> integrations,

            ImmutableArray<Outputs.SyntheticsCheckJavascriptFileResult> javascriptFiles,

            ImmutableArray<Outputs.SyntheticsCheckLinkResult> links,

            ImmutableArray<Outputs.SyntheticsCheckLocationResult> locations,

            bool muted,

            string name,

            ImmutableArray<Outputs.SyntheticsCheckNotificationResult> notifications,

            bool paused,

            int responseTimeMonitorMilliseconds,

            bool roundRobin,

            ImmutableArray<Outputs.SyntheticsCheckStatusResult> statuses,

            ImmutableArray<Outputs.SyntheticsCheckStepResult> steps,

            ImmutableArray<Outputs.SyntheticsCheckSuccessCriteriaResult> successCriterias,

            ImmutableArray<Outputs.SyntheticsCheckTagResult> tags,

            ImmutableArray<Outputs.SyntheticsCheckThresholdMonitorResult> thresholdMonitors,

            string type,

            string updatedAt,

            string url,

            ImmutableArray<Outputs.SyntheticsCheckViewportResult> viewports)
        {
            AutoRetry = autoRetry;
            BlackoutPeriods = blackoutPeriods;
            Browsers = browsers;
            CheckConnections = checkConnections;
            Cookies = cookies;
            CreatedAt = createdAt;
            DnsOverrides = dnsOverrides;
            Enabled = enabled;
            ExcludedFiles = excludedFiles;
            Frequency = frequency;
            HttpMethod = httpMethod;
            HttpRequestBody = httpRequestBody;
            HttpRequestHeaders = httpRequestHeaders;
            Id = id;
            Integrations = integrations;
            JavascriptFiles = javascriptFiles;
            Links = links;
            Locations = locations;
            Muted = muted;
            Name = name;
            Notifications = notifications;
            Paused = paused;
            ResponseTimeMonitorMilliseconds = responseTimeMonitorMilliseconds;
            RoundRobin = roundRobin;
            Statuses = statuses;
            Steps = steps;
            SuccessCriterias = successCriterias;
            Tags = tags;
            ThresholdMonitors = thresholdMonitors;
            Type = type;
            UpdatedAt = updatedAt;
            Url = url;
            Viewports = viewports;
        }
    }
}