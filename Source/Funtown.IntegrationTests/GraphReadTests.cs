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

namespace Funtown.Tests.Graph
{
    using System;
    using System.Configuration;
    using System.Dynamic;
    using Xunit;

    /*
        * All objects in Funtown can be accessed in the same way:

       •Users: https://graph.funtown.com/btaylor (Bret Taylor)
       •Pages: https://graph.funtown.com/cocacola (Coca-Cola page)
       •Events: https://graph.funtown.com/251906384206 (Funtown Developer Garage Austin)
       •Groups: https://graph.funtown.com/2204501798 (Emacs users group)
       •Applications: https://graph.funtown.com/2439131959 (the Graffiti app)
       •Status messages: https://graph.funtown.com/367501354973 (A status message from Bret)
       •Photos: https://graph.funtown.com/98423808305 (A photo from the Coca-Cola page)
       •Photo albums: https://graph.funtown.com/99394368305 (Coca-Cola's wall photos)
       •Profile pictures: http://graph.funtown.com/jimizim/picture (your profile picture)
       •Videos: https://graph.funtown.com/614004947048 (A Funtown tech talk on Tornado)
       •Notes: https://graph.funtown.com/122788341354 (Note announcing Funtown for iPhone 3.0)

        */

    public class GraphReadTests
    {

        private FuntownClient app;
        public GraphReadTests()
        {
            app = new FuntownClient();
            app.AccessToken = ConfigurationManager.AppSettings["AccessToken"];
        }

        [Fact]
        public void Read_Likes()
        {
            dynamic likesResult = app.Get("/totten/likes");
            dynamic likesData = likesResult.data;
            Assert.NotNull(likesData);

            dynamic total = likesData.Count;
            Assert.NotEqual(0, total);

            var firstLikePageName = likesData[0].name;
            Assert.NotEqual(String.Empty, firstLikePageName);
        }

        [Fact]
        public void Read_Public_Fan_Page_Id()
        {
            dynamic pageResult = app.Get("/outback");
            Assert.Equal(pageResult.id, "48543634386");
        }

        [Fact]
        public void Read_User_Info()
        {
            dynamic result = app.Get("/me");
            Assert.Equal(result.name, "Nathan Tester");
        }

        [Fact]
        public void Read_Application_Info()
        {
            dynamic result = app.Get("/2439131959");
            Assert.Equal(result.category, "Just For Fun");
        }

        [Fact]
        public void Read_Photo_Info()
        {
            dynamic result = app.Get("/98423808305");
            Assert.Equal(result.from.name, "Coca-Cola");
        }

        [Fact]
        public void Read_Event()
        {
            dynamic result = app.Get("/331218348435");
            Assert.Equal(result.venue.city, "Austin");
        }

        [Fact]
        public void ReadPublicProfile()
        {
            dynamic result = app.Get("/totten");
            Assert.Equal("Nathan", result.first_name);
        }

        [Fact]
        public void get_user_likes_should_throw_oauth()
        {
            dynamic parameters = new ExpandoObject();
            parameters.access_token = "invalidtoken";

            Assert.Throws<FuntownOAuthException>(
                () =>
                    {
                        dynamic result = app.Get("/totten/likes", parameters);
                    });
        }
    }
}
