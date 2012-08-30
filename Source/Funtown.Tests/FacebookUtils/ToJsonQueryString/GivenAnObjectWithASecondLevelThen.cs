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

namespace Funtown.Tests.FuntownUtils.ToJsonQueryString
{
    using Funtown;
    using System.Collections.Generic;
    using System.Dynamic;
    using Xunit;

    public class GivenAnObjectWithASecondLevelThen
    {
        [Fact]
        public void ShouldSerializeItCorrectly()
        {
            dynamic attachment = new ExpandoObject();
            attachment.name = "my attachment";
            attachment.href = "http://apps.funtown.com/canvas";

            dynamic parameters = new ExpandoObject();
            parameters.method = "stream.publish";
            parameters.message = "my message";
            parameters.attachment = attachment;

#if SILVERLIGHT
            string result = FuntownUtils.ToJsonQueryString((IDictionary<string, object>)parameters);
#else
            string result = FuntownUtils.ToJsonQueryString(parameters);
#endif
            Assert.Equal("method=stream.publish&message=my%20message&attachment=%7B%22name%22%3A%22my%20attachment%22%2C%22href%22%3A%22http%3A%2F%2Fapps.funtown.com%2Fcanvas%22%7D", result);
        }
    }
}