using System;
using System.ComponentModel.DataAnnotations;

namespace Feedbackformfrontend.Models;

public class FeedBack
{
    public int Id { get; set; }
    [Required]
    public string? CompanyName { get; set; }
    [Required]
    public string? JobTitle { get; set; }
    public int JobId { get; set; }
    
    [Required]
    public required string Reasons { get; set; }

    public string? Details { get; set; }

    public DateOnly AppliedOn { get; set; }


};
