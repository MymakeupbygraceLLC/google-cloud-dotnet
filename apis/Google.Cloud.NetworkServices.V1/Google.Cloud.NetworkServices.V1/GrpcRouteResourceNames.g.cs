// Copyright 2025 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

#pragma warning disable CS8981
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gcnv = Google.Cloud.NetworkServices.V1;
using sys = System;

namespace Google.Cloud.NetworkServices.V1
{
    /// <summary>Resource name for the <c>GrpcRoute</c> resource.</summary>
    public sealed partial class GrpcRouteName : gax::IResourceName, sys::IEquatable<GrpcRouteName>
    {
        /// <summary>The possible contents of <see cref="GrpcRouteName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/grpcRoutes/{grpc_route}</c>.
            /// </summary>
            ProjectLocationGrpcRoute = 1,
        }

        private static gax::PathTemplate s_projectLocationGrpcRoute = new gax::PathTemplate("projects/{project}/locations/{location}/grpcRoutes/{grpc_route}");

        /// <summary>Creates a <see cref="GrpcRouteName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="GrpcRouteName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static GrpcRouteName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new GrpcRouteName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="GrpcRouteName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/grpcRoutes/{grpc_route}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="grpcRouteId">The <c>GrpcRoute</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="GrpcRouteName"/> constructed from the provided ids.</returns>
        public static GrpcRouteName FromProjectLocationGrpcRoute(string projectId, string locationId, string grpcRouteId) =>
            new GrpcRouteName(ResourceNameType.ProjectLocationGrpcRoute, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), grpcRouteId: gax::GaxPreconditions.CheckNotNullOrEmpty(grpcRouteId, nameof(grpcRouteId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GrpcRouteName"/> with pattern
        /// <c>projects/{project}/locations/{location}/grpcRoutes/{grpc_route}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="grpcRouteId">The <c>GrpcRoute</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="GrpcRouteName"/> with pattern
        /// <c>projects/{project}/locations/{location}/grpcRoutes/{grpc_route}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string grpcRouteId) =>
            FormatProjectLocationGrpcRoute(projectId, locationId, grpcRouteId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GrpcRouteName"/> with pattern
        /// <c>projects/{project}/locations/{location}/grpcRoutes/{grpc_route}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="grpcRouteId">The <c>GrpcRoute</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="GrpcRouteName"/> with pattern
        /// <c>projects/{project}/locations/{location}/grpcRoutes/{grpc_route}</c>.
        /// </returns>
        public static string FormatProjectLocationGrpcRoute(string projectId, string locationId, string grpcRouteId) =>
            s_projectLocationGrpcRoute.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(grpcRouteId, nameof(grpcRouteId)));

        /// <summary>Parses the given resource name string into a new <see cref="GrpcRouteName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/grpcRoutes/{grpc_route}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="grpcRouteName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="GrpcRouteName"/> if successful.</returns>
        public static GrpcRouteName Parse(string grpcRouteName) => Parse(grpcRouteName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="GrpcRouteName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/grpcRoutes/{grpc_route}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="grpcRouteName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="GrpcRouteName"/> if successful.</returns>
        public static GrpcRouteName Parse(string grpcRouteName, bool allowUnparsed) =>
            TryParse(grpcRouteName, allowUnparsed, out GrpcRouteName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GrpcRouteName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/grpcRoutes/{grpc_route}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="grpcRouteName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GrpcRouteName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string grpcRouteName, out GrpcRouteName result) => TryParse(grpcRouteName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GrpcRouteName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/grpcRoutes/{grpc_route}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="grpcRouteName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GrpcRouteName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string grpcRouteName, bool allowUnparsed, out GrpcRouteName result)
        {
            gax::GaxPreconditions.CheckNotNull(grpcRouteName, nameof(grpcRouteName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationGrpcRoute.TryParseName(grpcRouteName, out resourceName))
            {
                result = FromProjectLocationGrpcRoute(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(grpcRouteName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private GrpcRouteName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string grpcRouteId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            GrpcRouteId = grpcRouteId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="GrpcRouteName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/grpcRoutes/{grpc_route}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="grpcRouteId">The <c>GrpcRoute</c> ID. Must not be <c>null</c> or empty.</param>
        public GrpcRouteName(string projectId, string locationId, string grpcRouteId) : this(ResourceNameType.ProjectLocationGrpcRoute, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), grpcRouteId: gax::GaxPreconditions.CheckNotNullOrEmpty(grpcRouteId, nameof(grpcRouteId)))
        {
        }

        /// <summary>The <see cref="ResourceNameType"/> of the contained resource name.</summary>
        public ResourceNameType Type { get; }

        /// <summary>
        /// The contained <see cref="gax::UnparsedResourceName"/>. Only non-<c>null</c> if this instance contains an
        /// unparsed resource name.
        /// </summary>
        public gax::UnparsedResourceName UnparsedResource { get; }

        /// <summary>
        /// The <c>GrpcRoute</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string GrpcRouteId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationGrpcRoute: return s_projectLocationGrpcRoute.Expand(ProjectId, LocationId, GrpcRouteId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as GrpcRouteName);

        /// <inheritdoc/>
        public bool Equals(GrpcRouteName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(GrpcRouteName a, GrpcRouteName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(GrpcRouteName a, GrpcRouteName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>BackendService</c> resource.</summary>
    public sealed partial class BackendServiceName : gax::IResourceName, sys::IEquatable<BackendServiceName>
    {
        /// <summary>The possible contents of <see cref="BackendServiceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/backendServices/{backend_service}</c>.
            /// </summary>
            ProjectLocationBackendService = 1,
        }

        private static gax::PathTemplate s_projectLocationBackendService = new gax::PathTemplate("projects/{project}/locations/{location}/backendServices/{backend_service}");

        /// <summary>Creates a <see cref="BackendServiceName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="BackendServiceName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static BackendServiceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new BackendServiceName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="BackendServiceName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/backendServices/{backend_service}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backendServiceId">The <c>BackendService</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="BackendServiceName"/> constructed from the provided ids.</returns>
        public static BackendServiceName FromProjectLocationBackendService(string projectId, string locationId, string backendServiceId) =>
            new BackendServiceName(ResourceNameType.ProjectLocationBackendService, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), backendServiceId: gax::GaxPreconditions.CheckNotNullOrEmpty(backendServiceId, nameof(backendServiceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BackendServiceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/backendServices/{backend_service}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backendServiceId">The <c>BackendService</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BackendServiceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/backendServices/{backend_service}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string backendServiceId) =>
            FormatProjectLocationBackendService(projectId, locationId, backendServiceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BackendServiceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/backendServices/{backend_service}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backendServiceId">The <c>BackendService</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BackendServiceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/backendServices/{backend_service}</c>.
        /// </returns>
        public static string FormatProjectLocationBackendService(string projectId, string locationId, string backendServiceId) =>
            s_projectLocationBackendService.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(backendServiceId, nameof(backendServiceId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="BackendServiceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/backendServices/{backend_service}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="backendServiceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="BackendServiceName"/> if successful.</returns>
        public static BackendServiceName Parse(string backendServiceName) => Parse(backendServiceName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="BackendServiceName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/backendServices/{backend_service}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="backendServiceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="BackendServiceName"/> if successful.</returns>
        public static BackendServiceName Parse(string backendServiceName, bool allowUnparsed) =>
            TryParse(backendServiceName, allowUnparsed, out BackendServiceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BackendServiceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/backendServices/{backend_service}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="backendServiceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BackendServiceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string backendServiceName, out BackendServiceName result) =>
            TryParse(backendServiceName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BackendServiceName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/backendServices/{backend_service}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="backendServiceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BackendServiceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string backendServiceName, bool allowUnparsed, out BackendServiceName result)
        {
            gax::GaxPreconditions.CheckNotNull(backendServiceName, nameof(backendServiceName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationBackendService.TryParseName(backendServiceName, out resourceName))
            {
                result = FromProjectLocationBackendService(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(backendServiceName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private BackendServiceName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string backendServiceId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            BackendServiceId = backendServiceId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="BackendServiceName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/backendServices/{backend_service}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backendServiceId">The <c>BackendService</c> ID. Must not be <c>null</c> or empty.</param>
        public BackendServiceName(string projectId, string locationId, string backendServiceId) : this(ResourceNameType.ProjectLocationBackendService, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), backendServiceId: gax::GaxPreconditions.CheckNotNullOrEmpty(backendServiceId, nameof(backendServiceId)))
        {
        }

        /// <summary>The <see cref="ResourceNameType"/> of the contained resource name.</summary>
        public ResourceNameType Type { get; }

        /// <summary>
        /// The contained <see cref="gax::UnparsedResourceName"/>. Only non-<c>null</c> if this instance contains an
        /// unparsed resource name.
        /// </summary>
        public gax::UnparsedResourceName UnparsedResource { get; }

        /// <summary>
        /// The <c>BackendService</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string BackendServiceId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationBackendService: return s_projectLocationBackendService.Expand(ProjectId, LocationId, BackendServiceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as BackendServiceName);

        /// <inheritdoc/>
        public bool Equals(BackendServiceName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(BackendServiceName a, BackendServiceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(BackendServiceName a, BackendServiceName b) => !(a == b);
    }

    public partial class GrpcRoute
    {
        /// <summary>
        /// <see cref="gcnv::GrpcRouteName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::GrpcRouteName GrpcRouteName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::GrpcRouteName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary><see cref="MeshName"/>-typed view over the <see cref="Meshes"/> resource name property.</summary>
        public gax::ResourceNameList<MeshName> MeshesAsMeshNames
        {
            get => new gax::ResourceNameList<MeshName>(Meshes, s => string.IsNullOrEmpty(s) ? null : MeshName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="GatewayName"/>-typed view over the <see cref="Gateways"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<GatewayName> GatewaysAsGatewayNames
        {
            get => new gax::ResourceNameList<GatewayName>(Gateways, s => string.IsNullOrEmpty(s) ? null : GatewayName.Parse(s, allowUnparsed: true));
        }

        public partial class Types
        {
            public partial class Destination
            {
                /// <summary>
                /// <see cref="BackendServiceName"/>-typed view over the <see cref="ServiceName"/> resource name
                /// property.
                /// </summary>
                public BackendServiceName ServiceNameAsBackendServiceName
                {
                    get => string.IsNullOrEmpty(ServiceName) ? null : BackendServiceName.Parse(ServiceName, allowUnparsed: true);
                    set => ServiceName = value?.ToString() ?? "";
                }
            }
        }
    }

    public partial class ListGrpcRoutesRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetGrpcRouteRequest
    {
        /// <summary>
        /// <see cref="gcnv::GrpcRouteName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::GrpcRouteName GrpcRouteName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::GrpcRouteName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateGrpcRouteRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteGrpcRouteRequest
    {
        /// <summary>
        /// <see cref="gcnv::GrpcRouteName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::GrpcRouteName GrpcRouteName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::GrpcRouteName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
