﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace IdentitySample.Authorization.ClaimBasedAuthorization.MvcUserAccessClaims
{
    public static class EmployeeControllerClaimValues
    {
        public const string EmployeeIndex = nameof(EmployeeIndex);
        public const string EmployeeIndexPersian = "صفحه اصلی مدیریت کارکنان";

        public const string EmployeeDetails = nameof(EmployeeDetails);
        public const string EmployeeDetailsPersian = "جزئیات کارکنان";

        public static readonly ReadOnlyCollection<(string claimValueEnglish, string claimValuePersian)> AllClaimValues;

        static EmployeeControllerClaimValues()
        {
            AllClaimValues =
                MvcClaimValuesUtilities.GetPersianAndEnglishClaimValues(typeof(EmployeeControllerClaimValues))
                    .ToList()
                    .AsReadOnly();
        }
    }
}
