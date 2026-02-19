using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using LCPInfrastructure;
using LCPReportingSystem.ViewModel;
using LiveCharts.Wpf;
using LiveCharts;
using System.Windows.Media;
using CommonLib;
using LCPReportingSystem.DbHelper;
using LCPReportingSystem.Model;


namespace LCPReportingSystem.UserControls
{
    /// <summary>
    /// Interaction logic for LineGraphUserControl.xaml
    /// </summary>
    public partial class LineGraphUserControl : UserControl
    {
        public LineGraphViewModel lineGraphViewModel;
        public List<string> valueslist = new List<string>();
        
        public LineGraphUserControl()
        {
            InitializeComponent();

            try
            {
                lineGraphViewModel = new LineGraphViewModel();
                lineGraphViewModel.DataHandler = GetSelectedList;
                lineGraphViewModel.setValuesHandler = SetProperValues_Latest;
                lineGraphViewModel.setItemSourceHandler = SetMultiSelectionItemSource;
                this.DataContext = lineGraphViewModel;
                if (UsageConstants.exerciseTypes.Count > 0)
                {
                    cmbExerciseType.ItemsSource = UsageConstants.exerciseTypes;
                    cmbExerciseType.SelectedValue = UsageConstants.DefaultExerciseItem;
                }
                cmbSubsystem.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(LineGraphUserControl));
            }
          
        }

        private void SetMultiSelectionItemSource(Dictionary<string, object> items)
        {
            try
            {
                MC1.ItemsSource = null;

                if (MC1.SelectedItems!=null && MC1.SelectedItems.Count>0)
                {
                    MC1.Text = "";
                }
                

                MC1.ItemsSource = items;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(SetMultiSelectionItemSource));
            }
        }

        private void SetProperValues_Latest(Dictionary<string, object> dictionary)
        {
            try
            {             
                if (valueslist != null && valueslist.Count > 0)
                {
                    List<List<double>> valueLists = new List<List<double>>();
                    List<string> valueTitles = new List<string>();
                    List<DateTime> dateLabels = new List<DateTime>();
                    if (!valueslist.Contains("Dates"))
                        valueslist.Add("Dates");

                    // Extract values
                    foreach (var item in valueslist)
                    {
                        if (dictionary.TryGetValue(item, out object value))
                        {
                            if (value is List<double> dList && dList.Count > 0)
                            {
                                valueLists.Add(dList);
                                valueTitles.Add(item);
                            }
                            else if (value is List<DateTime> dtList && dateLabels.Count == 0)
                            {
                                dateLabels = dtList;
                            }
                        }
                    }

                    // Sync all to smallest length
                    int pointCount = valueLists.Append(dateLabels.Select(_ => 0.0).ToList()).Min(v => v.Count);
                    for (int i = 0; i < valueLists.Count; i++)
                    {
                        valueLists[i] = valueLists[i].Take(pointCount).ToList();
                    }
                    dateLabels = dateLabels.Take(pointCount).ToList();

                    // Create series collection
                    SeriesCollection src = new SeriesCollection();
                    for (int i = 0; i < valueLists.Count && i < 3; i++)
                    {
                        LineSeries line = new LineSeries
                        {
                            Title = valueTitles.ElementAtOrDefault(i) ?? $"Param{i + 1}",
                            Values = new ChartValues<double>(valueLists[i]),
                            StrokeThickness = 2,
                            PointGeometry = null
                        };
                        src.Add(line);
                    }

                    LineChart.Series = src;

                    // Setup X Axis
                    if (LineChart.AxisX.Count == 0)
                        LineChart.AxisX.Add(new Axis());

                    LineChart.AxisX[0].Title = "Date Time";
                    LineChart.AxisX[0].Labels = dateLabels.Select(d => d.ToString("dd MMM HH:mm")).ToArray();
                    LineChart.AxisX[0].LabelsRotation = 45;
                    LineChart.AxisX[0].FontSize = 14;
                    LineChart.AxisX[0].Foreground = System.Windows.Media.Brushes.Black;

                    // Setup Y Axis based on available value lists
                    if (valueLists.Count > 0)
                    {
                        double minY = valueLists.Select(l => l.Min()).Min();
                        double maxY = valueLists.Select(l => l.Max()).Max();
                        double padding = (maxY - minY) * 0.05;
                        if (padding == 0) padding = 1;

                        if (LineChart.AxisY.Count == 0)
                            LineChart.AxisY.Add(new Axis());

                        LineChart.AxisY[0].Title = "Parameter Values";
                        LineChart.AxisY[0].MinValue = Math.Floor(minY - padding);
                        LineChart.AxisY[0].MaxValue = Math.Ceiling(maxY + padding);
                        LineChart.AxisY[0].FontSize = 14;
                        LineChart.AxisY[0].Foreground = System.Windows.Media.Brushes.Black;
                    }
                    int subsystemnumber = lineGraphViewModel.lngSubSystemIndex;
                    IsSubSystem sub = (IsSubSystem)subsystemnumber;
                    ActivityReportDataInsertModel.SetActivityReport("Graphical Report", " Graphical Report Generated for : " + sub.ToString(), string.Empty);

                }

            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(SetProperValues_Latest));
            }
        }
       
      
        private List<string> GetSelectedList( )
        {
            try
            {
                if (valueslist.Count > 0)
                    valueslist.Clear();

                if(MC1.SelectedItems!=null)
                {
                    valueslist = MC1.SelectedItems.Keys.ToList();
                    return valueslist;
                }
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(GetSelectedList));
         
            }
            return valueslist;
        }

        private void cmbExerciseType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (cmbExerciseType.SelectedValue.ToString() == UsageConstants.DefaultExerciseItem)
                {
                    fromdateTimePicker.IsEnabled = true;
                    todateTimePicker.IsEnabled = true;
                }
                else
                {
                    var DateTimeRangeList = lineGraphViewModel.LoadExerciseDateTime_Type(cmbExerciseType.SelectedValue.ToString());
                    fromdateTimePicker.Value = DateTimeRangeList[0].ExerciseStartTime;
                    todateTimePicker.Value = DateTimeRangeList[0].ExerciseEndTime;
                    fromdateTimePicker.IsEnabled = false;
                    todateTimePicker.IsEnabled = false;
                }
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(cmbExerciseType_SelectionChanged));
            }
        }
        private void cmbSubsystem_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (cmbSubsystem.SelectedItem != null)
                {
                    var selectedItem = cmbSubsystem.SelectedItem as ComboBoxItem;
                    var viewModel = DataContext as LineGraphViewModel;
                    if (string.Equals(selectedItem.Content.ToString(), UsageConstants.DieselGenerator1Text))
                    {
                        if (viewModel?.LngDgCommand?.CanExecute(UsageConstants.DieselGenerator1Text) == true)
                        {
                            viewModel.LngDgCommand.Execute(UsageConstants.DieselGenerator1Text);
                        }
                    }
                    else if (string.Equals(selectedItem.Content.ToString(), UsageConstants.DieselGenerator2Text))
                    {
                        if (viewModel?.LngDgCommand?.CanExecute(UsageConstants.DieselGenerator2Text) == true)
                        {
                            viewModel.LngDgCommand.Execute(UsageConstants.DieselGenerator2Text);
                        }
                    }
                    else if (string.Equals(selectedItem.Content.ToString(), UsageConstants.Radio1Text))
                    {
                        if (viewModel?.LngRadioCommand?.CanExecute(UsageConstants.Radio1Text) == true)
                        {
                            viewModel.LngRadioCommand.Execute(UsageConstants.Radio1Text);
                        }
                    }
                    else if (string.Equals(selectedItem.Content.ToString(), UsageConstants.Radio2Text))
                    {
                        if (viewModel?.LngRadioCommand?.CanExecute(UsageConstants.Radio2Text) == true)
                        {
                            viewModel.LngRadioCommand.Execute(UsageConstants.Radio2Text);
                        }
                    }
                    else if (string.Equals(selectedItem.Content.ToString(), UsageConstants.Switch1Text))
                    {
                        if (viewModel?.LngSwitchCommand?.CanExecute(UsageConstants.Switch1Text) == true)
                        {
                            viewModel.LngSwitchCommand.Execute(UsageConstants.Switch1Text);
                        }
                    }
                    else if (string.Equals(selectedItem.Content.ToString(), UsageConstants.Switch2Text))
                    {
                        if (viewModel?.LngSwitchCommand?.CanExecute(UsageConstants.Switch2Text) == true)
                        {
                            viewModel.LngSwitchCommand.Execute(UsageConstants.Switch2Text);
                        }
                    }
                    else if (string.Equals(selectedItem.Content.ToString(), UsageConstants.UPS1Text))
                    {
                        if (viewModel?.LngUpsCommand?.CanExecute(UsageConstants.UPS1Text) == true)
                        {
                            viewModel.LngUpsCommand.Execute(UsageConstants.UPS1Text);
                        }
                    }
                    else if (string.Equals(selectedItem.Content.ToString(), UsageConstants.UPS2Text))
                    {
                        if (viewModel?.LngUpsCommand?.CanExecute(UsageConstants.UPS2Text) == true)
                        {
                            viewModel.LngUpsCommand.Execute(UsageConstants.UPS2Text);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(cmbSubsystem_SelectionChanged));
            }
        }
        private void FilterButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (FilterBorder.Visibility == Visibility.Visible)
                { FilterBorder.Visibility = Visibility.Collapsed; return; }

                if (FilterBorder.Visibility == Visibility.Collapsed)
                { FilterBorder.Visibility = Visibility.Visible; return; }
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(FilterButton_Click));
            }
        }
    }
}
