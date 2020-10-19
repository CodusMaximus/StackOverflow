using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace StackOverflowAnswers {
    [TestClass]
    public class SetProgressBarMaxFromSlider {
        /// <summary>
        /// https://stackoverflow.com/questions/64431031/how-can-i-make-the-maximum-value-of-a-progrsssbar-equal-to-the-user-inputed-time
        /// </summary>
        [TestMethod]
        public void SetProgressBarMax() {
            //this is probably done by your framework (Windows forms?)
            var slider = new Slider();
            var progressBar = new ProgressBar();

            slider.ValueChanged += (s, e) => {
                progressBar.Maximum = (slider.Value + 60);
            };


        }
    }
    public class ProgressBar {
        public int Maximum { get; set; }
    }

    public class Slider {
        public int Value { get; set; }

        public event EventHandler<int> ValueChanged;
    }

}
