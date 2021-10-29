using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProgressCircle
{
    /// <summary>
    /// Interaction logic for ProgressCircleUC.xaml
    /// </summary>
    public partial class ProgressCircleUC : UserControl
    {
        #region indicatorBrush property
        /// <summary>
        /// indicatorBrush.
        /// </summary>
        public Brush indicatorBrush
        {
            get { return (Brush)GetValue(indicatorBrushProperty); }
            set { SetValue(indicatorBrushProperty, value); }
        }

        /// <summary>
        /// Dependency property of indicatorBrush.
        /// </summary>
        public static readonly DependencyProperty indicatorBrushProperty = DependencyProperty.Register("indicatorBrush", typeof(Brush), typeof(ProgressCircleUC), new FrameworkPropertyMetadata(Brushes.BlueViolet));
        #endregion

        #region ellipseBgBrush property
        /// <summary>
        /// ellipseBgBrush.
        /// </summary>
        public Brush ellipseBgBrush
        {
            get { return (Brush)GetValue(ellipseBgBrushProperty); }
            set { SetValue(ellipseBgBrushProperty, value); }
        }

        /// <summary>
        /// Dependency property of ellipseBgBrush.
        /// </summary>
        public static readonly DependencyProperty ellipseBgBrushProperty = DependencyProperty.Register("ellipseBgBrush", typeof(Brush), typeof(ProgressCircleUC));
        #endregion

        #region BorderProgressBarBrush property
        /// <summary>
        /// BorderProgressBarBrush.
        /// </summary>
        public Brush BorderProgressBarBrush
        {
            get { return (Brush)GetValue(BorderProgressBarBrushProperty); }
            set { SetValue(BorderProgressBarBrushProperty, value); }
        }

        /// <summary>
        /// Dependency property of BorderProgressBarBrush.
        /// </summary>
        public static readonly DependencyProperty BorderProgressBarBrushProperty = DependencyProperty.Register("BorderProgressBarBrush", typeof(Brush), typeof(ProgressCircleUC), new FrameworkPropertyMetadata(Brushes.DeepSkyBlue));
        #endregion


        #region percentBrush property
        /// <summary>
        /// percentBrush.
        /// </summary>
        public Brush percentBrush
        {
            get { return (Brush)GetValue(percentBrushProperty); }
            set { SetValue(percentBrushProperty, value); }
        }

        /// <summary>
        /// Dependency property of percentBrush.
        /// </summary>
        public static readonly DependencyProperty percentBrushProperty = DependencyProperty.Register("percentBrush", typeof(Brush), typeof(ProgressCircleUC), new FrameworkPropertyMetadata(Brushes.BlueViolet));
        #endregion

        #region valueEndAngle property
        /// <summary>
        /// valueEndAngle.
        /// </summary>
        public int valueEndAngle
        {
            get { return (int)GetValue(valueEndAngleProperty); }
            set { SetValue(valueEndAngleProperty, value); }
        }

        /// <summary>
        /// Dependency property of valueEndAngle.
        /// </summary>
        public static readonly DependencyProperty valueEndAngleProperty = DependencyProperty.Register("valueEndAngle", typeof(int), typeof(ProgressCircleUC), new FrameworkPropertyMetadata(25));
        #endregion

        public ProgressCircleUC()
        {
            InitializeComponent();
        }
    }

    [ValueConversion(typeof(int), typeof(double))]
    public class ValueToAngleConvertor : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            int percent = (int) value;
            
            if (percent < 0)
                percent =  0;

            if (percent > 100)
                percent = 100;

            return (double)((percent * 0.01) * 360);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return (int)(((double)value / 360) * 100);
        }
    }

    [ValueConversion(typeof(int), typeof(string))]
    public class ValueToPercentConvertor : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            int percent = (int)value;
            
            if (percent < 0)
                percent = 0;

            if (percent > 100)
                percent = 100;

            return percent.ToString() + "%";
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string valueString = ((string) value).Replace("%", "");

            int percent;

            if (!int.TryParse(valueString, out percent))
            {
                percent = 0;
            }

            if (percent < 0)

                percent = 0;

            if (percent > 100)

                percent = 100;

            return (int) percent;
        }
    }
}
