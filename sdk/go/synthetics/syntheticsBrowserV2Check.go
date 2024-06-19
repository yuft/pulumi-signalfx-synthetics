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
//			_, err := synthetics.SyntheticsBrowserV2Check(ctx, &synthetics.SyntheticsBrowserV2CheckArgs{
//				Tests: []synthetics.SyntheticsBrowserV2CheckTest{
//					{
//						Id: 496,
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
func SyntheticsBrowserV2Check(ctx *pulumi.Context, args *SyntheticsBrowserV2CheckArgs, opts ...pulumi.InvokeOption) (*SyntheticsBrowserV2CheckResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv SyntheticsBrowserV2CheckResult
	err := ctx.Invoke("synthetics:index/syntheticsBrowserV2Check:syntheticsBrowserV2Check", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking syntheticsBrowserV2Check.
type SyntheticsBrowserV2CheckArgs struct {
	Tests []SyntheticsBrowserV2CheckTest `pulumi:"tests"`
}

// A collection of values returned by syntheticsBrowserV2Check.
type SyntheticsBrowserV2CheckResult struct {
	// The provider-assigned unique ID for this managed resource.
	Id    string                         `pulumi:"id"`
	Tests []SyntheticsBrowserV2CheckTest `pulumi:"tests"`
}

func SyntheticsBrowserV2CheckOutput(ctx *pulumi.Context, args SyntheticsBrowserV2CheckOutputArgs, opts ...pulumi.InvokeOption) SyntheticsBrowserV2CheckResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (SyntheticsBrowserV2CheckResult, error) {
			args := v.(SyntheticsBrowserV2CheckArgs)
			r, err := SyntheticsBrowserV2Check(ctx, &args, opts...)
			var s SyntheticsBrowserV2CheckResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(SyntheticsBrowserV2CheckResultOutput)
}

// A collection of arguments for invoking syntheticsBrowserV2Check.
type SyntheticsBrowserV2CheckOutputArgs struct {
	Tests SyntheticsBrowserV2CheckTestArrayInput `pulumi:"tests"`
}

func (SyntheticsBrowserV2CheckOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*SyntheticsBrowserV2CheckArgs)(nil)).Elem()
}

// A collection of values returned by syntheticsBrowserV2Check.
type SyntheticsBrowserV2CheckResultOutput struct{ *pulumi.OutputState }

func (SyntheticsBrowserV2CheckResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*SyntheticsBrowserV2CheckResult)(nil)).Elem()
}

func (o SyntheticsBrowserV2CheckResultOutput) ToSyntheticsBrowserV2CheckResultOutput() SyntheticsBrowserV2CheckResultOutput {
	return o
}

func (o SyntheticsBrowserV2CheckResultOutput) ToSyntheticsBrowserV2CheckResultOutputWithContext(ctx context.Context) SyntheticsBrowserV2CheckResultOutput {
	return o
}

// The provider-assigned unique ID for this managed resource.
func (o SyntheticsBrowserV2CheckResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v SyntheticsBrowserV2CheckResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o SyntheticsBrowserV2CheckResultOutput) Tests() SyntheticsBrowserV2CheckTestArrayOutput {
	return o.ApplyT(func(v SyntheticsBrowserV2CheckResult) []SyntheticsBrowserV2CheckTest { return v.Tests }).(SyntheticsBrowserV2CheckTestArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(SyntheticsBrowserV2CheckResultOutput{})
}
