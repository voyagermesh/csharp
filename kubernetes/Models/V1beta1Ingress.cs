using k8s.Models;

// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace com.appscode.voyager.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Custom Ingress type for Voyager.
    /// </summary>
    public partial class V1beta1Ingress
    {
        /// <summary>
        /// Initializes a new instance of the V1beta1Ingress class.
        /// </summary>
        public V1beta1Ingress()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1beta1Ingress class.
        /// </summary>
        /// <param name="apiVersion">APIVersion defines the versioned schema of
        /// this representation of an object. Servers should convert recognized
        /// schemas to the latest internal value, and may reject unrecognized
        /// values. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</param>
        /// <param name="kind">Kind is a string value representing the REST
        /// resource this object represents. Servers may infer this from the
        /// endpoint the client submits requests to. Cannot be updated. In
        /// CamelCase. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</param>
        /// <param name="metadata">Standard object's metadata. More info:
        /// http://releases.k8s.io/release-1.2/docs/devel/api-conventions.md#metadata</param>
        /// <param name="spec">Spec is the desired state of the Ingress. More
        /// info:
        /// http://releases.k8s.io/release-1.2/docs/devel/api-conventions.md#spec-and-status</param>
        /// <param name="status">Status is the current state of the Ingress.
        /// More info:
        /// http://releases.k8s.io/release-1.2/docs/devel/api-conventions.md#spec-and-status</param>
        public V1beta1Ingress(string apiVersion = default(string), string kind = default(string), k8s.Models.V1ObjectMeta metadata = default(k8s.Models.V1ObjectMeta), V1beta1IngressSpec spec = default(V1beta1IngressSpec), V1beta1IngressStatus status = default(V1beta1IngressStatus))
        {
            ApiVersion = apiVersion;
            Kind = kind;
            Metadata = metadata;
            Spec = spec;
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets aPIVersion defines the versioned schema of this
        /// representation of an object. Servers should convert recognized
        /// schemas to the latest internal value, and may reject unrecognized
        /// values. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#resources
        /// </summary>
        [JsonProperty(PropertyName = "apiVersion")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Gets or sets kind is a string value representing the REST resource
        /// this object represents. Servers may infer this from the endpoint
        /// the client submits requests to. Cannot be updated. In CamelCase.
        /// More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Gets or sets standard object's metadata. More info:
        /// http://releases.k8s.io/release-1.2/docs/devel/api-conventions.md#metadata
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public k8s.Models.V1ObjectMeta Metadata { get; set; }

        /// <summary>
        /// Gets or sets spec is the desired state of the Ingress. More info:
        /// http://releases.k8s.io/release-1.2/docs/devel/api-conventions.md#spec-and-status
        /// </summary>
        [JsonProperty(PropertyName = "spec")]
        public V1beta1IngressSpec Spec { get; set; }

        /// <summary>
        /// Gets or sets status is the current state of the Ingress. More info:
        /// http://releases.k8s.io/release-1.2/docs/devel/api-conventions.md#spec-and-status
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public V1beta1IngressStatus Status { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Metadata != null)
            {
                Metadata.Validate();
            }
            if (Spec != null)
            {
                Spec.Validate();
            }
        }
    }
}
