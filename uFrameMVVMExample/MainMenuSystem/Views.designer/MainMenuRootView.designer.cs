// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Example {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.Kernel;
    using uFrame.Kernel.Serialization;
    using uFrame.MVVM;
    using uFrame.MVVM.Bindings;
    using uFrame.MVVM.Services;
    using uFrame.MVVM.ViewModels;
    using UniRx;
    using UnityEngine;
    
    
    public class MainMenuRootViewBase : uFrame.MVVM.Views.ViewBase {
        
        [UnityEngine.SerializeField()]
        [uFrame.MVVM.Attributes.UFGroup("View Model Properties")]
        [UnityEngine.HideInInspector()]
        public Type _CurrentScreenType;
        
        [uFrame.MVVM.Attributes.UFToggleGroup("Screens")]
        [UnityEngine.HideInInspector()]
        public bool _BindScreens = true;
        
        [uFrame.MVVM.Attributes.UFGroup("Screens")]
        [UnityEngine.SerializeField()]
        [UnityEngine.HideInInspector()]
        [UnityEngine.Serialization.FormerlySerializedAsAttribute("_Screensparent")]
        protected UnityEngine.Transform _ScreensParent;
        
        [uFrame.MVVM.Attributes.UFGroup("Screens")]
        [UnityEngine.SerializeField()]
        [UnityEngine.HideInInspector()]
        [UnityEngine.Serialization.FormerlySerializedAsAttribute("_ScreensviewFirst")]
        protected bool _ScreensViewFirst;
        
        public override string DefaultIdentifier {
            get {
                return "MainMenuRoot";
            }
        }
        
        public override System.Type ViewModelType {
            get {
                return typeof(MainMenuRootViewModel);
            }
        }
        
        public MainMenuRootViewModel MainMenuRoot {
            get {
                return (MainMenuRootViewModel)ViewModelObject;
            }
        }
        
        protected override void InitializeViewModel(uFrame.MVVM.ViewModels.ViewModel model) {
            base.InitializeViewModel(model);
            // NOTE: this method is only invoked if the 'Initialize ViewModel' is checked in the inspector.
            // var vm = model as MainMenuRootViewModel;
            // This method is invoked when applying the data from the inspector to the viewmodel.  Add any view-specific customizations here.
            var mainmenurootview = ((MainMenuRootViewModel)model);
            mainmenurootview.CurrentScreenType = this._CurrentScreenType;
        }
        
        public override void Bind() {
            base.Bind();
            // Use this.MainMenuRoot to access the viewmodel.
            // Use this method to subscribe to the view-model.
            // Any designer bindings are created in the base implementation.
            if (_BindScreens) {
                this.BindToViewCollection(this.MainMenuRoot.Screens, this.ScreensCreateView, this.ScreensAdded, this.ScreensRemoved, _ScreensParent, _ScreensViewFirst);
            }
        }
        
        public virtual uFrame.MVVM.Views.ViewBase ScreensCreateView(uFrame.MVVM.ViewModels.ViewModel viewModel) {
            return InstantiateView(viewModel);
        }
        
        public virtual void ScreensAdded(uFrame.MVVM.Views.ViewBase view) {
        }
        
        public virtual void ScreensRemoved(uFrame.MVVM.Views.ViewBase view) {
        }
    }
}
