﻿//-----------------------------------------------------------------------
// <copyright file="GlobalSuppressions.cs" company="The Outercurve Foundation">
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

// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the 
// Error List, point to "Suppress Message(s)", and click 
// "In Project Suppression File".
// You do not need to add suppressions to this file manually.
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Funtown.IFuntownSettings.#CanvasPageUrlPath")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "IDictionary", Scope = "member", Target = "Funtown.FuntownApp.#OauthRequest(System.Uri,System.Object,Funtown.HttpMethod)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "IDictionary", Scope = "member", Target = "Funtown.FuntownApp.#OauthRequestAsync(Funtown.FuntownAsyncCallback,System.Object,System.Uri,System.Object,Funtown.HttpMethod)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "IDictionary", Scope = "member", Target = "Funtown.FuntownApp.#OAuthRequest(System.Uri,System.Object,Funtown.HttpMethod)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "IDictionary", Scope = "member", Target = "Funtown.FuntownApp.#OAuthRequestAsync(Funtown.FuntownAsyncCallback,System.Object,System.Uri,System.Object,Funtown.HttpMethod)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "signedRequest", Scope = "member", Target = "Funtown.FuntownSession.#.ctor(Funtown.FuntownSignedRequest)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "appSecret", Scope = "member", Target = "Funtown.FuntownSession.#Validate(System.Collections.Generic.Dictionary`2<System.String,System.String>,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "apiSecret", Scope = "member", Target = "Funtown.FuntownSession.#.ctor(System.String,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "JsonWriter", Scope = "member", Target = "Funtown.JsonWriter.#Json")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "TextWriter", Scope = "member", Target = "Funtown.JsonWriter.#Json")]
