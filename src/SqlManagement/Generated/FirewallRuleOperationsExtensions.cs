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
using System.Threading;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Management.Sql;
using Microsoft.WindowsAzure.Management.Sql.Models;

namespace Microsoft.WindowsAzure.Management.Sql
{
    /// <summary>
    /// The Windows Azure SQL Database Management API includes operations for
    /// managing the server-level firewall rules for SQL Database servers.You
    /// cannot manage the database-level firewall rules using the Windows
    /// Azure SQL Database Management API; they can only be managed by running
    /// the  Transact-SQL statements against the master or individual user
    /// databases.  (see
    /// http://msdn.microsoft.com/en-us/library/windowsazure/gg715276.aspx for
    /// more information)
    /// </summary>
    public static partial class FirewallRuleOperationsExtensions
    {
        /// <summary>
        /// The Set Server Firewall Rule operation updates an existing
        /// server-level firewall rule or adds a new server-level firewall
        /// rule for a SQL Database server that belongs to a subscription.
        /// (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/gg715280.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Sql.IFirewallRuleOperations.
        /// </param>
        /// <param name='serverName'>
        /// The name of the SQL database server to which this rule will be
        /// applied.
        /// </param>
        /// <param name='parameters'>
        /// Parameters for the Create Firewall Rule operation
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static FirewallRuleCreateResponse Create(this IFirewallRuleOperations operations, string serverName, FirewallRuleCreateParameters parameters)
        {
            try
            {
                return operations.CreateAsync(serverName, parameters).Result;
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
        /// The Set Server Firewall Rule operation updates an existing
        /// server-level firewall rule or adds a new server-level firewall
        /// rule for a SQL Database server that belongs to a subscription.
        /// (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/gg715280.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Sql.IFirewallRuleOperations.
        /// </param>
        /// <param name='serverName'>
        /// The name of the SQL database server to which this rule will be
        /// applied.
        /// </param>
        /// <param name='parameters'>
        /// Parameters for the Create Firewall Rule operation
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<FirewallRuleCreateResponse> CreateAsync(this IFirewallRuleOperations operations, string serverName, FirewallRuleCreateParameters parameters)
        {
            return operations.CreateAsync(serverName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// The Delete Server Firewall Rule operation deletes a server-level
        /// firewall rule from a SQL Database server that belongs to a
        /// subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/gg715277.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Sql.IFirewallRuleOperations.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server that will be have new firewall rule applied
        /// to it
        /// </param>
        /// <param name='ruleName'>
        /// The name of the new firewall rule
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static OperationResponse Delete(this IFirewallRuleOperations operations, string serverName, string ruleName)
        {
            try
            {
                return operations.DeleteAsync(serverName, ruleName).Result;
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
        /// The Delete Server Firewall Rule operation deletes a server-level
        /// firewall rule from a SQL Database server that belongs to a
        /// subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/gg715277.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Sql.IFirewallRuleOperations.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server that will be have new firewall rule applied
        /// to it
        /// </param>
        /// <param name='ruleName'>
        /// The name of the new firewall rule
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<OperationResponse> DeleteAsync(this IFirewallRuleOperations operations, string serverName, string ruleName)
        {
            return operations.DeleteAsync(serverName, ruleName, CancellationToken.None);
        }
        
        /// <summary>
        /// The Get Server Firewall Rules operation retrieves a list of all the
        /// server-level firewall rules for a SQL Database server that belongs
        /// to a subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/gg715278.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Sql.IFirewallRuleOperations.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server for which the call is being made
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static FirewallRuleListResponse List(this IFirewallRuleOperations operations, string serverName)
        {
            try
            {
                return operations.ListAsync(serverName).Result;
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
        /// The Get Server Firewall Rules operation retrieves a list of all the
        /// server-level firewall rules for a SQL Database server that belongs
        /// to a subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/gg715278.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Sql.IFirewallRuleOperations.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server for which the call is being made
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<FirewallRuleListResponse> ListAsync(this IFirewallRuleOperations operations, string serverName)
        {
            return operations.ListAsync(serverName, CancellationToken.None);
        }
        
        /// <summary>
        /// The Set Server Firewall Rule operation updates an existing
        /// server-level firewall rule or adds a new server-level firewall
        /// rule for a SQL Database server that belongs to a subscription.
        /// (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/gg715280.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Sql.IFirewallRuleOperations.
        /// </param>
        /// <param name='serverName'>
        /// The name of the SQL database server to which this rule will be
        /// applied.
        /// </param>
        /// <param name='ruleName'>
        /// The name of the firewall rule to be updated.
        /// </param>
        /// <param name='parameters'>
        /// Parameters for the Update Firewall Rule operation
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static FirewallRuleUpdateResponse Update(this IFirewallRuleOperations operations, string serverName, string ruleName, FirewallRuleUpdateParameters parameters)
        {
            try
            {
                return operations.UpdateAsync(serverName, ruleName, parameters).Result;
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
        /// The Set Server Firewall Rule operation updates an existing
        /// server-level firewall rule or adds a new server-level firewall
        /// rule for a SQL Database server that belongs to a subscription.
        /// (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/gg715280.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Sql.IFirewallRuleOperations.
        /// </param>
        /// <param name='serverName'>
        /// The name of the SQL database server to which this rule will be
        /// applied.
        /// </param>
        /// <param name='ruleName'>
        /// The name of the firewall rule to be updated.
        /// </param>
        /// <param name='parameters'>
        /// Parameters for the Update Firewall Rule operation
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<FirewallRuleUpdateResponse> UpdateAsync(this IFirewallRuleOperations operations, string serverName, string ruleName, FirewallRuleUpdateParameters parameters)
        {
            return operations.UpdateAsync(serverName, ruleName, parameters, CancellationToken.None);
        }
    }
}