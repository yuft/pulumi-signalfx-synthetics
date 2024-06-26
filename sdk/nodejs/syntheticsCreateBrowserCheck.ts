// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * **Note**: This is a Rigor (Legacy) resource
 */
export class SyntheticsCreateBrowserCheck extends pulumi.CustomResource {
    /**
     * Get an existing SyntheticsCreateBrowserCheck resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: SyntheticsCreateBrowserCheckState, opts?: pulumi.CustomResourceOptions): SyntheticsCreateBrowserCheck {
        return new SyntheticsCreateBrowserCheck(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'synthetics:index/syntheticsCreateBrowserCheck:SyntheticsCreateBrowserCheck';

    /**
     * Returns true if the given object is an instance of SyntheticsCreateBrowserCheck.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is SyntheticsCreateBrowserCheck {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === SyntheticsCreateBrowserCheck.__pulumiType;
    }

    public readonly autoRetry!: pulumi.Output<boolean | undefined>;
    public readonly autoUpdateUserAgent!: pulumi.Output<boolean | undefined>;
    public readonly blackoutPeriods!: pulumi.Output<outputs.SyntheticsCreateBrowserCheckBlackoutPeriod[] | undefined>;
    public readonly browsers!: pulumi.Output<outputs.SyntheticsCreateBrowserCheckBrowser[] | undefined>;
    public readonly checkConnections!: pulumi.Output<outputs.SyntheticsCreateBrowserCheckCheckConnection[] | undefined>;
    public readonly cookies!: pulumi.Output<outputs.SyntheticsCreateBrowserCheckCookie[] | undefined>;
    public readonly dnsOverrides!: pulumi.Output<outputs.SyntheticsCreateBrowserCheckDnsOverride[] | undefined>;
    public readonly enabled!: pulumi.Output<boolean | undefined>;
    public readonly enforceSslValidation!: pulumi.Output<boolean | undefined>;
    public readonly excludedFiles!: pulumi.Output<outputs.SyntheticsCreateBrowserCheckExcludedFile[] | undefined>;
    public readonly frequency!: pulumi.Output<number>;
    public readonly httpMethod!: pulumi.Output<string | undefined>;
    public readonly httpRequestBody!: pulumi.Output<string | undefined>;
    public readonly httpRequestHeaders!: pulumi.Output<outputs.SyntheticsCreateBrowserCheckHttpRequestHeader[] | undefined>;
    public readonly integrations!: pulumi.Output<number[] | undefined>;
    public readonly javascriptFiles!: pulumi.Output<outputs.SyntheticsCreateBrowserCheckJavascriptFile[] | undefined>;
    public readonly lastUpdated!: pulumi.Output<string>;
    public readonly locations!: pulumi.Output<number[] | undefined>;
    public readonly name!: pulumi.Output<string>;
    public readonly notifications!: pulumi.Output<outputs.SyntheticsCreateBrowserCheckNotification[] | undefined>;
    public readonly roundRobin!: pulumi.Output<boolean | undefined>;
    public readonly steps!: pulumi.Output<outputs.SyntheticsCreateBrowserCheckStep[] | undefined>;
    public readonly successCriterias!: pulumi.Output<outputs.SyntheticsCreateBrowserCheckSuccessCriteria[] | undefined>;
    public readonly tags!: pulumi.Output<string[] | undefined>;
    public readonly thresholdMonitors!: pulumi.Output<outputs.SyntheticsCreateBrowserCheckThresholdMonitor[] | undefined>;
    public readonly type!: pulumi.Output<string | undefined>;
    public readonly url!: pulumi.Output<string>;
    public readonly userAgent!: pulumi.Output<string | undefined>;
    public readonly viewports!: pulumi.Output<outputs.SyntheticsCreateBrowserCheckViewport[] | undefined>;
    public readonly waitForFullMetrics!: pulumi.Output<boolean | undefined>;

    /**
     * Create a SyntheticsCreateBrowserCheck resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: SyntheticsCreateBrowserCheckArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: SyntheticsCreateBrowserCheckArgs | SyntheticsCreateBrowserCheckState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as SyntheticsCreateBrowserCheckState | undefined;
            resourceInputs["autoRetry"] = state ? state.autoRetry : undefined;
            resourceInputs["autoUpdateUserAgent"] = state ? state.autoUpdateUserAgent : undefined;
            resourceInputs["blackoutPeriods"] = state ? state.blackoutPeriods : undefined;
            resourceInputs["browsers"] = state ? state.browsers : undefined;
            resourceInputs["checkConnections"] = state ? state.checkConnections : undefined;
            resourceInputs["cookies"] = state ? state.cookies : undefined;
            resourceInputs["dnsOverrides"] = state ? state.dnsOverrides : undefined;
            resourceInputs["enabled"] = state ? state.enabled : undefined;
            resourceInputs["enforceSslValidation"] = state ? state.enforceSslValidation : undefined;
            resourceInputs["excludedFiles"] = state ? state.excludedFiles : undefined;
            resourceInputs["frequency"] = state ? state.frequency : undefined;
            resourceInputs["httpMethod"] = state ? state.httpMethod : undefined;
            resourceInputs["httpRequestBody"] = state ? state.httpRequestBody : undefined;
            resourceInputs["httpRequestHeaders"] = state ? state.httpRequestHeaders : undefined;
            resourceInputs["integrations"] = state ? state.integrations : undefined;
            resourceInputs["javascriptFiles"] = state ? state.javascriptFiles : undefined;
            resourceInputs["lastUpdated"] = state ? state.lastUpdated : undefined;
            resourceInputs["locations"] = state ? state.locations : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["notifications"] = state ? state.notifications : undefined;
            resourceInputs["roundRobin"] = state ? state.roundRobin : undefined;
            resourceInputs["steps"] = state ? state.steps : undefined;
            resourceInputs["successCriterias"] = state ? state.successCriterias : undefined;
            resourceInputs["tags"] = state ? state.tags : undefined;
            resourceInputs["thresholdMonitors"] = state ? state.thresholdMonitors : undefined;
            resourceInputs["type"] = state ? state.type : undefined;
            resourceInputs["url"] = state ? state.url : undefined;
            resourceInputs["userAgent"] = state ? state.userAgent : undefined;
            resourceInputs["viewports"] = state ? state.viewports : undefined;
            resourceInputs["waitForFullMetrics"] = state ? state.waitForFullMetrics : undefined;
        } else {
            const args = argsOrState as SyntheticsCreateBrowserCheckArgs | undefined;
            if ((!args || args.frequency === undefined) && !opts.urn) {
                throw new Error("Missing required property 'frequency'");
            }
            if ((!args || args.url === undefined) && !opts.urn) {
                throw new Error("Missing required property 'url'");
            }
            resourceInputs["autoRetry"] = args ? args.autoRetry : undefined;
            resourceInputs["autoUpdateUserAgent"] = args ? args.autoUpdateUserAgent : undefined;
            resourceInputs["blackoutPeriods"] = args ? args.blackoutPeriods : undefined;
            resourceInputs["browsers"] = args ? args.browsers : undefined;
            resourceInputs["checkConnections"] = args ? args.checkConnections : undefined;
            resourceInputs["cookies"] = args ? args.cookies : undefined;
            resourceInputs["dnsOverrides"] = args ? args.dnsOverrides : undefined;
            resourceInputs["enabled"] = args ? args.enabled : undefined;
            resourceInputs["enforceSslValidation"] = args ? args.enforceSslValidation : undefined;
            resourceInputs["excludedFiles"] = args ? args.excludedFiles : undefined;
            resourceInputs["frequency"] = args ? args.frequency : undefined;
            resourceInputs["httpMethod"] = args ? args.httpMethod : undefined;
            resourceInputs["httpRequestBody"] = args ? args.httpRequestBody : undefined;
            resourceInputs["httpRequestHeaders"] = args ? args.httpRequestHeaders : undefined;
            resourceInputs["integrations"] = args ? args.integrations : undefined;
            resourceInputs["javascriptFiles"] = args ? args.javascriptFiles : undefined;
            resourceInputs["lastUpdated"] = args ? args.lastUpdated : undefined;
            resourceInputs["locations"] = args ? args.locations : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["notifications"] = args ? args.notifications : undefined;
            resourceInputs["roundRobin"] = args ? args.roundRobin : undefined;
            resourceInputs["steps"] = args ? args.steps : undefined;
            resourceInputs["successCriterias"] = args ? args.successCriterias : undefined;
            resourceInputs["tags"] = args ? args.tags : undefined;
            resourceInputs["thresholdMonitors"] = args ? args.thresholdMonitors : undefined;
            resourceInputs["type"] = args ? args.type : undefined;
            resourceInputs["url"] = args ? args.url : undefined;
            resourceInputs["userAgent"] = args ? args.userAgent : undefined;
            resourceInputs["viewports"] = args ? args.viewports : undefined;
            resourceInputs["waitForFullMetrics"] = args ? args.waitForFullMetrics : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(SyntheticsCreateBrowserCheck.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering SyntheticsCreateBrowserCheck resources.
 */
export interface SyntheticsCreateBrowserCheckState {
    autoRetry?: pulumi.Input<boolean>;
    autoUpdateUserAgent?: pulumi.Input<boolean>;
    blackoutPeriods?: pulumi.Input<pulumi.Input<inputs.SyntheticsCreateBrowserCheckBlackoutPeriod>[]>;
    browsers?: pulumi.Input<pulumi.Input<inputs.SyntheticsCreateBrowserCheckBrowser>[]>;
    checkConnections?: pulumi.Input<pulumi.Input<inputs.SyntheticsCreateBrowserCheckCheckConnection>[]>;
    cookies?: pulumi.Input<pulumi.Input<inputs.SyntheticsCreateBrowserCheckCookie>[]>;
    dnsOverrides?: pulumi.Input<pulumi.Input<inputs.SyntheticsCreateBrowserCheckDnsOverride>[]>;
    enabled?: pulumi.Input<boolean>;
    enforceSslValidation?: pulumi.Input<boolean>;
    excludedFiles?: pulumi.Input<pulumi.Input<inputs.SyntheticsCreateBrowserCheckExcludedFile>[]>;
    frequency?: pulumi.Input<number>;
    httpMethod?: pulumi.Input<string>;
    httpRequestBody?: pulumi.Input<string>;
    httpRequestHeaders?: pulumi.Input<pulumi.Input<inputs.SyntheticsCreateBrowserCheckHttpRequestHeader>[]>;
    integrations?: pulumi.Input<pulumi.Input<number>[]>;
    javascriptFiles?: pulumi.Input<pulumi.Input<inputs.SyntheticsCreateBrowserCheckJavascriptFile>[]>;
    lastUpdated?: pulumi.Input<string>;
    locations?: pulumi.Input<pulumi.Input<number>[]>;
    name?: pulumi.Input<string>;
    notifications?: pulumi.Input<pulumi.Input<inputs.SyntheticsCreateBrowserCheckNotification>[]>;
    roundRobin?: pulumi.Input<boolean>;
    steps?: pulumi.Input<pulumi.Input<inputs.SyntheticsCreateBrowserCheckStep>[]>;
    successCriterias?: pulumi.Input<pulumi.Input<inputs.SyntheticsCreateBrowserCheckSuccessCriteria>[]>;
    tags?: pulumi.Input<pulumi.Input<string>[]>;
    thresholdMonitors?: pulumi.Input<pulumi.Input<inputs.SyntheticsCreateBrowserCheckThresholdMonitor>[]>;
    type?: pulumi.Input<string>;
    url?: pulumi.Input<string>;
    userAgent?: pulumi.Input<string>;
    viewports?: pulumi.Input<pulumi.Input<inputs.SyntheticsCreateBrowserCheckViewport>[]>;
    waitForFullMetrics?: pulumi.Input<boolean>;
}

/**
 * The set of arguments for constructing a SyntheticsCreateBrowserCheck resource.
 */
export interface SyntheticsCreateBrowserCheckArgs {
    autoRetry?: pulumi.Input<boolean>;
    autoUpdateUserAgent?: pulumi.Input<boolean>;
    blackoutPeriods?: pulumi.Input<pulumi.Input<inputs.SyntheticsCreateBrowserCheckBlackoutPeriod>[]>;
    browsers?: pulumi.Input<pulumi.Input<inputs.SyntheticsCreateBrowserCheckBrowser>[]>;
    checkConnections?: pulumi.Input<pulumi.Input<inputs.SyntheticsCreateBrowserCheckCheckConnection>[]>;
    cookies?: pulumi.Input<pulumi.Input<inputs.SyntheticsCreateBrowserCheckCookie>[]>;
    dnsOverrides?: pulumi.Input<pulumi.Input<inputs.SyntheticsCreateBrowserCheckDnsOverride>[]>;
    enabled?: pulumi.Input<boolean>;
    enforceSslValidation?: pulumi.Input<boolean>;
    excludedFiles?: pulumi.Input<pulumi.Input<inputs.SyntheticsCreateBrowserCheckExcludedFile>[]>;
    frequency: pulumi.Input<number>;
    httpMethod?: pulumi.Input<string>;
    httpRequestBody?: pulumi.Input<string>;
    httpRequestHeaders?: pulumi.Input<pulumi.Input<inputs.SyntheticsCreateBrowserCheckHttpRequestHeader>[]>;
    integrations?: pulumi.Input<pulumi.Input<number>[]>;
    javascriptFiles?: pulumi.Input<pulumi.Input<inputs.SyntheticsCreateBrowserCheckJavascriptFile>[]>;
    lastUpdated?: pulumi.Input<string>;
    locations?: pulumi.Input<pulumi.Input<number>[]>;
    name?: pulumi.Input<string>;
    notifications?: pulumi.Input<pulumi.Input<inputs.SyntheticsCreateBrowserCheckNotification>[]>;
    roundRobin?: pulumi.Input<boolean>;
    steps?: pulumi.Input<pulumi.Input<inputs.SyntheticsCreateBrowserCheckStep>[]>;
    successCriterias?: pulumi.Input<pulumi.Input<inputs.SyntheticsCreateBrowserCheckSuccessCriteria>[]>;
    tags?: pulumi.Input<pulumi.Input<string>[]>;
    thresholdMonitors?: pulumi.Input<pulumi.Input<inputs.SyntheticsCreateBrowserCheckThresholdMonitor>[]>;
    type?: pulumi.Input<string>;
    url: pulumi.Input<string>;
    userAgent?: pulumi.Input<string>;
    viewports?: pulumi.Input<pulumi.Input<inputs.SyntheticsCreateBrowserCheckViewport>[]>;
    waitForFullMetrics?: pulumi.Input<boolean>;
}
