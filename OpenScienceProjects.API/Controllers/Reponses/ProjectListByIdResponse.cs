﻿using System.Text.Json.Serialization;

namespace OpenScienceProjects.API.Controllers.Reponses;

public class ProjectListByIdResponse
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("description")]
    public string Description { get; set; }
    [JsonPropertyName("description")]
    public int OrganizationId { get; set; }
    [JsonPropertyName("tag_ids")]
    public List<int> TagIds { get; set; } = new List<int>();
}