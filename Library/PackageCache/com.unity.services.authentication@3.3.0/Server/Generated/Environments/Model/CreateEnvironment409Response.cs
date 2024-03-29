
//-----------------------------------------------------------------------------
// <auto-generated>
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using UnityEngine.Scripting;
using Unity.Services.Authentication.Server.Shared;

namespace Unity.Services.Authentication.Server.Environments.Generated
{
    /// <summary>
    /// CreateEnvironment409Response
    /// </summary>
    [DataContract(Name = "create_environment_409_response")]
    [Preserve]
    internal partial class CreateEnvironment409Response
    {
        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        [Preserve]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        [Preserve]
        public int Status { get; set; }

        /// <summary>
        /// Gets or Sets Detail
        /// </summary>
        [DataMember(Name = "detail", EmitDefaultValue = false)]
        [Preserve]
        public string Detail { get; set; }

        /// <summary>
        /// Gets or Sets RequestId
        /// </summary>
        [DataMember(Name = "requestId", EmitDefaultValue = false)]
        [Preserve]
        public string RequestId { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEnvironment409Response" /> class.
        /// </summary>
        /// <param name="title">title.</param>
        /// <param name="status">status.</param>
        /// <param name="detail">detail.</param>
        /// <param name="requestId">requestId.</param>
        [Preserve]
        public CreateEnvironment409Response(string title = default(string), int status = default(int), string detail = default(string), string requestId = default(string))
        {
            this.Title = title;
            this.Status = status;
            this.Detail = detail;
            this.RequestId = requestId;
        }
    }

}
