﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6F3801B6F6170AF5F259FE21277268CE81F30BB10BBB013AB5255CE735428E1A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace EV3Explorer {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 2 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal EV3Explorer.MainWindow window;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ColumnDefinition leftColumn;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ColumnDefinition rightColumn;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView PCDirectory;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridView PCDirectoryGridView;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView EV3Directory;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridView EV3DirectoryGridView;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock BrickNotFound;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EV3RefreshList;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EV3NavigateUp;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EV3SwitchDevice;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EV3Path;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EV3DeviceName;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PCNavigateUp;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PCRefreshList;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PCPath;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteFile;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NewFolder;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Upload;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RunFile;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Download;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CompileAndRun;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Compile;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox OnlyShowPrograms;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/EV3Explorer;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.window = ((EV3Explorer.MainWindow)(target));
            
            #line 5 "..\..\MainWindow.xaml"
            this.window.KeyDown += new System.Windows.Input.KeyEventHandler(this.Window_keydown);
            
            #line default
            #line hidden
            
            #line 6 "..\..\MainWindow.xaml"
            this.window.Closing += new System.ComponentModel.CancelEventHandler(this.Window_closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.leftColumn = ((System.Windows.Controls.ColumnDefinition)(target));
            return;
            case 3:
            this.rightColumn = ((System.Windows.Controls.ColumnDefinition)(target));
            return;
            case 4:
            this.PCDirectory = ((System.Windows.Controls.ListView)(target));
            
            #line 20 "..\..\MainWindow.xaml"
            this.PCDirectory.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.PCDirectory_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.PCDirectoryGridView = ((System.Windows.Controls.GridView)(target));
            return;
            case 6:
            this.EV3Directory = ((System.Windows.Controls.ListView)(target));
            
            #line 29 "..\..\MainWindow.xaml"
            this.EV3Directory.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.EV3Directory_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.EV3DirectoryGridView = ((System.Windows.Controls.GridView)(target));
            return;
            case 8:
            this.BrickNotFound = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.EV3RefreshList = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\MainWindow.xaml"
            this.EV3RefreshList.Click += new System.Windows.RoutedEventHandler(this.EV3RefreshList_clicked);
            
            #line default
            #line hidden
            return;
            case 10:
            this.EV3NavigateUp = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\MainWindow.xaml"
            this.EV3NavigateUp.Click += new System.Windows.RoutedEventHandler(this.EV3NavigateUp_clicked);
            
            #line default
            #line hidden
            return;
            case 11:
            this.EV3SwitchDevice = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\MainWindow.xaml"
            this.EV3SwitchDevice.Click += new System.Windows.RoutedEventHandler(this.EV3SwitchDevice_clicked);
            
            #line default
            #line hidden
            return;
            case 12:
            this.EV3Path = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            this.EV3DeviceName = ((System.Windows.Controls.TextBox)(target));
            
            #line 43 "..\..\MainWindow.xaml"
            this.EV3DeviceName.LostKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.DeviceName_focuslost);
            
            #line default
            #line hidden
            
            #line 43 "..\..\MainWindow.xaml"
            this.EV3DeviceName.KeyDown += new System.Windows.Input.KeyEventHandler(this.DeviceName_keydown);
            
            #line default
            #line hidden
            return;
            case 14:
            this.PCNavigateUp = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\MainWindow.xaml"
            this.PCNavigateUp.Click += new System.Windows.RoutedEventHandler(this.PCNavigateUp_clicked);
            
            #line default
            #line hidden
            return;
            case 15:
            this.PCRefreshList = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\MainWindow.xaml"
            this.PCRefreshList.Click += new System.Windows.RoutedEventHandler(this.PCRefreshList_clicked);
            
            #line default
            #line hidden
            return;
            case 16:
            this.PCPath = ((System.Windows.Controls.TextBox)(target));
            return;
            case 17:
            this.DeleteFile = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\MainWindow.xaml"
            this.DeleteFile.Click += new System.Windows.RoutedEventHandler(this.DeleteFile_clicked);
            
            #line default
            #line hidden
            return;
            case 18:
            this.NewFolder = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\MainWindow.xaml"
            this.NewFolder.Click += new System.Windows.RoutedEventHandler(this.NewFolder_clicked);
            
            #line default
            #line hidden
            return;
            case 19:
            this.Upload = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\MainWindow.xaml"
            this.Upload.Click += new System.Windows.RoutedEventHandler(this.Upload_clicked);
            
            #line default
            #line hidden
            return;
            case 20:
            this.RunFile = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\MainWindow.xaml"
            this.RunFile.Click += new System.Windows.RoutedEventHandler(this.RunFile_clicked);
            
            #line default
            #line hidden
            return;
            case 21:
            this.Download = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\MainWindow.xaml"
            this.Download.Click += new System.Windows.RoutedEventHandler(this.Download_clicked);
            
            #line default
            #line hidden
            return;
            case 22:
            this.CompileAndRun = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\MainWindow.xaml"
            this.CompileAndRun.Click += new System.Windows.RoutedEventHandler(this.CompileAndRun_clicked);
            
            #line default
            #line hidden
            return;
            case 23:
            this.Compile = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\MainWindow.xaml"
            this.Compile.Click += new System.Windows.RoutedEventHandler(this.Compile_clicked);
            
            #line default
            #line hidden
            return;
            case 24:
            this.OnlyShowPrograms = ((System.Windows.Controls.CheckBox)(target));
            
            #line 54 "..\..\MainWindow.xaml"
            this.OnlyShowPrograms.Click += new System.Windows.RoutedEventHandler(this.OnlyShowPrograms_clicked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

