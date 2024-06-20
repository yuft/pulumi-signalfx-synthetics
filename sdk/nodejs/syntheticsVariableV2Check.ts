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
 * const datasourceCheckVariable = synthetics.syntheticsVariableV2Check({
 *     variables: [{
 *         id: 246,
 *     }],
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function syntheticsVariableV2Check(args: SyntheticsVariableV2CheckArgs, opts?: pulumi.InvokeOptions): Promise<SyntheticsVariableV2CheckResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("synthetics:index/syntheticsVariableV2Check:syntheticsVariableV2Check", {
        "variables": args.variables,
    }, opts);
}

/**
 * A collection of arguments for invoking syntheticsVariableV2Check.
 */
export interface SyntheticsVariableV2CheckArgs {
    variables: inputs.SyntheticsVariableV2CheckVariable[];
}

/**
 * A collection of values returned by syntheticsVariableV2Check.
 */
export interface SyntheticsVariableV2CheckResult {
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly variables: outputs.SyntheticsVariableV2CheckVariable[];
}
/**
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as synthetics from "@pulumi/synthetics";
 *
 * const datasourceCheckVariable = synthetics.syntheticsVariableV2Check({
 *     variables: [{
 *         id: 246,
 *     }],
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function syntheticsVariableV2CheckOutput(args: SyntheticsVariableV2CheckOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<SyntheticsVariableV2CheckResult> {
    return pulumi.output(args).apply((a: any) => syntheticsVariableV2Check(a, opts))
}

/**
 * A collection of arguments for invoking syntheticsVariableV2Check.
 */
export interface SyntheticsVariableV2CheckOutputArgs {
    variables: pulumi.Input<pulumi.Input<inputs.SyntheticsVariableV2CheckVariableArgs>[]>;
}