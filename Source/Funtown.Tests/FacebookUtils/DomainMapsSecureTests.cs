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

    public class DomainMapsSecureTests
    {
        [Fact]
        public void CountEquals7()
        {
            var result = FuntownUtils.DomainMapsSecure.Count;

            Assert.Equal(7, result);
        }

        [Fact]
        public void ApiIsSetCorrectly()
        {
            var result = FuntownUtils.DomainMapsSecure[FuntownUtils.DOMAIN_MAP_API].ToString();

            Assert.Equal("https://api.funtown.com/", result);
        }

        [Fact]
        public void ApiReadIsSetCorrectly()
        {
            var result = FuntownUtils.DomainMapsSecure[FuntownUtils.DOMAIN_MAP_API_READ].ToString();

            Assert.Equal("https://api-read.funtown.com/", result);
        }

        [Fact]
        public void ApiVideoIsSetCorrectly()
        {
            var result = FuntownUtils.DomainMapsSecure[FuntownUtils.DOMAIN_MAP_API_VIDEO].ToString();

            Assert.Equal("https://api-video.funtown.com/", result);
        }

        [Fact]
        public void GraphIsSetCorrectly()
        {
            var result = FuntownUtils.DomainMapsSecure[FuntownUtils.DOMAIN_MAP_GRAPH].ToString();

            Assert.Equal("https://graph.funtown.com/", result);
        }

        [Fact]
        public void GraphVideoSetCorrectly()
        {
            var result = FuntownUtils.DomainMapsSecure[FuntownUtils.DOMAIN_MAP_GRAPH_VIDEO].ToString();

            Assert.Equal("https://graph-video.funtown.com/", result);
        }

        [Fact]
        public void WwwIsSetCorrectly()
        {
            var result = FuntownUtils.DomainMapsSecure[FuntownUtils.DOMAIN_MAP_WWW].ToString();

            Assert.Equal("https://www.funtown.com/", result);
        }

        [Fact]
        public void AppsIsSetCorrectly()
        {
            var result = FuntownUtils.DomainMapsSecure[FuntownUtils.DOMAIN_MAP_APPS].ToString();

            Assert.Equal("https://apps.funtown.com/", result);
        }
    }
}