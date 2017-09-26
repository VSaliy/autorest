// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace SharedHeaders.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Parameters supplied to the Create operation.
    /// </summary>
    public partial class BatchAccountCreateParameters
    {
        /// <summary>
        /// Initializes a new instance of the BatchAccountCreateParameters
        /// class.
        /// </summary>
        public BatchAccountCreateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BatchAccountCreateParameters
        /// class.
        /// </summary>
        /// <param name="location">The region in which to create the
        /// account.</param>
        /// <param name="tags">The user-specified tags associated with the
        /// account.</param>
        public BatchAccountCreateParameters(string location, IDictionary<string, string> tags = default(IDictionary<string, string>))
        {
            Location = location;
            Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the region in which to create the account.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the user-specified tags associated with the account.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Location == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Location");
            }
        }
    }
}
