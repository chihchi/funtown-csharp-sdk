//-----------------------------------------------------------------------
// <copyright file="<file>.cs" company="The Outercurve Foundation">
//    Copyright (c) 2011, The Outercurve Foundation. 
//
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//      http://www.apache.org/licenses/LICENSE-2.0
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
// </copyright>
// <author>Nathan Totten (ntotten.com), Jim Zimmerman (jimzimmerman.com) and Prabir Shrestha (prabir.me)</author>
// <website>https://github.com/funtown-csharp-sdk/facbook-csharp-sdk</website>
//-----------------------------------------------------------------------

namespace Funtown.Tests.FuntownUtils.ParseQueryParametersToDictionary
{
    using System.Collections.Generic;
    using Funtown;
    using Xunit;

    public class GivenAPathStartingWithForwardSlashAndNoQueryStringAndEmptyParametersThen
    {
        [Fact(DisplayName = "ParseUrlParameters: Given a path starting with Forward slash and empty parameters Then return path equals the path without forward slash")]
        public void ReturnPathEqualsThePathWithoutForwardSlash()
        {
            string originalPath = "/me/likes";
            string pathWithoutForwardSlash = "me/likes";
            var parameters = new Dictionary<string, object>();

            var path = FuntownUtils.ParseQueryParametersToDictionary(originalPath, parameters);

            Assert.Equal(pathWithoutForwardSlash, path);
        }
    }
}