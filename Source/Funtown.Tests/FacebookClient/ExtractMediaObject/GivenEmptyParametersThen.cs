﻿//-----------------------------------------------------------------------
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

using System.Collections.Generic;
using Xunit;

namespace Funtown.Tests.FuntownClient.ExtractMediaObject
{
    using Funtown;

    public class GivenEmptyParametersThen
    {
        private IDictionary<string, object> _parameters;

        public GivenEmptyParametersThen()
        {
            _parameters = new Dictionary<string, object>();
        }

        [Fact]
        public void ReturnValueIsNotNull()
        {
            var result = FuntownClient.ExtractMediaObjects(_parameters);

            Assert.NotNull(result);
        }

        [Fact]
        public void CountIs0()
        {
            var result = FuntownClient.ExtractMediaObjects(_parameters);

            Assert.Equal(0, result.Count);
        }
    }
}