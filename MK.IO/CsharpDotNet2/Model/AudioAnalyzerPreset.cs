using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class AudioAnalyzerPreset {
    /// <summary>
    /// The language for the audio payload in the input using the BCP-47 format of 'language tag-region' (e.g: 'en-US')
    /// </summary>
    /// <value>The language for the audio payload in the input using the BCP-47 format of 'language tag-region' (e.g: 'en-US')</value>
    [DataMember(Name="audioLanguage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "audioLanguage")]
    public string AudioLanguage { get; set; }

    /// <summary>
    /// Dictionary containing key value pairs for parameters not exposed in the preset itself
    /// </summary>
    /// <value>Dictionary containing key value pairs for parameters not exposed in the preset itself</value>
    [DataMember(Name="experimentalOptions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "experimentalOptions")]
    public Dictionary<string, Object> ExperimentalOptions { get; set; }

    /// <summary>
    /// Determines the set of audio analysis operations to be performed. If unspecified, the Standard AudioAnalysisMode would be chosen.
    /// </summary>
    /// <value>Determines the set of audio analysis operations to be performed. If unspecified, the Standard AudioAnalysisMode would be chosen.</value>
    [DataMember(Name="mode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mode")]
    public string Mode { get; set; }

    /// <summary>
    /// The discriminator for derived types.
    /// </summary>
    /// <value>The discriminator for derived types.</value>
    [DataMember(Name="odatatype", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "odatatype")]
    public string Odatatype { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AudioAnalyzerPreset {\n");
      sb.Append("  AudioLanguage: ").Append(AudioLanguage).Append("\n");
      sb.Append("  ExperimentalOptions: ").Append(ExperimentalOptions).Append("\n");
      sb.Append("  Mode: ").Append(Mode).Append("\n");
      sb.Append("  Odatatype: ").Append(Odatatype).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}