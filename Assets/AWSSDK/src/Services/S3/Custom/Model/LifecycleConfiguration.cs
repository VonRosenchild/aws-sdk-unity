//
// Copyright 2014-2015 Amazon.com, 
// Inc. or its affiliates. All Rights Reserved.
// 
// Licensed under the Amazon Software License (the "License"). 
// You may not use this file except in compliance with the 
// License. A copy of the License is located at
// 
//     http://aws.amazon.com/asl/
// 
// or in the "license" file accompanying this file. This file is 
// distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, express or implied. See the License 
// for the specific language governing permissions and 
// limitations under the License.
//

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.S3.Model
{
    /// <summary>Lifecycle Configuration
    /// </summary>
    public class LifecycleConfiguration
    {
        
        private List<LifecycleRule> rules = new List<LifecycleRule>();
        public List<LifecycleRule> Rules
        {
            get { return this.rules; }
            set { this.rules = value; }
        }

        // Check to see if Rules property is set
        internal bool IsSetRules()
        {
            return this.rules.Count > 0;
        }
    }
}
