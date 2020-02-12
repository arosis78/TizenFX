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
using System.Diagnostics;

namespace ElmSharp.Wearable
{
    /// <summary>
    /// The Circle GenGrid Selector is a widget to display and handle the gengrid items by the Rotary event.
    /// Inherits <see cref="GenGrid"/>.
    /// </summary>
    /// <since_tizen> preview </since_tizen>
    public class CircleGenGrid : GenGrid, IRotaryActionWidget
    {
        IntPtr _circleHandle;
        CircleSurface _surface;

        /// <summary>
        /// Creates and initializes a new instance of the Circle GenGrid class.
        /// </summary>
        /// <param name="parent">The parent of the new Circle GenGrid instance.</param>
        /// <param name="surface">The surface for drawing the circle features for this widget.</param>
        /// <since_tizen> preview </since_tizen>
        public CircleGenGrid(EvasObject parent, CircleSurface surface) : base()
        {
            Debug.Assert(parent == null || surface == null || parent.IsRealized);
            _surface = surface;
            Realize(parent);
        }

        /// <summary>
        /// Gets the handle for the Circle widget.
        /// </summary>
        /// <since_tizen> preview </since_tizen>
        public virtual IntPtr CircleHandle => _circleHandle;

        /// <summary>
        /// Gets the handle for the circle surface used in this widget.
        /// </summary>
        /// <since_tizen> preview </since_tizen>
        public virtual CircleSurface CircleSurface => _surface;

        /// <summary>
        /// Sets or gets the state of the widget, which might be enabled or disabled.
        /// </summary>
        /// <since_tizen> preview </since_tizen>
        public override bool IsEnabled
        {
            get
            {
                return !Interop.Eext.eext_circle_object_disabled_get(CircleHandle);
            }
            set
            {
                Interop.Eext.eext_circle_object_disabled_set(CircleHandle, !value);
            }
        }

        /// <summary>
        /// Sets or gets the policy if the vertical scrollbar is visible.
        /// </summary>
        /// <remarks>
        /// ScrollBarVisiblePolicy.Auto means the vertical scrollbar is made visible if it is needed, or otherwise kept hidden.
        /// ScrollBarVisiblePolicy.Visible turns it on all the time, and ScrollBarVisiblePolicy.Invisible always keeps it off.
        /// </remarks>
        /// <since_tizen> preview </since_tizen>
        public new ScrollBarVisiblePolicy VerticalScrollBarVisiblePolicy
        {
            get
            {
                int policy;
                Interop.Eext.eext_circle_object_gengrid_scroller_policy_get(CircleHandle, IntPtr.Zero, out policy);
                return (ScrollBarVisiblePolicy)policy;
            }
            set
            {
                int h;
                Interop.Eext.eext_circle_object_gengrid_scroller_policy_get(CircleHandle, out h, IntPtr.Zero);
                Interop.Eext.eext_circle_object_gengrid_scroller_policy_set(CircleHandle, (int)h, (int)value);
            }
        }

        /// <summary>
        /// Sets or gets the policy if the horizontal scrollbar is visible.
        /// </summary>
        /// <remarks>
        /// ScrollBarVisiblePolicy.Auto means the horizontal scrollbar is made visible if it is needed, or otherwise kept hidden.
        /// ScrollBarVisiblePolicy.Visible turns it on all the time, and ScrollBarVisiblePolicy.Invisible always keeps it off.
        /// </remarks>
        /// <since_tizen> preview </since_tizen>
        public new ScrollBarVisiblePolicy HorizontalScrollBarVisiblePolicy
        {
            get
            {
                int policy;
                Interop.Eext.eext_circle_object_gengrid_scroller_policy_get(CircleHandle, out policy, IntPtr.Zero);
                return (ScrollBarVisiblePolicy)policy;
            }
            set
            {
                int v;
                Interop.Eext.eext_circle_object_gengrid_scroller_policy_get(CircleHandle, IntPtr.Zero, out v);
                Interop.Eext.eext_circle_object_gengrid_scroller_policy_set(CircleHandle, (int)value, (int)v);
            }
        }

        /// <summary>
        /// Creates a widget handle.
        /// </summary>
        /// <param name="parent">Parent EvasObject.</param>
        /// <returns>Handle IntPtr.</returns>
        /// <since_tizen> preview </since_tizen>
        protected override IntPtr CreateHandle(EvasObject parent)
        {
            var handle = base.CreateHandle(parent);
            _circleHandle = Interop.Eext.eext_circle_object_gengrid_add(RealHandle == IntPtr.Zero ? handle : RealHandle, CircleSurface.Handle);

            return handle;
        }
    }
}
