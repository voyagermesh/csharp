// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace com.appscode.voyager.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class V1beta1AuthOption
    {
        /// <summary>
        /// Initializes a new instance of the V1beta1AuthOption class.
        /// </summary>
        public V1beta1AuthOption()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1beta1AuthOption class.
        /// </summary>
        public V1beta1AuthOption(V1beta1BasicAuth basic = default(V1beta1BasicAuth), V1beta1TLSAuth tls = default(V1beta1TLSAuth))
        {
            Basic = basic;
            Tls = tls;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "basic")]
        public V1beta1BasicAuth Basic { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tls")]
        public V1beta1TLSAuth Tls { get; set; }

    }
}
