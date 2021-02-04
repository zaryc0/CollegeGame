using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace TUC.Interfaces.Shells
{
    public interface IShellBase
    {
        void Show();
        void Hide();
        void Close();
        void DragMove();
        ResizeMode ResizeMode { get; set; }
        event SizeChangedEventHandler SizeChanged;
        WindowState WindowState { get; set; }
    }
}
