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

namespace Funtown.Tests.ExceptionFactory.GetRestException
{
    using System.Collections.Generic;
    using Funtown;
    using Xunit;

    public class GivenAnDictionaryStringObjectWithErrorCodeNotEqualTo190Or4WithMessageRequestLimitReachedThen
    {
        private IDictionary<string, object> dict;

        public GivenAnDictionaryStringObjectWithErrorCodeNotEqualTo190Or4WithMessageRequestLimitReachedThen()
        {
            int errorCodeNot190or4 = 10000;
            dict = new Dictionary<string, object>
                       {
                           { "error_code", errorCodeNot190or4 },
                           { "error_msg", "request limit reached"}
                           // others ommited for brevity
                       };
        }

        [Fact]
        public void ResultIsNotNull()
        {
            var result = ExceptionFactory.GetRestException(dict);

            Assert.NotNull(result);
        }

        [Fact]
        public void ResultIsOfTypeFuntownApiLimitException()
        {
            var result = ExceptionFactory.GetRestException(dict);

            Assert.IsType<FuntownApiLimitException>(result);
        }
    }
}