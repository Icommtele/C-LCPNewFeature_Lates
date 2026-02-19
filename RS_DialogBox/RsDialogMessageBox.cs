using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.IO;
using CommonLib;
using LCPReportingSystem.Model;

namespace LCPReportingSystem.RsDialogMessageBox
{
    internal static class RsDialogBox
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="title"></param>
        /// <param name="button"></param>
        /// <param name="icon"></param>
        /// <returns></returns>
        internal static MessageBoxResult ShowMsg(string message, string title, MessageBoxButton button, MessageBoxImage icon)
        {
            BrushConverter bc = new BrushConverter();
            MainWindow window = new MainWindow
            {
                Title = title,                
                SizeToContent = SizeToContent.WidthAndHeight,
                ResizeMode = ResizeMode.NoResize,
                Background = (Brush)bc.ConvertFrom("#0064C1"),
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
                Foreground = Brushes.White,
                WindowStyle = WindowStyle.SingleBorderWindow,
                WindowState = WindowState.Normal,
                BorderBrush = (Brush)bc.ConvertFrom("#EEEFF3"), // Set the border color to black
                BorderThickness = new Thickness(1), // Set the border thickness
            };          

            // Set the content of the window to the border
            StackPanel panel = new StackPanel();
            ImageSource iconSource = null;
            switch (icon)
            {
                case MessageBoxImage.Warning:
                    iconSource = new BitmapImage(new Uri(GetImagePathWarning));
                    break;
                case MessageBoxImage.Error:
                    iconSource = new BitmapImage(new Uri(GetImagePathError));
                    break;
                default:
                    iconSource = new BitmapImage(new Uri(GetImagePath));
                    break;
            }
            Image iconImage = new Image
            {
                Source = iconSource,
                HorizontalAlignment = HorizontalAlignment.Center,
                Margin = new Thickness(0, 0, 0, 0),
                Height = 80,
                Width = 50
            };
            TextBlock textBlock = new TextBlock
            {
                Text = message,
                TextWrapping = TextWrapping.Wrap,
                TextAlignment = TextAlignment.Center,
                FontSize = 16,
                FontFamily = new FontFamily("Arial Unicode MS Regular")
            };
            TextBlock MessageTitle = new TextBlock
            {
                //Text = title,
                FontSize = 16,
                Margin = new Thickness(8, 5, 0, 0)
            };
            panel.Children.Add(MessageTitle);
            panel.Children.Add(iconImage);
            panel.Children.Add(textBlock);

            Grid buttonGrid = new Grid
            {
                HorizontalAlignment = HorizontalAlignment.Right,
                Margin = new Thickness(10, 50, 10, 10),
                Width = 500,
            };
            MessageBoxResult result = MessageBoxResult.Cancel;

            StackPanel stackPanelYes = new StackPanel
            {
                Height = 25,
                Width = 80,
                Background = (Brush)bc.ConvertFrom("#EEEFF3"),
                HorizontalAlignment = HorizontalAlignment.Right,
                Margin = new Thickness(0, 0, 100, 0)
            };

            TextBlock textBlockYes = new TextBlock
            {
                Text = "YES",
                Foreground = Brushes.Black,
                HorizontalAlignment = HorizontalAlignment.Center,
                Margin = new Thickness(0, 5, 0, 0),
                FontWeight = FontWeights.Bold,
            };

            stackPanelYes.Children.Add(textBlockYes);
            stackPanelYes.MouseDown += (sender, e) =>
            {
                result = MessageBoxResult.Yes;
                window.DialogResult = true;
                window.Close();
            };
            StackPanel stackPanelNo = new StackPanel
            {
                Height = 25,
                Width = 80,
                Background = (Brush)bc.ConvertFrom("#EEEFF3"),
                HorizontalAlignment = HorizontalAlignment.Right,
                Margin = new Thickness(0, 0, 12, 0)
                
            };
            TextBlock textBlockNo = new TextBlock
            {
                Text = "NO",
                Foreground = Brushes.Black,
                HorizontalAlignment = HorizontalAlignment.Center,
                Margin = new Thickness(0, 5, 0, 0),
                FontWeight = FontWeights.Bold,
            };
            stackPanelNo.Children.Add(textBlockNo);
            stackPanelNo.MouseDown += (sender, e) =>
            {
                result = MessageBoxResult.No;
                window.DialogResult = true;
                window.Close();
            };
            StackPanel stackPanelOk = new StackPanel
            {
                Height = 25,
                Width = 80,
                Background = (Brush)bc.ConvertFrom("#EEEFF3"),
                HorizontalAlignment = HorizontalAlignment.Right,
                Margin = new Thickness(0, 0, 10, 0)
            };
            TextBlock textBlockOk = new TextBlock
            {
                Text = "OK",
                Foreground = Brushes.Black,
                HorizontalAlignment = HorizontalAlignment.Center,
                Margin = new Thickness(0, 5, 0, 0),
                FontWeight = FontWeights.Bold,
            };
            stackPanelOk.Children.Add(textBlockOk);
            stackPanelOk.MouseDown += (sender, e) =>
            {
                result = MessageBoxResult.OK;
                window.DialogResult = true;
                window.Close();
            };
            if (button == MessageBoxButton.OK || button == MessageBoxButton.OKCancel)
            {
                stackPanelOk.RenderTransform = new TranslateTransform(13, 0);
                buttonGrid.Children.Add(stackPanelOk);
            }
            if (button == MessageBoxButton.YesNo || button == MessageBoxButton.YesNoCancel)
            {
                stackPanelYes.RenderTransform = new TranslateTransform(16, 0);
                stackPanelNo.RenderTransform = new TranslateTransform(14, 0);
                buttonGrid.Children.Add(stackPanelYes);
                buttonGrid.Children.Add(stackPanelNo);
            }
            if (button == MessageBoxButton.OKCancel || button == MessageBoxButton.YesNoCancel)
            {
                stackPanelYes.RenderTransform = new TranslateTransform(20, 0);


                StackPanel stackPanelCancel = new StackPanel
                {
                    Height = 25,
                    Width = 80,
                    Background = (Brush)bc.ConvertFrom("#FE4F64"),
                    HorizontalAlignment = HorizontalAlignment.Left,
                    Margin = new Thickness(415, 0, 10, 0)
                };

                TextBlock textBlockCancel = new TextBlock
                {
                    Text = "CANCEL",
                    Foreground = (Brush)bc.ConvertFrom("#710000"),
                    HorizontalAlignment = HorizontalAlignment.Center,
                    Margin = new Thickness(0, 5, 0, 0),
                    FontWeight = FontWeights.Bold,
                };

                stackPanelCancel.Children.Add(textBlockCancel);
                stackPanelCancel.MouseDown += (sender, e) =>
                {
                    result = MessageBoxResult.Cancel;
                    window.DialogResult = true;
                    window.Close();
                };

                stackPanelYes.Margin = new Thickness(0, 0, 190, 0);
                stackPanelNo.Margin = new Thickness(0, 0, 95, 0);
                stackPanelOk.Margin = new Thickness(0, 0, 95, 0);

                stackPanelCancel.RenderTransform = new TranslateTransform(12, 0);
                buttonGrid.Children.Add(stackPanelCancel);
            }

            panel.Children.Add(buttonGrid);
            window.Content = panel;
            window.ShowDialog();
            return result;
        }
        /// <summary>
        /// 
        /// </summary>
        /// 
        internal static MessageBoxResult ShowMsg(List<TrapCountInfo>trapcountInfo,string title)
        {
            

            BrushConverter bc = new BrushConverter();
            
           // Main window
           Window window = new Window
            {
                Title = title,
                SizeToContent = SizeToContent.WidthAndHeight,
                ResizeMode = ResizeMode.NoResize,
                Background = (Brush)bc.ConvertFrom("#0064C1"),
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
                Foreground = Brushes.White,
                WindowStyle = WindowStyle.SingleBorderWindow,
                WindowState = WindowState.Normal,
                BorderBrush = (Brush)bc.ConvertFrom("#EEEFF3"),
                BorderThickness = new Thickness(1),
            };

            // StackPanel to hold content
            StackPanel stackPanel = new StackPanel
            {
                Margin = new Thickness(0)
            };

            // Create GridView columns
            GridView gridView = new GridView();

            gridView.Columns.Add(new GridViewColumn
            {
                Header = "S.No",
                DisplayMemberBinding = new System.Windows.Data.Binding("SerialNo"),
                Width = 30
            });

            gridView.Columns.Add(new GridViewColumn
            {
                Header = "Trap Type",
                DisplayMemberBinding = new System.Windows.Data.Binding("TrapType"),
                Width = 300
            });

            gridView.Columns.Add(new GridViewColumn
            {
                Header = "Count",
                DisplayMemberBinding = new System.Windows.Data.Binding("Count"),
                Width = 45
            });

            // Define item container style
            Style itemStyle = new Style(typeof(ListViewItem));

            // Background hover effect
            itemStyle.Setters.Add(new Setter(Control.BackgroundProperty, Brushes.Transparent));
            itemStyle.Setters.Add(new Setter(Control.PaddingProperty, new Thickness(5)));
            itemStyle.Setters.Add(new Setter(Control.MarginProperty, new Thickness(2)));
            itemStyle.Setters.Add(new Setter(Control.FontWeightProperty, FontWeights.SemiBold));
            itemStyle.Setters.Add(new Setter(Control.ForegroundProperty, Brushes.White));
            itemStyle.Setters.Add(new Setter(Control.BorderBrushProperty, Brushes.LightGray));
            itemStyle.Setters.Add(new Setter(Control.BorderThicknessProperty, new Thickness(0, 0, 0, 1)));

            // Add triggers for mouse hover
            Trigger hoverTrigger = new Trigger
            {
                Property = UIElement.IsMouseOverProperty,
                Value = true
            };
            hoverTrigger.Setters.Add(new Setter(Control.BackgroundProperty, new SolidColorBrush(Color.FromArgb(40, 255, 255, 255))));

            itemStyle.Triggers.Add(hoverTrigger);

            // Create the ListView and apply the style
            ListView listView = new ListView
            {
                View = gridView,
                Height = 300,
                Width = 400,
                Margin = new Thickness(0, 0, 0, 10),
                Background = Brushes.Transparent,
                Foreground = Brushes.White,
                FontWeight = FontWeights.SemiBold,
                ItemContainerStyle = itemStyle
            };// Apply the style

            // Prepare data with serial number
            var dataWithSerial = trapcountInfo.Select((item, index) => new
            {
                SerialNo = index + 1,
                TrapType = item.NotificationType,
                Count = item.TrapCount,
            }).ToList();
            listView.ItemsSource=null;
            listView.ItemsSource = dataWithSerial;

            // ScrollViewer wrapper
            ScrollViewer scrollViewer = new ScrollViewer
            {
                Content = listView,
                VerticalScrollBarVisibility = ScrollBarVisibility.Auto,
                Height = 320
            };

            stackPanel.Children.Add(scrollViewer);
            window.Content = stackPanel;

            bool? result = window.ShowDialog();
            return result == true ? MessageBoxResult.OK : MessageBoxResult.Cancel;
        }
        /// <summary>
        private static string GetImagePath
        {
            get
            {
                string projectDirectory = string.Empty;
                string path = string.Empty;
                string fullPath = string.Empty;

                string workingDirectory = Environment.CurrentDirectory;
                if (workingDirectory != null)
                {
                    projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
                    if (!string.IsNullOrEmpty(projectDirectory))
                    {
                        path = @"\Assarts\check.png";
                        fullPath = projectDirectory + path;
                    }
                    else
                    {
                        throw new Exception(CommonLib.Common.Projectnotfound);
                    }
                }
                else
                {
                    throw new Exception(CommonLib.Common.Projectdirfound);
                }

                if (!string.IsNullOrEmpty(fullPath))
                {
                    return fullPath;
                }
                else
                {
                    throw new Exception("Image path not found");
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private static string GetImagePathWarning
        {
            get
            {
                string projectDirectory = string.Empty;
                string path = string.Empty;
                string fullPath = string.Empty;

                string workingDirectory = Environment.CurrentDirectory;
                if (workingDirectory != null)
                {
                    projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
                    if (!string.IsNullOrEmpty(projectDirectory))
                    {
                        path = @"\Assarts\warning-sign.png";
                        fullPath = projectDirectory + path;
                    }
                    else
                    {
                        throw new Exception(CommonLib.Common.Projectnotfound);
                    }
                }
                else
                {
                    throw new Exception(CommonLib.Common.Projectdirfound);
                }

                if (!string.IsNullOrEmpty(fullPath))
                {
                    return fullPath;
                }
                else
                {
                    throw new Exception("Image path not found");
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private static string GetImagePathError
        {
            get
            {
                string projectDirectory = string.Empty;
                string path = string.Empty;
                string fullPath = string.Empty;

                string workingDirectory = Environment.CurrentDirectory;
                if (workingDirectory != null)
                {
                    projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
                    if (!string.IsNullOrEmpty(projectDirectory))
                    {
                        path = @"\Assarts\error.png";
                        fullPath = projectDirectory + path;
                    }
                    else
                    {
                        throw new Exception("Project directory not found");
                    }
                }
                else
                {
                    throw new Exception("Working directory not found");
                }

                if (!string.IsNullOrEmpty(fullPath))
                {
                    return fullPath;
                }
                else
                {
                    throw new Exception("Image path not found");
                }
            }
        }
    }
}
