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

namespace Funtown.Tests.FuntownUtils
{
    using Funtown;
    using Xunit;

    public class DropQueryParametersTests
    {
        [Fact]
        public void CountIs2()
        {
            var result = FuntownUtils.DropQueryParameters.Count;

            Assert.Equal(2, result);
        }

        [Fact]
        public void ContainsSession()
        {
            var result = FuntownUtils.DropQueryParameters.Contains("session");

            Assert.True(result);
        }

        [Fact]
        public void ContainsSignedRequest()
        {
            var result = FuntownUtils.DropQueryParameters.Contains("signed_request");

            Assert.True(result);
        }
    }
}