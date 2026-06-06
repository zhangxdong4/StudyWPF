using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StudyWPF
{
    /// <summary>
    /// AddCurricula.xaml 的交互逻辑
    /// </summary>
    public partial class AddCurricula : Page
    {
        public AddCurricula()
        {
            InitializeComponent();
            BindWeekToComboBox();
        }

        private void BindWeekToComboBox()
        {
            var list = new List<object>();

            foreach (DayOfWeek week in Enum.GetValues(typeof(DayOfWeek)))
            {
                string text = week switch
                {
                    DayOfWeek.Sunday => "星期日",
                    DayOfWeek.Monday => "星期一",
                    DayOfWeek.Tuesday => "星期二",
                    DayOfWeek.Wednesday => "星期三",
                    DayOfWeek.Thursday => "星期四",
                    DayOfWeek.Friday => "星期五",
                    DayOfWeek.Saturday => "星期六",
                    _ => week.ToString()
                };

                list.Add(new { Text = text, Value = week });
            }

            CboWeek.ItemsSource = list;
        }
    }
}
