using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Mission6App.Models;

public enum MovieRating
{
    G,
    PG,
    PG13,
    R
}
public class Application 
{
    
    public int ApplicationId { get; set; }
    [Microsoft.Build.Framework.Required]
    public string Category { get; set; }
    [Microsoft.Build.Framework.Required]
    public string Title { get; set; }
    [Microsoft.Build.Framework.Required]
    public string Director { get; set; }
    [Microsoft.Build.Framework.Required]
    public int Year { get; set; }
    [Microsoft.Build.Framework.Required]
    public MovieRating Rating { get; set; }
    [Microsoft.Build.Framework.Required]
    public bool? Edited { get; set; }
    public string? LentTo { get; set; }
    [Range(0,25)]
    public string? Notes { get; set; }
}