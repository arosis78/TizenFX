/*
 * Copyright (c) 2016 Samsung Electronics Co., Ltd All Rights Reserved
 *
 * Licensed under the Apache License, Version 2.0 (the License);
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an AS IS BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Runtime.InteropServices;

internal static partial class Interop
{

    internal static partial class Eext
    {
        [DllImport(Libraries.Eext)]
        internal static extern IntPtr eext_circle_object_gengrid_add(IntPtr gengrid, IntPtr surface);

        [DllImport(Libraries.Eext)]
        internal static extern void eext_circle_object_gengrid_scroller_policy_set(IntPtr circleGengrid, int policyHorisontal, int policyVertical);

        [DllImport(Libraries.Eext)]
        internal static extern void eext_circle_object_gengrid_scroller_policy_get(IntPtr circleGengrid, out int policyHorisontal, out int policyVertical);

        [DllImport(Libraries.Eext)]
        internal static extern void eext_circle_object_gengrid_scroller_policy_get(IntPtr circleGengrid, out int policyHorisontal, IntPtr policyVertical);

        [DllImport(Libraries.Eext)]
        internal static extern void eext_circle_object_gengrid_scroller_policy_get(IntPtr circleGengrid, IntPtr policyHorisontal, out int policyVertical);
    }
}