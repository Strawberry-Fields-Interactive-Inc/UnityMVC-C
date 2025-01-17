﻿using System;
using UnityEngine;
using UnityMVC.Component;
using UnityMVC.Events;
using UnityMVC.View;

/*<NAMESPACE>*/
    //// Autogenerated code. DO NOT CHANGE unless it is really needed and you know what you are doing.
    public partial class MVCComponentGroupTemplate : MVCComponentGroup
    {
        private ViewTemplate View => BaseOwnerView as ViewTemplate;
        // Access Events from here. Please, use Observer pattern, people who uses Observer patterns are nice people.
        public /*NEW*/ ControllerTemplateEvents Events => View.Events;
        public override Type GetViewType()
        {
            return typeof(ViewTemplate);
        }
        
        public override bool IsActive()
        {
            bool viewExists = View != null;
            bool isActive = View.gameObject.activeSelf;
            if (viewExists)
            {
                Debug.LogWarning($"View {typeof(ViewTemplate).Name} does not exist");
            }
            if (!isActive)
            {
                Debug.LogWarning($"View {this.GetType().Name} not active");
            }
            return isActive && viewExists;
        }

        public override void SetView(View view)
        {
            BaseOwnerView = view as ViewTemplate;
            OnViewWasSet(BaseOwnerView);
        }

        protected override void InternalAwake()
        {
        }

        protected override void InternalStart()
        {
            
        }

        protected override void InternalOnEnable()
        {
            if (View == null)
            {
                return;
            }
            RegisterEvents();
        }

        protected override void InternalOnDisable()
        {
            if (View == null)
            {
                return;
            }
            UnregisterEvents();
        }

        protected override void InternalOnDestroy()
        {
            if (View == null)
            {
                return;
            }
            View.UnregisterComponentFromView(this);
        }
    }
/*}*/