using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace LCPReportingSystem.Command
{
    public static class MouseActionCommand
    {
        public static readonly DependencyProperty MouseDownCommandProperty =
            DependencyProperty.RegisterAttached(
                "MouseDownCommand",
                typeof(ICommand),
                typeof(MouseActionCommand),
                new PropertyMetadata(null, OnMouseEnterCommandChanged));

        public static void SetMouseDownCommand(UIElement element, ICommand value)
        {
            element.SetValue(MouseDownCommandProperty, value);
        }

        public static ICommand GetMouseDownCommand(UIElement element)
        {
            return (ICommand)element.GetValue(MouseDownCommandProperty);
        }
        private static void OnMouseEnterCommandChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is UIElement uiElement)
            {
                uiElement.MouseDown += (sender, args) =>
                {
                    var command = GetMouseDownCommand(uiElement);
                    if (command != null && command.CanExecute(null))
                    {
                        command.Execute(null);
                    }
                };
            }
        }
        public static readonly DependencyProperty MouseLeaveCommandProperty =
            DependencyProperty.RegisterAttached(
                "MouseLeaveCommand",
                typeof(ICommand),
                typeof(MouseActionCommand),
                new PropertyMetadata(null, OnMouseLeaveCommandChanged));

        public static void SetMouseLeaveCommand(UIElement element, ICommand value)
        {
            element.SetValue(MouseLeaveCommandProperty, value);
        }

        public static ICommand GetMouseLeaveCommand(UIElement element)
        {
            return (ICommand)element.GetValue(MouseLeaveCommandProperty);
        }

        private static void OnMouseLeaveCommandChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is UIElement uiElement)
            {
                uiElement.MouseLeave += (sender, args) =>
                {
                    var command = GetMouseLeaveCommand(uiElement);
                    if (command != null && command.CanExecute(null))
                    {
                        command.Execute(null);
                    }
                };
            }
        }
    }
}
