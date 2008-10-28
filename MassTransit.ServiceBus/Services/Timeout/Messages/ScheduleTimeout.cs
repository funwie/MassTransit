// Copyright 2007-2008 The Apache Software Foundation.
//  
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use 
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed 
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace MassTransit.ServiceBus.Services.Timeout.Messages
{
    using System;

    [Serializable]
    public class ScheduleTimeout :
        CorrelatedBy<Guid>
    {
        private Guid _correlationId;
        private DateTime _timeoutAt;

        protected ScheduleTimeout()
        {
        }

        public ScheduleTimeout(Guid correlationId, TimeSpan timeoutIn)
        {
            _correlationId = correlationId;
            _timeoutAt = DateTime.UtcNow + timeoutIn;
        }

        public ScheduleTimeout(Guid correlationId, DateTime timeoutAt)
        {
            _correlationId = correlationId;
            _timeoutAt = timeoutAt.ToUniversalTime();
        }

        public DateTime TimeoutAt
        {
            get { return _timeoutAt; }
            set { _timeoutAt = value; }
        }

        public Guid CorrelationId
        {
            get { return _correlationId; }
            set { _correlationId = value; }
        }
    }
}