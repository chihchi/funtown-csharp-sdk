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

namespace Funtown.Tests.Rest
{
    using System.Configuration;
    using System.Dynamic;
    using Xunit;

    public class RestReadTests
    {
        private FuntownClient app;
        public RestReadTests()
        {
            app = new FuntownClient();
            app.AccessToken = ConfigurationManager.AppSettings["AccessToken"];
        }

        [Fact]
        public void user_getInfo_rest_should_throw_oauth()
        {
            dynamic parameters = new ExpandoObject();
            parameters.method = "user.getInfo";
            parameters.uids = "14812017";
            parameters.fields = "first_name,last_name";
            parameters.access_token = "invalidtoken";

            Assert.Throws<FuntownOAuthException>(
                () =>
                    {
                        var result = app.Get(parameters);
                        // var firstName = result[0].first_name;
                    });
        }

    }
}
