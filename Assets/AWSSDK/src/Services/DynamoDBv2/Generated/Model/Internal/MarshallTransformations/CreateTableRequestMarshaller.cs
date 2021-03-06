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

/*
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DynamoDBv2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DynamoDBv2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateTable Request Marshaller
    /// </summary>       
    public class CreateTableRequestMarshaller : IMarshaller<IRequest, CreateTableRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateTableRequest)input);
        }

        public IRequest Marshall(CreateTableRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DynamoDBv2");
            string target = "DynamoDB_20120810.CreateTable";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAttributeDefinitions())
                {
                    context.Writer.WritePropertyName("AttributeDefinitions");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAttributeDefinitionsListValue in publicRequest.AttributeDefinitions)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = AttributeDefinitionMarshaller.Instance;
                        marshaller.Marshall(publicRequestAttributeDefinitionsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetGlobalSecondaryIndexes())
                {
                    context.Writer.WritePropertyName("GlobalSecondaryIndexes");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestGlobalSecondaryIndexesListValue in publicRequest.GlobalSecondaryIndexes)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = GlobalSecondaryIndexMarshaller.Instance;
                        marshaller.Marshall(publicRequestGlobalSecondaryIndexesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetKeySchema())
                {
                    context.Writer.WritePropertyName("KeySchema");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestKeySchemaListValue in publicRequest.KeySchema)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = KeySchemaElementMarshaller.Instance;
                        marshaller.Marshall(publicRequestKeySchemaListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetLocalSecondaryIndexes())
                {
                    context.Writer.WritePropertyName("LocalSecondaryIndexes");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestLocalSecondaryIndexesListValue in publicRequest.LocalSecondaryIndexes)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = LocalSecondaryIndexMarshaller.Instance;
                        marshaller.Marshall(publicRequestLocalSecondaryIndexesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetProvisionedThroughput())
                {
                    context.Writer.WritePropertyName("ProvisionedThroughput");
                    context.Writer.WriteObjectStart();

                    var marshaller = ProvisionedThroughputMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ProvisionedThroughput, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTableName())
                {
                    context.Writer.WritePropertyName("TableName");
                    context.Writer.Write(publicRequest.TableName);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }


    }
}