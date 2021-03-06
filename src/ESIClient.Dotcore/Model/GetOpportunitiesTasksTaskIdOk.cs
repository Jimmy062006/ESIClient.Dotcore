/* 
 * EVE Swagger Interface
 *
 * An OpenAPI for EVE Online
 *
 * OpenAPI spec version: 1.3.8
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = ESIClient.Dotcore.Client.SwaggerDateConverter;

namespace ESIClient.Dotcore.Model
{
    /// <summary>
    /// 200 ok object
    /// </summary>
    [DataContract]
    public partial class GetOpportunitiesTasksTaskIdOk :  IEquatable<GetOpportunitiesTasksTaskIdOk>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetOpportunitiesTasksTaskIdOk" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetOpportunitiesTasksTaskIdOk() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetOpportunitiesTasksTaskIdOk" /> class.
        /// </summary>
        /// <param name="description">description string (required).</param>
        /// <param name="name">name string (required).</param>
        /// <param name="notification">notification string (required).</param>
        /// <param name="taskId">task_id integer (required).</param>
        public GetOpportunitiesTasksTaskIdOk(string description = default(string), string name = default(string), string notification = default(string), int? taskId = default(int?))
        {
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new InvalidDataException("description is a required property for GetOpportunitiesTasksTaskIdOk and cannot be null");
            }
            else
            {
                this.Description = description;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for GetOpportunitiesTasksTaskIdOk and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "notification" is required (not null)
            if (notification == null)
            {
                throw new InvalidDataException("notification is a required property for GetOpportunitiesTasksTaskIdOk and cannot be null");
            }
            else
            {
                this.Notification = notification;
            }
            // to ensure "taskId" is required (not null)
            if (taskId == null)
            {
                throw new InvalidDataException("taskId is a required property for GetOpportunitiesTasksTaskIdOk and cannot be null");
            }
            else
            {
                this.TaskId = taskId;
            }
        }
        
        /// <summary>
        /// description string
        /// </summary>
        /// <value>description string</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// name string
        /// </summary>
        /// <value>name string</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// notification string
        /// </summary>
        /// <value>notification string</value>
        [DataMember(Name="notification", EmitDefaultValue=false)]
        public string Notification { get; set; }

        /// <summary>
        /// task_id integer
        /// </summary>
        /// <value>task_id integer</value>
        [DataMember(Name="task_id", EmitDefaultValue=false)]
        public int? TaskId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetOpportunitiesTasksTaskIdOk {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Notification: ").Append(Notification).Append("\n");
            sb.Append("  TaskId: ").Append(TaskId).Append("\n");
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
            return this.Equals(input as GetOpportunitiesTasksTaskIdOk);
        }

        /// <summary>
        /// Returns true if GetOpportunitiesTasksTaskIdOk instances are equal
        /// </summary>
        /// <param name="input">Instance of GetOpportunitiesTasksTaskIdOk to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetOpportunitiesTasksTaskIdOk input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Notification == input.Notification ||
                    (this.Notification != null &&
                    this.Notification.Equals(input.Notification))
                ) && 
                (
                    this.TaskId == input.TaskId ||
                    (this.TaskId != null &&
                    this.TaskId.Equals(input.TaskId))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Notification != null)
                    hashCode = hashCode * 59 + this.Notification.GetHashCode();
                if (this.TaskId != null)
                    hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                return hashCode;
            }
        }
    }

}
