/* 
 * LocationIQ
 *
 * LocationIQ provides flexible enterprise-grade location based solutions. We work with developers, startups and enterprises worldwide serving billions of requests everyday. This page provides an overview of the technical aspects of our API and will help you get started.
 *
 * The version of the OpenAPI document: 1.1.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// DirectionsNearest
    /// </summary>
    [DataContract]
    public partial class DirectionsNearest :  IEquatable<DirectionsNearest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DirectionsNearest" /> class.
        /// </summary>
        /// <param name="code">code.</param>
        /// <param name="waypoints">waypoints.</param>
        public DirectionsNearest(string code = default(string), List<DirectionsNearestWaypoints> waypoints = default(List<DirectionsNearestWaypoints>))
        {
            this.Code = code;
            this.Waypoints = waypoints;
        }
        
        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets Waypoints
        /// </summary>
        [DataMember(Name="waypoints", EmitDefaultValue=false)]
        public List<DirectionsNearestWaypoints> Waypoints { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DirectionsNearest {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Waypoints: ").Append(Waypoints).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DirectionsNearest);
        }

        /// <summary>
        /// Returns true if DirectionsNearest instances are equal
        /// </summary>
        /// <param name="input">Instance of DirectionsNearest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DirectionsNearest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Waypoints == input.Waypoints ||
                    this.Waypoints != null &&
                    input.Waypoints != null &&
                    this.Waypoints.SequenceEqual(input.Waypoints)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Waypoints != null)
                    hashCode = hashCode * 59 + this.Waypoints.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}