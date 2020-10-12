using System;
using System.Collections.Generic;
using Microsoft.DocAsCode.DataContracts.Common;
using Microsoft.DocAsCode.YamlSerialization;
using Newtonsoft.Json;
using YamlDotNet.Serialization;

namespace DocFx.Plugins.TypeScriptReference
{
    [Serializable]
    public class ApiDeprecatedBuildOutput
    {
        [YamlMember(Alias = Constants.PropertyName.Content)]
        [JsonProperty(Constants.PropertyName.Content)]
        public List<ApiLanguageValuePair<string>> Content { get; set; }

        [ExtensibleMember]
        [JsonExtensionData]
        public Dictionary<string, object> Metadata { get; set; } = new Dictionary<string, object>();
    }
}
