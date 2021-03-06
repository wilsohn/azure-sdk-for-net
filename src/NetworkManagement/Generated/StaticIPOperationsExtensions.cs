// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Management.Network;
using Microsoft.WindowsAzure.Management.Network.Models;

namespace Microsoft.WindowsAzure
{
    /// <summary>
    /// The Service Management API includes operations for managing the virtual
    /// networks your subscription.  (see
    /// http://msdn.microsoft.com/en-us/library/windowsazure/jj157182.aspx for
    /// more information)
    /// </summary>
    public static partial class StaticIPOperationsExtensions
    {
        /// <summary>
        /// The Check Static IP operation retrieves the details for the
        /// availability of static IP addresses for the given virtual network.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Network.IStaticIPOperations.
        /// </param>
        /// <param name='virtualNetworkName'>
        /// The name of the virtual network.
        /// </param>
        /// <param name='ipAddress'>
        /// The address of the static IP.
        /// </param>
        /// <returns>
        /// A response that indicates the availability of a static IP address,
        /// and if not, provide a list of suggestions.
        /// </returns>
        public static NetworkStaticIPAvailabilityResponse Check(this IStaticIPOperations operations, string virtualNetworkName, string ipAddress)
        {
            try
            {
                return operations.CheckAsync(virtualNetworkName, ipAddress).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// The Check Static IP operation retrieves the details for the
        /// availability of static IP addresses for the given virtual network.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Network.IStaticIPOperations.
        /// </param>
        /// <param name='virtualNetworkName'>
        /// The name of the virtual network.
        /// </param>
        /// <param name='ipAddress'>
        /// The address of the static IP.
        /// </param>
        /// <returns>
        /// A response that indicates the availability of a static IP address,
        /// and if not, provide a list of suggestions.
        /// </returns>
        public static Task<NetworkStaticIPAvailabilityResponse> CheckAsync(this IStaticIPOperations operations, string virtualNetworkName, string ipAddress)
        {
            return operations.CheckAsync(virtualNetworkName, ipAddress, CancellationToken.None);
        }
    }
}
