﻿// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace MudBlazor
{
#nullable enable
    public class FieldType
    {
        public bool IsString { get; set; }

        public bool IsNumber { get; set; }

        public bool IsEnum { get; set; }

        public bool IsDateTime { get; set; }

        public bool IsBoolean { get; set; }

        public bool IsGuid { get; set; }

        public static FieldType Identify(Type? type)
        {
            var filedType = new FieldType
            {
                IsString = TypeIdentifier.IsString(type),
                IsNumber = TypeIdentifier.IsNumber(type),
                IsEnum = TypeIdentifier.IsEnum(type),
                IsDateTime = TypeIdentifier.IsDateTime(type),
                IsBoolean = TypeIdentifier.IsBoolean(type),
                IsGuid = TypeIdentifier.IsGuid(type)
            };

            return filedType;
        }
    }
}
