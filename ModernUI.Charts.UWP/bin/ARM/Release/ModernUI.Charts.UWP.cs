namespace ModernUI.Charts.UWP.ModernUI_Charts_UWP_XamlTypeInfo
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", " 10.0.17.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute]
    public sealed partial class XamlMetaDataProvider : Windows.UI.Xaml.Markup.IXamlMetadataProvider
    {
        public XamlMetaDataProvider() { }
        public Windows.UI.Xaml.Markup.IXamlType GetXamlType(string fullName) { return default(Windows.UI.Xaml.Markup.IXamlType); }
        public Windows.UI.Xaml.Markup.IXamlType GetXamlType(System.Type type) { return default(Windows.UI.Xaml.Markup.IXamlType); }
        public Windows.UI.Xaml.Markup.XmlnsDefinition[] GetXmlnsDefinitions() { return default(Windows.UI.Xaml.Markup.XmlnsDefinition[]); }
    }
}
namespace ModernUICharts
{
    public partial class AutoSizeTextBlock : Windows.UI.Xaml.Controls.Control
    {
        public static readonly Windows.UI.Xaml.DependencyProperty IsHeightExceedsSpaceProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty IsWidthExceedsSpaceProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty TextBlockStyleProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty TextProperty;
        public AutoSizeTextBlock() { }
        public bool IsHeightExceedsSpace { get { return default(bool); } set { } }
        public bool IsWidthExceedsSpace { get { return default(bool); } set { } }
        public string Text { get { return default(string); } set { } }
        public Windows.UI.Xaml.Style TextBlockStyle { get { return default(Windows.UI.Xaml.Style); } set { } }
        protected override Windows.Foundation.Size ArrangeOverride(Windows.Foundation.Size finalSize) { return default(Windows.Foundation.Size); }
        protected override Windows.Foundation.Size MeasureOverride(Windows.Foundation.Size availableSize) { return default(Windows.Foundation.Size); }
        protected override void OnApplyTemplate() { }
    }
    public partial class BarPiece : ModernUICharts.PieceBase
    {
        public static readonly Windows.UI.Xaml.DependencyProperty ColumnWidthProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty PercentageProperty;
        public BarPiece() { }
        public double ColumnWidth { get { return default(double); } set { } }
        public double Percentage { get { return default(double); } set { } }
        protected override void DrawGeometry(bool withAnimation=true) { }
        protected override void InternalOnApplyTemplate() { }
    }
    public sealed partial class BooleanToVisibilityConverter : Windows.UI.Xaml.Data.IValueConverter
    {
        public BooleanToVisibilityConverter() { }
        public object Convert(object value, System.Type targetType, object parameter, string language) { return default(object); }
        public object ConvertBack(object value, System.Type targetType, object parameter, string language) { return default(object); }
        public object InternalConvertBack(object value, System.Type targetType, object parameter) { return default(object); }
    }
    public partial class ChartArea : Windows.UI.Xaml.Controls.ContentControl
    {
        public static readonly Windows.UI.Xaml.DependencyProperty ChartLegendItemStyleProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty ParentChartProperty;
        public ChartArea() { }
        public System.Collections.ObjectModel.ObservableCollection<ModernUICharts.ChartLegendItemViewModel> ChartLegendItems { get { return default(System.Collections.ObjectModel.ObservableCollection<ModernUICharts.ChartLegendItemViewModel>); } }
        public Windows.UI.Xaml.Style ChartLegendItemStyle { get { return default(Windows.UI.Xaml.Style); } set { } }
        public System.Collections.ObjectModel.ObservableCollection<ModernUICharts.DataPointGroup> DataPointGroups { get { return default(System.Collections.ObjectModel.ObservableCollection<ModernUICharts.DataPointGroup>); } }
        public System.Collections.ObjectModel.ObservableCollection<string> GridLines { get { return default(System.Collections.ObjectModel.ObservableCollection<string>); } }
        public ModernUICharts.ChartBase ParentChart { get { return default(ModernUICharts.ChartBase); } set { } }
    }
    public abstract partial class ChartBase : Windows.UI.Xaml.Controls.Control, System.ComponentModel.INotifyPropertyChanged
    {
        public static readonly Windows.UI.Xaml.DependencyProperty ChartAreaStyleProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty ChartLegendItemStyleProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty ChartLegendVisibilityProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty ChartSubTitleProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty ChartTitleProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty ChartTitleStyleProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty ChartTitleVisibilityProperty;
        public static Windows.UI.Xaml.DependencyProperty DataContextWatcherProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty DefaultPaletteProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty ExceptionsProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty InternalDataContextProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty IsRowColumnSwitchedProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty MaxDataPointGroupSumProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty MaxDataPointValueProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty PaletteProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty PlotterAreaStyleProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty SelectedBrushProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty SelectedItemProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty SeriesProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty SeriesSourceProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty SeriesTemplateProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty SumOfDataPointGroupProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty ToolTipFormatProperty;
        public ChartBase() { }
        public Windows.UI.Xaml.Style ChartAreaStyle { get { return default(Windows.UI.Xaml.Style); } set { } }
        public System.Collections.ObjectModel.ObservableCollection<ModernUICharts.ChartLegendItemViewModel> ChartLegendItems { get { return default(System.Collections.ObjectModel.ObservableCollection<ModernUICharts.ChartLegendItemViewModel>); } }
        public Windows.UI.Xaml.Style ChartLegendItemStyle { get { return default(Windows.UI.Xaml.Style); } set { } }
        public Windows.UI.Xaml.Visibility ChartLegendVisibility { get { return default(Windows.UI.Xaml.Visibility); } set { } }
        public string ChartSubTitle { get { return default(string); } set { } }
        public string ChartTitle { get { return default(string); } set { } }
        public Windows.UI.Xaml.Style ChartTitleStyle { get { return default(Windows.UI.Xaml.Style); } set { } }
        public Windows.UI.Xaml.Visibility ChartTitleVisibility { get { return default(Windows.UI.Xaml.Visibility); } set { } }
        public System.Collections.ObjectModel.ObservableCollection<ModernUICharts.DataPointGroup> DataPointGroups { get { return default(System.Collections.ObjectModel.ObservableCollection<ModernUICharts.DataPointGroup>); } }
        public ModernUICharts.ResourceDictionaryCollection DefaultPalette { get { return default(ModernUICharts.ResourceDictionaryCollection); } set { } }
        public System.Collections.ObjectModel.ObservableCollection<string> Exceptions { get { return default(System.Collections.ObjectModel.ObservableCollection<string>); } set { } }
        public System.Collections.ObjectModel.ObservableCollection<string> GridLines { get { return default(System.Collections.ObjectModel.ObservableCollection<string>); } }
        protected abstract double GridLinesMaxValue { get; }
        public bool HasExceptions { get { return default(bool); } }
        public object InternalDataContext { get { return default(object); } set { } }
        public bool IsRowColumnSwitched { get { return default(bool); } set { } }
        public virtual bool IsUseNextBiggestMaxValue { get { return default(bool); } }
        public double MaxDataPointGroupSum { get { return default(double); } set { } }
        public double MaxDataPointValue { get { return default(double); } set { } }
        public ModernUICharts.ResourceDictionaryCollection Palette { get { return default(ModernUICharts.ResourceDictionaryCollection); } set { } }
        public Windows.UI.Xaml.Style PlotterAreaStyle { get { return default(Windows.UI.Xaml.Style); } set { } }
        public Windows.UI.Xaml.Media.Brush SelectedBrush { get { return default(Windows.UI.Xaml.Media.Brush); } set { } }
        public object SelectedItem { get { return default(object); } set { } }
        public System.Collections.ObjectModel.ObservableCollection<ModernUICharts.ChartSeries> Series { get { return default(System.Collections.ObjectModel.ObservableCollection<ModernUICharts.ChartSeries>); } set { } }
        public System.Collections.IEnumerable SeriesSource { get { return default(System.Collections.IEnumerable); } set { } }
        public Windows.UI.Xaml.DataTemplate SeriesTemplate { get { return default(Windows.UI.Xaml.DataTemplate); } set { } }
        public double SumOfDataPointGroup { get { return default(double); } set { } }
        public string ToolTipFormat { get { return default(string); } set { } }
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged { add { } remove { } }
        [System.Runtime.CompilerServices.AsyncStateMachineAttribute(typeof(ModernUICharts.ChartBase.<DataContextWatcher_Changed>d__25))]
        public static void DataContextWatcher_Changed(Windows.UI.Xaml.DependencyObject sender, Windows.UI.Xaml.DependencyPropertyChangedEventArgs args) { }
        public void InternalOnApplyTemplate() { }
        protected override void OnApplyTemplate() { }
        protected virtual void OnMaxDataPointGroupSumChanged(double p) { }
        protected virtual void OnMaxDataPointValueChanged(double p) { }
        protected void UpdateGridLines() { }
    }
    public partial class ChartLegendItem : Windows.UI.Xaml.Controls.ContentControl
    {
        public static readonly Windows.UI.Xaml.DependencyProperty CaptionProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty ItemBrushProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty PercentageProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty ValueProperty;
        public ChartLegendItem() { }
        public string Caption { get { return default(string); } set { } }
        public Windows.UI.Xaml.Media.Brush ItemBrush { get { return default(Windows.UI.Xaml.Media.Brush); } set { } }
        public double Percentage { get { return default(double); } set { } }
        public double Value { get { return default(double); } set { } }
    }
    public partial class ChartLegendItemViewModel : Windows.UI.Xaml.DependencyObject
    {
        public static readonly Windows.UI.Xaml.DependencyProperty CaptionProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty ItemBrushProperty;
        public ChartLegendItemViewModel() { }
        public string Caption { get { return default(string); } set { } }
        public Windows.UI.Xaml.Media.Brush ItemBrush { get { return default(Windows.UI.Xaml.Media.Brush); } set { } }
    }
    public partial class ChartSeries : Windows.UI.Xaml.Controls.ItemsControl
    {
        public static readonly Windows.UI.Xaml.DependencyProperty DisplayMemberProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty SeriesTitleProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty ValueMemberProperty;
        public ChartSeries() { }
        public string DisplayMember { get { return default(string); } set { } }
        public string SeriesTitle { get { return default(string); } set { } }
        public string ValueMember { get { return default(string); } set { } }
    }
    public partial class ChartTitle : Windows.UI.Xaml.Controls.ContentControl
    {
        public static readonly Windows.UI.Xaml.DependencyProperty SubTitleProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty TitleProperty;
        public ChartTitle() { }
        public string SubTitle { get { return default(string); } set { } }
        public string Title { get { return default(string); } set { } }
    }
    public partial class ClusteredBarChart : ModernUICharts.ChartBase
    {
        public ClusteredBarChart() { }
        protected override double GridLinesMaxValue { get { return default(double); } }
        public override bool IsUseNextBiggestMaxValue { get { return default(bool); } }
        protected override void OnMaxDataPointValueChanged(double p) { }
    }
    public partial class ClusteredColumnChart : ModernUICharts.ChartBase
    {
        public ClusteredColumnChart() { }
        protected override double GridLinesMaxValue { get { return default(double); } }
        public override bool IsUseNextBiggestMaxValue { get { return default(bool); } }
        protected override void OnMaxDataPointValueChanged(double p) { }
    }
    public partial class ColumnPiece : ModernUICharts.PieceBase
    {
        public static readonly Windows.UI.Xaml.DependencyProperty ColumnHeightProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty PercentageProperty;
        public ColumnPiece() { }
        public double ColumnHeight { get { return default(double); } set { } }
        public double Percentage { get { return default(double); } set { } }
        protected override void DrawGeometry(bool withAnimation=true) { }
        protected override void InternalOnApplyTemplate() { }
    }
    public partial class ColumnSeriesPanel : Windows.UI.Xaml.Controls.Panel
    {
        public ColumnSeriesPanel() { }
        protected override Windows.Foundation.Size ArrangeOverride(Windows.Foundation.Size finalSize) { return default(Windows.Foundation.Size); }
        protected override Windows.Foundation.Size MeasureOverride(Windows.Foundation.Size availableSize) { return default(Windows.Foundation.Size); }
    }
    public partial class CustomWrapPanel : Windows.UI.Xaml.Controls.Panel
    {
        public static readonly Windows.UI.Xaml.DependencyProperty OrientationProperty;
        public CustomWrapPanel() { }
        public Windows.UI.Xaml.Controls.Orientation Orientation { get { return default(Windows.UI.Xaml.Controls.Orientation); } set { } }
        protected override Windows.Foundation.Size ArrangeOverride(Windows.Foundation.Size finalSize) { return default(Windows.Foundation.Size); }
        protected override Windows.Foundation.Size MeasureOverride(Windows.Foundation.Size availableSize) { return default(Windows.Foundation.Size); }
    }
    public partial class DataPoint : Windows.UI.Xaml.DependencyObject, System.ComponentModel.INotifyPropertyChanged
    {
        public static readonly Windows.UI.Xaml.DependencyProperty IsClickedByUserProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty IsSelectedProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty ItemBrushProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty MaxDataPointGroupSumProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty MaxDataPointValueProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty SelectedBrushProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty SelectedItemProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty StartValueProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty SumOfDataPointGroupProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty ToolTipFormatProperty;
        public DataPoint(ModernUICharts.ChartBase parentChart) { }
        public string Caption { get { return default(string); } }
        public string DisplayMember { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string DisplayName { get { return default(string); } }
        public string FormattedValue { get { return default(string); } }
        public bool IsSelected { get { return default(bool); } set { } }
        public Windows.UI.Xaml.Media.Brush ItemBrush { get { return default(Windows.UI.Xaml.Media.Brush); } set { } }
        public double MaxDataPointGroupSum { get { return default(double); } set { } }
        public double MaxDataPointValue { get { return default(double); } set { } }
        public ModernUICharts.ChartBase ParentChart { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(ModernUICharts.ChartBase); } }
        public double PercentageFromMaxDataPointGroupSum { get { return default(double); } }
        public double PercentageFromMaxDataPointValue { get { return default(double); } }
        public double PercentageFromSumOfDataPointGroup { get { return default(double); } }
        public object ReferencedObject { get { return default(object); } set { } }
        public Windows.UI.Xaml.Media.Brush SelectedBrush { get { return default(Windows.UI.Xaml.Media.Brush); } set { } }
        public object SelectedItem { get { return default(object); } set { } }
        public string SeriesCaption { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public double StartValue { get { return default(double); } set { } }
        public double SumOfDataPointGroup { get { return default(double); } set { } }
        public string ToolTipFormat { get { return default(string); } set { } }
        public double Value { get { return default(double); } }
        public string ValueMember { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged { add { } remove { } }
    }
    public partial class DataPointGroup : Windows.UI.Xaml.DependencyObject, System.ComponentModel.INotifyPropertyChanged
    {
        public static readonly Windows.UI.Xaml.DependencyProperty SelectedItemProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty SumOfDataPointGroupProperty;
        public DataPointGroup(ModernUICharts.ChartBase parentChart, string caption, bool showcaption) { }
        public string Caption { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
        public System.Collections.ObjectModel.ObservableCollection<ModernUICharts.DataPoint> DataPoints { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.ObjectModel.ObservableCollection<ModernUICharts.DataPoint>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public ModernUICharts.ChartBase ParentChart { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(ModernUICharts.ChartBase); } }
        public object SelectedItem { get { return default(object); } set { } }
        public bool ShowCaption { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
        public double SumOfDataPointGroup { get { return default(double); } set { } }
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged { add { } remove { } }
    }
    public partial class DoubleToGridLengthPercent : Windows.UI.Xaml.Data.IValueConverter
    {
        public DoubleToGridLengthPercent() { }
        public object Convert(object value, System.Type targetType, object parameter, string language) { return default(object); }
        public object ConvertBack(object value, System.Type targetType, object parameter, string language) { return default(object); }
    }
    public partial class DoughnutChart : ModernUICharts.PieChart
    {
        public DoughnutChart() { }
        protected override double GridLinesMaxValue { get { return default(double); } }
    }
    public enum EasingFunction
    {
        EaseInCubic = 4,
        EaseInExpo = 9,
        EaseInOutCubic = 6,
        EaseInOutQuad = 3,
        EaseInQuad = 1,
        EaseInQuart = 7,
        EaseOutCubic = 5,
        EaseOutExpo = 10,
        EaseOutQuad = 2,
        EaseOutQuart = 8,
        Linear = 0,
    }
    public partial class EvenlyDistributedColumnsGrid : Windows.UI.Xaml.Controls.Panel
    {
        public EvenlyDistributedColumnsGrid() { }
        protected override Windows.Foundation.Size ArrangeOverride(Windows.Foundation.Size finalSize) { return default(Windows.Foundation.Size); }
        protected override Windows.Foundation.Size MeasureOverride(Windows.Foundation.Size availableSize) { return default(Windows.Foundation.Size); }
    }
    public partial class EvenlyDistributedRowGrid : Windows.UI.Xaml.Controls.Panel
    {
        public static readonly Windows.UI.Xaml.DependencyProperty IsReverseOrderProperty;
        public EvenlyDistributedRowGrid() { }
        public bool IsReverseOrder { get { return default(bool); } set { } }
        protected override Windows.Foundation.Size ArrangeOverride(Windows.Foundation.Size finalSize) { return default(Windows.Foundation.Size); }
        protected override Windows.Foundation.Size MeasureOverride(Windows.Foundation.Size availableSize) { return default(Windows.Foundation.Size); }
    }
    public static partial class Extensions
    {
        public static System.Reflection.PropertyInfo[] GetAllProperties(this System.Type type) { return default(System.Reflection.PropertyInfo[]); }
    }
    public partial class FadingListView : Windows.UI.Xaml.Controls.ItemsControl
    {
        public static readonly Windows.UI.Xaml.DependencyProperty RealHeightProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty RealWidthProperty;
        public FadingListView() { }
        public double RealHeight { get { return default(double); } set { } }
        public double RealWidth { get { return default(double); } set { } }
        protected override void PrepareContainerForItemOverride(Windows.UI.Xaml.DependencyObject element, object item) { }
    }
    public partial class Legend : Windows.UI.Xaml.Controls.ItemsControl
    {
        public static readonly Windows.UI.Xaml.DependencyProperty ChartLegendItemStyleProperty;
        public Legend() { }
        public Windows.UI.Xaml.Style ChartLegendItemStyle { get { return default(Windows.UI.Xaml.Style); } set { } }
    }
    public partial class MinimalWidthTextBlock : Windows.UI.Xaml.Controls.Control
    {
        public static readonly Windows.UI.Xaml.DependencyProperty TextBlockStyleProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty TextProperty;
        public MinimalWidthTextBlock() { }
        public string Text { get { return default(string); } set { } }
        public Windows.UI.Xaml.Style TextBlockStyle { get { return default(Windows.UI.Xaml.Style); } set { } }
        protected override Windows.Foundation.Size ArrangeOverride(Windows.Foundation.Size finalSize) { return default(Windows.Foundation.Size); }
        protected override Windows.Foundation.Size MeasureOverride(Windows.Foundation.Size availableSize) { return default(Windows.Foundation.Size); }
        protected override void OnApplyTemplate() { }
    }
    [Windows.UI.Xaml.TemplateVisualStateAttribute(Name="Selected", GroupName="SelectionStates")]
    [Windows.UI.Xaml.TemplateVisualStateAttribute(Name="Unselected", GroupName="SelectionStates")]
    public abstract partial class PieceBase : Windows.UI.Xaml.Controls.Control
    {
        public static readonly Windows.UI.Xaml.DependencyProperty ClientHeightProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty ClientWidthProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty IsClickedByUserProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty IsSelectedProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty ParentChartProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty SelectedBrushProperty;
        protected PieceBase() { }
        public string Caption { get { return default(string); } }
        public double ClientHeight { get { return default(double); } set { } }
        public double ClientWidth { get { return default(double); } set { } }
        public bool IsClickedByUser { get { return default(bool); } set { } }
        public bool IsSelected { get { return default(bool); } set { } }
        public ModernUICharts.ChartBase ParentChart { get { return default(ModernUICharts.ChartBase); } set { } }
        public Windows.UI.Xaml.Media.Brush SelectedBrush { get { return default(Windows.UI.Xaml.Media.Brush); } set { } }
        protected virtual void DrawGeometry(bool withAnimation=true) { }
        protected virtual void InternalOnApplyTemplate() { }
        protected override void OnApplyTemplate() { }
        protected virtual void OnIsSelectedPropertyChanged(bool oldValue, bool newValue) { }
        protected override void OnPointerPressed(Windows.UI.Xaml.Input.PointerRoutedEventArgs e) { }
        protected void RegisterMouseEvents(Windows.UI.Xaml.UIElement slice) { }
    }
    public partial class PieChart : ModernUICharts.ChartBase
    {
        public static readonly Windows.UI.Xaml.DependencyProperty InnerRadiusRatioProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty PieMinimalSizeProperty;
        public PieChart() { }
        protected override double GridLinesMaxValue { get { return default(double); } }
        public double InnerRadiusRatio { get { return default(double); } set { } }
        protected virtual bool IsDoughtnutEnabled { get { return default(bool); } }
        public double PieMinimalSize { get { return default(double); } set { } }
    }
    public partial class PiePiece : ModernUICharts.PieceBase
    {
        public static readonly Windows.UI.Xaml.DependencyProperty DoughnutInnerRadiusRatioProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty GeometryProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty LabelXPosProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty LabelYPosProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty LineGeometryProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty MaxValueProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty MouseOverGeometryProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty RadiusProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty SelectionGeometryProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty StartValueProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty SumOfDataSeriesProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty ValueProperty;
        public PiePiece() { }
        public double DoughnutInnerRadiusRatio { get { return default(double); } set { } }
        public Windows.UI.Xaml.Media.Geometry Geometry { get { return default(Windows.UI.Xaml.Media.Geometry); } set { } }
        public bool IsDoughnut { get { return default(bool); } }
        public double LabelXPos { get { return default(double); } set { } }
        public double LabelYPos { get { return default(double); } set { } }
        public Windows.UI.Xaml.Media.Geometry LineGeometry { get { return default(Windows.UI.Xaml.Media.Geometry); } set { } }
        public double MaxValue { get { return default(double); } set { } }
        public Windows.UI.Xaml.Media.Geometry MouseOverGeometry { get { return default(Windows.UI.Xaml.Media.Geometry); } set { } }
        public double Percent { get { return default(double); } }
        public Windows.UI.Xaml.Media.Geometry SelectionGeometry { get { return default(Windows.UI.Xaml.Media.Geometry); } set { } }
        public double StartValue { get { return default(double); } set { } }
        public double SumOfDataSeries { get { return default(double); } set { } }
        public double Value { get { return default(double); } set { } }
        public Windows.UI.Xaml.Media.PathGeometry CloneDeep(Windows.UI.Xaml.Media.PathGeometry pathGeometry) { return default(Windows.UI.Xaml.Media.PathGeometry); }
        protected override void DrawGeometry(bool withAnimation=true) { }
        protected override void InternalOnApplyTemplate() { }
    }
    public partial class PiePieceLabel : Windows.UI.Xaml.Controls.Control
    {
        public static readonly Windows.UI.Xaml.DependencyProperty CaptionProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty ItemBrushProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty PercentageProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty ValueProperty;
        public PiePieceLabel() { }
        public string Caption { get { return default(string); } set { } }
        public Windows.UI.Xaml.Media.Brush ItemBrush { get { return default(Windows.UI.Xaml.Media.Brush); } set { } }
        public double Percentage { get { return default(double); } set { } }
        public double Value { get { return default(double); } set { } }
    }
    public partial class PlotterArea : Windows.UI.Xaml.Controls.ContentControl
    {
        public static readonly Windows.UI.Xaml.DependencyProperty ChartLegendItemStyleProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty DataPointItemsPanelProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty DataPointItemTemplateProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty ParentChartProperty;
        public PlotterArea() { }
        public Windows.UI.Xaml.Style ChartLegendItemStyle { get { return default(Windows.UI.Xaml.Style); } set { } }
        public Windows.UI.Xaml.Controls.ItemsPanelTemplate DataPointItemsPanel { get { return default(Windows.UI.Xaml.Controls.ItemsPanelTemplate); } set { } }
        public Windows.UI.Xaml.DataTemplate DataPointItemTemplate { get { return default(Windows.UI.Xaml.DataTemplate); } set { } }
        public ModernUICharts.ChartBase ParentChart { get { return default(ModernUICharts.ChartBase); } set { } }
    }
    public partial class RadialGaugeChart : ModernUICharts.ChartBase
    {
        public RadialGaugeChart() { }
        protected override double GridLinesMaxValue { get { return default(double); } }
    }
    [Windows.UI.Xaml.TemplateVisualStateAttribute(Name="Selected", GroupName="SelectionStates")]
    public partial class RadialGaugePiece : ModernUICharts.PieceBase
    {
        public static readonly Windows.UI.Xaml.DependencyProperty AnimatedValueProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty BackgroundGeometryProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty FormattedAnimatedValueProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty GeometryProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty MouseOverGeometryProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty RadiusProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty SelectionGeometryProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty ValueProperty;
        public RadialGaugePiece() { }
        public double AnimatedValue { get { return default(double); } set { } }
        public Windows.UI.Xaml.Media.Geometry BackgroundGeometry { get { return default(Windows.UI.Xaml.Media.Geometry); } set { } }
        public double FormattedAnimatedValue { get { return default(double); } set { } }
        public Windows.UI.Xaml.Media.Geometry Geometry { get { return default(Windows.UI.Xaml.Media.Geometry); } set { } }
        public Windows.UI.Xaml.Media.Geometry MouseOverGeometry { get { return default(Windows.UI.Xaml.Media.Geometry); } set { } }
        public Windows.UI.Xaml.Media.Geometry SelectionGeometry { get { return default(Windows.UI.Xaml.Media.Geometry); } set { } }
        public double Value { get { return default(double); } set { } }
        protected override void DrawGeometry(bool withAnimation=true) { }
        protected override void InternalOnApplyTemplate() { }
    }
    public partial class ResourceDictionaryCollection : System.Collections.ObjectModel.ObservableCollection<Windows.UI.Xaml.ResourceDictionary>
    {
        public ResourceDictionaryCollection() { }
    }
    public partial class RowSeriesPanel : Windows.UI.Xaml.Controls.Grid
    {
        public RowSeriesPanel() { }
        protected override Windows.Foundation.Size ArrangeOverride(Windows.Foundation.Size finalSize) { return default(Windows.Foundation.Size); }
        protected override Windows.Foundation.Size MeasureOverride(Windows.Foundation.Size availableSize) { return default(Windows.Foundation.Size); }
    }
    public partial class StackedBar100Chart : ModernUICharts.ChartBase
    {
        public StackedBar100Chart() { }
        protected override double GridLinesMaxValue { get { return default(double); } }
    }
    public partial class StackedBarChart : ModernUICharts.ChartBase
    {
        public StackedBarChart() { }
        protected override double GridLinesMaxValue { get { return default(double); } }
        protected override void OnMaxDataPointGroupSumChanged(double p) { }
    }
    public partial class StackedColumn100Chart : ModernUICharts.ChartBase
    {
        public StackedColumn100Chart() { }
        protected override double GridLinesMaxValue { get { return default(double); } }
    }
    public partial class StackedColumnChart : ModernUICharts.ChartBase
    {
        public StackedColumnChart() { }
        protected override double GridLinesMaxValue { get { return default(double); } }
        protected override void OnMaxDataPointGroupSumChanged(double p) { }
    }
    public partial class StackedColumnsPanel : Windows.UI.Xaml.Controls.Grid
    {
        public StackedColumnsPanel() { }
        protected override Windows.Foundation.Size ArrangeOverride(Windows.Foundation.Size finalSize) { return default(Windows.Foundation.Size); }
        protected override Windows.Foundation.Size MeasureOverride(Windows.Foundation.Size availableSize) { return default(Windows.Foundation.Size); }
    }
    public partial class UniformGridPanel : Windows.UI.Xaml.Controls.Grid
    {
        public static readonly Windows.UI.Xaml.DependencyProperty MinimalGridWidthProperty;
        public static readonly Windows.UI.Xaml.DependencyProperty OrientationProperty;
        public UniformGridPanel() { }
        public double MinimalGridWidth { get { return default(double); } set { } }
        public Windows.UI.Xaml.Controls.Orientation Orientation { get { return default(Windows.UI.Xaml.Controls.Orientation); } set { } }
        protected override Windows.Foundation.Size ArrangeOverride(Windows.Foundation.Size finalSize) { return default(Windows.Foundation.Size); }
        protected override Windows.Foundation.Size MeasureOverride(Windows.Foundation.Size availableSize) { return default(Windows.Foundation.Size); }
    }
}
