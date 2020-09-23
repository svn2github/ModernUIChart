namespace ModernUICharts
{
    using System;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls;
    using Windows.UI.Xaml.Media.Animation;

    public class BarPiece : PieceBase
    {
        #region Fields

        private Border slice = null;

        public static readonly DependencyProperty PercentageProperty =
            DependencyProperty.Register("Percentage", typeof(double), typeof(BarPiece),
            new PropertyMetadata(0.0, new PropertyChangedCallback(OnPercentageChanged)));
        
        public static readonly DependencyProperty ColumnWidthProperty =
            DependencyProperty.Register("ColumnWidth", typeof(double), typeof(BarPiece),
            new PropertyMetadata(0.0));

        #endregion Fields

        #region Constructors

        static BarPiece()        
        {
#if NETFX_CORE
                        
#elif SILVERLIGHT
    
#else
            DefaultStyleKeyProperty.OverrideMetadata(typeof(BarPiece), new FrameworkPropertyMetadata(typeof(BarPiece)));
#endif
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ColumnPiece"/> class.
        /// </summary>
        public BarPiece()
        {
#if NETFX_CORE
            this.DefaultStyleKey = typeof(BarPiece);
#endif
#if SILVERLIGHT
            this.DefaultStyleKey = typeof(BarPiece);
#endif
            Loaded += ColumnPiece_Loaded;
        }

        #endregion Constructors

        #region Properties

        public double Percentage
        {
            get { return (double)GetValue(PercentageProperty); }
            set { SetValue(PercentageProperty, value); }
        }

        public double ColumnWidth
        {
            get { return (double)GetValue(ColumnWidthProperty); }
            set { SetValue(ColumnWidthProperty, value); }
        }

        #endregion Properties

        #region Methods

        private static void OnPercentageChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            (d as BarPiece).DrawGeometry();
        }

        protected override void InternalOnApplyTemplate()
        {
            slice = this.GetTemplateChild("Slice") as Border;
            RegisterMouseEvents(slice);
        }

        void ColumnPiece_Loaded(object sender, RoutedEventArgs e)
        {
            DrawGeometry();
        }

        /// <summary>
        /// Draws the geometry.
        /// </summary>
        /// <param name="context">The context.</param>
        protected override void DrawGeometry(bool withAnimation = true)
        {    
            try
            {
                if (this.ClientWidth <= 0.0)
                {
                    return;
                }
                if (this.ClientHeight <= 0.0)
                {
                    return;
                }

                double startWidth = 0;
                if (slice.Width > 0)
                {
                    startWidth = slice.Width;
                }

                DoubleAnimation scaleAnimation = new DoubleAnimation();
                scaleAnimation.From = startWidth;
                scaleAnimation.To = this.ClientWidth * Percentage;
                scaleAnimation.Duration = TimeSpan.FromMilliseconds(500);
                scaleAnimation.EasingFunction = new QuarticEase() { EasingMode = EasingMode.EaseOut };
                Storyboard storyScaleX = new Storyboard();
                storyScaleX.Children.Add(scaleAnimation);
                
                Storyboard.SetTarget(storyScaleX, slice);

#if NETFX_CORE
                scaleAnimation.EnableDependentAnimation = true;
                Storyboard.SetTargetProperty(storyScaleX, "Width");
#else
                Storyboard.SetTargetProperty(storyScaleX, new PropertyPath("Width"));
#endif
                storyScaleX.Begin();
                         
                //SetValue(ColumnPiece.ColumnHeightProperty, this.ClientHeight * Percentage);
            }
            catch (Exception ex)
            {
            }
        }

        #endregion Methods
    }
}