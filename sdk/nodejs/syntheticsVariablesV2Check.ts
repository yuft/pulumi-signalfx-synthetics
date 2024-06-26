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
 * const datasourceVariables = synthetics.syntheticsVariablesV2Check({
 *     variables: [{}],
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function syntheticsVariablesV2Check(args?: SyntheticsVariablesV2CheckArgs, opts?: pulumi.InvokeOptions): Promise<SyntheticsVariablesV2CheckResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("synthetics:index/syntheticsVariablesV2Check:syntheticsVariablesV2Check", {
        "variables": args.variables,
    }, opts);
}

/**
 * A collection of arguments for invoking syntheticsVariablesV2Check.
 */
export interface SyntheticsVariablesV2CheckArgs {
    variables?: inputs.SyntheticsVariablesV2CheckVariable[];
}

/**
 * A collection of values returned by syntheticsVariablesV2Check.
 */
export interface SyntheticsVariablesV2CheckResult {
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly variables?: outputs.SyntheticsVariablesV2CheckVariable[];
}
/**
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as synthetics from "@pulumi/synthetics";
 *
 * const datasourceVariables = synthetics.syntheticsVariablesV2Check({
 *     variables: [{}],
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function syntheticsVariablesV2CheckOutput(args?: SyntheticsVariablesV2CheckOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<SyntheticsVariablesV2CheckResult> {
    return pulumi.output(args).apply((a: any) => syntheticsVariablesV2Check(a, opts))
}

/**
 * A collection of arguments for invoking syntheticsVariablesV2Check.
 */
export interface SyntheticsVariablesV2CheckOutputArgs {
    variables?: pulumi.Input<pulumi.Input<inputs.SyntheticsVariablesV2CheckVariableArgs>[]>;
}
