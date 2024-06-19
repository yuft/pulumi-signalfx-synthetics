// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Synthetics.Outputs
{

    [OutputType]
    public sealed class SyntheticsCreateBrowserCheckBlackoutPeriod
    {
        public readonly string? CreatedAt;
        public readonly int? DurationInMinutes;
        public readonly string? EndDate;
        public readonly string? EndTime;
        public readonly bool? IsRepeat;
        public readonly string? MonthlyRepeatType;
        public readonly string? RepeatType;
        public readonly string? StartDate;
        public readonly string? StartTime;
        public readonly string? Timezone;
        public readonly string? UpdatedAt;

        [OutputConstructor]
        private SyntheticsCreateBrowserCheckBlackoutPeriod(
            string? createdAt,

            int? durationInMinutes,

            string? endDate,

            string? endTime,

            bool? isRepeat,

            string? monthlyRepeatType,

            string? repeatType,

            string? startDate,

            string? startTime,

            string? timezone,

            string? updatedAt)
        {
            CreatedAt = createdAt;
            DurationInMinutes = durationInMinutes;
            EndDate = endDate;
            EndTime = endTime;
            IsRepeat = isRepeat;
            MonthlyRepeatType = monthlyRepeatType;
            RepeatType = repeatType;
            StartDate = startDate;
            StartTime = startTime;
            Timezone = timezone;
            UpdatedAt = updatedAt;
        }
    }
}
