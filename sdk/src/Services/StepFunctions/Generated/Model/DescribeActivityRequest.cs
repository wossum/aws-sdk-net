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

/*
 * Do not modify this file. This file is generated from the states-2016-11-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.StepFunctions.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeActivity operation.
    /// Describes an activity.
    /// </summary>
    public partial class DescribeActivityRequest : AmazonStepFunctionsRequest
    {
        private string _activityArn;

        /// <summary>
        /// Gets and sets the property ActivityArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the activity to describe.
        /// </para>
        /// </summary>
        public string ActivityArn
        {
            get { return this._activityArn; }
            set { this._activityArn = value; }
        }

        // Check to see if ActivityArn property is set
        internal bool IsSetActivityArn()
        {
            return this._activityArn != null;
        }

    }
}