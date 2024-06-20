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

__all__ = ['SyntheticsCreateLocationV2Args', 'SyntheticsCreateLocationV2']

@pulumi.input_type
class SyntheticsCreateLocationV2Args:
    def __init__(__self__, *,
                 locations: pulumi.Input[Sequence[pulumi.Input['SyntheticsCreateLocationV2LocationArgs']]]):
        """
        The set of arguments for constructing a SyntheticsCreateLocationV2 resource.
        """
        pulumi.set(__self__, "locations", locations)

    @property
    @pulumi.getter
    def locations(self) -> pulumi.Input[Sequence[pulumi.Input['SyntheticsCreateLocationV2LocationArgs']]]:
        return pulumi.get(self, "locations")

    @locations.setter
    def locations(self, value: pulumi.Input[Sequence[pulumi.Input['SyntheticsCreateLocationV2LocationArgs']]]):
        pulumi.set(self, "locations", value)


@pulumi.input_type
class _SyntheticsCreateLocationV2State:
    def __init__(__self__, *,
                 locations: Optional[pulumi.Input[Sequence[pulumi.Input['SyntheticsCreateLocationV2LocationArgs']]]] = None):
        """
        Input properties used for looking up and filtering SyntheticsCreateLocationV2 resources.
        """
        if locations is not None:
            pulumi.set(__self__, "locations", locations)

    @property
    @pulumi.getter
    def locations(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['SyntheticsCreateLocationV2LocationArgs']]]]:
        return pulumi.get(self, "locations")

    @locations.setter
    def locations(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['SyntheticsCreateLocationV2LocationArgs']]]]):
        pulumi.set(self, "locations", value)


class SyntheticsCreateLocationV2(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 locations: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['SyntheticsCreateLocationV2LocationArgs']]]]] = None,
                 __props__=None):
        """
        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import pulumi_synthetics as synthetics

        location_v2_foo = synthetics.SyntheticsCreateLocationV2("locationV2Foo", locations=[synthetics.SyntheticsCreateLocationV2LocationArgs(
            country="IE",
            id="private-aws-awesome-east",
            label="awesome aws east location",
        )])
        ```
        <!--End PulumiCodeChooser -->

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: SyntheticsCreateLocationV2Args,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import pulumi_synthetics as synthetics

        location_v2_foo = synthetics.SyntheticsCreateLocationV2("locationV2Foo", locations=[synthetics.SyntheticsCreateLocationV2LocationArgs(
            country="IE",
            id="private-aws-awesome-east",
            label="awesome aws east location",
        )])
        ```
        <!--End PulumiCodeChooser -->

        :param str resource_name: The name of the resource.
        :param SyntheticsCreateLocationV2Args args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(SyntheticsCreateLocationV2Args, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 locations: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['SyntheticsCreateLocationV2LocationArgs']]]]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = SyntheticsCreateLocationV2Args.__new__(SyntheticsCreateLocationV2Args)

            if locations is None and not opts.urn:
                raise TypeError("Missing required property 'locations'")
            __props__.__dict__["locations"] = locations
        super(SyntheticsCreateLocationV2, __self__).__init__(
            'synthetics:index/syntheticsCreateLocationV2:SyntheticsCreateLocationV2',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            locations: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['SyntheticsCreateLocationV2LocationArgs']]]]] = None) -> 'SyntheticsCreateLocationV2':
        """
        Get an existing SyntheticsCreateLocationV2 resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _SyntheticsCreateLocationV2State.__new__(_SyntheticsCreateLocationV2State)

        __props__.__dict__["locations"] = locations
        return SyntheticsCreateLocationV2(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def locations(self) -> pulumi.Output[Sequence['outputs.SyntheticsCreateLocationV2Location']]:
        return pulumi.get(self, "locations")
