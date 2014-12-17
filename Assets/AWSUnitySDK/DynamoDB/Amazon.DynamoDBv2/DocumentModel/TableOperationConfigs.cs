﻿/*
 * Copyright 2014-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *
 *
 * Licensed under the AWS Mobile SDK for Unity Developer Preview License Agreement (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located in the "license" file accompanying this file.
 * See the License for the specific language governing permissions and limitations under the License.
 *
 */

using System;
using System.Collections.Generic;

using Amazon.DynamoDBv2.Model;

namespace Amazon.DynamoDBv2.DocumentModel
{
    /// <summary>
    /// Configuration for the Table.PutItem operation
    /// </summary>
    public class PutItemOperationConfig
    {
        /// <summary>
        /// The expected state of data in DynamoDB.
        /// Note: setting both Expected and ExpectedState is not supported and
        /// will result in an exception being thrown.
        /// 
        /// For the operation to succeed, the data in DynamoDB must match the conditions
        /// specified in the ExpectedState.
        /// </summary>
        public ExpectedState ExpectedState { get; set; }

        /// <summary>
        /// Document representing the expected state of data in DynamoDB.
        /// Note: setting both Expected and ExpectedState is not supported and
        /// will result in an exception being thrown.
        /// 
        /// For the operation to succeed, the data in DynamoDB must be equal
        /// to the attributes in Expected. If an attribute in Expected
        /// is set to null, that attribute must not be preset on the item in DynamoDB.
        /// </summary>
        public Document Expected { get; set; }

        /// <summary>
        /// Flag specifying what values should be returned.
        /// 
        /// PutItem only supports ReturnValues.AllOldAttributes and ReturnValues.None
        /// </summary>
        public ReturnValues ReturnValues { get; set; }
    }

    /// <summary>
    /// Configuration for the Table.GetItem operation
    /// </summary>
    public class GetItemOperationConfig
    {
        /// <summary>
        /// List of attributes to retrieve
        /// </summary>
        public List<string> AttributesToGet { get; set; }

        /// <summary>
        /// If set to true, this flag ensures that the most recently written data is
        /// returned.
        /// </summary>
        public bool ConsistentRead { get; set; }
    }

    /// <summary>
    /// Configuration for the Table.UpdateItem operation
    /// </summary>
    public class UpdateItemOperationConfig
    {
        /// <summary>
        /// The expected state of data in DynamoDB.
        /// Note: setting both Expected and ExpectedState is not supported and
        /// will result in an exception being thrown.
        /// 
        /// For the operation to succeed, the data in DynamoDB must match the conditions
        /// specified in the ExpectedState.
        /// </summary>
        public ExpectedState ExpectedState { get; set; }

        /// <summary>
        /// Document representing the expected state of data in DynamoDB.
        /// Note: setting both Expected and ExpectedState is not supported and
        /// will result in an exception being thrown.
        /// 
        /// For the operation to succeed, the data in DynamoDB must be equal
        /// to the attributes in Expected. If an attribute in Expected
        /// is set to null, that attribute must not be preset on the item in DynamoDB.
        /// </summary>
        public Document Expected { get; set; }

        /// <summary>
        /// Flag specifying what values should be returned.
        /// </summary>
        public ReturnValues ReturnValues { get; set; }
    }

    /// <summary>
    /// Configuration for the Table.DeleteItem operation
    /// </summary>
    public class DeleteItemOperationConfig
    {
        /// <summary>
        /// The expected state of data in DynamoDB.
        /// Note: setting both Expected and ExpectedState is not supported and
        /// will result in an exception being thrown.
        /// 
        /// For the operation to succeed, the data in DynamoDB must match the conditions
        /// specified in the ExpectedState.
        /// </summary>
        public ExpectedState ExpectedState { get; set; }

        /// <summary>
        /// Document representing the expected state of data in DynamoDB.
        /// Note: setting both Expected and ExpectedState is not supported and
        /// will result in an exception being thrown.
        /// 
        /// For the operation to succeed, the data in DynamoDB must be equal
        /// to the attributes in Expected. If an attribute in Expected
        /// is set to null, that attribute must not be preset on the item in DynamoDB.
        /// </summary>
        public Document Expected { get; set; }

        /// <summary>
        /// Flag specifying what values should be returned.
        /// 
        /// DeleteItem only supports ReturnValues.AllOldAttributes and ReturnValues.None
        /// </summary>
        public ReturnValues ReturnValues { get; set; }
    }

    /// <summary>
    /// Configuration for the Table.Scan operation
    /// </summary>
    public class ScanOperationConfig
    {
        /// <summary>
        /// Initializes a default Table.Scan config object
        /// Filter is empty, Limit is Int32.MaxValue
        /// </summary>
        public ScanOperationConfig()
        {
            Filter = new ScanFilter();
            Limit = Int32.MaxValue;
            Select = SelectValues.AllAttributes;
            ConditionalOperator = ConditionalOperatorValues.And;
        }

        /// <summary>
        /// List of attributes to retrieve as part of the search
        /// </summary>
        public List<string> AttributesToGet { get; set; }

        /// <summary>
        /// Upper limit on the number of items scanned per request
        /// for matching conditions.
        /// </summary>
        public int Limit { get; set; }

        /// <summary>
        /// Filter for the search operation
        /// </summary>
        public ScanFilter Filter { get; set; }

        /// <summary>
        /// Enum specifying what data to return from query.
        /// </summary>
        public SelectValues Select { get; set; }

        /// <summary>
        /// For parallel <i>Scan</i> requests, <i>TotalSegments</i>represents the total number of segments for a table that is being scanned. Segments
        /// are a way to logically divide a table into equally sized portions, for the duration of the <i>Scan</i> request. The value of
        /// <i>TotalSegments</i> corresponds to the number of application "workers" (such as threads or processes) that will perform the parallel
        /// <i>Scan</i>. For example, if you want to scan a table using four application threads, you would specify a <i>TotalSegments</i> value of 4.
        /// The value for <i>TotalSegments</i> must be greater than or equal to 1, and less than or equal to 4096. If you specify a <i>TotalSegments</i>
        /// value of 1, the <i>Scan</i> will be sequential rather than parallel. If you specify <i>TotalSegments</i>, you must also specify
        /// <i>Segment</i>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>1 - 4096</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int TotalSegments { get; set; }

        /// <summary>
        /// For parallel <i>Scan</i> requests, <i>Segment</i> identifies an individual segment to be scanned by an application "worker" (such as a
        /// thread or a process). Each worker issues a <i>Scan</i> request with a distinct value for the segment it will scan. Segment IDs are
        /// zero-based, so the first segment is always 0. For example, if you want to scan a table using four application threads, the first thread
        /// would specify a <i>Segment</i> value of 0, the second thread would specify 1, and so on. LastEvaluatedKey returned from a parallel scan
        /// request must be used with same Segment id in a subsequent operation. The value for <i>Segment</i> must be less than or equal to 0, and less
        /// than the value provided for <i>TotalSegments</i>. If you specify <i>Segment</i>, you must also specify <i>TotalSegments</i>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>0 - 4095</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int Segment { get; set; }

        /// <summary>
        /// Whether to collect GetNextSet and GetRemaining results in Matches property.
        /// Default is true. If set to false, Matches will always be empty.
        /// </summary>
        public bool CollectResults { get; set; }

        /// <summary>
        /// A logical operator to apply to the conditions in the Filter property:
        /// AND - If all of the conditions evaluate to true, then the entire filter evaluates to true.
        /// OR - If at least one of the conditions evaluate to true, then the entire filter evaluates to true.
        /// 
        /// Default value is AND.
        /// </summary>
        public ConditionalOperatorValues ConditionalOperator { get; set; }
    }

    /// <summary>
    /// Configuration for the Table.Query operation
    /// </summary>
    public class QueryOperationConfig
    {
        /// <summary>
        /// Initializes a default Table.Query config object
        /// Filter is empty, Limit is Int32.MaxValue
        /// </summary>
        public QueryOperationConfig()
        {
            Filter = new QueryFilter();
            Limit = Int32.MaxValue;
            Select = SelectValues.AllAttributes;
        }

        /// <summary>
        /// Filter for the search operation
        /// </summary>
        public QueryFilter Filter { get; set; }

        /// <summary>
        /// If set to true, this flag ensures that the most recently written data is
        /// returned.
        /// </summary>
        public bool ConsistentRead { get; set; }

        /// <summary>
        /// List of attributes to retrieve as part of the search
        /// </summary>
        public List<string> AttributesToGet { get; set; }

        /// <summary>
        /// Upper limit on the number of items to return per request
        /// </summary>
        public int Limit { get; set; }

        /// <summary>
        /// Flag that signals if the search is traversing backwards
        /// </summary>
        public bool BackwardSearch { get; set; }

        /// <summary>
        /// Name of the index to query against.
        /// </summary>
        public string IndexName { get; set; }

        /// <summary>
        /// Enum specifying what data to return from query.
        /// </summary>
        public SelectValues Select { get; set; }

        /// <summary>
        /// Whether to collect GetNextSet and GetRemaining results in Matches property.
        /// Default is true. If set to false, Matches will always be empty.
        /// </summary>
        public bool CollectResults { get; set; }

        /// <summary>
        /// A logical operator to apply to the conditions in the Filter property:
        /// AND - If all of the conditions evaluate to true, then the entire filter evaluates to true.
        /// OR - If at least one of the conditions evaluate to true, then the entire filter evaluates to true.
        /// 
        /// Default value is AND.
        /// </summary>
        public ConditionalOperatorValues ConditionalOperator { get; set; }
    }
}