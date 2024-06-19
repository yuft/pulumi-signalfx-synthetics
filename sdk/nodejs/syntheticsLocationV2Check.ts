// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as synthetics from "@pulumi/synthetics";
 *
 * const datasourceLocation = synthetics.syntheticsLocationV2Check({
 *     locations: [{
 *         id: "private-aws-awesome-east",
 *     }],
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function syntheticsLocationV2Check(args: SyntheticsLocationV2CheckArgs, opts?: pulumi.InvokeOptions): Promise<SyntheticsLocationV2CheckResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("synthetics:index/syntheticsLocationV2Check:syntheticsLocationV2Check", {
        "locations": args.locations,
        "metas": args.metas,
    }, opts);
}

/**
 * A collection of arguments for invoking syntheticsLocationV2Check.
 */
export interface SyntheticsLocationV2CheckArgs {
    locations: inputs.SyntheticsLocationV2CheckLocation[];
    metas?: inputs.SyntheticsLocationV2CheckMeta[];
}

/**
 * A collection of values returned by syntheticsLocationV2Check.
 */
export interface SyntheticsLocationV2CheckResult {
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly locations: outputs.SyntheticsLocationV2CheckLocation[];
    readonly metas: outputs.SyntheticsLocationV2CheckMeta[];
}
/**
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as synthetics from "@pulumi/synthetics";
 *
 * const datasourceLocation = synthetics.syntheticsLocationV2Check({
 *     locations: [{
 *         id: "private-aws-awesome-east",
 *     }],
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function syntheticsLocationV2CheckOutput(args: SyntheticsLocationV2CheckOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<SyntheticsLocationV2CheckResult> {
    return pulumi.output(args).apply((a: any) => syntheticsLocationV2Check(a, opts))
}

/**
 * A collection of arguments for invoking syntheticsLocationV2Check.
 */
export interface SyntheticsLocationV2CheckOutputArgs {
    locations: pulumi.Input<pulumi.Input<inputs.SyntheticsLocationV2CheckLocationArgs>[]>;
    metas?: pulumi.Input<pulumi.Input<inputs.SyntheticsLocationV2CheckMetaArgs>[]>;
}
