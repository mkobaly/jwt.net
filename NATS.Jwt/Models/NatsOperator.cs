using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NATS.Jwt.Models;

public record NatsOperator : NatsGenericFields
{
    /// <summary>
    /// List of other operator NKeys that can be used to sign on behalf of the main
    /// operator identity.
    /// </summary>
    [JsonPropertyName("signing_keys")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public List<string> SigningKeys { get; set; }

    /// <summary>
    /// AccountServerURL is a partial URL like "https://host.domain.org:<c>port</c>/jwt/v1"
    /// tools will use the prefix and build queries by appending /accounts/<c>account_id</c>
    /// or /operator to the path provided. Note this assumes that the account server
    /// can handle requests in a nats-account-server compatible way. See
    /// https://github.com/nats-io/nats-account-server for an example.
    /// </summary>
    [JsonPropertyName("account_server_url")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public string AccountServerURL { get; set; }

    /// <summary>
    /// A list of NATS urls (tls://host:port) where tools can connect to the server
    /// using proper credentials.
    /// </summary>
    [JsonPropertyName("operator_service_urls")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public List<string> OperatorServiceURLs { get; set; }

    /// <summary>
    /// Identity of the system account
    /// </summary>
    [JsonPropertyName("system_account")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public string SystemAccount { get; set; }

    /// <summary>
    /// Min Server version
    /// </summary>
    [JsonPropertyName("assert_server_version")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public string AssertServerVersion { get; set; }

    /// <summary>
    /// Signing of subordinate objects will require signing keys
    /// </summary>
    [JsonPropertyName("strict_signing_key_usage")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public bool StrictSigningKeyUsage { get; set; }
}
