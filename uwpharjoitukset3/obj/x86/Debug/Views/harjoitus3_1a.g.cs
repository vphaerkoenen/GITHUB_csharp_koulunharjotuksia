﻿#pragma checksum "E:\Github\GLOBAL_GITHUB_vphaerkoenen\code_samples\uuwpharjoitukset3\uwpharjoitukset3\Views\harjoitus3_1a.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9AC080941D9135F83EADA6E105F83CC685F26AB182A74F6616B8B5C3A74C74D5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace uwpharjoitukset3.Views
{
    partial class harjoitus3_1a : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class harjoitus3_1a_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            Iharjoitus3_1a_Bindings
        {
            private global::uwpharjoitukset3.Views.harjoitus3_1a dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.TextBlock obj2;
            private global::Windows.UI.Xaml.Controls.TextBlock obj5;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj2TextDisabled = false;
            private static bool isobj5TextDisabled = false;

            private harjoitus3_1a_obj1_BindingsTracking bindingsTracking;

            public harjoitus3_1a_obj1_Bindings()
            {
                this.bindingsTracking = new harjoitus3_1a_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 15 && columnNumber == 75)
                {
                    isobj2TextDisabled = true;
                }
                else if (lineNumber == 18 && columnNumber == 118)
                {
                    isobj5TextDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // Views\harjoitus3_1a.xaml line 15
                        this.obj2 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 5: // Views\harjoitus3_1a.xaml line 18
                        this.obj5 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // Iharjoitus3_1a_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::uwpharjoitukset3.Views.harjoitus3_1a)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::uwpharjoitukset3.Views.harjoitus3_1a obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_PassWord(obj.PassWord, phase);
                        this.Update_UselessFact(obj.UselessFact, phase);
                    }
                }
            }
            private void Update_PassWord(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\harjoitus3_1a.xaml line 15
                    if (!isobj2TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj2, obj, null);
                    }
                }
            }
            private void Update_UselessFact(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\harjoitus3_1a.xaml line 18
                    if (!isobj5TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj5, obj, null);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class harjoitus3_1a_obj1_BindingsTracking
            {
                private global::System.WeakReference<harjoitus3_1a_obj1_Bindings> weakRefToBindingObj; 

                public harjoitus3_1a_obj1_BindingsTracking(harjoitus3_1a_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<harjoitus3_1a_obj1_Bindings>(obj);
                }

                public harjoitus3_1a_obj1_Bindings TryGetBindingObject()
                {
                    harjoitus3_1a_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_(null);
                }

                public void PropertyChanged_(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    harjoitus3_1a_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::uwpharjoitukset3.Views.harjoitus3_1a obj = sender as global::uwpharjoitukset3.Views.harjoitus3_1a;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_PassWord(obj.PassWord, DATA_CHANGED);
                                bindings.Update_UselessFact(obj.UselessFact, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "PassWord":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_PassWord(obj.PassWord, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "UselessFact":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_UselessFact(obj.UselessFact, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                public void UpdateChildListeners_(global::uwpharjoitukset3.Views.harjoitus3_1a obj)
                {
                    harjoitus3_1a_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        if (bindings.dataRoot != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)bindings.dataRoot).PropertyChanged -= PropertyChanged_;
                        }
                        if (obj != null)
                        {
                            bindings.dataRoot = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Views\harjoitus3_1a.xaml line 15
                {
                    this.PassWordTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3: // Views\harjoitus3_1a.xaml line 16
                {
                    this.PassWordButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.PassWordButton).Click += this.Button_Click;
                }
                break;
            case 4: // Views\harjoitus3_1a.xaml line 17
                {
                    this.UselessFactButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.UselessFactButton).Click += this.UselessFactButton_Click;
                }
                break;
            case 5: // Views\harjoitus3_1a.xaml line 18
                {
                    this.UselessFactTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // Views\harjoitus3_1a.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    harjoitus3_1a_obj1_Bindings bindings = new harjoitus3_1a_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

