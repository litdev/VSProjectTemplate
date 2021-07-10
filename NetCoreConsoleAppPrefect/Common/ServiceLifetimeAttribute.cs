﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    /// <summary>
    /// 指定服务生命周期，默认Scoped
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class ServiceLifetimeAttribute : Attribute
    {
        private ServiceLifetime _Lifetime = ServiceLifetime.Scoped;
        private bool _IsEnabled = true;

        /// <summary>
        /// 默认Scoped
        /// </summary>
        public ServiceLifetimeAttribute()
        {
            this.Lifetime = ServiceLifetime.Scoped;
            this.IsEnabled = true;
        }

        public ServiceLifetimeAttribute(ServiceLifetime serviceLifetime)
        {
            this.Lifetime = serviceLifetime;
            this.IsEnabled = true;
        }

        public ServiceLifetimeAttribute(bool isEnabled)
        {
            this.Lifetime = ServiceLifetime.Scoped;
            this.IsEnabled = IsEnabled;
        }

        public ServiceLifetimeAttribute(ServiceLifetime serviceLifetime, bool isEnabled)
        {
            this.Lifetime = serviceLifetime;
            this.IsEnabled = IsEnabled;
        }


        /// <summary>
        /// 生命周期
        /// </summary>
        public ServiceLifetime Lifetime
        {
            get
            {
                return _Lifetime;
            }
            set
            {
                _Lifetime = value;
            }
        }

        /// <summary>
        /// 是否启用
        /// </summary>
        public bool IsEnabled
        {
            get
            {
                return _IsEnabled;
            }
            set
            {
                _IsEnabled = value;
            }
        }
    }
}
