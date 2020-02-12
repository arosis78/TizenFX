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
using ElmSharp.Wearable;

namespace ElmSharp.Test.TC
{
    class CircleGenGridTest1 : TestCaseBase
    {
        public override string TestName => "CircleGenGridTest1";
        public override string TestDescription => "To display a gengrid applied a circle UI on a conformant";

        CircleGenGrid CreateCircleGenGrid(EvasObject parent, CircleSurface surface, bool IsHorizontal, int width, int height, string style)
        {
            var grid = new CircleGenGrid(parent, surface)
            {
                Style = "circle",
                IsHorizontal = IsHorizontal,
                HorizontalScrollBarVisiblePolicy = ScrollBarVisiblePolicy.Auto,
                VerticalScrollBarVisiblePolicy = ScrollBarVisiblePolicy.Auto,
                AlignmentX = -1,
                AlignmentY = -1,
                WeightX = 1,
                WeightY = 1,
                ItemWidth = width,
                ItemHeight = height,
            };
            ((IRotaryActionWidget)grid).Activate();

            GenItemClass itemClass = new GenItemClass(style)
            {
                GetContentHandler = (obj, part) =>
                {
                    Color item = (Color)obj;
                    if (part == "elm.swallow.icon")
                    {
                        var colorbox = new Rectangle(parent)
                        {
                            Color = item
                        };
                        return colorbox;
                    }
                    return null;
                }
            };

            var rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                int r = rnd.Next(255);
                int g = rnd.Next(255);
                int b = rnd.Next(255);
                Color color = Color.FromRgb(r, g, b);
                var griditem = grid.Append(itemClass, color);

            }
            grid.Show();

            return grid;
        }

        public override void Run(Window window)
        {
            int step = 0;

            Conformant conformant = new Conformant(window);
            conformant.Show();

            var surface = new CircleSurface(conformant);

            var grid = CreateCircleGenGrid(conformant, surface, true, 109, 109, "default");
            conformant.SetContent(grid);

            Button button = new Button(conformant)
            {
                Style = "bottom",
                Text = "Change Size",
            };
            button.Geometry = new Rect(0, 282, 360, 78);
            button.Show();

            button.Clicked += (s, e) =>
            {
                if (step == 0)
                {
                    grid.Unrealize();
                    grid = CreateCircleGenGrid(conformant, surface, true, 138, 138, "default");
                    conformant.SetContent(grid);
                    step++;
                }
                else if (step == 1)
                {
                    grid.Unrealize();
                    grid = CreateCircleGenGrid(conformant, surface, false, 254, 188, "vertical_single");
                    conformant.SetContent(grid);
                    step++;
                }
                else if (step == 2)
                {
                    grid.Unrealize();
                    grid = CreateCircleGenGrid(conformant, surface, false, 129, 129, "vertical");
                    conformant.SetContent(grid);
                    step++;
                }
                else
                {
                    grid.Unrealize();
                    grid = CreateCircleGenGrid(conformant, surface, true, 109, 109, "default");
                    conformant.SetContent(grid);
                    step = 0;
                }
            };
        }
    }
}
