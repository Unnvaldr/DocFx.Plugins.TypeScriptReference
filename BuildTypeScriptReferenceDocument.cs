// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System.Composition;
using Microsoft.DocAsCode.Build.Common;
using Microsoft.DocAsCode.Plugins;

namespace DocFx.Plugins.TypeScriptReference
{
    [Export(nameof(TypeScriptReferenceDocumentProcessor), typeof(IDocumentBuildStep))]
    public class BuildTypeScriptReferenceDocument : BuildReferenceDocumentBase
    {
        public override string Name => nameof(BuildTypeScriptReferenceDocument);

        #region BuildReferenceDocumentBase

        protected override void BuildArticle(IHostService host, FileModel model)
        {
            var pageViewModel = (PageViewModel)model.Content;

            BuildArticleCore(host, model, shouldSkipMarkup: pageViewModel?.ShouldSkipMarkup ?? false);
        }

        #endregion
    }
}