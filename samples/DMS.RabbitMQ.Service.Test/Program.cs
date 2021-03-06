﻿using DMS.BaseFramework.Common.Extension;
using DMS.Log4net;
using DMS.RabbitMQ.Consumers;
using DMS.RabbitMQ.Extensions;
using DMS.RabbitMQ.Models;
using Microsoft.Extensions.Hosting;
using System;

namespace DMS.RabbitMQ.Service.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateDefaultHost(args).Run();
        }

        /// <summary>
        /// 创建
        /// </summary>
        /// <param name="configDir"></param>
        /// <returns></returns>
        static IHost CreateDefaultHost(string[] args) => new HostBuilder()
            .UseLog4net("Config\\log4net.config")
            .UseRabbitMQ("Config\\rabbitmq.json")
            .UseBusinessHost()//启用业务主机
                              //.UseAuditHost()//启用审计队列
            .Build();
    }
}
