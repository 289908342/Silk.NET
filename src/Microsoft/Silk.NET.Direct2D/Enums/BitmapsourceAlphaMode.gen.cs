// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [Flags]
    [NativeName("Name", "D2D1_BITMAPSOURCE_ALPHA_MODE")]
    public enum BitmapsourceAlphaMode : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Premultiplied\"")]
        [NativeName("Name", "D2D1_BITMAPSOURCE_ALPHA_MODE_PREMULTIPLIED")]
        BitmapsourceAlphaModePremultiplied = 0x1,
        [Obsolete("Deprecated in favour of \"Straight\"")]
        [NativeName("Name", "D2D1_BITMAPSOURCE_ALPHA_MODE_STRAIGHT")]
        BitmapsourceAlphaModeStraight = 0x2,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_BITMAPSOURCE_ALPHA_MODE_FORCE_DWORD")]
        BitmapsourceAlphaModeForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_BITMAPSOURCE_ALPHA_MODE_PREMULTIPLIED")]
        Premultiplied = 0x1,
        [NativeName("Name", "D2D1_BITMAPSOURCE_ALPHA_MODE_STRAIGHT")]
        Straight = 0x2,
        [NativeName("Name", "D2D1_BITMAPSOURCE_ALPHA_MODE_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}