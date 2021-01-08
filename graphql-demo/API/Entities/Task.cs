﻿using System;

namespace API.Entities
{
    public sealed class Task
    {
        public Guid Id { get; set; }
        public bool IsDone { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}