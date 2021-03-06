// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Zapappi.Client.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class SMSQueueItem
    {
        /// <summary>
        /// Initializes a new instance of the SMSQueueItem class.
        /// </summary>
        public SMSQueueItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SMSQueueItem class.
        /// </summary>
        public SMSQueueItem(string number = default(string), string id = default(string), string messageBody = default(string), string cLID = default(string), string dDI = default(string), System.DateTime? received = default(System.DateTime?), string uniqueID = default(string), string croppedBody = default(string))
        {
            Number = number;
            Id = id;
            MessageBody = messageBody;
            CLID = cLID;
            DDI = dDI;
            Received = received;
            UniqueID = uniqueID;
            CroppedBody = croppedBody;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Number")]
        public string Number { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MessageBody")]
        public string MessageBody { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CLID")]
        public string CLID { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DDI")]
        public string DDI { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Received")]
        public System.DateTime? Received { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UniqueID")]
        public string UniqueID { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CroppedBody")]
        public string CroppedBody { get; private set; }

    }
}
