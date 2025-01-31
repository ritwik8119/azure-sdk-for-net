﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.Data.SchemaRegistry
{
    /// <summary>
    /// Properties for a SchemaRegistry schema.
    /// </summary>
    public class SchemaProperties
    {
        internal SchemaProperties(string location, SchemaFormat format, string schemaId, int? schemaVersion)
        {
            Id = schemaId;
            Location = location;
            Format = format;
            Version = schemaVersion ?? 0;
        }

        /// <summary>
        /// The schema ID that uniquely identifies a schema in the registry namespace.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// The location of the schema.
        /// </summary>
        internal string Location { get; }

        /// <summary>
        /// Serialization type for the schema being stored.
        /// </summary>
        public SchemaFormat Format { get; }

        /// <summary>
        /// Version of the schema.
        /// </summary>
        internal int Version { get; }
    }
}
