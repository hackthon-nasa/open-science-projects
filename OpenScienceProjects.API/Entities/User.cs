﻿namespace OpenScienceProjects.API.Entities;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public DateOnly BirthDate { get; set; }
    public string Description { get; set; }
    public virtual IList<UserSkill> UserSkills { get; set; }
    public virtual IList<UserInterest> UserInterests { get; set; }
}