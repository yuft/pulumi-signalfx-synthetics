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
//			_, err := synthetics.SyntheticsPortV2Check(ctx, &synthetics.SyntheticsPortV2CheckArgs{
//				Tests: []synthetics.SyntheticsPortV2CheckTest{
//					{
//						Id: 1650,
//					},
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
func SyntheticsPortV2Check(ctx *pulumi.Context, args *SyntheticsPortV2CheckArgs, opts ...pulumi.InvokeOption) (*SyntheticsPortV2CheckResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv SyntheticsPortV2CheckResult
	err := ctx.Invoke("synthetics:index/syntheticsPortV2Check:syntheticsPortV2Check", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking syntheticsPortV2Check.
type SyntheticsPortV2CheckArgs struct {
	Tests []SyntheticsPortV2CheckTest `pulumi:"tests"`
}

// A collection of values returned by syntheticsPortV2Check.
type SyntheticsPortV2CheckResult struct {
	// The provider-assigned unique ID for this managed resource.
	Id    string                      `pulumi:"id"`
	Tests []SyntheticsPortV2CheckTest `pulumi:"tests"`
}

func SyntheticsPortV2CheckOutput(ctx *pulumi.Context, args SyntheticsPortV2CheckOutputArgs, opts ...pulumi.InvokeOption) SyntheticsPortV2CheckResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (SyntheticsPortV2CheckResult, error) {
			args := v.(SyntheticsPortV2CheckArgs)
			r, err := SyntheticsPortV2Check(ctx, &args, opts...)
			var s SyntheticsPortV2CheckResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(SyntheticsPortV2CheckResultOutput)
}

// A collection of arguments for invoking syntheticsPortV2Check.
type SyntheticsPortV2CheckOutputArgs struct {
	Tests SyntheticsPortV2CheckTestArrayInput `pulumi:"tests"`
}

func (SyntheticsPortV2CheckOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*SyntheticsPortV2CheckArgs)(nil)).Elem()
}

// A collection of values returned by syntheticsPortV2Check.
type SyntheticsPortV2CheckResultOutput struct{ *pulumi.OutputState }

func (SyntheticsPortV2CheckResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*SyntheticsPortV2CheckResult)(nil)).Elem()
}

func (o SyntheticsPortV2CheckResultOutput) ToSyntheticsPortV2CheckResultOutput() SyntheticsPortV2CheckResultOutput {
	return o
}

func (o SyntheticsPortV2CheckResultOutput) ToSyntheticsPortV2CheckResultOutputWithContext(ctx context.Context) SyntheticsPortV2CheckResultOutput {
	return o
}

// The provider-assigned unique ID for this managed resource.
func (o SyntheticsPortV2CheckResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v SyntheticsPortV2CheckResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o SyntheticsPortV2CheckResultOutput) Tests() SyntheticsPortV2CheckTestArrayOutput {
	return o.ApplyT(func(v SyntheticsPortV2CheckResult) []SyntheticsPortV2CheckTest { return v.Tests }).(SyntheticsPortV2CheckTestArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(SyntheticsPortV2CheckResultOutput{})
}
