﻿using System;
using System.Collections.Generic;
using Volo.Abp.Data;
using Volo.Abp.Domain.Entities.Auditing;

namespace Abp.BizLogManagement
{
    /// <summary>
    /// 业务日志
    /// </summary>
    public class BizLog : CreationAuditedEntity<Guid>, IHasExtraProperties
    {
        public BizLog()
        {
            ExtraProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// 业务单号
        /// </summary>
        public string BizNo { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        public string BizType { get; set; }

        /// <summary>
        /// 业务名称
        /// </summary>
        public string BizName { get; set; }

        /// <summary>
        /// 业务描述
        /// </summary>
        public string BizDescription { get; set; }

        /// <summary>
        /// 业务单据数据
        /// </summary>
        public string BizData { get; set; }

        public virtual Dictionary<string, object> ExtraProperties { get; protected set; }
    }
}