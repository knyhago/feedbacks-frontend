using System;
using Feedbackformfrontend.Models;

namespace Feedbackformfrontend.Components;

public class FormClient
{
    private List<FeedBack> feedbacks = new List<FeedBack>   
{
    new FeedBack
    {
        Id = 1,
        CompanyName = "TCS",
        JobTitle = "Software Developer",
        JobId = 100,
        Reasons = "Sponsorship" ,
        Details = "We got another candidate who can sponsor",
        AppliedOn = new DateOnly(2021, 10, 12)
    },
    new FeedBack
    {
        Id = 2,
        CompanyName = "Infosys",
        JobTitle = "Backend Engineer",
        JobId = 101,
        Reasons =  "Better Candidate",
        Details = "Found someone with more relevant project experience",
        AppliedOn = new DateOnly(2023, 5, 20)
    },
    new FeedBack
    {
        Id = 3,
        CompanyName = "Wipro",
        JobTitle = "Full Stack Developer",
        JobId = 102,
        Reasons =  "Skills Mismatch" ,
        Details = "Required expertise in React and .NET Core",
        AppliedOn = new DateOnly(2024, 2, 15)
    },
    new FeedBack
    {
        Id = 4,
        CompanyName = "Accenture",
        JobTitle = "Cloud Engineer",
        JobId = 103,
        Reasons ="Better Candidate",
        Details = "Candidate had more Azure certifications and hands-on projects",
        AppliedOn = new DateOnly(2024, 9, 5)
    },
    new FeedBack
    {
        Id = 5,
        CompanyName = "Capgemini",
        JobTitle = "Data Analyst",
        JobId = 104,
        Reasons = "Sponsorship", 
        Details = "Visa sponsorship requirements couldn't be met",
        AppliedOn = new DateOnly(2025, 1, 25)
    }
};

public async Task<List<FeedBack>> GetFeedback()=>[..feedbacks];

public void AddFeedback(FeedBack newData)
{
    newData.Id=feedbacks.Count()+1;
    feedbacks.Add(newData);
}

public void UpdateFeedback(FeedBack updatedGame)
    {
        FeedBack oldGame = FindFeedbackById(updatedGame.Id);

        oldGame.CompanyName = updatedGame.CompanyName;
        oldGame.JobTitle = updatedGame.JobTitle;
        oldGame.JobId = updatedGame.JobId;
        oldGame.Reasons = updatedGame.Reasons;
        oldGame.Details = updatedGame.Details;
        oldGame.AppliedOn = updatedGame.AppliedOn;

    }

    private FeedBack FindFeedbackById(int id)
    {
        return feedbacks.First(value => value.Id == id);
    }

    public void DeleteFeedback(int id)
    {
    var feedback = FindFeedbackById(id);

    feedbacks.Remove(feedback);     

    }


}
