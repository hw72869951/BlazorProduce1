﻿using System.ComponentModel;

namespace BlazorProduce1.Common
{
    /// <summary>
    /// 事件说明类
    /// </summary>
    public class EventItem
    {
        /// <summary>
        /// 获得/设置 参数
        /// </summary>
        [DisplayName("参数")]
        public string Name { get; set; } = "";

        /// <summary>
        /// 获得/设置 说明
        /// </summary>
        [DisplayName("说明")]
        public string Description { get; set; } = "";

        /// <summary>
        /// 获得/设置 类型
        /// </summary>
        [DisplayName("类型")]
        public string Type { get; set; } = "";
    }
}
