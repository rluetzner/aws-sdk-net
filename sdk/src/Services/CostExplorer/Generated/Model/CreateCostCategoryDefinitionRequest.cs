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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCostCategoryDefinition operation.
    /// <important> 
    /// <para>
    ///  <i> <b>Cost Category is in public beta for AWS Billing and Cost Management and is
    /// subject to change. Your use of Cost Categories is subject to the Beta Service Participation
    /// terms of the <a href="https://aws.amazon.com/service-terms/">AWS Service Terms</a>
    /// (Section 1.10).</b> </i> 
    /// </para>
    ///  </important> 
    /// <para>
    /// Creates a new Cost Category with the requested name and rules.
    /// </para>
    /// </summary>
    public partial class CreateCostCategoryDefinitionRequest : AmazonCostExplorerRequest
    {
        private string _name;
        private List<CostCategoryRule> _rules = new List<CostCategoryRule>();
        private CostCategoryRuleVersion _ruleVersion;

        /// <summary>
        /// Gets and sets the property Name.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Rules. 
        /// <para>
        ///  <code>CreateCostCategoryDefinition</code> supports dimensions, Tags, and nested expressions.
        /// Currently the only dimensions supported is <code>LINKED_ACCOUNT</code>.
        /// </para>
        ///  
        /// <para>
        /// Root level <code>OR</code> is not supported. We recommend you create a separate rule
        /// instead.
        /// </para>
        ///  
        /// <para>
        /// Rules are processed in order. If there are multiple rules that match the line item,
        /// then the first rule to match is used to determine that Cost Category value. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=500)]
        public List<CostCategoryRule> Rules
        {
            get { return this._rules; }
            set { this._rules = value; }
        }

        // Check to see if Rules property is set
        internal bool IsSetRules()
        {
            return this._rules != null && this._rules.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RuleVersion.
        /// </summary>
        [AWSProperty(Required=true)]
        public CostCategoryRuleVersion RuleVersion
        {
            get { return this._ruleVersion; }
            set { this._ruleVersion = value; }
        }

        // Check to see if RuleVersion property is set
        internal bool IsSetRuleVersion()
        {
            return this._ruleVersion != null;
        }

    }
}