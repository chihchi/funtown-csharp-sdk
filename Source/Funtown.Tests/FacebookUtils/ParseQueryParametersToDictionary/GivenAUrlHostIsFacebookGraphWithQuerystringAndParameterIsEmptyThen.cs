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

    public class GivenAUrlHostIsFuntownGraphWithQuerystringAndParameterIsEmptyThen
    {
        [Fact]
        public void TheParameterValuesAreEqualToTheQuerystrings()
        {
            string urlWithQueryString = "http://graph.funtown.com/me/likes?limit=3&offset=2";
            var parameters = new Dictionary<string, object>();

            FuntownUtils.ParseQueryParametersToDictionary(urlWithQueryString, parameters);

            Assert.Equal("3", parameters["limit"]);
            Assert.Equal("2", parameters["offset"]);
        }

        [Fact]
        public void TheCountOfParameterIsEqualToTheCountOfQuerystring()
        {
            string urlWithQueryString = "http://graph.funtown.com/me/likes?limit=3&offset=2";
            var parameters = new Dictionary<string, object>();

            FuntownUtils.ParseQueryParametersToDictionary(urlWithQueryString, parameters);

            Assert.Equal(2, parameters.Count);
        }

        [Fact]
        public void TheReturnPathEqualsPathWithoutUriHostAndDoesNotStartWithForwardSlash()
        {
            string urlWithQueryString = "http://graph.funtown.com/me/likes?limit=3&offset=2";
            string originalPathWithoutForwardSlashAndWithoutQueryString = "me/likes";
            var parameters = new Dictionary<string, object>();

            var path = FuntownUtils.ParseQueryParametersToDictionary(urlWithQueryString, parameters);

            Assert.Equal(originalPathWithoutForwardSlashAndWithoutQueryString, path);
        }

        [Fact]
        public void TheReturnPathDoesNotStartWithForwardSlash()
        {
            string urlWithQueryString = "http://graph.funtown.com/me/likes?limit=3&offset=2";

            var parameters = new Dictionary<string, object>();

            var path = FuntownUtils.ParseQueryParametersToDictionary(urlWithQueryString, parameters);

            Assert.NotEqual('/', path[0]);
        }

    }
}