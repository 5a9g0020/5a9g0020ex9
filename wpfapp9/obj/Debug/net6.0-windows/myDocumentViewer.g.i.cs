﻿#pragma checksum "..\..\..\myDocumentViewer.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "930014850A3E5722C0DD881FCCB5668B6A4935DC"
//------------------------------------------------------------------------------
// <auto-generated>
//     這段程式碼是由工具產生的。
//     執行階段版本:4.0.30319.42000
//
//     對這個檔案所做的變更可能會造成錯誤的行為，而且如果重新產生程式碼，
//     變更將會遺失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using WpfApp1;
using Xceed.Wpf.Toolkit;
using Xceed.Wpf.Toolkit.Chromes;
using Xceed.Wpf.Toolkit.Converters;
using Xceed.Wpf.Toolkit.Core;
using Xceed.Wpf.Toolkit.Core.Converters;
using Xceed.Wpf.Toolkit.Core.Input;
using Xceed.Wpf.Toolkit.Core.Media;
using Xceed.Wpf.Toolkit.Core.Utilities;
using Xceed.Wpf.Toolkit.Mag.Converters;
using Xceed.Wpf.Toolkit.Panels;
using Xceed.Wpf.Toolkit.Primitives;
using Xceed.Wpf.Toolkit.PropertyGrid;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;
using Xceed.Wpf.Toolkit.PropertyGrid.Commands;
using Xceed.Wpf.Toolkit.PropertyGrid.Converters;
using Xceed.Wpf.Toolkit.PropertyGrid.Editors;
using Xceed.Wpf.Toolkit.Zoombox;


namespace WpfApp1 {
    
    
    /// <summary>
    /// MyDocumentViewer
    /// </summary>
    public partial class MyDocumentViewer : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\myDocumentViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button openButton;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\myDocumentViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveButton;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\myDocumentViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NewButton;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\myDocumentViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton btnBold;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\myDocumentViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton btnItalic;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\myDocumentViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton btnUnderline;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\myDocumentViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.ColorPicker fontColorPicker;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\myDocumentViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.ColorPicker backgroundColorPicker;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\myDocumentViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comFontFamily;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\myDocumentViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comFontSize;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\myDocumentViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Clear;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\myDocumentViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RichTextBox rtbEditor;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/mydocumentviewer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\myDocumentViewer.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 11 "..\..\..\myDocumentViewer.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.Open_Executed);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 12 "..\..\..\myDocumentViewer.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.Save_Executed);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 13 "..\..\..\myDocumentViewer.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.New_Executed);
            
            #line default
            #line hidden
            return;
            case 4:
            this.openButton = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.SaveButton = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.NewButton = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.btnBold = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            return;
            case 8:
            this.btnItalic = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            return;
            case 9:
            this.btnUnderline = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            return;
            case 10:
            this.fontColorPicker = ((Xceed.Wpf.Toolkit.ColorPicker)(target));
            
            #line 48 "..\..\..\myDocumentViewer.xaml"
            this.fontColorPicker.SelectedColorChanged += new System.Windows.RoutedPropertyChangedEventHandler<System.Nullable<System.Windows.Media.Color>>(this.FontColorPicker_SelectedColorChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.backgroundColorPicker = ((Xceed.Wpf.Toolkit.ColorPicker)(target));
            
            #line 51 "..\..\..\myDocumentViewer.xaml"
            this.backgroundColorPicker.SelectedColorChanged += new System.Windows.RoutedPropertyChangedEventHandler<System.Nullable<System.Windows.Media.Color>>(this.BackgroundColorPicker_SelectedColorChanged);
            
            #line default
            #line hidden
            return;
            case 12:
            this.comFontFamily = ((System.Windows.Controls.ComboBox)(target));
            
            #line 53 "..\..\..\myDocumentViewer.xaml"
            this.comFontFamily.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComFontFamily_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 13:
            this.comFontSize = ((System.Windows.Controls.ComboBox)(target));
            
            #line 54 "..\..\..\myDocumentViewer.xaml"
            this.comFontSize.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComFontSize_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 14:
            this.Clear = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\..\myDocumentViewer.xaml"
            this.Clear.Click += new System.Windows.RoutedEventHandler(this.Clear_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            this.rtbEditor = ((System.Windows.Controls.RichTextBox)(target));
            
            #line 63 "..\..\..\myDocumentViewer.xaml"
            this.rtbEditor.SelectionChanged += new System.Windows.RoutedEventHandler(this.RtbEditor_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
