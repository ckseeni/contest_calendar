﻿

#pragma checksum "C:\Users\mtslab\Documents\Visual Studio 2013\Projects\contest calendar\contest calendar\Calendar.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E17ACE4A36A887F55DD53F691D0B12DD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace contest_calendar
{
    partial class BlankPage1 : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 189 "..\..\Calendar.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.button1_Click;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 18 "..\..\Calendar.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.previousMonth;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 20 "..\..\Calendar.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.nextMonth;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


