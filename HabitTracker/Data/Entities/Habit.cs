﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace HabitTracker.Data.Entities;

public class Habit
{
    [Key]
    public Guid Id { get; set; }

    public required string Title { get; set; }

    public string Description { get; set; } = string.Empty;

    public Guid ColorId { get; set; }

    public Color Color { get; set; } = null!;

    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }

    public bool IsCompleted { get; set; }

    public string UserId { get; set; } = string.Empty;
    public ApplicationUser User { get; set; } = null!;

    [JsonIgnore]

    public List<HabitFrequency> Frequencies { get; set; } = [];
    [JsonIgnore]
    public List<HabitRecord> Records { get; set; } = [];


    [NotMapped]
    public HabitRecord TodayRecord => Records.FirstOrDefault(r => r.Date.Date == DateTime.Now.Date) ?? new HabitRecord();

    [NotMapped]
    public int StreakMax => Records
        .Where(r => r.IsDone)
        .Select(r => r.Date.Date)
        .Aggregate((current, next) => current.AddDays(1) == next ? next : current)
        .Subtract(StartDate.Date)
        .Days;

    [NotMapped]
    public string HexCode => Color.Code;
}