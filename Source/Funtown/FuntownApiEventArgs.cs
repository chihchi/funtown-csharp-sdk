﻿//-----------------------------------------------------------------------
// <copyright file="FuntownApiEventArgs.cs" company="The Outercurve Foundation">
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

namespace Funtown
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Represents the Funtown api event args.
    /// </summary>
    public class FuntownApiEventArgs : AsyncCompletedEventArgs
    {
        /// <summary>
        /// The result.
        /// </summary>
        private readonly object _result;

        /// <summary>
        /// Initializes a new instance of the <see cref="FuntownApiEventArgs"/> class.
        /// </summary>
        /// <param name="error">
        /// The error.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        /// <param name="result">
        /// The result.
        /// </param>
        public FuntownApiEventArgs(Exception error, bool cancelled, object userState, object result)
            : base(error, cancelled, userState)
        {
            _result = result;
        }

        /// <summary>
        /// Get the json result.
        /// </summary>
        /// <returns>
        /// The json result.
        /// </returns>
        [SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
        public object GetResultData()
        {
            RaiseExceptionIfNecessary();
            return _result;
        }
    }
}
