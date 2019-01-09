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
using Tizen.NUI;
using Tizen.NUI.UIComponents;
using Tizen.NUI.BaseComponents;

namespace NUI.UIComponents.Test
{
    public class TestRunner : NUIApplication
    {
        private Window _window;

        public TestRunner()
        {
         
        }

        protected override void OnCreate()
        {
            base.OnCreate();
            Initialize();
        }

        public void OnKeyEvent(object sender, Window.KeyEventArgs e)
        {
            if (e.Key.State == Key.StateType.Down && (e.Key.KeyPressedName == "XF86Back" || e.Key.KeyPressedName == "Escape"))
            {
                Exit();
            }
        }

        public void Initialize()
        {
            _window = Window.Instance;
            _window.BackgroundColor = Color.White;
            _window.KeyEvent += OnKeyEvent;
            _window.ChildObjectAdded += (s, e) =>
            {
                var obj = (View)s;
                Console.WriteLine("Child object added : Name = {0}, AutomationId = {1}", obj.Name, obj.AutomationId);
            };

            TextLabel _label = new TextLabel("Label");
            _label.Size2D = new Size2D(710, 50);
            _label.Position2D = new Position2D(10, 10);
            _label.PointSize = 10;
            _label.TextColor = Color.Black;
            _label.AutomationId = "Label";
            _window.Add(_label);

            PushButton _pushbutton = new PushButton();
            _pushbutton.Size2D = new Size2D(360, 100);
            _pushbutton.Position2D = new Position2D(10, 100);
            _pushbutton.LabelText = "Button";
            _window.Add(_pushbutton);

            CheckBoxButton _check = new CheckBoxButton();
            _check.Size2D = new Size2D(500, 100);
            _check.Position2D = new Position2D(10, 240);
            _check.LabelText = "Check";
            _window.Add(_check);

            RadioButton _radio = new RadioButton();
            _radio.Size2D = new Size2D(500, 100);
            _radio.Position2D = new Position2D(10, 380);
            _radio.LabelText = "Radio";
            _window.Add(_radio);

            ProgressBar _prog = new ProgressBar();
            _prog.Size2D = new Size2D(700, 20);
            _prog.Position2D = new Position2D(10, 520);
            _prog.ProgressValue = 0.5f;
            _window.Add(_prog);

            Slider _slider = new Slider();
            _slider.Size2D = new Size2D(700, 80);
            _slider.Position2D = new Position2D(0, 700);
            
            _window.Add(_slider);
        }

        static void Main(string[] args)
        {
            TestRunner testRunner = new TestRunner();
            testRunner.Run(args);
        }
    }
}
