// Copyright 2022 Confluent Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// Refer to LICENSE for more information.
using System.Collections.Generic;

namespace Confluent.Kafka.Admin
{
    /// <summary>
    ///     Represents the result of a describe consumer group operation.
    /// </summary>
    public class DescribeUserScramCredentialsReport
    {

        /// <summary>
        ///    Request Level Error
        /// </summary>
        public Error Error { get; set; }

        /// <summary>
        ///    Descriptions of various Users
        /// </summary>
        public List<UserScramCredentialsDescription> UserScramCredentialsDescriptions { get; set; }

        /// <summary>
        ///    Returns a human readable representation of this object.
        /// </summary>
        public override string ToString() {
            string res = "DescribeUserScramCredentialsReport\n";
            
            return res;
        }
    }
}