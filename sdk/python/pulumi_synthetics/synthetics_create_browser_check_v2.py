# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities
from . import outputs
from ._inputs import *

__all__ = ['SyntheticsCreateBrowserCheckV2Args', 'SyntheticsCreateBrowserCheckV2']

@pulumi.input_type
class SyntheticsCreateBrowserCheckV2Args:
    def __init__(__self__, *,
                 tests: pulumi.Input[Sequence[pulumi.Input['SyntheticsCreateBrowserCheckV2TestArgs']]]):
        """
        The set of arguments for constructing a SyntheticsCreateBrowserCheckV2 resource.
        """
        pulumi.set(__self__, "tests", tests)

    @property
    @pulumi.getter
    def tests(self) -> pulumi.Input[Sequence[pulumi.Input['SyntheticsCreateBrowserCheckV2TestArgs']]]:
        return pulumi.get(self, "tests")

    @tests.setter
    def tests(self, value: pulumi.Input[Sequence[pulumi.Input['SyntheticsCreateBrowserCheckV2TestArgs']]]):
        pulumi.set(self, "tests", value)


@pulumi.input_type
class _SyntheticsCreateBrowserCheckV2State:
    def __init__(__self__, *,
                 tests: Optional[pulumi.Input[Sequence[pulumi.Input['SyntheticsCreateBrowserCheckV2TestArgs']]]] = None):
        """
        Input properties used for looking up and filtering SyntheticsCreateBrowserCheckV2 resources.
        """
        if tests is not None:
            pulumi.set(__self__, "tests", tests)

    @property
    @pulumi.getter
    def tests(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['SyntheticsCreateBrowserCheckV2TestArgs']]]]:
        return pulumi.get(self, "tests")

    @tests.setter
    def tests(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['SyntheticsCreateBrowserCheckV2TestArgs']]]]):
        pulumi.set(self, "tests", value)


class SyntheticsCreateBrowserCheckV2(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 tests: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['SyntheticsCreateBrowserCheckV2TestArgs']]]]] = None,
                 __props__=None):
        """
        ## Example Usage

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: SyntheticsCreateBrowserCheckV2Args,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        ## Example Usage

        :param str resource_name: The name of the resource.
        :param SyntheticsCreateBrowserCheckV2Args args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(SyntheticsCreateBrowserCheckV2Args, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 tests: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['SyntheticsCreateBrowserCheckV2TestArgs']]]]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = SyntheticsCreateBrowserCheckV2Args.__new__(SyntheticsCreateBrowserCheckV2Args)

            if tests is None and not opts.urn:
                raise TypeError("Missing required property 'tests'")
            __props__.__dict__["tests"] = tests
        super(SyntheticsCreateBrowserCheckV2, __self__).__init__(
            'synthetics:index/syntheticsCreateBrowserCheckV2:SyntheticsCreateBrowserCheckV2',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            tests: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['SyntheticsCreateBrowserCheckV2TestArgs']]]]] = None) -> 'SyntheticsCreateBrowserCheckV2':
        """
        Get an existing SyntheticsCreateBrowserCheckV2 resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _SyntheticsCreateBrowserCheckV2State.__new__(_SyntheticsCreateBrowserCheckV2State)

        __props__.__dict__["tests"] = tests
        return SyntheticsCreateBrowserCheckV2(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def tests(self) -> pulumi.Output[Sequence['outputs.SyntheticsCreateBrowserCheckV2Test']]:
        return pulumi.get(self, "tests")
