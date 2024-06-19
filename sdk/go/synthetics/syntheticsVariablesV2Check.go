// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package synthetics

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/yuft/pulumi-signalfx-synthetics/sdk/go/synthetics/internal"
)

// ## Example Usage
//
// <!--Start PulumiCodeChooser -->
// ```go
// package main
//
// import (
//
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//	"github.com/yuft/pulumi-signalfx-synthetics/sdk/go/synthetics"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := synthetics.SyntheticsVariablesV2Check(ctx, &synthetics.SyntheticsVariablesV2CheckArgs{
//				Variables: []synthetics.SyntheticsVariablesV2CheckVariable{
//					nil,
//				},
//			}, nil)
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
// <!--End PulumiCodeChooser -->
func SyntheticsVariablesV2Check(ctx *pulumi.Context, args *SyntheticsVariablesV2CheckArgs, opts ...pulumi.InvokeOption) (*SyntheticsVariablesV2CheckResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv SyntheticsVariablesV2CheckResult
	err := ctx.Invoke("synthetics:index/syntheticsVariablesV2Check:syntheticsVariablesV2Check", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking syntheticsVariablesV2Check.
type SyntheticsVariablesV2CheckArgs struct {
	Variables []SyntheticsVariablesV2CheckVariable `pulumi:"variables"`
}

// A collection of values returned by syntheticsVariablesV2Check.
type SyntheticsVariablesV2CheckResult struct {
	// The provider-assigned unique ID for this managed resource.
	Id        string                               `pulumi:"id"`
	Variables []SyntheticsVariablesV2CheckVariable `pulumi:"variables"`
}

func SyntheticsVariablesV2CheckOutput(ctx *pulumi.Context, args SyntheticsVariablesV2CheckOutputArgs, opts ...pulumi.InvokeOption) SyntheticsVariablesV2CheckResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (SyntheticsVariablesV2CheckResult, error) {
			args := v.(SyntheticsVariablesV2CheckArgs)
			r, err := SyntheticsVariablesV2Check(ctx, &args, opts...)
			var s SyntheticsVariablesV2CheckResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(SyntheticsVariablesV2CheckResultOutput)
}

// A collection of arguments for invoking syntheticsVariablesV2Check.
type SyntheticsVariablesV2CheckOutputArgs struct {
	Variables SyntheticsVariablesV2CheckVariableArrayInput `pulumi:"variables"`
}

func (SyntheticsVariablesV2CheckOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*SyntheticsVariablesV2CheckArgs)(nil)).Elem()
}

// A collection of values returned by syntheticsVariablesV2Check.
type SyntheticsVariablesV2CheckResultOutput struct{ *pulumi.OutputState }

func (SyntheticsVariablesV2CheckResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*SyntheticsVariablesV2CheckResult)(nil)).Elem()
}

func (o SyntheticsVariablesV2CheckResultOutput) ToSyntheticsVariablesV2CheckResultOutput() SyntheticsVariablesV2CheckResultOutput {
	return o
}

func (o SyntheticsVariablesV2CheckResultOutput) ToSyntheticsVariablesV2CheckResultOutputWithContext(ctx context.Context) SyntheticsVariablesV2CheckResultOutput {
	return o
}

// The provider-assigned unique ID for this managed resource.
func (o SyntheticsVariablesV2CheckResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v SyntheticsVariablesV2CheckResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o SyntheticsVariablesV2CheckResultOutput) Variables() SyntheticsVariablesV2CheckVariableArrayOutput {
	return o.ApplyT(func(v SyntheticsVariablesV2CheckResult) []SyntheticsVariablesV2CheckVariable { return v.Variables }).(SyntheticsVariablesV2CheckVariableArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(SyntheticsVariablesV2CheckResultOutput{})
}
