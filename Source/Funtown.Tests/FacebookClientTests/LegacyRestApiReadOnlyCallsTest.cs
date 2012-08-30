//-----------------------------------------------------------------------
// <copyright file="LegacyRestApiReadOnlyCallsTest.cs" company="The Outercurve Foundation">
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

namespace Funtown.Tests.FuntownClient
{
    using System.Linq;
    using Funtown;
    using Xunit;

    public class LegacyRestApiReadOnlyCallsTest
    {
        [Fact]
        public void LengthIs60()
        {
            var result = FuntownClient.LegacyRestApiReadOnlyCalls.Length;

            Assert.Equal(60, result);
        }

        [Fact]
        public void ContainsAdminGetAllocation()
        {
            var result = FuntownClient.LegacyRestApiReadOnlyCalls.Contains("admin.getallocation");

            Assert.True(result);
        }

        [Fact]
        public void ContainsAdminGetAppProperties()
        {
            var result = FuntownClient.LegacyRestApiReadOnlyCalls.Contains("admin.getappproperties");

            Assert.True(result);
        }

        [Fact]
        public void ContainsAdminGetBannedUsers()
        {
            var result = FuntownClient.LegacyRestApiReadOnlyCalls.Contains("admin.getbannedusers");

            Assert.True(result);
        }

        [Fact]
        public void ContainsAdminGetLiveStreamViaLink()
        {
            var result = FuntownClient.LegacyRestApiReadOnlyCalls.Contains("admin.getlivestreamvialink");

            Assert.True(result);
        }

        [Fact]
        public void ContainsAdminGetMetrics()
        {
            var result = FuntownClient.LegacyRestApiReadOnlyCalls.Contains("admin.getmetrics");

            Assert.True(result);
        }

        [Fact]
        public void ContainsAdminGetRestrictionInfo()
        {
            var result = FuntownClient.LegacyRestApiReadOnlyCalls.Contains("admin.getrestrictioninfo");

            Assert.True(result);
        }

        [Fact]
        public void ContainsApplicationGetPublicInfo()
        {
            var result = FuntownClient.LegacyRestApiReadOnlyCalls.Contains("application.getpublicinfo");

            Assert.True(result);
        }

        [Fact]
        public void ContainsAuthGetPublicKey()
        {
            var result = FuntownClient.LegacyRestApiReadOnlyCalls.Contains("auth.getapppublickey");

            Assert.True(result);
        }

        [Fact]
        public void ContainsAuthGetSession()
        {
            var result = FuntownClient.LegacyRestApiReadOnlyCalls.Contains("auth.getsession");

            Assert.True(result);
        }

        [Fact]
        public void ContainsAuthGetSignedPublicSessionData()
        {
            var result = FuntownClient.LegacyRestApiReadOnlyCalls.Contains("auth.getsignedpublicsessiondata");

            Assert.True(result);
        }

        [Fact]
        public void ContainsCommentsGet()
        {
            var result = FuntownClient.LegacyRestApiReadOnlyCalls.Contains("comments.get");

            Assert.True(result);
        }

        [Fact]
        public void ContainsGetUnconnectedFriendsCount()
        {
            var result = FuntownClient.LegacyRestApiReadOnlyCalls.Contains("connect.getunconnectedfriendscount");

            Assert.True(result);
        }

        [Fact]
        public void ContainsDashboardGetActivity()
        {
            var result = FuntownClient.LegacyRestApiReadOnlyCalls.Contains("dashboard.getactivity");

            Assert.True(result);
        }

        [Fact]
        public void ContainsDashboardGetCount()
        {
            var result = FuntownClient.LegacyRestApiReadOnlyCalls.Contains("dashboard.getcount");

            Assert.True(result);
        }

        [Fact]
        public void ContainsDashboardGetGlobalNews()
        {
            var result = FuntownClient.LegacyRestApiReadOnlyCalls.Contains("dashboard.getglobalnews");

            Assert.True(result);
        }

        [Fact]
        public void ContainsDashboardGetNews()
        {
            var result = FuntownClient.LegacyRestApiReadOnlyCalls.Contains("dashboard.getnews");

            Assert.True(result);
        }

        [Fact]
        public void ContainsDashboardMultiGetCount()
        {
            var result = FuntownClient.LegacyRestApiReadOnlyCalls.Contains("dashboard.multigetcount");

            Assert.True(result);
        }

        [Fact]
        public void ContainsDashboardMultiGetNews()
        {
            var result = FuntownClient.LegacyRestApiReadOnlyCalls.Contains("dashboard.multigetnews");

            Assert.True(result);
        }

        [Fact]
        public void ContainsDataGetCookies()
        {
            var result = FuntownClient.LegacyRestApiReadOnlyCalls.Contains("data.getcookies");

            Assert.True(result);
        }

        [Fact]
        public void ContainsEventsGet()
        {
            var result = FuntownClient.LegacyRestApiReadOnlyCalls.Contains("events.get");

            Assert.True(result);
        }

        [Fact]
        public void ContainsEventsGetMembers()
        {
            var result = FuntownClient.LegacyRestApiReadOnlyCalls.Contains("events.getmembers");

            Assert.True(result);
        }

        [Fact]
        public void ContainsFbmlGetCustomTags()
        {
            var result = FuntownClient.LegacyRestApiReadOnlyCalls.Contains("fbml.getcustomtags");

            Assert.True(result);
        }

        [Fact]
        public void ContainsFeedGetAppFirendStories()
        {
            var result = FuntownClient.LegacyRestApiReadOnlyCalls.Contains("feed.getappfriendstories");

            Assert.True(result);
        }

        [Fact]
        public void ContainsFeedGetrEgisteredTemplateBundleById()
        {
            var result = FuntownClient.LegacyRestApiReadOnlyCalls.Contains("feed.getregisteredtemplatebundlebyid");

            Assert.True(result);
        }

        [Fact]
        public void ContainsFeedGetrEgisteredTemplateBundles()
        {
            var result = FuntownClient.LegacyRestApiReadOnlyCalls.Contains("feed.getregisteredtemplatebundles");

            Assert.True(result);
        }

        [Fact]
        public void ContainsFqlMultiQuery()
        {
            var result = FuntownClient.LegacyRestApiReadOnlyCalls.Contains("fql.multiquery");

            Assert.True(result);
        }

        [Fact]
        public void ContainsFqlQuery()
        {
            var result = FuntownClient.LegacyRestApiReadOnlyCalls.Contains("fql.query");

            Assert.True(result);
        }

        [Fact]
        public void ContainsFriendsAreFriends()
        {
            var result = FuntownClient.LegacyRestApiReadOnlyCalls.Contains("friends.arefriends");

            Assert.True(result);
        }

        [Fact]
        public void ContainsFriendsGet()
        {
            var result = FuntownClient.LegacyRestApiReadOnlyCalls.Contains("friends.get");

            Assert.True(result);
        }

        [Fact]
        public void ContainsFriendsGetApUsers()
        {
            var result = FuntownClient.LegacyRestApiReadOnlyCalls.Contains("friends.getappusers");

            Assert.True(result);
        }

        [Fact]
        public void ContainsFriendsGetLists()
        {
            var result = FuntownClient.LegacyRestApiReadOnlyCalls.Contains("friends.getlists");

            Assert.True(result);
        }

        [Fact]
        public void ContainsFriendsGetMultualFriends()
        {
            var result = FuntownClient.LegacyRestApiReadOnlyCalls.Contains("friends.getmutualfriends");

            Assert.True(result);
        }

        [Fact]
        public void ContainsGiftsGet()
        {
            var result = FuntownClient.LegacyRestApiReadOnlyCalls.Contains("gifts.get");

            Assert.True(result);
        }

        [Fact]
        public void ContainsGroupsGet()
        {
            var result = FuntownClient.LegacyRestApiReadOnlyCalls.Contains("groups.get");

            Assert.True(result);
        }

        [Fact]
        public void ContainsGroupsGetMembers()
        {
            var result = FuntownClient.LegacyRestApiReadOnlyCalls.Contains("groups.getmembers");

            Assert.True(result);
        }

        [Fact]
        public void ContainsIntlGetTranslations()
        {
            var result = FuntownClient.LegacyRestApiReadOnlyCalls.Contains("intl.gettranslations");

            Assert.True(result);
        }

        [Fact]
        public void ContainsLinksGet()
        {
            var result = FuntownClient.LegacyRestApiReadOnlyCalls.Contains("links.get");

            Assert.True(result);
        }

        [Fact]
        public void ContainsNotesGet()
        {
            var result = FuntownClient.LegacyRestApiReadOnlyCalls.Contains("notes.get");

            Assert.True(result);
        }

        [Fact]
        public void ContainsNotificationsGet()
        {
            var result = FuntownClient.LegacyRestApiReadOnlyCalls.Contains("notifications.get");

            Assert.True(result);
        }

        [Fact]
        public void ContainsPagesGetInfo()
        {
            var result = FuntownClient.LegacyRestApiReadOnlyCalls.Contains("pages.getinfo");

            Assert.True(result);
        }

        [Fact]
        public void ContainsPagesIsAdmin()
        {
            var result = FuntownClient.LegacyRestApiReadOnlyCalls.Contains("pages.isadmin");

            Assert.True(result);
        }

        [Fact]
        public void ContainsPagesIsAppAdded()
        {
            var result = FuntownClient.LegacyRestApiReadOnlyCalls.Contains("pages.isappadded");

            Assert.True(result);
        }

        [Fact]
        public void ContainsPagesIsFan()
        {
            var result = FuntownClient.LegacyRestApiReadOnlyCalls.Contains("pages.isfan");

            Assert.True(result);
        }

        [Fact]
        public void ContainsPermissionsCheckAvailableApiAccess()
        {
            var result = FuntownClient.LegacyRestApiReadOnlyCalls.Contains("permissions.checkavailableapiaccess");

            Assert.True(result);
        }

        [Fact]
        public void ContainsPermissionsCheckGrantedApiAccess()
        {
            var result = FuntownClient.LegacyRestApiReadOnlyCalls.Contains("permissions.checkgrantedapiaccess");

            Assert.True(result);
        }

        [Fact]
        public void ContainsPhotosGet()
        {
            var result = FuntownClient.LegacyRestApiReadOnlyCalls.Contains("photos.get");

            Assert.True(result);
        }

        [Fact]
        public void ContainsPhotosGetAlbums()
        {
            var result = FuntownClient.LegacyRestApiReadOnlyCalls.Contains("photos.getalbums");

            Assert.True(result);
        }

        [Fact]
        public void ContainsPhotosGetTags()
        {
            var result = FuntownClient.LegacyRestApiReadOnlyCalls.Contains("photos.gettags");

            Assert.True(result);
        }

        [Fact]
        public void ContainsProfileGetInfo()
        {
            var result = FuntownClient.LegacyRestApiReadOnlyCalls.Contains("profile.getinfo");

            Assert.True(result);
        }

        [Fact]
        public void ContainsProfileGetInfoOptions()
        {
            var result = FuntownClient.LegacyRestApiReadOnlyCalls.Contains("profile.getinfooptions");

            Assert.True(result);
        }

        [Fact]
        public void ContainsStreamGet()
        {
            var result = FuntownClient.LegacyRestApiReadOnlyCalls.Contains("stream.get");

            Assert.True(result);
        }

        [Fact]
        public void ContainsStreamGetComments()
        {
            var result = FuntownClient.LegacyRestApiReadOnlyCalls.Contains("stream.getcomments");

            Assert.True(result);
        }

        [Fact]
        public void ContainsStreamGetFilters()
        {
            var result = FuntownClient.LegacyRestApiReadOnlyCalls.Contains("stream.getfilters");

            Assert.True(result);
        }

        [Fact]
        public void ContainsUsersGetInfo()
        {
            var result = FuntownClient.LegacyRestApiReadOnlyCalls.Contains("users.getinfo");

            Assert.True(result);
        }

        [Fact]
        public void ContainsUsersGetLoggedInUser()
        {
            var result = FuntownClient.LegacyRestApiReadOnlyCalls.Contains("users.getloggedinuser");

            Assert.True(result);
        }

        [Fact]
        public void ContainsUsersGetStandardInfo()
        {
            var result = FuntownClient.LegacyRestApiReadOnlyCalls.Contains("users.getstandardinfo");

            Assert.True(result);
        }

        [Fact]
        public void ContainsUsersHasAppPermission()
        {
            var result = FuntownClient.LegacyRestApiReadOnlyCalls.Contains("users.hasapppermission");

            Assert.True(result);
        }

        [Fact]
        public void ContainsUsersIsAppUser()
        {
            var result = FuntownClient.LegacyRestApiReadOnlyCalls.Contains("users.isappuser");

            Assert.True(result);
        }

        [Fact]
        public void ContainsUsersIsVerified()
        {
            var result = FuntownClient.LegacyRestApiReadOnlyCalls.Contains("users.isverified");

            Assert.True(result);
        }

        [Fact]
        public void ContainsVideGetUploadLimits()
        {
            var result = FuntownClient.LegacyRestApiReadOnlyCalls.Contains("video.getuploadlimits");

            Assert.True(result);
        }
    }
}