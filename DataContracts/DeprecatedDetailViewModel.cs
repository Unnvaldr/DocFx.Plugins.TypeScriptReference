// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.DocAsCode.Common;
using Microsoft.DocAsCode.DataContracts.Common;
using Microsoft.DocAsCode.YamlSerialization;
using Newtonsoft.Json;
using YamlDotNet.Serialization;

namespace DocFx.Plugins.TypeScriptReference
{
    [Serializable]
    public class DeprecatedDetailViewModel
    {
        [YamlMember(Alias = Constants.PropertyName.Content)]
        [JsonProperty(Constants.PropertyName.Content)]
        [MarkdownContent]
        public string Content { get; set; }

        [ExtensibleMember(Constants.ExtensionMemberPrefix.Content)]
        [JsonIgnore]
        public SortedList<string, string> Contents { get; set; } = new SortedList<string, string>();

        [ExtensibleMember]
        [JsonIgnore]
        public Dictionary<string, object> Metadata { get; set; } = new Dictionary<string, object>();

        [EditorBrowsable(EditorBrowsableState.Never)]
        [YamlIgnore]
        [JsonExtensionData]
        [UniqueIdentityReferenceIgnore]
        [MarkdownContentIgnore]
        public CompositeDictionary ExtensionData =>
            CompositeDictionary
                .CreateBuilder()
                .Add(Constants.ExtensionMemberPrefix.Content, Contents, JTokenConverter.Convert<string>)
                .Add(string.Empty, Metadata)
                .Create();
    }
}
