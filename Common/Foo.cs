﻿using System.ComponentModel;

namespace BlazorProduce1.Common
{
    /// <summary>
    /// 
    /// </summary>
    internal class Foo
    {
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("城市名称")]
        public string Name { get; set; } = "上海";
    }
}
