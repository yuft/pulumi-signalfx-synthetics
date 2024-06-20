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

__all__ = [
    'SyntheticsLocationV2CheckResult',
    'AwaitableSyntheticsLocationV2CheckResult',
    'synthetics_location_v2_check',
    'synthetics_location_v2_check_output',
]

@pulumi.output_type
class SyntheticsLocationV2CheckResult:
    """
    A collection of values returned by syntheticsLocationV2Check.
    """
    def __init__(__self__, id=None, locations=None, metas=None):
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if locations and not isinstance(locations, list):
            raise TypeError("Expected argument 'locations' to be a list")
        pulumi.set(__self__, "locations", locations)
        if metas and not isinstance(metas, list):
            raise TypeError("Expected argument 'metas' to be a list")
        pulumi.set(__self__, "metas", metas)

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def locations(self) -> Sequence['outputs.SyntheticsLocationV2CheckLocationResult']:
        return pulumi.get(self, "locations")

    @property
    @pulumi.getter
    def metas(self) -> Sequence['outputs.SyntheticsLocationV2CheckMetaResult']:
        return pulumi.get(self, "metas")


class AwaitableSyntheticsLocationV2CheckResult(SyntheticsLocationV2CheckResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return SyntheticsLocationV2CheckResult(
            id=self.id,
            locations=self.locations,
            metas=self.metas)


def synthetics_location_v2_check(locations: Optional[Sequence[pulumi.InputType['SyntheticsLocationV2CheckLocationArgs']]] = None,
                                 metas: Optional[Sequence[pulumi.InputType['SyntheticsLocationV2CheckMetaArgs']]] = None,
                                 opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableSyntheticsLocationV2CheckResult:
    """
    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_synthetics as synthetics

    datasource_location = synthetics.synthetics_location_v2_check(locations=[synthetics.SyntheticsLocationV2CheckLocationArgs(
        id="private-aws-awesome-east",
    )])
    ```
    <!--End PulumiCodeChooser -->
    """
    __args__ = dict()
    __args__['locations'] = locations
    __args__['metas'] = metas
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('synthetics:index/syntheticsLocationV2Check:syntheticsLocationV2Check', __args__, opts=opts, typ=SyntheticsLocationV2CheckResult).value

    return AwaitableSyntheticsLocationV2CheckResult(
        id=pulumi.get(__ret__, 'id'),
        locations=pulumi.get(__ret__, 'locations'),
        metas=pulumi.get(__ret__, 'metas'))


@_utilities.lift_output_func(synthetics_location_v2_check)
def synthetics_location_v2_check_output(locations: Optional[pulumi.Input[Sequence[pulumi.InputType['SyntheticsLocationV2CheckLocationArgs']]]] = None,
                                        metas: Optional[pulumi.Input[Optional[Sequence[pulumi.InputType['SyntheticsLocationV2CheckMetaArgs']]]]] = None,
                                        opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[SyntheticsLocationV2CheckResult]:
    """
    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_synthetics as synthetics

    datasource_location = synthetics.synthetics_location_v2_check(locations=[synthetics.SyntheticsLocationV2CheckLocationArgs(
        id="private-aws-awesome-east",
    )])
    ```
    <!--End PulumiCodeChooser -->
    """
    ...