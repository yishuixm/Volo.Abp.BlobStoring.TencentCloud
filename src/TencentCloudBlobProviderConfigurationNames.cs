﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Leo.Abp.BlobStoring.TencentCloud
{
    public static class TencentCloudBlobProviderConfigurationNames
    {
        public const string BucketName = "TencentCloud.BucketName";
        public const string ContainerName = "TencentCloud.ContainerName";
        public const string CreateContainerIfNotExists = "TencentCloud.CreateContainerIfNotExists";

        public const string AppId = "TencntCloud.AppId";
        public const string SecretId = "TencentCloud.SecretId";
        public const string SecretKey = "TencentCloud.SecretKey";

        public const string Region = "TencentCloud.Region";
        public const string ConnectionLimit = "TencentCloud.ConnectionLimit";
        public const string ConnectionTimeout = "TencentCloud.ConnectionTimeout";
        public const string ReadWriteTimeout = "TencentCloud.ReadWriteTimeout";
        public const string KeyDurationSecond = "TencentCloud.KeyDurationSecond";
    }
}
