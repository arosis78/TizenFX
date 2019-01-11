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
            _window.ViewConnected += (s, e) =>
            {
                var view = (View)s;
                Console.WriteLine("View Connected : Name = {0}, AutomationId = {1}", view.Name, view.AutomationId);
            };

            TextLabel _label = new TextLabel("Label");
            _label.Size2D = new Size2D(710, 50);
            _label.Position2D = new Position2D(10, 10);
            _label.PointSize = 10;
            _label.TextColor = Color.Black;
            _label.AutomationId = "label1";
            _label.Name = "TextLabel";
            _window.Add(_label);        

            PushButton _pushbutton = new PushButton();
            _pushbutton.Size2D = new Size2D(360, 100);
            _pushbutton.Position2D = new Position2D(10, 100);
            _pushbutton.LabelText = "Button";
            _pushbutton.AutomationId = "button";
            _pushbutton.Name = "PushButton";
            _window.Add(_pushbutton);

            CheckBoxButton _check = new CheckBoxButton();
            _check.Size2D = new Size2D(500, 100);
            _check.Position2D = new Position2D(10, 240);
            _check.LabelText = "Check";
            _check.AutomationId = "check";
            _check.Name = "CheckBoxButton";
            _window.Add(_check);

            RadioButton _radio = new RadioButton();
            _radio.Size2D = new Size2D(500, 100);
            _radio.Position2D = new Position2D(10, 380);
            _radio.LabelText = "Radio";
            _radio.AutomationId = "radio";
            _radio.Name = "RadioButton";
            _window.Add(_radio);

            ProgressBar _prog = new ProgressBar();
            _prog.Size2D = new Size2D(700, 20);
            _prog.Position2D = new Position2D(10, 520);
            _prog.ProgressValue = 0.5f;
            _prog.AutomationId = "progressbar";
            _prog.Name = "ProgressBar";
            _window.Add(_prog);

            Slider _slider = new Slider();
            _slider.Size2D = new Size2D(700, 80);
            _slider.Position2D = new Position2D(0, 700);
            _slider.AutomationId = "slider";
            _slider.Name = "Slider";
            _window.Add(_slider);

            FlexContainer _container;
            _container = new FlexContainer();
            _container.Size2D = new Size2D(720, 400);
            _container.Position2D = new Position2D(0, 800);
            _container.PivotPoint = PivotPoint.TopLeft;
            _container.FlexWrap = FlexContainer.WrapType.Wrap;
            _container.FlexDirection = FlexContainer.FlexDirectionType.Column;
            _container.AutomationId = "flex_container";
            _container.Name = "FlexContainer";
            _window.Add(_container);

            TextLabel _label2 = new TextLabel("Label2");
            _label2.Focusable = true;
            _label2.BackgroundColor = Color.Red;
            _label2.PointSize = 10;
            _label2.AutomationId = "lable2";
            _label2.Name = "TextLable2";
            _container.Add(_label2);
        }

        static void Main(string[] args)
        {
            TestRunner testRunner = new TestRunner();
            testRunner.Run(args);
        }
    }
}
