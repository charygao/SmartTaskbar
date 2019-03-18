﻿using System;
using System.Runtime.CompilerServices;
using static SmartTaskbar.Core.SafeNativeMethods;

namespace SmartTaskbar.Core.Helpers
{
    internal static class ParentWindow
    {
        private const uint GA_PARENT = 1;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static IntPtr GetParentWindow(this IntPtr handle) => GetAncestor(handle, GA_PARENT);
    }
}
