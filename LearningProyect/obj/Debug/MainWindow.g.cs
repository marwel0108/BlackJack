﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7CA5BC84FB893C6940D4321EB4A9776DC8675F8C442E661BD9F2EDC9811C754B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using LearningProyect;
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


namespace LearningProyect {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle Table;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border playerZoneBorder;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel PlayerZone;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddCard;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button StopGame;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Reset;
        
        #line default
        #line hidden
        
        
        #line 160 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border pcZoneBorder;
        
        #line default
        #line hidden
        
        
        #line 167 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel PCZone;
        
        #line default
        #line hidden
        
        
        #line 181 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Quit;
        
        #line default
        #line hidden
        
        
        #line 217 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button pPoints;
        
        #line default
        #line hidden
        
        
        #line 224 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button pcPoints;
        
        #line default
        #line hidden
        
        
        #line 231 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button playerRounds;
        
        #line default
        #line hidden
        
        
        #line 239 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button pcRounds;
        
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
            System.Uri resourceLocater = new System.Uri("/LearningProyect;component/mainwindow.xaml", System.UriKind.Relative);
            
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
            
            #line 15 "..\..\MainWindow.xaml"
            ((LearningProyect.MainWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Table = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 3:
            this.playerZoneBorder = ((System.Windows.Controls.Border)(target));
            
            #line 39 "..\..\MainWindow.xaml"
            this.playerZoneBorder.MouseEnter += new System.Windows.Input.MouseEventHandler(this.border_playerZoneBorder_Enter);
            
            #line default
            #line hidden
            
            #line 40 "..\..\MainWindow.xaml"
            this.playerZoneBorder.MouseLeave += new System.Windows.Input.MouseEventHandler(this.border_playerZoneBorder_Leave);
            
            #line default
            #line hidden
            return;
            case 4:
            this.PlayerZone = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 5:
            this.AddCard = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\MainWindow.xaml"
            this.AddCard.Click += new System.Windows.RoutedEventHandler(this.btn_AddCard_Click);
            
            #line default
            #line hidden
            
            #line 57 "..\..\MainWindow.xaml"
            this.AddCard.MouseEnter += new System.Windows.Input.MouseEventHandler(this.btn_AddCard_MouseEnter);
            
            #line default
            #line hidden
            
            #line 58 "..\..\MainWindow.xaml"
            this.AddCard.MouseLeave += new System.Windows.Input.MouseEventHandler(this.btn_AddCard_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 6:
            this.StopGame = ((System.Windows.Controls.Button)(target));
            
            #line 91 "..\..\MainWindow.xaml"
            this.StopGame.Click += new System.Windows.RoutedEventHandler(this.btn_StopGame_Click);
            
            #line default
            #line hidden
            
            #line 92 "..\..\MainWindow.xaml"
            this.StopGame.MouseEnter += new System.Windows.Input.MouseEventHandler(this.btn_StopGame_MouseEnter);
            
            #line default
            #line hidden
            
            #line 93 "..\..\MainWindow.xaml"
            this.StopGame.MouseLeave += new System.Windows.Input.MouseEventHandler(this.btn_StopGame_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Reset = ((System.Windows.Controls.Button)(target));
            
            #line 126 "..\..\MainWindow.xaml"
            this.Reset.Click += new System.Windows.RoutedEventHandler(this.btn_Reset_Click);
            
            #line default
            #line hidden
            
            #line 127 "..\..\MainWindow.xaml"
            this.Reset.MouseEnter += new System.Windows.Input.MouseEventHandler(this.btn_Reset_MouseEnter);
            
            #line default
            #line hidden
            
            #line 128 "..\..\MainWindow.xaml"
            this.Reset.MouseLeave += new System.Windows.Input.MouseEventHandler(this.btn_Reset_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 8:
            this.pcZoneBorder = ((System.Windows.Controls.Border)(target));
            
            #line 165 "..\..\MainWindow.xaml"
            this.pcZoneBorder.MouseEnter += new System.Windows.Input.MouseEventHandler(this.border_pcZoneBorder_Enter);
            
            #line default
            #line hidden
            
            #line 166 "..\..\MainWindow.xaml"
            this.pcZoneBorder.MouseLeave += new System.Windows.Input.MouseEventHandler(this.border_pcZoneBorder_Leave);
            
            #line default
            #line hidden
            return;
            case 9:
            this.PCZone = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 10:
            this.Quit = ((System.Windows.Controls.Button)(target));
            
            #line 182 "..\..\MainWindow.xaml"
            this.Quit.Click += new System.Windows.RoutedEventHandler(this.btn_Quit_Click);
            
            #line default
            #line hidden
            
            #line 183 "..\..\MainWindow.xaml"
            this.Quit.MouseEnter += new System.Windows.Input.MouseEventHandler(this.btn_Quit_MouseEnter);
            
            #line default
            #line hidden
            
            #line 184 "..\..\MainWindow.xaml"
            this.Quit.MouseLeave += new System.Windows.Input.MouseEventHandler(this.btn_Quit_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 11:
            this.pPoints = ((System.Windows.Controls.Button)(target));
            return;
            case 12:
            this.pcPoints = ((System.Windows.Controls.Button)(target));
            return;
            case 13:
            this.playerRounds = ((System.Windows.Controls.Button)(target));
            return;
            case 14:
            this.pcRounds = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

