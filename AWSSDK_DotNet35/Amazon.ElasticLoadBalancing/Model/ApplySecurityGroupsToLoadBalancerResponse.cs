/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.Runtime;

namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// Returns information about the  ApplySecurityGroupsToLoadBalancer response and response metadata.
    /// </summary>
    public partial class ApplySecurityGroupsToLoadBalancerResponse : ApplySecurityGroupsToLoadBalancerResult
    {
        /// <summary>
        /// Gets and sets the ApplySecurityGroupsToLoadBalancerResult property.
        /// The out for the ApplySecurityGroupsToLoadBalancer action.
        /// </summary>
        [Obsolete(@"This property has been deprecated. All properties of the ApplySecurityGroupsToLoadBalancerResult class are now available on the ApplySecurityGroupsToLoadBalancerResponse class. You should use the properties on ApplySecurityGroupsToLoadBalancerResponse instead of accessing them through ApplySecurityGroupsToLoadBalancerResult.")]
        public ApplySecurityGroupsToLoadBalancerResult ApplySecurityGroupsToLoadBalancerResult
        {
            get
            {
                return this;
            }
        }
    }
}
    
