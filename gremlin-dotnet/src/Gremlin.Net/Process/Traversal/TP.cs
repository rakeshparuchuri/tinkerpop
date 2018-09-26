#region License

/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

#endregion

// THIS IS A GENERATED FILE - DO NOT MODIFY THIS FILE DIRECTLY - see pom.xml
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Gremlin.Net.Process.Traversal
{
#pragma warning disable 1591

    /// <summary>
    ///     A <see cref="TP" /> is a predicate of the form Func&lt;string, bool&gt;.
    ///     That is, given some string, return true or false.
    /// </summary>
    public class TP : P
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="P" /> class.
        /// </summary>
        /// <param name="operatorName">The name of the predicate.</param>
        /// <param name="value">The value of the predicate.</param>
        /// <param name="other">An optional other predicate that is used as an argument for this predicate.</param>
        public TP(string operatorName, string value, P other = null) : base(operatorName, value, other)
        {
        }


        public static TP Absent(string value)
        {
            return new TP("absent", value);
        }

        public static TP Contains(string value)
        {
            return new TP("contains", value);
        }

        public static TP EndsNotWith(string value)
        {
            return new TP("endsNotWith", value);
        }

        public static TP EndsWith(string value)
        {
            return new TP("endsWith", value);
        }

        public static TP StartsNotWith(string value)
        {
            return new TP("startsNotWith", value);
        }

        public static TP StartsWith(string value)
        {
            return new TP("startsWith", value);
        }


        private static T[] ToGenericArray<T>(ICollection<T> collection)
        {
            return collection?.ToArray() ?? new T[0];
        }

        /// <inheritdoc />
        public override string ToString()
        {
            return Other == null ? $"{OperatorName}({Value})" : $"{OperatorName}({Value},{Other})";
        }
    }

#pragma warning restore 1591
}