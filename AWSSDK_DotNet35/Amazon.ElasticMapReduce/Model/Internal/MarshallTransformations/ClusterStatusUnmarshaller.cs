/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    using System.IO;
    using ThirdParty.Json.LitJson;
    using Amazon.ElasticMapReduce.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// ClusterStatusUnmarshaller
      /// </summary>
      internal class ClusterStatusUnmarshaller : IUnmarshaller<ClusterStatus, XmlUnmarshallerContext>, IUnmarshaller<ClusterStatus, JsonUnmarshallerContext>
      {
        ClusterStatus IUnmarshaller<ClusterStatus, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public ClusterStatus Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            ClusterStatus clusterStatus = new ClusterStatus();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("State", targetDepth))
              {
                context.Read();
                clusterStatus.State = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("StateChangeReason", targetDepth))
              {
                context.Read();
                clusterStatus.StateChangeReason = ClusterStateChangeReasonUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Timeline", targetDepth))
              {
                context.Read();
                clusterStatus.Timeline = ClusterTimelineUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return clusterStatus;
                }
            }
          

            return clusterStatus;
        }

        private static ClusterStatusUnmarshaller instance;
        public static ClusterStatusUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new ClusterStatusUnmarshaller();
            return instance;
        }
    }
}
  
