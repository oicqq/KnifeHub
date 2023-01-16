﻿using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using PluginCore.IPlugins;
using DocsPlugin.Utils;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace DocsPlugin
{
    public class DocsPlugin : BasePlugin
    {
        public override (bool IsSuccess, string Message) AfterEnable()
        {
            Console.WriteLine($"{nameof(DocsPlugin)}: {nameof(AfterEnable)}");
            return base.AfterEnable();
        }

        public override (bool IsSuccess, string Message) BeforeDisable()
        {
            Console.WriteLine($"{nameof(DocsPlugin)}: {nameof(BeforeDisable)}");
            return base.BeforeDisable();
        }

    }
}
